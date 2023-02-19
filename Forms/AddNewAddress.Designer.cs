namespace CourseProject
{
    partial class AddNewAddress
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
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_flatNum = new System.Windows.Forms.TextBox();
            this.textBox_frontDoorNum = new System.Windows.Forms.TextBox();
            this.textBox_houseNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.addressTableAdapter1 = new CourseProject.ClothingShopDataSetTableAdapters.AddressTableAdapter();
            this.deliveryTableAdapter1 = new CourseProject.ClothingShopDataSetTableAdapters.DeliveryTableAdapter();
            this.clothingShopDataSet1 = new CourseProject.ClothingShopDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.clothingShopDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "* - поля, обов\'язкові для заповнення";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(355, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 25);
            this.label16.TabIndex = 70;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(355, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 25);
            this.label15.TabIndex = 69;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(355, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 25);
            this.label14.TabIndex = 68;
            this.label14.Text = "*";
            // 
            // textBox_flatNum
            // 
            this.textBox_flatNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_flatNum.Location = new System.Drawing.Point(155, 236);
            this.textBox_flatNum.Name = "textBox_flatNum";
            this.textBox_flatNum.Size = new System.Drawing.Size(194, 27);
            this.textBox_flatNum.TabIndex = 67;
            // 
            // textBox_frontDoorNum
            // 
            this.textBox_frontDoorNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_frontDoorNum.Location = new System.Drawing.Point(155, 203);
            this.textBox_frontDoorNum.Name = "textBox_frontDoorNum";
            this.textBox_frontDoorNum.Size = new System.Drawing.Size(194, 27);
            this.textBox_frontDoorNum.TabIndex = 66;
            // 
            // textBox_houseNum
            // 
            this.textBox_houseNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_houseNum.Location = new System.Drawing.Point(155, 170);
            this.textBox_houseNum.Name = "textBox_houseNum";
            this.textBox_houseNum.Size = new System.Drawing.Size(194, 27);
            this.textBox_houseNum.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(12, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 25);
            this.label13.TabIndex = 64;
            this.label13.Text = "№ квартири";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 25);
            this.label12.TabIndex = 63;
            this.label12.Text = "№ під\'їзду";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 25);
            this.label11.TabIndex = 62;
            this.label11.Text = "№ будинку";
            // 
            // textBox_street
            // 
            this.textBox_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_street.Location = new System.Drawing.Point(155, 132);
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(194, 27);
            this.textBox_street.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 60;
            this.label10.Text = "Вулиця";
            // 
            // textBox_city
            // 
            this.textBox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_city.Location = new System.Drawing.Point(155, 99);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(194, 27);
            this.textBox_city.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 58;
            this.label9.Text = "Місто";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_address.Location = new System.Drawing.Point(117, 44);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(176, 25);
            this.label_address.TabIndex = 57;
            this.label_address.Text = "Адреса доставки:";
            // 
            // button_cancel
            // 
            this.button_cancel.AutoSize = true;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(12, 305);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(114, 39);
            this.button_cancel.TabIndex = 71;
            this.button_cancel.Text = "Назад";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.AutoSize = true;
            this.button_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ok.Location = new System.Drawing.Point(262, 305);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(114, 39);
            this.button_ok.TabIndex = 72;
            this.button_ok.Text = "ОК";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // addressTableAdapter1
            // 
            this.addressTableAdapter1.ClearBeforeFill = true;
            // 
            // deliveryTableAdapter1
            // 
            this.deliveryTableAdapter1.ClearBeforeFill = true;
            // 
            // clothingShopDataSet1
            // 
            this.clothingShopDataSet1.DataSetName = "ClothingShopDataSet";
            this.clothingShopDataSet1.EnforceConstraints = false;
            this.clothingShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddNewAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 356);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_flatNum);
            this.Controls.Add(this.textBox_frontDoorNum);
            this.Controls.Add(this.textBox_houseNum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_street);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label1);
            this.Name = "AddNewAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введення нової адреси";
            ((System.ComponentModel.ISupportInitialize)(this.clothingShopDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_flatNum;
        private System.Windows.Forms.TextBox textBox_frontDoorNum;
        private System.Windows.Forms.TextBox textBox_houseNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_street;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private ClothingShopDataSetTableAdapters.AddressTableAdapter addressTableAdapter1;
        private ClothingShopDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter1;
        private ClothingShopDataSet clothingShopDataSet1;
    }
}