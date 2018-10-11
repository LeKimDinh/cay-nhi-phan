namespace Demo_cây_nhị_phân
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNodeCount = new System.Windows.Forms.Label();
            this.btnPostOrderTraverse = new System.Windows.Forms.Button();
            this.btnPreOrderTraverse = new System.Windows.Forms.Button();
            this.btnInOrderTraverse = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerateTree = new System.Windows.Forms.Button();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userControl11 = new Demo_cây_nhị_phân.UserControl1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblNodeCount);
            this.panel1.Controls.Add(this.btnPostOrderTraverse);
            this.panel1.Controls.Add(this.btnPreOrderTraverse);
            this.panel1.Controls.Add(this.btnInOrderTraverse);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnGenerateTree);
            this.panel1.Controls.Add(this.numMax);
            this.panel1.Controls.Add(this.numMin);
            this.panel1.Controls.Add(this.numSize);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 137);
            this.panel1.TabIndex = 1;
            // 
            // lblNodeCount
            // 
            this.lblNodeCount.AutoSize = true;
            this.lblNodeCount.Location = new System.Drawing.Point(203, 36);
            this.lblNodeCount.Name = "lblNodeCount";
            this.lblNodeCount.Size = new System.Drawing.Size(34, 13);
            this.lblNodeCount.TabIndex = 17;
            this.lblNodeCount.Text = "Value";
            // 
            // btnPostOrderTraverse
            // 
            this.btnPostOrderTraverse.Location = new System.Drawing.Point(322, 97);
            this.btnPostOrderTraverse.Name = "btnPostOrderTraverse";
            this.btnPostOrderTraverse.Size = new System.Drawing.Size(111, 28);
            this.btnPostOrderTraverse.TabIndex = 16;
            this.btnPostOrderTraverse.Text = "Post-Order Traverse";
            this.btnPostOrderTraverse.UseVisualStyleBackColor = true;
            // 
            // btnPreOrderTraverse
            // 
            this.btnPreOrderTraverse.Location = new System.Drawing.Point(322, 57);
            this.btnPreOrderTraverse.Name = "btnPreOrderTraverse";
            this.btnPreOrderTraverse.Size = new System.Drawing.Size(111, 28);
            this.btnPreOrderTraverse.TabIndex = 15;
            this.btnPreOrderTraverse.Text = "Pre-Order Traverse";
            this.btnPreOrderTraverse.UseVisualStyleBackColor = true;
            // 
            // btnInOrderTraverse
            // 
            this.btnInOrderTraverse.Location = new System.Drawing.Point(313, 9);
            this.btnInOrderTraverse.Name = "btnInOrderTraverse";
            this.btnInOrderTraverse.Size = new System.Drawing.Size(111, 28);
            this.btnInOrderTraverse.TabIndex = 14;
            this.btnInOrderTraverse.Text = "In-Order Traverse";
            this.btnInOrderTraverse.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(123, 97);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 28);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete Node";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(123, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 28);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(123, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Node";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(253, 10);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Value";
            // 
            // btnGenerateTree
            // 
            this.btnGenerateTree.Location = new System.Drawing.Point(6, 88);
            this.btnGenerateTree.Name = "btnGenerateTree";
            this.btnGenerateTree.Size = new System.Drawing.Size(108, 31);
            this.btnGenerateTree.TabIndex = 8;
            this.btnGenerateTree.Text = "Generate Random Tree";
            this.btnGenerateTree.UseVisualStyleBackColor = true;
            this.btnGenerateTree.Click += new System.EventHandler(this.btnGenerateTree_Click);
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(62, 57);
            this.numMax.Name = "numMax";
            this.numMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numMax.Size = new System.Drawing.Size(44, 20);
            this.numMax.TabIndex = 7;
            this.numMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(62, 29);
            this.numMin.Name = "numMin";
            this.numMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numMin.Size = new System.Drawing.Size(44, 20);
            this.numMin.TabIndex = 6;
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(62, 3);
            this.numSize.Name = "numSize";
            this.numSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numSize.Size = new System.Drawing.Size(44, 20);
            this.numSize.TabIndex = 4;
            this.numSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max size";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(571, 453);
            this.userControl11.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 593);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPostOrderTraverse;
        private System.Windows.Forms.Button btnPreOrderTraverse;
        private System.Windows.Forms.Button btnInOrderTraverse;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerateTree;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserControl1 userControl11;
        private System.Windows.Forms.Label lblNodeCount;
    }
}

