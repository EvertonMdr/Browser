using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{

    public partial class Form1 : Form
    {
        private String mb;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            criaArquivoTexto();
            carregaBarrafavoritos();
            mb = "www.google.com.br/search?q=";
            wbPage.ScriptErrorsSuppressed = true; // ativa javascript das paginas

        
        }

        private void criaArquivoTexto()
        {
            Stream arq = null;
            try
            {
                arq = File.Open("Favoritos.txt", FileMode.OpenOrCreate);
                arq.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ", ex.Message);
            }
        }

        protected void botao_Click(object sender, System.EventArgs e)
        {

            ToolStripButton botao = (ToolStripButton)sender;

            String end = getEndereco(botao.Text);
            wbPage.Navigate(end);

        }

        private void carregaBarrafavoritos()
        {
            int tam = 0;
            Stream arq = null;
            toolStrip2.Items.Clear();
          
            try
            {
                arq = File.Open("Favoritos.txt", FileMode.Open); ;
                String s;
                StreamReader leitor = new StreamReader(arq);
                s = leitor.ReadLine();

                string caminho = "imagens\\favor.png";
               
                Image img =Image.FromFile(caminho);

                if (s != null)
                {
                    int i = 0;
                    string titulo_pag = s.Substring(s.IndexOf('*') + 1);

                    if (titulo_pag.Length > 13)
                        titulo_pag = titulo_pag.Substring(0, 13);
                  

                    ToolStripButton[] botao = new ToolStripButton[30];
                  

                   botao[i] = new ToolStripButton(titulo_pag);
                   botao[i].Image = img;
                   botao[i].Click += new EventHandler(botao_Click);
                   toolStrip2.Items.Add(botao[i]);

                    s = leitor.ReadLine();
                    i++;
                    while (s != null)
                    {
                         titulo_pag = s.Substring(s.IndexOf('*') + 1);

                        if (titulo_pag.Length > 13)
                            titulo_pag = titulo_pag.Substring(0, 13);

                        botao[i] = new ToolStripButton(titulo_pag);
                        toolStrip2.Items.Add(botao[i]);
                        botao[i].Image = img;
                        botao[i].Click += new EventHandler(botao_Click);
                        s = leitor.ReadLine();
                        i++;
                    }
                }
                leitor.Close();
                arq.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro:---- " + ex.Message);
            }
        }

        private bool endeExiste(String end)
        {
            String s = "";
            try
            {
                Stream arq = File.Open("Favoritos.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(arq);

                s = leitor.ReadLine();
                if (s != null)
                {
                    s = s.Substring(0, s.IndexOf('*'));
                    while (s != null && !s.Equals(end))
                    {
                        s = leitor.ReadLine();
                        if (s != null)
                            s = s.Substring(0, s.IndexOf('*'));
                    }
                }

                leitor.Close();
                arq.Close();

            } catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            if (s == null)
                return false;

            return true;
        }

        private String getEndereco(String desc)
        {
            String s = "", desc_aux;
            int ini, tam;
            try
            {
                Stream arq = File.Open("Favoritos.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(arq);

                s = leitor.ReadLine();
                if (s != null)
                {
                    ini = s.IndexOf('*') + 1;
                    tam = s.Length - ini;

                    desc_aux = s.Substring(s.IndexOf('*')+1, tam);
                    while (s != null && !desc_aux.Contains(desc))
                    {
                        s = leitor.ReadLine();

                     

                        if (s != null)
                        {
                            ini = s.IndexOf('*') + 1;
                            tam = s.Length - ini;

                            desc_aux = s.Substring(ini, tam);
                        }
                            
                    }
                }

                leitor.Close();
                arq.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            if (s == null)
                return null;

            return s.Substring(0, s.IndexOf('*'));
        }

        private void carregaEndereco(String url)
        {
            if (url == null)
            MessageBox.Show("Pagina nao encontrada!!");
            else
           wbPage.Navigate(url);

        }

        private void mecanismoBusca(String mb,String frase)
        {
            mb = mb + frase;
            carregaEndereco(mb);
        }

        public bool isUrl(String str)
        {
            if (str.Length > 4 && str.Substring(0, 4).ToLower().CompareTo("www.") == 0)
                return true;

            return false;
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            if (!cbPesquisa.Items.Contains(cbPesquisa.Text)) // adicionando histórico
                cbPesquisa.Items.Add(cbPesquisa.Text);

             cbPesquisa.Text = wbPage.Url.ToString();

            if (!endeExiste(wbPage.Url.ToString()))
                btFavoritos.Image = Image.FromFile("imagens\\starcinza.png");
            else
                btFavoritos.Image = Image.FromFile("imagens\\starhellow.png");
        }
    
        private void btFavoritos_Click(object sender, EventArgs e)
        {

            if (!endeExiste(cbPesquisa.Text))
            {
                try
                {
                
                    Stream arq = File.Open("Favoritos.txt", FileMode.Append);
                    StreamWriter gravador = new StreamWriter(arq);
                    gravador.WriteLine(cbPesquisa.Text+"*"+wbPage.DocumentTitle);
                    gravador.Close();
                    arq.Close();
                    btFavoritos.Image = Image.FromFile("imagens\\starhellow.png");
                    carregaBarrafavoritos();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
           

        }

        private void limparOsFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            File.Delete("favoritos.txt");
            criaArquivoTexto();
            toolStrip2.Items.Clear();
            btFavoritos.Image = Image.FromFile("imagens\\starcinza.png");

        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {

            try
            {
                if (e.CurrentProgress > 0)
                {
                    progressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
                    progressBar1.Value = Convert.ToInt32(e.CurrentProgress);
                    progressBar1.Visible = true;

                }
                else
                    progressBar1.Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cbPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true; // tira o barulho da tecla enter

                if (isUrl(cbPesquisa.Text))
                {
                    carregaEndereco(cbPesquisa.Text);
                }
                else
                    mecanismoBusca(mb, cbPesquisa.Text);

            }
        }

        private void exiberBarrasDeFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exiberBarrasDeFavoritosToolStripMenuItem.Checked)
                toolStrip2.Visible = true;
            else
                toolStrip2.Visible = false;


        }

        private void btRecarregar_Click(object sender, EventArgs e)
        {
            wbPage.Refresh();
        }

        protected void setStatusChecked(String nome)
        {

            toolStripMenuItemGoogle.Checked = false;
            toolStripMenuItemYahoo.Checked = false;
            toolStripMenuItemBig.Checked = false;

            if (nome.Equals("Google"))
            {
                toolStripMenuItemGoogle.Checked = true;
                return;

            }

            if (nome.Equals("Yahoo"))
            {
                toolStripMenuItemYahoo.Checked = true;
                return;
            }

            toolStripMenuItemBig.Checked = true;
            return;

         }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setStatusChecked("Google");
              mb = "www.google.com.br/search?q=";
        }

        private void yahooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setStatusChecked("Yahoo");
            mb = "https://br.search.yahoo.com/search?p=";
        }

        private void bigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setStatusChecked("Big");
            mb = "https://www.bing.com/search?q=";
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            wbPage.Navigate(mb);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            wbPage.Refresh();
        }

        private void btArrowRight_Click(object sender, EventArgs e)
        {
            wbPage.GoForward();
        }

        private void btArrowLeft_Click(object sender, EventArgs e)
        {
            wbPage.GoBack();
        }

        private void toolStripMenuItemSair_Click(object sender, EventArgs e)
        {
            Close();
        }

       

      
    }
}



