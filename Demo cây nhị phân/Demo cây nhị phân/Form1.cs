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
            btnGenerateTree_Click(null, null);
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
            //lblTreeHeight.Text = "Tree Height: " + bsTreePanel1.TreeHeight;
        }
    }
}
