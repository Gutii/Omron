using System;
using System.Windows.Forms;

namespace ASHK.SRTApp.Forms
{
    public partial class FormAbout : DevExpress.XtraEditors.XtraForm
    {

        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            // Get the AssemblyInfo class.
            Common.AssemblyInfo info = new Common.AssemblyInfo();
            this.Text = string.Format("О программе: {0}", info.Title);
            this.ProductName.Text = string.Format("{0}", info.Product);
            this.Version.Text = string.Format("Версия: {0}", info.AssemblyVersion);
            this.Copyright.Text = string.Format("{0}", info.Copyright);
            this.CompanyName.Text = string.Format("{0}", info.Company);
            this.Description.Text = string.Format("   {0}", info.Description);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
