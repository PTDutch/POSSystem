using CSPOSSQLServerEFCore.Models.Db; //อ้างถึง Folder
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSPOSSQLServerEFCore
{
    public partial class ProductManagementForm : Form
    {
        public ProductManagementForm()
        {
            InitializeComponent();

            productIDTextBox.ReadOnly = true; //ปิดไว้ไม่ให้แก้ไขมันเป็น Auto
            barecodeTextBox.MaxLength = 15;
            productnameTextBox.MaxLength = 50;

            //เขียนคำสั่งตั้งค่า DataGridview
            dataGridView1.ReadOnly = true; //อ่านได้อย่างเดียว
            dataGridView1.MultiSelect = false; //เลือกได้แถวเดียว
            dataGridView1.AllowUserToAddRows = false; //ห้ามการเพิ่มข้อมูล
            dataGridView1.AllowUserToDeleteRows = false;//ห้ามลบแถว
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //เลือกเต็มแถว
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;//
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            //คลิกบน DataGV แล้วให้แสดงข้อมูลไปที่  Textbox ต่างๆ
            dataGridView1.CellClick += dataGridView1_SelectionChanged;
        }

        //สร้างตัวแปรระดับ Field
        private int currentID = -1;
        private void dataGridView1_SelectionChanged(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //เช็คว่า Data มีข้อมูลหรือไม่
                if (dataGridView1.SelectedRows.Count > 0)//มีการเลือกแถวมากกว่า 1
                {
                    currentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                    //ประกาศตัวแปรมาแทร DataGVRow
                    DataGridViewRow row = dataGridView1.SelectedRows[0];//แถวที่เลือก
                    //columnต่างๆของ dataGV ก็จะเป็น cell //การทำแบบนี้จะมีปัญหาถ้ามีค่า null
                    productIDTextBox.Text = row.Cells[0].Value.ToString();
                    barecodeTextBox.Text = row.Cells[1].Value.ToString();
                    productnameTextBox.Text = row.Cells[2].Value.ToString();
                    costPriceTextBox.Text = row.Cells[3].Value.ToString();
                    sellingPriceTextBox.Text = row.Cells[4].Value.ToString();
                    //แก้ปัญหาค่า null เบื้องต้น
                    if (row.Cells[5].Value != null)
                    {
                        unitsInStockTextBox.Text = row.Cells[5].Value.ToString();
                    }
                    else
                    {
                        unitsInStockTextBox.Text = "0";
                    }
                    if (row.Cells[6].Value != null)
                    {
                        reorderLevelTextBox.Text = row.Cells[6].Value.ToString();
                    }
                    else
                    {
                        reorderLevelTextBox.Text = "null";
                    }
                    categoryNameTextBox.Text = row.Cells[7].Value.ToString();
                    unitNameTextBox.Text = row.Cells[8].Value.ToString();
                    noteTextBox.Text = row.Cells[9].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "DataGridView1 Selection Changed.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //สร้าง Instance ของ class ฐานข้อมูล
        CSEFCorePOSDBContext db = new CSEFCorePOSDBContext();

        //สร้าง method โหลดข้อมูล
        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        private void loadData(string strKeyword)
        {
            var data = from p in db.Products
                       where
                       p.ProductBarcode.Contains(strKeyword) ||
                       p.ProductName.Contains(strKeyword) ||
                       p.Note.Contains(strKeyword)
                       orderby p.ProductName ascending
                       select new //สร้างcolumn
                       {
                           ProductID = p.ProductId,
                           ProductBarcode = p.ProductBarcode,
                           ProductName = p.ProductName,
                           CostPrice = p.CostPrice.Value.ToString("#,###,##0.00", System.Globalization.CultureInfo.InvariantCulture),
                           SellingPrice = p.SellingPrice.Value.ToString("#,###,##0.00", System.Globalization.CultureInfo.InvariantCulture),
                           UnitInStock = p.UnitInStock,
                           ReorderLevel = p.ReorderLevel,
                           CategoryName = p.CategoryName,
                           UnitName = p.UnitName,
                           Note = p.Note
                       };

            //เช็คว่า Data มีข้อมูลหรือไม่ ก่อนโหลดข้อมูล
            if (data.Count() > 0)
            {
                dataGridView1.DataSource = data.ToList();

                dataGridView1.Columns[0].HeaderText = "Product ID";
                dataGridView1.Columns[1].HeaderText = "Barcode";
                dataGridView1.Columns[2].HeaderText = "Product Name";
                dataGridView1.Columns[3].HeaderText = "Cost Price";
                dataGridView1.Columns[4].HeaderText = "Selling Price";
                dataGridView1.Columns[5].HeaderText = "Unit In Stock";
                dataGridView1.Columns[6].HeaderText = "Reorder Level";
                dataGridView1.Columns[7].HeaderText = "Category Name";
                dataGridView1.Columns[8].HeaderText = "Unit Name";
                //dataGridView1.Columns[9].HeaderText = "Note";
            }
            else //ถ้าไม่มีข้อมูล
            {
                dataGridView1.DataSource = null;
            }

            addNewButton.Text = "Add new"; //ใช้ตอน instert ข้อมูลเสร็จให้มีการเปลี่ยนข้อความ Text เป็น Add new จากตอนแรกอาจเป็น cancel
            dataGridView1.Enabled = true;
            keywordTextBox.Focus();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            keywordTextBox.Clear(); //การคลิกปุ่มนี้ทำให้เป็นการเคลียkeywordTextboxด้วย
            addNewButton.Text = "Add new";
            dataGridView1.Enabled = true;
            loadData(""); //ส่ง Empty string เข้าไป เป็นการโหลดข้อมูลทั้งหมด

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //seard คือการส่งค่าจาก keywordTextbox ไปให้ method loadData นั้นเอง
            loadData(keywordTextBox.Text.Trim());
        }

        private void keywordTextBox_DoubleClick(object sender, EventArgs e)
        {
            keywordTextBox.Clear();
            keywordTextBox.Focus();
        }

        private void keywordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Disablw Windows Sound.
                e.SuppressKeyPress = true; // ปิดเสียง
                loadData(keywordTextBox.Text.Trim());
            }
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            try
            {
                //เมื่อมีการกดปุ่ม  Add new ให้เช็คว่าข้อความบนปุ่มเป็นอะไร
                if (addNewButton.Text.Trim() == "Add new") //Trim เพราะมีการไปเคาะเว้นวรรคข้อความไว้บน Form
                {
                    addNewButton.Text = "Cancel";

                    foreach (var txt in this.Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                    }

                    dataGridView1.Enabled = false; //ตอน Instance ข้อมูลปิดไม่ให้มีการเลือก
                    barecodeTextBox.ReadOnly = false;

                    //กำหนดค่า Default ให้ TextBox สะดวกในการใช้งาน
                    costPriceTextBox.Text = "0";
                    sellingPriceTextBox.Text = "0";
                    unitsInStockTextBox.Text = "0";
                    reorderLevelTextBox.Text = "0";
                    categoryNameTextBox.Text = "Category";
                    unitNameTextBox.Text = "Units";
                    noteTextBox.Text = "Note";

                    barecodeTextBox.Focus();
                }
                else  //Cancel 
                {
                    addNewButton.Text = "Add new";
                    barecodeTextBox.ReadOnly = true;
                    dataGridView1.Enabled = true;
                    keywordTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Add new button Click.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //ทำงาน 2 แบบ 1) Insert Into, 2) Updeat
            //SQL INSERT INTO
            //SQL UPDEAT
            //DATA Validation

            //DATA Validation

            if (string.IsNullOrEmpty(barecodeTextBox.Text.Trim()) ||//เช็คค่าว่างของ barecode, productname
               string.IsNullOrEmpty(costPriceTextBox.Text.Trim()))
            {
                //แจ่้งเเตือน User
                MessageBox.Show("Please fill in the required fields.", "Saving data : Dutcheang.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //ตรวจสอบความถูกต้องของ Data type (CostPrice, SellingPrice)
            //แปลงข้อมูลเป็น Decimal

            decimal costInput;
            if (!decimal.TryParse(costPriceTextBox.Text.Trim(), out costInput)) //มี !(not) ด้านหน้า ถ้าแปลงไม่ได้-->returnออก
            {
                MessageBox.Show("Cost price : The value must be numeric.", "Saving data : Dutcheang.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                costPriceTextBox.Focus();
                costPriceTextBox.SelectAll();
                return;
            }

            decimal sellingInput;
            if (!decimal.TryParse(sellingPriceTextBox.Text.Trim(), out sellingInput)) //มี !(not) ด้านหน้า ถ้าแปลงไม่ได้-->
            {
                MessageBox.Show("selling price : The value must be numeric.", "Saving data : Dutcheang.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sellingPriceTextBox.Focus();
                sellingPriceTextBox.SelectAll();
                return;
            }

            double quantityInput;
            if (!double.TryParse(unitsInStockTextBox.Text.Trim(), out quantityInput)) //มี !(not) ด้านหน้า ถ้าแปลงไม่ได้-->
            {
                MessageBox.Show("Units in Stock: The value must be numeric.", "Saving data : Dutcheang.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                unitsInStockTextBox.Focus();
                unitsInStockTextBox.SelectAll();
                return;
            }

            short levelInput;
            if (!short.TryParse(reorderLevelTextBox.Text.Trim(), out levelInput)) //มี !(not) ด้านหน้า ถ้าแปลงไม่ได้-->
            {
                MessageBox.Show("Reorder Level: The value must be numeric.", "Saving data : Dutcheang.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reorderLevelTextBox.Focus();
                reorderLevelTextBox.SelectAll();
                return;
            }

            //การ Save(ใช้DialogResult) ถาม User ว่าต้องการดำเนิดการต่อหรือไม่

            DialogResult result;

            //การที่เราจะรู้ว่าเป็นการ insert or update นั้นให้เช็คจากปุ่มบน addNew
            if (addNewButton.Text.Trim() == "Cancel") //INSERT INTO || Add new
            {
                result = MessageBox.Show("Do you want to continue?", "Add new product : Dutcheang.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) //เช็คว่าเป็น yes ไหม
                {

                    using (var tr = db.Database.BeginTransaction())
                    {
                        Product pr = new Product();
                        pr.ProductBarcode = barecodeTextBox.Text.Trim();
                        pr.ProductName = productnameTextBox.Text.Trim();

                        //เอาจากทีประกาศตัวแปรไว้ด้านบน
                        pr.CostPrice = costInput;
                        pr.SellingPrice = sellingInput;
                        pr.UnitInStock = quantityInput;
                        pr.ReorderLevel = levelInput;

                        pr.CategoryName = categoryNameTextBox.Text.Trim();
                        pr.UnitName = unitNameTextBox.Text.Trim();
                        pr.Note = noteTextBox.Text.Trim();

                        db.Products.Add(pr); //นำ pr ไปเพิ่มให้กับตาราง
                        db.SaveChanges(); //บันทึกการเปลี่ยนแปลง
                        tr.Commit(); //ยืนยันความถูกต้อง
                        center.isExecuted = true; //จะได้รู้ว่าบันทึกเสร็จแล้วrefreshให้หน่อย
                        MessageBox.Show("Record has been added successfully.", "Saving data : Dutcheang",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            else // Update
            {
                result = MessageBox.Show("Do you want to continue?", "Save Changes : Dutcheang.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)//yes แสดงว่าต้องการแก้ไข้รายการ
                {
                    using (var tr = db.Database.BeginTransaction())
                    {
                        //ดึงข้อมูลมาจากตาราง product โดยอ้างอิงจาก barcodetextbix ใช้ where
                        var pr = (from p in db.Products
                                  where p.ProductBarcode == barecodeTextBox.Text.Trim() //ใช้ id or barcode ก็ได้
                                  //where p.ProductId == Convert.ToInt32(productIDTextBox.Text.Trim())
                                  select p).FirstOrDefault();
                        if (pr != null)
                        {
                            //การ Update ก็จะนำค่ามาจาก TextBox ต่างๆ

                            //pr.ProductBarcode = barecodeTextBox.Text.Trim(); //ในกรณีใช้ ProductID เป็นเงื่อนไขในการอัปเดต
                            pr.ProductName = productnameTextBox.Text.Trim();
                            pr.CostPrice = costInput;
                            pr.SellingPrice = sellingInput;
                            pr.UnitInStock = quantityInput;
                            pr.ReorderLevel = levelInput;

                            pr.CategoryName = categoryNameTextBox.Text.Trim();
                            pr.UnitName = unitNameTextBox.Text.Trim();
                            pr.Note = noteTextBox.Text.Trim();

                            db.SaveChanges();
                            tr.Commit(); //การยืนยันTransaction
                            center.isExecuted = true; //จะได้รู้ว่าบันทึกเสร็จแล้วrefreshให้หน่อย
                            MessageBox.Show("Record has been updated successfully.", "Update data : Dutcheang",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                }
            }

            if (center.isExecuted == true) // แสดงว่าบันทึกข้อมูลเสร็จแล้ว
            {
                foreach (var txt in this.Controls.OfType<TextBox>()) //ก่อนrfทำการclearข้อมูล
                {
                    txt.Clear();
                }
                loadData(""); //Refresh data.(ส่งค่าว่างเข้าไปเหมือนการrefreshข้อมูล)

            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(productIDTextBox.Text.Trim())) //เช็คก่อนว่ามีค่าว่างอยู่ที่ productID หรือไม่
            {
                return; //ค่าว่าง Return ออก
            }

            //ถาม User
            DialogResult result;
            result = MessageBox.Show("Do you want to delete the selected item?", "Delete data : Dutcheang.",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)//yes แสดงว่าต้องการใช้งาน
            {
                using (var tr = db.Database.BeginTransaction())
                {
                    try
                    {

                        var pr = (from p in db.Products
                                  where p.ProductId == Convert.ToInt32(productIDTextBox.Text.Trim())
                                  select p).FirstOrDefault();

                        if (pr != null) //เช็คว่า null รึเปล่า
                        {
                            db.Products.Remove(pr);
                        }
                        db.SaveChanges();
                        tr.Commit();
                        center.isExecuted = true;
                        MessageBox.Show("Record has been updated successfully.", "Delete data : Dutcheang", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex.Message, "Delete Data Faild : Dutcheang.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally //ใช้สำหรับการ refresh ข้อมูล
                    {
                        if (center.isExecuted == true) // แสดงว่าบันทึกข้อมูลเสร็จแล้ว
                        {
                            foreach (var txt in this.Controls.OfType<TextBox>()) //ก่อนrfทำการclearข้อมูล
                            {
                                txt.Clear();
                            }
                            loadData(""); //Refresh data.(ส่งค่าว่างเข้าไปเหมือนการrefreshข้อมูล)

                        }
                    }
                }
            }
        }

    }
}
