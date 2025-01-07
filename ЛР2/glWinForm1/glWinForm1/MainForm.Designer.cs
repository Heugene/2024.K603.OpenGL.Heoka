
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
            numericUpDownHorizontal = new System.Windows.Forms.NumericUpDown();
            numericUpDownVertical = new System.Windows.Forms.NumericUpDown();
            radioButtonFill = new System.Windows.Forms.RadioButton();
            radioButtonLine = new System.Windows.Forms.RadioButton();
            radioButtonPoint = new System.Windows.Forms.RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHorizontal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVertical).BeginInit();
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
            renderControl1.Size = new System.Drawing.Size(600, 520);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(renderControl1);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(600, 520);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(644, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 25);
            label1.TabIndex = 2;
            label1.Text = "Tile count:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(618, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 25);
            label2.TabIndex = 3;
            label2.Text = "horizontal:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(619, 110);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 25);
            label3.TabIndex = 4;
            label3.Text = "vertical:";
            // 
            // numericUpDownHorizontal
            // 
            numericUpDownHorizontal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numericUpDownHorizontal.Location = new System.Drawing.Point(719, 71);
            numericUpDownHorizontal.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHorizontal.Name = "numericUpDownHorizontal";
            numericUpDownHorizontal.Size = new System.Drawing.Size(47, 31);
            numericUpDownHorizontal.TabIndex = 5;
            numericUpDownHorizontal.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHorizontal.ValueChanged += numericUpDownHorizontal_ValueChanged;
            // 
            // numericUpDownVertical
            // 
            numericUpDownVertical.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numericUpDownVertical.Location = new System.Drawing.Point(719, 110);
            numericUpDownVertical.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownVertical.Name = "numericUpDownVertical";
            numericUpDownVertical.Size = new System.Drawing.Size(47, 31);
            numericUpDownVertical.TabIndex = 6;
            numericUpDownVertical.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownVertical.ValueChanged += numericUpDownVertical_ValueChanged;
            // 
            // radioButtonFill
            // 
            radioButtonFill.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radioButtonFill.AutoSize = true;
            radioButtonFill.Checked = true;
            radioButtonFill.Location = new System.Drawing.Point(619, 385);
            radioButtonFill.Name = "radioButtonFill";
            radioButtonFill.Size = new System.Drawing.Size(110, 29);
            radioButtonFill.TabIndex = 7;
            radioButtonFill.TabStop = true;
            radioButtonFill.Text = "Fill mode";
            radioButtonFill.UseVisualStyleBackColor = true;
            radioButtonFill.CheckedChanged += radioButtonFill_CheckedChanged;
            // 
            // radioButtonLine
            // 
            radioButtonLine.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radioButtonLine.AutoSize = true;
            radioButtonLine.Location = new System.Drawing.Point(619, 420);
            radioButtonLine.Name = "radioButtonLine";
            radioButtonLine.Size = new System.Drawing.Size(120, 29);
            radioButtonLine.TabIndex = 8;
            radioButtonLine.Text = "Line mode";
            radioButtonLine.UseVisualStyleBackColor = true;
            radioButtonLine.CheckedChanged += radioButtonLine_CheckedChanged;
            // 
            // radioButtonPoint
            // 
            radioButtonPoint.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radioButtonPoint.AutoSize = true;
            radioButtonPoint.Location = new System.Drawing.Point(619, 455);
            radioButtonPoint.Name = "radioButtonPoint";
            radioButtonPoint.Size = new System.Drawing.Size(129, 29);
            radioButtonPoint.TabIndex = 9;
            radioButtonPoint.Text = "Point mode";
            radioButtonPoint.UseVisualStyleBackColor = true;
            radioButtonPoint.CheckedChanged += radioButtonPoint_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(778, 544);
            Controls.Add(radioButtonPoint);
            Controls.Add(radioButtonLine);
            Controls.Add(radioButtonFill);
            Controls.Add(numericUpDownVertical);
            Controls.Add(numericUpDownHorizontal);
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
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownHorizontal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVertical).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownHorizontal;
        private System.Windows.Forms.NumericUpDown numericUpDownVertical;
        private System.Windows.Forms.RadioButton radioButtonFill;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.RadioButton radioButtonPoint;
    }
}

