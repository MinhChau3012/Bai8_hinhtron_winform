namespace Bai8_hinhtron_winform
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btnDientich = new System.Windows.Forms.Button();
            this.btnChuvi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "HÌNH TRÒN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bán kính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "HÌNH TRÒN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kết quả";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(178, 42);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(145, 20);
            this.txtR.TabIndex = 1;
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(178, 101);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(145, 20);
            this.txtKq.TabIndex = 1;
            // 
            // btnDientich
            // 
            this.btnDientich.Location = new System.Drawing.Point(280, 188);
            this.btnDientich.Name = "btnDientich";
            this.btnDientich.Size = new System.Drawing.Size(110, 60);
            this.btnDientich.TabIndex = 2;
            this.btnDientich.Text = "diện tích";
            this.btnDientich.UseVisualStyleBackColor = true;
            this.btnDientich.Click += new System.EventHandler(this.btnDientich_Click);
            // 
            // btnChuvi
            // 
            this.btnChuvi.Location = new System.Drawing.Point(95, 188);
            this.btnChuvi.Name = "btnChuvi";
            this.btnChuvi.Size = new System.Drawing.Size(110, 60);
            this.btnChuvi.TabIndex = 2;
            this.btnChuvi.Text = "chu vi";
            this.btnChuvi.UseVisualStyleBackColor = true;
            this.btnChuvi.Click += new System.EventHandler(this.btnChuvi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 321);
            this.Controls.Add(this.btnChuvi);
            this.Controls.Add(this.btnDientich);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button btnDientich;
        private System.Windows.Forms.Button btnChuvi;
    }
}

