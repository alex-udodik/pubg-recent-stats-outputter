
namespace PUBG_Recent_Games_Stats_Outputter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSelectName = new System.Windows.Forms.Label();
            this.comboBoxNames = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSelectStats = new System.Windows.Forms.Label();
            this.labelLast20 = new System.Windows.Forms.Label();
            this.labelLastGame = new System.Windows.Forms.Label();
            this.labelCurrentSeason = new System.Windows.Forms.Label();
            this.checkBoxLast20GamesADR = new System.Windows.Forms.CheckBox();
            this.checkBoxLast20SurvivedTime = new System.Windows.Forms.CheckBox();
            this.checkBoxLast20FraggerRating = new System.Windows.Forms.CheckBox();
            this.checkBoxLastGameAdr = new System.Windows.Forms.CheckBox();
            this.checkBoxLastGameSurvivedTime = new System.Windows.Forms.CheckBox();
            this.checkBoxLastGameKills = new System.Windows.Forms.CheckBox();
            this.checkBoxLastGamePlacement = new System.Windows.Forms.CheckBox();
            this.checkBoxCurrentSeasonFraggerRating = new System.Windows.Forms.CheckBox();
            this.checkBoxCurrentSeasonSurvivedTime = new System.Windows.Forms.CheckBox();
            this.checkBoxCurrentSeasonAdr = new System.Windows.Forms.CheckBox();
            this.checkBoxCurrentSeasonWinRate = new System.Windows.Forms.CheckBox();
            this.checkBoxVerticalOutput = new System.Windows.Forms.CheckBox();
            this.richTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.labelConsole = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxGameModes = new System.Windows.Forms.ComboBox();
            this.labelSelectGameMode = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSelectName
            // 
            this.labelSelectName.AutoSize = true;
            this.labelSelectName.Font = new System.Drawing.Font("Azonix", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectName.Location = new System.Drawing.Point(12, 50);
            this.labelSelectName.Name = "labelSelectName";
            this.labelSelectName.Size = new System.Drawing.Size(149, 17);
            this.labelSelectName.TabIndex = 0;
            this.labelSelectName.Text = "Select Name";
            // 
            // comboBoxNames
            // 
            this.comboBoxNames.FormattingEnabled = true;
            this.comboBoxNames.Items.AddRange(new object[] {
            "Add name"});
            this.comboBoxNames.Location = new System.Drawing.Point(168, 50);
            this.comboBoxNames.Name = "comboBoxNames";
            this.comboBoxNames.Size = new System.Drawing.Size(142, 21);
            this.comboBoxNames.TabIndex = 1;
            this.comboBoxNames.Text = "Select Player";
            this.comboBoxNames.SelectedIndexChanged += new System.EventHandler(this.comboBoxNames_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // labelSelectStats
            // 
            this.labelSelectStats.AutoSize = true;
            this.labelSelectStats.Font = new System.Drawing.Font("Azonix", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectStats.Location = new System.Drawing.Point(12, 98);
            this.labelSelectStats.Name = "labelSelectStats";
            this.labelSelectStats.Size = new System.Drawing.Size(154, 17);
            this.labelSelectStats.TabIndex = 3;
            this.labelSelectStats.Text = "Select Stats";
            // 
            // labelLast20
            // 
            this.labelLast20.AutoSize = true;
            this.labelLast20.Font = new System.Drawing.Font("Azonix", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLast20.Location = new System.Drawing.Point(13, 139);
            this.labelLast20.Name = "labelLast20";
            this.labelLast20.Size = new System.Drawing.Size(65, 12);
            this.labelLast20.TabIndex = 4;
            this.labelLast20.Text = "Last 20";
            // 
            // labelLastGame
            // 
            this.labelLastGame.AutoSize = true;
            this.labelLastGame.Font = new System.Drawing.Font("Azonix", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastGame.Location = new System.Drawing.Point(332, 139);
            this.labelLastGame.Name = "labelLastGame";
            this.labelLastGame.Size = new System.Drawing.Size(85, 12);
            this.labelLastGame.TabIndex = 5;
            this.labelLastGame.Text = "Last Game";
            // 
            // labelCurrentSeason
            // 
            this.labelCurrentSeason.AutoSize = true;
            this.labelCurrentSeason.Font = new System.Drawing.Font("Azonix", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentSeason.Location = new System.Drawing.Point(632, 139);
            this.labelCurrentSeason.Name = "labelCurrentSeason";
            this.labelCurrentSeason.Size = new System.Drawing.Size(133, 12);
            this.labelCurrentSeason.TabIndex = 6;
            this.labelCurrentSeason.Text = "Current Season";
            // 
            // checkBoxLast20GamesADR
            // 
            this.checkBoxLast20GamesADR.AutoSize = true;
            this.checkBoxLast20GamesADR.Font = new System.Drawing.Font("Azonix", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLast20GamesADR.Location = new System.Drawing.Point(15, 155);
            this.checkBoxLast20GamesADR.Name = "checkBoxLast20GamesADR";
            this.checkBoxLast20GamesADR.Size = new System.Drawing.Size(49, 15);
            this.checkBoxLast20GamesADR.TabIndex = 7;
            this.checkBoxLast20GamesADR.Text = "ADR";
            this.checkBoxLast20GamesADR.UseVisualStyleBackColor = true;
            // 
            // checkBoxLast20SurvivedTime
            // 
            this.checkBoxLast20SurvivedTime.AutoSize = true;
            this.checkBoxLast20SurvivedTime.Font = new System.Drawing.Font("Azonix", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLast20SurvivedTime.Location = new System.Drawing.Point(15, 176);
            this.checkBoxLast20SurvivedTime.Name = "checkBoxLast20SurvivedTime";
            this.checkBoxLast20SurvivedTime.Size = new System.Drawing.Size(119, 15);
            this.checkBoxLast20SurvivedTime.TabIndex = 8;
            this.checkBoxLast20SurvivedTime.Text = "Survived Time";
            this.checkBoxLast20SurvivedTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxLast20FraggerRating
            // 
            this.checkBoxLast20FraggerRating.AutoSize = true;
            this.checkBoxLast20FraggerRating.Font = new System.Drawing.Font("Azonix", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLast20FraggerRating.Location = new System.Drawing.Point(15, 197);
            this.checkBoxLast20FraggerRating.Name = "checkBoxLast20FraggerRating";
            this.checkBoxLast20FraggerRating.Size = new System.Drawing.Size(131, 15);
            this.checkBoxLast20FraggerRating.TabIndex = 9;
            this.checkBoxLast20FraggerRating.Text = "Fragger Rating";
            this.checkBoxLast20FraggerRating.UseVisualStyleBackColor = true;
            // 
            // checkBoxLastGameAdr
            // 
            this.checkBoxLastGameAdr.AutoSize = true;
            this.checkBoxLastGameAdr.Font = new System.Drawing.Font("Azonix", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLastGameAdr.Location = new System.Drawing.Point(334, 154);
            this.checkBoxLastGameAdr.Name = "checkBoxLastGameAdr";
            this.checkBoxLastGameAdr.Size = new System.Drawing.Size(49, 15);
            this.checkBoxLastGameAdr.TabIndex = 10;
            this.checkBoxLastGameAdr.Text = "ADR";
            this.checkBoxLastGameAdr.UseVisualStyleBackColor = true;
            // 
            // checkBoxLastGameSurvivedTime
            // 
            this.checkBoxLastGameSurvivedTime.AutoSize = true;
            this.checkBoxLastGameSurvivedTime.Font = new System.Drawing.Font("Azonix", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLastGameSurvivedTime.Location = new System.Drawing.Point(334, 175);
            this.checkBoxLastGameSurvivedTime.Name = "checkBoxLastGameSurvivedTime";
            this.checkBoxLastGameSurvivedTime.Size = new System.Drawing.Size(119, 15);
            this.checkBoxLastGameSurvivedTime.TabIndex = 11;
            this.checkBoxLastGameSurvivedTime.Text = "Survived Time";
            this.checkBoxLastGameSurvivedTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxLastGameKills
            // 
            this.checkBoxLastGameKills.AutoSize = true;
            this.checkBoxLastGameKills.Font = new System.Drawing.Font("Azonix", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLastGameKills.Location = new System.Drawing.Point(334, 196);
            this.checkBoxLastGameKills.Name = "checkBoxLastGameKills";
            this.checkBoxLastGameKills.Size = new System.Drawing.Size(57, 15);
            this.checkBoxLastGameKills.TabIndex = 12;
            this.checkBoxLastGameKills.Text = "Kills";
            this.checkBoxLastGameKills.UseVisualStyleBackColor = true;
            // 
            // checkBoxLastGamePlacement
            // 
            this.checkBoxLastGamePlacement.AutoSize = true;
            this.checkBoxLastGamePlacement.Font = new System.Drawing.Font("Azonix", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLastGamePlacement.Location = new System.Drawing.Point(334, 217);
            this.checkBoxLastGamePlacement.Name = "checkBoxLastGamePlacement";
            this.checkBoxLastGamePlacement.Size = new System.Drawing.Size(100, 15);
            this.checkBoxLastGamePlacement.TabIndex = 13;
            this.checkBoxLastGamePlacement.Text = "Placement";
            this.checkBoxLastGamePlacement.UseVisualStyleBackColor = true;
            // 
            // checkBoxCurrentSeasonFraggerRating
            // 
            this.checkBoxCurrentSeasonFraggerRating.AutoSize = true;
            this.checkBoxCurrentSeasonFraggerRating.Font = new System.Drawing.Font("Azonix", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCurrentSeasonFraggerRating.Location = new System.Drawing.Point(634, 197);
            this.checkBoxCurrentSeasonFraggerRating.Name = "checkBoxCurrentSeasonFraggerRating";
            this.checkBoxCurrentSeasonFraggerRating.Size = new System.Drawing.Size(131, 15);
            this.checkBoxCurrentSeasonFraggerRating.TabIndex = 16;
            this.checkBoxCurrentSeasonFraggerRating.Text = "Fragger Rating";
            this.checkBoxCurrentSeasonFraggerRating.UseVisualStyleBackColor = true;
            // 
            // checkBoxCurrentSeasonSurvivedTime
            // 
            this.checkBoxCurrentSeasonSurvivedTime.AutoSize = true;
            this.checkBoxCurrentSeasonSurvivedTime.Font = new System.Drawing.Font("Azonix", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCurrentSeasonSurvivedTime.Location = new System.Drawing.Point(634, 176);
            this.checkBoxCurrentSeasonSurvivedTime.Name = "checkBoxCurrentSeasonSurvivedTime";
            this.checkBoxCurrentSeasonSurvivedTime.Size = new System.Drawing.Size(119, 15);
            this.checkBoxCurrentSeasonSurvivedTime.TabIndex = 15;
            this.checkBoxCurrentSeasonSurvivedTime.Text = "Survived Time";
            this.checkBoxCurrentSeasonSurvivedTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxCurrentSeasonAdr
            // 
            this.checkBoxCurrentSeasonAdr.AutoSize = true;
            this.checkBoxCurrentSeasonAdr.Font = new System.Drawing.Font("Azonix", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCurrentSeasonAdr.Location = new System.Drawing.Point(634, 155);
            this.checkBoxCurrentSeasonAdr.Name = "checkBoxCurrentSeasonAdr";
            this.checkBoxCurrentSeasonAdr.Size = new System.Drawing.Size(49, 15);
            this.checkBoxCurrentSeasonAdr.TabIndex = 14;
            this.checkBoxCurrentSeasonAdr.Text = "ADR";
            this.checkBoxCurrentSeasonAdr.UseVisualStyleBackColor = true;
            // 
            // checkBoxCurrentSeasonWinRate
            // 
            this.checkBoxCurrentSeasonWinRate.AutoSize = true;
            this.checkBoxCurrentSeasonWinRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxCurrentSeasonWinRate.Font = new System.Drawing.Font("Azonix", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCurrentSeasonWinRate.Location = new System.Drawing.Point(634, 218);
            this.checkBoxCurrentSeasonWinRate.Name = "checkBoxCurrentSeasonWinRate";
            this.checkBoxCurrentSeasonWinRate.Size = new System.Drawing.Size(78, 15);
            this.checkBoxCurrentSeasonWinRate.TabIndex = 17;
            this.checkBoxCurrentSeasonWinRate.Text = "WinRate";
            this.checkBoxCurrentSeasonWinRate.UseVisualStyleBackColor = true;
            // 
            // checkBoxVerticalOutput
            // 
            this.checkBoxVerticalOutput.AutoSize = true;
            this.checkBoxVerticalOutput.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVerticalOutput.Location = new System.Drawing.Point(15, 421);
            this.checkBoxVerticalOutput.Name = "checkBoxVerticalOutput";
            this.checkBoxVerticalOutput.Size = new System.Drawing.Size(333, 20);
            this.checkBoxVerticalOutput.TabIndex = 18;
            this.checkBoxVerticalOutput.Text = "Send to text file vertically";
            this.checkBoxVerticalOutput.UseVisualStyleBackColor = true;
            // 
            // richTextBoxConsole
            // 
            this.richTextBoxConsole.Location = new System.Drawing.Point(12, 482);
            this.richTextBoxConsole.Name = "richTextBoxConsole";
            this.richTextBoxConsole.Size = new System.Drawing.Size(502, 232);
            this.richTextBoxConsole.TabIndex = 19;
            this.richTextBoxConsole.Text = "";
            // 
            // labelConsole
            // 
            this.labelConsole.AutoSize = true;
            this.labelConsole.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsole.Location = new System.Drawing.Point(12, 463);
            this.labelConsole.Name = "labelConsole";
            this.labelConsole.Size = new System.Drawing.Size(92, 16);
            this.labelConsole.TabIndex = 20;
            this.labelConsole.Text = "Console";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(520, 569);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(102, 52);
            this.buttonStart.TabIndex = 22;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxGameModes
            // 
            this.comboBoxGameModes.FormattingEnabled = true;
            this.comboBoxGameModes.Items.AddRange(new object[] {
            "solo",
            "solo-fpp",
            "duo",
            "duo-fpp",
            "squad",
            "squad-fpp"});
            this.comboBoxGameModes.Location = new System.Drawing.Point(584, 50);
            this.comboBoxGameModes.Name = "comboBoxGameModes";
            this.comboBoxGameModes.Size = new System.Drawing.Size(142, 21);
            this.comboBoxGameModes.TabIndex = 24;
            this.comboBoxGameModes.Text = "Select Game Mode";
            // 
            // labelSelectGameMode
            // 
            this.labelSelectGameMode.AutoSize = true;
            this.labelSelectGameMode.Font = new System.Drawing.Font("Azonix", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectGameMode.Location = new System.Drawing.Point(366, 50);
            this.labelSelectGameMode.Name = "labelSelectGameMode";
            this.labelSelectGameMode.Size = new System.Drawing.Size(212, 17);
            this.labelSelectGameMode.TabIndex = 23;
            this.labelSelectGameMode.Text = "Select Game Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 726);
            this.Controls.Add(this.comboBoxGameModes);
            this.Controls.Add(this.labelSelectGameMode);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelConsole);
            this.Controls.Add(this.richTextBoxConsole);
            this.Controls.Add(this.checkBoxVerticalOutput);
            this.Controls.Add(this.checkBoxCurrentSeasonWinRate);
            this.Controls.Add(this.checkBoxCurrentSeasonFraggerRating);
            this.Controls.Add(this.checkBoxCurrentSeasonSurvivedTime);
            this.Controls.Add(this.checkBoxCurrentSeasonAdr);
            this.Controls.Add(this.checkBoxLastGamePlacement);
            this.Controls.Add(this.checkBoxLastGameKills);
            this.Controls.Add(this.checkBoxLastGameSurvivedTime);
            this.Controls.Add(this.checkBoxLastGameAdr);
            this.Controls.Add(this.checkBoxLast20FraggerRating);
            this.Controls.Add(this.checkBoxLast20SurvivedTime);
            this.Controls.Add(this.checkBoxLast20GamesADR);
            this.Controls.Add(this.labelCurrentSeason);
            this.Controls.Add(this.labelLastGame);
            this.Controls.Add(this.labelLast20);
            this.Controls.Add(this.labelSelectStats);
            this.Controls.Add(this.comboBoxNames);
            this.Controls.Add(this.labelSelectName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectName;
        private System.Windows.Forms.ComboBox comboBoxNames;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label labelSelectStats;
        private System.Windows.Forms.Label labelLast20;
        private System.Windows.Forms.Label labelLastGame;
        private System.Windows.Forms.Label labelCurrentSeason;
        private System.Windows.Forms.CheckBox checkBoxLast20GamesADR;
        private System.Windows.Forms.CheckBox checkBoxLast20SurvivedTime;
        private System.Windows.Forms.CheckBox checkBoxLast20FraggerRating;
        private System.Windows.Forms.CheckBox checkBoxLastGameAdr;
        private System.Windows.Forms.CheckBox checkBoxLastGameSurvivedTime;
        private System.Windows.Forms.CheckBox checkBoxLastGameKills;
        private System.Windows.Forms.CheckBox checkBoxLastGamePlacement;
        private System.Windows.Forms.CheckBox checkBoxCurrentSeasonFraggerRating;
        private System.Windows.Forms.CheckBox checkBoxCurrentSeasonSurvivedTime;
        private System.Windows.Forms.CheckBox checkBoxCurrentSeasonAdr;
        private System.Windows.Forms.CheckBox checkBoxCurrentSeasonWinRate;
        private System.Windows.Forms.CheckBox checkBoxVerticalOutput;
        private System.Windows.Forms.RichTextBox richTextBoxConsole;
        private System.Windows.Forms.Label labelConsole;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxGameModes;
        private System.Windows.Forms.Label labelSelectGameMode;
    }
}

