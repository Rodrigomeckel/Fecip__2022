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

namespace PROJETO_FECIP
{
    public partial class Form2 : Form
    {
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

        public Form2()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        //======= mover forms

        Point DragCursor;
        Point DragForm;
        bool Dragging;

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void mtxb_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxb_cpf_Click(object sender, EventArgs e)
        {
          
        }

        private void txb_password_cadastro_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void mtxb_telefone_Click(object sender, EventArgs e)
        {
            mtxb_telefone.Clear();
        }

        private void txb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_username_Click(object sender, EventArgs e)
        {
            txb_username.Clear();
        }

        private void mtxb_cpf_cadastro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxb_cpf_cadastro_Click(object sender, EventArgs e)
        {
            mtxb_cpf_cadastro.Clear();
        }

        private void txb_password_cadastro_Click(object sender, EventArgs e)
        {
            txb_password_cadastro.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txb_password_cadastro.PasswordChar = '\0';
            }

            else
            {
                txb_password_cadastro.PasswordChar = '*';
            }
        }
    }
}
