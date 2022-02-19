using Newtonsoft.Json;
using ProyectoN1.Clases;

namespace ProyectoN1
{
    public partial class Form1 : Form
    {
        //Variable Global
        String[,] equipos;
        String[,] equiposOrdenados;
        

        //Encabezados de Columnas
        private int posicion = 0;
        private int nombreClub = 1;
        private int jugados = 2;
        private int puntos = 3;
        private int ganados=4;
        private int empates=5;
        private int perdidos=6;
        private int golesFavor=7;
        private int golesContra=8;
        private int diferenciaGoles =9;

        String path = "C:\\Tareas\\ProyectoN1\\Resultados.json";

        //Metodo de Lanzamiento deL Formulario
        public Form1()
        {
            //Lineas De Codigo Encargadas de Subir la Info         
            String descarga = File.ReadAllText(path);
            equipos = JsonConvert.DeserializeObject<String[,]>(descarga);
            InitializeComponent();
           
        }
     
        //Metodo Encargado de Cargar la Tabla
        public void CargarTabla(String[,] clubs)
        {
           
            
            for(int i = 0; i < clubs.GetLength(0); i++)
            {
                Tabla.Rows.Add(clubs[i, posicion], clubs[i, nombreClub], clubs[i, jugados], clubs[i, puntos], 
                clubs[i, ganados], clubs[i, empates], clubs[i, perdidos], clubs[i, golesFavor], 
                clubs[i, golesContra], clubs[i, diferenciaGoles]);                    
            }   
        }
        
        //Metodo Encargado de Limpiar Tabla
        public void LimpiarTabla()
        {
            Tabla.Rows.Clear();
        }

        //Boton-Evento Encargado de Cargar la informacion al Combobox
        private void BtnCargarEquipos_Click(object sender, EventArgs e)
        {
            //Carga la Informacion de la Matriz en los Combobox
            for (int i = 0; i < equipos.GetLength(0); i++)
            { 
                combo1.Items.Add(equipos[i, nombreClub]); 
                combo2.Items.Add(equipos[i, nombreClub]); 
            }
            CargarTabla(equipos);
            //Muestra y Desactiva
            BtnCargarEquipos.Enabled = false;
            combo1.Enabled = true;
            combo2.Enabled = true;
            txtcombo1.Enabled = true;
            txtcombo2.Enabled = true;
            BtnResultado.Enabled = true;

        }

