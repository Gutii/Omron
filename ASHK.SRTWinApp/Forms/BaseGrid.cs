using System;
using System.Windows.Forms;

namespace ASHK.SRTApp.Forms
{
    public partial class BaseGrid : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Common.Catalog Catalog;
        public string FormCaption
        {
            get
            {
                return this.ribbonPage1.Text;
            }
            set
            {
                this.ribbonPage1.Text = value;
            }
        }
        public string FormMenuCaption
        {
            get
            {
                return this.ribbonPage1.Text;
            }
            set
            {
                this.ribbonPage1.Text = value;
                this.Text = value;
            }
        }
        public BaseGrid(Common.Catalog catalog)
        {
            InitializeComponent();
            Catalog = catalog;

        }

        #region "Экспорт"
        private void bbiPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
        private void OpenFile(string fileName)
        {
            if (MessageBox.Show("Открыть файл экспорта?", "Экспорт в ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var process = new System.Diagnostics.Process();
                    // process.StartInfo.FileName = fileName
                    // process.StartInfo.Verb = "Открыть"
                    // process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                    // process.Start()
                    System.Diagnostics.Process.Start(fileName);
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }
            }
            // progressBarControl1.Position = 0
        }

        private string ShowSaveFileDialog(string title, string filter)
        {
            var dlg = new SaveFileDialog();
            string name = Application.ProductName;
            int n = name.LastIndexOf(".") + 1;
            if (n > 0)
            {
                name = name.Substring(n, name.Length - n);
            }

            dlg.Title = "Экспортировать в " + title;
            dlg.FileName = name;
            dlg.Filter = filter;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return dlg.FileName;
            }

            return "";
        }

        private void ExportToEx(string filename, string ext, DevExpress.XtraGrid.Views.Base.BaseView exportView)
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if (ext == "rtf")
            {
                exportView.ExportToRtf(filename);
            }

            if (ext == "pdf")
            {
                exportView.ExportToPdf(filename);
            }

            if (ext == "mht")
            {
                exportView.ExportToMht(filename);
            }

            if (ext == "htm")
            {
                exportView.ExportToHtml(filename);
            }

            if (ext == "txt")
            {
                exportView.ExportToText(filename);
            }

            if (ext == "xls")
            {
                exportView.ExportToXls(filename);
            }

            if (ext == "xlsx")
            {
                exportView.ExportToXlsx(filename);
            }

            if (ext == "csv")
            {
                exportView.ExportToCsv(filename);
            }

            Cursor.Current = currentCursor;
        }

        private void mnuExportHtml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string fileName = ShowSaveFileDialog("HTML Document", "HTML Documents|*.html");
            if ((fileName ?? "") == (string.Empty ?? ""))
            {
                return;
            }

            ExportToEx(fileName, "htm", gridView1);
            OpenFile(fileName);
        }

        private void mnuExportPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                string fileName = ShowSaveFileDialog("PDF Document", "PDF Files|*.pdf");
                if ((fileName ?? "") == (string.Empty ?? ""))
                {
                    return;
                }

                ExportToEx(fileName, "pdf", gridView1);
                OpenFile(fileName);
            }

        }

        private void mnuExportRtf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                string fileName = ShowSaveFileDialog("RTF Document", "RTF Files|*.rtf");
                if ((fileName ?? "") == (string.Empty ?? ""))
                {
                    return;
                }

                ExportToEx(fileName, "rtf", gridView1);
                OpenFile(fileName);
            }

        }

        private void mnuExportMht_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                string fileName = ShowSaveFileDialog("MHT Document", "MHT Files|*.mht");
                if ((fileName ?? "") == (string.Empty ?? ""))
                {
                    return;
                }

                ExportToEx(fileName, "mht", gridView1);
                OpenFile(fileName);
            }

        }

        private void mnuExportXls_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                string fileName = ShowSaveFileDialog("Microsoft Excel Document", "Microsoft Excel|*.xls");
                if ((fileName ?? "") == (string.Empty ?? ""))
                {
                    return;
                }

                ExportToEx(fileName, "xls", gridView1);
                OpenFile(fileName);
            }

        }

        private void mnuExportXLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                string fileName = ShowSaveFileDialog("Microsoft Excel 2007 Document", "Microsoft Excel|*.xlsx");
                if ((fileName ?? "") == (string.Empty ?? ""))
                {
                    return;
                }

                ExportToEx(fileName, "xlsx", gridView1);
                OpenFile(fileName);
            }

        }

        private void mnuExportTXT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                string fileName = ShowSaveFileDialog("Text Document", "Text Files|*.txt");
                if ((fileName ?? "") == (string.Empty ?? ""))
                {
                    return;
                }

                ExportToEx(fileName, "txt", gridView1);
                OpenFile(fileName);
            }

        }

        private void mnuExportCSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                string fileName = ShowSaveFileDialog("CSV Document", "CSV Files|*.csv");
                if ((fileName ?? "") == (string.Empty ?? ""))
                {
                    return;
                }

                ExportToEx(fileName, "csv", gridView1);
                OpenFile(fileName);
            }

        }
        #endregion

        private void BaseGrid_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            this.Name = FormCaption;
            var options = new DevExpress.XtraSplashScreen.OverlayWindowOptions(true, true, this.BackColor, this.ForeColor, 50);
            DevExpress.XtraSplashScreen.IOverlaySplashScreenHandle handle = DevExpress.XtraSplashScreen.SplashScreenManager.ShowOverlayForm(this, options);
            System.Data.SqlClient.SqlDataReader reader = null;
            try
            {
                switch (Catalog)
                {
                    case Common.Catalog.WeighingRawTires:
                        gridControl1.DataSource = Common.StaticAppHelper.GetWeighingTire();
                        break;
                    case Common.Catalog.RawTires:
                        gridControl1.DataSource = Common.StaticAppHelper.GetRawTire();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                handle.Close();
                gridView1.BestFitColumns();
            }
        }

        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                bsiRecordsCount.Caption = String.Format("Записей : {0}", gridView1.RowCount);
            }
            catch (Exception ex)
            {
                Common.StaticAppHelper.LogWrite(ex);
            }
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Refresh();
        }
    }
}
