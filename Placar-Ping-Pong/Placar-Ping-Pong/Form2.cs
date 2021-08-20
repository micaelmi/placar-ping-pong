using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placar_Ping_Pong
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void English_Click(object sender, EventArgs e)
        {
            label1.Text = "Application designed to help players easily count game points." +
                        "\n\n" +
                        "You can count the points with simple clicks or using the capital letters 'A' and 'S' of the keyboard." +
                        " " +
                        "It's possible to change the serves in the button with arrows when you decide who's the serve." +
                        "\n\n" +
                        "There is a voice that speak some things like who won the set and the score if you click in the button '+'." +
                        "\n\n" +
                        "In the botton of the screen, there's a button that clean all, making it possible to play another set." +
                        "\n\n" +
                        "We hope you like it:)";
        }

        private void Brasil_Click(object sender, EventArgs e)
        {
            label1.Text = "Aplicativo desenvolvido para ajudar os jogadores a contar facilmente os pontos do jogo." +
                        "\n\n " +
                " Você pode contar os pontos com cliques simples ou usando as letras maiúsculas 'A' e 'S' do teclado." +
                        "\n\n" +
                " É possível alterar os saques no botão com setas quando você decidir de quem é o saque." +
                        "\n\n" +
                " Existe uma voz que fala algumas coisas como quem ganhou o set e a pontuação se você clicar no botão '+'." +
                        "\n\n" +
                " No fundo da tela, há um botão que limpa tudo, possibilitando jogar outro set." +
                        "\n\n" +
                "Esperamos que você goste :)";

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Scores tela = new Scores();
            tela.Visible = true;
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
