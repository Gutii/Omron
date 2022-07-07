
namespace ASHK.SRTApp.Forms
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CompanyName = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.67651F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.32349F));
            this.tableLayoutPanel1.Controls.Add(this.LogoPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 409);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(204, 403);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.CompanyName, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Copyright, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ProductName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Version, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Description, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonOk, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(213, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.28358F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.71642F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(495, 403);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyName.Location = new System.Drawing.Point(3, 107);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(489, 56);
            this.CompanyName.TabIndex = 5;
            this.CompanyName.Text = "Название организации";
            this.CompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Copyright.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Copyright.Location = new System.Drawing.Point(3, 67);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(489, 40);
            this.Copyright.TabIndex = 2;
            this.Copyright.Text = "Авторские права";
            this.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductName.Location = new System.Drawing.Point(3, 0);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(489, 29);
            this.ProductName.TabIndex = 0;
            this.ProductName.Text = "Имя продукта";
            this.ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Version.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Version.Location = new System.Drawing.Point(3, 29);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(489, 38);
            this.Version.TabIndex = 1;
            this.Version.Text = "Версия";
            this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Description
            // 
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(3, 166);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Description.Size = new System.Drawing.Size(489, 198);
            this.Description.TabIndex = 6;
            this.Description.Text = "Description:\r\n\r\n(Во время выполнения текст подписи будет заменен информацией о сб" +
    "орке приложения.\r\nНастроить эту информацию можно в области \'Приложение\' конструк" +
    "тора проектов.)\r\n";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(417, 377);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 409);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormAbout.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbout";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
#pragma warning disable CS0108 // "FormAbout.CompanyName" скрывает наследуемый член "Control.CompanyName". Если скрытие было намеренным, используйте ключевое слово new.
        private System.Windows.Forms.Label CompanyName;
#pragma warning restore CS0108 // "FormAbout.CompanyName" скрывает наследуемый член "Control.CompanyName". Если скрытие было намеренным, используйте ключевое слово new.
        private System.Windows.Forms.Label Copyright;
#pragma warning disable CS0108 // "FormAbout.ProductName" скрывает наследуемый член "Control.ProductName". Если скрытие было намеренным, используйте ключевое слово new.
        private System.Windows.Forms.Label ProductName;
#pragma warning restore CS0108 // "FormAbout.ProductName" скрывает наследуемый член "Control.ProductName". Если скрытие было намеренным, используйте ключевое слово new.
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Button buttonOk;
    }
}