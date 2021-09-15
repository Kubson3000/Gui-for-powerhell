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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_for_powerhell
{
    public partial class Form1 : Form
    {
        public int current_page = 1;
        public int choosen = -1;
        public string new_imie, new_nazwisko, new_password, ou_list, ou_fullname, manager_list, title, department, department_number, manager_name, manager_fullname, ou_name, username, password, ou_number, manager_number;
        public string donor_nazwisko, donor_number, reciver_nazwisko, reciver_number;
        public string[] upn = new string[] { "@korona.wielun.pl", "@coronacandles.com" };

        void final_filler ()
        {
            final_imie_textbox.Text = new_imie;
            final_nazwisko_textbox.Text = new_nazwisko;
            final_haslo_textbox.Text = new_password;
            final_title_textbox.Text = title;
            final_department_textbox.Text = department;
            final_department_number_textbox.Text = department_number;
            final_manager_textbox.Text = manager_fullname;
            final_ou_fullname_textbox.Text = ou_fullname;
        }

        void user_creator ()
        {
            string path = "powershell_functions/user_creator.ps1";
            string script = File.ReadAllText(path);
            string edited_script = script.Replace("$input1", new_imie).Replace("$input2", new_nazwisko).Replace("$input3", new_password).Replace("$input4", title).Replace("$input5", department).Replace("$input6", department_number).Replace("$input7", manager_name).Replace("$input8", manager_number).Replace("$input9", ou_number).Replace("$user_input", username).Replace("$pass_input", password);
            Console.WriteLine(edited_script);
            RunScript(edited_script);
            string result = File.ReadAllText("result.txt");
            if (result == "1")
            {
                MessageBox.Show("Użytkownik został utworzony pomyślnie");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Błąd podczas tworzenia uzytkownika");
            }
            File.Delete("result.txt");
        }
        void Ou_search ()
        {
            string path = "powershell_functions/ou_search.ps1";
            string script = File.ReadAllText(path);
            RunScript(script);
            ou_list = File.ReadAllText("result.txt");
            Console.WriteLine(ou_list);
            StringReader strReader = new StringReader(ou_list);
            while (true)
            {
                string temp = strReader.ReadLine();
                if (temp != null)
                {
                    Ou_listbox.Items.Add(temp);
                }
                else { break; }
            }
            File.Delete("result.txt");
        }

        void Group_copy ()
        {
            string path = "powershell_functions/groups_copy.ps1";
            string script = File.ReadAllText(path);
            string edited_script = script.Replace("$input1", reciver_nazwisko).Replace("$input2", reciver_number).Replace("$input3", donor_nazwisko).Replace("$input4", donor_number).Replace("$user_input", username).Replace("$pass_input", password);
            Console.WriteLine(edited_script);
            RunScript(edited_script);
            string result = File.ReadAllText("result.txt");
            MessageBox.Show(result);
            Application.Exit();
        }

        void load_user_data ()
        {
            string path = "powershell_functions/user_propeties_getter.ps1";
            string script = File.ReadAllText(path);
            string edited_script = script.Replace("$input1", new_imie).Replace("$input2", new_nazwisko).Replace("$input3", new_password).Replace("$user_input", username).Replace("$pass_input", password);
            Console.WriteLine(edited_script);
            RunScript(edited_script);
            modify_imie_textbox.Text = new_imie;
            modify_nazwisko_textbox.Text = new_nazwisko;
            modify_haslo_textbox.Text = new_password;
            modify_title_textbox.Text = File.ReadAllText("title.txt");
            modify_department_textbox.Text = File.ReadAllText("dp.txt");
            modify_departmentnumber_textbox.Text = File.ReadAllText("dp_number.txt");
            string temp_upn = File.ReadAllText("upn.txt");
            int i = 0;
            foreach (string temp in upn)
            {
                modify_upn_combobox.Items.Add(temp);
                if (temp.Contains(temp_upn))
                {
                    modify_upn_combobox.Select();
                }
                i++;
            }
        }

        void Page_switcher(int current_page)
        {
            switch (choosen)
            {
                case -1:
                    switch (current_page)
                    {
                        case 1:
                            if (File.Exists("number.txt"))
                            {
                                File.Delete("number.txt");
                            }
                            if (File.Exists("result.txt"))
                            {
                                File.Delete("result.txt");
                            }
                            Main_label.Text = "Wprowadź dane";
                            Credencials_test_panel.Visible = true;
                            Action_choose_panel.Visible = false;
                            Back_button.Enabled = false;
                            break;
                        case 2:
                            Main_label.Text = "Wybierz akcję";
                            Credencials_test_panel.Visible = false;
                            Action_choose_panel.Visible = true;
                            User_name_pass_input.Visible = false;
                            Back_button.Enabled = true;
                            Next_button.Enabled = false;
                            break;
                        default:
                            Console.WriteLine("Page_switcher error (-1 defult)");
                            break;

                    }
                    break;
                case 0:
                    switch (current_page) // Tworzenie nowego użytkownika
                    {
                        case 2:
                            Main_label.Text = "Wybierz akcję";
                            Credencials_test_panel.Visible = false;
                            Action_choose_panel.Visible = true;
                            User_name_pass_input.Visible = false;
                            Back_button.Enabled = true;
                            Next_button.Enabled = false;
                            choosen = -1;
                            break;
                        case 3:
                            Main_label.Text = "Wprowadź dane tworzonego użytkownika";
                            Action_choose_panel.Visible = false;
                            User_name_pass_input.Visible = true;
                            Ou_choose_panel.Visible = false;
                            User_modify_panel.Visible = false;
                            Next_button.Enabled = false;
                            Ou_search();
                            break;
                        case 4:
                            Main_label.Text = "Wyszukaj i wybierz grupę w której zostanie utworzony nowy użytkownik.";
                            User_name_pass_input.Visible = false;
                            Ou_choose_panel.Visible = true;
                            Manager_panel.Visible = false;
                            Next_button.Enabled = false;
                            break;
                        case 5:
                            Main_label.Text = "Wporwadź nazwisko menadżera, a następnie wybierz go z listy";
                            Ou_choose_panel.Visible = false;
                            Manager_panel.Visible = true;
                            User_create_finish_panel.Visible = false;
                            Next_button.Enabled = false;
                            Next_button.Text = "Next";
                            break;
                        case 6:
                            Main_label.Text = "Sprwdź dane nowego urzytkownika i w razie potrzyeby je popraw";
                            Console.WriteLine('"' + manager_name + '"', '"' + manager_number.ToString() + '"', '"' + ou_number.ToString() + '"');
                            final_filler();
                            Manager_panel.Visible = false;
                            User_create_finish_panel.Visible = true;
                            Next_button.Text = "Finnish";
                            break;
                        case 7: // After 3
                            Main_label.Text = "Zmień wybrane atrybuty uzytkownika";
                            User_name_pass_input.Visible = false;
                            User_modify_panel.Visible = true;
                            break;
                        default:
                            Console.WriteLine("Page_switcher error (0 defult)");
                            break;
                    }
                    break;
                case 1: // Kopiowanie przynależności do grup
                    switch (current_page)
                    {
                        case 2:
                            Main_label.Text = "Wybierz akcję";
                            Credencials_test_panel.Visible = false;
                            Action_choose_panel.Visible = true;
                            User_name_pass_input.Visible = false;
                            User_donor_search_panel.Visible = false;
                            Back_button.Enabled = true;
                            Next_button.Enabled = false;
                            choosen = -1;
                            break;
                        case 3:
                            Main_label.Text = "Wpisz nazwisko 'dawcy', a następnie wybierz go z listy";
                            Action_choose_panel.Visible = false;
                            User_donor_search_panel.Visible = true;
                            Reciver_search_panel.Visible = false;
                            Next_button.Enabled = false;
                            break;
                        case 4:
                            Main_label.Text = "Wpisz nazwisko 'odbiorcy', a nastepnie wybierz go z listy";
                            User_donor_search_panel.Visible = false;
                            Reciver_search_panel.Visible = true;
                            Next_button.Enabled = false;
                            Next_button.Text = "Finnish";
                            break;
                        default:
                            Console.WriteLine("Page_switcher error (1 defult)");
                            break;
                    }
                    break;
            }
        }

        private void Reciver_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reciver_number = Reciver_listbox.SelectedIndex.ToString();
            Next_button.Enabled = true;
        }

        private void Donor_search_button_Click(object sender, EventArgs e)
        {
            donor_nazwisko = Donor_nazwisko_textbox.Text;
            Donor_listbox.Items.Clear();
            Regex rgx = new Regex(@"^[\p{L}]+$");
            if (rgx.IsMatch(donor_nazwisko))
            {
                string path = "powershell_functions/user_search.ps1";
                string script = File.ReadAllText(path);
                string edited_script = script.Replace("$input1", donor_nazwisko);
                RunScript(edited_script);
                string resut = File.ReadAllText("result.txt");
                StringReader strReader = new StringReader(resut);
                while (true)
                {
                    string temp = strReader.ReadLine();
                    if (temp != null)
                    {
                        Donor_listbox.Items.Add(temp);
                    }
                    else { break; }
                }
                File.Delete("result.txt");
            }
            else
            {
                MessageBox.Show("Nazwisko zawiera zakazane symbole");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Next_button.Enabled = false;
            Reciver_listbox.Items.Clear();
            reciver_nazwisko = Reciver_nazwisko_textbox.Text;
            string path = "powershell_functions/user_search.ps1";
            string script = File.ReadAllText(path);
            string edited_script = script.Replace("$input1", reciver_nazwisko);
            RunScript(edited_script);
            string result = File.ReadAllText("result.txt");
            StringReader strReader = new StringReader(result);
            while (true)
            {
                string temp = strReader.ReadLine();
                if (temp != null)
                {
                    Reciver_listbox.Items.Add(temp);
                }
                else { break; }
            }
            File.Delete("result.txt");
        }

        private void Donor_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            donor_number = Donor_listbox.SelectedIndex.ToString();
            Next_button.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void manager_textbox_TextChanged(object sender, EventArgs e)
        {
            manager_name = manager_textbox.Text;
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

        private void Manager_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            manager_number = Manager_listbox.SelectedIndex.ToString();
            manager_fullname = Manager_listbox.SelectedItem.ToString();
            Console.WriteLine(manager_number);
            Next_button.Enabled = true;
        }

        private void Cred_test_button_Click(object sender, EventArgs e)
        {
            string script_edited, new_username, new_password, results;
            string path = "powershell_functions/credencial_check.ps1";
            string script = File.ReadAllText(path);
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

        private void Atribiute_check_button_Click(object sender, EventArgs e)
        {
            title = title_textbox.Text;
            department = department_textbox.Text;
            department_number = department_number_textbox.Text;
            Regex rgx = new Regex(@"^[0-9]{3}-[0-9]{2}$");
            if (rgx.IsMatch(department_number))
            {
                Next_button.Enabled = true;
            }
            else
            {
                MessageBox.Show("Numer MPK jest nieprawidłowy, format prawidłowego numeru xxx-xx");
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            current_page--;
            Page_switcher(current_page);
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            if ((choosen == 0) && (current_page == 6)) {
                user_creator();
            }
            else if ((choosen == 1) && (current_page == 4))
            {
                Group_copy();
            }
            else
            {
                current_page++;
                Page_switcher(current_page);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Next_button.Enabled = false;
            Manager_listbox.Items.Clear();
            string manager_name = manager_textbox.Text;
            manager_name = '"' + manager_name + '"';
            string path = "powershell_functions/manager_search.ps1";
            string script = File.ReadAllText(path);
            string edited_script = script.Replace("$input1", manager_name);
            RunScript(edited_script);
            string manager_list = File.ReadAllText("result.txt");
            StringReader strReader = new StringReader(manager_list);
            Console.WriteLine("Managerlist " + manager_list);
            while (true)
            {
                string temp = strReader.ReadLine();
                if (temp != null)
                {
                    Manager_listbox.Items.Add(temp);
                }
                else { break; }
            }
            File.Delete("result.txt");
        }

        private void Choose_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Next_button.Enabled = true;
            choosen = Choose_listbox.SelectedIndex;
            Console.WriteLine(choosen.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ou_number = Ou_listbox.SelectedIndex.ToString();
            ou_fullname = Ou_listbox.SelectedItem.ToString();
            Console.WriteLine(ou_number.ToString());
            Next_button.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Check_new_user_Click(object sender, EventArgs e)
        {
            new_imie = new_imie_textbox.Text;
            new_nazwisko = new_nazwisko_textbox.Text;
            new_password = new_password_textbox.Text;
            string imie = '"' + new_imie + '"';
            string nazwisko = '"' + new_nazwisko + '"';
            string password = '"' + new_password + '"';
            string path = "powershell_functions/new_user_name_check.ps1";
            string script = File.ReadAllText(path);
            string script_edited = script.Replace("$input1", imie).Replace("$input2", nazwisko).Replace("$input3", password);
            RunScript(script_edited);
            string results = File.ReadAllText("result.txt");
            if (results == "0")
            {
                Atribiute_editor_panel.Visible = true;
            }
            else if (results == "1") // Full name
            {
                File.WriteAllText("number.txt", results);
                DialogResult dialogResult = MessageBox.Show("Użytkownik o podanych danych już istnieje, czy chesz go edytować?", "Eekum bokum", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    current_page = 7;
                    load_user_data();
                    Page_switcher(current_page);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //mogu mogu
                }

            }
            else if (results == "2") // Short name
            {
                MessageBox.Show("Użytkownik istnieje (inicial)");
            }
            else if (results == "3")
            {
                MessageBox.Show("Użytkownik istnieje (pełne imie) + będne hasło");
            }
            else if (results == "4")
            {
                MessageBox.Show("Użytkownik istnieje (iniciał) + będne hasło");
            }
            else if (results == "5")
            {
                MessageBox.Show("Będne hasło");
            }
            Console.WriteLine('"'+results+'"');
            File.Delete("result.txt");
        }
    }
}
