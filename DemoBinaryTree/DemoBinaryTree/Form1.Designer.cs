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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateTree = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInOrderTraverse = new System.Windows.Forms.Button();
            this.btnPreOrderTraverse = new System.Windows.Forms.Button();
            this.btnPostOrderTraverse = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTreeHeight = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 339);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtOutput);
            this.panel1.Location = new System.Drawing.Point(3, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 22);
            this.panel1.TabIndex = 2;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.Gold;
            this.txtOutput.Location = new System.Drawing.Point(1, 1);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(608, 20);
            this.txtOutput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(15, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max";
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(79, 372);
            this.numSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(62, 20);
            this.numSize.TabIndex = 6;
            this.numSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(79, 395);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(62, 20);
            this.numMin.TabIndex = 7;
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(79, 418);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(62, 20);
            this.numMax.TabIndex = 8;
            this.numMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnGenerateTree
            // 
            this.btnGenerateTree.Location = new System.Drawing.Point(12, 455);
            this.btnGenerateTree.Name = "btnGenerateTree";
            this.btnGenerateTree.Size = new System.Drawing.Size(129, 28);
            this.btnGenerateTree.TabIndex = 9;
            this.btnGenerateTree.Text = "Generate Random Tree";
            this.btnGenerateTree.UseVisualStyleBackColor = true;
            this.btnGenerateTree.Click += new System.EventHandler(this.btnGenerateTree_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Value";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(203, 370);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(166, 396);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 28);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Node";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(166, 425);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 28);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(166, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 28);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Node";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnInOrderTraverse
            // 
            this.btnInOrderTraverse.Location = new System.Drawing.Point(293, 391);
            this.btnInOrderTraverse.Name = "btnInOrderTraverse";
            this.btnInOrderTraverse.Size = new System.Drawing.Size(117, 28);
            this.btnInOrderTraverse.TabIndex = 15;
            this.btnInOrderTraverse.Text = "In-Order Traverse";
            this.btnInOrderTraverse.UseVisualStyleBackColor = true;
            // 
            // btnPreOrderTraverse
            // 
            this.btnPreOrderTraverse.Location = new System.Drawing.Point(293, 425);
            this.btnPreOrderTraverse.Name = "btnPreOrderTraverse";
            this.btnPreOrderTraverse.Size = new System.Drawing.Size(117, 28);
            this.btnPreOrderTraverse.TabIndex = 16;
            this.btnPreOrderTraverse.Text = "Pre-Order Traverse";
            this.btnPreOrderTraverse.UseVisualStyleBackColor = true;
            // 
            // btnPostOrderTraverse
            // 
            this.btnPostOrderTraverse.Location = new System.Drawing.Point(293, 455);
            this.btnPostOrderTraverse.Name = "btnPostOrderTraverse";
            this.btnPostOrderTraverse.Size = new System.Drawing.Size(117, 28);
            this.btnPostOrderTraverse.TabIndex = 17;
            this.btnPostOrderTraverse.Text = "Post-Order Traverse";
            this.btnPostOrderTraverse.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(437, 374);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(118, 35);
            this.lblMessage.TabIndex = 18;
            this.lblMessage.Text = "label5";
            // 
            // lblTreeHeight
            // 
            this.lblTreeHeight.AutoSize = true;
            this.lblTreeHeight.Location = new System.Drawing.Point(437, 433);
            this.lblTreeHeight.Name = "lblTreeHeight";
            this.lblTreeHeight.Size = new System.Drawing.Size(34, 13);
            this.lblTreeHeight.TabIndex = 19;
            this.lblTreeHeight.Text = "Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 495);
            this.Controls.Add(this.lblTreeHeight);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnPostOrderTraverse);
            this.Controls.Add(this.btnPreOrderTraverse);
            this.Controls.Add(this.btnInOrderTraverse);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGenerateTree);
            this.Controls.Add(this.numMax);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOutput;
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
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTreeHeight;
    }
}

