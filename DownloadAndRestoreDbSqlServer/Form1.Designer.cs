namespace DownloadAndRestoreDbSqlServer
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
            this.chkListaBancosDownload = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkListaBancosRestauracao = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDevDownload = new System.Windows.Forms.Button();
            this.btnHomologDownload = new System.Windows.Forms.Button();
            this.btnProdDownload = new System.Windows.Forms.Button();
            this.btnProdRestauracao = new System.Windows.Forms.Button();
            this.btnHomologRestauracao = new System.Windows.Forms.Button();
            this.btnDevRestauracao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.downloadProgresso = new System.Windows.Forms.ProgressBar();
            this.RestauracaoProgresso = new System.Windows.Forms.ProgressBar();
            this.lblTamanhoBanco = new System.Windows.Forms.Label();
            this.lblPorcentagemDownload = new System.Windows.Forms.Label();
            this.lblVelocidadeDownload = new System.Windows.Forms.Label();
            this.lblProcentagemRestauracao = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEnderecoDownload = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtPastaDbHost = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtDiretorioDbLocal = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtDiretorioDbProd = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtDiretorioDbHml = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtDiretorioDbDev = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLogSucesso = new System.Windows.Forms.TextBox();
            this.txtLogErro = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkListaBancosDownload
            // 
            this.chkListaBancosDownload.FormattingEnabled = true;
            this.chkListaBancosDownload.Items.AddRange(new object[] {
            "NomeBanco1",
            "NomeBanco2",
            "NomeBanco3",
            "NomeBanco4"});
            this.chkListaBancosDownload.Location = new System.Drawing.Point(6, 65);
            this.chkListaBancosDownload.Name = "chkListaBancosDownload";
            this.chkListaBancosDownload.Size = new System.Drawing.Size(239, 109);
            this.chkListaBancosDownload.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Downloads";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Restaurar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkListaBancosRestauracao
            // 
            this.chkListaBancosRestauracao.FormattingEnabled = true;
            this.chkListaBancosRestauracao.Items.AddRange(new object[] {
            "NomeBanco1",
            "NomeBanco2",
            "NomeBanco3",
            "NomeBanco4"});
            this.chkListaBancosRestauracao.Location = new System.Drawing.Point(340, 65);
            this.chkListaBancosRestauracao.Name = "chkListaBancosRestauracao";
            this.chkListaBancosRestauracao.Size = new System.Drawing.Size(239, 109);
            this.chkListaBancosRestauracao.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ambientes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ambientes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDevDownload
            // 
            this.btnDevDownload.Location = new System.Drawing.Point(6, 247);
            this.btnDevDownload.Name = "btnDevDownload";
            this.btnDevDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDevDownload.TabIndex = 6;
            this.btnDevDownload.Text = "Dev";
            this.btnDevDownload.UseVisualStyleBackColor = true;
            this.btnDevDownload.Click += new System.EventHandler(this.btnDevDownload_Click);
            // 
            // btnHomologDownload
            // 
            this.btnHomologDownload.Location = new System.Drawing.Point(88, 246);
            this.btnHomologDownload.Name = "btnHomologDownload";
            this.btnHomologDownload.Size = new System.Drawing.Size(75, 23);
            this.btnHomologDownload.TabIndex = 7;
            this.btnHomologDownload.Text = "Homolog";
            this.btnHomologDownload.UseVisualStyleBackColor = true;
            this.btnHomologDownload.Click += new System.EventHandler(this.btnHomologDownload_Click);
            // 
            // btnProdDownload
            // 
            this.btnProdDownload.Location = new System.Drawing.Point(170, 246);
            this.btnProdDownload.Name = "btnProdDownload";
            this.btnProdDownload.Size = new System.Drawing.Size(75, 23);
            this.btnProdDownload.TabIndex = 8;
            this.btnProdDownload.Text = "Prod";
            this.btnProdDownload.UseVisualStyleBackColor = true;
            this.btnProdDownload.Click += new System.EventHandler(this.btnProdDownload_Click);
            // 
            // btnProdRestauracao
            // 
            this.btnProdRestauracao.Location = new System.Drawing.Point(504, 245);
            this.btnProdRestauracao.Name = "btnProdRestauracao";
            this.btnProdRestauracao.Size = new System.Drawing.Size(75, 23);
            this.btnProdRestauracao.TabIndex = 11;
            this.btnProdRestauracao.Text = "Prod";
            this.btnProdRestauracao.UseVisualStyleBackColor = true;
            this.btnProdRestauracao.Click += new System.EventHandler(this.btnProdRestauracao_Click);
            // 
            // btnHomologRestauracao
            // 
            this.btnHomologRestauracao.Location = new System.Drawing.Point(422, 245);
            this.btnHomologRestauracao.Name = "btnHomologRestauracao";
            this.btnHomologRestauracao.Size = new System.Drawing.Size(75, 23);
            this.btnHomologRestauracao.TabIndex = 10;
            this.btnHomologRestauracao.Text = "Homolog";
            this.btnHomologRestauracao.UseVisualStyleBackColor = true;
            this.btnHomologRestauracao.Click += new System.EventHandler(this.btnHomologRestauracao_Click);
            // 
            // btnDevRestauracao
            // 
            this.btnDevRestauracao.Location = new System.Drawing.Point(340, 246);
            this.btnDevRestauracao.Name = "btnDevRestauracao";
            this.btnDevRestauracao.Size = new System.Drawing.Size(75, 23);
            this.btnDevRestauracao.TabIndex = 9;
            this.btnDevRestauracao.Text = "Dev";
            this.btnDevRestauracao.UseVisualStyleBackColor = true;
            this.btnDevRestauracao.Click += new System.EventHandler(this.btnDevRestauracao_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "Progresso";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 35);
            this.label6.TabIndex = 13;
            this.label6.Text = "Progresso";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downloadProgresso
            // 
            this.downloadProgresso.Location = new System.Drawing.Point(6, 340);
            this.downloadProgresso.Name = "downloadProgresso";
            this.downloadProgresso.Size = new System.Drawing.Size(239, 23);
            this.downloadProgresso.TabIndex = 14;
            // 
            // RestauracaoProgresso
            // 
            this.RestauracaoProgresso.Location = new System.Drawing.Point(340, 340);
            this.RestauracaoProgresso.Name = "RestauracaoProgresso";
            this.RestauracaoProgresso.Size = new System.Drawing.Size(239, 23);
            this.RestauracaoProgresso.TabIndex = 15;
            // 
            // lblTamanhoBanco
            // 
            this.lblTamanhoBanco.Location = new System.Drawing.Point(6, 370);
            this.lblTamanhoBanco.Name = "lblTamanhoBanco";
            this.lblTamanhoBanco.Size = new System.Drawing.Size(239, 23);
            this.lblTamanhoBanco.TabIndex = 16;
            this.lblTamanhoBanco.Text = "0Mb";
            this.lblTamanhoBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPorcentagemDownload
            // 
            this.lblPorcentagemDownload.Location = new System.Drawing.Point(6, 393);
            this.lblPorcentagemDownload.Name = "lblPorcentagemDownload";
            this.lblPorcentagemDownload.Size = new System.Drawing.Size(239, 23);
            this.lblPorcentagemDownload.TabIndex = 17;
            this.lblPorcentagemDownload.Text = "0%";
            this.lblPorcentagemDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVelocidadeDownload
            // 
            this.lblVelocidadeDownload.Location = new System.Drawing.Point(6, 416);
            this.lblVelocidadeDownload.Name = "lblVelocidadeDownload";
            this.lblVelocidadeDownload.Size = new System.Drawing.Size(239, 23);
            this.lblVelocidadeDownload.TabIndex = 18;
            this.lblVelocidadeDownload.Text = "0 kb/s";
            this.lblVelocidadeDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcentagemRestauracao
            // 
            this.lblProcentagemRestauracao.Location = new System.Drawing.Point(340, 370);
            this.lblProcentagemRestauracao.Name = "lblProcentagemRestauracao";
            this.lblProcentagemRestauracao.Size = new System.Drawing.Size(239, 23);
            this.lblProcentagemRestauracao.TabIndex = 19;
            this.lblProcentagemRestauracao.Text = "0%";
            this.lblProcentagemRestauracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 509);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblProcentagemRestauracao);
            this.tabPage1.Controls.Add(this.chkListaBancosDownload);
            this.tabPage1.Controls.Add(this.RestauracaoProgresso);
            this.tabPage1.Controls.Add(this.lblVelocidadeDownload);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnProdRestauracao);
            this.tabPage1.Controls.Add(this.lblPorcentagemDownload);
            this.tabPage1.Controls.Add(this.btnHomologRestauracao);
            this.tabPage1.Controls.Add(this.btnDevDownload);
            this.tabPage1.Controls.Add(this.btnDevRestauracao);
            this.tabPage1.Controls.Add(this.lblTamanhoBanco);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnHomologDownload);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.chkListaBancosRestauracao);
            this.tabPage1.Controls.Add(this.btnProdDownload);
            this.tabPage1.Controls.Add(this.downloadProgresso);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gerenciador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSalvar);
            this.tabPage2.Controls.Add(this.txtEnderecoDownload);
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.txtPastaDbHost);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Controls.Add(this.txtDiretorioDbLocal);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.txtDiretorioDbProd);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.txtDiretorioDbHml);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.txtDiretorioDbDev);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.txtSenha);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.txtNomeUsuario);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configurações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 446);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(575, 23);
            this.btnSalvar.TabIndex = 57;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtEnderecoDownload
            // 
            this.txtEnderecoDownload.Location = new System.Drawing.Point(6, 68);
            this.txtEnderecoDownload.Name = "txtEnderecoDownload";
            this.txtEnderecoDownload.Size = new System.Drawing.Size(575, 20);
            this.txtEnderecoDownload.TabIndex = 56;
            this.txtEnderecoDownload.UseWaitCursor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 52);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(119, 13);
            this.label33.TabIndex = 55;
            this.label33.Text = "Endereço de Download";
            // 
            // txtPastaDbHost
            // 
            this.txtPastaDbHost.Location = new System.Drawing.Point(6, 411);
            this.txtPastaDbHost.Name = "txtPastaDbHost";
            this.txtPastaDbHost.Size = new System.Drawing.Size(575, 20);
            this.txtPastaDbHost.TabIndex = 54;
            this.txtPastaDbHost.Text = "Data Source=(localdb)\\MSSQLLocalDb;Integrated Security=True";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 395);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(107, 13);
            this.label32.TabIndex = 53;
            this.label32.Text = "Host do Banco Local";
            // 
            // txtDiretorioDbLocal
            // 
            this.txtDiretorioDbLocal.Location = new System.Drawing.Point(6, 362);
            this.txtDiretorioDbLocal.Name = "txtDiretorioDbLocal";
            this.txtDiretorioDbLocal.Size = new System.Drawing.Size(575, 20);
            this.txtDiretorioDbLocal.TabIndex = 52;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(7, 346);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(95, 13);
            this.label30.TabIndex = 51;
            this.label30.Text = "Diretório do Banco";
            // 
            // txtDiretorioDbProd
            // 
            this.txtDiretorioDbProd.Location = new System.Drawing.Point(6, 313);
            this.txtDiretorioDbProd.Name = "txtDiretorioDbProd";
            this.txtDiretorioDbProd.Size = new System.Drawing.Size(575, 20);
            this.txtDiretorioDbProd.TabIndex = 50;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(7, 297);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(140, 13);
            this.label29.TabIndex = 49;
            this.label29.Text = "Diretório Download DB Prod";
            // 
            // txtDiretorioDbHml
            // 
            this.txtDiretorioDbHml.Location = new System.Drawing.Point(6, 264);
            this.txtDiretorioDbHml.Name = "txtDiretorioDbHml";
            this.txtDiretorioDbHml.Size = new System.Drawing.Size(575, 20);
            this.txtDiretorioDbHml.TabIndex = 46;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 248);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(141, 13);
            this.label27.TabIndex = 45;
            this.label27.Text = "Diretório Download DB HML";
            // 
            // txtDiretorioDbDev
            // 
            this.txtDiretorioDbDev.Location = new System.Drawing.Point(6, 215);
            this.txtDiretorioDbDev.Name = "txtDiretorioDbDev";
            this.txtDiretorioDbDev.Size = new System.Drawing.Size(575, 20);
            this.txtDiretorioDbDev.TabIndex = 44;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 199);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(138, 13);
            this.label26.TabIndex = 43;
            this.label26.Text = "Diretório Download DB Dev";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 166);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(575, 20);
            this.txtSenha.TabIndex = 42;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 150);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 13);
            this.label25.TabIndex = 41;
            this.label25.Text = "Senha";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(6, 3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(575, 37);
            this.label24.TabIndex = 40;
            this.label24.Text = "Diretorios do Banco";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(6, 117);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(575, 20);
            this.txtNomeUsuario.TabIndex = 39;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "Nome Usuario";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtLogErro);
            this.tabPage3.Controls.Add(this.txtLogSucesso);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(587, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(575, 37);
            this.label7.TabIndex = 41;
            this.label7.Text = "Sucesso";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(575, 37);
            this.label8.TabIndex = 42;
            this.label8.Text = "Erros";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLogSucesso
            // 
            this.txtLogSucesso.Location = new System.Drawing.Point(3, 50);
            this.txtLogSucesso.Multiline = true;
            this.txtLogSucesso.Name = "txtLogSucesso";
            this.txtLogSucesso.Size = new System.Drawing.Size(578, 191);
            this.txtLogSucesso.TabIndex = 43;
            // 
            // txtLogErro
            // 
            this.txtLogErro.Location = new System.Drawing.Point(3, 281);
            this.txtLogErro.Multiline = true;
            this.txtLogErro.Name = "txtLogErro";
            this.txtLogErro.Size = new System.Drawing.Size(578, 191);
            this.txtLogErro.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListaBancosDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chkListaBancosRestauracao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDevDownload;
        private System.Windows.Forms.Button btnHomologDownload;
        private System.Windows.Forms.Button btnProdDownload;
        private System.Windows.Forms.Button btnProdRestauracao;
        private System.Windows.Forms.Button btnHomologRestauracao;
        private System.Windows.Forms.Button btnDevRestauracao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar downloadProgresso;
        private System.Windows.Forms.ProgressBar RestauracaoProgresso;
        private System.Windows.Forms.Label lblTamanhoBanco;
        private System.Windows.Forms.Label lblPorcentagemDownload;
        private System.Windows.Forms.Label lblVelocidadeDownload;
        private System.Windows.Forms.Label lblProcentagemRestauracao;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtEnderecoDownload;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtPastaDbHost;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtDiretorioDbLocal;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtDiretorioDbProd;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtDiretorioDbHml;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtDiretorioDbDev;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLogSucesso;
        private System.Windows.Forms.TextBox txtLogErro;
    }
}

