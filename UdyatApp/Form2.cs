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
using Newtonsoft.Json;


namespace UdyatApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            lbLocation_info.Text = "hola mundo";

            string path = @"C:\\Temp\\info.txt";

            if (File.Exists(path))
            {
                read_file();
            }


        }


        private void read_file(string path)
        {
            var stream = File.OpenText(path);

            string st = stream.ReadToEnd();

        }

 //
 //       //Open the file              
 //       var stream = File.OpenText("json file.txt");
 //       //Read the file              
 //       string st = stream.ReadToEnd();
 //       var jsonArray = JsonArray.Parse(st);              
//foreach (var item in jsonArray)              
//{                                   
//JsonObject ob = new JsonObject(item);                   
//foreach (var t in ob.Values)                  
//{                       
//JsonObject oo = new JsonObject(t);                       
//foreach (var x in oo)                      
//{                          
//textBox1.AppendText(x.Key + " : " + x.Value + "\n");                      
//}
//}

    }
}
