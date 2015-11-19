using CellarPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCellar
{
    public partial class FormMain : Form , ISetName
    {
        public FormMain()
        {

            InitializeComponent();
            this.cellarPanel = new CellarPanel.CellarPanel(this);
            this.Controls.Add(this.cellarPanel);
            this.cellarPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cellarPanel.DotDistance = 20;
            this.cellarPanel.DotHeight = 2;
            this.cellarPanel.Location = new System.Drawing.Point(12, 12);
            this.cellarPanel.Name = "cellarPanel1";
            this.cellarPanel.Size = new System.Drawing.Size(370, 400);
            this.cellarPanel.TabIndex = 0;
         
        }

        string ISetName.Name
        {
            get
            {
                return txtbName.Text;
            }
            set
            {           
                txtbName.Text = value;
            }
        }

        private void txtbName_TextChanged(object sender, EventArgs e)
        {
            cellarPanel.SetNewSegmentName(txtbName.Text);

        }

        public List<Segments> SegmentsList
        {
            set
            {
                cmbSegments.Items.Clear();
                foreach(Segments actuallSegment in value)
                {
                    cmbSegments.Items.Add(actuallSegment.Name);
                }
            }
        }

        public string ActualSelectedSegment
        {
            set 
            {
                cmbSegments.Text = String.Empty;
                cmbSegments.SelectedText = value;
             
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cellarPanel.AdditemToSegment(comboBox1.Text, cmbSegments.Text);
        }


        public List<string> ItemsList
        {
            set 
            {
                listViewSegments.Items.Clear();
                foreach(string item in value)
                listViewSegments.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cellarPanel.SearchSegment(cmbFind.Text);
        }
    }
}
