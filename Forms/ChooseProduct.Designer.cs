namespace CourseProject
{
    partial class ChooseProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_brand = new System.Windows.Forms.Label();
            this.label_producer = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clothingShopDataSet = new CourseProject.ClothingShopDataSet();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_sum = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_delivery = new System.Windows.Forms.Button();
            this.storageTableAdapter = new CourseProject.ClothingShopDataSetTableAdapters.StorageTableAdapter();
            this.orderTableAdapter = new CourseProject.ClothingShopDataSetTableAdapters.OrderTableAdapter();
            this.button_UPD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Короткий опис";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ціна";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Гендер";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Країна-виробник";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Бренд";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Тип одягу";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Код товару";
            // 
            // label_id
            // 
            this.label_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_id.Location = new System.Drawing.Point(208, 57);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(19, 25);
            this.label_id.TabIndex = 15;
            this.label_id.Text = "-";
            // 
            // label_type
            // 
            this.label_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_type.Location = new System.Drawing.Point(208, 144);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(19, 25);
            this.label_type.TabIndex = 16;
            this.label_type.Text = "-";
            // 
            // label_brand
            // 
            this.label_brand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_brand.AutoSize = true;
            this.label_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_brand.Location = new System.Drawing.Point(208, 102);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(19, 25);
            this.label_brand.TabIndex = 17;
            this.label_brand.Text = "-";
            // 
            // label_producer
            // 
            this.label_producer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_producer.AutoSize = true;
            this.label_producer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_producer.Location = new System.Drawing.Point(208, 185);
            this.label_producer.Name = "label_producer";
            this.label_producer.Size = new System.Drawing.Size(19, 25);
            this.label_producer.TabIndex = 18;
            this.label_producer.Text = "-";
            // 
            // label_gender
            // 
            this.label_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_gender.Location = new System.Drawing.Point(208, 224);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(19, 25);
            this.label_gender.TabIndex = 19;
            this.label_gender.Text = "-";
            // 
            // label_price
            // 
            this.label_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_price.Location = new System.Drawing.Point(208, 261);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(19, 25);
            this.label_price.TabIndex = 20;
            this.label_price.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(303, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Зробіть свій вибір";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(313, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Розмір";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(313, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Кількість";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.storageBindingSource;
            this.comboBox1.DisplayMember = "Size";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(426, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.ValueMember = "ProductCode";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            this.storageBindingSource.DataSource = this.clothingShopDataSet;
            // 
            // clothingShopDataSet
            // 
            this.clothingShopDataSet.DataSetName = "ClothingShopDataSet";
            this.clothingShopDataSet.EnforceConstraints = false;
            this.clothingShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(426, 96);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 28);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            this.numericUpDown1.Leave += new System.EventHandler(this.numericUpDown1_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(629, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 29);
            this.label11.TabIndex = 26;
            this.label11.Text = "Разом\r\n";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(598, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Вартість";
            // 
            // label_sum
            // 
            this.label_sum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_sum.AutoSize = true;
            this.label_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sum.Location = new System.Drawing.Point(697, 60);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(19, 25);
            this.label_sum.TabIndex = 28;
            this.label_sum.Text = "-";
            // 
            // button_OK
            // 
            this.button_OK.AutoSize = true;
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(318, 314);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(179, 39);
            this.button_OK.TabIndex = 29;
            this.button_OK.Text = "Додати товар";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.AutoSize = true;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(14, 314);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(114, 39);
            this.button_cancel.TabIndex = 30;
            this.button_cancel.Text = "Назад";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_delivery
            // 
            this.button_delivery.AutoSize = true;
            this.button_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delivery.Location = new System.Drawing.Point(548, 314);
            this.button_delivery.Name = "button_delivery";
            this.button_delivery.Size = new System.Drawing.Size(255, 39);
            this.button_delivery.TabIndex = 31;
            this.button_delivery.Text = "Оформити доставку";
            this.button_delivery.UseVisualStyleBackColor = true;
            this.button_delivery.Click += new System.EventHandler(this.button_delivery_Click);
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // button_UPD
            // 
            this.button_UPD.AutoSize = true;
            this.button_UPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_UPD.Location = new System.Drawing.Point(647, 314);
            this.button_UPD.Name = "button_UPD";
            this.button_UPD.Size = new System.Drawing.Size(156, 39);
            this.button_UPD.TabIndex = 32;
            this.button_UPD.Text = "Редагувати";
            this.button_UPD.UseVisualStyleBackColor = true;
            this.button_UPD.Visible = false;
            this.button_UPD.Click += new System.EventHandler(this.button_UPD_Click);
            // 
            // ChooseProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 365);
            this.Controls.Add(this.button_UPD);
            this.Controls.Add(this.button_delivery);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_sum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_producer);
            this.Controls.Add(this.label_brand);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "ChooseProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати товар до кошика";
            this.Load += new System.EventHandler(this.ChooseProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_brand;
        private System.Windows.Forms.Label label_producer;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_sum;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_delivery;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private ClothingShopDataSetTableAdapters.StorageTableAdapter storageTableAdapter;
        private ClothingShopDataSet clothingShopDataSet;
        private ClothingShopDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.Button button_UPD;
    }
}