using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UdyatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = @"C:\Temp\sample.py";

            this.Hide();
            Form2 message = new Form2();
            Timer T = new Timer();

            while (!File.Exists(path))
            {
                T.Interval = 10000;
                T.Start();

                //Console.WriteLine("hola");

            }


            if (File.Exists(path))
            {
                run_cmd();
                //Console.WriteLine("Hello world");

                message.Show();

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Metodo que se encarga de ejecutar el python
        private void run_cmd()
        {
            //busca el archivo.py
            string fileName = @"C:\Temp\sample.py";

            //ejecuta el archivo.py usando el ejecuatble de python
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\Adolfo\AppData\Local\Programs\Python\Python36\python.exe", fileName)
            {
                //se usan las siguientes intrucciones para evitar el manejo de expeciones en el uso del ejecutable
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();
            //se empieza el programa con el ejecuatble

            //Se meustra en terminal la salida de python
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
