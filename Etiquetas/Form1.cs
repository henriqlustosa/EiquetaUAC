﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using GenCode128;
using System.Globalization;
//using System.ServiceModel.Web;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace Etiquetas
{
    public partial class Form1 : Form
    {
        String error;

        int status;
        Paciente detiq;
        Paciente detiq2;


        //HospubDados dados = new HospubDados();
        //string conStr = "DSN=hospub-server;Uid=;Pwd=;";//string de conexão com o banco de dados


        public Form1()
        {
            InitializeComponent();
            status = 0;
            error = "";
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 400, 700);
            printDialog1.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 400, 700);

        }
        public class Paciente
        {
            public int cd_prontuario { get; set; }
            public string nm_nome { get; set; }
            public int cd_rf_matricula { get; set; }
            public string in_sexo { get; set; }
            public string nm_mae { get; set; }
            public string dt_data_nascimento { get; set; }
            public int nr_idade { get; set; }
           


        }
        private void btImprimir_Click(object sender, EventArgs e)
        {
            btImprimir.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            //btImprimir.Enabled = true;

        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btImprimir.Enabled = true;
            if (status == 1)
                lblError.Text = error;
            else
                lblError.ResetText();
            this.txbRh.ResetText();
            this.txbRh.Enabled = true;
            this.txbRh.Focus();
            this.txbRh.Text = "";
            this.cbExame.ResetText();
            this.cbClinica.ResetText();
            this.cbNumeroEtiquetas.ResetText();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string NumeroDeEtiquetas = "";
                if (cbNumeroEtiquetas.InvokeRequired)
                {
                    cbNumeroEtiquetas.Invoke(new MethodInvoker(delegate { NumeroDeEtiquetas = cbNumeroEtiquetas.Text; }));
                }

                int rh = Convert.ToInt32(txbRh.Text);
                int count = 0;
                //detiq = dados.getDados(be);
                string url = "http://10.48.21.64:5000/hspmsgh-api/pacientes/paciente/" + rh;
                int maxCount = Convert.ToInt32(NumeroDeEtiquetas);
                WebRequest request = WebRequest.Create(url);
                try
                {
                    using (var twitpicResponse = (HttpWebResponse)request.GetResponse())
                    {
                        using (var reader = new StreamReader(twitpicResponse.GetResponseStream()))
                        {
                            JsonSerializer json = new JsonSerializer();
                            var objText = reader.ReadToEnd();
                            detiq = JsonConvert.DeserializeObject<Paciente>(objText);


                        }
                    }


                   
                    PrintDialog printDialog1 = new PrintDialog();
                    printDialog1.Document = printDocument1;
                    DialogResult result = printDialog1.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        while (maxCount > count)
                        {
                            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 295, 98);
                           //printDialog1.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 295, 98);
                            printDocument1.Print();
                            count++;
                        }

             



                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Número de RH inexistente! " + ex.Message);
                    status = 1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Número de RH inexistente! " + ex.Message);
                status = 1;

            }
        }
     

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Clinica = "";
            if (cbClinica.InvokeRequired)
            {
                cbClinica.Invoke(new MethodInvoker(delegate { Clinica = cbClinica.Text; }));
            }
            string Exame = "";
            if (cbExame.InvokeRequired)
            {
                cbClinica.Invoke(new MethodInvoker(delegate { Exame = cbExame.Text; }));
            }


            DateTime dataTempo = DateTime.Now;
            String dataNormal = dataTempo.ToShortDateString();
            String[] data = dataTempo.ToShortDateString().Split('/');
            String strData = data[2] + data[1] + data[0];
            String[] tempo = dataTempo.ToLongTimeString().Split(':');
            String strTempo = tempo[0] + tempo[1] + tempo[2];
            String codigo = strData + strTempo;





            //e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 295, 98);//900 é a largura da página
            //printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 295, 98);
           // printDialog1.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 295, 98);
            using (Graphics g = e.Graphics)
            {
                using (Font fnt = new Font("Arial", 12))
                {

                    int startXEsquerda = 5;
                    int starty = 0;//distancia das linhas
                   

                   
                        string nomep1 = detiq.nm_nome;
                        int contN = nomep1.Length;
                        string nomep = detiq.nm_nome.Substring(0, 26);
                        string nomeCompos = nomep1.Substring(26);


                        g.DrawString("Nome: " + detiq.nm_nome, new Font("Arial", 7, FontStyle.Bold), System.Drawing.Brushes.Black, startXEsquerda, starty + 5);
                        g.DrawString("RH: " + txbRh.Text + "       DN: " + detiq.dt_data_nascimento + "       SEXO: " + detiq.in_sexo, new Font("Arial", 7, FontStyle.Regular), System.Drawing.Brushes.Black, startXEsquerda, starty + 20);
                        g.DrawString("NOME DA MÃE: " + detiq.nm_mae, new Font("Arial", 7, FontStyle.Regular), System.Drawing.Brushes.Black, startXEsquerda, starty + 35);
                       
                        g.DrawString("Exame: " + Exame + " Data: " + dataNormal, new Font("Arial", 7, FontStyle.Regular), System.Drawing.Brushes.Black, startXEsquerda, starty + 50);
                        g.DrawString("Clinica: " + Clinica, new Font("Arial", 7, FontStyle.Regular), System.Drawing.Brushes.Black, startXEsquerda, starty + 65);
                        g.DrawString("Pedido: " + codigo, new Font("Arial", 7, FontStyle.Regular), System.Drawing.Brushes.Black, startXEsquerda, starty + 80);
                       



                    
                }
            }


        }

        private void txbRh_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

                btImprimir_Click(sender, e);

            }
        }


    }
}