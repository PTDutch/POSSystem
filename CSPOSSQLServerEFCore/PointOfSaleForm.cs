using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSPOSSQLServerEFCore.Models.Db;

namespace CSPOSSQLServerEFCore
{
    public partial class PointOfSaleForm : Form
    {
        public PointOfSaleForm()
        {
            InitializeComponent();

            timer1.Enabled = true; //จริงๆเปิดไว้แล้วแต่เขียนcodeอีกรอบ
            timer1.Interval = 1000;

            //จริงๆมีการกำหนด properties บางส่วนไว้ที่หน้า properties window ไว้แล้ว แต่เขียนโค้ดกันไว้อีกที
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;//เลือกได้แถวเดียว
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

        }

        CSEFCorePOSDBContext db = new CSEFCorePOSDBContext();

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void PointOfSaleForm_Load(object sender, EventArgs e)
        {
            currentDateTextBox.Text = DateTime.Now.ToString();

            //ดึงมาตอนสร้างระบบ login (ยังไม่ทำ)
            employeeIDTextBox.Text = "1";
            employeeNameTextBox.Text = "Sadutch Yanai";

            customerIDTextBox.Text = "-";
            customerNameTextBox.Text = "-";

            toolStripStatusLabel1.Text = String.Format("Hello, {0}!", "Sadutch Yanai");

            //สร้าง string array มาเป็นหัวการสร้าง DataGriView
            string[] header = new[] { "ID", "Barcode", "Product Name", "Selling Price", "Quantity", "Subtotal" };
            dataGridView1.ColumnCount = header.Length; //6 //บอกว่า DataGV มีกี่ column

            for (var i = 0; i <= header.Length - 1; i++) //เริ่มจากศูนย์ ลบหนึ่งด้วย
            {
                dataGridView1.Columns[i].HeaderText = header[i]; //[i]ตัวนับ
            }

            //กำหนดความกว้างแต่ละ column
            var dgv = dataGridView1;
            dgv.ColumnHeadersHeight = 35;
            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 180;
            dgv.Columns[2].Width = 250;
            dgv.Columns[3].Width = 200;
            dgv.Columns[4].Width = 100;
            dgv.Columns[5].Width = 200;

            //จัดรูปแบบ column ว่าชิดซ้านหรือขวา
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            NewButton.PerformClick();
        }

        private void PointOfSaleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ประกาศตัวแปรต่างๆมาใช้กับ message box
            string msg = "Do you want to close this form?";
            string caption = "Closing from : Dutcheang.";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            MessageBoxIcon ico = MessageBoxIcon.Question;

