﻿
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
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            renderControl1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(0, 0);
            renderControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(891, 609);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(891, 609);
            Controls.Add(renderControl1);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("Segoe UI", 9F);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Lab1 OpenGL Heoka";
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
    }
}

