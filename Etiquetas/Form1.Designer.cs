namespace Etiquetas
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
            this.btImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbRh = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblError = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.rbEtiqueta_6 = new System.Windows.Forms.RadioButton();
            this.rbEtiqueta_8 = new System.Windows.Forms.RadioButton();
            this.lbQuarto = new System.Windows.Forms.Label();
            this.lbAndar = new System.Windows.Forms.Label();
            this.cbExame = new System.Windows.Forms.ComboBox();
            this.cbClinica = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(192, 216);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(75, 23);
            this.btImprimir.TabIndex = 5;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Informe o RH";
            // 
            // txbRh
            // 
            this.txbRh.Location = new System.Drawing.Point(124, 74);
            this.txbRh.Name = "txbRh";
            this.txbRh.Size = new System.Drawing.Size(143, 20);
            this.txbRh.TabIndex = 1;
            this.txbRh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbRh_KeyPress);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(139, 157);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 6;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(105, 22);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(222, 20);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Sistema de Etiquetas Exames";
            // 
            // rbEtiqueta_6
            // 
            this.rbEtiqueta_6.AutoSize = true;
            this.rbEtiqueta_6.Location = new System.Drawing.Point(124, 183);
            this.rbEtiqueta_6.Name = "rbEtiqueta_6";
            this.rbEtiqueta_6.Size = new System.Drawing.Size(77, 17);
            this.rbEtiqueta_6.TabIndex = 8;
            this.rbEtiqueta_6.TabStop = true;
            this.rbEtiqueta_6.Text = "6 etiquetas";
            this.rbEtiqueta_6.UseVisualStyleBackColor = true;
            // 
            // rbEtiqueta_8
            // 
            this.rbEtiqueta_8.AutoSize = true;
            this.rbEtiqueta_8.Location = new System.Drawing.Point(242, 183);
            this.rbEtiqueta_8.Name = "rbEtiqueta_8";
            this.rbEtiqueta_8.Size = new System.Drawing.Size(77, 17);
            this.rbEtiqueta_8.TabIndex = 9;
            this.rbEtiqueta_8.TabStop = true;
            this.rbEtiqueta_8.Text = "8 etiquetas";
            this.rbEtiqueta_8.UseVisualStyleBackColor = true;
            // 
            // lbQuarto
            // 
            this.lbQuarto.AutoSize = true;
            this.lbQuarto.Location = new System.Drawing.Point(31, 135);
            this.lbQuarto.Name = "lbQuarto";
            this.lbQuarto.Size = new System.Drawing.Size(38, 13);
            this.lbQuarto.TabIndex = 10;
            this.lbQuarto.Text = "Clinica";
            // 
            // lbAndar
            // 
            this.lbAndar.AutoSize = true;
            this.lbAndar.Location = new System.Drawing.Point(380, 135);
            this.lbAndar.Name = "lbAndar";
            this.lbAndar.Size = new System.Drawing.Size(39, 13);
            this.lbAndar.TabIndex = 14;
            this.lbAndar.Text = "Exame";
            // 
            // cbExame
            // 
            this.cbExame.FormattingEnabled = true;
            this.cbExame.Items.AddRange(new object[] {
            "ELETRONEUROMIOGRAFIA",
            "ELETROENCEFALOGRAMA",
            "ENDOSCOPIA",
            "COLONOSCOPIA",
            "RADIOLOGIA INTERVENCIONISTA",
            "CIRURGIA VASCULAR",
            "CATETERISMO CARDÍACO",
            "ULTRASSOM COM PUNÇÃO"});
            this.cbExame.Location = new System.Drawing.Point(446, 127);
            this.cbExame.Name = "cbExame";
            this.cbExame.Size = new System.Drawing.Size(208, 21);
            this.cbExame.TabIndex = 15;
            // 
            // cbClinica
            // 
            this.cbClinica.FormattingEnabled = true;
            this.cbClinica.Items.AddRange(new object[] {
            " Pronto Socorro Adulto ",
            "Acupuntura",
            "Alergia ",
            "Amb. Desc. Carrão",
            "Amb. Desc. Lapa",
            "Amb. Desc. Santo Amaro",
            "Amb. Desc. São Miguel",
            "Amb. Desc. Tucuruvi",
            "Berçário e UTI Neonatal",
            "Buco Maxilo Facial",
            "Cardiologia",
            "Cir.Cabeça e Pescoço ",
            "Cirurgia Pediátrica",
            "Cirurgia Plástica",
            "Cirurgia Torácica ",
            "Cirurgia Vascular",
            "Clínica Médica",
            "Dermatologia",
            "Endoscopia",
            "Endocrinologia",
            "Fisiatria ",
            "Fisioterapia",
            "Fonoaudiologia",
            "Gastrocirurgia",
            "Gastroclínica",
            "Geriatria",
            "Ginecologia",
            "Hematologia",
            "Molestias Infecciosas",
            "Nefrologia",
            "Neurocirurgia ",
            "Neuroclínica",
            "Obstetrícia",
            "Odontologia",
            "Oftalmologia",
            "Oncologia",
            "Ortopedia ",
            "Otorrinolaringologia",
            "Pediatria, PSI e UTI Pediátrica"});
            this.cbClinica.Location = new System.Drawing.Point(124, 127);
            this.cbClinica.Name = "cbClinica";
            this.cbClinica.Size = new System.Drawing.Size(228, 21);
            this.cbClinica.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 269);
            this.Controls.Add(this.cbClinica);
            this.Controls.Add(this.cbExame);
            this.Controls.Add(this.lbAndar);
            this.Controls.Add(this.lbQuarto);
            this.Controls.Add(this.rbEtiqueta_8);
            this.Controls.Add(this.rbEtiqueta_6);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbRh);
            this.Controls.Add(this.btImprimir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbRh;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.RadioButton rbEtiqueta_6;
        private System.Windows.Forms.RadioButton rbEtiqueta_8;
        private System.Windows.Forms.Label lbQuarto;
        private System.Windows.Forms.Label lbAndar;
        private System.Windows.Forms.ComboBox cbExame;
        private System.Windows.Forms.ComboBox cbClinica;

    }
}

