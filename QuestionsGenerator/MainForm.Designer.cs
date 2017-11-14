namespace QuestionsGenerator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAdd = new System.Windows.Forms.CheckBox();
            this.cbSubtract = new System.Windows.Forms.CheckBox();
            this.cbMultiply = new System.Windows.Forms.CheckBox();
            this.cbDivide = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numQuestion = new System.Windows.Forms.NumericUpDown();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboFormat = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1217, 604);
            this.splitContainer1.SplitterDistance = 646;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboFormat);
            this.groupBox1.Controls.Add(this.numCount);
            this.groupBox1.Controls.Add(this.numQuestion);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.cbDivide);
            this.groupBox1.Controls.Add(this.cbMultiply);
            this.groupBox1.Controls.Add(this.cbSubtract);
            this.groupBox1.Controls.Add(this.cbAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(15, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设定";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "参与计算数字个数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "参与计算运算符：";
            // 
            // cbAdd
            // 
            this.cbAdd.AutoSize = true;
            this.cbAdd.Checked = true;
            this.cbAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAdd.Location = new System.Drawing.Point(115, 54);
            this.cbAdd.Name = "cbAdd";
            this.cbAdd.Size = new System.Drawing.Size(36, 16);
            this.cbAdd.TabIndex = 3;
            this.cbAdd.Text = "加";
            this.cbAdd.UseVisualStyleBackColor = true;
            // 
            // cbSubtract
            // 
            this.cbSubtract.AutoSize = true;
            this.cbSubtract.Checked = true;
            this.cbSubtract.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSubtract.Location = new System.Drawing.Point(157, 54);
            this.cbSubtract.Name = "cbSubtract";
            this.cbSubtract.Size = new System.Drawing.Size(36, 16);
            this.cbSubtract.TabIndex = 3;
            this.cbSubtract.Text = "减";
            this.cbSubtract.UseVisualStyleBackColor = true;
            // 
            // cbMultiply
            // 
            this.cbMultiply.AutoSize = true;
            this.cbMultiply.Checked = true;
            this.cbMultiply.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMultiply.Location = new System.Drawing.Point(205, 54);
            this.cbMultiply.Name = "cbMultiply";
            this.cbMultiply.Size = new System.Drawing.Size(36, 16);
            this.cbMultiply.TabIndex = 3;
            this.cbMultiply.Text = "乘";
            this.cbMultiply.UseVisualStyleBackColor = true;
            // 
            // cbDivide
            // 
            this.cbDivide.AutoSize = true;
            this.cbDivide.Checked = true;
            this.cbDivide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDivide.Location = new System.Drawing.Point(254, 54);
            this.cbDivide.Name = "cbDivide";
            this.cbDivide.Size = new System.Drawing.Size(36, 16);
            this.cbDivide.TabIndex = 3;
            this.cbDivide.Text = "除";
            this.cbDivide.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Location = new System.Drawing.Point(482, 195);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(109, 32);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "生成运算";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "生成问题数：";
            // 
            // numQuestion
            // 
            this.numQuestion.Location = new System.Drawing.Point(115, 87);
            this.numQuestion.Name = "numQuestion";
            this.numQuestion.Size = new System.Drawing.Size(120, 21);
            this.numQuestion.TabIndex = 5;
            this.numQuestion.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(115, 17);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(120, 21);
            this.numCount.TabIndex = 5;
            this.numCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "生成问题数：";
            // 
            // comboFormat
            // 
            this.comboFormat.FormattingEnabled = true;
            this.comboFormat.Items.AddRange(new object[] {
            "口算",
            "计算"});
            this.comboFormat.Location = new System.Drawing.Point(115, 130);
            this.comboFormat.Name = "comboFormat";
            this.comboFormat.Size = new System.Drawing.Size(121, 20);
            this.comboFormat.TabIndex = 6;
            this.comboFormat.Text = "口算";
            this.toolTip1.SetToolTip(this.comboFormat, "口算间距小，计算间距大");
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(567, 604);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 604);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "参数设定";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.NumericUpDown numQuestion;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox cbDivide;
        private System.Windows.Forms.CheckBox cbMultiply;
        private System.Windows.Forms.CheckBox cbSubtract;
        private System.Windows.Forms.CheckBox cbAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFormat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

