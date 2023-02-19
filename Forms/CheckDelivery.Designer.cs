namespace CourseProject
{
    partial class CheckDelivery
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
            comboBox_address = new System.Windows.Forms.ComboBox();
            this.addressTableAdapter1 = new CourseProject.ClothingShopDataSetTableAdapters.AddressTableAdapter();
            this.button_newAddress = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_order = new System.Windows.Forms.Button();
            this.button_receipt = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_makeDel = new System.Windows.Forms.Button();
            this.clientTableAdapter1 = new CourseProject.ClothingShopDataSetTableAdapters.ClientTableAdapter();
            this.deliveryTableAdapter = new CourseProject.ClothingShopDataSetTableAdapters.DeliveryTableAdapter();
            this.storageTableAdapter = new CourseProject.ClothingShopDataSetTableAdapters.StorageTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оберіть необхідну адресу доставки:";
            // 
            // comboBox_address
            // 
            comboBox_address.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            comboBox_address.FormattingEnabled = true;
            comboBox_address.Location = new System.Drawing.Point(396, 8);
            comboBox_address.Name = "comboBox_address";
            comboBox_address.Size = new System.Drawing.Size(672, 28);
            comboBox_address.TabIndex = 1;
            // 
            // addressTableAdapter1
            // 
            this.addressTableAdapter1.ClearBeforeFill = true;
            // 
            // button_newAddress
            // 
            this.button_newAddress.AutoSize = true;
            this.button_newAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_newAddress.Location = new System.Drawing.Point(1095, 8);
            this.button_newAddress.Name = "button_newAddress";
            this.button_newAddress.Size = new System.Drawing.Size(187, 30);
            this.button_newAddress.TabIndex = 2;
            this.button_newAddress.Text = "Ввести нову адресу";
            this.button_newAddress.UseVisualStyleBackColor = true;
            this.button_newAddress.Click += new System.EventHandler(this.button_newAddress_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Електронна пошта, на яку прийде лист-підтвердження:";
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_email.Location = new System.Drawing.Point(595, 49);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(227, 27);
            this.textBox_email.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Перевірте звітну документацію:";
            // 
            // button_order
            // 
            this.button_order.AutoSize = true;
            this.button_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_order.Location = new System.Drawing.Point(343, 89);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(136, 30);
            this.button_order.TabIndex = 20;
            this.button_order.Text = "Замовлення";
            this.button_order.UseVisualStyleBackColor = true;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // button_receipt
            // 
            this.button_receipt.AutoSize = true;
            this.button_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_receipt.Location = new System.Drawing.Point(500, 89);
            this.button_receipt.Name = "button_receipt";
            this.button_receipt.Size = new System.Drawing.Size(118, 30);
            this.button_receipt.TabIndex = 21;
            this.button_receipt.Text = "Квитанція";
            this.button_receipt.UseVisualStyleBackColor = true;
            this.button_receipt.Click += new System.EventHandler(this.button_receipt_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.AutoSize = true;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(17, 172);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(114, 39);
            this.button_cancel.TabIndex = 34;
            this.button_cancel.Text = "Назад";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_makeDel
            // 
            this.button_makeDel.AutoSize = true;
            this.button_makeDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_makeDel.Location = new System.Drawing.Point(1016, 172);
            this.button_makeDel.Name = "button_makeDel";
            this.button_makeDel.Size = new System.Drawing.Size(276, 39);
            this.button_makeDel.TabIndex = 35;
            this.button_makeDel.Text = "Замовити доставку";
            this.button_makeDel.UseVisualStyleBackColor = true;
            this.button_makeDel.Click += new System.EventHandler(this.button_makeDel_Click);
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(624, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "* рекомендовано зберегти";
            // 
            // CheckDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 223);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_makeDel);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_receipt);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_newAddress);
            this.Controls.Add(comboBox_address);
            this.Controls.Add(this.label1);
            this.Name = "CheckDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Замовлення доставки";
            this.Load += new System.EventHandler(this.CheckDelivery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private static System.Windows.Forms.ComboBox comboBox_address;
        private ClothingShopDataSetTableAdapters.AddressTableAdapter addressTableAdapter1;
        private System.Windows.Forms.Button button_newAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_order;
        private System.Windows.Forms.Button button_receipt;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_makeDel;
        private ClothingShopDataSetTableAdapters.ClientTableAdapter clientTableAdapter1;
        private ClothingShopDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
        private ClothingShopDataSetTableAdapters.StorageTableAdapter storageTableAdapter;
        private System.Windows.Forms.Label label4;
    }
}