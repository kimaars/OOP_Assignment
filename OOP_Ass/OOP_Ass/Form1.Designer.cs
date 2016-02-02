﻿namespace OOP_Ass
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
            this.txtSampling = new System.Windows.Forms.TextBox();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSampling = new System.Windows.Forms.Button();
            this.grpSampling = new System.Windows.Forms.GroupBox();
            this.grpLogging = new System.Windows.Forms.GroupBox();
            this.btnLogging = new System.Windows.Forms.Button();
            this.txtLogging = new System.Windows.Forms.TextBox();
            this.lblSampling = new System.Windows.Forms.Label();
            this.lblLogging = new System.Windows.Forms.Label();
            this.grpSensor = new System.Windows.Forms.GroupBox();
            this.txtSensor = new System.Windows.Forms.TextBox();
            this.mnuStrip.SuspendLayout();
            this.grpSampling.SuspendLayout();
            this.grpLogging.SuspendLayout();
            this.grpSensor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSampling
            // 
            this.txtSampling.Location = new System.Drawing.Point(127, 35);
            this.txtSampling.Name = "txtSampling";
            this.txtSampling.Size = new System.Drawing.Size(100, 20);
            this.txtSampling.TabIndex = 0;
            this.txtSampling.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(439, 24);
            this.mnuStrip.TabIndex = 1;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnSampling
            // 
            this.btnSampling.Location = new System.Drawing.Point(6, 71);
            this.btnSampling.Name = "btnSampling";
            this.btnSampling.Size = new System.Drawing.Size(75, 23);
            this.btnSampling.TabIndex = 2;
            this.btnSampling.Text = "Sampling";
            this.btnSampling.UseVisualStyleBackColor = true;
            // 
            // grpSampling
            // 
            this.grpSampling.Controls.Add(this.lblSampling);
            this.grpSampling.Controls.Add(this.btnSampling);
            this.grpSampling.Controls.Add(this.txtSampling);
            this.grpSampling.Location = new System.Drawing.Point(24, 49);
            this.grpSampling.Name = "grpSampling";
            this.grpSampling.Size = new System.Drawing.Size(245, 100);
            this.grpSampling.TabIndex = 3;
            this.grpSampling.TabStop = false;
            this.grpSampling.Text = "Sampling";
            this.grpSampling.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpLogging
            // 
            this.grpLogging.Controls.Add(this.lblLogging);
            this.grpLogging.Controls.Add(this.btnLogging);
            this.grpLogging.Controls.Add(this.txtLogging);
            this.grpLogging.Location = new System.Drawing.Point(24, 168);
            this.grpLogging.Name = "grpLogging";
            this.grpLogging.Size = new System.Drawing.Size(245, 105);
            this.grpLogging.TabIndex = 4;
            this.grpLogging.TabStop = false;
            this.grpLogging.Text = "Logging";
            // 
            // btnLogging
            // 
            this.btnLogging.Location = new System.Drawing.Point(6, 71);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(98, 23);
            this.btnLogging.TabIndex = 2;
            this.btnLogging.Text = "Logging on file";
            this.btnLogging.UseVisualStyleBackColor = true;
            // 
            // txtLogging
            // 
            this.txtLogging.Location = new System.Drawing.Point(127, 31);
            this.txtLogging.Name = "txtLogging";
            this.txtLogging.Size = new System.Drawing.Size(100, 20);
            this.txtLogging.TabIndex = 0;
            // 
            // lblSampling
            // 
            this.lblSampling.AutoSize = true;
            this.lblSampling.Location = new System.Drawing.Point(6, 38);
            this.lblSampling.Name = "lblSampling";
            this.lblSampling.Size = new System.Drawing.Size(101, 13);
            this.lblSampling.TabIndex = 5;
            this.lblSampling.Text = "Next Sampling Time";
            // 
            // lblLogging
            // 
            this.lblLogging.AutoSize = true;
            this.lblLogging.Location = new System.Drawing.Point(6, 34);
            this.lblLogging.Name = "lblLogging";
            this.lblLogging.Size = new System.Drawing.Size(96, 13);
            this.lblLogging.TabIndex = 6;
            this.lblLogging.Text = "Next Logging Time";
            // 
            // grpSensor
            // 
            this.grpSensor.Controls.Add(this.txtSensor);
            this.grpSensor.Location = new System.Drawing.Point(287, 49);
            this.grpSensor.Name = "grpSensor";
            this.grpSensor.Size = new System.Drawing.Size(132, 224);
            this.grpSensor.TabIndex = 5;
            this.grpSensor.TabStop = false;
            this.grpSensor.Text = "Sensor Values";
            // 
            // txtSensor
            // 
            this.txtSensor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSensor.Location = new System.Drawing.Point(6, 19);
            this.txtSensor.Multiline = true;
            this.txtSensor.Name = "txtSensor";
            this.txtSensor.Size = new System.Drawing.Size(120, 194);
            this.txtSensor.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 285);
            this.Controls.Add(this.grpSensor);
            this.Controls.Add(this.grpLogging);
            this.Controls.Add(this.grpSampling);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.grpSampling.ResumeLayout(false);
            this.grpSampling.PerformLayout();
            this.grpLogging.ResumeLayout(false);
            this.grpLogging.PerformLayout();
            this.grpSensor.ResumeLayout(false);
            this.grpSensor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSampling;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnSampling;
        private System.Windows.Forms.GroupBox grpSampling;
        private System.Windows.Forms.Label lblSampling;
        private System.Windows.Forms.GroupBox grpLogging;
        private System.Windows.Forms.Label lblLogging;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.TextBox txtLogging;
        private System.Windows.Forms.GroupBox grpSensor;
        private System.Windows.Forms.TextBox txtSensor;
    }
}

