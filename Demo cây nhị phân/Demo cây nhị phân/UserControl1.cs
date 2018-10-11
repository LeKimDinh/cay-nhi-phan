using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Demo_cây_nhị_phân;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Text.RegularExpressions;

namespace Demo_cây_nhị_phân
{
    partial class UserControl1 : UserControl
    {
        const int RADIUS = 20;         
        const int DIAMETER = RADIUS * 2;   
        const int HOR_DISTANCE = 70;       
        const int VER_DISTANCE = 100;    

        Pen _penNormal;
        Pen _penHighLight;
        Brush _brush;
        Font _font;

        BinaryTree<int> _Tree;

        float _leftRoot;
        float _minLeft;
        float _maxLeft;

        float _ratio;

        public Image Image
        {
            get { return pictureBox1.Image; }
        }

        Graphics _g;

        Queue<int> _queue;

        public int NodeCount
        {
            get { return _Tree.Count; }
        }
        public int TreeHeight
        {
            get { return _Tree.GetHeight(); }
        }


        public UserControl1()
        {
            InitializeComponent();

         
            _brush = new LinearGradientBrush(new Rectangle(0, VER_DISTANCE / 2, 100, VER_DISTANCE),
        Color.LightSkyBlue, Color.White, LinearGradientMode.Vertical);
            _penNormal = new Pen(Color.DarkOrange, 2);
            _penHighLight = new Pen(Color.Red, 3);
            _font = new Font("Arial", 18);
            _Tree = new BinaryTree<int>(50);


        }

        public void GenerateTree(int size, int min, int max)
        {
            if (min >= max || (max - min < size))
            {
                MessageBox.Show("Invalid parameters!", "OMG");
                return;
            }
            _queue = null;
            _Tree.Clear();
            Random rnd = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(min, max);
            _Tree.Add(arr);
            //BeginDraw(true);
        }
       
    }
}
