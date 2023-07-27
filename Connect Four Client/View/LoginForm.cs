using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connect_Four_Client.API;
using Connect_Four_Client.Model.Tables;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Connect_Four_Client.Model;
using Connect_Four_Client.Model.HTTP;

namespace Connect_Four_Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CreateAccountLable_Click(object sender, EventArgs e)
        {
            // Open Registar Website Page 
            System.Diagnostics.Process.Start("https://localhost:7114/Players/Create");
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {           
            try {
                // check with the server if the id is exist in the server 
                string idTextBox = IdTextBox.Text;
                int id = Int32.Parse(idTextBox);
                // get the player info 
                PlayersTbl playersTbl =  await HttpClientServerRequest.GetPlayerAsync(idTextBox);
                
                if (playersTbl != null)
                {
                    // create player class from the data
                    Player player = new Player(playersTbl.FirstName, playersTbl.LastName, playersTbl.Id, (Country)Enum.ToObject(typeof(Country), playersTbl.Counrty), playersTbl.Phone, playersTbl.GamesNum);
                    //open the menu for the player
                    MenuForm Menu = new MenuForm(player, this);
                    Menu.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("ID is not exist in system, please registar in the website.", "Error");
                }


            } catch (Exception) {
                // error message
                // show pop up message
                MessageBox.Show("Please enter valid ID", "Erorr");
            }
        }


    }
}
