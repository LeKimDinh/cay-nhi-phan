using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DemoBinaryTree;
using System.Text.RegularExpressions;


namespace DemoBinaryTree
{
    public partial class Form1 : Form
    {
       
        const int RADIUS = 20;
        const int DIAMETER = RADIUS * 2;
        const int HOR_DISTANCE = 70;
        const int VER_DISTANCE =100;

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
            get { return _Tree.count; }
        }
        public int TreeHeight
        {
            get { return _Tree.GetHeight(); }
        }
        public Form1()
        {
            InitializeComponent();

            _brush = new LinearGradientBrush(new Rectangle(0, VER_DISTANCE / 2, 100, VER_DISTANCE),
        Color.LightSkyBlue, Color.White, LinearGradientMode.Vertical);
            _penNormal = new Pen(Color.DarkBlue, 3);
            _penHighLight = new Pen(Color.Red, 3);
            _font = new Font("Time New Roman", 18);
            _Tree = new BinaryTree();
        }       
        private void BeginDraw(bool resetAll)
        {
            _ratio = (_Tree.count * 1000) /this.Width;
            if (resetAll == true)
            {
                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();
                _leftRoot = pictureBox1.Width / 2;
                _minLeft = _leftRoot;
                _maxLeft = _leftRoot;
                _g = pictureBox1.CreateGraphics();
                CalculateSize(_g, _leftRoot, _Tree.root);
                _leftRoot -= _minLeft;
                _maxLeft -= _minLeft;
                _minLeft = 0;
                _leftRoot += 100;
                _maxLeft += 350;
            }
            Image img = new Bitmap((int)_maxLeft, (_Tree.GetHeight() + 2) * VER_DISTANCE+100);
            
            pictureBox1.Image = img;
            _g = Graphics.FromImage(pictureBox1.Image);
            _g.SmoothingMode = SmoothingMode.AntiAlias;
            DrawTreeNode(_g, new PointF(_leftRoot, DIAMETER ), _Tree.root, true);
        }
        private void CalculateSize(Graphics g, float left, BinaryTreeNode node)
        {

            if (node != null)
            {
                string text = node.key.ToString();
                SizeF size = g.MeasureString(text, pictureBox1.Font);
                float x = left - (RADIUS + size.Width) / 2;
               
                if (node.HasLeft)
                {

                    float p2 = x - Math.Abs(node.key - node.left.key) * _ratio;
                    if (p2 < _minLeft)
                        _minLeft = p2;
                    if (p2 > _maxLeft)
                        _maxLeft = p2;
                    CalculateSize(g, p2, node.left);
                }
                if (node.HasRight)
                {
                    float p2 = x + Math.Abs(node.key - node.right.key) * _ratio;
                    if (p2 < _minLeft)
                        _minLeft = p2;
                    if (p2 > _maxLeft)
                        _maxLeft = p2;
                    CalculateSize(g, p2, node.right);
                }
            }
        }
        private void DrawTreeNode(Graphics g, PointF p, BinaryTreeNode node, bool highlight)
        {
            if (node != null)
            {
                string text = node.key.ToString();
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
                    p2.X -= (node.key - node.left.key+(18/10)) * _ratio * (13 / 10);

                    p2.Y += VER_DISTANCE;                    
                    bool hlight = false;
                    if (_queue != null && _queue.Count > 0)
                    {
                        if (_queue.Peek() == node.left.key)
                        {
                            _queue.Dequeue();
                            pen = _penHighLight;
                            hlight = true;
                        }
                    }                                  
                    g.DrawLine(pen, p1, p2);
                    DrawTreeNode(g, p2, node.left, hlight);
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
                    p2.X += (node.right.key- node.key) * _ratio * (12 / 10);

                   
                    p2.Y += VER_DISTANCE;                    
                    pen = _penNormal;
                    bool hlight = false;
                    if (_queue != null && _queue.Count > 0)
                    {
                        if (_queue.Peek() == node.right.key)
                        {
                            _queue.Dequeue();
                            pen = _penHighLight;
                            hlight = true;
                        }
                    }                                     
                    g.DrawLine(pen, p1, p2);
                    DrawTreeNode(g, p2, node.right, hlight);
                    if (p2.X < _minLeft)
                        _minLeft = p2.X;
                    if (p2.X > _maxLeft)
                        _maxLeft = p2.X;
                }
                pen = highlight ? _penHighLight : _penNormal;
                g.FillEllipse(_brush, left, top, ellipseWidth, ellipseHeight);
                g.DrawEllipse(pen, left, top, ellipseWidth, ellipseHeight);
                g.DrawString(text, _font, Brushes.DarkRed, left + RADIUS / 2, top + RADIUS / 2);
            }
        }
        // add
        public bool Add(int value)
        {
            _queue = _Tree.ADD(value);
            if (_queue==null)
            {
               
                MessageBox.Show($"Tree already contain an node with value {value}");
                return false;
            }
                   
            BeginDraw(true);
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            Add((int)numericUpDown1.Value);
            UpdateInfo();

        }
        private void btnGenerateTree_Click(object sender, EventArgs e)           
        {
           
           
            int min = (int)numMin.Value;
            int max = (int)numMax.Value;
            int size = (int)numSize.Value;
            if (min >= max || (max - min )< size)
            {
                MessageBox.Show("Invalid parameters!", "OMG");
                return;
            }
            _Tree.Clear();
            Random rnd = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max);
                _Tree.Add(arr[i]);
            }
            BeginDraw(true);
            UpdateInfo();

        }
        //Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
          
            int value = (int)numericUpDown1.Value;           
            _queue = _Tree.FindPath(value);
            if (_queue == null)
            {
                MessageBox.Show($"Tree does not contain value {value}");
                return;
            }
         
            BeginDraw(false);           
            return;
        }
        //Traverses
        private void btnInOrderTraverse_Click(object sender, EventArgs e)
        {

            lbnduyet.Text = "";

            List<int> list = _Tree.PostOrderTraverse();
            lbnduyet.Text = "InOrderTraverse: ";
            foreach (int a in list)
            {
                lbnduyet.Text += a.ToString() + " ";
            }

        }
        private void btnPreOrderTraverse_Click(object sender, EventArgs e)
        {
            lbnduyet.Text = "";

            List<int> list = _Tree.PostOrderTraverse();
            lbnduyet.Text = "PreOrderTraverse: ";
            foreach (int a in list)
            {
                lbnduyet.Text += a.ToString() + " ";
            }

        }
        private void btnPostOrderTraverse_Click(object sender, EventArgs e)
        {
            lbnduyet.Text = "";
            
            List<int> list = _Tree.PostOrderTraverse();
            lbnduyet.Text = "PostOrderTraverse: ";
            foreach (int a in list)
            {
                lbnduyet.Text += a.ToString() + " ";
            }
            
        }
        
        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _Tree.x = 0;
            int value = (int)numericUpDown1.Value;
            if (!_Tree.Remove(value))
            {
                MessageBox.Show($"Tree does not contain value {value}"); 
                return;
            }            
            _queue = _Tree.FindPath(_Tree.x);
            BeginDraw(true);
            UpdateInfo();

        }
        void UpdateInfo()
        {
            lblNodeCount.Text = "Node Count: " + _Tree.count;
            lblTreeHeight.Text = "Tree Height: " + TreeHeight;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Do you want to exit??", "Notification!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thoat == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void lblTreeHeight_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
