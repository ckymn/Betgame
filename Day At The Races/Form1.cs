using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Races
{
    public partial class Form1 : Form
    {
        Greyhound[] dogsArray = new Greyhound[4]; // tazi class`ini kullanmak icin nesne olusturduk ve 4 tazidan olusuyor.
        private Timer timer1;
        private IContainer components;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        int zackBet = 0; //zac bahis degeri
        int nickBet = 0; // nick bahis degeri
        int taylorBet = 0; // taylor bahis degeri
        bool Bet = false; //bahislerin baslangic degeri
        public string winningDog; //kazanan kopek degeri
        decimal dbOddsAgainst; //
        public decimal Test;





        Guy[] guyArray = new Guy[3];
        private Label lblZack;
        private Label lblNick;
        private Label lblTaylor;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox1;
        private Label lblOdds;
        public Label lblDBOdds;
        private Label LROdds;
        private Label MOdds;
        private Label SSOdds;
        private Label label4;
        private BackgroundWorker backgroundWorker1;
        Random Randomizer = new Random();
        //Bet Mybet = new Bet();


        public Form1()
        {
            InitializeComponent();


            dogsArray[0] = new Greyhound() { MyPictureBox = pictureBox1, Name = "Day Break", RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width, StartingPosition = pictureBox1.Left, Randomizer = Randomizer, oddsFor = Randomizer.Next(1, 3), oddsAgainst = Randomizer.Next(2, 8) };
            dogsArray[1] = new Greyhound() { MyPictureBox = pictureBox2, Name = "Lightning's Revenge", RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width, StartingPosition = pictureBox2.Left, Randomizer = Randomizer, oddsFor = Randomizer.Next(1, 3), oddsAgainst = Randomizer.Next(2, 14) };
            dogsArray[2] = new Greyhound() { MyPictureBox = pictureBox3, Name = "Mytosis", RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width, StartingPosition = pictureBox3.Left, Randomizer = Randomizer, oddsFor = Randomizer.Next(1, 3), oddsAgainst = Randomizer.Next(2, 12) };
            dogsArray[3] = new Greyhound() { MyPictureBox = pictureBox4, Name = "Sleeping Sycamore", RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width, StartingPosition = pictureBox4.Left, Randomizer = Randomizer, oddsFor = Randomizer.Next(1, 3), oddsAgainst = Randomizer.Next(2, 10) };

            guyArray[0] = new Guy() { MyBet = null, Name = "Zack", Cash = 50, MyLabel = lblZack, MyRadioButton = rdbtnZack, MyLabel2 = lblZackBet };
            guyArray[1] = new Guy() { MyBet = null, Name = "Nick", Cash = 75, MyLabel = lblNick, MyRadioButton = rdbtnNick, MyLabel2 = lblNickBet };
            guyArray[2] = new Guy() { MyBet = null, Name = "Taylor", Cash = 45, MyLabel = lblTaylor, MyRadioButton = rdbtnTaylor, MyLabel2 = lblTaylorBet };

            guyArray[0].UpdateLabels();
            guyArray[1].UpdateLabels();
            guyArray[2].UpdateLabels();


            if (dogsArray[0].oddsFor.ToString() == dogsArray[0].oddsAgainst.ToString())
                lblDBOdds.Text = "Even";
            else
                lblDBOdds.Text = dogsArray[0].oddsAgainst.ToString() + " : " + dogsArray[0].oddsFor.ToString();
            if (dogsArray[1].oddsFor.ToString() == dogsArray[1].oddsAgainst.ToString())
                LROdds.Text = "Even";
            else
                LROdds.Text = dogsArray[1].oddsAgainst.ToString() + " : " + dogsArray[1].oddsFor.ToString();
            if (dogsArray[2].oddsFor.ToString() == dogsArray[2].oddsAgainst.ToString())
                MOdds.Text = "Even";
            else
                MOdds.Text = dogsArray[2].oddsAgainst.ToString() + " : " + dogsArray[2].oddsFor.ToString();
            if (dogsArray[3].oddsFor.ToString() == dogsArray[3].oddsAgainst.ToString())
                SSOdds.Text = "Even";
            else
                SSOdds.Text = dogsArray[3].oddsAgainst.ToString() + " : " + dogsArray[3].oddsFor.ToString();


        }

        private void btnRace_Click_1(object sender, EventArgs e)
        {

            dogsArray[0].TakeStartingPosition();
            dogsArray[1].TakeStartingPosition();
            dogsArray[2].TakeStartingPosition();
            dogsArray[3].TakeStartingPosition();
            zackBet = 0;
            nickBet = 0;
            taylorBet = 0;
            btnRace.Enabled = false;
            timer1.Start();

        }

        private PictureBox racetrackPictureBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbtnZack = new System.Windows.Forms.RadioButton();
            this.rdbtnNick = new System.Windows.Forms.RadioButton();
            this.rdbtnTaylor = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblZackBet = new System.Windows.Forms.Label();
            this.lblNickBet = new System.Windows.Forms.Label();
            this.lblTaylorBet = new System.Windows.Forms.Label();
            this.lblBetter = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRace = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblZack = new System.Windows.Forms.Label();
            this.lblNick = new System.Windows.Forms.Label();
            this.lblTaylor = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblOdds = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.lblDBOdds = new System.Windows.Forms.Label();
            this.LROdds = new System.Windows.Forms.Label();
            this.MOdds = new System.Windows.Forms.Label();
            this.SSOdds = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Betting Parlor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minimum bet:  5 dollars";
            // 
            // rdbtnZack
            // 
            this.rdbtnZack.AutoSize = true;
            this.rdbtnZack.Checked = true;
            this.rdbtnZack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnZack.Location = new System.Drawing.Point(33, 302);
            this.rdbtnZack.Name = "rdbtnZack";
            this.rdbtnZack.Size = new System.Drawing.Size(14, 13);
            this.rdbtnZack.TabIndex = 7;
            this.rdbtnZack.TabStop = true;
            this.rdbtnZack.UseVisualStyleBackColor = true;
            this.rdbtnZack.CheckedChanged += new System.EventHandler(this.rdbtnZack_CheckedChanged);
            // 
            // rdbtnNick
            // 
            this.rdbtnNick.AutoSize = true;
            this.rdbtnNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNick.Location = new System.Drawing.Point(33, 326);
            this.rdbtnNick.Name = "rdbtnNick";
            this.rdbtnNick.Size = new System.Drawing.Size(14, 13);
            this.rdbtnNick.TabIndex = 8;
            this.rdbtnNick.UseVisualStyleBackColor = true;
            this.rdbtnNick.CheckedChanged += new System.EventHandler(this.rdbtnNick_CheckedChanged);
            // 
            // rdbtnTaylor
            // 
            this.rdbtnTaylor.AutoSize = true;
            this.rdbtnTaylor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnTaylor.Location = new System.Drawing.Point(33, 349);
            this.rdbtnTaylor.Name = "rdbtnTaylor";
            this.rdbtnTaylor.Size = new System.Drawing.Size(14, 13);
            this.rdbtnTaylor.TabIndex = 9;
            this.rdbtnTaylor.UseVisualStyleBackColor = true;
            this.rdbtnTaylor.CheckedChanged += new System.EventHandler(this.rdbtnTaylor_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // lblZackBet
            // 
            this.lblZackBet.AutoSize = true;
            this.lblZackBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZackBet.Location = new System.Drawing.Point(266, 304);
            this.lblZackBet.Name = "lblZackBet";
            this.lblZackBet.Size = new System.Drawing.Size(154, 16);
            this.lblZackBet.TabIndex = 11;
            this.lblZackBet.Text = "Zack hasn\'t placed a bet";
            this.lblZackBet.Click += new System.EventHandler(this.lblZackBet_Click);
            // 
            // lblNickBet
            // 
            this.lblNickBet.AutoSize = true;
            this.lblNickBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickBet.Location = new System.Drawing.Point(266, 328);
            this.lblNickBet.Name = "lblNickBet";
            this.lblNickBet.Size = new System.Drawing.Size(151, 16);
            this.lblNickBet.TabIndex = 12;
            this.lblNickBet.Text = "Nick hasn\'t placed a bet";
            this.lblNickBet.Click += new System.EventHandler(this.lblNickBet_Click);
            // 
            // lblTaylorBet
            // 
            this.lblTaylorBet.AutoSize = true;
            this.lblTaylorBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaylorBet.Location = new System.Drawing.Point(266, 350);
            this.lblTaylorBet.Name = "lblTaylorBet";
            this.lblTaylorBet.Size = new System.Drawing.Size(163, 16);
            this.lblTaylorBet.TabIndex = 13;
            this.lblTaylorBet.Text = "Taylor hasn\'t placed a bet";
            // 
            // lblBetter
            // 
            this.lblBetter.AutoSize = true;
            this.lblBetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetter.Location = new System.Drawing.Point(50, 394);
            this.lblBetter.Name = "lblBetter";
            this.lblBetter.Size = new System.Drawing.Size(44, 20);
            this.lblBetter.TabIndex = 14;
            this.lblBetter.Text = "Zack";
            // 
            // btnBet
            // 
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.Location = new System.Drawing.Point(107, 391);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 15;
            this.btnBet.Text = "Bets";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "dollars on ";
            // 
            // btnRace
            // 
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.Location = new System.Drawing.Point(591, 377);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(116, 44);
            this.btnRace.TabIndex = 18;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(680, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Day Break";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(680, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Lightning\'s Revenge";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(680, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Mytosis";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(683, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Sleeping Sycamore";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblZack
            // 
            this.lblZack.AutoSize = true;
            this.lblZack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZack.Location = new System.Drawing.Point(51, 300);
            this.lblZack.Name = "lblZack";
            this.lblZack.Size = new System.Drawing.Size(0, 16);
            this.lblZack.TabIndex = 23;
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNick.Location = new System.Drawing.Point(51, 324);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(0, 16);
            this.lblNick.TabIndex = 24;
            this.lblNick.Click += new System.EventHandler(this.lblNick_Click);
            // 
            // lblTaylor
            // 
            this.lblTaylor.AutoSize = true;
            this.lblTaylor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaylor.Location = new System.Drawing.Point(51, 347);
            this.lblTaylor.Name = "lblTaylor";
            this.lblTaylor.Size = new System.Drawing.Size(0, 16);
            this.lblTaylor.TabIndex = 25;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(197, 392);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 26;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Day Break",
            "Lightning\'s Revenge",
            "Mytosis",
            "Sleeping Sycamore"});
            this.comboBox1.Location = new System.Drawing.Point(400, 390);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Text = "Day Break";
            // 
            // lblOdds
            // 
            this.lblOdds.AutoSize = true;
            this.lblOdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdds.Location = new System.Drawing.Point(795, 3);
            this.lblOdds.Name = "lblOdds";
            this.lblOdds.Size = new System.Drawing.Size(190, 20);
            this.lblOdds.TabIndex = 28;
            this.lblOdds.Text = "Odds for Current Race";
            this.lblOdds.Click += new System.EventHandler(this.lblOdds_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Day_At_The_Races.Properties.Resources.dog__1_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(72, 179);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 28);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Day_At_The_Races.Properties.Resources.dog__1_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(72, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 28);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Day_At_The_Races.Properties.Resources.dog__1_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(72, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 28);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Day_At_The_Races.Properties.Resources.dog__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(72, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 28);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.BackgroundImage = global::Day_At_The_Races.Properties.Resources.racetrack__1_;
            this.racetrackPictureBox.Location = new System.Drawing.Point(72, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(602, 205);
            this.racetrackPictureBox.TabIndex = 0;
            this.racetrackPictureBox.TabStop = false;
            // 
            // lblDBOdds
            // 
            this.lblDBOdds.AutoSize = true;
            this.lblDBOdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBOdds.Location = new System.Drawing.Point(852, 34);
            this.lblDBOdds.Name = "lblDBOdds";
            this.lblDBOdds.Size = new System.Drawing.Size(51, 16);
            this.lblDBOdds.TabIndex = 29;
            this.lblDBOdds.Text = "label4";
            this.lblDBOdds.Click += new System.EventHandler(this.dbOddsAgainst_Click);
            // 
            // LROdds
            // 
            this.LROdds.AutoSize = true;
            this.LROdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LROdds.Location = new System.Drawing.Point(852, 79);
            this.LROdds.Name = "LROdds";
            this.LROdds.Size = new System.Drawing.Size(41, 13);
            this.LROdds.TabIndex = 30;
            this.LROdds.Text = "label5";
            // 
            // MOdds
            // 
            this.MOdds.AutoSize = true;
            this.MOdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOdds.Location = new System.Drawing.Point(852, 132);
            this.MOdds.Name = "MOdds";
            this.MOdds.Size = new System.Drawing.Size(41, 13);
            this.MOdds.TabIndex = 31;
            this.MOdds.Text = "label6";
            // 
            // SSOdds
            // 
            this.SSOdds.AutoSize = true;
            this.SSOdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSOdds.Location = new System.Drawing.Point(852, 183);
            this.SSOdds.Name = "SSOdds";
            this.SSOdds.Size = new System.Drawing.Size(41, 13);
            this.SSOdds.TabIndex = 32;
            this.SSOdds.Text = "label7";
            this.SSOdds.Click += new System.EventHandler(this.SSOdds_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1023, 458);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SSOdds);
            this.Controls.Add(this.MOdds);
            this.Controls.Add(this.LROdds);
            this.Controls.Add(this.lblDBOdds);
            this.Controls.Add(this.lblOdds);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.lblTaylor);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.lblZack);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.lblBetter);
            this.Controls.Add(this.lblTaylorBet);
            this.Controls.Add(this.lblNickBet);
            this.Controls.Add(this.lblZackBet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbtnTaylor);
            this.Controls.Add(this.rdbtnNick);
            this.Controls.Add(this.rdbtnZack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racetrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
        private RadioButton rdbtnZack;
        private RadioButton rdbtnNick;
        private RadioButton rdbtnTaylor;
        private Label label3;
        private Label lblZackBet;
        private Label lblNickBet;
        private Label lblTaylorBet;
        private Label lblBetter;
        private Button btnBet;
        private Label label8;
        private Button btnRace;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //dogsArray[0].Run();
            //dogsArray[1].Run();
            //dogsArray[2].Run();
            //dogsArray[3].Run();
            //  while (dogsArray[0].Run() == false && dogsArray[1].Run() == false && dogsArray[2].Run() == false && dogsArray[3].Run() == false)
            // {
            for (int i = 0; i < dogsArray.Length; i++)
            {

                dogsArray[i].Run();
                if (dogsArray[i].Run() == true)
                {
                    // dogsArray[i].Run() = true;
                    timer1.Stop();
                    timer1.Enabled = false;
                    MessageBox.Show(dogsArray[i].Name + " has won the race");
                    winningDog = dogsArray[i].Name;
                    i = dogsArray.Length;
                    btnRace.Enabled = true;
                    guyArray[0].Collect(winningDog);
                    guyArray[1].Collect(winningDog);
                    guyArray[2].Collect(winningDog);


                    // guyArray[0].ClearBet();
                    // guyArray[1].ClearBet();
                    // guyArray[2].ClearBet();
                }

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblNick_Click(object sender, EventArgs e)
        {

        }

        private void rdbtnZack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnZack.Enabled)
                lblBetter.Text = "Zack";
        }

        private void rdbtnNick_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnNick.Enabled)
                lblBetter.Text = "Nick";
        }

        private void rdbtnTaylor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnTaylor.Enabled)
                lblBetter.Text = "Taylor";
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString() == "Day Break")
                Test = dogsArray[0].oddsAgainst / dogsArray[0].oddsFor;
            if (comboBox1.Text.ToString() == "Lightning's Revenge")
                Test = dogsArray[1].oddsAgainst / dogsArray[1].oddsFor;
            if (comboBox1.Text.ToString() == "Mytosis")
                Test = dogsArray[2].oddsAgainst / dogsArray[2].oddsFor;
            if (comboBox1.Text.ToString() == "Sleeping Sycamore")
                Test = dogsArray[3].oddsAgainst / dogsArray[3].oddsFor;

            if (lblBetter.Text == "Zack")
            {
                if (zackBet == 0)
                {

                    Bet = guyArray[0].PlaceBet(Convert.ToInt16(numericUpDown2.Value), comboBox1.Text.ToString(), Test);
                    if (Bet == true)
                    {
                        zackBet = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Zack has already placed a bet.");
                }

            }
            if (lblBetter.Text == "Nick")
            {
                if (nickBet == 0)
                {
                    Bet = guyArray[1].PlaceBet(Convert.ToInt16(numericUpDown2.Value), comboBox1.Text.ToString(), Test);
                    if (Bet == true)
                    {
                        nickBet = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Nick has already placed a bet.");
                }

            }
            if (lblBetter.Text == "Taylor")
            {
                if (taylorBet == 0)
                {
                    Bet = guyArray[2].PlaceBet(Convert.ToInt16(numericUpDown2.Value), comboBox1.Text.ToString(), Test);
                    if (Bet == true)
                    {
                        taylorBet = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Taylor has already placed a bet.");
                }

            }
        }

        private void lblZackBet_Click(object sender, EventArgs e)
        {

        }

        private void lblOdds_Click(object sender, EventArgs e)
        {

        }

        private void dbOddsAgainst_Click(object sender, EventArgs e)
        {

        }

        private void lblNickBet_Click(object sender, EventArgs e)
        {

        }

        private void SSOdds_Click(object sender, EventArgs e)
        {

        }
    }
}




