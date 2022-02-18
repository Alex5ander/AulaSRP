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
            this.components = new System.ComponentModel.Container();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtL2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtL1 = new System.Windows.Forms.TextBox();
            this.tela = new System.Windows.Forms.Panel();
            this.btnPlotar = new System.Windows.Forms.Button();
            this.lbResposta = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.Controls.Add(this.lbResposta);
            this.pnSuperior.Controls.Add(this.panel2);
            this.pnSuperior.Controls.Add(this.panel1);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Padding = new System.Windows.Forms.Padding(8);
            this.pnSuperior.Size = new System.Drawing.Size(693, 217);
            this.pnSuperior.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCalcular.Location = new System.Drawing.Point(0, 8);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(8);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(328, 48);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panel1.Size = new System.Drawing.Size(677, 75);
            this.panel1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtL2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(447, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 67);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtL1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lado 1";
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
            // tela
            // 
            this.tela.BackColor = System.Drawing.Color.White;
            this.tela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tela.Location = new System.Drawing.Point(0, 217);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(693, 226);
            this.tela.TabIndex = 1;
            this.tela.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tela_MouseClick);
            this.tela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tela_MouseMove);
            // 
            // btnPlotar
            // 
            this.btnPlotar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlotar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPlotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlotar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPlotar.Location = new System.Drawing.Point(349, 8);
            this.btnPlotar.Margin = new System.Windows.Forms.Padding(8);
            this.btnPlotar.Name = "btnPlotar";
            this.btnPlotar.Size = new System.Drawing.Size(328, 48);
            this.btnPlotar.TabIndex = 8;
            this.btnPlotar.Text = "Plotar";
            this.btnPlotar.UseVisualStyleBackColor = true;
            this.btnPlotar.Click += new System.EventHandler(this.btnPlotar_Click);
            // 
            // lbResposta
            // 
            this.lbResposta.BackColor = System.Drawing.Color.Black;
            this.lbResposta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbResposta.ForeColor = System.Drawing.Color.White;
            this.lbResposta.Location = new System.Drawing.Point(8, 169);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(677, 40);
            this.lbResposta.TabIndex = 1;
            this.lbResposta.Text = "Resposta";
            this.lbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbResposta.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPlotar);
            this.panel2.Controls.Add(this.btnCalcular);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(8, 83);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.panel2.Size = new System.Drawing.Size(677, 64);
            this.panel2.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 443);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.pnSuperior);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnSuperior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel tela;
        private System.Windows.Forms.Button btnPlotar;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer;
    }
}