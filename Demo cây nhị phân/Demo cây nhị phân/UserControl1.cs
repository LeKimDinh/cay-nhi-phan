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

        float _Root;
        float _min;
        float _max;

        float _ratio;

        public Image Image
        {
            get { return pictureBox1.Image; }
        }

        Graphics _g;

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

            this.SetStyle(ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer |
                ControlStyles.AllPaintingInWmPaint, true);

            _brush = new LinearGradientBrush(new Rectangle(0, VER_DISTANCE / 2, 100, VER_DISTANCE),
        Color.LightSkyBlue, Color.White, LinearGradientMode.Vertical);
            _penNormal = new Pen(Color.OrangeRed, 5);
            _penHighLight = new Pen(Color.Purple, 5);
            _font = new Font("Arial", 18);
            _Tree = new BinaryTree<int>();


        }
        private void BSTreePanel_Load(object sender, EventArgs e)
        {

        }
        public void GenerateTree(int size, int min, int max)
        {
            if (min >= max || (max - min < size))
            {
                MessageBox.Show("So lieu khong hop le");
                return;
            }

           

            _Tree.Clear();

            Random rnd = new Random();

            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(min, max);
            _Tree.Add(arr);
            BeginDraw(true);
        }
       
        private void BeginDraw(bool resetAll)
        {
            _ratio = (_Tree.Count * 300) / this.Width;
            if (resetAll != false)
            {
                _Root = pictureBox1.Width / 2;
                _max = _Root;
                _min = _Root;
                _g = pictureBox1.CreateGraphics();
                CalculateSize(_g, _Root, _Tree.Root);
                _Root += 100 - _min;
                _max += 250 - _min;
            }
            

            Image img = new Bitmap((int)_max, ((_Tree.GetHeight() + 1) * VER_DISTANCE));
            pictureBox1.Image = img;
            _g = Graphics.FromImage(pictureBox1.Image);
            DrawTreeNode(_g, new PointF(_Root, DIAMETER * 2), _Tree.Root, true);
        }
        private void CalculateSize(Graphics g, float left, BinaryTreeNode<int> node)
        {
            if (node != null)
            {
                string text = node.Value.ToString();
                SizeF size = g.MeasureString(text, pictureBox1.Font);
                float x = left - (RADIUS + size.Width) / 2;
                if (node.HasLeft)
                {
                    float p2 = x - Math.Abs(node.Value - node.LeftChild.Value) * _ratio;
                    if (p2 < _min)
                        _min = p2;
                    if (p2 > _max)
                        _max = p2;

                    CalculateSize(g, p2, node.LeftChild);
                }
                if (node.HasRight)
                {
                    float p2 = x + Math.Abs(node.RightChild.Value - node.Value) * _ratio;
                    if (p2 < _min)
                        _min = p2;
                    if (p2 > _max)
                        _max = p2;
                    CalculateSize(g, p2, node.RightChild);
                }
            }
        }
        private void DrawTreeNode(Graphics g, PointF p, BinaryTreeNode<int> node, bool highlight)
        {
            if (node != null)
            {
                string text = node.Value.ToString();
                SizeF size = g.MeasureString(text, _font);
                float ellipseWidth = RADIUS + size.Width;
                float ellipseHeight = RADIUS + size.Height;
                float left = p.X - ellipseWidth / 2;
                float top = p.Y - ellipseHeight / 2;
                Pen pen = _penNormal;
                if (node.HasLeft)
                {
                    PointF p1 = p;
                    PointF p2 = p;
                    p1.X = left + ellipseWidth / 2;
                    p2.X -= (node.Value - node.LeftChild.Value) * _ratio;
                    p2.Y += VER_DISTANCE;                                      
                    g.DrawLine(pen, p1, p2);
                    DrawTreeNode(g, p2, node.LeftChild, true);
                    if (p2.X < _min)
                        _min = p2.X;
                    if (p2.X > _max)
                        _max = p2.X;
                }
                if (node.HasRight)
                {
                    PointF p1 = p;
                    PointF p2 = p;
                    p1.X = left + ellipseWidth / 2;
                    p2.X += (node.RightChild.Value - node.Value) * _ratio;
                    p2.Y += VER_DISTANCE;
                    pen = _penNormal;                                       
                    g.DrawLine(pen, p1, p2);
                    DrawTreeNode(g, p2, node.RightChild, true);
                    if (p2.X < _min)
                        _min = p2.X;
                    if (p2.X > _max)
                        _max = p2.X;
                }
                pen = false ? _penHighLight : _penNormal;
                g.FillEllipse(_brush, left, top, ellipseWidth, ellipseHeight);
                g.DrawEllipse(pen, left, top, ellipseWidth, ellipseHeight);
                g.DrawString(text, _font, Brushes.Black, left + RADIUS / 2, top + RADIUS / 2);
            }
        }
        public bool AddNode(int value)
        {
            if (!_Tree.Add(value))
            {
                txtOutput.Text = "Tree already contain an node with value " + value;
                txtOutput.SelectAll();
                return false;
            }
            txtOutput.Clear();
            BeginDraw(true);
            return true;
        }
    }
}
