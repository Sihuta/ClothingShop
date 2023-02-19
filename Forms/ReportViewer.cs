using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class ReportViewer : Form
    {
        string reportType;
        int[] productID;

        public ReportViewer()
        {
            InitializeComponent();
        }

        public ReportViewer(string report)
            : this()
        {
            reportType = report;            
        }

        public ReportViewer(int[] productId)
            : this()
        {
            productID = productId;
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {   
            switch (reportType)
            {
                case "order":
                    loadOrderReport();
                    break;
                case "receipt":
                    loadReceiptReport();
                    break;
            }
            if (productID != null && productID.Length > 0)
            {
                loadProductAmount();
            }
        }

        void loadOrderReport()
        {
            string query = "SELECT * FROM UserOrder WHERE Delivery_id = @DeliveryID";
            bindingSource = DataAccess.MakeComplexQuery(query, "@DeliveryID", Client.DeliveryID);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", bindingSource));
            reportViewer1.LocalReport.ReportPath = @"C:\Users\dsigu\OneDrive - Kharkov National University of Radioelectronics\2-й курс\CourseProject\Reports\OrderReport.rdlc";

            ReportParameter repParam = new ReportParameter("DeliveryID", Client.DeliveryID.ToString(), true);
            reportViewer1.LocalReport.SetParameters(repParam);

            reportViewer1.RefreshReport();
        }

        void loadReceiptReport()
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\dsigu\OneDrive - Kharkov National University of Radioelectronics\2-й курс\CourseProject\Reports\ReceiptReport.rdlc";

            var query = "SELECT SUM(Sum) FROM UserOrder WHERE Delivery_id = @DeliveryID";
            
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DeliveryID", Client.DeliveryID.ToString(), true));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("UserName", getClientName(), true));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Sum", DataAccess.MakeValueQuery(query, "DeliveryID", Client.DeliveryID).ToString(), true));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bindingSource));

            reportViewer1.RefreshReport();
        }

        string getClientName()
        {
            DataTable dt = Client.GetClientData(Client.GetFullNameQuery);
            return dt.Rows[0].ItemArray[0].ToString() + " " + dt.Rows[0].ItemArray[1].ToString() + " " + dt.Rows[0].ItemArray[2].ToString();
         }

        void loadProductAmount()
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            bindingSource = DataAccess.DisplayNotReadyProdAmount(productID);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bindingSource));
            reportViewer1.LocalReport.ReportPath = @"C:\Users\dsigu\OneDrive - Kharkov National University of Radioelectronics\2-й курс\CourseProject\Reports\AvailableProductAmount.rdlc";

            reportViewer1.RefreshReport();
        }
    }
}
