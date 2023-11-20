using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TorreHanoi
{
    public partial class Hanoi : Form
    {
        private int numDiscos ;
        private int TorreInicial;
        private int TorreAuxiliar;
        private int TorreFinal;
        private List<Panel> torresVisuales;
        private List<Stack<int>> torres;
        private List<Button> discos;
        private string inicioText = "Torre inicial";
        private string finalText = "Torre final";
        
        public Hanoi()
        {InitializeComponent();IniciarTorresVisuales();MostrarTorresVisuales();}
        
        private void IniciarTorres()
        {
            torres = new List<Stack<int>>();
            for (int i = 0; i < 3 ; i++)
            {
                torres.Add(new Stack<int>());
            }
            for (int i = numDiscos; i > 0 ; i--)
            {
                torres[TorreInicial].Push(i);
            }
        }
        private void IniciarDiscos()
        {
            Random rand = new Random();
            discos = new List<Button>(); 
            for (int i = 0; i < numDiscos; i++)
            {
                Button disco = new Button();             
                disco.Width = (i + 1) * 30 + 8;
                disco.FlatStyle = FlatStyle.Flat; 
                Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));                
                disco.BackColor = randomColor; 
                discos.Add(disco);
            }
        }
        private void MostrarDiscos()
        {            
            for (int i = 0; i < torres.Count; i++)
            {
                int j = 0;
                Stack<int> torreActual = new Stack<int>(torres[i]);
                foreach (int discoSize in torreActual)
                {
                    int x = i * 325 + (190 - discos[discoSize - 1].Width) / 2;
                    int y = 345 - (j + 1) * 20;
                    discos[discoSize - 1].Location = new Point(x, y);
                    Controls.Add(discos[discoSize - 1]);
                    j++;
                }
            }
            foreach (Button disco in discos)
            {
                disco.BringToFront();
            }
        }
        private void MoverDisco(int origen, int destino)
        {
            int disco = torres[origen].Pop();
            torres[destino].Push(disco);
        }
        private void ResolverHanoi(int n, int origen, int destino, int auxiliar)
        {
            if (n > 0)
            {
                ResolverHanoi(n - 1, origen, auxiliar, destino);
                MoverDisco(origen, destino);
                MostrarDiscos();
                Application.DoEvents();
                System.Threading.Thread.Sleep(400); 
                ResolverHanoi(n - 1, auxiliar, destino, origen);
            }
        }        
        private void btnResolver_Click_1(object sender, EventArgs e)
        {
            if (torres == null || torres[TorreInicial].Count == 0)
            {
                MessageBox.Show("No hay torres o ya se ha resuelto.");
            }            
            else 
            {
                ResolverHanoi(numDiscos, TorreInicial, TorreFinal, TorreAuxiliar);
                label1.Visible = true;
            }
        }       
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (comboFinal.SelectedItem == null || comboInicio.SelectedItem == null || comboNumDiscos.SelectedItem == null)
            {
                MessageBox.Show("Selección de torres o discos no válida");
            }
            else
            {
                if (int.TryParse(comboFinal.SelectedItem.ToString(), out TorreFinal) &&
                    int.TryParse(comboInicio.SelectedItem.ToString(), out TorreInicial) &&
                    int.TryParse(comboNumDiscos.SelectedItem.ToString(), out numDiscos))
                {
                    if (TorreFinal < 1 || TorreFinal > 3 || TorreInicial < 1 || TorreInicial > 3 || TorreFinal == TorreInicial)
                    {
                        MessageBox.Show("Selección de torres no válida");
                        return;
                    }
                    if (numDiscos < 3 || numDiscos > 5 )
                    {
                        MessageBox.Show("Cantidad de discos no válida. Debe ser entre 3 y 5.");
                        return;
                    }
                    TorreFinal--;
                    TorreInicial--;
                    TorreAuxiliar = Enumerable.Range(0, 3).Except(new[] { TorreInicial, TorreFinal }).Single();
                    if (torres == null)
                    {
                        IniciarTorres();
                        IniciarDiscos();                        
                        MostrarDiscos();                        
                    }
                    else
                    {
                        MessageBox.Show("Ya hay torre");
                    }
                }
                else
                {
                    MessageBox.Show("La conversión no es válida. Asegúrate de que los elementos en los ComboBox sean números.");
                }
            }
        }
        private void LimpiarPantalla()
        {
            foreach (var disco in discos)
            {
                Controls.Remove(disco);
            }
            discos.Clear();
            torres = null;
            comboInicio.SelectedItem = null;
            comboFinal.SelectedItem = null;
            comboInicio.Text = inicioText; comboFinal.Text = finalText;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (torres == null)
            {
                MessageBox.Show("No hay nada para reiniciar.");
            }
            else
            {
                LimpiarPantalla();
                label1.Visible = false;
            }
        }        
        private void IniciarTorresVisuales()
        {
            torresVisuales = new List<Panel>();
            for (int i = 0; i < 3; i++)
            {
                Panel torreVisual = new Panel();
                torreVisual.BackColor = Color.Black;
                torreVisual.Width = 10;torreVisual.Height = 120; 
                int x = (i * 325) + 90;int y = 228; 
                torreVisual.Location = new Point(x, y);
                torresVisuales.Add(torreVisual);
                Controls.Add(torreVisual);
            }
        }
        private void MostrarTorresVisuales()
        {
            foreach (var torreVisual in torresVisuales)
            {
                torreVisual.BringToFront();
            }
        }
        private void comboNumDiscos_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void comboFinal_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void Hanoi_Load(object sender, EventArgs e)
        { }
        private void btnResolver_Click(object sender, EventArgs e)
        { }
    }
}
