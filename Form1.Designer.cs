namespace RNGGame_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player1Head = new System.Windows.Forms.PictureBox();
            this.player2Head = new System.Windows.Forms.PictureBox();
            this.player2Torso = new System.Windows.Forms.PictureBox();
            this.player2LeftLeg = new System.Windows.Forms.PictureBox();
            this.player2RightLeg = new System.Windows.Forms.PictureBox();
            this.player2LeftArm = new System.Windows.Forms.PictureBox();
            this.player2RightArm = new System.Windows.Forms.PictureBox();
            this.player1RightArm = new System.Windows.Forms.PictureBox();
            this.player1LeftArm = new System.Windows.Forms.PictureBox();
            this.player1RightLeg = new System.Windows.Forms.PictureBox();
            this.player1LeftLeg = new System.Windows.Forms.PictureBox();
            this.player1Torso = new System.Windows.Forms.PictureBox();
            this.attackingTitleLabel = new System.Windows.Forms.Label();
            this.playerTurnLabel = new System.Windows.Forms.Label();
            this.player1HPTitleLabel = new System.Windows.Forms.Label();
            this.player2HPTitleLabel = new System.Windows.Forms.Label();
            this.player1HPCountLabel = new System.Windows.Forms.Label();
            this.player2HPCountLabel = new System.Windows.Forms.Label();
            this.diceRollImage = new System.Windows.Forms.PictureBox();
            this.diceImagePanel = new System.Windows.Forms.Panel();
            this.player2DefendPanel = new System.Windows.Forms.Panel();
            this.player2DodgeButton = new System.Windows.Forms.Button();
            this.player2CounterButton = new System.Windows.Forms.Button();
            this.player2BlockButton = new System.Windows.Forms.Button();
            this.player1DefendPanel = new System.Windows.Forms.Panel();
            this.Player1DodgeButton = new System.Windows.Forms.Button();
            this.player1CounterButton = new System.Windows.Forms.Button();
            this.player1BlockButton = new System.Windows.Forms.Button();
            this.player1UpgradeSelectionPanel = new System.Windows.Forms.Panel();
            this.player1UpgradeChoice2Label = new System.Windows.Forms.Label();
            this.player1UpgradeChoice1Label = new System.Windows.Forms.Label();
            this.player1UpgradeSelectionLabel = new System.Windows.Forms.Label();
            this.player1UpgradeChoice1Image = new System.Windows.Forms.PictureBox();
            this.player1UpgradeChoice2Image = new System.Windows.Forms.PictureBox();
            this.player2UpgradeSelectionPanel = new System.Windows.Forms.Panel();
            this.player2UpgradeChoice2Label = new System.Windows.Forms.Label();
            this.player2UpgradeChoice1Label = new System.Windows.Forms.Label();
            this.player2UpgradeChoice2Image = new System.Windows.Forms.PictureBox();
            this.player2UpgradeChoice1Image = new System.Windows.Forms.PictureBox();
            this.player2UpgradeSelectionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1Head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Torso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2LeftLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2RightLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2LeftArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2RightArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1RightArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1LeftArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1RightLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1LeftLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Torso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceRollImage)).BeginInit();
            this.diceImagePanel.SuspendLayout();
            this.player2DefendPanel.SuspendLayout();
            this.player1DefendPanel.SuspendLayout();
            this.player1UpgradeSelectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1UpgradeChoice1Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1UpgradeChoice2Image)).BeginInit();
            this.player2UpgradeSelectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2UpgradeChoice2Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2UpgradeChoice1Image)).BeginInit();
            this.SuspendLayout();
            // 
            // player1Head
            // 
            this.player1Head.BackColor = System.Drawing.Color.MidnightBlue;
            this.player1Head.Location = new System.Drawing.Point(200, 54);
            this.player1Head.Name = "player1Head";
            this.player1Head.Size = new System.Drawing.Size(75, 75);
            this.player1Head.TabIndex = 0;
            this.player1Head.TabStop = false;
            this.player1Head.Click += new System.EventHandler(this.player1Head_Click);
            // 
            // player2Head
            // 
            this.player2Head.BackColor = System.Drawing.Color.Crimson;
            this.player2Head.Location = new System.Drawing.Point(525, 54);
            this.player2Head.Name = "player2Head";
            this.player2Head.Size = new System.Drawing.Size(75, 75);
            this.player2Head.TabIndex = 1;
            this.player2Head.TabStop = false;
            this.player2Head.Click += new System.EventHandler(this.player2Head_Click);
            // 
            // player2Torso
            // 
            this.player2Torso.BackColor = System.Drawing.Color.Crimson;
            this.player2Torso.Location = new System.Drawing.Point(513, 132);
            this.player2Torso.Name = "player2Torso";
            this.player2Torso.Size = new System.Drawing.Size(100, 100);
            this.player2Torso.TabIndex = 4;
            this.player2Torso.TabStop = false;
            this.player2Torso.Click += new System.EventHandler(this.player2Torso_Click);
            // 
            // player2LeftLeg
            // 
            this.player2LeftLeg.BackColor = System.Drawing.Color.Crimson;
            this.player2LeftLeg.Location = new System.Drawing.Point(513, 236);
            this.player2LeftLeg.Name = "player2LeftLeg";
            this.player2LeftLeg.Size = new System.Drawing.Size(30, 84);
            this.player2LeftLeg.TabIndex = 5;
            this.player2LeftLeg.TabStop = false;
            this.player2LeftLeg.Click += new System.EventHandler(this.player2LeftLeg_Click);
            // 
            // player2RightLeg
            // 
            this.player2RightLeg.BackColor = System.Drawing.Color.Crimson;
            this.player2RightLeg.Location = new System.Drawing.Point(583, 236);
            this.player2RightLeg.Name = "player2RightLeg";
            this.player2RightLeg.Size = new System.Drawing.Size(30, 84);
            this.player2RightLeg.TabIndex = 6;
            this.player2RightLeg.TabStop = false;
            this.player2RightLeg.Click += new System.EventHandler(this.player2RightLeg_Click);
            // 
            // player2LeftArm
            // 
            this.player2LeftArm.BackColor = System.Drawing.Color.Crimson;
            this.player2LeftArm.Location = new System.Drawing.Point(478, 132);
            this.player2LeftArm.Name = "player2LeftArm";
            this.player2LeftArm.Size = new System.Drawing.Size(30, 84);
            this.player2LeftArm.TabIndex = 7;
            this.player2LeftArm.TabStop = false;
            this.player2LeftArm.Click += new System.EventHandler(this.player2LeftArm_Click);
            // 
            // player2RightArm
            // 
            this.player2RightArm.BackColor = System.Drawing.Color.Crimson;
            this.player2RightArm.Location = new System.Drawing.Point(618, 132);
            this.player2RightArm.Name = "player2RightArm";
            this.player2RightArm.Size = new System.Drawing.Size(30, 84);
            this.player2RightArm.TabIndex = 8;
            this.player2RightArm.TabStop = false;
            this.player2RightArm.Click += new System.EventHandler(this.player2RightArm_Click);
            // 
            // player1RightArm
            // 
            this.player1RightArm.BackColor = System.Drawing.Color.MidnightBlue;
            this.player1RightArm.Location = new System.Drawing.Point(293, 132);
            this.player1RightArm.Name = "player1RightArm";
            this.player1RightArm.Size = new System.Drawing.Size(30, 84);
            this.player1RightArm.TabIndex = 13;
            this.player1RightArm.TabStop = false;
            this.player1RightArm.Click += new System.EventHandler(this.player1RightArm_Click);
            // 
            // player1LeftArm
            // 
            this.player1LeftArm.BackColor = System.Drawing.Color.MidnightBlue;
            this.player1LeftArm.Location = new System.Drawing.Point(153, 132);
            this.player1LeftArm.Name = "player1LeftArm";
            this.player1LeftArm.Size = new System.Drawing.Size(30, 84);
            this.player1LeftArm.TabIndex = 12;
            this.player1LeftArm.TabStop = false;
            this.player1LeftArm.Click += new System.EventHandler(this.player1LeftArm_Click);
            // 
            // player1RightLeg
            // 
            this.player1RightLeg.BackColor = System.Drawing.Color.MidnightBlue;
            this.player1RightLeg.Location = new System.Drawing.Point(258, 236);
            this.player1RightLeg.Name = "player1RightLeg";
            this.player1RightLeg.Size = new System.Drawing.Size(30, 84);
            this.player1RightLeg.TabIndex = 11;
            this.player1RightLeg.TabStop = false;
            this.player1RightLeg.Click += new System.EventHandler(this.player1RightLeg_Click);
            // 
            // player1LeftLeg
            // 
            this.player1LeftLeg.BackColor = System.Drawing.Color.MidnightBlue;
            this.player1LeftLeg.Location = new System.Drawing.Point(188, 236);
            this.player1LeftLeg.Name = "player1LeftLeg";
            this.player1LeftLeg.Size = new System.Drawing.Size(30, 84);
            this.player1LeftLeg.TabIndex = 10;
            this.player1LeftLeg.TabStop = false;
            this.player1LeftLeg.Click += new System.EventHandler(this.player1LeftLeg_Click);
            // 
            // player1Torso
            // 
            this.player1Torso.BackColor = System.Drawing.Color.MidnightBlue;
            this.player1Torso.Location = new System.Drawing.Point(188, 132);
            this.player1Torso.Name = "player1Torso";
            this.player1Torso.Size = new System.Drawing.Size(100, 100);
            this.player1Torso.TabIndex = 9;
            this.player1Torso.TabStop = false;
            this.player1Torso.Click += new System.EventHandler(this.player1Torso_Click);
            // 
            // attackingTitleLabel
            // 
            this.attackingTitleLabel.AutoSize = true;
            this.attackingTitleLabel.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackingTitleLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.attackingTitleLabel.Location = new System.Drawing.Point(272, 23);
            this.attackingTitleLabel.Name = "attackingTitleLabel";
            this.attackingTitleLabel.Size = new System.Drawing.Size(148, 27);
            this.attackingTitleLabel.TabIndex = 14;
            this.attackingTitleLabel.Text = "Attacking:";
            // 
            // playerTurnLabel
            // 
            this.playerTurnLabel.AutoSize = true;
            this.playerTurnLabel.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTurnLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.playerTurnLabel.Location = new System.Drawing.Point(412, 24);
            this.playerTurnLabel.Name = "playerTurnLabel";
            this.playerTurnLabel.Size = new System.Drawing.Size(119, 27);
            this.playerTurnLabel.TabIndex = 15;
            this.playerTurnLabel.Text = "Player 1";
            // 
            // player1HPTitleLabel
            // 
            this.player1HPTitleLabel.AutoSize = true;
            this.player1HPTitleLabel.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1HPTitleLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.player1HPTitleLabel.Location = new System.Drawing.Point(12, 23);
            this.player1HPTitleLabel.Name = "player1HPTitleLabel";
            this.player1HPTitleLabel.Size = new System.Drawing.Size(63, 27);
            this.player1HPTitleLabel.TabIndex = 16;
            this.player1HPTitleLabel.Text = "HP: ";
            // 
            // player2HPTitleLabel
            // 
            this.player2HPTitleLabel.AutoSize = true;
            this.player2HPTitleLabel.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2HPTitleLabel.ForeColor = System.Drawing.Color.Crimson;
            this.player2HPTitleLabel.Location = new System.Drawing.Point(668, 23);
            this.player2HPTitleLabel.Name = "player2HPTitleLabel";
            this.player2HPTitleLabel.Size = new System.Drawing.Size(63, 27);
            this.player2HPTitleLabel.TabIndex = 17;
            this.player2HPTitleLabel.Text = "HP: ";
            // 
            // player1HPCountLabel
            // 
            this.player1HPCountLabel.AutoSize = true;
            this.player1HPCountLabel.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1HPCountLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.player1HPCountLabel.Location = new System.Drawing.Point(81, 23);
            this.player1HPCountLabel.Name = "player1HPCountLabel";
            this.player1HPCountLabel.Size = new System.Drawing.Size(60, 27);
            this.player1HPCountLabel.TabIndex = 18;
            this.player1HPCountLabel.Text = "100";
            // 
            // player2HPCountLabel
            // 
            this.player2HPCountLabel.AutoSize = true;
            this.player2HPCountLabel.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2HPCountLabel.ForeColor = System.Drawing.Color.Crimson;
            this.player2HPCountLabel.Location = new System.Drawing.Point(728, 23);
            this.player2HPCountLabel.Name = "player2HPCountLabel";
            this.player2HPCountLabel.Size = new System.Drawing.Size(60, 27);
            this.player2HPCountLabel.TabIndex = 19;
            this.player2HPCountLabel.Text = "100";
            // 
            // diceRollImage
            // 
            this.diceRollImage.BackColor = System.Drawing.Color.Lavender;
            this.diceRollImage.Location = new System.Drawing.Point(22, 16);
            this.diceRollImage.Name = "diceRollImage";
            this.diceRollImage.Size = new System.Drawing.Size(100, 100);
            this.diceRollImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diceRollImage.TabIndex = 20;
            this.diceRollImage.TabStop = false;
            // 
            // diceImagePanel
            // 
            this.diceImagePanel.BackColor = System.Drawing.Color.Indigo;
            this.diceImagePanel.Controls.Add(this.diceRollImage);
            this.diceImagePanel.Location = new System.Drawing.Point(329, 116);
            this.diceImagePanel.Name = "diceImagePanel";
            this.diceImagePanel.Size = new System.Drawing.Size(143, 132);
            this.diceImagePanel.TabIndex = 21;
            // 
            // player2DefendPanel
            // 
            this.player2DefendPanel.BackColor = System.Drawing.Color.Crimson;
            this.player2DefendPanel.Controls.Add(this.player2DodgeButton);
            this.player2DefendPanel.Controls.Add(this.player2CounterButton);
            this.player2DefendPanel.Controls.Add(this.player2BlockButton);
            this.player2DefendPanel.Enabled = false;
            this.player2DefendPanel.Location = new System.Drawing.Point(417, 326);
            this.player2DefendPanel.Name = "player2DefendPanel";
            this.player2DefendPanel.Size = new System.Drawing.Size(371, 112);
            this.player2DefendPanel.TabIndex = 23;
            this.player2DefendPanel.Visible = false;
            // 
            // player2DodgeButton
            // 
            this.player2DodgeButton.Location = new System.Drawing.Point(266, 28);
            this.player2DodgeButton.Name = "player2DodgeButton";
            this.player2DodgeButton.Size = new System.Drawing.Size(93, 57);
            this.player2DodgeButton.TabIndex = 5;
            this.player2DodgeButton.Text = "Dodge";
            this.player2DodgeButton.UseVisualStyleBackColor = true;
            this.player2DodgeButton.Click += new System.EventHandler(this.player2DodgeButton_Click);
            // 
            // player2CounterButton
            // 
            this.player2CounterButton.Location = new System.Drawing.Point(142, 28);
            this.player2CounterButton.Name = "player2CounterButton";
            this.player2CounterButton.Size = new System.Drawing.Size(93, 57);
            this.player2CounterButton.TabIndex = 4;
            this.player2CounterButton.Text = "Counter";
            this.player2CounterButton.UseVisualStyleBackColor = true;
            this.player2CounterButton.Click += new System.EventHandler(this.player2CounterButton_Click);
            // 
            // player2BlockButton
            // 
            this.player2BlockButton.Location = new System.Drawing.Point(18, 28);
            this.player2BlockButton.Name = "player2BlockButton";
            this.player2BlockButton.Size = new System.Drawing.Size(93, 57);
            this.player2BlockButton.TabIndex = 3;
            this.player2BlockButton.Text = "Block";
            this.player2BlockButton.UseVisualStyleBackColor = true;
            this.player2BlockButton.Click += new System.EventHandler(this.player2BlockButton_Click);
            // 
            // player1DefendPanel
            // 
            this.player1DefendPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.player1DefendPanel.Controls.Add(this.Player1DodgeButton);
            this.player1DefendPanel.Controls.Add(this.player1CounterButton);
            this.player1DefendPanel.Controls.Add(this.player1BlockButton);
            this.player1DefendPanel.Enabled = false;
            this.player1DefendPanel.Location = new System.Drawing.Point(12, 326);
            this.player1DefendPanel.Name = "player1DefendPanel";
            this.player1DefendPanel.Size = new System.Drawing.Size(371, 112);
            this.player1DefendPanel.TabIndex = 23;
            this.player1DefendPanel.Visible = false;
            // 
            // Player1DodgeButton
            // 
            this.Player1DodgeButton.Location = new System.Drawing.Point(262, 28);
            this.Player1DodgeButton.Name = "Player1DodgeButton";
            this.Player1DodgeButton.Size = new System.Drawing.Size(93, 57);
            this.Player1DodgeButton.TabIndex = 2;
            this.Player1DodgeButton.Text = "Dodge";
            this.Player1DodgeButton.UseVisualStyleBackColor = true;
            this.Player1DodgeButton.Click += new System.EventHandler(this.Player1DodgeButton_Click);
            // 
            // player1CounterButton
            // 
            this.player1CounterButton.Location = new System.Drawing.Point(138, 28);
            this.player1CounterButton.Name = "player1CounterButton";
            this.player1CounterButton.Size = new System.Drawing.Size(93, 57);
            this.player1CounterButton.TabIndex = 1;
            this.player1CounterButton.Text = "Counter";
            this.player1CounterButton.UseVisualStyleBackColor = true;
            this.player1CounterButton.Click += new System.EventHandler(this.player1CounterButton_Click);
            // 
            // player1BlockButton
            // 
            this.player1BlockButton.Location = new System.Drawing.Point(14, 28);
            this.player1BlockButton.Name = "player1BlockButton";
            this.player1BlockButton.Size = new System.Drawing.Size(93, 57);
            this.player1BlockButton.TabIndex = 0;
            this.player1BlockButton.Text = "Block";
            this.player1BlockButton.UseVisualStyleBackColor = true;
            this.player1BlockButton.Click += new System.EventHandler(this.player1BlockButton_Click);
            // 
            // player1UpgradeSelectionPanel
            // 
            this.player1UpgradeSelectionPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.player1UpgradeSelectionPanel.Controls.Add(this.player1UpgradeChoice2Label);
            this.player1UpgradeSelectionPanel.Controls.Add(this.player1UpgradeChoice1Label);
            this.player1UpgradeSelectionPanel.Controls.Add(this.player1UpgradeSelectionLabel);
            this.player1UpgradeSelectionPanel.Controls.Add(this.player1UpgradeChoice1Image);
            this.player1UpgradeSelectionPanel.Controls.Add(this.player1UpgradeChoice2Image);
            this.player1UpgradeSelectionPanel.Enabled = false;
            this.player1UpgradeSelectionPanel.Location = new System.Drawing.Point(-2, 0);
            this.player1UpgradeSelectionPanel.Name = "player1UpgradeSelectionPanel";
            this.player1UpgradeSelectionPanel.Size = new System.Drawing.Size(803, 230);
            this.player1UpgradeSelectionPanel.TabIndex = 24;
            this.player1UpgradeSelectionPanel.Visible = false;
            // 
            // player1UpgradeChoice2Label
            // 
            this.player1UpgradeChoice2Label.BackColor = System.Drawing.Color.RoyalBlue;
            this.player1UpgradeChoice2Label.Location = new System.Drawing.Point(615, 62);
            this.player1UpgradeChoice2Label.Name = "player1UpgradeChoice2Label";
            this.player1UpgradeChoice2Label.Size = new System.Drawing.Size(150, 150);
            this.player1UpgradeChoice2Label.TabIndex = 4;
            // 
            // player1UpgradeChoice1Label
            // 
            this.player1UpgradeChoice1Label.BackColor = System.Drawing.Color.RoyalBlue;
            this.player1UpgradeChoice1Label.Location = new System.Drawing.Point(231, 62);
            this.player1UpgradeChoice1Label.Name = "player1UpgradeChoice1Label";
            this.player1UpgradeChoice1Label.Size = new System.Drawing.Size(150, 150);
            this.player1UpgradeChoice1Label.TabIndex = 3;
            // 
            // player1UpgradeSelectionLabel
            // 
            this.player1UpgradeSelectionLabel.AutoSize = true;
            this.player1UpgradeSelectionLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.player1UpgradeSelectionLabel.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1UpgradeSelectionLabel.Location = new System.Drawing.Point(240, 23);
            this.player1UpgradeSelectionLabel.Name = "player1UpgradeSelectionLabel";
            this.player1UpgradeSelectionLabel.Size = new System.Drawing.Size(318, 24);
            this.player1UpgradeSelectionLabel.TabIndex = 2;
            this.player1UpgradeSelectionLabel.Text = "Player 1 Upgrade Selection";
            // 
            // player1UpgradeChoice1Image
            // 
            this.player1UpgradeChoice1Image.BackColor = System.Drawing.Color.RoyalBlue;
            this.player1UpgradeChoice1Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player1UpgradeChoice1Image.BackgroundImage")));
            this.player1UpgradeChoice1Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player1UpgradeChoice1Image.Location = new System.Drawing.Point(75, 62);
            this.player1UpgradeChoice1Image.Name = "player1UpgradeChoice1Image";
            this.player1UpgradeChoice1Image.Size = new System.Drawing.Size(150, 150);
            this.player1UpgradeChoice1Image.TabIndex = 1;
            this.player1UpgradeChoice1Image.TabStop = false;
            this.player1UpgradeChoice1Image.Click += new System.EventHandler(this.player1UpgradeChoice1Image_Click);
            // 
            // player1UpgradeChoice2Image
            // 
            this.player1UpgradeChoice2Image.BackColor = System.Drawing.Color.RoyalBlue;
            this.player1UpgradeChoice2Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player1UpgradeChoice2Image.BackgroundImage")));
            this.player1UpgradeChoice2Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player1UpgradeChoice2Image.Location = new System.Drawing.Point(459, 62);
            this.player1UpgradeChoice2Image.Name = "player1UpgradeChoice2Image";
            this.player1UpgradeChoice2Image.Size = new System.Drawing.Size(150, 150);
            this.player1UpgradeChoice2Image.TabIndex = 0;
            this.player1UpgradeChoice2Image.TabStop = false;
            this.player1UpgradeChoice2Image.Click += new System.EventHandler(this.player1UpgradeChoice2Image_Click);
            // 
            // player2UpgradeSelectionPanel
            // 
            this.player2UpgradeSelectionPanel.BackColor = System.Drawing.Color.Crimson;
            this.player2UpgradeSelectionPanel.Controls.Add(this.player2UpgradeChoice2Label);
            this.player2UpgradeSelectionPanel.Controls.Add(this.player2UpgradeChoice1Label);
            this.player2UpgradeSelectionPanel.Controls.Add(this.player2UpgradeChoice2Image);
            this.player2UpgradeSelectionPanel.Controls.Add(this.player2UpgradeChoice1Image);
            this.player2UpgradeSelectionPanel.Controls.Add(this.player2UpgradeSelectionLabel);
            this.player2UpgradeSelectionPanel.Enabled = false;
            this.player2UpgradeSelectionPanel.Location = new System.Drawing.Point(-2, 222);
            this.player2UpgradeSelectionPanel.Name = "player2UpgradeSelectionPanel";
            this.player2UpgradeSelectionPanel.Size = new System.Drawing.Size(803, 229);
            this.player2UpgradeSelectionPanel.TabIndex = 25;
            this.player2UpgradeSelectionPanel.Visible = false;
            // 
            // player2UpgradeChoice2Label
            // 
            this.player2UpgradeChoice2Label.BackColor = System.Drawing.Color.PaleVioletRed;
            this.player2UpgradeChoice2Label.Location = new System.Drawing.Point(615, 63);
            this.player2UpgradeChoice2Label.Name = "player2UpgradeChoice2Label";
            this.player2UpgradeChoice2Label.Size = new System.Drawing.Size(150, 150);
            this.player2UpgradeChoice2Label.TabIndex = 6;
            // 
            // player2UpgradeChoice1Label
            // 
            this.player2UpgradeChoice1Label.BackColor = System.Drawing.Color.PaleVioletRed;
            this.player2UpgradeChoice1Label.Location = new System.Drawing.Point(231, 63);
            this.player2UpgradeChoice1Label.Name = "player2UpgradeChoice1Label";
            this.player2UpgradeChoice1Label.Size = new System.Drawing.Size(150, 150);
            this.player2UpgradeChoice1Label.TabIndex = 5;
            // 
            // player2UpgradeChoice2Image
            // 
            this.player2UpgradeChoice2Image.BackColor = System.Drawing.Color.PaleVioletRed;
            this.player2UpgradeChoice2Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player2UpgradeChoice2Image.Location = new System.Drawing.Point(459, 63);
            this.player2UpgradeChoice2Image.Name = "player2UpgradeChoice2Image";
            this.player2UpgradeChoice2Image.Size = new System.Drawing.Size(150, 150);
            this.player2UpgradeChoice2Image.TabIndex = 4;
            this.player2UpgradeChoice2Image.TabStop = false;
            this.player2UpgradeChoice2Image.Click += new System.EventHandler(this.player2UpgradeChoice2Image_Click);
            // 
            // player2UpgradeChoice1Image
            // 
            this.player2UpgradeChoice1Image.BackColor = System.Drawing.Color.PaleVioletRed;
            this.player2UpgradeChoice1Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player2UpgradeChoice1Image.Location = new System.Drawing.Point(75, 63);
            this.player2UpgradeChoice1Image.Name = "player2UpgradeChoice1Image";
            this.player2UpgradeChoice1Image.Size = new System.Drawing.Size(150, 150);
            this.player2UpgradeChoice1Image.TabIndex = 3;
            this.player2UpgradeChoice1Image.TabStop = false;
            this.player2UpgradeChoice1Image.Click += new System.EventHandler(this.Player2UpgradeChoice1Image_Click);
            // 
            // player2UpgradeSelectionLabel
            // 
            this.player2UpgradeSelectionLabel.AutoSize = true;
            this.player2UpgradeSelectionLabel.BackColor = System.Drawing.Color.PaleVioletRed;
            this.player2UpgradeSelectionLabel.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2UpgradeSelectionLabel.Location = new System.Drawing.Point(240, 29);
            this.player2UpgradeSelectionLabel.Name = "player2UpgradeSelectionLabel";
            this.player2UpgradeSelectionLabel.Size = new System.Drawing.Size(318, 24);
            this.player2UpgradeSelectionLabel.TabIndex = 2;
            this.player2UpgradeSelectionLabel.Text = "Player 2 Upgrade Selection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player1UpgradeSelectionPanel);
            this.Controls.Add(this.player2HPCountLabel);
            this.Controls.Add(this.player1HPCountLabel);
            this.Controls.Add(this.player2UpgradeSelectionPanel);
            this.Controls.Add(this.player2HPTitleLabel);
            this.Controls.Add(this.player1HPTitleLabel);
            this.Controls.Add(this.playerTurnLabel);
            this.Controls.Add(this.attackingTitleLabel);
            this.Controls.Add(this.player1RightArm);
            this.Controls.Add(this.player1LeftArm);
            this.Controls.Add(this.player1RightLeg);
            this.Controls.Add(this.player1LeftLeg);
            this.Controls.Add(this.player1Torso);
            this.Controls.Add(this.player2RightArm);
            this.Controls.Add(this.player2LeftArm);
            this.Controls.Add(this.player2RightLeg);
            this.Controls.Add(this.player2LeftLeg);
            this.Controls.Add(this.player2Torso);
            this.Controls.Add(this.player2Head);
            this.Controls.Add(this.player1Head);
            this.Controls.Add(this.diceImagePanel);
            this.Controls.Add(this.player1DefendPanel);
            this.Controls.Add(this.player2DefendPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player1Head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Torso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2LeftLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2RightLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2LeftArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2RightArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1RightArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1LeftArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1RightLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1LeftLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Torso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceRollImage)).EndInit();
            this.diceImagePanel.ResumeLayout(false);
            this.player2DefendPanel.ResumeLayout(false);
            this.player1DefendPanel.ResumeLayout(false);
            this.player1UpgradeSelectionPanel.ResumeLayout(false);
            this.player1UpgradeSelectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1UpgradeChoice1Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1UpgradeChoice2Image)).EndInit();
            this.player2UpgradeSelectionPanel.ResumeLayout(false);
            this.player2UpgradeSelectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2UpgradeChoice2Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2UpgradeChoice1Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1Head;
        private System.Windows.Forms.PictureBox player2Head;
        private System.Windows.Forms.PictureBox player2Torso;
        private System.Windows.Forms.PictureBox player2LeftLeg;
        private System.Windows.Forms.PictureBox player2RightLeg;
        private System.Windows.Forms.PictureBox player2LeftArm;
        private System.Windows.Forms.PictureBox player2RightArm;
        private System.Windows.Forms.PictureBox player1RightArm;
        private System.Windows.Forms.PictureBox player1LeftArm;
        private System.Windows.Forms.PictureBox player1RightLeg;
        private System.Windows.Forms.PictureBox player1LeftLeg;
        private System.Windows.Forms.PictureBox player1Torso;
        private System.Windows.Forms.Label attackingTitleLabel;
        private System.Windows.Forms.Label playerTurnLabel;
        private System.Windows.Forms.Label player1HPTitleLabel;
        private System.Windows.Forms.Label player2HPTitleLabel;
        private System.Windows.Forms.Label player1HPCountLabel;
        private System.Windows.Forms.Label player2HPCountLabel;
        private System.Windows.Forms.PictureBox diceRollImage;
        private System.Windows.Forms.Panel diceImagePanel;
        private System.Windows.Forms.Panel player2DefendPanel;
        private System.Windows.Forms.Panel player1DefendPanel;
        private System.Windows.Forms.Button player2DodgeButton;
        private System.Windows.Forms.Button player2CounterButton;
        private System.Windows.Forms.Button player2BlockButton;
        private System.Windows.Forms.Button Player1DodgeButton;
        private System.Windows.Forms.Button player1CounterButton;
        private System.Windows.Forms.Button player1BlockButton;
        private System.Windows.Forms.Panel player1UpgradeSelectionPanel;
        private System.Windows.Forms.PictureBox player1UpgradeChoice2Image;
        private System.Windows.Forms.Label player1UpgradeSelectionLabel;
        private System.Windows.Forms.PictureBox player1UpgradeChoice1Image;
        private System.Windows.Forms.Panel player2UpgradeSelectionPanel;
        private System.Windows.Forms.Label player2UpgradeSelectionLabel;
        private System.Windows.Forms.PictureBox player2UpgradeChoice2Image;
        private System.Windows.Forms.PictureBox player2UpgradeChoice1Image;
        private System.Windows.Forms.Label player1UpgradeChoice2Label;
        private System.Windows.Forms.Label player1UpgradeChoice1Label;
        private System.Windows.Forms.Label player2UpgradeChoice2Label;
        private System.Windows.Forms.Label player2UpgradeChoice1Label;
    }
}

