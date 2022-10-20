namespace prjGenius
{
    partial class frmJogo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogo2));
            this.pcbAzul = new System.Windows.Forms.PictureBox();
            this.pcbVermelho = new System.Windows.Forms.PictureBox();
            this.pcbAmarelo = new System.Windows.Forms.PictureBox();
            this.pcbVerde = new System.Windows.Forms.PictureBox();
            this.btnIniciarJogo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tmrPcb = new System.Windows.Forms.Timer(this.components);
            this.lblPontuacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerde)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbAzul
            // 
            this.pcbAzul.Image = global::prjGenius.Properties.Resources.azul1;
            this.pcbAzul.Location = new System.Drawing.Point(243, 212);
            this.pcbAzul.Name = "pcbAzul";
            this.pcbAzul.Size = new System.Drawing.Size(184, 182);
            this.pcbAzul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAzul.TabIndex = 3;
            this.pcbAzul.TabStop = false;
            this.pcbAzul.Click += new System.EventHandler(this.pcbAzul_Click);
            // 
            // pcbVermelho
            // 
            this.pcbVermelho.Image = global::prjGenius.Properties.Resources.vermelho1;
            this.pcbVermelho.Location = new System.Drawing.Point(243, 18);
            this.pcbVermelho.Name = "pcbVermelho";
            this.pcbVermelho.Size = new System.Drawing.Size(184, 182);
            this.pcbVermelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVermelho.TabIndex = 2;
            this.pcbVermelho.TabStop = false;
            this.pcbVermelho.Click += new System.EventHandler(this.pcbVermelho_Click);
            // 
            // pcbAmarelo
            // 
            this.pcbAmarelo.Image = global::prjGenius.Properties.Resources.amarelo1;
            this.pcbAmarelo.Location = new System.Drawing.Point(46, 212);
            this.pcbAmarelo.Name = "pcbAmarelo";
            this.pcbAmarelo.Size = new System.Drawing.Size(184, 182);
            this.pcbAmarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAmarelo.TabIndex = 1;
            this.pcbAmarelo.TabStop = false;
            this.pcbAmarelo.Click += new System.EventHandler(this.pcbAmarelo_Click);
            // 
            // pcbVerde
            // 
            this.pcbVerde.Image = global::prjGenius.Properties.Resources.verde;
            this.pcbVerde.InitialImage = global::prjGenius.Properties.Resources.verde;
            this.pcbVerde.Location = new System.Drawing.Point(46, 18);
            this.pcbVerde.Name = "pcbVerde";
            this.pcbVerde.Size = new System.Drawing.Size(184, 182);
            this.pcbVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVerde.TabIndex = 0;
            this.pcbVerde.TabStop = false;
            this.pcbVerde.Click += new System.EventHandler(this.pcbVerde_Click);
            // 
            // btnIniciarJogo
            // 
            this.btnIniciarJogo.Location = new System.Drawing.Point(196, 172);
            this.btnIniciarJogo.Name = "btnIniciarJogo";
            this.btnIniciarJogo.Size = new System.Drawing.Size(78, 34);
            this.btnIniciarJogo.TabIndex = 4;
            this.btnIniciarJogo.Text = "Iniciar Jogo";
            this.btnIniciarJogo.UseVisualStyleBackColor = true;
            this.btnIniciarJogo.Click += new System.EventHandler(this.btnIniciarJogo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(208, 223);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(53, 20);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tmrPcb
            // 
            this.tmrPcb.Interval = 1500;
            this.tmrPcb.Tick += new System.EventHandler(this.tmrPcb_Tick);
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.Location = new System.Drawing.Point(509, 43);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(198, 29);
            this.lblPontuacao.TabIndex = 6;
            this.lblPontuacao.Text = "0";
            this.lblPontuacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmJogo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 414);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnIniciarJogo);
            this.Controls.Add(this.pcbAzul);
            this.Controls.Add(this.pcbVermelho);
            this.Controls.Add(this.pcbAmarelo);
            this.Controls.Add(this.pcbVerde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmJogo2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genius é da Estrela ! ! !";
            ((System.ComponentModel.ISupportInitialize)(this.pcbAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbVerde;
        private System.Windows.Forms.PictureBox pcbAmarelo;
        private System.Windows.Forms.PictureBox pcbVermelho;
        private System.Windows.Forms.PictureBox pcbAzul;
        private System.Windows.Forms.Button btnIniciarJogo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Timer tmrPcb;
        private System.Windows.Forms.Label lblPontuacao;
    }
}