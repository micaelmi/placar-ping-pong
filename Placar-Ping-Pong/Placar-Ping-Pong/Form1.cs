using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placar_Ping_Pong
{
    public partial class Scores : Form
    {
        public int p1 = 0, p2 = 0, s = 0, conta = 0, num = 0,
            br = 0, usa = 0,  sets1 = 0, sets2 = 0, contador = 0, fim = 0;
        public String pl1, pl2, nome1, nome2, numSets, txSet1, txSet2;
        public char KeyChar { get; set; }
        
        public Scores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Convert();
            Score1.Text = pl1;
            Score2.Text = pl2;
            pb1.Visible = true;
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
                p1++;
                s++;
                Saque();
                Convert();
                Score1.Text = pl1;
                Fala();
                VaiA2();

            if (p1 == 7 & p2 == 5 & pb1.Visible == true || p2 == 7 & p1 == 5 & pb2.Visible == true)
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SetOutputToDefaultAudioDevice();
                synth.Volume = 100;
                synth.Rate = 3;
                synth.Speak("Sete a cin, COCAAADA!");
            }

            if (p1 >= 11 && p2 <= p1 - 2)
            {
                if(br == 1)
                {
                    messageWin.Text = lbP1.Text +  " venceu!!!";
                } 
                else
                {
                    messageWin.Text = lbP1.Text + " Wins!!!";
                }
                while (conta <= 0)
                {
                    SpeechSynthesizer synth = new SpeechSynthesizer();

                    synth.SetOutputToDefaultAudioDevice();
                    synth.Volume = 100;
                    synth.Rate = 3;
                    synth.Speak(lbP1.Text + " venceu!!!");
                    conta++;
                }

                if(p1 > 0 && contador == 0)
                {
                    sets1++;
                    txSet1 = sets1.ToString();
                    SetsP1.Text = sets1.ToString();
                    contador++;
                }

                if(txSet1 == cbSets.Text && fim == 0)
                {
                    final();
                }

            }

        }

        private void final()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 100;
            synth.Rate = 3;
            synth.Speak("Fim de Jogo ");
            fim++;

            /*sets1 = 0;
            SetsP1.Text = "0";
            sets2 = 0;
            SetsP2.Text = "0";*/
        }

        private void btnPlus1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Teclas(e);
        }

        

        private void btnLess1_Click(object sender, EventArgs e)
        {
            if (p1 > 0)
            {
                p1--;
                s--;
                Saque();
                Convert();
                Score1.Text = pl1;
                TrocaSaque();
            }
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            
                p2++;
                s++;
                Saque();
                Convert();
                Score2.Text = pl2;
                Fala();
                VaiA2();

            if (p1 == 7 & p2 == 5 & pb1.Visible == true || p2 == 7 & p1 == 5 & pb2.Visible == true)
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SetOutputToDefaultAudioDevice();
                synth.Volume = 100;
                synth.Rate = 3;
                synth.Speak("Sete a cin, COCAAADA!");
            }

            if (p2 >= 11 && p1 <= p2 - 2)
            {
                if (br == 1)
                {
                    messageWin.Text = lbP2.Text + " venceu!!!";
                }
                else
                {
                    messageWin.Text = lbP2.Text + " Wins!!!";
                }
                while (conta <= 0)
                {
                    SpeechSynthesizer synth = new SpeechSynthesizer();

                    synth.SetOutputToDefaultAudioDevice();
                    synth.Volume = 100;
                    synth.Rate = 3;
                    synth.Speak(lbP2.Text + " VENCEU!");
                    conta++;
                }
                if (p2 > 0 && contador == 0)
                {
                    sets2++;
                    txSet2 = sets2.ToString();
                    SetsP2.Text = sets2.ToString();
                    contador++;
                }

                if (txSet2 == cbSets.Text && fim == 0)
                {
                    final();
                }
            }

        }

        private void btnPlus2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Teclas(e);
        }

        private void btnLess2_Click(object sender, EventArgs e)
        {
            if (p2 > 0)
            {
                p2--;
                s--;
                Saque();
                Convert();
                Score2.Text = pl2;
                TrocaSaque();
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionaRegistro();
            Score1.Text = "0";
            Score2.Text = "0";
            messageWin.Text = "";
            p1 = 0;
            p2 = 0;
            s = 0;
            conta = 0;
            contador = 0;
            num = 0;
            lbVaiA2.Text = "";
            Convert();
        }

        private void AdicionaRegistro()
        {


            conexao comb = new conexao();
            // INSERT INTO `tb01_resultados` 
            //(`seq`, `jogador1`, `sets1`, `pontos1`, `pontos2`, `sets2`, `jogador2`, `data`)
            //VALUES (NULL, 'teste1', '1', '11', '1', '1', 'teste2', '2021-02-23');
            comb.sql = "INSERT INTO tb01_resultados (jogador1, sets1, pontos1, pontos2, sets2, jogador2, data)";
            comb.sql += "VALUES ('" + nome1 + "', '" + sets1 + "', '" + p1 + "', '"  + p2 + "', '" + sets2 + "', '" + nome2 + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            //MessageBox.Show(comb.sql);
            comb.open();

            int lin = comb.Runsql();

            if (lin > 0)
            {
                MessageBox.Show("Dados registrados!", "Ação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro! Desculpe, algo deu errado", "Ação",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            comb.close();
        }
     

        private void btnChange_Click(object sender, EventArgs e)
        {
            TrocaSaque();
        }

        private void TrocaSaque()
        {
            if (pb1.Visible == true)
            {
                pb1.Visible = false;
                pb2.Visible = true;
            }
            else
            {
                pb2.Visible = false;
                pb1.Visible = true;
            }
        }

        private void Score1_Click(object sender, EventArgs e)
        {

        }

        

        private void Convert()
        {
            pl1 = p1.ToString();
            pl2 = p2.ToString();
        }

        private void Saque()
        {
            if(pb1.Visible == true)
            {
                if(s % 2 == 0)
                {
                    pb1.Visible = false;
                    pb2.Visible = true;
                }
            }
            else
            {
                if (pb2.Visible == true)
                {
                    if (s % 2 == 0)
                    {
                        pb2.Visible = false;
                        pb1.Visible = true;
                    }
                }
            } 
        }

        private void Fala()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 100;
            synth.Rate = 2;

            if(pb1.Visible == true)
            {
                synth.Speak(pl1 + "a" + pl2);
            }

            if (pb2.Visible == true)
            {
                synth.Speak(pl2 + "a" + pl1);
            }

        }

        private void pbRegistros_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 tela = new Form3();
            tela.Show();
        }

        private void lbP1_Click(object sender, EventArgs e)
        {

        }

        private void txPlayer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {

            if (txPlayer1.Text != "" && txPlayer2.Text != "" && cbSets.Text != "")
            {
                nome1 = txPlayer1.Text;
                nome2 = txPlayer2.Text;
                numSets = cbSets.Text;
                pnStart.Visible = false;

                lbP1.Text = nome1;
                lbP2.Text = nome2;
            }

            else
            {
                lbAviso.Visible = true;
            }

        }

        private void cbSets_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void VaiA2()
        {
            
            if(p1 >= 10 && p2 >= 10)
            {
                s++;
                lbVaiA2.Visible = true;
                while (num <= 0)
                {
                    SpeechSynthesizer synth = new SpeechSynthesizer();

                    synth.SetOutputToDefaultAudioDevice();
                    synth.Volume = 100;
                    synth.Rate = 2;
                    synth.Speak("VAI A 2");
                    num++;
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 tela = new Form2();
            tela.Show();
        }

        private void closePanel_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void Teclas(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.A)
            {
                p1++;
                s++;
                Saque();
                Convert();
                Score1.Text = pl1;
                VaiA2();

                if (p1 == 7 & p2 == 5 & pb1.Visible == true || p2 == 7 & p1 == 5 & pb2.Visible == true)
                {
                    SpeechSynthesizer synth = new SpeechSynthesizer();
                    synth.SetOutputToDefaultAudioDevice();
                    synth.Volume = 100;
                    synth.Rate = 3;
                    synth.Speak("Sete a cin, COCAAADA!");
                }


                if (p1 >= 11 && p2 <= p1 - 2)
                {
                    if (br == 1)
                    {
                        messageWin.Text = lbP1.Text + " venceu!!!";
                    }
                    else
                    {
                        messageWin.Text = lbP1.Text + " Wins!!!";
                    }
                    while (conta <= 0)
                    {
                        SpeechSynthesizer synth = new SpeechSynthesizer();

                        synth.SetOutputToDefaultAudioDevice();
                        synth.Volume = 100;
                        synth.Rate = 3;
                        synth.Speak(lbP1.Text + " venceu!!!");
                        conta++;
                    }

                    if (p1 > 0 && contador == 0)
                    {
                        sets1++;
                        txSet1 = sets1.ToString();
                        SetsP1.Text = sets1.ToString();
                        contador++;
                    }

                    if (txSet1 == cbSets.Text && fim == 0)
                    {
                        final();
                    }
                }

                if (p1 == 110 || p2 == 110)
                {
                    SpeechSynthesizer synth = new SpeechSynthesizer();
                    synth.SetOutputToDefaultAudioDevice();
                    synth.Volume = 100;
                    synth.Rate = 2;
                    synth.Speak("Calma aí amigão, o jogo já acabou...");
                }
            }

            if (e.KeyChar == (char)Keys.S)
            {
                p2++;
                s++;
                Saque();
                Convert();
                Score2.Text = pl2;
                VaiA2();

                if (p1 == 7 & p2 == 5 & pb1.Visible == true || p2 == 7 & p1 == 5 & pb2.Visible == true)
                {
                    SpeechSynthesizer synth = new SpeechSynthesizer();
                    synth.SetOutputToDefaultAudioDevice();
                    synth.Volume = 100;
                    synth.Rate = 3;
                    synth.Speak("Sete a cin, COCAAADA!");
                }

                if (p2 >= 11 && p1 <= p2 - 2)
                {
                    if (br == 1)
                    {
                        messageWin.Text = lbP2.Text + " venceu!!!";
                    }
                    else
                    {
                        messageWin.Text = lbP2.Text + " Wins!!!";
                    }
                    while (conta <= 0)
                    {
                        SpeechSynthesizer synth = new SpeechSynthesizer();

                        synth.SetOutputToDefaultAudioDevice();
                        synth.Volume = 100;
                        synth.Rate = 3;
                        synth.Speak(lbP2.Text + " venceu!!!");
                        conta++;
                    }

                    if (p2 > 0 && contador == 0)
                    {
                        sets2++;
                        txSet2 = sets2.ToString();
                        SetsP2.Text = sets2.ToString();
                        contador++;
                    }

                    if (txSet2 == cbSets.Text && fim == 0)
                    {
                        final();
                    }
                }

                if (p1 == 110 || p2 == 110)
                {
                    SpeechSynthesizer synth = new SpeechSynthesizer();
                    synth.SetOutputToDefaultAudioDevice();
                    synth.Volume = 100;
                    synth.Rate = 2;
                    synth.Speak("Calma aí amigão, o jogo já acabou...");
                }
            }
        }

        private void English_Click(object sender, EventArgs e)
        {
            br = 0;
            usa++;
            lbTitle.Text = "Table Tennis Scoreboard";
            lbServe.Text = "Serve";
            lbA.Text = "Press A";
            lbS.Text = "Press S";
            btnZero.Text = "Zero Score";
            lbDevBy.Text = "Developed by: Micael Miranda Inácio - 2020";
            lbVaiA2.Text = "Wins with two advantage";
            
        }

        private void Brasil_Click(object sender, EventArgs e)
        {
            usa = 0;
            br++;
            lbTitle.Text = "Placar de Tênis de Mesa";
            lbServe.Text = "Saque";
            lbA.Text = "Pressione A";
            lbS.Text = "Pressione S";
            btnZero.Text = "Zerar Placar";
            lbDevBy.Text = "Desenvolvido por: Micael Miranda Inácio - 2020";
            lbVaiA2.Text = "Vence com dois de vantagem";
            
        }

        private void btnLess1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Teclas(e);
        }

        private void btnChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            Teclas(e);
        }

        private void btnLess2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Teclas(e);
        }

        private void btnZero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Teclas(e);
        }

        private void Scores_KeyPress(object sender, KeyPressEventArgs e)
        {
            Teclas(e);
        }

        private void btnOK_KeyPress(object sender, KeyPressEventArgs e)
        {
            Teclas(e);
        }

    }
}


