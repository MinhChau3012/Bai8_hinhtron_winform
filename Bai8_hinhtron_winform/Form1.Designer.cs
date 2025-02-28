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
            this.btnChuvi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDT = new System.Windows.Forms.RadioButton();
            this.rdbCV = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbDIENTICH = new System.Windows.Forms.CheckBox();
            this.chbCHUVI = new System.Windows.Forms.CheckBox();
            this.lblKq = new System.Windows.Forms.Label();
            this.btnTINH1 = new System.Windows.Forms.Button();
            this.btnTINH2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.txtR.Location = new System.Drawing.Point(115, 48);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(145, 20);
            this.txtR.TabIndex = 1;
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(115, 100);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(145, 20);
            this.txtKq.TabIndex = 1;
            // 
            // btnChuvi
            // 
            this.btnChuvi.Location = new System.Drawing.Point(28, 142);
            this.btnChuvi.Name = "btnChuvi";
            this.btnChuvi.Size = new System.Drawing.Size(110, 60);
            this.btnChuvi.TabIndex = 2;
            this.btnChuvi.Text = "tính";
            this.btnChuvi.UseVisualStyleBackColor = true;
            this.btnChuvi.Click += new System.EventHandler(this.btnChuvi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDT);
            this.groupBox1.Controls.Add(this.rdbCV);
            this.groupBox1.Location = new System.Drawing.Point(441, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbDT
            // 
            this.rdbDT.AutoSize = true;
            this.rdbDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDT.Location = new System.Drawing.Point(14, 62);
            this.rdbDT.Name = "rdbDT";
            this.rdbDT.Size = new System.Drawing.Size(93, 21);
            this.rdbDT.TabIndex = 0;
            this.rdbDT.TabStop = true;
            this.rdbDT.Text = "DIỆN TÍCH";
            this.rdbDT.UseVisualStyleBackColor = true;
            // 
            // rdbCV
            // 
            this.rdbCV.AutoSize = true;
            this.rdbCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCV.Location = new System.Drawing.Point(14, 27);
            this.rdbCV.Name = "rdbCV";
            this.rdbCV.Size = new System.Drawing.Size(71, 21);
            this.rdbCV.TabIndex = 0;
            this.rdbCV.TabStop = true;
            this.rdbCV.Text = "CHU VI";
            this.rdbCV.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbDIENTICH);
            this.groupBox2.Controls.Add(this.chbCHUVI);
            this.groupBox2.Location = new System.Drawing.Point(638, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 105);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // chbDIENTICH
            // 
            this.chbDIENTICH.AutoSize = true;
            this.chbDIENTICH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDIENTICH.Location = new System.Drawing.Point(17, 62);
            this.chbDIENTICH.Name = "chbDIENTICH";
            this.chbDIENTICH.Size = new System.Drawing.Size(94, 21);
            this.chbDIENTICH.TabIndex = 0;
            this.chbDIENTICH.Text = "DIỆN TÍCH";
            this.chbDIENTICH.UseVisualStyleBackColor = true;
            // 
            // chbCHUVI
            // 
            this.chbCHUVI.AutoSize = true;
            this.chbCHUVI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCHUVI.Location = new System.Drawing.Point(17, 30);
            this.chbCHUVI.Name = "chbCHUVI";
            this.chbCHUVI.Size = new System.Drawing.Size(72, 21);
            this.chbCHUVI.TabIndex = 0;
            this.chbCHUVI.Text = "CHU VI";
            this.chbCHUVI.UseVisualStyleBackColor = true;
            // 
            // lblKq
            // 
            this.lblKq.AutoSize = true;
            this.lblKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKq.Location = new System.Drawing.Point(214, 158);
            this.lblKq.Name = "lblKq";
            this.lblKq.Size = new System.Drawing.Size(55, 17);
            this.lblKq.TabIndex = 4;
            this.lblKq.Text = "kết quả";
            // 
            // btnTINH1
            // 
            this.btnTINH1.Location = new System.Drawing.Point(492, 176);
            this.btnTINH1.Name = "btnTINH1";
            this.btnTINH1.Size = new System.Drawing.Size(83, 45);
            this.btnTINH1.TabIndex = 5;
            this.btnTINH1.Text = "Tính";
            this.btnTINH1.UseVisualStyleBackColor = true;
            // 
            // btnTINH2
            // 
            this.btnTINH2.Location = new System.Drawing.Point(685, 176);
            this.btnTINH2.Name = "btnTINH2";
            this.btnTINH2.Size = new System.Drawing.Size(83, 45);
            this.btnTINH2.TabIndex = 5;
            this.btnTINH2.Text = "Tính";
            this.btnTINH2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 321);
            this.Controls.Add(this.btnTINH2);
            this.Controls.Add(this.btnTINH1);
            this.Controls.Add(this.lblKq);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChuvi);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button btnChuvi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblKq;
        private System.Windows.Forms.RadioButton rdbDT;
        private System.Windows.Forms.RadioButton rdbCV;
        private System.Windows.Forms.CheckBox chbDIENTICH;
        private System.Windows.Forms.CheckBox chbCHUVI;
        private System.Windows.Forms.Button btnTINH1;
        private System.Windows.Forms.Button btnTINH2;
    }
}

