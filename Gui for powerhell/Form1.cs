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
        void Page_switcher(int current_page)
        {
            switch (current_page)
            {
                case 1:
                    Credencia_test_panel.Visible = true;
                    Action_choose_panel.Visible = false;
                    Back_button.Enabled = false;
                    break;
                case 2:
                    Credencia_test_panel.Visible = false;
                    Action_choose_panel.Visible = true;
                    Back_button.Enabled = true;
                    Next_button.Enabled = false;
                    break;
                default:
                    Console.WriteLine("Page_switcher error");
                    break;

            }
        }
        public int current_page = 1;

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
            results = File.ReadAllText("Credencial_result.txt");
            if (results == "1") // Credencials correct
            {
                Next_button.Enabled = true;
            }
            else // Credencial false
            {
                MessageBox.Show("Niedostateczne permisje urzytkownika");
            }
            Console.WriteLine(results);
            File.Delete("Credencial_result.txt");
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            current_page--;
            Page_switcher(current_page);
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            current_page++;
            Page_switcher(current_page);
        }

        private void Choose_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Next_button.Enabled = true;
        }
    }
}
