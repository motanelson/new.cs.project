using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace newprojs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "new_project";
        }
        public static void Mains(string[] argv)
        {
            string f1 = "<Solution>\r\n  <Project Path=\"$1.csproj\" />\r\n</Solution>\r\n";
            string f2 = "<Project Sdk=\"Microsoft.NET.Sdk\">\r\n\r\n  <PropertyGroup>\r\n    <OutputType>Exe</OutputType>\r\n    <TargetFramework>net6.0</TargetFramework>\r\n    <ImplicitUsings>enable</ImplicitUsings>\r\n    <Nullable>enable</Nullable>\r\n  </PropertyGroup>\r\n\r\n</Project>\r\n";
            string f3 = "Console.BackgroundColor = ConsoleColor.White;\r\nConsole.ForegroundColor = ConsoleColor.Black;\r\nConsole.Clear();\r\nConsole.WriteLine(\"Hello world...\\n\");";
            
            if (argv.Length < 1) return;
            f1 = f1.Replace("$1", argv[0]);
            Directory.CreateDirectory(argv[0]);
            File.WriteAllText(argv[0] + "\\" + argv[0] + ".slnx", f1);
            File.WriteAllText(argv[0] + "\\" + argv[0] + ".csproj", f2);
            File.WriteAllText(argv[0] + "\\" + "Program.cs", f3);
            return;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] s= new string[1];
            s[0] = textBox1.Text.ToString();
            Mains(s);
        }
    }
}
