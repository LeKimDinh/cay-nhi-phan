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

        BinaryTree _Tree;

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
        Color.White, Color.Purple, LinearGradientMode.Vertical);
            _penNormal = new Pen(Color.Green, 3);
            _penHighLight = new Pen(Color.Black, 3);
            _font = new Font("Arial", 18);
            _Tree = new BinaryTree(50);
        }
        private void BSTreePanel_Load(object sender, EventArgs e)
        {

        }
        public void GenerateTree(int size, int min, int max)
        {
            if (min >= max || (max - min < size))
            {
                MessageBox.Show("Invalid parameters!", "OMG");
                return;
            }

            //_queue = null;

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
            _ratio = (_Tree.Count * 200) / this.Width;

            if (resetAll)
            {


                _g = pictureBox1.CreateGraphics();
                CalculateSize(_g, _leftRoot, _Tree.Root);
                _leftRoot += 100 - _minLeft;
                _maxLeft += 250 - _minLeft;
            }
            Image img = new Bitmap((int)_maxLeft, (_Tree.GetHeight() + 1) * VER_DISTANCE);
            pictureBox1.Image = img;
            _g = Graphics.FromImage(pictureBox1.Image);
            _g.SmoothingMode = SmoothingMode.AntiAlias;
            DrawTreeNode(_g, new PointF(_leftRoot, DIAMETER * 2), _Tree.Root, true);
        }

        private void CalculateSize(Graphics g, float left, BinaryTreeNode node)
        {
            _leftRoot = pictureBox1.Width / 2;
            _minLeft = _leftRoot;
            _maxLeft = _leftRoot;
            if (node != null)
            {
                float x = left - RADIUS / 2;
                if (node.HasLeft)
                {
                    float p2 = x - Math.Abs(node.Value - node.LeftChild.Value) * _ratio;
                    if (p2 < _minLeft)
                        _minLeft = p2;
                    if (p2 > _maxLeft)
                        _maxLeft = p2;
                    CalculateSize(g, p2, node.LeftChild);
                }
                if (node.HasRight)
                {
                    float p2 = x + Math.Abs(node.RightChild.Value - node.Value) * _ratio;

                    if (p2 < _minLeft)
                        _minLeft = p2;
                    if (p2 > _maxLeft)
                        _maxLeft = p2;
                    CalculateSize(g, p2, node.RightChild);
                }
            }
        }

        private void DrawTreeNode(Graphics g, PointF p, BinaryTreeNode node, bool highlight)
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

                    bool hlight = false;

                    if (_queue != null && _queue.Count > 0)
                    {
                        if (_queue.Peek() == node.LeftChild.Value)
                        {

                            pen = _penHighLight;
                            hlight = true;
                        }
                    }
                    g.DrawLine(pen, p1, p2);

                    DrawTreeNode(g, p2, node.LeftChild, true);

                    if (p2.X < _minLeft)
                        _minLeft = p2.X;
                    if (p2.X > _maxLeft)
                        _maxLeft = p2.X;
                }
                if (node.HasRight)
                {
                    PointF p1 = p;
                    PointF p2 = p;
                    p1.X = left + ellipseWidth / 2;

                    p2.X += (node.RightChild.Value - node.Value) * _ratio;

                    p2.Y += VER_DISTANCE;

                    pen = _penNormal;
                    bool hlight = false;
                    if (_queue != null && _queue.Count > 0)
                    {
                        if (_queue.Peek() == node.RightChild.Value)
                        {

                            pen = _penHighLight;
                            hlight = true;
                        }
                    }
                    g.DrawLine(pen, p1, p2);

                    DrawTreeNode(g, p2, node.RightChild, true);

                    if (p2.X < _minLeft)
                        _minLeft = p2.X;
                    if (p2.X > _maxLeft)
                        _maxLeft = p2.X;
                }

                pen = highlight ? _penHighLight : _penNormal;

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

        public bool SearchNode(int value)
        {
            _queue = _Tree.FindPath(value);
            if (_queue == null)
            {
                txtOutput.Text = "Tree does not contain value " + value;
                txtOutput.SelectAll();
                return false;
            }
            txtOutput.Clear();
            BeginDraw(false);
            return true;
        }
    }
}
