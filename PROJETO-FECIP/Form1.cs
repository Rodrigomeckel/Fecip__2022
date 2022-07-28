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

namespace PROJETO_FECIP
{
    public partial class Form1 : Form
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
            Close();
        }

        private void txb_password_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
        }

        private void txb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_password_Click_1(object sender, EventArgs e)
        {
            txb_password.Clear();
            pictureBox3.BackgroundImage = Properties.Resources.cadeado;
            panel5.ForeColor = Color.FromArgb(78, 184, 206);
            txb_password.ForeColor = Color.FromArgb(78, 184, 206);

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
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
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
    }
}
