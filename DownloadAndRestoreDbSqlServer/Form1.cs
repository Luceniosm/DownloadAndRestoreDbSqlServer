using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadAndRestoreDbSqlServer
{
    public partial class Form1 : Form
    {
        Stopwatch sw;
        delegate void SetCheckedListBoxCallback(CheckedListBox checkedList, int indice, bool checado);
        delegate void SetBtnCallback(List<Button> buttons, bool habilitar);


        public Form1()
        {
            InitializeComponent();
        }

        #region Download

        private void btnDevDownload_Click(object sender, EventArgs e)
        {
            ValidaPastaCriada(txtDiretorioDbDev.Text, false);
            BloquearDesbloquearBotoesDeDownload(false);
            Task.Run(() => DownloadBancosSelecionados(txtEnderecoDownload.Text, txtDiretorioDbDev.Text));
        }
       

        private void btnHomologDownload_Click(object sender, EventArgs e)
        {
            ValidaPastaCriada(txtDiretorioDbHml.Text, false);
            BloquearDesbloquearBotoesDeDownload(false);
            Task.Run(() => DownloadBancosSelecionados(txtEnderecoDownload.Text, txtDiretorioDbHml.Text));
        }

        private void btnProdDownload_Click(object sender, EventArgs e)
        {
            ValidaPastaCriada(txtDiretorioDbProd.Text, false);
            BloquearDesbloquearBotoesDeDownload(false);
            Task.Run(() => DownloadBancosSelecionados(txtEnderecoDownload.Text, txtDiretorioDbProd.Text));
        }

        private void DownloadBancosSelecionados(string urlDownload, string caminhoPastaSalvarDownload)
        {
            var existeProximoChecado = false;
            for (int i = 0; i < chkListaBancosDownload.Items.Count; i++)
            {
                if (chkListaBancosDownload.GetItemCheckState(i) == CheckState.Checked)
                {
                    try
                    {
                        existeProximoChecado = true;
                        var chkDelegade = new SetCheckedListBoxCallback(FlegarCheckBox);
                        this.Invoke(chkDelegade, new object[] { chkListaBancosDownload, i, false });

                        MensagemLog("Download do banco :" + chkListaBancosDownload.Items[i].ToString(), true);
                        RealizarDownload(urlDownload, chkListaBancosDownload.Items[i].ToString(), caminhoPastaSalvarDownload);
                        break;
                    }
                    catch (Exception ex)
                    {
                        existeProximoChecado = false;
                        MensagemLog(ex.Message, false);
                        MensagemLog(ex.InnerException?.ToString(), false);
                    }
                }
            }
            if (existeProximoChecado) return;

            BloquearDesbloquearBotoesDeDownload(true);
        }
        
        private void BloquearDesbloquearBotoesDeDownload(bool acao)
        {
            var btnDelegade = new SetBtnCallback(DesabilitarOuHabilitarBotoes);
            this.Invoke(btnDelegade, new object[]
            {
                new List<Button>
                {
                    btnDevDownload,
                    btnHomologDownload,
                    btnProdDownload                    
                },
                acao
            });
        }

        private void RealizarDownload(string urlDownload, string nomedoBanco, string caminhoPastaSalvarDownload)
        {
            var webClient = new WebClient
            {
                Credentials = new NetworkCredential(txtNomeUsuario.Text, txtSenha.Text)
            };
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler((s, e) => {
                DownloadDbCompleto(nomedoBanco, urlDownload, caminhoPastaSalvarDownload, e);
            });
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadDbProcesso);


            var url = new Uri(nomedoBanco);
            sw.Start();

            var link = new Uri(ObterLink(webClient, url));
            webClient.DownloadFileAsync(link, caminhoPastaSalvarDownload + @"\" + nomedoBanco + ".bak");
        }
                

        private void DownloadDbCompleto(string nomedoBanco, string urlDownload, string caminhoPastaSalvarDownload, AsyncCompletedEventArgs e)
        {
            sw.Reset();

            if (e.Cancelled == true)
            {
                MensagemLog("Download do banco " + nomedoBanco + " cancelado!!", true);
            }
            else
            {
                MensagemLog("Download do banco " + nomedoBanco + " Finalizado!!", true);
            }


            AlterarTextLabel(lblVelocidadeDownload, "0 kb/s");
            AlterarTextLabel(lblPorcentagemDownload, "0%");
            AlterarTextLabel(lblTamanhoBanco, "0MB");
            AlterarStatusDownloadDbProcentagem(0);
            DownloadBancosSelecionados(urlDownload, caminhoPastaSalvarDownload);
        }

        private void DownloadDbProcesso(object sender, DownloadProgressChangedEventArgs e)
        {
            AlterarTextLabel(lblVelocidadeDownload, string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00")));
            AlterarTextLabel(lblPorcentagemDownload, e.ProgressPercentage.ToString() + "%");
            AlterarTextLabel(lblTamanhoBanco, string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00")));
            AlterarStatusDownloadDbProcentagem(e.ProgressPercentage);
        }

        private string ObterLink(WebClient webClient, Uri url)
        {
            var m1 = Regex.Matches(webClient.DownloadString(url), @"(<A.*?>.*?</A>)", RegexOptions.Singleline);            
            var novaUrl = string.Empty;
            
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;                
                Match m2 = Regex.Match(value, @"HREF=\""(.*?)\""", RegexOptions.Singleline);
                if (m2.Success)
                {
                    novaUrl = m2.Groups[1].Value;
                }
            }
          
            return "http://" + url.Host + novaUrl;
        }

        public void AlterarStatusDownloadDbProcentagem(int porcentagem)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(AlterarStatusDownloadDbProcentagem), new object[] { porcentagem });
                return;
            }
            downloadProgresso.Value = porcentagem;
        }


        #endregion

        #region Restauração

        private void btnDevRestauracao_Click(object sender, EventArgs e)
        {

        }

        private void btnHomologRestauracao_Click(object sender, EventArgs e)
        {

        }

        private void btnProdRestauracao_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region Core

        private void ValidaPastaCriada(string caminhoPasta, bool pastaOculta)
        {
            try
            {
                if (!Directory.Exists(caminhoPasta))
                {
                    var diretorio = Directory.CreateDirectory(caminhoPasta);
                    if(pastaOculta)
                        diretorio.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                }
            }
            catch (Exception ex)
            {
                MensagemLog(ex.Message, false);
                MensagemLog(ex.InnerException?.ToString(), false);
            }
        }
        
        private void MensagemLog(string value, bool sucesso)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string, bool>(MensagemLog), new object[] { value, sucesso });
                return;
            }

            if (sucesso)
            {
                txtLogSucesso.Text += value + Environment.NewLine;
                txtLogSucesso.SelectionStart = txtLogSucesso.TextLength;
                txtLogSucesso.ScrollToCaret();
            }
            else
            {
                txtLogErro.Text += value + Environment.NewLine;
                txtLogErro.SelectionStart = txtLogSucesso.TextLength;
                txtLogErro.ScrollToCaret();
            }
        }

        private void FlegarCheckBox(CheckedListBox checkedList, int indice, bool checado)
        {
            checkedList.SetItemChecked(indice, checado);
        }

        private void DesabilitarOuHabilitarBotoes(List<Button> buttons, bool habilitar)
        {
            foreach (var button in buttons)
            {
                button.Enabled = habilitar;
            }
        }

        private void AlterarTextLabel(Label lbl, string texto)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<Label, string>(AlterarTextLabel), new object[] { lbl, texto });
                return;
            }

            lbl.Text = texto;
        }

        #endregion
    }
}
