namespace MyCellar
{
    partial class FormMain
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listViewSegments = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.cmbSegments = new System.Windows.Forms.ComboBox();
            this.lblSegments = new System.Windows.Forms.Label();
            this.lblContents = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // listViewSegments
            // 
            this.listViewSegments.Location = new System.Drawing.Point(23, 230);
            this.listViewSegments.Name = "listViewSegments";
            this.listViewSegments.Size = new System.Drawing.Size(170, 183);
            this.listViewSegments.TabIndex = 2;
            this.listViewSegments.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cmbFind);
            this.groupBox1.Controls.Add(this.lblFind);
            this.groupBox1.Controls.Add(this.cmbSegments);
            this.groupBox1.Controls.Add(this.lblSegments);
            this.groupBox1.Controls.Add(this.lblContents);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.listViewSegments);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(518, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 422);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elementy";
            // 
            // cmbFind
            // 
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.Location = new System.Drawing.Point(126, 176);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(121, 24);
            this.cmbFind.TabIndex = 9;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(23, 179);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(70, 17);
            this.lblFind.TabIndex = 8;
            this.lblFind.Text = "Szukanie:";
            // 
            // cmbSegments
            // 
            this.cmbSegments.FormattingEnabled = true;
            this.cmbSegments.Location = new System.Drawing.Point(126, 84);
            this.cmbSegments.Name = "cmbSegments";
            this.cmbSegments.Size = new System.Drawing.Size(121, 24);
            this.cmbSegments.TabIndex = 7;
            // 
            // lblSegments
            // 
            this.lblSegments.AutoSize = true;
            this.lblSegments.Location = new System.Drawing.Point(23, 87);
            this.lblSegments.Name = "lblSegments";
            this.lblSegments.Size = new System.Drawing.Size(68, 17);
            this.lblSegments.TabIndex = 6;
            this.lblSegments.Text = "Segment:";
            // 
            // lblContents
            // 
            this.lblContents.AutoSize = true;
            this.lblContents.Location = new System.Drawing.Point(23, 210);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(77, 17);
            this.lblContents.TabIndex = 5;
            this.lblContents.Text = "Zawartość:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nowy element:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(518, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rejon piwnicy";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(126, 37);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(121, 22);
            this.txtbName.TabIndex = 1;
            this.txtbName.TextChanged += new System.EventHandler(this.txtbName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nazwa";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(253, 178);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "My Cellar storegate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CellarPanel.CellarPanel cellarPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listViewSegments;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFind;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.ComboBox cmbSegments;
        private System.Windows.Forms.Label lblSegments;
        private System.Windows.Forms.Label lblContents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;


    }
}