            DialogResult result; //ใช้ DialoResult มาเช็คว่ากดปุ่ม yes หริอไม่
            if (dataGridView1.Rows.Count > 0) //เงื่อไขถ้าเราไม่ได้ยิง barcode จะปิดไปเลย
            {
                result = MessageBox.Show(this, msg, caption, btn, ico); //ถ้ายิงิbarcodeมาแล้วจะถาม
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        string referenceNo = "";// ใช้ในการกำหนดเลขที่ใบเสร็จ
        private void NewButton_Click(object sender, EventArgs e) //จะทำ transaction
        {
            try
            {
                if (NewButton.Text.Trim() == "New...")
                {
                    NewButton.Text = "Cancel";
                    // Generate Custom Sales ID
                    generateCustomSalesID();
                }
                else
                {
                    NewButton.Text = "New...";
                    transactionIDTextBox.Clear();
                    referenceNo = "";
                    dataGridView1.Rows.Clear();
                }

                barcodeTextBox.Clear();
                barcodeTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "New Button : Dutcheang",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateCustomSalesID() //เขียนโค้ดสร้างเลขที่ใบเสร็จแบบกดหนดเเองตรงนี้
        {
            //ในเลขที่ใบเสร็จ จะมีวันเดือนปีสร้างตัวแปรมารับ
            string currentDate = DateTime.Now.ToString("ddMMyyyy");
            //การดึงข้อมูลเป็นกลุ่มในปีปัจจุบัน
            var group = from s in db.Sales
                        where s.SaleDate.Value.Year == DateTime.Now.Year
                        group s by s.SaleDate.Value.Year into g //จัดกลุ่มตามปีที่ขาย
                        select new
                        {
                            sDate = g.Key,
                            MaxRefID = g.Max(s => s.SaleReferenceNo) //ดึงค่าตัวเลขสูดสุดที่เก็บไว้ในปีนั้นนำมาเเป็น ID
                        };
            //เช็คว่ามีค่า null มั้ยถ้าไม่มีค่ามูลกำหนดเป็นหนึ่ง แต่ถ้ามีข้อมูลMAXก็มาบวกเพิ่มนึ่ง
            if (group != null)
            {
                if (group.Count() > 0)//เช็คจากแถว แสดงว่ามีข้อมูลแล้ว
                {
                    int newID = group.FirstOrDefault().MaxRefID;
                    newID += 1;
                    transactionIDTextBox.Text = "Sale" + currentDate + newID.ToString("000000");
                    referenceNo = Convert.ToString(newID);
                }
                else //แสดงว่าไม่มีข้อมูลในปีนั้นๆยังไม่มีการขายเกิดขึ้น
                {
                    int intID = 1;
                    transactionIDTextBox.Text = "Sale" + currentDate + intID.ToString("000000");
                    referenceNo = Convert.ToString(intID); //
                }
            }

        }

        private void barcodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //การทำงานกับ eventKeyDown ต้องปิดเสียง windows
            try
            {
                if (e.KeyCode == Keys.Enter) //เช็คว่าเราเคาะ enter รึเปล่า
                {
                    //Disable Widows Sound
                    e.SuppressKeyPress = true;
                    if (string.IsNullOrEmpty(barcodeTextBox.Text.Trim())) //เช็ค barcode มีค่าว่างหรือไม่
                    {
                        return;
                    }

                    if (string.IsNullOrEmpty(transactionIDTextBox.Text.Trim())) //มีการกดปุ่ม New... ยัง
                    {
                        return;
                    }

                    //เงื่อนไขต่างๆผ่านดึงขอมูลสินค้ามาแสดง  DataGridViiew
                    searchProduct(barcodeTextBox.Text.Trim(), false);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Barcode TextBox KeyDown",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculateTotalAmount()
        {

            try
            {
                double amount = 0;
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    amount += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value); //เป็นค่าทางการเงินต้อง convert
                }

                totalAmountTextBox.Text = amount.ToString();

                double numFomat = Convert.ToDouble(totalAmountTextBox.Text);
                totalAmountTextBox.Text = numFomat.ToString("##,##0.00"); //จัดรูปแบบทางการเงิน

                //barcodeTextBox.Focus();
                //barcodeTextBox.Select();
                //barcodeTextBox.SelectAll();

                center.focusTexBox(barcodeTextBox);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Calculate Total Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchProduct(string barcode, bool b)
        {
            try
            {
                //การ search สิ้นค้าที่เราต้องการนั้นต้องตรงกับสิ้นค้าที่เรายิงไปใน barcodeTextBox ยิงbcตัวไหนมาค้นในตาราง product ว่าbcตัวไหนตรงก็นำมาแสดง dataGV
                var data = from c in db.Products
                           where c.ProductBarcode.Trim() == barcode.Trim()
                           select new
                           {
                               ProductID = c.ProductId,
                               ProductBarcode = c.ProductBarcode,
                               ProductName = c.ProductName,
                               sellingPrice = c.SellingPrice,
                               UnitsInStock = c.UnitInStock
                           };
                //เช็คว่า data เป็นค่า null รึเปล่า
                if (data != null)
                {
                    if (data.Count() > 0) // กรณีที่ search แล้วเจอสินค้า //ทำการดึงข้อมุลมาแสดงบน TextBox ต่่างๆ
                    {
                        productIDTextBox.Text = data.FirstOrDefault().ProductID.ToString();
                        productBarcodeTextBox.Text = data.FirstOrDefault().ProductBarcode.ToString();
                        productNameTextBox.Text = data.FirstOrDefault().ProductName.ToString();

                        double numFomat = Convert.ToDouble(data.FirstOrDefault().sellingPrice.ToString());
                        sellingPriceTextBox.Text = numFomat.ToString("##,##0.00"); //จัดรูปแบบทางการเงิน

                        unitsInStockTextBox.Text = data.FirstOrDefault().UnitsInStock.ToString();

                        int maxNum = Convert.ToInt32(unitsInStockTextBox.Text.Trim());
                        numericUpDown1.Maximum = maxNum;

                        if (maxNum > 0)
                        {
                            //default
                            numericUpDown1.Value = 1;
                        }

                    }
                    else //ถ้าไม่มีข้อมูล //กรณีที่ search แล้วไม่เจอสินค้า
                    {
                        productIDTextBox.Clear();
                        productBarcodeTextBox.Clear();
                        productNameTextBox.Clear();
                        sellingPriceTextBox.Text = "0"; //ค่า int 
                        unitsInStockTextBox.Text = "0";

                        numericUpDown1.Value = 0;
                        numericUpDown1.Maximum = 0;

                        MessageBox.Show("Your search dit not math any producth.", "No Products Found.",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //barcodeTextBox.Clear();
                        //barcodeTextBox.Focus(); //หลังจากยิง bc ไม่เจอทำการโฟกัสที่ bcTextbox
                        //barcodeTextBox.Select();
                        //barcodeTextBox.SelectAll();
                        center.focusTexBox(barcodeTextBox);

                        return;
                    }
                }

                //check if parameter bool b is true of flase
                if (b == true) //มีการ doublecheck ที่ DataGV แล้วแสดงข้อมูลมายังส่วนของ product คือการcheckเพื่อดูข้อมูลนั้นเอง
                {
                    return;
                }

                //but if it's shooting a barcode
                var us = unitsInStockTextBox.Text.Trim(); //Check the number of products
                if (Convert.ToDouble(us) < 1) //เป็นการช็คยอดคงเหลือเพราะสินค้าที่เราขายได้ต้องมากกว่าหนึ่ง
                {
                    MessageBox.Show("This item is temporatily out of stock.", "Out of Stock",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //barcodeTextBox.Focus();
                    //barcodeTextBox.Select();
                    //barcodeTextBox.SelectAll();
                    center.focusTexBox(barcodeTextBox);
                    return;
                }

                if (dataGridView1.Rows.Count == 0)//แต่ถ้าสินค้ามีอยู่ให้ทำการเพิ่มไปที่ DataGV1 
                {
                    double subTotal = Convert.ToDouble(sellingPriceTextBox.Text) * (int)numericUpDown1.Value;
                    dataGridView1.Rows.Add(productIDTextBox.Text, productBarcodeTextBox.Text, productNameTextBox.Text,
                        sellingPriceTextBox.Text, numericUpDown1.Value.ToString(), subTotal);
                    calculateTotalAmount();
                    return;
                }
                else
                {
                    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                    {
                        if (productBarcodeTextBox.Text.Trim() == dataGridView1.Rows[i].Cells[1].Value.ToString()) //กรณียิงbarcodeตัวเดิม
                        {
                            if (Convert.ToInt32(unitsInStockTextBox.Text.Trim()) <=
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value)) //ยอดที่ยิงมานั้นเกินจำนวนในstockรึเปล่า //กันไม่ให้กิน
                            {
                                MessageBox.Show("This item is temporatily out of stock.", "Out of Stock",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //barcodeTextBox.Focus();
                                //barcodeTextBox.Select();
                                //barcodeTextBox.SelectAll();
                                center.focusTexBox(barcodeTextBox);
                                return;
                            }
                            else
                            {
                                //คำนวณ subtotal
                                double price = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value); //selling Price
                                double qty = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value); //Quantity

                                qty += 1; //กรณีบาร์โค้ดตัวดิม เหมือนยิง 5 ครั้งก็จะบวกไปรื่อยๆ
                                dataGridView1.Rows[i].Cells[4].Value = qty; //Quantity

                                // subtotal
                                dataGridView1.Rows[i].Cells[5].Value = price * qty;

                                calculateTotalAmount(); //คำนวณยอดรวมทั้งหมด
                                return;
                            }
                        }
                    }
                    //กรณี Barcode ตัวอื่นไม่ซ้ำ
                    double subTotal = Convert.ToDouble(sellingPriceTextBox.Text.Trim()) * (int)numericUpDown1.Value;
                    dataGridView1.Rows.Add(productIDTextBox.Text, productBarcodeTextBox.Text, productNameTextBox.Text,
                        sellingPriceTextBox.Text, numericUpDown1.Value.ToString(), subTotal);

                    int rowIdx = dataGridView1.Rows.Count - 1; //เลือก DataGV1 ที่ยิงล่าสุด
                    int colIdx = 0; //checkว่าให้เเลือก columnไหน

                    dataGridView1.Rows[rowIdx].Selected = true;
                    dataGridView1.Rows[rowIdx].Cells[colIdx].Selected = true;

                    dataGridView1.FirstDisplayedScrollingRowIndex = rowIdx;

                    calculateTotalAmount();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "search Product Method", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) //แสดงว่ามีการclickเลือกแถวใดแถวนึง
            {
                //ดึงbarcodeจาก dataGV มา
                var barcode = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                searchProduct(barcode.ToString(), true); //ส่ง true ไปเพระาตอนยิง Barcode เป็นค่า false แต่ตอน double เป็นค่า 

            }
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;//ปิดเสียง

                if (string.IsNullOrEmpty(productBarcodeTextBox.Text.Trim())) //check productBarcode must not be null
                {
                    return; //ถ้าเป็นค่าว่างก็ออก

                }

                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    if (productBarcodeTextBox.Text.Trim() == dataGridView1.Rows[i].Cells[1].Value.ToString())
                    {
                        if (Convert.ToUInt32(unitsInStockTextBox.Text.Trim()) < Convert.ToInt32(numericUpDown1.Value))
                        {
                            MessageBox.Show("This item is temporatily out of stock.", "Out of Stock",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //barcodeTextBox.Focus();
                            //barcodeTextBox.Select();
                            //barcodeTextBox.SelectAll();
                            center.focusTexBox(barcodeTextBox);
                            return;
                        }
                        else //ถ้าไม่เกิน สินค้ายังมีอยู่
                        {
                            //คำนวณ subtotal
                            double price = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value); //selling Price
                            int qty = Convert.ToInt32(numericUpDown1.Value); //Quantity

                            dataGridView1.Rows[i].Cells[4].Value = qty; //Quantity

                            // Updaesubtotal
                            dataGridView1.Rows[i].Cells[5].Value = price * qty;

                            calculateTotalAmount(); //คำนวณยอดรวมทั้งหมด

                            return;
                        }
                    }
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //ใช้สำหรับการลบข้อมูลออกจาก DataGV
            try
            {
                //การลบแถว
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    calculateTotalAmount(); //พอลบแล้วก็ต้องมีการคำนวณใหม่
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Remove Button Click.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void totalAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            tenderedTextBox.Clear();
            changeTextBox.Clear();
        }

        private void tenderedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(totalAmountTextBox.Text.Trim()) &&
                    !(Convert.ToDouble(totalAmountTextBox.Text.Trim()) < 1))
                {
                    if (!string.IsNullOrEmpty(tenderedTextBox.Text.Trim()))
                    {
                        //คำนวณเงินทอน
                        double chang = Convert.ToDouble(tenderedTextBox.Text.Trim()) -
                            Convert.ToDouble(totalAmountTextBox.Text.Trim());
                        changeTextBox.Text = chang.ToString();
                    }
                    else
                    {
                        changeTextBox.Clear();
                    }
                }
                else
                {
                    //totalAmount เป็นค่าว่าง
                    tenderedTextBox.Clear();
                    changeTextBox.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Tendered TextBox TextChanged.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tenderedTextBox.Clear();
                changeTextBox.Clear();
                tenderedTextBox.Focus();
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var dgv = dataGridView1;
            //เช็คว่ามีแถวข้อมูลหรือไม่ //ไม่ยอมให้บันทึกข้อมูลถ้า dataGV ไม่มีข้อมูลสินค้า
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Please add one or more item to the list.", "Saving data : Dutcheang.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                center.focusTexBox(barcodeTextBox);
                return;
            }

            //เช็คว่ามีการป้อนข้อมูลการรับเงินมาหรือยัง
            if (string.IsNullOrEmpty(tenderedTextBox.Text.Trim()) ||
                Convert.ToDouble(tenderedTextBox.Text.Trim()) < Convert.ToDouble(totalAmountTextBox.Text.Trim()))
            {
                MessageBox.Show("Enter Cash Amount.", "Saving data : Dutcheang.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                tenderedTextBox.Clear();
                changeTextBox.Text = "";

                center.focusTexBox(barcodeTextBox);
                return;
            }

            using (var tr = db.Database.BeginTransaction())
            {
                try
                {
                    //ดึงข้อมูลมาเก็บไว้ในตัวแปรที่ประกาศไว้ที่ class.center
                    center.saleReceiptId = transactionIDTextBox.Text.Trim();
                    center.saleReferenceNo = Convert.ToInt32(referenceNo);
                    center.empID = Convert.ToInt32(employeeIDTextBox.Text.Trim());
                    center.cusID = 0; //Convert.ToInt32(customerIDTextBox.Text.Trim());

                    decimal total = Convert.ToDecimal(totalAmountTextBox.Text.Trim());
                    decimal tendered = Convert.ToDecimal(tenderedTextBox.Text.Trim());
                    decimal change =  Convert.ToDecimal(changeTextBox.Text.Trim()); //0;

                    string msg = "Do you want to continue?";
                    string caption = "Save data : Dutcheang.";
                    MessageBoxButtons btn = MessageBoxButtons.YesNo;
                    MessageBoxIcon ico = MessageBoxIcon.Question;

                    DialogResult result;
                    result = MessageBox.Show(this, msg, caption, btn, ico);

                    if (result == DialogResult.Yes)
                    {
                        Sale sa = new Sale();

                        sa.SaleId = center.saleReceiptId;
                        sa.SaleReferenceNo = center.saleReferenceNo;
                        sa.EmployeeId = center.empID;
                        sa.CustomerId = center.cusID;
                        sa.SaleTotal = total;
                        sa.SaleReceive = tendered;
                        sa.SaleChange = change;

                        SaleDetail sas;
                        for(int i =0; i <= dgv.Rows.Count - 1; i++)
                        {

                            string proID = dgv.Rows[i].Cells[0].Value.ToString(); //Product ID
                            string barcode = dgv.Rows[i].Cells[1].Value.ToString(); //Product Barcode
                            string proName = dgv.Rows[i].Cells[2].Value.ToString(); //Product Name
                            decimal proPrice = Convert.ToDecimal(dgv.Rows[i].Cells[3].Value.ToString()); //Selling price
                            double proQty = Convert.ToDouble(dgv.Rows[i].Cells[4].Value.ToString()); //Quantity
                            decimal subTotal = Convert.ToDecimal(dgv.Rows[i].Cells[5].Value.ToString()); //subtotal

                            sas =  new SaleDetail();
                            sas.SaleId = center.saleReceiptId;
                            sas.ProductId = Convert.ToInt32(proID);
                            sas.ProductName = proName;
                            sas.ProductPrice = proPrice; 
                            sas.ProductQuantity = proQty;
                            sas.Subtotal = subTotal;

                            //เพิ่ม sas เข้าไปในตาราง SaleDetails
                            db.SaleDetails.Add(sas);

                            //Update stock.
                            var proData = (from p in db.Products
                                           where p.ProductBarcode == barcode
                                           select p).FirstOrDefault();

                            if(proData != null )
                            {
                                //เช็คจำนวนสินค้าของเหลือ UnitsInStock
                                proData.UnitInStock = proData.UnitInStock - proQty;

                            }

                        } // End For Loop.

                        //บันทึกข้อมูลลงตาราง Sales
                        db.Sales.Add(sa);

                        db.SaveChanges();
                        tr.Commit();

                        MessageBox.Show("Save Successfully!", "Saveing data : Dutcheang.",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        totalAmountTextBox.Clear();
                        tenderedTextBox.Clear();
                        changeTextBox.Clear();

                        dgv.Rows.Clear();

                        TextBox txt;
                        foreach (Control ctrl in groupBox3.Controls)
                        {
                            if (ctrl is TextBox)
                            {
                                txt = (TextBox)ctrl;
                                txt.Clear();
                            }
                            if (ctrl is NumericUpDown)
                            {
                                (ctrl as NumericUpDown).Value = 0;
                            }
                        }
                        if (NewButton.Text == "Cancel")
                        {
                            NewButton.Text = "New...";
                        }
                        NewButton.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Saveing data : Dutcheang.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
