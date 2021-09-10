using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_for_powerhell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RunScript(string script)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(script);
            pipeline.Invoke();
            runspace.Close();
        }

        private void Cred_test_button_Click(object sender, EventArgs e)
        {
            string script_edited, new_username, new_password, results;
            string path = "script1.ps1";
            string script = File.ReadAllText(path);
            string username, password;
            username = Username_box.Text;
            password = Password_box.Text;
            new_username = '"' + username + '"';
            new_password = '"' + password + '"';
            script_edited = script.Replace("$user_input", new_username).Replace("$pass_input", new_password);
            RunScript(script_edited);
            //Output_textbox.Text = username + password;
            results = File.ReadAllText("Credencial_result.txt");
            if (results == "1") // Credencials correct
            {
                
            }
            else // Credencial false !add popup
            {
                MessageBox.Show("Niedostateczne permisje urzytkownika");
            }
            Console.WriteLine(results);
            File.Delete("Credencial_result.txt");
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
