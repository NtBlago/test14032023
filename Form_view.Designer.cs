namespace test14032023
{
    partial class Form_view
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_view));
            this.bot_panel = new System.Windows.Forms.Panel();
            this.top_panel = new System.Windows.Forms.Panel();
            this.icon_picturebox = new System.Windows.Forms.PictureBox();
            this.name_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.red_button = new System.Windows.Forms.Button();
            this.tovar_dgw = new System.Windows.Forms.DataGridView();
            this.safinIsp491_tradeDataSet = new test14032023.safinIsp491_tradeDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new test14032023.safinIsp491_tradeDataSetTableAdapters.ProductTableAdapter();
            this.productArticleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDiscountAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edinitsaizmereniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info_panel = new System.Windows.Forms.Panel();
            this.photo_picturebox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NameT_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescT_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ManufT_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CostT_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DiscountT_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bot_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovar_dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safinIsp491_tradeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo_picturebox)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bot_panel
            // 
            this.bot_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bot_panel.Controls.Add(this.info_panel);
            this.bot_panel.Controls.Add(this.red_button);
            this.bot_panel.Controls.Add(this.exit_button);
            this.bot_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bot_panel.Location = new System.Drawing.Point(0, 557);
            this.bot_panel.Margin = new System.Windows.Forms.Padding(4);
            this.bot_panel.Name = "bot_panel";
            this.bot_panel.Size = new System.Drawing.Size(1253, 164);
            this.bot_panel.TabIndex = 7;
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.top_panel.Controls.Add(this.icon_picturebox);
            this.top_panel.Controls.Add(this.name_label);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Margin = new System.Windows.Forms.Padding(4);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1253, 138);
            this.top_panel.TabIndex = 6;
            // 
            // icon_picturebox
            // 
            this.icon_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("icon_picturebox.Image")));
            this.icon_picturebox.Location = new System.Drawing.Point(0, 3);
            this.icon_picturebox.Name = "icon_picturebox";
            this.icon_picturebox.Size = new System.Drawing.Size(132, 132);
            this.icon_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_picturebox.TabIndex = 1;
            this.icon_picturebox.TabStop = false;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(173, 54);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(125, 18);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "ООО «Украшение»";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.exit_button.Location = new System.Drawing.Point(1159, 34);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(81, 78);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Закрыть";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // red_button
            // 
            this.red_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.red_button.Location = new System.Drawing.Point(1057, 34);
            this.red_button.Margin = new System.Windows.Forms.Padding(4);
            this.red_button.Name = "red_button";
            this.red_button.Size = new System.Drawing.Size(94, 78);
            this.red_button.TabIndex = 4;
            this.red_button.Text = "Добавление данных";
            this.red_button.UseVisualStyleBackColor = false;
            this.red_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // tovar_dgw
            // 
            this.tovar_dgw.AutoGenerateColumns = false;
            this.tovar_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tovar_dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productArticleNumberDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.productCategoryDataGridViewTextBoxColumn,
            this.productPhotoDataGridViewTextBoxColumn,
            this.productManufacturerDataGridViewTextBoxColumn,
            this.productCostDataGridViewTextBoxColumn,
            this.productDiscountAmountDataGridViewTextBoxColumn,
            this.productQuantityInStockDataGridViewTextBoxColumn,
            this.productStatusDataGridViewTextBoxColumn,
            this.edinitsaizmereniaDataGridViewTextBoxColumn});
            this.tovar_dgw.DataSource = this.productBindingSource;
            this.tovar_dgw.Location = new System.Drawing.Point(0, 141);
            this.tovar_dgw.Name = "tovar_dgw";
            this.tovar_dgw.Size = new System.Drawing.Size(1253, 409);
            this.tovar_dgw.TabIndex = 8;
            // 
            // safinIsp491_tradeDataSet
            // 
            this.safinIsp491_tradeDataSet.DataSetName = "safinIsp491_tradeDataSet";
            this.safinIsp491_tradeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.safinIsp491_tradeDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productArticleNumberDataGridViewTextBoxColumn
            // 
            this.productArticleNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductArticleNumber";
            this.productArticleNumberDataGridViewTextBoxColumn.HeaderText = "ProductArticleNumber";
            this.productArticleNumberDataGridViewTextBoxColumn.Name = "productArticleNumberDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            // 
            // productCategoryDataGridViewTextBoxColumn
            // 
            this.productCategoryDataGridViewTextBoxColumn.DataPropertyName = "ProductCategory";
            this.productCategoryDataGridViewTextBoxColumn.HeaderText = "ProductCategory";
            this.productCategoryDataGridViewTextBoxColumn.Name = "productCategoryDataGridViewTextBoxColumn";
            // 
            // productPhotoDataGridViewTextBoxColumn
            // 
            this.productPhotoDataGridViewTextBoxColumn.DataPropertyName = "ProductPhoto";
            this.productPhotoDataGridViewTextBoxColumn.HeaderText = "ProductPhoto";
            this.productPhotoDataGridViewTextBoxColumn.Name = "productPhotoDataGridViewTextBoxColumn";
            // 
            // productManufacturerDataGridViewTextBoxColumn
            // 
            this.productManufacturerDataGridViewTextBoxColumn.DataPropertyName = "ProductManufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.HeaderText = "ProductManufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.Name = "productManufacturerDataGridViewTextBoxColumn";
            // 
            // productCostDataGridViewTextBoxColumn
            // 
            this.productCostDataGridViewTextBoxColumn.DataPropertyName = "ProductCost";
            this.productCostDataGridViewTextBoxColumn.HeaderText = "ProductCost";
            this.productCostDataGridViewTextBoxColumn.Name = "productCostDataGridViewTextBoxColumn";
            // 
            // productDiscountAmountDataGridViewTextBoxColumn
            // 
            this.productDiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "ProductDiscountAmount";
            this.productDiscountAmountDataGridViewTextBoxColumn.HeaderText = "ProductDiscountAmount";
            this.productDiscountAmountDataGridViewTextBoxColumn.Name = "productDiscountAmountDataGridViewTextBoxColumn";
            // 
            // productQuantityInStockDataGridViewTextBoxColumn
            // 
            this.productQuantityInStockDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantityInStock";
            this.productQuantityInStockDataGridViewTextBoxColumn.HeaderText = "ProductQuantityInStock";
            this.productQuantityInStockDataGridViewTextBoxColumn.Name = "productQuantityInStockDataGridViewTextBoxColumn";
            // 
            // productStatusDataGridViewTextBoxColumn
            // 
            this.productStatusDataGridViewTextBoxColumn.DataPropertyName = "ProductStatus";
            this.productStatusDataGridViewTextBoxColumn.HeaderText = "ProductStatus";
            this.productStatusDataGridViewTextBoxColumn.Name = "productStatusDataGridViewTextBoxColumn";
            // 
            // edinitsaizmereniaDataGridViewTextBoxColumn
            // 
            this.edinitsaizmereniaDataGridViewTextBoxColumn.DataPropertyName = "Edinitsa_izmerenia";
            this.edinitsaizmereniaDataGridViewTextBoxColumn.HeaderText = "Edinitsa_izmerenia";
            this.edinitsaizmereniaDataGridViewTextBoxColumn.Name = "edinitsaizmereniaDataGridViewTextBoxColumn";
            // 
            // info_panel
            // 
            this.info_panel.Controls.Add(this.panel5);
            this.info_panel.Controls.Add(this.photo_picturebox);
            this.info_panel.Controls.Add(this.panel4);
            this.info_panel.Location = new System.Drawing.Point(112, 12);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(795, 140);
            this.info_panel.TabIndex = 9;
            // 
            // photo_picturebox
            // 
            this.photo_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("photo_picturebox.Image")));
            this.photo_picturebox.Location = new System.Drawing.Point(14, 11);
            this.photo_picturebox.Name = "photo_picturebox";
            this.photo_picturebox.Size = new System.Drawing.Size(162, 107);
            this.photo_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo_picturebox.TabIndex = 10;
            this.photo_picturebox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.DiscountT_label);
            this.panel4.Location = new System.Drawing.Point(652, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 107);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.CostT_label);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.ManufT_label);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.DescT_label);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.NameT_label);
            this.panel5.Location = new System.Drawing.Point(210, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(381, 126);
            this.panel5.TabIndex = 9;
            // 
            // NameT_label
            // 
            this.NameT_label.AutoSize = true;
            this.NameT_label.Location = new System.Drawing.Point(13, 11);
            this.NameT_label.Name = "NameT_label";
            this.NameT_label.Size = new System.Drawing.Size(147, 18);
            this.NameT_label.TabIndex = 0;
            this.NameT_label.Text = "Наименование товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // DescT_label
            // 
            this.DescT_label.AutoSize = true;
            this.DescT_label.Location = new System.Drawing.Point(16, 40);
            this.DescT_label.Name = "DescT_label";
            this.DescT_label.Size = new System.Drawing.Size(116, 18);
            this.DescT_label.TabIndex = 2;
            this.DescT_label.Text = "Описание товара";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // ManufT_label
            // 
            this.ManufT_label.AutoSize = true;
            this.ManufT_label.Location = new System.Drawing.Point(16, 71);
            this.ManufT_label.Name = "ManufT_label";
            this.ManufT_label.Size = new System.Drawing.Size(107, 18);
            this.ManufT_label.TabIndex = 4;
            this.ManufT_label.Text = "Производитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "label7";
            // 
            // CostT_label
            // 
            this.CostT_label.AutoSize = true;
            this.CostT_label.Location = new System.Drawing.Point(16, 96);
            this.CostT_label.Name = "CostT_label";
            this.CostT_label.Size = new System.Drawing.Size(39, 18);
            this.CostT_label.TabIndex = 6;
            this.CostT_label.Text = "Цена";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "label9";
            // 
            // DiscountT_label
            // 
            this.DiscountT_label.AutoSize = true;
            this.DiscountT_label.Location = new System.Drawing.Point(8, 11);
            this.DiscountT_label.Name = "DiscountT_label";
            this.DiscountT_label.Size = new System.Drawing.Size(99, 18);
            this.DiscountT_label.TabIndex = 0;
            this.DiscountT_label.Text = "Размер скидки";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "label11";
            // 
            // Form_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 721);
            this.Controls.Add(this.tovar_dgw);
            this.Controls.Add(this.bot_panel);
            this.Controls.Add(this.top_panel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_view";
            this.Text = "Просмотр данных.";
            this.Load += new System.EventHandler(this.Form_view_Load);
            this.bot_panel.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovar_dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safinIsp491_tradeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.info_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photo_picturebox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bot_panel;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.PictureBox icon_picturebox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button red_button;
        private System.Windows.Forms.DataGridView tovar_dgw;
        private safinIsp491_tradeDataSet safinIsp491_tradeDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private safinIsp491_tradeDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productArticleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPhotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDiscountAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edinitsaizmereniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox photo_picturebox;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CostT_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ManufT_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DescT_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NameT_label;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label DiscountT_label;
    }
}