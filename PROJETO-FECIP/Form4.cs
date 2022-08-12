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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UMO23JP;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

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

        public Form4()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                if (lbl_exibir.Text != "")
                {
                    con.Open();

                    string CADASTRAR = " insert into TOKEN(ARMAZE_COD) values('"+ lbl_exibir.Text+ "')";
                    cmd = new SqlCommand(CADASTRAR, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("TOKEN CRIADO", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }

            


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random Chave = new Random();
            lbl_exibir.Text = Chave.Next(100000).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        Point DragCursor;
        Point DragForm;
        bool Dragging;

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
    }
}
