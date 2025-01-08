
namespace glWinForm1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderControl1 = new RenderControl();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            numericUpDownN = new System.Windows.Forms.NumericUpDown();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            renderControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(0, 0);
            renderControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(567, 520);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(renderControl1);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(567, 520);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(612, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 25);
            label1.TabIndex = 2;
            label1.Text = "Xmin";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(612, 98);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 25);
            label2.TabIndex = 3;
            label2.Text = "Xmax";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(612, 151);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 25);
            label3.TabIndex = 4;
            label3.Text = "Points";
            // 
            // numericUpDownMin
            // 
            numericUpDownMin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numericUpDownMin.DecimalPlaces = 1;
            numericUpDownMin.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownMin.Location = new System.Drawing.Point(684, 48);
            numericUpDownMin.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDownMin.Name = "numericUpDownMin";
            numericUpDownMin.Size = new System.Drawing.Size(82, 31);
            numericUpDownMin.TabIndex = 5;
            numericUpDownMin.Value = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDownMin.ValueChanged += numericUpDownMin_ValueChanged;
            // 
            // numericUpDownMax
            // 
            numericUpDownMax.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numericUpDownMax.DecimalPlaces = 1;
            numericUpDownMax.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownMax.Location = new System.Drawing.Point(684, 98);
            numericUpDownMax.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDownMax.Name = "numericUpDownMax";
            numericUpDownMax.Size = new System.Drawing.Size(82, 31);
            numericUpDownMax.TabIndex = 6;
            numericUpDownMax.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownMax.ValueChanged += numericUpDownMax_ValueChanged;
            // 
            // numericUpDownN
            // 
            numericUpDownN.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numericUpDownN.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownN.Location = new System.Drawing.Point(684, 151);
            numericUpDownN.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownN.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownN.Name = "numericUpDownN";
            numericUpDownN.Size = new System.Drawing.Size(82, 31);
            numericUpDownN.TabIndex = 7;
            numericUpDownN.Value = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownN.ValueChanged += numericUpDownN_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(612, 285);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(154, 154);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(778, 544);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDownN);
            Controls.Add(numericUpDownMax);
            Controls.Add(numericUpDownMin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MinimumSize = new System.Drawing.Size(800, 600);
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

