using Connect_Four_Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Four_Client
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }



        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load_1(object sender, EventArgs e)
        {

        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            new ConnectFourGameForm().Show();

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
