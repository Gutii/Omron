using System;
using System.Drawing;
using System.Windows.Forms;

namespace ASHK.SRTApp.Forms
{
    public partial class FormSettings : System.Windows.Forms.Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
            for (int i = 1; i <= 78; i++)
            {
                listFontSizeMain.Items.Add(i);
                listGropPanel.Items.Add(i);
            }
        }

        private void LoadSettings()
        {
            #region "AplicationSettings"
            textBox4.Text = Common.StaticAppHelper.Settings.AplicationSettings.ClientName;
            checkBox5.Checked = Common.StaticAppHelper.Settings.AplicationSettings.LoadDB;
            checkBox6.Checked = Common.StaticAppHelper.Settings.AplicationSettings.EnableSettings;
            checkBox7.Checked = Common.StaticAppHelper.Settings.AplicationSettings.EnableConnectDB;
            checkBox10.Checked = Common.StaticAppHelper.Settings.AplicationSettings.AutoUpdate;
            textBox2.Text = Common.StaticAppHelper.Settings.AplicationSettings.PathUpdate;
            #endregion
            #region "LogsSettings"
            checkBox3.Checked = Common.StaticAppHelper.Settings.LogsSettings.SaveFile;
            checkBox4.Checked = Common.StaticAppHelper.Settings.LogsSettings.CleanFile;
            spinEdit1.Value = Common.StaticAppHelper.Settings.LogsSettings.CleanFileCount;
            checkBox2.Checked = Common.StaticAppHelper.Settings.LogsSettings.SaveDB;
            checkBox1.Checked = Common.StaticAppHelper.Settings.LogsSettings.SaveEvent;
            #endregion
            #region "ScalesSettings"
            textBox1.Text = Common.StaticAppHelper.Settings.ScalesSettings.IP;
            spinEdit2.Value = Common.StaticAppHelper.Settings.ScalesSettings.Port;
            textBox3.Text = Common.StaticAppHelper.Settings.ScalesSettings.Name;
            #endregion
            #region "FontSizeSettings"
            numericSizeFontMain.Value = (decimal)Common.StaticAppHelper.Settings.FontSizeSettings.MainLabelSettings;
            numericGropPanel.Value = (decimal)Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings;
            #endregion
        }


        private void button1_Click(object sender, EventArgs e)
        {
            #region "AplicationSettings"
            Common.StaticAppHelper.Settings.AplicationSettings.ClientName = textBox4.Text;
            Common.StaticAppHelper.Settings.AplicationSettings.LoadDB = checkBox5.Checked;
            Common.StaticAppHelper.Settings.AplicationSettings.EnableSettings = checkBox6.Checked;
            Common.StaticAppHelper.Settings.AplicationSettings.EnableConnectDB = checkBox7.Checked;
            Common.StaticAppHelper.Settings.AplicationSettings.AutoUpdate = checkBox10.Checked;
            Common.StaticAppHelper.Settings.AplicationSettings.PathUpdate = textBox2.Text;
            #endregion
            #region "LogsSettings"
            Common.StaticAppHelper.Settings.LogsSettings.SaveFile = checkBox3.Checked;
            Common.StaticAppHelper.Settings.LogsSettings.CleanFile = checkBox4.Checked;
            Common.StaticAppHelper.Settings.LogsSettings.CleanFileCount = (int)spinEdit1.Value;
            Common.StaticAppHelper.Settings.LogsSettings.SaveDB = checkBox2.Checked;
            Common.StaticAppHelper.Settings.LogsSettings.SaveEvent = checkBox1.Checked;
            #endregion
            #region "ScalesSettings"
            Common.StaticAppHelper.Settings.ScalesSettings.IP = textBox1.Text;
            Common.StaticAppHelper.Settings.ScalesSettings.Port = (int)spinEdit2.Value;
            Common.StaticAppHelper.Settings.ScalesSettings.Name = textBox3.Text;
            #endregion
            #region "FontSizeSettings"
            Common.StaticAppHelper.Settings.FontSizeSettings.MainLabelSettings = (int)numericSizeFontMain.Value;
            Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings = (int)numericGropPanel.Value;
            #endregion

            Common.StaticAppHelper.Settings.SaveToBD();
            Common.StaticAppHelper.FinalizeApp();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericGropPanel_ValueChanged(object sender, EventArgs e)
        {
            label4.Font = new Font(label8.Font.FontFamily, (float)numericGropPanel.Value, label8.Font.Style, label8.Font.Unit, label8.Font.GdiCharSet, label8.Font.GdiVerticalFont);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Common.WeighingHelper.MassaKScale = new MassaK.MassaKScale(Common.StaticAppHelper.Settings.ScalesSettings.IP, Common.StaticAppHelper.Settings.ScalesSettings.Port, Common.StaticAppHelper.Settings.ScalesSettings.Name);
                //Common.WeighingHelper.MassaKScale.ReadWeight();
                System.Windows.Forms.MessageBox.Show("Весы подключены!", "Информация", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Нет подключения к весам!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                Common.StaticAppHelper.LogWrite(ex);
            }
        }

        private void listFontSizeMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericSizeFontMain.Value = (int)((System.Windows.Forms.ListBox)sender).SelectedItem;
        }

        private void numericSizeFontMain_ValueChanged(object sender, EventArgs e)
        {
            label8.Font = new Font(label8.Font.FontFamily, (float)numericSizeFontMain.Value, label8.Font.Style, label8.Font.Unit, label8.Font.GdiCharSet, label8.Font.GdiVerticalFont);
        }

        private void listGropPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericGropPanel.Value = (int)((System.Windows.Forms.ListBox)sender).SelectedItem;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (!string.IsNullOrEmpty(textBox2.Text))
                openFileDialog.FileName = textBox2.Text;
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                textBox2.Text = openFileDialog.FileName;
            }
            openFileDialog.Dispose();
        }
    }
}
