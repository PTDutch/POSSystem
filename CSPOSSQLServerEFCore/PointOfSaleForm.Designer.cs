namespace CSPOSSQLServerEFCore
{
    partial class PointOfSaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            currentTimeLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            label2 = new Label();
            barcodeTextBox = new TextBox();
            groupBox1 = new GroupBox();
            employeeNameTextBox = new TextBox();
            label6 = new Label();
            employeeIDTextBox = new TextBox();
            label5 = new Label();
            transactionIDTextBox = new TextBox();
            label4 = new Label();
            currentDateTextBox = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            customerNameTextBox = new TextBox();
            label9 = new Label();
            customerIDTextBox = new TextBox();
            label10 = new Label();
            groupBox3 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label14 = new Label();
            productNameTextBox = new TextBox();
            label13 = new Label();
            unitsInStockTextBox = new TextBox();
            label7 = new Label();
            productBarcodeTextBox = new TextBox();
            label8 = new Label();
            sellingPriceTextBox = new TextBox();
            label11 = new Label();
            productIDTextBox = new TextBox();
            label12 = new Label();
            label15 = new Label();
            label16 = new Label();
            dataGridView1 = new DataGridView();
            NewButton = new Button();
            closeButton = new Button();
            removeButton = new Button();
            saveButton = new Button();
            tenderedTextBox = new TextBox();
            label17 = new Label();
            changeTextBox = new TextBox();
            label18 = new Label();
            totalAmountTextBox = new TextBox();
            label19 = new Label();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1236, 96);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(584, 60);
            label1.TabIndex = 0;
            label1.Text = "Point Of Sale (POS) System";
            // 
            // currentTimeLabel
            // 
            currentTimeLabel.AutoSize = true;
            currentTimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            currentTimeLabel.Location = new Point(32, 115);
            currentTimeLabel.Name = "currentTimeLabel";
            currentTimeLabel.Size = new Size(90, 20);
            currentTimeLabel.TabIndex = 1;
            currentTimeLabel.Text = "00:00:00 AM";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 762);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1236, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.ForeColor = Color.FromArgb(255, 128, 0);
            toolStripStatusLabel1.Image = Properties.Resources.Graphicloads_Flat_Finance_Statistics_market1;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(73, 20);
            toolStripStatusLabel1.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(679, 118);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Barcode";
            // 
            // barcodeTextBox
            // 
            barcodeTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            barcodeTextBox.Location = new Point(768, 115);
            barcodeTextBox.Name = "barcodeTextBox";
            barcodeTextBox.Size = new Size(249, 27);
            barcodeTextBox.TabIndex = 4;
            barcodeTextBox.KeyDown += barcodeTextBox_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(employeeNameTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(employeeIDTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(transactionIDTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(currentDateTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(32, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(623, 135);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaction :";
            // 
            // employeeNameTextBox
            // 
            employeeNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            employeeNameTextBox.Location = new Point(452, 89);
            employeeNameTextBox.Name = "employeeNameTextBox";
            employeeNameTextBox.ReadOnly = true;
            employeeNameTextBox.Size = new Size(154, 27);
            employeeNameTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(324, 95);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 10;
            label6.Text = "Employee Name:";
            // 
            // employeeIDTextBox
            // 
            employeeIDTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            employeeIDTextBox.Location = new Point(452, 45);
            employeeIDTextBox.Name = "employeeIDTextBox";
            employeeIDTextBox.ReadOnly = true;
            employeeIDTextBox.Size = new Size(154, 27);
            employeeIDTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(324, 48);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 8;
            label5.Text = "Employee ID:";
            // 
            // transactionIDTextBox
            // 
            transactionIDTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            transactionIDTextBox.Location = new Point(130, 88);
            transactionIDTextBox.Name = "transactionIDTextBox";
            transactionIDTextBox.ReadOnly = true;
            transactionIDTextBox.Size = new Size(153, 27);
            transactionIDTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 92);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 6;
            label4.Text = "Transaction ID:";
            // 
            // currentDateTextBox
            // 
            currentDateTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            currentDateTextBox.Location = new Point(130, 45);
            currentDateTextBox.Name = "currentDateTextBox";
            currentDateTextBox.ReadOnly = true;
            currentDateTextBox.Size = new Size(153, 27);
            currentDateTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 48);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 6;
            label3.Text = "Current Date:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(customerNameTextBox);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(customerIDTextBox);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(684, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 123);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Customer :";
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customerNameTextBox.Location = new Point(151, 86);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.ReadOnly = true;
            customerNameTextBox.Size = new Size(154, 27);
            customerNameTextBox.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(22, 90);
            label9.Name = "label9";
            label9.Size = new Size(119, 20);
            label9.TabIndex = 6;
            label9.Text = "Customer Name:";
            // 
            // customerIDTextBox
            // 
            customerIDTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customerIDTextBox.Location = new Point(151, 43);
            customerIDTextBox.Name = "customerIDTextBox";
            customerIDTextBox.ReadOnly = true;
            customerIDTextBox.Size = new Size(154, 27);
            customerIDTextBox.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(22, 46);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 6;
            label10.Text = "Customer ID:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(productNameTextBox);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(unitsInStockTextBox);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(productBarcodeTextBox);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(sellingPriceTextBox);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(productIDTextBox);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(32, 310);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1002, 145);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(819, 100);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(154, 27);
            numericUpDown1.TabIndex = 16;
            numericUpDown1.KeyDown += numericUpDown1_KeyDown;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(691, 102);
            label14.Name = "label14";
            label14.Size = new Size(68, 20);
            label14.TabIndex = 15;
            label14.Text = "Quantity:";
            // 
            // productNameTextBox
            // 
            productNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productNameTextBox.Location = new Point(819, 45);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.ReadOnly = true;
            productNameTextBox.Size = new Size(154, 27);
            productNameTextBox.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(691, 48);
            label13.Name = "label13";
            label13.Size = new Size(107, 20);
            label13.TabIndex = 12;
            label13.Text = "Product Name:";
            // 
            // unitsInStockTextBox
            // 
            unitsInStockTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            unitsInStockTextBox.Location = new Point(482, 89);
            unitsInStockTextBox.Name = "unitsInStockTextBox";
            unitsInStockTextBox.ReadOnly = true;
            unitsInStockTextBox.Size = new Size(154, 27);
            unitsInStockTextBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(354, 95);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 10;
            label7.Text = "Units in Stock:";
            // 
            // productBarcodeTextBox
            // 
            productBarcodeTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productBarcodeTextBox.Location = new Point(482, 45);
            productBarcodeTextBox.Name = "productBarcodeTextBox";
            productBarcodeTextBox.ReadOnly = true;
            productBarcodeTextBox.Size = new Size(154, 27);
            productBarcodeTextBox.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(354, 48);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 8;
            label8.Text = "Barcode:";
            // 
            // sellingPriceTextBox
            // 
            sellingPriceTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sellingPriceTextBox.Location = new Point(130, 88);
            sellingPriceTextBox.Name = "sellingPriceTextBox";
            sellingPriceTextBox.ReadOnly = true;
            sellingPriceTextBox.Size = new Size(153, 27);
            sellingPriceTextBox.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(18, 92);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 6;
            label11.Text = "Selling Price:";
            // 
            // productIDTextBox
            // 
            productIDTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productIDTextBox.Location = new Point(130, 45);
            productIDTextBox.Name = "productIDTextBox";
            productIDTextBox.ReadOnly = true;
            productIDTextBox.Size = new Size(153, 27);
            productIDTextBox.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(18, 48);
            label12.Name = "label12";
            label12.Size = new Size(82, 20);
            label12.TabIndex = 6;
            label12.Text = "Product ID:";
            // 
            // label15
            // 
            label15.BackColor = Color.RosyBrown;
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Location = new Point(32, 293);
            label15.Name = "label15";
            label15.Size = new Size(1002, 4);
            label15.TabIndex = 8;
            // 
            // label16
            // 
            label16.BackColor = Color.RosyBrown;
            label16.BorderStyle = BorderStyle.Fixed3D;
            label16.Location = new Point(32, 467);
            label16.Name = "label16";
            label16.Size = new Size(1002, 4);
            label16.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 490);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1002, 259);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // NewButton
            // 
            NewButton.BackColor = Color.Sienna;
            NewButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NewButton.ForeColor = Color.Transparent;
            NewButton.Location = new Point(1059, 115);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(153, 57);
            NewButton.TabIndex = 15;
            NewButton.Text = "New...";
            NewButton.UseVisualStyleBackColor = false;
            NewButton.Click += NewButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.OrangeRed;
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(1059, 177);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(153, 57);
            closeButton.TabIndex = 16;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Orange;
            removeButton.ForeColor = Color.White;
            removeButton.Location = new Point(1059, 240);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(153, 57);
            removeButton.TabIndex = 17;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.IndianRed;
            saveButton.ForeColor = Color.Transparent;
            saveButton.Location = new Point(1059, 692);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(153, 57);
            saveButton.TabIndex = 18;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // tenderedTextBox
            // 
            tenderedTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tenderedTextBox.Location = new Point(1060, 540);
            tenderedTextBox.Name = "tenderedTextBox";
            tenderedTextBox.Size = new Size(149, 34);
            tenderedTextBox.TabIndex = 9;
            tenderedTextBox.TextAlign = HorizontalAlignment.Center;
            tenderedTextBox.TextChanged += tenderedTextBox_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(1059, 517);
            label17.Name = "label17";
            label17.Size = new Size(74, 20);
            label17.TabIndex = 8;
            label17.Text = "Tendered:";
            // 
            // changeTextBox
            // 
            changeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            changeTextBox.Location = new Point(1059, 612);
            changeTextBox.Name = "changeTextBox";
            changeTextBox.ReadOnly = true;
            changeTextBox.Size = new Size(148, 34);
            changeTextBox.TabIndex = 20;
            changeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(1060, 589);
            label18.Name = "label18";
            label18.Size = new Size(62, 20);
            label18.TabIndex = 19;
            label18.Text = "Change:";
            // 
            // totalAmountTextBox
            // 
            totalAmountTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalAmountTextBox.Location = new Point(1060, 474);
            totalAmountTextBox.Name = "totalAmountTextBox";
            totalAmountTextBox.ReadOnly = true;
            totalAmountTextBox.Size = new Size(149, 34);
            totalAmountTextBox.TabIndex = 22;
            totalAmountTextBox.TextAlign = HorizontalAlignment.Center;
            totalAmountTextBox.TextChanged += totalAmountTextBox_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(1059, 451);
            label19.Name = "label19";
            label19.Size = new Size(102, 20);
            label19.TabIndex = 21;
            label19.Text = "Total Amount:";
            // 
            // PointOfSaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 788);
            Controls.Add(totalAmountTextBox);
            Controls.Add(label19);
            Controls.Add(changeTextBox);
            Controls.Add(label18);
            Controls.Add(tenderedTextBox);
            Controls.Add(saveButton);
            Controls.Add(label17);
            Controls.Add(removeButton);
            Controls.Add(closeButton);
            Controls.Add(NewButton);
            Controls.Add(dataGridView1);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(barcodeTextBox);
            Controls.Add(label2);
            Controls.Add(statusStrip1);
            Controls.Add(currentTimeLabel);
            Controls.Add(panel1);
            Name = "PointOfSaleForm";
            Text = "Point Of Sale Form";
            FormClosing += PointOfSaleForm_FormClosing;
            Load += PointOfSaleForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label currentTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label2;
        private TextBox barcodeTextBox;
        private GroupBox groupBox1;
        private TextBox employeeNameTextBox;
        private Label label6;
        private TextBox employeeIDTextBox;
        private Label label5;
        private TextBox transactionIDTextBox;
        private Label label4;
        private TextBox currentDateTextBox;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox customerNameTextBox;
        private Label label9;
        private TextBox customerIDTextBox;
        private Label label10;
        private GroupBox groupBox3;
        private Label label14;
        private TextBox productNameTextBox;
        private Label label13;
        private TextBox unitsInStockTextBox;
        private Label label7;
        private TextBox productBarcodeTextBox;
        private Label label8;
        private TextBox sellingPriceTextBox;
        private Label label11;
        private TextBox productIDTextBox;
        private Label label12;
        private Label label15;
        private Label label16;
        private DataGridView dataGridView1;
        private Button NewButton;
        private Button closeButton;
        private Button removeButton;
        private Button saveButton;
        private TextBox tenderedTextBox;
        private Label label17;
        private TextBox changeTextBox;
        private Label label18;
        private TextBox totalAmountTextBox;
        private Label label19;
        private NumericUpDown numericUpDown1;
    }
}