﻿using System;
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
    public partial class Form1 : System.Windows.Forms.Form
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


      

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


        }

        //======= mover forms

        Point DragCursor;
        Point DragForm;
        bool Dragging;

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
            
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_password_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-UMO23JP;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            string login = "SELECT * FROM CADASTRO WHERE CPF = '" + mtxb_cpf.Text + "'and SENHA ='" + txb_password.Text +"'";
            cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                Form4 frm4 = new Form4();
                frm4.ShowDialog();
            }

            else if (mtxb_cpf.Text == string.Empty && txb_password.Text == string.Empty)
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS PARA FINALIZAR", "MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               
            else
            {
                MessageBox.Show("CPF OU SENHA INVALIDA","MESAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                mtxb_cpf.Text = "";
                txb_password.Text = "";
                mtxb_cpf.Focus();
            }
        }

        private void txb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_password_Click_1(object sender, EventArgs e)
        {
            txb_password.Clear();
            

        }

        private void mtxb_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxb_cpf_Click(object sender, EventArgs e)
        {
            mtxb_cpf.Text = "";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void lbl_cadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm2 = new Form2();
            fm2.ShowDialog();

            Form1 fm1 = new Form1();
            fm1.Closed += (s, agrs) => this.Close();
            fm1.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txb_password.PasswordChar = '\0';
            }

            else
            {
                txb_password.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_trocar_senha_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.ShowDialog();

            Form1 fm1 = new Form1();
            fm1.Closed += (s, agrs) => this.Close();
            fm1.ShowDialog();

        }
    }
}
