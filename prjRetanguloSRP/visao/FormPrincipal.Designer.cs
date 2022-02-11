namespace prjRetanguloSRP.visao
{
    partial class FormPrincipal
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
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.txtL1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtL2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbResposta = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pnSuperior.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.Controls.Add(this.btnCalcular);
            this.pnSuperior.Controls.Add(this.lbResposta);
            this.pnSuperior.Controls.Add(this.panel1);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Padding = new System.Windows.Forms.Padding(8);
            this.pnSuperior.Size = new System.Drawing.Size(693, 193);
            this.pnSuperior.TabIndex = 0;
            // 
            // txtL1
            // 
            this.txtL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtL1.Location = new System.Drawing.Point(3, 27);
            this.txtL1.Name = "txtL1";
            this.txtL1.Size = new System.Drawing.Size(251, 31);
            this.txtL1.TabIndex = 1;
            this.txtL1.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtL1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lado 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtL2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(447, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 85);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lado 2";
            // 
            // txtL2
            // 
            this.txtL2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtL2.Location = new System.Drawing.Point(3, 27);
            this.txtL2.Name = "txtL2";
            this.txtL2.Size = new System.Drawing.Size(224, 31);
            this.txtL2.TabIndex = 1;
            this.txtL2.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 85);
            this.panel1.TabIndex = 6;
            // 
            // lbResposta
            // 
            this.lbResposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResposta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbResposta.Location = new System.Drawing.Point(8, 148);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(677, 37);
            this.lbResposta.TabIndex = 1;
            this.lbResposta.Text = "resultado";
            this.lbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalcular.Location = new System.Drawing.Point(8, 93);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(8);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(677, 44);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 443);
            this.Controls.Add(this.pnSuperior);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnSuperior.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtL1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtL2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbResposta;
    }
}