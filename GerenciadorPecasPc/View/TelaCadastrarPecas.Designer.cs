namespace GerenciadorPecasPc.View
{
    partial class TelaCadastrarPecas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textpecas = new System.Windows.Forms.TextBox();
            this.textBoxmarcas = new System.Windows.Forms.TextBox();
            this.txtboxcapacidade = new System.Windows.Forms.TextBox();
            this.btncadastrarpecas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(302, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Pecas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(116, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peças:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(116, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marcas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(116, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidade:";
            // 
            // textpecas
            // 
            this.textpecas.Location = new System.Drawing.Point(204, 127);
            this.textpecas.Name = "textpecas";
            this.textpecas.Size = new System.Drawing.Size(262, 23);
            this.textpecas.TabIndex = 4;
            // 
            // textBoxmarcas
            // 
            this.textBoxmarcas.Location = new System.Drawing.Point(204, 175);
            this.textBoxmarcas.Name = "textBoxmarcas";
            this.textBoxmarcas.Size = new System.Drawing.Size(262, 23);
            this.textBoxmarcas.TabIndex = 5;
            // 
            // txtboxcapacidade
            // 
            this.txtboxcapacidade.Location = new System.Drawing.Point(204, 218);
            this.txtboxcapacidade.Name = "txtboxcapacidade";
            this.txtboxcapacidade.Size = new System.Drawing.Size(262, 23);
            this.txtboxcapacidade.TabIndex = 6;
            // 
            // btncadastrarpecas
            // 
            this.btncadastrarpecas.Location = new System.Drawing.Point(208, 337);
            this.btncadastrarpecas.Name = "btncadastrarpecas";
            this.btncadastrarpecas.Size = new System.Drawing.Size(313, 23);
            this.btncadastrarpecas.TabIndex = 7;
            this.btncadastrarpecas.Text = "Cadastrar";
            this.btncadastrarpecas.UseVisualStyleBackColor = true;
            this.btncadastrarpecas.Click += new System.EventHandler(this.btncadastrarpecas_Click);
            // 
            // TelaCadastrarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncadastrarpecas);
            this.Controls.Add(this.txtboxcapacidade);
            this.Controls.Add(this.textBoxmarcas);
            this.Controls.Add(this.textpecas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastrarPecas";
            this.Text = "TelaCadastrarPecas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textpecas;
        private TextBox textBoxmarcas;
        private TextBox txtboxcapacidade;
        private Button btncadastrarpecas;
    }
}