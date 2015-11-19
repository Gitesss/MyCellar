namespace CellarPanel
{
    partial class CellarControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cellarPanel1 = new CellarPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdtnCellarBorder = new System.Windows.Forms.RadioButton();
            this.rdtnSegmentsBorder = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cellarPanel1
            // 
            this.cellarPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cellarPanel1.BackColor = System.Drawing.Color.White;
            this.cellarPanel1.DotDistance = 10;
            this.cellarPanel1.DotHeight = 10;
            this.cellarPanel1.Location = new System.Drawing.Point(0, 0);
            this.cellarPanel1.Name = "cellarPanel1";
            this.cellarPanel1.Size = new System.Drawing.Size(452, 401);
            this.cellarPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdtnCellarBorder);
            this.groupBox1.Controls.Add(this.rdtnSegmentsBorder);
            this.groupBox1.Location = new System.Drawing.Point(3, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rdtnCellarBorder
            // 
            this.rdtnCellarBorder.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdtnCellarBorder.AutoSize = true;
            this.rdtnCellarBorder.Location = new System.Drawing.Point(143, 11);
            this.rdtnCellarBorder.Name = "rdtnCellarBorder";
            this.rdtnCellarBorder.Size = new System.Drawing.Size(65, 27);
            this.rdtnCellarBorder.TabIndex = 3;
            this.rdtnCellarBorder.TabStop = true;
            this.rdtnCellarBorder.Text = "Piwnica";
            this.rdtnCellarBorder.UseVisualStyleBackColor = true;
            // 
            // rdtnSegmentsBorder
            // 
            this.rdtnSegmentsBorder.AllowDrop = true;
            this.rdtnSegmentsBorder.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdtnSegmentsBorder.AutoSize = true;
            this.rdtnSegmentsBorder.Location = new System.Drawing.Point(214, 11);
            this.rdtnSegmentsBorder.Name = "rdtnSegmentsBorder";
            this.rdtnSegmentsBorder.Size = new System.Drawing.Size(81, 27);
            this.rdtnSegmentsBorder.TabIndex = 2;
            this.rdtnSegmentsBorder.TabStop = true;
            this.rdtnSegmentsBorder.Text = "Segmenty";
            this.rdtnSegmentsBorder.UseVisualStyleBackColor = true;
            // 
            // CellarControl
            // 
            this.AllowDrop = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cellarPanel1);
            this.Name = "CellarControl";
            this.Size = new System.Drawing.Size(450, 450);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CellarPanel cellarPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdtnCellarBorder;
        private System.Windows.Forms.RadioButton rdtnSegmentsBorder;

       



    }
}
