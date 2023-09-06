using EjAlumnos.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjAlumnos.FrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            //Instaciado el objeto objAlumno de la clase Alumno e inicializado dicho objeto
            Alumno oAlumno = new Alumno();

            oAlumno.DNI = txtDNI.Text;
            oAlumno.Nombre = txtNombre.Text;
            oAlumno.Materia = txtMateria.Text;
            oAlumno.Nota = txtNota.Text;

            //objAlumno.DNI = "1587458";

            lblSalida.Text = oAlumno.DNI;
        }
    }
}
