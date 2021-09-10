using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        }

        private void Cred_test_button_Click(object sender, EventArgs e)
        {
            string script_edited, new_username, new_password;
            string path = "script1.ps1";
            string script = File.ReadAllText(path);
            string username, password;
            username = Username_box.Text;
            password = Password_box.Text;
            new_username = '"' + username + '"';
            new_password = '"' + password + '"';
            script_edited = script.Replace("$user_input", new_username).Replace("$pass_input", new_password);
            RunScript(script_edited);
            Output_textbox.Text = username + password;
        }
    }
}
