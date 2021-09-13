
namespace Gui_for_powerhell
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bottom_buttons_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Next_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.Cred_test_button = new System.Windows.Forms.Button();
            this.Credencia_test_panel = new System.Windows.Forms.Panel();
            this.Username_box = new System.Windows.Forms.TextBox();
            this.Password_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Main_label = new System.Windows.Forms.Label();
            this.Action_choose_panel = new System.Windows.Forms.Panel();
            this.Choose_listbox = new System.Windows.Forms.ListBox();
            this.User_name_pass_input = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.new_imie_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.new_nazwisko_textbox = new System.Windows.Forms.TextBox();
            this.Check_new_user = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.new_password_textbox = new System.Windows.Forms.TextBox();
            this.Atribiute_editor_panel = new System.Windows.Forms.Panel();
            this.Bottom_buttons_panel.SuspendLayout();
            this.Credencia_test_panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Action_choose_panel.SuspendLayout();
            this.User_name_pass_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bottom_buttons_panel
            // 
            this.Bottom_buttons_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bottom_buttons_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bottom_buttons_panel.Controls.Add(this.Next_button);
            this.Bottom_buttons_panel.Controls.Add(this.Back_button);
            this.Bottom_buttons_panel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.Bottom_buttons_panel.Location = new System.Drawing.Point(3, 391);
            this.Bottom_buttons_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bottom_buttons_panel.Name = "Bottom_buttons_panel";
            this.Bottom_buttons_panel.Size = new System.Drawing.Size(795, 57);
            this.Bottom_buttons_panel.TabIndex = 0;
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(717, 3);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(75, 23);
            this.Next_button.TabIndex = 2;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Enabled = false;
            this.Back_button.Location = new System.Drawing.Point(636, 2);
            this.Back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 23);
            this.Back_button.TabIndex = 1;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Cred_test_button
            // 
            this.Cred_test_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cred_test_button.Location = new System.Drawing.Point(402, 249);
            this.Cred_test_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cred_test_button.Name = "Cred_test_button";
            this.Cred_test_button.Size = new System.Drawing.Size(124, 23);
            this.Cred_test_button.TabIndex = 0;
            this.Cred_test_button.Text = "Test Credencias";
            this.Cred_test_button.UseVisualStyleBackColor = true;
            this.Cred_test_button.Click += new System.EventHandler(this.Cred_test_button_Click);
            // 
            // Credencia_test_panel
            // 
            this.Credencia_test_panel.Controls.Add(this.Cred_test_button);
            this.Credencia_test_panel.Controls.Add(this.Username_box);
            this.Credencia_test_panel.Controls.Add(this.Password_box);
            this.Credencia_test_panel.Controls.Add(this.label2);
            this.Credencia_test_panel.Controls.Add(this.label3);
            this.Credencia_test_panel.Location = new System.Drawing.Point(0, 66);
            this.Credencia_test_panel.Margin = new System.Windows.Forms.Padding(4);
            this.Credencia_test_panel.Name = "Credencia_test_panel";
            this.Credencia_test_panel.Size = new System.Drawing.Size(797, 319);
            this.Credencia_test_panel.TabIndex = 0;
            // 
            // Username_box
            // 
            this.Username_box.Location = new System.Drawing.Point(367, 122);
            this.Username_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Username_box.Name = "Username_box";
            this.Username_box.Size = new System.Drawing.Size(189, 22);
            this.Username_box.TabIndex = 6;
            // 
            // Password_box
            // 
            this.Password_box.Location = new System.Drawing.Point(367, 186);
            this.Password_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password_box.Name = "Password_box";
            this.Password_box.PasswordChar = '*';
            this.Password_box.Size = new System.Drawing.Size(189, 22);
            this.Password_box.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Main_label);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(797, 59);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Main_label
            // 
            this.Main_label.AutoSize = true;
            this.Main_label.Location = new System.Drawing.Point(4, 0);
            this.Main_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Main_label.Name = "Main_label";
            this.Main_label.Size = new System.Drawing.Size(106, 16);
            this.Main_label.TabIndex = 0;
            this.Main_label.Text = "Wprowadź dane";
            this.Main_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Action_choose_panel
            // 
            this.Action_choose_panel.Controls.Add(this.Choose_listbox);
            this.Action_choose_panel.Location = new System.Drawing.Point(0, 66);
            this.Action_choose_panel.Margin = new System.Windows.Forms.Padding(4);
            this.Action_choose_panel.Name = "Action_choose_panel";
            this.Action_choose_panel.Size = new System.Drawing.Size(797, 319);
            this.Action_choose_panel.TabIndex = 2;
            this.Action_choose_panel.Visible = false;
            // 
            // Choose_listbox
            // 
            this.Choose_listbox.FormattingEnabled = true;
            this.Choose_listbox.ItemHeight = 16;
            this.Choose_listbox.Items.AddRange(new object[] {
            "Stworzyć nowego użytkownika",
            "Skopiować przynależności grup"});
            this.Choose_listbox.Location = new System.Drawing.Point(245, 69);
            this.Choose_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.Choose_listbox.Name = "Choose_listbox";
            this.Choose_listbox.Size = new System.Drawing.Size(260, 100);
            this.Choose_listbox.TabIndex = 0;
            this.Choose_listbox.SelectedIndexChanged += new System.EventHandler(this.Choose_listbox_SelectedIndexChanged);
            // 
            // User_name_pass_input
            // 
            this.User_name_pass_input.Controls.Add(this.Atribiute_editor_panel);
            this.User_name_pass_input.Controls.Add(this.new_password_textbox);
            this.User_name_pass_input.Controls.Add(this.label5);
            this.User_name_pass_input.Controls.Add(this.Check_new_user);
            this.User_name_pass_input.Controls.Add(this.new_nazwisko_textbox);
            this.User_name_pass_input.Controls.Add(this.label4);
            this.User_name_pass_input.Controls.Add(this.new_imie_textbox);
            this.User_name_pass_input.Controls.Add(this.label1);
            this.User_name_pass_input.Location = new System.Drawing.Point(0, 66);
            this.User_name_pass_input.Name = "User_name_pass_input";
            this.User_name_pass_input.Size = new System.Drawing.Size(797, 319);
            this.User_name_pass_input.TabIndex = 3;
            this.User_name_pass_input.Visible = false;
            this.User_name_pass_input.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // new_imie_textbox
            // 
            this.new_imie_textbox.Location = new System.Drawing.Point(85, 48);
            this.new_imie_textbox.Name = "new_imie_textbox";
            this.new_imie_textbox.Size = new System.Drawing.Size(100, 22);
            this.new_imie_textbox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nazwisko";
            // 
            // new_nazwisko_textbox
            // 
            this.new_nazwisko_textbox.Location = new System.Drawing.Point(85, 88);
            this.new_nazwisko_textbox.Name = "new_nazwisko_textbox";
            this.new_nazwisko_textbox.Size = new System.Drawing.Size(100, 22);
            this.new_nazwisko_textbox.TabIndex = 3;
            // 
            // Check_new_user
            // 
            this.Check_new_user.Location = new System.Drawing.Point(96, 169);
            this.Check_new_user.Name = "Check_new_user";
            this.Check_new_user.Size = new System.Drawing.Size(75, 23);
            this.Check_new_user.TabIndex = 4;
            this.Check_new_user.Text = "Check user";
            this.Check_new_user.UseVisualStyleBackColor = true;
            this.Check_new_user.Click += new System.EventHandler(this.Check_new_user_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hasło";
            // 
            // new_password_textbox
            // 
            this.new_password_textbox.Location = new System.Drawing.Point(85, 125);
            this.new_password_textbox.Name = "new_password_textbox";
            this.new_password_textbox.PasswordChar = '*';
            this.new_password_textbox.Size = new System.Drawing.Size(100, 22);
            this.new_password_textbox.TabIndex = 6;
            // 
            // Atribiute_editor_panel
            // 
            this.Atribiute_editor_panel.Location = new System.Drawing.Point(367, 1);
            this.Atribiute_editor_panel.Name = "Atribiute_editor_panel";
            this.Atribiute_editor_panel.Size = new System.Drawing.Size(427, 318);
            this.Atribiute_editor_panel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.User_name_pass_input);
            this.Controls.Add(this.Action_choose_panel);
            this.Controls.Add(this.Credencia_test_panel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Bottom_buttons_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "AD helper";
            this.Bottom_buttons_panel.ResumeLayout(false);
            this.Credencia_test_panel.ResumeLayout(false);
            this.Credencia_test_panel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.Action_choose_panel.ResumeLayout(false);
            this.User_name_pass_input.ResumeLayout(false);
            this.User_name_pass_input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Bottom_buttons_panel;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Cred_test_button;
        private System.Windows.Forms.Panel Credencia_test_panel;
        private System.Windows.Forms.TextBox Username_box;
        private System.Windows.Forms.TextBox Password_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Action_choose_panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Main_label;
        private System.Windows.Forms.ListBox Choose_listbox;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Panel User_name_pass_input;
        private System.Windows.Forms.Panel Atribiute_editor_panel;
        private System.Windows.Forms.TextBox new_password_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Check_new_user;
        private System.Windows.Forms.TextBox new_nazwisko_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox new_imie_textbox;
        private System.Windows.Forms.Label label1;
    }
}

