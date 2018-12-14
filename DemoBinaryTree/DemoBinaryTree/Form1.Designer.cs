namespace DemoBinaryTree
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbnduyet = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTreeHeight = new System.Windows.Forms.Label();
            this.lblNodeCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPostOrderTraverse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPreOrderTraverse = new System.Windows.Forms.Button();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.btnInOrderTraverse = new System.Windows.Forms.Button();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGenerateTree = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbnduyet);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 616);
            this.panel2.TabIndex = 1;
            // 
            // lbnduyet
            // 
            this.lbnduyet.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnduyet.Location = new System.Drawing.Point(121, 500);
            this.lbnduyet.Name = "lbnduyet";
            this.lbnduyet.Size = new System.Drawing.Size(630, 89);
            this.lbnduyet.TabIndex = 19;
            this.lbnduyet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 609);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTreeHeight);
            this.panel1.Controls.Add(this.lblNodeCount);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPostOrderTraverse);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPreOrderTraverse);
            this.panel1.Controls.Add(this.numSize);
            this.panel1.Controls.Add(this.btnInOrderTraverse);
            this.panel1.Controls.Add(this.numMin);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.numMax);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnGenerateTree);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(815, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 616);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTreeHeight
            // 
            this.lblTreeHeight.AutoSize = true;
            this.lblTreeHeight.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTreeHeight.Location = new System.Drawing.Point(63, 419);
            this.lblTreeHeight.Name = "lblTreeHeight";
            this.lblTreeHeight.Size = new System.Drawing.Size(34, 13);
            this.lblTreeHeight.TabIndex = 19;
            this.lblTreeHeight.Text = "Value";
            this.lblTreeHeight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTreeHeight.Click += new System.EventHandler(this.lblTreeHeight_Click);
            // 
            // lblNodeCount
            // 
            this.lblNodeCount.Location = new System.Drawing.Point(14, 481);
            this.lblNodeCount.Name = "lblNodeCount";
            this.lblNodeCount.Size = new System.Drawing.Size(176, 65);
            this.lblNodeCount.TabIndex = 18;
            this.lblNodeCount.Text = "label5";
            this.lblNodeCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Min";
            // 
            // btnPostOrderTraverse
            // 
            this.btnPostOrderTraverse.Location = new System.Drawing.Point(28, 362);
            this.btnPostOrderTraverse.Name = "btnPostOrderTraverse";
            this.btnPostOrderTraverse.Size = new System.Drawing.Size(162, 28);
            this.btnPostOrderTraverse.TabIndex = 17;
            this.btnPostOrderTraverse.Text = "Post-Order Traverse";
            this.btnPostOrderTraverse.UseVisualStyleBackColor = true;
            this.btnPostOrderTraverse.Click += new System.EventHandler(this.btnPostOrderTraverse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max";
            // 
            // btnPreOrderTraverse
            // 
            this.btnPreOrderTraverse.Location = new System.Drawing.Point(28, 328);
            this.btnPreOrderTraverse.Name = "btnPreOrderTraverse";
            this.btnPreOrderTraverse.Size = new System.Drawing.Size(162, 28);
            this.btnPreOrderTraverse.TabIndex = 16;
            this.btnPreOrderTraverse.Text = "Pre-Order Traverse";
            this.btnPreOrderTraverse.UseVisualStyleBackColor = true;
            this.btnPreOrderTraverse.Click += new System.EventHandler(this.btnPreOrderTraverse_Click);
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(91, 7);
            this.numSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(49, 20);
            this.numSize.TabIndex = 6;
            this.numSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnInOrderTraverse
            // 
            this.btnInOrderTraverse.Location = new System.Drawing.Point(28, 294);
            this.btnInOrderTraverse.Name = "btnInOrderTraverse";
            this.btnInOrderTraverse.Size = new System.Drawing.Size(162, 28);
            this.btnInOrderTraverse.TabIndex = 15;
            this.btnInOrderTraverse.Text = "In-Order Traverse";
            this.btnInOrderTraverse.UseVisualStyleBackColor = true;
            this.btnInOrderTraverse.Click += new System.EventHandler(this.btnInOrderTraverse_Click);
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(91, 40);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(49, 20);
            this.numMin.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(28, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 28);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Node";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(91, 77);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(49, 20);
            this.numMax.TabIndex = 8;
            this.numMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(28, 226);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(162, 28);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGenerateTree
            // 
            this.btnGenerateTree.Location = new System.Drawing.Point(28, 122);
            this.btnGenerateTree.Name = "btnGenerateTree";
            this.btnGenerateTree.Size = new System.Drawing.Size(158, 28);
            this.btnGenerateTree.TabIndex = 9;
            this.btnGenerateTree.Text = "Generate Random Tree";
            this.btnGenerateTree.UseVisualStyleBackColor = true;
            this.btnGenerateTree.Click += new System.EventHandler(this.btnGenerateTree_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 192);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 28);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Node";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Value";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(91, 156);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Button btnGenerateTree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInOrderTraverse;
        private System.Windows.Forms.Button btnPreOrderTraverse;
        private System.Windows.Forms.Button btnPostOrderTraverse;
        private System.Windows.Forms.Label lblNodeCount;
        private System.Windows.Forms.Label lblTreeHeight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbnduyet;
    }
}

