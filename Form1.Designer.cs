namespace tuan1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.MaskedTextBox();
            this.btgiaipt = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(93, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(143, 112);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(98, 22);
            this.txta.TabIndex = 1;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(143, 179);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(98, 22);
            this.txtb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(93, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "b";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(93, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "c";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(143, 255);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(98, 22);
            this.txtc.TabIndex = 2;
            // 
            // btgiaipt
            // 
            this.btgiaipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btgiaipt.Location = new System.Drawing.Point(612, 141);
            this.btgiaipt.Name = "btgiaipt";
            this.btgiaipt.Size = new System.Drawing.Size(124, 37);
            this.btgiaipt.TabIndex = 3;
            this.btgiaipt.Text = "Giai";
            this.btgiaipt.UseVisualStyleBackColor = true;
            this.btgiaipt.Click += new System.EventHandler(this.btgiaipt_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnreset.Location = new System.Drawing.Point(612, 219);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(124, 37);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "Lam lai";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // txtkq
            // 
            this.txtkq.Enabled = false;
            this.txtkq.Location = new System.Drawing.Point(330, 141);
            this.txtkq.Multiline = true;
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(177, 120);
            this.txtkq.TabIndex = 4;
            this.txtkq.TextChanged += new System.EventHandler(this.txtkq_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btgiaipt);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.MaskedTextBox txtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtc;
        private System.Windows.Forms.Button btgiaipt;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txtkq;
    }
}

