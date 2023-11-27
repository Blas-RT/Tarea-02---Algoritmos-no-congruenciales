using Prueba16Nov.Algoritmos;

namespace Prueba16Nov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Paso 0: Condic�on de vac�o
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") || textBox3.Text.Equals("") ||
                textBox4.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VAC�OS");
                return;
            }
            // Paso 1: Inicializaci�n de par�metros
            int x0 = Convert.ToInt32(textBox1.Text);
            int a = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int m = Convert.ToInt32(textBox4.Text);
            int Total = Convert.ToInt32(textBox5.Text);

            // Paso 1.2: Validación algoritmo
            if (x0 < 0 ||
                a <= 0 || c <= 0 ||
                m <= 0)
            {
                MessageBox.Show("Los números tienen que ser MAYORES QUE CERO");
                return;
            }

            
            // Paso 2: Declarar clase algoritmo gen�tico
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            // Paso 3: Llamar m�todo principal
            List<int> listaEnteros = algoritmo.GenerarValoresPseudoaleatoriosCongruenciales(x0, a, c, m, Total);
            // Paso 4: Llenar el grid
            llenarGrid(listaEnteros);
        }
        public void llenarGrid(List<int> lista)
        {
            // Paso 0: Indicas el n�mero de columnas
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";

            // Paso 1: Determinas la cantidad de columnas
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");

            //Paso 2: Recorres el grid para cada fila llenas los valores aleatorios
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
            }

        }

        public void DescargaExcel(DataGridView data)
        {
            // Paso 0: Instalar complemente de exel
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            // Paso 1: Construyes columnas y los nombres de las "cabeceras"
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }
            // Paso 2: Construyes filas y llenas valores
            int indiceFilas = 0;

            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFilas++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFilas + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            // Paso 3: visibilidad
            exportarExcel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DescargaExcel(dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
