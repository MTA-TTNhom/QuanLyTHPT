namespace QLHocSinhTHPT
{
    partial class frmConnection
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
            private void InitializeComponent()
            {
                this.groupPanelLeft = new DevComponents.DotNetBar.Controls.GroupPanel();
                this.reflectionImage = new DevComponents.DotNetBar.Controls.ReflectionImage();
                this.labelX1 = new DevComponents.DotNetBar.LabelX();
                this.labelX2 = new DevComponents.DotNetBar.LabelX();
                this.labelX3 = new DevComponents.DotNetBar.LabelX();
                this.labelX4 = new DevComponents.DotNetBar.LabelX();
                this.labelX5 = new DevComponents.DotNetBar.LabelX();
                this.txtServer = new DevComponents.DotNetBar.Controls.TextBoxX();
                this.cmbAuthentication = new DevComponents.DotNetBar.Controls.ComboBoxEx();
                this.winAuth = new DevComponents.Editors.ComboItem();
                this.sqlServerAuth = new DevComponents.Editors.ComboItem();
                this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
                this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
                this.btnTestConnection = new DevComponents.DotNetBar.ButtonX();
                this.cmbDatabase = new DevComponents.DotNetBar.Controls.ComboBoxEx();
                this.btnOK = new DevComponents.DotNetBar.ButtonX();
                this.btnCancel = new DevComponents.DotNetBar.ButtonX();
                this.panelLine = new System.Windows.Forms.Panel();
                this.groupPanelLeft.SuspendLayout();
                this.SuspendLayout();
                // 
                // groupPanelLeft
                // 
                this.groupPanelLeft.CanvasColor = System.Drawing.SystemColors.Control;
                this.groupPanelLeft.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
                this.groupPanelLeft.Controls.Add(this.reflectionImage);
                this.groupPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
                this.groupPanelLeft.Location = new System.Drawing.Point(0, 0);
                this.groupPanelLeft.Name = "groupPanelLeft";
                this.groupPanelLeft.Size = new System.Drawing.Size(150, 268);
                // 
                // 
                // 
                this.groupPanelLeft.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
                this.groupPanelLeft.Style.BackColorGradientAngle = 90;
                this.groupPanelLeft.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
                this.groupPanelLeft.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                this.groupPanelLeft.Style.BorderBottomWidth = 1;
                this.groupPanelLeft.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
                this.groupPanelLeft.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
                this.groupPanelLeft.Style.BorderLeftWidth = 1;
                this.groupPanelLeft.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
                this.groupPanelLeft.Style.BorderRightWidth = 1;
                this.groupPanelLeft.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
                this.groupPanelLeft.Style.BorderTopWidth = 1;
                this.groupPanelLeft.Style.CornerDiameter = 4;
                this.groupPanelLeft.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
                this.groupPanelLeft.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
                this.groupPanelLeft.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
                this.groupPanelLeft.TabIndex = 0;
                // 
                // reflectionImage
                // 
                this.reflectionImage.BackColor = System.Drawing.Color.Transparent;
                this.reflectionImage.Image = global::QLHocSinhTHPT.Properties.Resources.connection;
                this.reflectionImage.Location = new System.Drawing.Point(10, 0);
                this.reflectionImage.Name = "reflectionImage";
                this.reflectionImage.Size = new System.Drawing.Size(128, 265);
                this.reflectionImage.TabIndex = 0;
                // 
                // labelX1
                // 
                this.labelX1.BackColor = System.Drawing.Color.Transparent;
                this.labelX1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelX1.Location = new System.Drawing.Point(170, 15);
                this.labelX1.Name = "labelX1";
                this.labelX1.Size = new System.Drawing.Size(88, 20);
                this.labelX1.TabIndex = 0;
                this.labelX1.Text = "Server:";
                // 
                // labelX2
                // 
            }

            #endregion
        }
}