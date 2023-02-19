namespace CourseProject
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_logIn = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clothingShopDataSet = new CourseProject.ClothingShopDataSet();
            this.deliveryTableAdapter1 = new CourseProject.ClothingShopDataSetTableAdapters.DeliveryTableAdapter();
            this.addressTableAdapter1 = new CourseProject.ClothingShopDataSetTableAdapters.AddressTableAdapter();
            this.clientTableAdapter = new CourseProject.ClothingShopDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new CourseProject.ClothingShopDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(165, 77);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(194, 30);
            this.textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(165, 133);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(194, 30);
            this.textBox_password.TabIndex = 1;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(69, 82);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(61, 25);
            this.label_login.TabIndex = 2;
            this.label_login.Text = "Логін";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.Location = new System.Drawing.Point(69, 133);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(80, 25);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Пароль";
            // 
            // button_logIn
            // 
            this.button_logIn.AutoSize = true;
            this.button_logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_logIn.Location = new System.Drawing.Point(74, 230);
            this.button_logIn.Name = "button_logIn";
            this.button_logIn.Size = new System.Drawing.Size(82, 35);
            this.button_logIn.TabIndex = 4;
            this.button_logIn.Text = "Увійти";
            this.button_logIn.UseVisualStyleBackColor = true;
            this.button_logIn.Click += new System.EventHandler(this.button_logIn_Click);
            // 
            // button_register
            // 
            this.button_register.AutoSize = true;
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_register.Location = new System.Drawing.Point(176, 230);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(183, 35);
            this.button_register.TabIndex = 5;
            this.button_register.Text = "Зареєструватися";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Client";
            this.bindingSource1.DataSource = this.clothingShopDataSet;
            // 
            // clothingShopDataSet
            // 
            this.clothingShopDataSet.DataSetName = "ClothingShopDataSet";
            this.clothingShopDataSet.EnforceConstraints = false;
            this.clothingShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryTableAdapter1
            // 
            this.deliveryTableAdapter1.ClearBeforeFill = true;
            // 
            // addressTableAdapter1
            // 
            this.addressTableAdapter1.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddressTableAdapter = this.addressTableAdapter1;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.CatalogTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.ClothingTypeTableAdapter = null;
            this.tableAdapterManager.DeliveryTableAdapter = this.deliveryTableAdapter1;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.Product_MaterialTableAdapter = null;
            this.tableAdapterManager.StorageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CourseProject.ClothingShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 290);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_logIn);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід до ІС \"Магазин одягу\"";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingShopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_logIn;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ClothingShopDataSet clothingShopDataSet;
        private ClothingShopDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter1;
        private ClothingShopDataSetTableAdapters.AddressTableAdapter addressTableAdapter1;
        private ClothingShopDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private ClothingShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

