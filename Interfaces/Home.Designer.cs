﻿namespace Eth3r.Interfaces
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.master_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_by = new System.Windows.Forms.Label();
            this.button_about = new System.Windows.Forms.Button();
            this.button_instructions = new System.Windows.Forms.Button();
            this.button_tools = new System.Windows.Forms.Button();
            this.button_generate = new System.Windows.Forms.Button();
            this.master_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // master_panel
            // 
            this.master_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.master_panel.Controls.Add(this.label1);
            this.master_panel.Controls.Add(this.label3);
            this.master_panel.Controls.Add(this.label_by);
            this.master_panel.Controls.Add(this.button_about);
            this.master_panel.Controls.Add(this.button_instructions);
            this.master_panel.Controls.Add(this.button_tools);
            this.master_panel.Controls.Add(this.button_generate);
            this.master_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.master_panel.Location = new System.Drawing.Point(0, 0);
            this.master_panel.Name = "master_panel";
            this.master_panel.Size = new System.Drawing.Size(800, 450);
            this.master_panel.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 52);
            this.label1.TabIndex = 13;
            this.label1.Text = "Eth3r";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Tahoma", 34.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(39, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 59);
            this.label3.TabIndex = 12;
            this.label3.Text = "Modes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_by
            // 
            this.label_by.AutoSize = true;
            this.label_by.Font = new System.Drawing.Font("Tahoma", 9.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_by.ForeColor = System.Drawing.Color.Lime;
            this.label_by.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_by.Location = new System.Drawing.Point(49, 310);
            this.label_by.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_by.Name = "label_by";
            this.label_by.Size = new System.Drawing.Size(224, 17);
            this.label_by.TabIndex = 8;
            this.label_by.Text = "By: TKO-Cuber and NX_Master";
            // 
            // button_about
            // 
            this.button_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_about.BackColor = System.Drawing.Color.Lime;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_about.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_about.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_about.Location = new System.Drawing.Point(425, 310);
            this.button_about.Margin = new System.Windows.Forms.Padding(2);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(131, 40);
            this.button_about.TabIndex = 7;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_instructions
            // 
            this.button_instructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_instructions.BackColor = System.Drawing.Color.Lime;
            this.button_instructions.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_instructions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_instructions.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_instructions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_instructions.Location = new System.Drawing.Point(588, 253);
            this.button_instructions.Margin = new System.Windows.Forms.Padding(2);
            this.button_instructions.Name = "button_instructions";
            this.button_instructions.Size = new System.Drawing.Size(131, 40);
            this.button_instructions.TabIndex = 6;
            this.button_instructions.Text = "Instructions";
            this.button_instructions.UseVisualStyleBackColor = false;
            this.button_instructions.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_tools
            // 
            this.button_tools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_tools.BackColor = System.Drawing.Color.Lime;
            this.button_tools.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_tools.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_tools.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_tools.Location = new System.Drawing.Point(425, 266);
            this.button_tools.Margin = new System.Windows.Forms.Padding(2);
            this.button_tools.Name = "button_tools";
            this.button_tools.Size = new System.Drawing.Size(131, 40);
            this.button_tools.TabIndex = 5;
            this.button_tools.Text = "More tools";
            this.button_tools.UseVisualStyleBackColor = false;
            // 
            // button_generate
            // 
            this.button_generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_generate.BackColor = System.Drawing.Color.Lime;
            this.button_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_generate.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_generate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_generate.Location = new System.Drawing.Point(260, 297);
            this.button_generate.Margin = new System.Windows.Forms.Padding(2);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(131, 40);
            this.button_generate.TabIndex = 4;
            this.button_generate.Text = "Generate Custom Firmware";
            this.button_generate.UseVisualStyleBackColor = false;
            this.button_generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.master_panel);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(800, 450);
            this.master_panel.ResumeLayout(false);
            this.master_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel master_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_by;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_instructions;
        private System.Windows.Forms.Button button_tools;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Label label1;
    }
}
