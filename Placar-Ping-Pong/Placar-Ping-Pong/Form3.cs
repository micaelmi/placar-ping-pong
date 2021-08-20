using MySql.Data.MySqlClient;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DadosTabela();
        }

        private void DadosTabela()
        {
            conexao comb = new conexao();
            comb.sql = "SELECT * FROM tb01_resultados ORDER BY seq DESC";

            comb.open();

            MySqlDataReader dados = comb.Execsql();

            dgLista.Rows.Clear();

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    dgLista.Rows.Add(
                        dados["jogador1"].ToString(),
                        dados["sets1"].ToString(),
                        dados["pontos1"].ToString(),
                        dados["pontos2"].ToString(),
                        dados["sets2"].ToString(),
                        dados["jogador2"].ToString(),
                        dados["data"].ToString());
                }
            }
            comb.close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Scores tela = new Scores();
            tela.Visible = true;
            this.Close();
        }
    }
}
