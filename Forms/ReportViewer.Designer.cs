namespace CourseProject
{
    partial class ReportViewer
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductAmountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClothingShopDataSet = new CourseProject.ClothingShopDataSet();
            this.ProductsCatalogTableAdapter = new CourseProject.ClothingShopDataSetTableAdapters.ProductsCatalogTableAdapter();
            this.ProductAmountTableAdapter = new CourseProject.ClothingShopDataSetTableAdapters.ProductAmountTableAdapter();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client1TableAdapter = new CourseProject.ClothingShopDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAmountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClothingShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CourseProject.OrderReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1366, 481);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProductAmountBindingSource
            // 
            this.ProductAmountBindingSource.DataMember = "ProductAmount";
            this.ProductAmountBindingSource.DataSource = this.ClothingShopDataSet;
            // 
            // ClothingShopDataSet
            // 
            this.ClothingShopDataSet.DataSetName = "ClothingShopDataSet";
            this.ClothingShopDataSet.EnforceConstraints = false;
            this.ClothingShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductsCatalogTableAdapter
            // 
            this.ProductsCatalogTableAdapter.ClearBeforeFill = true;
            // 
            // ProductAmountTableAdapter
            // 
            this.ProductAmountTableAdapter.ClearBeforeFill = true;
            // 
            // client1TableAdapter1
            // 
            this.client1TableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 481);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportViewer";
            this.Text = "ReportViewer";
            this.Load += new System.EventHandler(this.ReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductAmountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClothingShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bindingSource;
        private ClothingShopDataSet ClothingShopDataSet;
        private ClothingShopDataSetTableAdapters.ProductsCatalogTableAdapter ProductsCatalogTableAdapter;
        private System.Windows.Forms.BindingSource ProductAmountBindingSource;
        private ClothingShopDataSetTableAdapters.ProductAmountTableAdapter ProductAmountTableAdapter;
        private ClothingShopDataSetTableAdapters.ClientTableAdapter client1TableAdapter;
    }
}