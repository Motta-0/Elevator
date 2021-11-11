using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
    public partial class Form1 : Form
    {
        Image closeImage = null;
        Image openImage = null;

        int[] Chamar_Interno = new int[6];
        int[] Chamar_Subir = new int[6];
        int[] Chamar_Descer = new int[6];
        String[] Terreo = new string[6];

        public Form1()
        {
            InitializeComponent();

            //Controle interno do elevador
            INTERNO.RowTemplate.Height = 40;
            INTERNO.Rows.Add(6);
            for (int i=0; i<6; i++)
            {
                INTERNO[0, i].Value = string.Format("{0}", 6 - i);
            }

            //Elevador em si, andares
            ELEVADOR.RowTemplate.Height = 40;
            ELEVADOR.Rows.Add(6);

            //Botões externos SUBIDA
            SOBE.RowTemplate.Height = 40;
            SOBE.Rows.Add(6);
            for (int i = 0; i < 6; i++)
            {
                SOBE[0, i].Value = string.Format("{0}", 6 - i);
            }
            SOBE.Rows[0].Visible = false;

            //Botões externos DESCIDA
            DESCE.RowTemplate.Height = 40;
            DESCE.Rows.Add(6);
            for (int i = 0; i < 5; i++)
            {
                DESCE[0, i].Value = string.Format("{0}", 6 - i);
            }
            DESCE.Rows[5].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* TENTATIVA DE COLOCAR UMA IMAGEM NO ELEVADOR
             
            closeImage = new Bitmap("fechado.gif");
            openImage = new Bitmap("aberto.gif");
            DataGridViewImageColumn imageColumn1 = (DataGridViewImageColumn)ELEVADOR.Columns["Column1"];
            imageColumn1.DefaultCellStyle.NullValue = null;
            ELEVADOR[0, 5].Value = closeImage;
            */

            INTERVALO.Interval = 500;       //SETANDO O TEMPO DE ESPERA
            INTERVALO.Start();

            //zerando os botões
            for(int i=0; i<6;i++)
            {
                Chamar_Interno[i] = 0;
                Chamar_Subir[i] = 0;
                Chamar_Descer[i] = 0;
            }
        }

        private void INTERNO_SelectionChanged(object sender, EventArgs e)
        {
            INTERNO.Rows[INTERNO.CurrentCell.RowIndex].Selected = false;
        }

        private void ELEVADOR_SelectionChanged(object sender, EventArgs e)
        {
            ELEVADOR.Rows[ELEVADOR.CurrentCell.RowIndex].Selected = false;
        }

        private void SOBE_SelectionChanged(object sender, EventArgs e)
        {
            SOBE.Rows[SOBE.CurrentCell.RowIndex].Selected = false;
        }

        private void DESCE_SelectionChanged(object sender, EventArgs e)
        {
            DESCE.Rows[DESCE.CurrentCell.RowIndex].Selected = false;
        }

        private void INTERVALO_Tick(object sender, EventArgs e)
        {

        }

        //definindo o chamar do botão internamente
        private void INTERNO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = INTERNO.CurrentRow.Index;
            Chamar_Interno[5 - row] = 5 - row + 1;
            string str = String.Format("INTERNO Click{0}", Terreo[5 - row]);
            INTERNO.Rows[row].DefaultCellStyle.BackColor = Color.BlueViolet;
            MessageBox.Show(str);
            INTERNO.Rows[row].DefaultCellStyle.BackColor = Color.White;
        }

        //definindo o botão de subida externo
        private void SOBE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = SOBE.CurrentRow.Index;
            Chamar_Subir[5 - row] = 5 - row + 1;
            string str = String.Format("Chamar Subir {0}", Terreo[5 - row]);
            SOBE.Rows[row].DefaultCellStyle.BackColor = Color.LightGreen;
            MessageBox.Show(str);
            SOBE.Rows[row].DefaultCellStyle.BackColor = Color.White;
        }

        //definindo o botão de descida externo
        private void DESCE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = DESCE.CurrentRow.Index;
            Chamar_Descer[5 - row] = 5 - row + 1;
            string str = String.Format("Chamar Descer {0}", Terreo[5 - row]);
            DESCE.Rows[row].DefaultCellStyle.BackColor = Color.LightGreen;
            MessageBox.Show(str);
            DESCE.Rows[row].DefaultCellStyle.BackColor = Color.White;
        }
    }
}
