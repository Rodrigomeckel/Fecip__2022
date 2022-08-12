using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace PROJETO_FECIP
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UMO23JP;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          //======== aredondar borda
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse

      );


        public Form3()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        Point DragCursor;
        Point DragForm;
        bool Dragging;


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-UMO23JP;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            string alterar = "update CADASTRO set SENHA = '" + txb_password.Text+ "'";
            cmd = new SqlCommand(alterar, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("SENHA ALTERADA COM SUCESSO!!", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }

            Form1 fm1 = new Form1();
            fm1.ShowDialog();

            Form3 fm3 = new Form3();
            fm1.Closed += (s, agrs) => this.Close();
            fm1.ShowDialog();

        }

        private void btn_pesquizar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-UMO23JP;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            
            string pesquisar = "SELECT * FROM CADASTRO WHERE CPF = '" + mtxb_alterar_cpf.Text + "'";
            cmd = new SqlCommand(pesquisar, con);

            try
            {
                if (mtxb_alterar_cpf.Text == string.Empty)
                {
                    MessageBox.Show("VOCÊ PRESCISA DIGITAR O CPF !!", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == false)
                {
                    
                    throw new Exception("ESTE CPF NÃO ESTÁ CADASTRADO!!");
                   
                    
                }

                


                dr.Read();

                txb_password.Text = Convert.ToString(dr["SENHA"]);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mtxb_alterar_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void mtxb_alterar_cpf_Click(object sender, EventArgs e)
        {
            mtxb_alterar_cpf.Clear();
        }

        private void txb_password_Click(object sender, EventArgs e)
        {
            txb_password.Clear();
        }
    }
}
