using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUBG_Recent_Games_Stats_Outputter
{
    public partial class AddNameForm : Form
    {

        public EventHandler AddRegisteredName;
        
        public AddNameForm()
        {
            InitializeComponent();
        }

        private void textBoxAddName_Enter(object sender, EventArgs e)
        {
            //buttonAdd_Click(sender, e);
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = this.textBoxAddName.Text as string;
            string url = "https://api.pubg.com/shards/steam/players?filter[playerNames]=" + name;

            QueryExecutor exec = new QueryExecutor();
            exec.Url = url;
            var json = await Task.Run(() => exec.ExecuteQuery());
            JsonParser parser = new JsonParser();

            AccountID.RootAccountIDObject obj = parser.SerializeAccountIDObject(json);
            string accountid = obj.data[0].id;
            string playername = obj.data[0].attributes.name;
            
            Player player = new Player();
            player.name_ = playername;
            player.accountid_ = accountid;

            await Sqlite.SavePlayer(player);

            //insert into sql database
            //send back to main form and populate combo box
            
            AddRegisteredName?.Invoke(player, e);
        }

    }
}
