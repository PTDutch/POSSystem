namespace CSPOSSQLServerEFCore
{
    partial class ProductManagementForm
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
            panel1 = new Panel();
            label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            keywordTextBox = new TextBox();
            searchButton = new Button();
            addNewButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            refreshButton = new Button();
            label11 = new Label();
            statusStrip1 = new StatusStrip();
            dataGridView1 = new DataGridView();
            productIDTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            barecodeTextBox = new TextBox();
            label3 = new Label();
            productnameTextBox = new TextBox();
            label4 = new Label();
            costPriceTextBox = new TextBox();
            label5 = new Label();
            sellingPriceTextBox = new TextBox();
            label6 = new Label();
            unitsInStockTextBox = new TextBox();
            label7 = new Label();
            noteTextBox = new TextBox();
            label8 = new Label();
            unitNameTextBox = new TextBox();
            label9 = new Label();
            categoryNameTextBox = new TextBox();
            label10 = new Label();
            reorderLevelTextBox = new TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(label);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 97);
            panel1.TabIndex = 0;
            // 
            // label
            // 
            label.BackColor = Color.SaddleBrown;
            label.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = Color.Transparent;
            label.Location = new Point(33, 18);
            label.Name = "label";
            label.Size = new Size(601, 70);
            label.TabIndex = 0;
            label.Text = "Product Management Form";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Bisque;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(keywordTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(searchButton, 1, 0);
            tableLayoutPanel1.Controls.Add(addNewButton, 2, 0);
            tableLayoutPanel1.Controls.Add(saveButton, 3, 0);
            tableLayoutPanel1.Controls.Add(deleteButton, 4, 0);
            tableLayoutPanel1.Controls.Add(refreshButton, 5, 0);
            tableLayoutPanel1.Controls.Add(label11, 6, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 97);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1012, 52);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // keywordTextBox
            // 
            keywordTextBox.Dock = DockStyle.Fill;
            keywordTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            keywordTextBox.Location = new Point(3, 7);
            keywordTextBox.Margin = new Padding(3, 7, 3, 3);
            keywordTextBox.Name = "keywordTextBox";
            keywordTextBox.Size = new Size(344, 38);
            keywordTextBox.TabIndex = 0;
            keywordTextBox.DoubleClick += keywordTextBox_DoubleClick;
            keywordTextBox.KeyDown += keywordTextBox_KeyDown;
            // 
            // searchButton
            // 
            searchButton.Dock = DockStyle.Fill;
            searchButton.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_preview_archive_24;
            searchButton.Location = new Point(353, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(119, 46);
            searchButton.TabIndex = 1;
            searchButton.Text = " Search";
            searchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // addNewButton
            // 
            addNewButton.Dock = DockStyle.Fill;
            addNewButton.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_new_24;
            addNewButton.Location = new Point(478, 3);
            addNewButton.Name = "addNewButton";
            addNewButton.Size = new Size(119, 46);
            addNewButton.TabIndex = 2;
            addNewButton.Text = " Add new";
            addNewButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addNewButton.UseVisualStyleBackColor = true;
            addNewButton.Click += addNewButton_Click;
            // 
            // saveButton
            // 
            saveButton.Dock = DockStyle.Fill;
            saveButton.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_games_endturn_24;
            saveButton.Location = new Point(603, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(119, 46);
            saveButton.TabIndex = 3;
            saveButton.Text = " Save";
            saveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_close_24;
            deleteButton.Location = new Point(728, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(119, 46);
            deleteButton.TabIndex = 4;
            deleteButton.Text = " Delete";
            deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Dock = DockStyle.Fill;
            refreshButton.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_games_solve_24;
            refreshButton.Location = new Point(853, 3);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(119, 46);
            refreshButton.TabIndex = 5;
            refreshButton.Text = " Refresh";
            refreshButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(978, 0);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 6;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 621);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1012, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 354);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(949, 264);
            dataGridView1.TabIndex = 3;
            // 
            // productIDTextBox
            // 
            productIDTextBox.Location = new Point(169, 172);
            productIDTextBox.Name = "productIDTextBox";
            productIDTextBox.Size = new Size(300, 27);
            productIDTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 175);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 5;
            label1.Text = "Product ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 208);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 7;
            label2.Text = "Barcode:";
            // 
            // barecodeTextBox
            // 
            barecodeTextBox.Location = new Point(169, 205);
            barecodeTextBox.Name = "barecodeTextBox";
            barecodeTextBox.Size = new Size(300, 27);
            barecodeTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 241);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 9;
            label3.Text = "Product Name:";
            // 
            // productnameTextBox
            // 
            productnameTextBox.Location = new Point(170, 238);
            productnameTextBox.Name = "productnameTextBox";
            productnameTextBox.Size = new Size(300, 27);
            productnameTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 274);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 11;
            label4.Text = "Cost Price:";
            // 
            // costPriceTextBox
            // 
            costPriceTextBox.Location = new Point(169, 271);
            costPriceTextBox.Name = "costPriceTextBox";
            costPriceTextBox.Size = new Size(300, 27);
            costPriceTextBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 307);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 13;
            label5.Text = "Selling Price:";
            // 
            // sellingPriceTextBox
            // 
            sellingPriceTextBox.Location = new Point(169, 304);
            sellingPriceTextBox.Name = "sellingPriceTextBox";
            sellingPriceTextBox.Size = new Size(300, 27);
            sellingPriceTextBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(549, 179);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 15;
            label6.Text = "Units in Stock";
            // 
            // unitsInStockTextBox
            // 
            unitsInStockTextBox.Location = new Point(672, 175);
            unitsInStockTextBox.Name = "unitsInStockTextBox";
            unitsInStockTextBox.Size = new Size(300, 27);
            unitsInStockTextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(549, 310);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 23;
            label7.Text = "Note:";
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(672, 307);
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(300, 27);
            noteTextBox.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(549, 277);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 21;
            label8.Text = "Unit Name";
            // 
            // unitNameTextBox
            // 
            unitNameTextBox.Location = new Point(672, 274);
            unitNameTextBox.Name = "unitNameTextBox";
            unitNameTextBox.Size = new Size(300, 27);
            unitNameTextBox.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(549, 244);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 19;
            label9.Text = "Catategory:";
            // 
            // categoryNameTextBox
            // 
            categoryNameTextBox.Location = new Point(672, 241);
            categoryNameTextBox.Name = "categoryNameTextBox";
            categoryNameTextBox.Size = new Size(300, 27);
            categoryNameTextBox.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(549, 211);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 17;
            label10.Text = "Reorder Level:";
            // 
            // reorderLevelTextBox
            // 
            reorderLevelTextBox.Location = new Point(672, 208);
            reorderLevelTextBox.Name = "reorderLevelTextBox";
            reorderLevelTextBox.Size = new Size(300, 27);
            reorderLevelTextBox.TabIndex = 16;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 643);
            Controls.Add(label7);
            Controls.Add(noteTextBox);
            Controls.Add(label8);
            Controls.Add(unitNameTextBox);
            Controls.Add(label9);
            Controls.Add(categoryNameTextBox);
            Controls.Add(label10);
            Controls.Add(reorderLevelTextBox);
            Controls.Add(label6);
            Controls.Add(unitsInStockTextBox);
            Controls.Add(label5);
            Controls.Add(sellingPriceTextBox);
            Controls.Add(label4);
            Controls.Add(costPriceTextBox);
            Controls.Add(label3);
            Controls.Add(productnameTextBox);
            Controls.Add(label2);
            Controls.Add(barecodeTextBox);
            Controls.Add(label1);
            Controls.Add(productIDTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "ProductManagementForm";
            Text = "Product Management Form";
            Load += ProductManagementForm_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox keywordTextBox;
        private Button searchButton;
        private Button addNewButton;
        private Button saveButton;
        private Button deleteButton;
        private Button refreshButton;
        private StatusStrip statusStrip1;
        private DataGridView dataGridView1;
        private TextBox productIDTextBox;
        private Label label1;
        private Label label2;
        private TextBox barecodeTextBox;
        private Label label3;
        private TextBox productnameTextBox;
        private Label label4;
        private TextBox costPriceTextBox;
        private Label label5;
        private TextBox sellingPriceTextBox;
        private Label label6;
        private TextBox unitsInStockTextBox;
        private Label label7;
        private TextBox noteTextBox;
        private Label label8;
        private TextBox unitNameTextBox;
        private Label label9;
        private TextBox categoryNameTextBox;
        private Label label10;
        private TextBox reorderLevelTextBox;
        private Label label11;
    }
}