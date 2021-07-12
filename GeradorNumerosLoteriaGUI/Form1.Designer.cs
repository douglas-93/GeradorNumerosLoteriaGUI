
namespace GeradorNumerosLoteriaGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtxbResultado = new System.Windows.Forms.RichTextBox();
            this.rbMegaSena = new System.Windows.Forms.RadioButton();
            this.rbQuina = new System.Windows.Forms.RadioButton();
            this.rbLotofacil = new System.Windows.Forms.RadioButton();
            this.rbLotomania = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnSalvarArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxbResultado
            // 
            this.rtxbResultado.Enabled = false;
            this.rtxbResultado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxbResultado.Location = new System.Drawing.Point(12, 168);
            this.rtxbResultado.Name = "rtxbResultado";
            this.rtxbResultado.Size = new System.Drawing.Size(330, 74);
            this.rtxbResultado.TabIndex = 0;
            this.rtxbResultado.Text = "";
            // 
            // rbMegaSena
            // 
            this.rbMegaSena.AutoSize = true;
            this.rbMegaSena.Location = new System.Drawing.Point(12, 143);
            this.rbMegaSena.Name = "rbMegaSena";
            this.rbMegaSena.Size = new System.Drawing.Size(85, 19);
            this.rbMegaSena.TabIndex = 1;
            this.rbMegaSena.TabStop = true;
            this.rbMegaSena.Text = "Mega-Sena";
            this.rbMegaSena.UseVisualStyleBackColor = true;
            // 
            // rbQuina
            // 
            this.rbQuina.AutoSize = true;
            this.rbQuina.Location = new System.Drawing.Point(103, 143);
            this.rbQuina.Name = "rbQuina";
            this.rbQuina.Size = new System.Drawing.Size(57, 19);
            this.rbQuina.TabIndex = 2;
            this.rbQuina.TabStop = true;
            this.rbQuina.Text = "Quina";
            this.rbQuina.UseVisualStyleBackColor = true;
            // 
            // rbLotofacil
            // 
            this.rbLotofacil.AutoSize = true;
            this.rbLotofacil.Location = new System.Drawing.Point(166, 143);
            this.rbLotofacil.Name = "rbLotofacil";
            this.rbLotofacil.Size = new System.Drawing.Size(71, 19);
            this.rbLotofacil.TabIndex = 3;
            this.rbLotofacil.TabStop = true;
            this.rbLotofacil.Text = "Lotofácil";
            this.rbLotofacil.UseVisualStyleBackColor = true;
            // 
            // rbLotomania
            // 
            this.rbLotomania.AutoSize = true;
            this.rbLotomania.Location = new System.Drawing.Point(243, 143);
            this.rbLotomania.Name = "rbLotomania";
            this.rbLotomania.Size = new System.Drawing.Size(82, 19);
            this.rbLotomania.TabIndex = 4;
            this.rbLotomania.TabStop = true;
            this.rbLotomania.Text = "Lotomania";
            this.rbLotomania.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gerador de números para loteria";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 69);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(12, 248);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 7;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(93, 248);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 8;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnSalvarArquivo
            // 
            this.btnSalvarArquivo.Location = new System.Drawing.Point(174, 248);
            this.btnSalvarArquivo.Name = "btnSalvarArquivo";
            this.btnSalvarArquivo.Size = new System.Drawing.Size(124, 23);
            this.btnSalvarArquivo.TabIndex = 9;
            this.btnSalvarArquivo.Text = "Salvar em Arquivo";
            this.btnSalvarArquivo.UseVisualStyleBackColor = true;
            this.btnSalvarArquivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 280);
            this.Controls.Add(this.btnSalvarArquivo);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbLotomania);
            this.Controls.Add(this.rbLotofacil);
            this.Controls.Add(this.rbQuina);
            this.Controls.Add(this.rbMegaSena);
            this.Controls.Add(this.rtxbResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de números para loteria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxbResultado;
        private System.Windows.Forms.RadioButton rbMegaSena;
        private System.Windows.Forms.RadioButton rbQuina;
        private System.Windows.Forms.RadioButton rbLotofacil;
        private System.Windows.Forms.RadioButton rbLotomania;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnSalvarArquivo;
    }
}

