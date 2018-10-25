using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo_cây_nhị_phân;

namespace Demo_cây_nhị_phân
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnGenerateTree_Click(object sender, EventArgs e)
        {
            userControl11.GenerateTree((int)numSize.Value,
               (int)numMin.Value, (int)numMax.Value);

            UpdateInfo();
        }
        void UpdateInfo()
        {
            lblNodeCount.Text = "Node Count: " + userControl11.NodeCount;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

           
            if (!userControl11.AddNode((int)numericUpDown1.Value))
                userControl11.Text = "Tree already contain an node with that value";
            else
                UpdateInfo();

        }
    }
}
