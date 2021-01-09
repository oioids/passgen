
namespace PassGenApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.generate = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.passlabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.count = new System.Windows.Forms.Label();
            this.numberbox = new System.Windows.Forms.CheckBox();
            this.symbolbox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.generate);
            this.panel1.Controls.Add(this.copy);
            this.panel1.Controls.Add(this.passlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 240);
            this.panel1.TabIndex = 0;
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.SystemColors.Control;
            this.generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generate.Font = new System.Drawing.Font("Manrope", 10F);
            this.generate.Location = new System.Drawing.Point(299, 170);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(93, 44);
            this.generate.TabIndex = 1;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.SystemColors.Control;
            this.copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.copy.Font = new System.Drawing.Font("Manrope", 10F);
            this.copy.Location = new System.Drawing.Point(200, 170);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(93, 44);
            this.copy.TabIndex = 1;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Manrope", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.ForeColor = System.Drawing.Color.White;
            this.passlabel.Location = new System.Drawing.Point(12, 72);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(0, 27);
            this.passlabel.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(53, 284);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Minimum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(315, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(53, 265);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(23, 15);
            this.count.TabIndex = 2;
            this.count.Text = "(4)";
            // 
            // numberbox
            // 
            this.numberbox.AutoSize = true;
            this.numberbox.Font = new System.Drawing.Font("Manrope", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberbox.Location = new System.Drawing.Point(56, 367);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(131, 22);
            this.numberbox.TabIndex = 3;
            this.numberbox.Text = "Include Numbers";
            this.numberbox.UseVisualStyleBackColor = true;
            // 
            // symbolbox
            // 
            this.symbolbox.AutoSize = true;
            this.symbolbox.Font = new System.Drawing.Font("Manrope", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolbox.Location = new System.Drawing.Point(56, 412);
            this.symbolbox.Name = "symbolbox";
            this.symbolbox.Size = new System.Drawing.Size(212, 22);
            this.symbolbox.TabIndex = 3;
            this.symbolbox.Text = "Include Symbols and Numbers";
            this.symbolbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 583);
            this.Controls.Add(this.symbolbox);
            this.Controls.Add(this.numberbox);
            this.Controls.Add(this.count);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Manrope", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassGen made by sairasu#3063";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.CheckBox numberbox;
        private System.Windows.Forms.CheckBox symbolbox;
    }
}

