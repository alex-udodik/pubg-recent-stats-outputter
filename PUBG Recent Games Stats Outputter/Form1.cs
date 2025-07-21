using PUBG_Recent_Games_Stats_Outputter.APISerialization;
using PUBG_Recent_Games_Stats_Outputter.APISerialization.Seasons;
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
    public partial class Form1 : Form
    {
        private Timer timer;
        private List<Player> players;

        public Form1()
        {
            players = new List<Player>();
            InitializeComponent();
            init();

        }

        private async void init()
        {

            players = await Sqlite.LoadAllPlayers();
            populateComboBox(null, new EventArgs());

            //load names from sql database
            //name is selected/added
            //checkboxes are selected
            //start is clicked

            ////
            //periodic timer is started (60 seconds)
            //api is checked
            //stats are calced.
            //stats are parsed
            //send to text file
            //repeat
        }

        public void InitTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 2000; // in miliseconds
            timer.Start();
        }

        private async Task<string> GetLatestSeasonId()
        {
            QueryExecutor executor = new QueryExecutor();
            executor.Url = $"https://api.pubg.com/shards/steam/seasons";
            var json = await Task.Run(() => executor.ExecuteQuery());
            JsonParser parser = new JsonParser();
            RootSeasonData rootSeasonData = parser.SerializeSeasonData(json);

            foreach (SeasonData data in rootSeasonData.data)
            {
                if (data.attributes.isCurrentSeason)
                {
                    return data.id;
                }
            }

            return "";
        }

        private GameStats GetGameStats(string gamemode, GameModeStats gameModeStats)
        {
            if (gamemode.Equals("solo"))
            {
                return gameModeStats.solo;
            }
            else if (gamemode.Equals("solo-fpp"))
            {
                return gameModeStats.solo_fpp;
            }
            else if (gamemode.Equals("duo"))
            {
                return gameModeStats.duo;
            }
            else if (gamemode.Equals("duo-fpp"))
            {
                return gameModeStats.duo_fpp;
            }
            else if (gamemode.Equals("squad"))
            {
                return gameModeStats.squad;
            }
            else if (gamemode.Equals("squad-fpp"))
            {
                return gameModeStats.squad_fpp;
            }

            return null;
        }

        private MatchList GetGameModeMatchList(string gamemode, Relationships relationships)
        {
            if (gamemode.Equals("solo"))
            {
                return relationships.matchesSolo;
            }
            else if (gamemode.Equals("solo-fpp"))
            {
                return relationships.matchesSoloFPP;
            }
            else if (gamemode.Equals("duo"))
            {
                return relationships.matchesDuo;
            }
            else if (gamemode.Equals("duo-fpp"))
            {
                return relationships.matchesDuoFPP;
            }
            else if (gamemode.Equals("squad"))
            {
                return relationships.matchesSquad;
            }
            else if (gamemode.Equals("squad-fpp"))
            {
                return relationships.matchesSquadFPP;
            }

            return null;
        }
        private async void timer_Tick(object sender, EventArgs e)
        {
            Player player = await Sqlite.GetAccountID(this.comboBoxNames.SelectedItem.ToString());
            string accountId = player.accountid_;

            string seasonId = await GetLatestSeasonId();

            QueryExecutor executor = new QueryExecutor();
            executor.Url = $"https://api.pubg.com/shards/steam/players/{accountId}/seasons/{seasonId}";

            var json = await Task.Run(() => executor.ExecuteQuery());

            JsonParser parser = new JsonParser();
            RootPlayerSeasonData playerSeasonData = parser.SerializePlayerSeasonData(json);

            string gameMode = this.comboBoxGameModes.SelectedItem.ToString();
            MatchList matchlist = GetGameModeMatchList(gameMode, playerSeasonData.data.relationships);
            GameStats gameStats = GetGameStats(gameMode, playerSeasonData.data.attributes.gameModeStats);
            

            int count = 0;
            foreach (MatchItem match in matchlist.data)
            {
                executor.Url = "https://api.pubg.com/shards/steam/matches/" + match.id;
                json = await Task.Run(() => executor.ExecuteQuery());
                //jsonMatches.Add(json);
                count++;
                //TODO: Now we just need to create a c# object to serialize match object
                // get the matches.
                //calculate stats
                // output to file
                if (count >= 19)
                {
                    break;
                }
                //this.richTextBoxConsole.AppendText(json.ToString());

            }

            this.richTextBoxConsole.AppendText("Finished");

        }

        private AccountID.RootAccountIDObject FetchStats()
        {
            return null;
        }

        private void comboBoxNames_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.comboBoxNames.SelectedItem.ToString().Equals("< add player >"))
            {
                //open new form

                AddNameForm addNameForm = new AddNameForm();
                addNameForm.AddRegisteredName = this.populateComboBox;
                addNameForm.ShowDialog();
            }

        }

        private void populateComboBox(object sender, EventArgs e)
        {
            if (sender != null)
            {
                Player player = sender as Player;
                this.players.Add(player);
            }

            this.comboBoxNames.Items.Clear();
            this.comboBoxNames.Items.Add("< add player >");
            foreach (Player player in this.players)
            {
                string name = player.name_;
                this.comboBoxNames.Items.Add(name);
            }
        }

        private void OutputToTextFile(string path, string data, bool vertical)
        {
            Output output = new Output();


        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            InitTimer();
        }

    }
}
