using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Deployment.Application;
using MaterialSkin;

namespace BIBLIOTECA
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        List<LIBRO> Planilla;
        List<TESIS> PlanillaTesis;
        List<ESTUDIANTE> PlanillaEstudiante;


        public Form1()
        {
            InitializeComponent();
            Planilla = new List<LIBRO>();
            PlanillaEstudiante = new List<ESTUDIANTE>();
            PlanillaTesis = new List<TESIS>();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue900, Accent.Blue700, TextShade.WHITE);
            

            CargaInicial();
            PanelBloqueado1();
            PanelBloqueado2();
            PanelBloqueado3();
            PanelBloqueado4();
            PanelBloqueado5();
            PanelBloqueado6();

        }

        public void CargaInicial()
        {

            LIBRO B1 = new LIBRO();
            B1.Titulo = "Batman NEW 52";
            B1.Autor = "Stan Lee";
            B1.Cantidad = 1;
            B1.ISBN = "123";
            B1.Editorial = "OvniPress";
            B1.Year = 2011;
            B1.Prestado = false;
            Planilla.Add(B1);

            LIBRO B2 = new LIBRO();
            B2.Titulo = "Wonder Woman NEW 52";
            B2.Autor = "Scott Snyder";
            B2.Cantidad = 1;
            B2.ISBN = "1234";
            B2.Editorial = "OvniPress";
            B2.Year = 2011;
            B2.Prestado = false;
            Planilla.Add(B2);

            LIBRO B3 = new LIBRO();
            B3.Titulo = "Robin NEW 52";
            B3.Autor = "Kevin Fiege";
            B3.Cantidad = 1;
            B3.ISBN = "12345";
            B3.Editorial = "OvniPress";
            B3.Year = 2011;
            B3.Prestado = false;
            Planilla.Add(B3);

            LIBRO B4 = new LIBRO();
            B4.Titulo = "Superman NEW 52";
            B4.Autor = "Stan Lee";
            B4.Cantidad = 1;
            B4.ISBN = "123456";
            B4.Editorial = "OvniPress";
            B4.Year = 2011;
            B4.Prestado = false;
            Planilla.Add(B4);

            LIBRO B5 = new LIBRO();
            B5.Titulo = "Batgirl NEW 52";
            B5.Autor = "Scott Snyder";
            B5.Cantidad = 1;
            B5.ISBN = "1234567";
            B5.Editorial = "OvniPress";
            B5.Year = 2011;
            B5.Prestado = false;
            Planilla.Add(B5);

            LIBRO B6 = new LIBRO();
            B6.Titulo = "Justice League NEW 52";
            B6.Autor = "Kevin Fiege";
            B6.Cantidad = 1;
            B6.ISBN = "12345678";
            B6.Editorial = "OvniPress";
            B6.Year = 2011;
            B6.Prestado = false;
            Planilla.Add(B6);

            TESIS T1 = new TESIS();
            T1.Titulo = "Suma y Resta";
            T1.Autor = "Adan D'Lima";
            T1.Asesor = "Claudio Cortinez";
            T1.Carrera = "Sistemas";
            T1.Year = 2024;
            PlanillaTesis.Add(T1);


            TESIS T2 = new TESIS();
            T2.Titulo = "Multiplicacion y Division";
            T2.Autor = "Adan D'Lima";
            T2.Asesor = "Claudio Cortinez";
            T2.Carrera = "Sistemas";
            T2.Year = 2024;
            PlanillaTesis.Add(T2);


            TESIS T3 = new TESIS();
            T3.Titulo = "Integrales";
            T3.Autor = "Jonathan Rojas";
            T3.Asesor = "Alejandro Perez";
            T3.Carrera = "Industrial";
            T3.Year = 2024;
            PlanillaTesis.Add(T3);


            TESIS T4 = new TESIS();
            T4.Titulo = "Cemento";
            T4.Autor = "Pedro Lugo";
            T4.Asesor = "Santiago Aparcedo";
            T4.Carrera = "Civil";
            T4.Year = 2024;
            PlanillaTesis.Add(T4);


            TESIS T5 = new TESIS();
            T5.Titulo = "Dientes";
            T5.Autor = "Luis Alvarez";
            T5.Asesor = "Jose Flores";
            T5.Carrera = "Odontologia";
            T5.Year = 2024;
            PlanillaTesis.Add(T5);


            TESIS T6 = new TESIS();
            T6.Titulo = "Hamburguesa";
            T6.Autor = "Bob Jhones";
            T6.Asesor = "Nick Quinn";
            T6.Carrera = "Cocina";
            T6.Year = 2024;
            PlanillaTesis.Add(T6);

            CargarPlanillaTesis();
            CargarPlanilla();

        }

        public void ClearTextBox()
        {

            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox7.Text = string.Empty;

        }


   
        ////////////////////////// Funciones Relacionadas a Libros, Trate de ponerlas en la clase Libro para trabajar mas enfocado a objetos pero me confundi todo, eso es duda para el siguiente proyecto ////////////////


        public void AddBooks()
        {
            bool p = false;

            for (int i=0; i<Planilla.Count; i++) 
            {
                if (Planilla[i].ISBN == textBox11.Text) { p = true;}          
            }

            bool A = false;
            var indice = 0;

            for (int i = 0; i < Planilla.Count; i++)
            {
                if (Planilla[i].Titulo == textBox2.Text && Planilla[i].Autor == textBox3.Text && Planilla[i].Editorial == textBox9.Text && Planilla[i].Year == Convert.ToInt32(textBox7.Text)) 
                { 
                    A = true;
                    indice = Planilla.FindIndex(LIBRO => LIBRO.Titulo.Equals(textBox2.Text));
                }

            }

            if (p==false) 
            {

                if (A == true) 
                {

                    Planilla[indice].Cantidad++;

                }
                
                 LIBRO L1 = new LIBRO();
                 L1.Titulo = textBox2.Text;
                 L1.Autor = textBox3.Text;
                 L1.Cantidad = L1.Cantidad + 1;
                 L1.ISBN = textBox11.Text;
                 L1.Editorial = textBox9.Text;
                 L1.Year = Convert.ToInt32(textBox7.Text);
                 L1.Prestado = false;
                 Planilla.Add(L1);

                for (int i = 0; i < Planilla.Count; i++)
                {
                    if (Planilla[i].Titulo == textBox2.Text) { Planilla[i].Cantidad = Planilla[indice].Cantidad; }
                }

                CargarPlanilla();        

            }
            else { MessageBox.Show("No existen 2 libros con el mismo ISBN"); }

        }

        private void CargarPlanilla()
        {
            dataGridView1.DataSource = null;

            if (materialRadioButton1.Checked == true) 
            {
                dataGridView1.DataSource = Planilla;
            }
            

        }

        private void CargarPlanilla2()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = PlanillaEstudiante;
        }

        public void BuscarLibros()
        {
            List<LIBRO> PlanillaFiltrada;

            var FilteredUsers = Planilla.Where(LIBRO => LIBRO.Autor.StartsWith(textBox13.Text));

            PlanillaFiltrada = FilteredUsers.ToList();

            if (materialRadioButton1.Checked == true)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = PlanillaFiltrada;
            }

        }

        public void ModificarPlanilla() 
        {

            bool E = false;

            for (int i = 0; i < Planilla.Count; i++)
            {

                if (Planilla[i].ISBN== textBox18.Text) { E = true; break; }

            }

            if (E == true)
            {

                var indice = Planilla.FindIndex(LIBRO => LIBRO.ISBN.Equals(textBox18.Text));

                LIBRO L2 = new LIBRO();
                L2.Titulo = textBox29.Text;
                L2.Autor = textBox27.Text;
                L2.Cantidad = L2.Cantidad + 1;
                L2.ISBN = Planilla[indice].ISBN;
                L2.Editorial = textBox21.Text;
                L2.Year = Convert.ToInt32(textBox19.Text);
                L2.Prestado = false;

                Planilla.RemoveAt(indice);
                Planilla.Insert(indice, L2);

                CargarPlanilla();

            }
            else { MessageBox.Show("Error, no puedes modificar un Item Inexistente"); }

        }

        public void EliminarPorISBN()
        {

            bool E = false;

            for (int i = 0; i < Planilla.Count; i++)
            {

                if (Planilla[i].ISBN == textBox16.Text) { E = true; break; }

            }


            if (E == true)
            {

                Planilla.RemoveAll(LIBRO => LIBRO.ISBN.Equals(textBox16.Text));
                CargarPlanilla();

            }
            else { MessageBox.Show("Erorr, no puedes borrar un item que no existe"); }

        }

        public void Prestamo() 
        {
                bool P = false;
                bool E = true;

                var indice = Planilla.FindIndex(LIBRO => LIBRO.ISBN.Equals(textBox24.Text));

                if (indice != -1)  { Planilla[indice].Prestado = true; }

                CargarPlanilla();

                ESTUDIANTE E1 = new ESTUDIANTE();

                E1.Name = textBox35.Text;
                E1.ID = textBox33.Text;         
                E1.ISBNprestado = textBox24.Text;

                var Existe = Planilla.FindIndex(LIBRO => LIBRO.ISBN.Equals(textBox24.Text));

                if (Existe == -1) { E = false; }

            if (indice != -1) { E1.LibroPrestado = Planilla[indice].Titulo; }

                for (int i = 0; i < PlanillaEstudiante.Count; i++)
                {

                    if (PlanillaEstudiante[i].ISBNprestado == textBox24.Text){ P = true;}                   

                }

                if (P==false) 
                {
                    if (E == true)
                    {

                        PlanillaEstudiante.Add(E1);

                        var Stu = PlanillaEstudiante.FindIndex(ESTUDIANTE => ESTUDIANTE.ID.Equals(textBox33.Text));
                        var Sti = PlanillaEstudiante.FindIndex(ESTUDIANTE => ESTUDIANTE.ISBNprestado.Equals(textBox24.Text));

                        if (PlanillaEstudiante[Stu].ContadorLibros < 3 && Stu != -1)
                        {

                            if (PlanillaEstudiante[Stu].ID == E1.ID)
                            {
                                PlanillaEstudiante[Stu].ContadorLibros++;

                                for (int i = 0; i < PlanillaEstudiante.Count; i++)
                                {
                                    if (PlanillaEstudiante[i].ID == textBox33.Text) { PlanillaEstudiante[i].ContadorLibros = PlanillaEstudiante[Stu].ContadorLibros; }
                                }
                            }
                        }
                        else { MessageBox.Show("Cantidad Maxima de Libros prestados por usuario alcanzada"); PlanillaEstudiante.RemoveAt(PlanillaEstudiante.Count - 1); }


                    }   
                    else { MessageBox.Show("No hay libros con el ISBN : " + textBox24.Text + " en inventario"); }

            }
                else {MessageBox.Show("No existen 2 libros con el mismo ISBN");}

            CargarPlanilla2();

        }

        public void Retorno()
        {

           bool E = false;

            for (int i = 0; i<PlanillaEstudiante.Count; i++) 
            {

                if (PlanillaEstudiante[i].ISBNprestado == textBox40.Text) { E = true; break; }                     
            
            }

            if (E == true)
            {

                var indice = Planilla.FindIndex(LIBRO => LIBRO.ISBN.Equals(textBox40.Text));
                Planilla[indice].Prestado = false;

                CargarPlanilla();

                var Stu = PlanillaEstudiante.FindIndex(ESTUDIANTE => ESTUDIANTE.ISBNprestado.Equals(textBox40.Text));
                var Sti = PlanillaEstudiante.FindIndex(ESTUDIANTE => ESTUDIANTE.ID.Equals(textBox5.Text));

                if (PlanillaEstudiante[Sti].ContadorLibros > 0) { PlanillaEstudiante[Sti].ContadorLibros = PlanillaEstudiante[Sti].ContadorLibros - 1; }

                for (int i = 0; i < PlanillaEstudiante.Count; i++)
                {
                    if (PlanillaEstudiante[i].ID == textBox33.Text)
                    { PlanillaEstudiante[i].ContadorLibros = PlanillaEstudiante[Stu].ContadorLibros; }
                }

                PlanillaEstudiante.RemoveAt(Stu);

                CargarPlanilla();
                CargarPlanilla2();

            }
            else { MessageBox.Show("Error, no puedes devolver algo que no posees"); }
        }


        /////////////////////////////////////////////////////////////////////////////////////////////// Funciones de accion del Forms //////////////////////////////////////////////////////////////////////////////////////

        private void button3_Click(object sender, EventArgs e)
        {
            AddBooks();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

            BuscarLibros();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Retorno();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            EliminarPorISBN();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarPlanilla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Prestamo();
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CargarPlanillaTesis();
            panel8.Enabled = false;
            panel6.Visible = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            dataGridView2.Enabled = false;
            panel4.Visible = false;
            textBox13.Visible = false;
            textBox47.Visible = true;
            textBox26.Visible = true;
            textBox25.Visible = true;
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CargarPlanilla();
            panel8.Enabled = true;
            panel6.Visible = true;
            panel1.Enabled = true;
            panel2.Enabled = true;
            dataGridView2.Enabled = true;
            panel4.Visible = true;
            textBox13.Visible = true;
            textBox47.Visible = false;
            textBox26.Visible = false;
            textBox25.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddTesis();
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            BuscarTesis();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModificarPlanillaTesis();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            BuscarTesisAsesor();
        }

        //////////////////////////////////////////////////////////////////////////////// Funciones Relacionadas a Tesis, lo mismo que con los Libros /////////////////////////////////////////////////////////////////////////


        public void AddTesis()
        {
            bool X = false;

            for (int i = 0; i<PlanillaTesis.Count; i++)
            {
                if (PlanillaTesis[i].Titulo == textBox32.Text) { X = true; }
       
            }

            if (X == false)
            {

                TESIS T1 = new TESIS();
                T1.Titulo = textBox32.Text;
                T1.Autor = textBox38.Text;
                T1.Asesor = textBox42.Text;
                T1.Carrera = textBox44.Text;
                T1.Year = Convert.ToInt32(textBox46.Text);
                PlanillaTesis.Add(T1);

                CargarPlanillaTesis();

            }
            else { MessageBox.Show("Ya existe una Tesis con ese Nombre en sistema");} 

        }

        public void CargarPlanillaTesis()
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = PlanillaTesis;

        }

        public void BuscarTesis()
        {
            List<TESIS> PlanillaFiltradaTesis;

            var FilteredUsersTesis = PlanillaTesis.Where(TESIS => TESIS.Autor.StartsWith(textBox47.Text));

            PlanillaFiltradaTesis = FilteredUsersTesis.ToList();

            if (materialRadioButton2.Checked == true)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = PlanillaFiltradaTesis;
            }

        }

        public void BuscarTesisAsesor()
        {
            List<TESIS> PlanillaFiltradaTesis;

            var FilteredUsersTesis = PlanillaTesis.Where(TESIS => TESIS.Asesor.StartsWith(textBox26.Text));

            PlanillaFiltradaTesis = FilteredUsersTesis.ToList();

            if (materialRadioButton2.Checked == true)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = PlanillaFiltradaTesis;
            }

        }

        public void ModificarPlanillaTesis()
        {

            bool E = false;

            for (int i = 0; i < PlanillaTesis.Count; i++)
            {

                if (PlanillaTesis[i].Titulo == textBox50.Text) { E = true; break; }

            }

            if (E == true)
            {

                var indice = PlanillaTesis.FindIndex(TESIS=> TESIS.Titulo.Equals(textBox50.Text));

                TESIS T2 = new TESIS();
                T2.Titulo = textBox55.Text;
                T2.Autor = textBox56.Text;
                T2.Asesor = textBox52.Text;
                T2.Carrera = textBox58.Text;
                T2.Year = Convert.ToInt32(textBox49.Text);

                PlanillaTesis.RemoveAt(indice);
                PlanillaTesis.Insert(indice, T2);

                CargarPlanillaTesis();

            }
            else { MessageBox.Show("Error, no puedes modificar un Item Inexistente"); }

        }


        //////////////////////////////////////////////////////////////////////////////////////////////////// Bloquear Botones/////////////////////////////////////////////////////////////////////////////////////////////////

        public void PanelBloqueado1()
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox11.Text != "" && textBox9.Text != "" && textBox7.Text != "")
            {

                button3.Enabled = true;

            }
            else { button3.Enabled = false; }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado1();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado1();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado1();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado1();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            PanelBloqueado1();
        }

        public void PanelBloqueado2()
        {
            if (textBox32.Text != "" && textBox38.Text != "" && textBox42.Text != "" && textBox44.Text != "" && textBox46.Text != "")
            {

                button6.Enabled = true;

            }
            else { button6.Enabled = false; }

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado2();
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado2();
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado2();
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado2();
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado2();
        }

        public void PanelBloqueado3()
        {
            if (textBox50.Text != "" && textBox55.Text != "" && textBox56.Text != "" && textBox52.Text != "" && textBox58.Text != "" && textBox49.Text != "")
            {

                button7.Enabled = true;

            }
            else { button7.Enabled = false; }

        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado3();
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado3();
        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado3();
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado3();
        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado3();
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado3();
        }

        public void PanelBloqueado4()
        {
            if (textBox24.Text != "" && textBox35.Text != "" && textBox33.Text != "")
            {

                button4.Enabled = true;

            }
            else { button4.Enabled = false; }

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado4();
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado4();
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado4();
        }

        public void PanelBloqueado5()
        {
            if (textBox40.Text != "" && textBox5.Text != "")
            {

                button5.Enabled = true;

            }
            else { button5.Enabled = false; }

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado5();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado5();
        }

        public void PanelBloqueado6()
        {
            if (textBox18.Text != "" && textBox29.Text != "" && textBox27.Text != "" && textBox21.Text != "" && textBox19.Text != "")
            {

                button2.Enabled = true;

            }
            else { button2.Enabled = false; }

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado6();
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado6();
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado6();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado6();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            PanelBloqueado6();
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Para representar un year solo necesitaas numeros");
                e.Handled = true;

            }

        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Para representar un year solo necesitaas numeros");
                e.Handled = true;

            }
        }

        private void textBox46_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Para representar un year solo necesitaas numeros");
                e.Handled = true;

            }
        }

        private void textBox49_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Para representar un year solo necesitaas numeros");
                e.Handled = true;

            }
        }

    }
}
