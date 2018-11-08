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


            userControl11.AddNode((int)numericUpDown1.Value);      
                UpdateInfo();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            userControl11.SearchNode((int)numericUpDown1.Value);   
                UpdateInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           
        }

        private void btnInOrderTraverse_Click(object sender, EventArgs e)
        {
            userControl11.InOrderTraverse(); 
        }

        private void btnPreOrderTraverse_Click(object sender, EventArgs e)
        {
            userControl11.PreOrderTraverse();
        }

        private void btnPostOrderTraverse_Click(object sender, EventArgs e)
        {
            userControl11.PostOrderTraverse();
        }
    }
}
