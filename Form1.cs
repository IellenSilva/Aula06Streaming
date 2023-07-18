using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula06Streaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string titulo = "Sintonia";
            string descricao = " Criados juntos na quebrada de São Paulo, três jovens amigos correm atrás de seus sonhos rodeados por música, drogas e religião.";
            string caminho_imagem = "C:/Users/iellen.sdanaga/source/repos/Aula06Streaming/Aula06Streaming/imagens/Sintonia.jpg";
            string link_Video = "https://www.youtube.com/embed/xsODpM3Rwdg?autoplay=true" ;



            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.caminho_imagem = caminho_imagem;
            telaInfo.link_video = link_Video;
            telaInfo.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           

        }
    }
}