        //Boton-Evento Encargado de Agregar Puntos y Goles
        private void BtnResultado_Click(object sender, EventArgs e)
        {
            String equipoLocal = "", equipoVisita = "";
            int resultadoLocal=0, resultadoVisita=0; 

            equipoLocal= Convert.ToString(combo1.SelectedItem);
            equipoVisita= Convert.ToString(combo2.SelectedItem);
            resultadoLocal =Convert.ToInt32(txtcombo1.Text);
            resultadoVisita = Convert.ToInt32(txtcombo2.Text);

            //If de error
            if (equipoLocal.Equals(equipoVisita))
            {
                MessageBox.Show("Seleccionaste el Mismo Equipo - ERROR");
            }

            //If si el Equipo Local Gana
            else if(resultadoLocal > resultadoVisita)
            {
               for(int i = 0;i < equipos.GetLength(0); i++)
                {
                    if (equipoLocal.Equals(equipos[i, nombreClub]))
                    {
                        equipos[i,jugados]=(Convert.ToInt32(equipos[i, jugados]) + 1)+"";
                        equipos[i, puntos] = (Convert.ToInt32(equipos[i, puntos]) + 3) + "";
                        equipos[i, ganados] = (Convert.ToInt32(equipos[i, ganados]) + 1) + "";
                        equipos[i, golesFavor] = (Convert.ToInt32(equipos[i, golesFavor]) + resultadoLocal) + "";
                        equipos[i, golesContra] = (Convert.ToInt32(equipos[i, golesContra]) + resultadoVisita)+"";
                        equipos[i, diferenciaGoles] = (Convert.ToInt32(equipos[i, golesFavor]) - Convert.ToInt32(equipos[i, golesContra])) + "";
                    }
                    else if (equipoVisita.Equals(equipos[i, nombreClub]))
                    {
                        equipos[i, jugados] = (Convert.ToInt32(equipos[i, jugados]) + 1) + "";
                        equipos[i, perdidos] = (Convert.ToInt32(equipos[i, perdidos]) + 1) + "";
                        equipos[i,golesFavor] = (Convert.ToInt32(equipos[i, golesFavor]) + resultadoVisita) + "";
                        equipos[i, golesContra] = (Convert.ToInt32(equipos[i, golesContra]) + resultadoLocal) + "";
                        equipos[i, diferenciaGoles] = (Convert.ToInt32(equipos[i, golesFavor]) - Convert.ToInt32(equipos[i, golesContra])) + "";
                    }
                }
            }

            //If si el Equipo Visita Gana
            else if (resultadoLocal < resultadoVisita)
            {
                for(int i = 0; i < equipos.GetLength(0); i++)
                {
                    if (equipoVisita.Equals(equipos[i, nombreClub]))
                    {
                        equipos[i, jugados] = (Convert.ToInt32(equipos[i, jugados]) + 1) + "";
                        equipos[i, puntos] = (Convert.ToInt32(equipos[i, puntos]) + 3) + "";
                        equipos[i, ganados] = (Convert.ToInt32(equipos[i, ganados]) + 1) + "";
                        equipos[i, golesFavor] = (Convert.ToInt32(equipos[i, golesFavor]) + resultadoVisita) + "";
                        equipos[i, golesContra] = (Convert.ToInt32(equipos[i, golesContra]) + resultadoLocal) + "";
                        equipos[i, diferenciaGoles] = (Convert.ToInt32(equipos[i, golesFavor]) - Convert.ToInt32(equipos[i, golesContra])) + "";
                    }
                    else if (equipoLocal.Equals(equipos[i, nombreClub]))
                    {
                        equipos[i, jugados] = (Convert.ToInt32(equipos[i, jugados]) + 1) + "";
                        equipos[i, perdidos] = (Convert.ToInt32(equipos[i, perdidos]) + 1) + "";
                        equipos[i, golesFavor] = (Convert.ToInt32(equipos[i, golesFavor]) + resultadoLocal) + "";
                        equipos[i, golesContra] = (Convert.ToInt32(equipos[i, golesContra]) + resultadoVisita) + "";
                        equipos[i, diferenciaGoles] = (Convert.ToInt32(equipos[i, golesFavor]) - Convert.ToInt32(equipos[i, golesContra])) + "";
                    }
                }
            }

            //If Si hay Empate
            else
            {
                for(int i = 0; i < equipos.GetLength(0); i++)
                {
                    if(equipoLocal.Equals(equipos[i, nombreClub]))
                    {
                        equipos[i, jugados] = (Convert.ToInt32(equipos[i, jugados]) + 1) + "";
                        equipos[i, puntos] = (Convert.ToInt32(equipos[i, puntos]) + 1) + "";
                        equipos[i, empates] = (Convert.ToInt32(equipos[i, empates]) + 1) + "";
                        equipos[i, golesFavor] = (Convert.ToInt32(equipos[i, golesFavor]) + resultadoLocal) + "";
                        equipos[i, golesContra] = (Convert.ToInt32(equipos[i, golesContra]) + resultadoVisita) + "";
                        equipos[i, diferenciaGoles] = (Convert.ToInt32(equipos[i, golesFavor]) - Convert.ToInt32(equipos[i, golesContra])) + "";
                    }
                    else if (equipoVisita.Equals(equipos[i, nombreClub]))
                    {
                        equipos[i, jugados] = (Convert.ToInt32(equipos[i, jugados]) + 1) + "";
                        equipos[i, puntos] = (Convert.ToInt32(equipos[i, puntos]) + 1) + "";
                        equipos[i, empates] = (Convert.ToInt32(equipos[i, empates]) + 1) + "";
                        equipos[i, golesFavor] = (Convert.ToInt32(equipos[i, golesFavor]) + resultadoVisita) + "";
                        equipos[i, golesContra] = (Convert.ToInt32(equipos[i, golesContra]) + resultadoLocal) + "";
                        equipos[i, diferenciaGoles] = (Convert.ToInt32(equipos[i, golesFavor]) - Convert.ToInt32(equipos[i, golesContra])) + "";
                    }
                }
               
            }

            ClsOrdenar ord=new ClsOrdenar();
            equiposOrdenados = ord.ordenar(equipos);
            LimpiarTabla();
            CargarTabla(equiposOrdenados);
            File.Delete(path);
            var carga = JsonConvert.SerializeObject(equiposOrdenados);
            File.WriteAllText(path, carga);
            BtnActualizar.Enabled = true;
        }

        //Boton-Evento Encargado De Actualizar Tabla
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            LimpiarTabla();
            CargarTabla(equiposOrdenados);
        }
    }
}