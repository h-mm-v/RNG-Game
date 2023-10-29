
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNGGame_2
{
    public partial class Form1 : Form
    {
        //Variables
        Image unknown = new Bitmap("unknown.png");
        Image swordImg = new Bitmap("sword.png");
        Image knucklesImg = new Bitmap("knuckles.png");
        Image prayerImg = new Bitmap("prayer.png");
        Image criticalImg = new Bitmap("critical.png");
        Image helmetImg = new Bitmap("helmet.png");
        Image PPImg = new Bitmap("rapier.png");
        Image haloImg = new Bitmap("halo.png");
        Image greatswordImg = new Bitmap("greatsword.png");
        Image SEImg = new Bitmap("SE.png");
        Image LSImg = new Bitmap("LS.png");
        Image GAImg = new Bitmap("apple.png");
        Image shieldImg = new Bitmap("shield.png");
        Image blessingImg = new Bitmap("blessing.png");
        Image operatorImg = new Bitmap("operator.png");
        Image eyeImg = new Bitmap("eye.png");
        Image sacDaggerImg = new Bitmap("sacDagger.png");
        Image PRImg = new Bitmap("rapier.png");
        Image sheriffImg = new Bitmap("sheriff.png");

        int player1BaseAttack = 0;
        int player2BaseAttack = 0;
        int player1AttackModifier = 0;
        int player2AttackModifier = 0;
        int player1TotalAttack = 0;
        int player2TotalAttack = 0;
        int player1AttackTarget = 0; // 1. Head, 2. Torso, 3. Left Arm, 4. Right Arm, 5. Left Leg, 6. Right Leg
        int player2AttackTarget = 0; // 1. Head, 2. Torso, 3. Left Arm, 4. Right Arm, 5. Left Leg, 6. Right Leg
        int player1CounterRoll = 0;
        int player2CounterRoll = 0;
        int player1DodgeRoll = 0;
        int player2DodgeRoll = 0;

        bool player1Sword = false;
        bool player2Sword = false;
        bool player1Knuckles = false;
        bool player2Knuckles = false;
        bool player1Prayer = false;
        bool player2Prayer = false;
        bool player1Critical = false;
        bool player2Critical = false;
        bool player1Helmet = false;
        bool player2Helmet = false;
        bool player1PP = false;
        bool player2PP = false;

        bool player1Halo = false;
        bool player2Halo = false;
        bool player1Greatsword = false;
        bool player2Greatsword = false;
        bool player1SE = false;
        bool player2SE = false;
        bool player1LS = false;
        bool player2LS = false;
        bool player1GA = false;
        bool player2GA = false;
        bool player1Shield = false;
        bool player2Shield = false;

        bool player1Blessing = false;
        bool player2Blessing = false;
        bool player1Op = false;
        bool player2Op = false;
        bool player1Eye = false;
        bool player2Eye = false;
        bool player1SacDagger = false;
        bool player2SacDagger = false;
        bool player1PR = false;
        bool player2PR = false;
        bool player1Sheriff = false;
        bool player2Sheriff = false;


        int player1HPCount = 100;
        int player2HPCount = 100;
        bool player1LeftArmCripple = false;
        bool player1RightArmCripple = false;
        bool player1LeftLegCripple = false;
        bool player1RightLegCripple = false;
        bool player2LeftArmCripple = false;
        bool player2RightArmCripple = false;
        bool player2LeftLegCripple = false;
        bool player2RightLegCripple = false;

        int player1upgradeChoice1;
        int player1upgradeChoice2;
        int player2upgradeChoice1;
        int player2upgradeChoice2;

        int combatCount = 1;
        int player1VictoryCount = 0;
        int player2VictoryCount = 0;
        bool player1Attacking = true;
        bool alreadyAttacking = false;
        //Declare DiceRoller Class
        DiceRoller roll = new DiceRoller();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult tutorialChoice = MessageBox.Show("Welcome to the second RNG Game! Before you start, would you like a rundown of how to play?", "Introduction", MessageBoxButtons.YesNo);
            switch (tutorialChoice)
            {
                case DialogResult.Yes:
                    MessageBox.Show("The attacking player chooses a body part to strike while the defending player picks from the 3 options of block, counter, and defend. The player whose HP reaches 0 or is decapitated loses.\n\n" +
                        "When attacking, roll a six sided dice to determine the base damage dealt. This is then added with any modifiers from upgrades to determine the damage dealt. If targetting the head, a total damage of 12 or above will instantly result in a victory. If targetting the torso, the attack deals 5 extra damage, and if targetting a limb, a total damage of 8 or more results in an extra attack.\n\n" +
                        "When defending, you can choose from 3 options. Block halves the damage taken. Counter rolls a 6 sided dice to contest the attack. If you roll lower, you take the original damage along with the damage of your roll. If they are equal, neither side takes damage, and if you roll higher, you take no damage while dealing your roll's damage to the attacker. Finally, dodge works the same as counter, but you take no extra damage on a fail and deal no extra damage on a success.");
                    MessageBox.Show("The first round begins with player 1 attacking. Player 1, please choose a target by clicking on the diagram.");
                    break;
                case DialogResult.No:
                    MessageBox.Show("The first round begins with player 1 attacking. Player 1, please choose a target by clicking on the diagram.");
                    break;
            }
            CombatUpgradeSelection();
        }
        //Functions
        private void Player1AttackingDamageCalculation()
        {
            player2HPCount -= player1TotalAttack;
            player2HPCountLabel.Text = player2HPCount.ToString();
            player1AttackModifier = 0;
            player1Attacking = false;
            playerTurnLabel.Text = "Player 2";
            attackingTitleLabel.ForeColor = Color.Crimson;
            playerTurnLabel.ForeColor = Color.Crimson;
            player2DefendPanel.Enabled = false;
            player2DefendPanel.Visible = false;
            if (player1GA == true)
            {
                player1HPCount += 3;
                player1HPCountLabel.Text = player1HPCount.ToString();
                MessageBox.Show("Player 1's Golden Apple has healed them for 3 HP", "GA Proc.");
            }
            if (player2GA == true)
            {
                player2HPCount += 3;
                player2HPCountLabel.Text = player2HPCount.ToString();
                MessageBox.Show("Player 2's Golden Apple has healed them for 3 HP", "GA Proc.");
            }
            alreadyAttacking = false;
            player1TotalAttack = 0;
            player1BaseAttack = 0;
            player2TotalAttack = 0;
            player2BaseAttack = 0;
        }
        private void Player2AttackingDamageCalculation()
        {
            player1HPCount -= player2TotalAttack;
            player1HPCountLabel.Text = player1HPCount.ToString();
            player2AttackModifier = 0;
            player1Attacking = true;
            playerTurnLabel.Text = "Player 1";
            attackingTitleLabel.ForeColor = Color.MidnightBlue;
            playerTurnLabel.ForeColor = Color.MidnightBlue;
            player1DefendPanel.Enabled = false;
            player1DefendPanel.Visible = false;
            if (player1GA == true)
            {
                player1HPCount += 3;
                player1HPCountLabel.Text = player1HPCount.ToString();
                MessageBox.Show("Player 1's Golden Apple has healed them for 3 HP", "GA Proc.");
            }
            if (player2GA == true)
            {
                player2HPCount += 3;
                player2HPCountLabel.Text = player2HPCount.ToString();
                MessageBox.Show("Player 2's Golden Apple has healed them for 3 HP", "GA Proc.");
            }
            alreadyAttacking = false;
            player1TotalAttack = 0;
            player1BaseAttack = 0;
            player2TotalAttack = 0;
            player2BaseAttack = 0;
        }

        private void CombatUpgradeSelection()
        {
            player1UpgradeSelectionPanel.Enabled = true;
            player1UpgradeSelectionPanel.Visible = true;
            player2UpgradeSelectionPanel.Enabled = true;
            player2UpgradeSelectionPanel.Visible = true;
            switch (combatCount)
            {
                case 1:
                    player1upgradeChoice1 = roll.Rolld6();
                    player1upgradeChoice2 = roll.Rolld6();
                    while (player1upgradeChoice2 == player1upgradeChoice1)
                    {
                        player1upgradeChoice2 = roll.Rolld6(); //failsafe for dupes
                    }
                    player2upgradeChoice1 = roll.Rolld6();
                    player2upgradeChoice2 = roll.Rolld6();
                    while (player2upgradeChoice2 == player2upgradeChoice1)
                    {
                        player2upgradeChoice2 = roll.Rolld6(); //failsafe for dupes
                    }
                    switch (player1upgradeChoice1)
                    {
                        case 1:
                            player1UpgradeChoice1Label.Text = "Sword: Increase damage dealt with each attack by a d8 (1-8)";
                            player1UpgradeChoice1Image.BackgroundImage = swordImg;
                            break;
                        case 2:
                            player1UpgradeChoice1Label.Text = "Brass Knuckles: Increase damage dealt with each attack by 2d4 (2-8)";
                            player1UpgradeChoice1Image.BackgroundImage = knucklesImg;
                            break;
                        case 3:
                            player1UpgradeChoice1Label.Text = "Prayer: Survive death once per combat and restore 15 HP";
                            player1UpgradeChoice1Image.BackgroundImage = prayerImg;
                            break;
                        case 4:
                            player1UpgradeChoice1Label.Text = "Critical: If you roll a 6 on the base attack dice (d6), deal 10 base damage rather than 6";
                            player1UpgradeChoice1Image.BackgroundImage = criticalImg;
                            break;
                        case 5:
                            player1UpgradeChoice1Label.Text = "Helmet: Gain 25 base HP";
                            player1UpgradeChoice1Image.BackgroundImage = helmetImg;
                            break;
                        case 6:
                            player1UpgradeChoice1Label.Text = "Piercing Point: Torso attacks deal an extra 8 damage rather than 5";
                            player1UpgradeChoice1Image.BackgroundImage = PPImg;
                            break;
                    }
                    switch (player1upgradeChoice2)
                    {
                        case 1:
                            player1UpgradeChoice2Label.Text = "Sword: Increase damage dealt with each attack by a d8 (1-8)";
                            player1UpgradeChoice2Image.BackgroundImage = swordImg;
                            break;
                        case 2:
                            player1UpgradeChoice2Label.Text = "Brass Knuckles: Increase damage dealt with each attack by 2d4 (2-8)";
                            player1UpgradeChoice2Image.BackgroundImage = knucklesImg;
                            break;
                        case 3:
                            player1UpgradeChoice2Label.Text = "Prayer: Survive death once per combat and restore 15 HP";
                            player1UpgradeChoice2Image.BackgroundImage = prayerImg;
                            break;
                        case 4:
                            player1UpgradeChoice2Label.Text = "Critical: If you roll a 6 on the base attack dice (d6), deal 10 base damage rather than 6";
                            player1UpgradeChoice2Image.BackgroundImage = criticalImg;
                            break;
                        case 5:
                            player1UpgradeChoice2Label.Text = "Helmet: Gain 25 base HP";
                            player1UpgradeChoice2Image.BackgroundImage = helmetImg;
                            break;
                        case 6:
                            player1UpgradeChoice2Label.Text = "Piercing Point: Torso attacks deal an extra 8 damage rather than 5";
                            player1UpgradeChoice2Image.BackgroundImage = PPImg;
                            break;
                    }
                    switch (player2upgradeChoice1)
                    {
                        case 1:
                            player2UpgradeChoice1Label.Text = "Sword: Increase damage dealt with each attack by a d8 (1-8)";
                            player2UpgradeChoice1Image.BackgroundImage = swordImg;
                            break;
                        case 2:
                            player2UpgradeChoice1Label.Text = "Brass Knuckles: Increase damage dealt with each attack by 2d4 (2-8)";
                            player2UpgradeChoice1Image.BackgroundImage = knucklesImg;
                            break;
                        case 3:
                            player2UpgradeChoice1Label.Text = "Prayer: Survive death once per combat and restore 15 HP";
                            player2UpgradeChoice1Image.BackgroundImage = prayerImg;
                            break;
                        case 4:
                            player2UpgradeChoice1Label.Text = "Critical: If you roll a 6 on the base attack dice (d6), deal 10 base damage rather than 6";
                            player2UpgradeChoice1Image.BackgroundImage = criticalImg;
                            break;
                        case 5:
                            player2UpgradeChoice1Label.Text = "Helmet: Gain 25 base HP";
                            player2UpgradeChoice1Image.BackgroundImage = helmetImg;
                            break;
                        case 6:
                            player2UpgradeChoice1Label.Text = "Piercing Point: Torso attacks deal an extra 8 damage rather than 5";
                            player2UpgradeChoice1Image.BackgroundImage = PPImg;
                            break;
                    }
                    switch (player2upgradeChoice2)
                    {
                        case 1:
                            player2UpgradeChoice2Label.Text = "Sword: Increase damage dealt with each attack by a d8 (1-8)";
                            player2UpgradeChoice2Image.BackgroundImage = swordImg;
                            break;
                        case 2:
                            player2UpgradeChoice2Label.Text = "Brass Knuckles: Increase damage dealt with each attack by 2d4 (2-8)";
                            player2UpgradeChoice2Image.BackgroundImage = knucklesImg;
                            break;
                        case 3:
                            player2UpgradeChoice2Label.Text = "Prayer: Survive death once per combat and restore 15 HP";
                            player2UpgradeChoice2Image.BackgroundImage = prayerImg;
                            break;
                        case 4:
                            player2UpgradeChoice2Label.Text = "Critical: If you roll a 6 on the base attack dice (d6), deal 10 base damage rather than 6";
                            player2UpgradeChoice2Image.BackgroundImage = criticalImg;
                            break;
                        case 5:
                            player2UpgradeChoice2Label.Text = "Helmet: Gain 25 base HP";
                            player2UpgradeChoice2Image.BackgroundImage = helmetImg;
                            break;
                        case 6:
                            player2UpgradeChoice2Label.Text = "Piercing Point: Torso attacks deal an extra 8 damage rather than 5";
                            player2UpgradeChoice2Image.BackgroundImage = PPImg;
                            break;
                    }
                    break;
                case 2:
                    player1upgradeChoice1 = roll.Rolld6();
                    player1upgradeChoice2 = roll.Rolld6();
                    while (player1upgradeChoice2 == player1upgradeChoice1)
                    {
                        player1upgradeChoice2 = roll.Rolld6(); //failsafe for dupes
                    }
                    player2upgradeChoice1 = roll.Rolld6();
                    player2upgradeChoice2 = roll.Rolld6();
                    while (player2upgradeChoice2 == player2upgradeChoice1)
                    {
                        player2upgradeChoice2 = roll.Rolld6(); //failsafe for dupes
                    }
                    switch (player1upgradeChoice1)
                    {
                        case 1:
                            player1UpgradeChoice1Label.Text = "Halo: Survive being decapitated once per combat";
                            player1UpgradeChoice1Image.BackgroundImage = haloImg;
                            break;
                        case 2:
                            player1UpgradeChoice1Label.Text = "Greatsword: Increase damage dealt with each attack by 2d8";
                            player1UpgradeChoice1Image.BackgroundImage = greatswordImg;
                            break;
                        case 3:
                            player1UpgradeChoice1Label.Text = "Serrated Edge: If you cripple a limb, deal an extra 4 damage";
                            player1UpgradeChoice1Image.BackgroundImage = SEImg;
                            break;
                        case 4:
                            player1UpgradeChoice1Label.Text = "Lucky Shot: If you roll a 1 on the base attack dice (d6), deal 12 base damage rather than 1";
                            player1UpgradeChoice1Image.BackgroundImage = LSImg;
                            break;
                        case 5:
                            player1UpgradeChoice1Label.Text = "Golden Apple: Regenerate 3 HP per turn";
                            player1UpgradeChoice1Image.BackgroundImage = GAImg;
                            break;
                        case 6:
                            player1UpgradeChoice1Label.Text = "Shield: If you fail a counter, take no EXTRA damage";
                            player1UpgradeChoice1Image.BackgroundImage = shieldImg;
                            break;
                    }
                    switch (player1upgradeChoice2)
                    {
                        case 1:
                            player1UpgradeChoice2Label.Text = "Halo: Survive being decapitated once per combat";
                            player1UpgradeChoice2Image.BackgroundImage = haloImg;
                            break;
                        case 2:
                            player1UpgradeChoice2Label.Text = "Greatsword: Increase damage dealt with each attack by 2d8";
                            player1UpgradeChoice2Image.BackgroundImage = greatswordImg;
                            break;
                        case 3:
                            player1UpgradeChoice2Label.Text = "Serrated Edge: If you cripple a limb, deal an extra 4 damage";
                            player1UpgradeChoice2Image.BackgroundImage = SEImg;
                            break;
                        case 4:
                            player1UpgradeChoice2Label.Text = "Lucky Shot: If you roll a 1 on the base attack dice (d6), deal 12 base damage rather than 1";
                            player1UpgradeChoice2Image.BackgroundImage = LSImg;
                            break;
                        case 5:
                            player1UpgradeChoice2Label.Text = "Golden Apple: Regenerate 3 HP per turn";
                            player1UpgradeChoice2Image.BackgroundImage = GAImg;
                            break;
                        case 6:
                            player1UpgradeChoice2Label.Text = "Shield: If you fail a counter, take no EXTRA damage";
                            player1UpgradeChoice2Image.BackgroundImage = shieldImg;
                            break;
                    }
                    switch (player2upgradeChoice1)
                    {
                        case 1:
                            player2UpgradeChoice1Label.Text = "Halo: Survive being decapitated once per combat";
                            player2UpgradeChoice1Image.BackgroundImage = haloImg;
                            break;
                        case 2:
                            player2UpgradeChoice1Label.Text = "Greatsword: Increase damage dealt with each attack by 2d8";
                            player2UpgradeChoice1Image.BackgroundImage = greatswordImg;
                            break;
                        case 3:
                            player2UpgradeChoice1Label.Text = "Serrated Edge: If you cripple a limb, deal an extra 4 damage";
                            player2UpgradeChoice1Image.BackgroundImage = SEImg;
                            break;
                        case 4:
                            player2UpgradeChoice1Label.Text = "Lucky Shot: If you roll a 1 on the base attack dice (d6), deal 12 base damage rather than 1";
                            player2UpgradeChoice1Image.BackgroundImage = LSImg;
                            break;
                        case 5:
                            player2UpgradeChoice1Label.Text = "Golden Apple: Regenerate 3 HP per turn";
                            player2UpgradeChoice1Image.BackgroundImage = GAImg;
                            break;
                        case 6:
                            player2UpgradeChoice1Label.Text = "Shield: If you fail a counter, take no EXTRA damage";
                            player2UpgradeChoice1Image.BackgroundImage = shieldImg;
                            break;
                    }
                    switch (player2upgradeChoice2)
                    {
                        case 1:
                            player2UpgradeChoice2Label.Text = "Halo: Survive being decapitated once per combat";
                            player2UpgradeChoice2Image.BackgroundImage = haloImg;
                            break;
                        case 2:
                            player2UpgradeChoice2Label.Text = "Greatsword: Increase damage dealt with each attack by 2d8";
                            player2UpgradeChoice2Image.BackgroundImage = greatswordImg;
                            break;
                        case 3:
                            player2UpgradeChoice2Label.Text = "Serrated Edge: If you cripple a limb, deal an extra 4 damage";
                            player2UpgradeChoice2Image.BackgroundImage = SEImg;
                            break;
                        case 4:
                            player2UpgradeChoice2Label.Text = "Lucky Shot: If you roll a 1 on the base attack dice (d6), deal 12 base damage rather than 1";
                            player2UpgradeChoice2Image.BackgroundImage = LSImg;
                            break;
                        case 5:
                            player2UpgradeChoice2Label.Text = "Golden Apple: Regenerate 3 HP per turn";
                            player2UpgradeChoice2Image.BackgroundImage = GAImg;
                            break;
                        case 6:
                            player2UpgradeChoice2Label.Text = "Shield: If you fail a counter, take no EXTRA damage";
                            player2UpgradeChoice2Image.BackgroundImage = shieldImg;
                            break;
                    }
                    break;
                case 3:
                    player1upgradeChoice1 = roll.Rolld6();
                    player1upgradeChoice2 = roll.Rolld6();
                    while (player1upgradeChoice2 == player1upgradeChoice1)
                    {
                        player1upgradeChoice2 = roll.Rolld6(); //failsafe for dupes
                    }
                    player2upgradeChoice1 = roll.Rolld6();
                    player2upgradeChoice2 = roll.Rolld6();
                    while (player2upgradeChoice2 == player2upgradeChoice1)
                    {
                        player2upgradeChoice2 = roll.Rolld6(); //failsafe for dupes
                    }
                    switch (player1upgradeChoice1)
                    {
                        case 1:
                            player1UpgradeChoice1Label.Text = "Blessing: Survive a death once per combat and restore 35 HP";
                            player1UpgradeChoice1Image.BackgroundImage = blessingImg;
                            break;
                        case 2:
                            player1UpgradeChoice1Label.Text = "Operator (Weapon #4): Increase damage dealt by d20 (1-20)";
                            player1UpgradeChoice1Image.BackgroundImage = operatorImg;
                            break;
                        case 3:
                            player1UpgradeChoice1Label.Text = "Hawkeye: Dodge rolls the dice twice, then picks the higher one to act as your dodge roll";
                            player1UpgradeChoice1Image.BackgroundImage = eyeImg;
                            break;
                        case 4:
                            player1UpgradeChoice1Label.Text = "Sacrificial Dagger (Weapon #5): Increase damage dealt by 2d12, but take 6 damage on every attack";
                            player1UpgradeChoice1Image.BackgroundImage = sacDaggerImg;
                            break;
                        case 5:
                            player1UpgradeChoice1Label.Text = "Perfect Riposte: A successful counter deals double damage";
                            player1UpgradeChoice1Image.BackgroundImage = PRImg;
                            break;
                        case 6:
                            player1UpgradeChoice1Label.Text = "Sheriff: Lower the decapitate threshold to 8 damage.\r\n";
                            player1UpgradeChoice1Image.BackgroundImage = sheriffImg;
                            break;
                    }
                    switch (player1upgradeChoice2)
                    {
                        case 1:
                            player1UpgradeChoice2Label.Text = "Blessing: Survive a death once per combat and restore 35 HP";
                            player1UpgradeChoice2Image.BackgroundImage = blessingImg;
                            break;
                        case 2:
                            player1UpgradeChoice2Label.Text = "Operator (Weapon #4): Increase damage dealt by d20 (1-20)";
                            player1UpgradeChoice2Image.BackgroundImage = operatorImg;
                            break;
                        case 3:
                            player1UpgradeChoice2Label.Text = "Hawkeye: Dodge rolls the dice twice, then picks the higher one to act as your dodge roll";
                            player1UpgradeChoice2Image.BackgroundImage = eyeImg;
                            break;
                        case 4:
                            player1UpgradeChoice2Label.Text = "Sacrificial Dagger (Weapon #5): Increase damage dealt by 2d12, but take 6 damage on every attack";
                            player1UpgradeChoice2Image.BackgroundImage = sacDaggerImg;
                            break;
                        case 5:
                            player1UpgradeChoice2Label.Text = "Perfect Riposte: A successful counter deals double damage";
                            player1UpgradeChoice2Image.BackgroundImage = PRImg;
                            break;
                        case 6:
                            player1UpgradeChoice2Label.Text = "Sheriff: Lower the decapitate threshold to 8 damage.\r\n";
                            player1UpgradeChoice2Image.BackgroundImage = sheriffImg;
                            break;
                    }
                    switch (player2upgradeChoice1)
                    {
                        case 1:
                            player2UpgradeChoice1Label.Text = "Blessing: Survive a death once per combat and restore 35 HP";
                            player2UpgradeChoice1Image.BackgroundImage = blessingImg;
                            break;
                        case 2:
                            player2UpgradeChoice1Label.Text = "Operator (Weapon #4): Increase damage dealt by d20 (1-20)";
                            player2UpgradeChoice1Image.BackgroundImage = operatorImg;
                            break;
                        case 3:
                            player2UpgradeChoice1Label.Text = "Hawkeye: Dodge rolls the dice twice, then picks the higher one to act as your dodge roll";
                            player2UpgradeChoice1Image.BackgroundImage = eyeImg;
                            break;
                        case 4:
                            player2UpgradeChoice1Label.Text = "Sacrificial Dagger (Weapon #5): Increase damage dealt by 2d12, but take 6 damage on every attack";
                            player2UpgradeChoice1Image.BackgroundImage = sacDaggerImg;
                            break;
                        case 5:
                            player2UpgradeChoice1Label.Text = "Perfect Riposte: A successful counter deals double damage";
                            player2UpgradeChoice1Image.BackgroundImage = PRImg;
                            break;
                        case 6:
                            player2UpgradeChoice1Label.Text = "Sheriff: Lower the decapitate threshold to 8 damage.\r\n";
                            player2UpgradeChoice1Image.BackgroundImage = sheriffImg;
                            break;
                    }
                    switch (player2upgradeChoice2)
                    {
                        case 1:
                            player2UpgradeChoice2Label.Text = "Blessing: Survive a death once per combat and restore 35 HP";
                            player2UpgradeChoice2Image.BackgroundImage = blessingImg;
                            break;
                        case 2:
                            player2UpgradeChoice2Label.Text = "Operator (Weapon #4): Increase damage dealt by d20 (1-20)";
                            player2UpgradeChoice2Image.BackgroundImage = operatorImg;
                            break;
                        case 3:
                            player2UpgradeChoice2Label.Text = "Hawkeye: Dodge rolls the dice twice, then picks the higher one to act as your dodge roll";
                            player2UpgradeChoice2Image.BackgroundImage = eyeImg;
                            break;
                        case 4:
                            player2UpgradeChoice2Label.Text = "Sacrificial Dagger (Weapon #5): Increase damage dealt by 2d12, but take 6 damage on every attack";
                            player2UpgradeChoice2Image.BackgroundImage = sacDaggerImg;
                            break;
                        case 5:
                            player2UpgradeChoice2Label.Text = "Perfect Riposte: A successful counter deals double damage";
                            player2UpgradeChoice2Image.BackgroundImage = PRImg;
                            break;
                        case 6:
                            player2UpgradeChoice2Label.Text = "Sheriff: Lower the decapitate threshold to 8 damage.\r\n";
                            player2UpgradeChoice2Image.BackgroundImage = sheriffImg;
                            break;
                    }
                    break;
            }

        }

        private void VictoryCheck()
        {
            if (player2HPCount <= 0)
            {
                if (player2Prayer == true)
                {
                    MessageBox.Show("Player 2's prayer has procced", "Prayer Proc");
                    player2HPCount = 15;
                    player2HPCountLabel.Text = player2HPCount.ToString();
                    player2Prayer = false;
                }
                else if (player2Blessing == true)
                {
                    MessageBox.Show("Player 2's blessing has procced", "Blessing Proc");
                    player2HPCount = 40;
                    player2HPCountLabel.Text = player2HPCount.ToString();
                    player2Blessing = false;
                }
                else
                {
                    MessageBox.Show("Player 1 has won combat " + combatCount + "!");
                    combatCount++;
                    player1HPCount = 100;
                    if (player1Helmet == true)
                        player1HPCount += 25;
                    player1HPCountLabel.Text = player1HPCount.ToString();
                    player2HPCount = 100;
                    if (player2Helmet == true)
                        player2HPCount += 25;
                    player2HPCountLabel.Text = player2HPCount.ToString();
                    player1Attacking = true;
                    player1VictoryCount++;
                    CombatUpgradeSelection();
                }

            }
            if (player1HPCount <= 0)
            {
                if (player1Prayer == true)
                {
                    MessageBox.Show("Player 1's prayer has procced", "Prayer Proc");
                    player1HPCount = 15;
                    player1HPCountLabel.Text = player1HPCount.ToString();
                    player1Prayer = false;
                }
                else if (player1Blessing == true)
                {
                    MessageBox.Show("Player 1's blessing has procced", "Blessing Proc");
                    player1HPCount = 40;
                    player1HPCountLabel.Text = player1HPCount.ToString();
                    player1Blessing = false;
                }
                else
                {
                    MessageBox.Show("Player 2 has won combat " + combatCount + "!");
                    combatCount++;
                    player1HPCount = 100;
                    player1HPCountLabel.Text = player1HPCount.ToString();
                    player2HPCount = 100;
                    player2HPCountLabel.Text = player2HPCount.ToString();
                    player1Attacking = true;
                    player2VictoryCount++;
                    CombatUpgradeSelection();
                }
            }
            if (player1VictoryCount == 2)
            {
                MessageBox.Show("Player 1 wins!");
                this.Close();
            }
            if (player2VictoryCount == 2)
            {
                MessageBox.Show("Player 2 wins!");
                this.Close();
            }

        }

        private void player2Head_Click(object sender, EventArgs e)
        {
            if (alreadyAttacking == true)
            {
                MessageBox.Show("You are already attacking something.");
            }
            else
            {
                switch (player1Attacking)
                {
                    case true:
                        alreadyAttacking = true;
                        player1BaseAttack = roll.Rolld6();
                        diceRollImage.Image = roll.SetD6Image(player1BaseAttack);
                        if (player1BaseAttack == 6 && player1Critical == true)
                        {
                            player1BaseAttack = 10;
                            MessageBox.Show("Critical has increased your base attack to 10.", "Critical Proc.");
                        }
                        if (player1BaseAttack == 1 && player1LS == true)
                        {
                            player1BaseAttack = 12;
                            MessageBox.Show("Lucky Shot has increased your base attack to 12.", "Lucky Shot Proc.");
                        }
                        if (player1Sword == true)
                        {
                            int swordModifier = roll.Rolld8();
                            player1AttackModifier += swordModifier;
                            MessageBox.Show("Player 1's Sword has given player 1 " + swordModifier + " more damage.", "Sword Proc");
                        }
                        if (player1Knuckles == true)
                        {
                            int knuckleModifier1 = roll.Rolld4();
                            int knuckleModifier2 = roll.Rolld4();
                            player1AttackModifier += knuckleModifier1;
                            player1AttackModifier += knuckleModifier2;
                            MessageBox.Show("Player 1's knuckles have given player 1 " + knuckleModifier1 + " + " + knuckleModifier2 + " more damage.", "knuckle Proc");
                        }
                        if (player1Greatsword == true)
                        {
                            int greatswordModifier1 = roll.Rolld8();
                            int greatswordModifier2 = roll.Rolld8();
                            player1AttackModifier += greatswordModifier1;
                            player1AttackModifier += greatswordModifier2;
                            MessageBox.Show("Player 1's greatsword have given player 1 " + greatswordModifier1 + " + " + greatswordModifier2 + " more damage.", "Greatsword Proc");
                        }
                        if (player1Op == true)
                        {
                            int opModifier = roll.Rolld20();
                            player1AttackModifier += opModifier;
                            MessageBox.Show("Player 1's operator has given player 1 " + opModifier + " more damage.", "Operator Proc");
                        }
                        if (player1SacDagger == true)
                        {
                            int sacDaggerModifier1 = roll.Rolld12();
                            int sacDaggerModifier2 = roll.Rolld12();
                            player1AttackModifier += sacDaggerModifier1;
                            player1AttackModifier += sacDaggerModifier2;
                            player1HPCount -= 6;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            MessageBox.Show("Player 1's sacrificial dagger has given player 1 " + sacDaggerModifier1 + " + " + sacDaggerModifier2 + " more damage.", "Sacrificial Dagger Proc");
                        }
                        player1TotalAttack = player1BaseAttack + player1AttackModifier;
                        player1AttackTarget = 1;
                        player2DefendPanel.Enabled = true;
                        player2DefendPanel.Visible = true;
                        break;
                    case false:
                        MessageBox.Show("Player 1 is not attacking");
                        break;
                }
            }
        }
        private void player2Torso_Click(object sender, EventArgs e)
        {
            if (alreadyAttacking == true)
            {
                MessageBox.Show("You are already attacking something.");
            }
            else
            {
                switch (player1Attacking)
                {
                    case true:
                        alreadyAttacking = true;
                        player1BaseAttack = roll.Rolld6();
                        diceRollImage.Image = roll.SetD6Image(player1BaseAttack);
                        if (player1BaseAttack == 6 && player1Critical == true)
                        {
                            player1BaseAttack = 10;
                            MessageBox.Show("Critical has increased your base attack to 10.", "Critical Proc.");
                        }
                        if (player1BaseAttack == 1 && player1LS == true)
                        {
                            player1BaseAttack = 12;
                            MessageBox.Show("Lucky Shot has increased your base attack to 12.", "Lucky Shot Proc.");
                        }
                        if (player1Sword == true)
                        {
                            int swordModifier = roll.Rolld8();
                            player1AttackModifier += swordModifier;
                            MessageBox.Show("Player 1's Sword has given player 1 " + swordModifier + " more damage.", "Sword Proc");
                        }
                        if (player1Knuckles == true)
                        {
                            int knuckleModifier1 = roll.Rolld4();
                            int knuckleModifier2 = roll.Rolld4();
                            player1AttackModifier += knuckleModifier1;
                            player1AttackModifier += knuckleModifier2;
                            MessageBox.Show("Player 1's knuckles have given player 1 " + knuckleModifier1 + " + " + knuckleModifier2 + " more damage.", "knuckle Proc");
                        }
                        if (player1Greatsword == true)
                        {
                            int greatswordModifier1 = roll.Rolld8();
                            int greatswordModifier2 = roll.Rolld8();
                            player1AttackModifier += greatswordModifier1;
                            player1AttackModifier += greatswordModifier2;
                            MessageBox.Show("Player 1's greatsword have given player 1 " + greatswordModifier1 + " + " + greatswordModifier2 + " more damage.", "Greatsword Proc");
                        }
                        if (player1Op == true)
                        {
                            int opModifier = roll.Rolld20();
                            player1AttackModifier += opModifier;
                            MessageBox.Show("Player 1's operator has given player 1 " + opModifier + " more damage.", "Operator Proc");
                        }
                        if (player1SacDagger == true)
                        {
                            int sacDaggerModifier1 = roll.Rolld12();
                            int sacDaggerModifier2 = roll.Rolld12();
                            player1AttackModifier += sacDaggerModifier1;
                            player1AttackModifier += sacDaggerModifier2;
                            player1HPCount -= 6;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            MessageBox.Show("Player 1's sacrificial dagger has given player 1 " + sacDaggerModifier1 + " + " + sacDaggerModifier2 + " more damage.", "Sacrificial Dagger Proc");
                        }
                        player1TotalAttack = player1BaseAttack + player1AttackModifier;
                        player1AttackTarget = 2;
                        player2DefendPanel.Enabled = true;
                        player2DefendPanel.Visible = true;
                        break;
                    case false:
                        MessageBox.Show("Player 1 is not attacking");
                        break;
                }
            }
        }
        private void player2LeftArm_Click(object sender, EventArgs e)
        {
            if (alreadyAttacking == true)
            {
                MessageBox.Show("You are already attacking something.");
            }
            else
            {
                switch (player1Attacking)
                {
                    case true:
                        alreadyAttacking = true;
                        player1BaseAttack = roll.Rolld6();
                        diceRollImage.Image = roll.SetD6Image(player1BaseAttack);
                        if (player1BaseAttack == 6 && player1Critical == true)
                        {
                            player1BaseAttack = 10;
                            MessageBox.Show("Critical has increased your base attack to 10.", "Critical Proc.");
                        }
                        if (player1BaseAttack == 1 && player1LS == true)
                        {
                            player1BaseAttack = 12;
                            MessageBox.Show("Lucky Shot has increased your base attack to 12.", "Lucky Shot Proc.");
                        }
                        if (player1Sword == true)
                        {
                            int swordModifier = roll.Rolld8();
                            player1AttackModifier += swordModifier;
                            MessageBox.Show("Player 1's Sword has given player 1 " + swordModifier + " more damage.", "Sword Proc");
                        }
                        if (player1Knuckles == true)
                        {
                            int knuckleModifier1 = roll.Rolld4();
                            int knuckleModifier2 = roll.Rolld4();
                            player1AttackModifier += knuckleModifier1;
                            player1AttackModifier += knuckleModifier2;
                            MessageBox.Show("Player 1's knuckles have given player 1 " + knuckleModifier1 + " + " + knuckleModifier2 + " more damage.", "knuckle Proc");
                        }
                        if (player1Greatsword == true)
                        {
                            int greatswordModifier1 = roll.Rolld8();
                            int greatswordModifier2 = roll.Rolld8();
                            player1AttackModifier += greatswordModifier1;
                            player1AttackModifier += greatswordModifier2;
                            MessageBox.Show("Player 1's greatsword have given player 1 " + greatswordModifier1 + " + " + greatswordModifier2 + " more damage.", "Greatsword Proc");
                        }
                        if (player1Op == true)
                        {
                            int opModifier = roll.Rolld20();
                            player1AttackModifier += opModifier;
                            MessageBox.Show("Player 1's operator has given player 1 " + opModifier + " more damage.", "Operator Proc");
                        }
                        if (player1SacDagger == true)
                        {
                            int sacDaggerModifier1 = roll.Rolld12();
                            int sacDaggerModifier2 = roll.Rolld12();
                            player1AttackModifier += sacDaggerModifier1;
                            player1AttackModifier += sacDaggerModifier2;
                            player1HPCount -= 6;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            MessageBox.Show("Player 1's sacrificial dagger has given player 1 " + sacDaggerModifier1 + " + " + sacDaggerModifier2 + " more damage.", "Sacrificial Dagger Proc");
                        }
                        player1TotalAttack = player1BaseAttack + player1AttackModifier;
                        player1AttackTarget = 3;
                        player2DefendPanel.Enabled = true;
                        player2DefendPanel.Visible = true;
                        break;
                    case false:
                        MessageBox.Show("Player 1 is not attacking");
                        break;
                }
            }
        }
        private void player2RightArm_Click(object sender, EventArgs e)
        {
            if (alreadyAttacking == true)
            {
                MessageBox.Show("You are already attacking something.");
            }
            else
            {
                switch (player1Attacking)
                {
                    case true:
                        alreadyAttacking = true;
                        player1BaseAttack = roll.Rolld6();
                        diceRollImage.Image = roll.SetD6Image(player1BaseAttack);
                        if (player1BaseAttack == 6 && player1Critical == true)
                        {
                            player1BaseAttack = 10;
                            MessageBox.Show("Critical has increased your base attack to 10.", "Critical Proc.");
                        }
                        if (player1BaseAttack == 1 && player1LS == true)
                        {
                            player1BaseAttack = 12;
                            MessageBox.Show("Lucky Shot has increased your base attack to 12.", "Lucky Shot Proc.");
                        }
                        if (player1Sword == true)
                        {
                            int swordModifier = roll.Rolld8();
                            player1AttackModifier += swordModifier;
                            MessageBox.Show("Player 1's Sword has given player 1 " + swordModifier + " more damage.", "Sword Proc");
                        }
                        if (player1Knuckles == true)
                        {
                            int knuckleModifier1 = roll.Rolld4();
                            int knuckleModifier2 = roll.Rolld4();
                            player1AttackModifier += knuckleModifier1;
                            player1AttackModifier += knuckleModifier2;
                            MessageBox.Show("Player 1's knuckles have given player 1 " + knuckleModifier1 + " + " + knuckleModifier2 + " more damage.", "knuckle Proc");
                        }
                        if (player1Greatsword == true)
                        {
                            int greatswordModifier1 = roll.Rolld8();
                            int greatswordModifier2 = roll.Rolld8();
                            player1AttackModifier += greatswordModifier1;
                            player1AttackModifier += greatswordModifier2;
                            MessageBox.Show("Player 1's greatsword have given player 1 " + greatswordModifier1 + " + " + greatswordModifier2 + " more damage.", "Greatsword Proc");
                        }
                        if (player1Op == true)
                        {
                            int opModifier = roll.Rolld20();
                            player1AttackModifier += opModifier;
                            MessageBox.Show("Player 1's operator has given player 1 " + opModifier + " more damage.", "Operator Proc");
                        }
                        if (player1SacDagger == true)
                        {
                            int sacDaggerModifier1 = roll.Rolld12();
                            int sacDaggerModifier2 = roll.Rolld12();
                            player1AttackModifier += sacDaggerModifier1;
                            player1AttackModifier += sacDaggerModifier2;
                            player1HPCount -= 6;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            MessageBox.Show("Player 1's sacrificial dagger has given player 1 " + sacDaggerModifier1 + " + " + sacDaggerModifier2 + " more damage.", "Sacrificial Dagger Proc");
                        }
                        player1TotalAttack = player1BaseAttack + player1AttackModifier;
                        player1AttackTarget = 4;
                        player2DefendPanel.Enabled = true;
                        player2DefendPanel.Visible = true;
                        break;
                    case false:
                        MessageBox.Show("Player 1 is not attacking");
                        break;
                }
            }
        }
        private void player2LeftLeg_Click(object sender, EventArgs e)
        {
            if (alreadyAttacking == true)
            {
                MessageBox.Show("You are already attacking something.");
            }
            else
            {
                switch (player1Attacking)
                {
                    case true:
                        alreadyAttacking = true;
                        player1BaseAttack = roll.Rolld6();
                        diceRollImage.Image = roll.SetD6Image(player1BaseAttack);
                        if (player1BaseAttack == 6 && player1Critical == true)
                        {
                            player1BaseAttack = 10;
                            MessageBox.Show("Critical has increased your base attack to 10.", "Critical Proc.");
                        }
                        if (player1BaseAttack == 1 && player1LS == true)
                        {
                            player1BaseAttack = 12;
                            MessageBox.Show("Lucky Shot has increased your base attack to 12.", "Lucky Shot Proc.");
                        }
                        if (player1Sword == true)
                        {
                            int swordModifier = roll.Rolld8();
                            player1AttackModifier += swordModifier;
                            MessageBox.Show("Player 1's Sword has given player 1 " + swordModifier + " more damage.", "Sword Proc");
                        }
                        if (player1Knuckles == true)
                        {
                            int knuckleModifier1 = roll.Rolld4();
                            int knuckleModifier2 = roll.Rolld4();
                            player1AttackModifier += knuckleModifier1;
                            player1AttackModifier += knuckleModifier2;
                            MessageBox.Show("Player 1's knuckles have given player 1 " + knuckleModifier1 + " + " + knuckleModifier2 + " more damage.", "knuckle Proc");
                        }
                        if (player1Greatsword == true)
                        {
                            int greatswordModifier1 = roll.Rolld8();
                            int greatswordModifier2 = roll.Rolld8();
                            player1AttackModifier += greatswordModifier1;
                            player1AttackModifier += greatswordModifier2;
                            MessageBox.Show("Player 1's greatsword have given player 1 " + greatswordModifier1 + " + " + greatswordModifier2 + " more damage.", "Greatsword Proc");
                        }
                        if (player1Op == true)
                        {
                            int opModifier = roll.Rolld20();
                            player1AttackModifier += opModifier;
                            MessageBox.Show("Player 1's operator has given player 1 " + opModifier + " more damage.", "Operator Proc");
                        }
                        if (player1SacDagger == true)
                        {
                            int sacDaggerModifier1 = roll.Rolld12();
                            int sacDaggerModifier2 = roll.Rolld12();
                            player1AttackModifier += sacDaggerModifier1;
                            player1AttackModifier += sacDaggerModifier2;
                            player1HPCount -= 6;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            MessageBox.Show("Player 1's sacrificial dagger has given player 1 " + sacDaggerModifier1 + " + " + sacDaggerModifier2 + " more damage.", "Sacrificial Dagger Proc");
                        }
                        player1TotalAttack = player1BaseAttack + player1AttackModifier;
                        player1AttackTarget = 5;
                        player2DefendPanel.Enabled = true;
                        player2DefendPanel.Visible = true;
                        break;
                    case false:
                        MessageBox.Show("Player 1 is not attacking");
                        break;
                }
            }
        }
        private void player2RightLeg_Click(object sender, EventArgs e)
        {
            if (alreadyAttacking == true)
            {
                MessageBox.Show("You are already attacking something.");
            }
            else
            {
                switch (player1Attacking)
                {
                    case true:
                        alreadyAttacking = true;
                        player1BaseAttack = roll.Rolld6();
                        diceRollImage.Image = roll.SetD6Image(player1BaseAttack);
                        if (player1BaseAttack == 6 && player1Critical == true)
                        {
                            player1BaseAttack = 10;
                            MessageBox.Show("Critical has increased your base attack to 10.", "Critical Proc.");
                        }
                        if (player1BaseAttack == 1 && player1LS == true)
                        {
                            player1BaseAttack = 12;
                            MessageBox.Show("Lucky Shot has increased your base attack to 12.", "Lucky Shot Proc.");
                        }
                        if (player1Sword == true)
                        {
                            int swordModifier = roll.Rolld8();
                            player1AttackModifier += swordModifier;
                            MessageBox.Show("Player 1's Sword has given player 1 " + swordModifier + " more damage.", "Sword Proc");
                        }
                        if (player1Knuckles == true)
                        {
                            int knuckleModifier1 = roll.Rolld4();
                            int knuckleModifier2 = roll.Rolld4();
                            player1AttackModifier += knuckleModifier1;
                            player1AttackModifier += knuckleModifier2;
                            MessageBox.Show("Player 1's knuckles have given player 1 " + knuckleModifier1 + " + " + knuckleModifier2 + " more damage.", "knuckle Proc");
                        }
                        if (player1Greatsword == true)
                        {
                            int greatswordModifier1 = roll.Rolld8();
                            int greatswordModifier2 = roll.Rolld8();
                            player1AttackModifier += greatswordModifier1;
                            player1AttackModifier += greatswordModifier2;
                            MessageBox.Show("Player 1's greatsword have given player 1 " + greatswordModifier1 + " + " + greatswordModifier2 + " more damage.", "Greatsword Proc");
                        }
                        if (player1Op == true)
                        {
                            int opModifier = roll.Rolld20();
                            player1AttackModifier += opModifier;
                            MessageBox.Show("Player 1's operator has given player 1 " + opModifier + " more damage.", "Operator Proc");
                        }
                        if (player1SacDagger == true)
                        {
                            int sacDaggerModifier1 = roll.Rolld12();
                            int sacDaggerModifier2 = roll.Rolld12();
                            player1AttackModifier += sacDaggerModifier1;
                            player1AttackModifier += sacDaggerModifier2;
                            player1HPCount -= 6;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            MessageBox.Show("Player 1's sacrificial dagger has given player 1 " + sacDaggerModifier1 + " + " + sacDaggerModifier2 + " more damage.", "Sacrificial Dagger Proc");
                        }
                        player1TotalAttack = player1BaseAttack + player1AttackModifier;
                        player1AttackTarget = 6;
                        player2DefendPanel.Enabled = true;
                        player2DefendPanel.Visible = true;
                        break;
                    case false:
                        MessageBox.Show("Player 1 is not attacking");
                        break;
                }
            }
        }

        private void player2BlockButton_Click(object sender, EventArgs e) //Player 2 Blocks
        {
            player1TotalAttack = player1TotalAttack / 2;
            diceRollImage.Image = unknown;
            switch (player1AttackTarget)
            {
                case 1: //If attacking head
                    if (player1TotalAttack >= 8 && player1Sheriff == true)
                    {
                        MessageBox.Show("Sheriff has caused a decapitation.", "Sheriff Proc");
                        combatCount++;
                        player1HPCount = 100;
                        if (player1Helmet == true)
                            player1HPCount += 25;
                        player1HPCountLabel.Text = player1HPCount.ToString();
                        player2HPCount = 100;
                        if (player2Helmet == true)
                            player2HPCount += 25;
                        player2HPCountLabel.Text = player2HPCount.ToString();
                        player1Attacking = true;
                        player1VictoryCount++;
                        player1DefendPanel.Enabled = false;
                        player2DefendPanel.Enabled = false;
                        alreadyAttacking = false;
                        CombatUpgradeSelection();
                    }
                    else if (player1TotalAttack >= 12)
                    {
                        if (player2Halo == true)
                        {
                            MessageBox.Show("Your Halo has saved you from decapitation.", "Halo Proc.");
                            player2Halo = false;
                        }
                        else
                        {
                            MessageBox.Show("Player 1 has decapitated Player 2, Player 1 wins Combat 1.");
                            combatCount++;
                            player1HPCount = 100;
                            if (player1Helmet == true)
                                player1HPCount += 25;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            player2HPCount = 100;
                            if (player2Helmet == true)
                                player2HPCount += 25;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            player1Attacking = true;
                            player1VictoryCount++;
                            player1DefendPanel.Enabled = false;
                            player2DefendPanel.Enabled = false;
                            alreadyAttacking = false;
                            CombatUpgradeSelection();
                        }

                    }
                    else
                    {
                        Player1AttackingDamageCalculation();
                        VictoryCheck();
                    }
                    break;
                case 2: //If attacking torso
                    switch (player1PP)
                    {
                        case true:
                            player1TotalAttack += 8;
                            MessageBox.Show("Piercing Point has turned your torso's 5 extra damage into 8 extra damage.", "PP Proc");
                            break;
                        case false:
                            player1TotalAttack += 5;
                            break;
                    }
                    Player1AttackingDamageCalculation();
                    VictoryCheck();
                    break;
                case 3: //If attacking left arm
                    if (player1TotalAttack >= 8)
                    {
                        player2HPCount -= player1TotalAttack;
                        player2HPCountLabel.Text = player2HPCount.ToString();
                        VictoryCheck();
                        MessageBox.Show("Player 1 has crippled Player 2's left arm, Player 1 gains an extra turn");
                        if (player1SE == true)
                        {
                            player2HPCount -= 4;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                        }
                        player2LeftArmCripple = true;
                        player2LeftArm.Visible = false;
                        alreadyAttacking = false;
                    }
                    else
                    {
                        Player1AttackingDamageCalculation();
                        VictoryCheck();
                    }
                    break;
                case 4: //If attacking right arm
                    if (player1TotalAttack >= 8)
                    {
                        player2HPCount -= player1TotalAttack;
                        player2HPCountLabel.Text = player2HPCount.ToString();
                        VictoryCheck();
                        MessageBox.Show("Player 1 has crippled Player 2's left arm, Player 1 gains an extra turn");
                        if (player1SE == true)
                        {
                            player2HPCount -= 4;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                        }
                        player2RightArmCripple = true;
                        player2RightArm.Visible = false;
                        alreadyAttacking = false;
                    }
                    else
                    {
                        Player1AttackingDamageCalculation();
                        VictoryCheck();
                    }
                    break;
                case 5: //If attacking left leg
                    if (player1TotalAttack >= 8)
                    {
                        player2HPCount -= player1TotalAttack;
                        player2HPCountLabel.Text = player2HPCount.ToString();
                        VictoryCheck();
                        MessageBox.Show("Player 1 has crippled Player 2's left arm, Player 1 gains an extra turn");
                        if (player1SE == true)
                        {
                            player2HPCount -= 4;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                        }
                        player2LeftLegCripple = true;
                        player2LeftLeg.Visible = false;
                        alreadyAttacking = false;
                    }
                    else
                    {
                        Player1AttackingDamageCalculation();
                        VictoryCheck();
                    }
                    break;
                case 6: //If attacking right leg

                    if (player1TotalAttack >= 8)
                    {
                        player2HPCount -= player1TotalAttack;
                        player2HPCountLabel.Text = player2HPCount.ToString();
                        VictoryCheck();
                        MessageBox.Show("Player 1 has crippled Player 2's left arm, Player 1 gains an extra turn");
                        if (player1SE == true)
                        {
                            player2HPCount -= 4;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                        }
                        player2RightLegCripple = true;
                        player2RightLeg.Visible = false;
                        alreadyAttacking = false;
                    }
                    else
                    {
                        Player1AttackingDamageCalculation();
                        VictoryCheck();
                    }
                    break;

            }
        }
        private void player2CounterButton_Click(object sender, EventArgs e) //Player 2 Counters
        {
            player2CounterRoll = roll.Rolld6();
            diceRollImage.Image = roll.SetD6Image(player2CounterRoll);
            if (player2CounterRoll > player1BaseAttack) //adjusted damage calculation for successful counter
            {
                player1TotalAttack = 0;
                if (player2PR == true)
                {
                    player2CounterRoll *= 2;
                }
                player1HPCount -= player2CounterRoll;
                player1HPCountLabel.Text = player1HPCount.ToString();
                Player1AttackingDamageCalculation();
                VictoryCheck();
            }
            else if (player2CounterRoll == player1BaseAttack)
            {
                player1TotalAttack = 0;
                Player1AttackingDamageCalculation();
                VictoryCheck();
            }
            else
            {
                if (player2Shield == true)
                {
                    player1TotalAttack += 0;
                    MessageBox.Show("Shield has procced.", "Shield Proc.");
                }
                else
                    player1TotalAttack += player2CounterRoll;

                switch (player1AttackTarget)
                {
                    case 1: //If attacking head
                        if (player1TotalAttack >= 8 && player1Sheriff == true)
                        {
                            MessageBox.Show("Sheriff has caused a decapitation.", "Sheriff Proc");
                            combatCount++;
                            player1HPCount = 100;
                            if (player1Helmet == true)
                                player1HPCount += 25;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            player2HPCount = 100;
                            if (player2Helmet == true)
                                player2HPCount += 25;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            player1Attacking = true;
                            player1VictoryCount++;
                            player1DefendPanel.Enabled = false;
                            player2DefendPanel.Enabled = false;
                            alreadyAttacking = false;
                            CombatUpgradeSelection();
                        }
                        else if (player1TotalAttack >= 12)
                        {
                            if (player2Halo == true)
                            {
                                MessageBox.Show("Your Halo has saved you from decapitation.", "Halo Proc.");
                                player2Halo = false;
                            }
                            else
                            {
                                MessageBox.Show("Player 1 has decapitated Player 2, Player 1 wins Combat 1.");
                                combatCount++;
                                player1HPCount = 100;
                                if (player1Helmet == true)
                                    player1HPCount += 25;
                                player1HPCountLabel.Text = player1HPCount.ToString();
                                player2HPCount = 100;
                                if (player2Helmet == true)
                                    player2HPCount += 25;
                                player2HPCountLabel.Text = player2HPCount.ToString();
                                player1Attacking = true;
                                player1VictoryCount++;
                                player1DefendPanel.Enabled = false;
                                player2DefendPanel.Enabled = false;
                                alreadyAttacking = false;
                                CombatUpgradeSelection();
                            }
                        }
                        else
                        {
                            Player1AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 2: //If attacking torso
                        if (player1TotalAttack > 0) //Account for if counter was successful
                        {
                            switch (player1PP)
                            {
                                case true:
                                    player1TotalAttack += 8;
                                    MessageBox.Show("Piercing Point has turned your torso's 5 extra damage into 8 extra damage.", "PP Proc");
                                    break;
                                case false:
                                    player1TotalAttack += 5;
                                    break;
                            }
                        }

                        Player1AttackingDamageCalculation();
                        VictoryCheck();
                        break;
                    case 3: //If attacking left arm
                        if (player1TotalAttack >= 8)
                        {
                            player2HPCount -= player1TotalAttack;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 1 has crippled Player 2's left arm, Player 1 gains an extra turn");
                            if (player1SE == true)
                            {
                                player2HPCount -= 4;
                                player2HPCountLabel.Text = player2HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player2LeftArmCripple = true;
                            player2LeftArm.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player1AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 4: //If attacking right arm
                        if (player1TotalAttack >= 8)
                        {
                            player2HPCount -= player1TotalAttack;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 1 has crippled Player 2's left arm, Player 1 gains an extra turn");
                            if (player1SE == true)
                            {
                                player2HPCount -= 4;
                                player2HPCountLabel.Text = player2HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player2RightArmCripple = true;
                            player2RightArm.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player1AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 5: //If attacking left leg
                        if (player1TotalAttack >= 8)
                        {
                            player2HPCount -= player1TotalAttack;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 1 has crippled Player 2's left arm, Player 1 gains an extra turn");
                            if (player1SE == true)
                            {
                                player2HPCount -= 4;
                                player2HPCountLabel.Text = player2HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player2LeftLegCripple = true;
                            player2LeftLeg.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player1AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 6: //If attacking right leg

                        if (player1TotalAttack >= 8)
                        {
                            player2HPCount -= player1TotalAttack;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 1 has crippled Player 2's left arm, Player 1 gains an extra turn");
                            if (player1SE == true)
                            {
                                player2HPCount -= 4;
                                player2HPCountLabel.Text = player2HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player2RightLegCripple = true;
                            player2RightLeg.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player1AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                }
            }
        }
        private void player2DodgeButton_Click(object sender, EventArgs e) //Player 2 Dodges
        {
            player2DodgeRoll = roll.Rolld6();
            diceRollImage.Image = roll.SetD6Image(player2DodgeRoll);
            if (player2Eye == true)
            {
                int eyeRoll = roll.Rolld6();
                if (eyeRoll > player2DodgeRoll)
                {
                    player2DodgeRoll = eyeRoll;
                    MessageBox.Show("Hawkeye has increased your dodge roll to " + eyeRoll + ".", "Hawkeye Proc.");
                }
            }
            if (player2DodgeRoll >= player1BaseAttack)
            {
                player1TotalAttack = 0;
                Player1AttackingDamageCalculation();
                VictoryCheck();
            }
            else
            {
                switch (player1AttackTarget)
                {
                    case 1: //If attacking head
                        if (player1TotalAttack >= 8 && player1Sheriff == true)
                        {
                            MessageBox.Show("Sheriff has caused a decapitation.", "Sheriff Proc");
                            combatCount++;
                            player1HPCount = 100;
                            if (player1Helmet == true)
                                player1HPCount += 25;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            player2HPCount = 100;
                            if (player2Helmet == true)
                                player2HPCount += 25;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            player1Attacking = true;
                            player1VictoryCount++;
                            player1DefendPanel.Enabled = false;
                            player2DefendPanel.Enabled = false;
                            alreadyAttacking = false;
                            CombatUpgradeSelection();
                        }
                        else if (player1TotalAttack >= 12)
                        {
                            if (player2Halo == true)
                            {
                                MessageBox.Show("Your Halo has saved you from decapitation.", "Halo Proc.");
                                player2Halo = false;
                            }
                            else
                            {
                                MessageBox.Show("Player 1 has decapitated Player 2, Player 1 wins Combat 1.");
                                combatCount++;
                                player1HPCount = 100;
                                if (player1Helmet == true)
                                    player1HPCount += 25;
                                player1HPCountLabel.Text = player1HPCount.ToString();
                                player2HPCount = 100;
                                if (player2Helmet == true)
                                    player2HPCount += 25;
                                player2HPCountLabel.Text = player2HPCount.ToString();
                                player1Attacking = true;
                                player1VictoryCount++;
                                player1DefendPanel.Enabled = false;
                                player2DefendPanel.Enabled = false;
                                alreadyAttacking = false;
                                CombatUpgradeSelection();
                            }
                        }
                        else
                        {
                            Player1AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 2: //If attacking torso
                        switch (player1PP)
                        {
                            case true:
                                player1TotalAttack += 8;
                                MessageBox.Show("Piercing Point has turned your torso's 5 extra damage into 8 extra damage.", "PP Proc");
                                break;
                            case false:
                                player1TotalAttack += 5;
                                break;
                        }
                        Player1AttackingDamageCalculation();
                        VictoryCheck();
                        break;
                    case 3: //If attacking left arm
                        if (player1TotalAttack >= 8)
                        {
                            player2HPCount -= player1TotalAttack;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 1 has crippled Player 2's left arm, Player 1 gains an extra turn");
                            if (player1SE == true)
                            {
                                player2HPCount -= 4;
                                player2HPCountLabel.Text = player2HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player2LeftArmCripple = true;
                            player2LeftArm.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player1AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 4: //If attacking right arm
                        if (player1TotalAttack >= 8)
                        {
                            player2HPCount -= player1TotalAttack;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 1 has crippled Player 2's left arm, Player 1 gains an extra turn");
                            if (player1SE == true)
                            {
                                player2HPCount -= 4;
                                player2HPCountLabel.Text = player2HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player2RightArmCripple = true;
                            player2RightArm.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player1AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 5: //If attacking left leg
                        if (player1TotalAttack >= 8)
                        {
                            player2HPCount -= player1TotalAttack;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 1 has crippled Player 2's left arm, Player 1 gains an extra turn");
                            if (player1SE == true)
                            {
                                player2HPCount -= 4;
                                player2HPCountLabel.Text = player2HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player2LeftLegCripple = true;
                            player2LeftLeg.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player1AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 6: //If attacking right leg

                        if (player1TotalAttack >= 8)
                        {
                            player2HPCount -= player1TotalAttack;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 1 has crippled Player 2's left arm, Player 1 gains an extra turn");
                            if (player1SE == true)
                            {
                                player2HPCount -= 4;
                                player2HPCountLabel.Text = player2HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player2RightLegCripple = true;
                            player2RightLeg.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player1AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                }
            }
        }

        private void player1Head_Click(object sender, EventArgs e)
        {
            if (alreadyAttacking == true)
            {
                MessageBox.Show("You are already attacking something.");
            }
            else
            {
                switch (player1Attacking)
                {
                    case false:
                        alreadyAttacking = true;
                        player2BaseAttack = roll.Rolld6();
                        diceRollImage.Image = roll.SetD6Image(player1BaseAttack);
                        if (player2BaseAttack == 6 && player2Critical == true)
                        {
                            player2BaseAttack = 10;
                            MessageBox.Show("Critical has increased your base attack to 10.", "Critical Proc.");
                        }
                        if (player2BaseAttack == 1 && player2LS == true)
                        {
                            player2BaseAttack = 12;
                            MessageBox.Show("Lucky Shot has increased your base attack to 12.", "Lucky Shot Proc.");
                        }
                        if (player2Sword == true)
                        {
                            int swordModifier = roll.Rolld8();
                            player2AttackModifier += swordModifier;
                            MessageBox.Show("Player 2's Sword has given player 2 " + swordModifier + " more damage.", "Sword Proc");
                        }
                        if (player2Knuckles == true)
                        {
                            int knuckleModifier1 = roll.Rolld4();
                            int knuckleModifier2 = roll.Rolld4();
                            player2AttackModifier += knuckleModifier1;
                            player2AttackModifier += knuckleModifier2;
                            MessageBox.Show("Player 2's knuckles have given player 2 " + knuckleModifier1 + " + " + knuckleModifier2 + " more damage.", "knuckle Proc");
                        }
                        if (player2Greatsword == true)
                        {
                            int greatswordModifier1 = roll.Rolld8();
                            int greatswordModifier2 = roll.Rolld8();
                            player2AttackModifier += greatswordModifier1;
                            player2AttackModifier += greatswordModifier2;
                            MessageBox.Show("Player 2's greatsword have given player 2 " + greatswordModifier1 + " + " + greatswordModifier2 + " more damage.", "Greatsword Proc");
                        }
                        if (player2Op == true)
                        {
                            int opModifier = roll.Rolld20();
                            player2AttackModifier += opModifier;
                            MessageBox.Show("Player 2's operator has given player 2 " + opModifier + " more damage.", "Operator Proc");
                        }
                        if (player2SacDagger == true)
                        {
                            int sacDaggerModifier1 = roll.Rolld12();
                            int sacDaggerModifier2 = roll.Rolld12();
                            player2AttackModifier += sacDaggerModifier1;
                            player2AttackModifier += sacDaggerModifier2;
                            player2HPCount -= 6;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            MessageBox.Show("Player 2's sacrificial dagger has given player 2 " + sacDaggerModifier1 + " + " + sacDaggerModifier2 + " more damage.", "Sacrificial Dagger Proc");
                        }
                        player2TotalAttack = player2BaseAttack + player2AttackModifier;
                        player2AttackTarget = 1;
                        player1DefendPanel.Enabled = true;
                        player1DefendPanel.Visible = true;
                        break;
                    case true:
                        MessageBox.Show("Player 2 is not attacking");
                        break;
                }
            }
        }
        private void player1Torso_Click(object sender, EventArgs e)
        {
            if (alreadyAttacking == true)
            {
                MessageBox.Show("You are already attacking something.");
            }
            else
            {
                switch (player1Attacking)
                {
                    case false:
                        alreadyAttacking = true;
                        player2BaseAttack = roll.Rolld6();
                        diceRollImage.Image = roll.SetD6Image(player1BaseAttack);
                        if (player2BaseAttack == 6 && player2Critical == true)
                        {
                            player2BaseAttack = 10;
                            MessageBox.Show("Critical has increased your base attack to 10.", "Critical Proc.");
                        }
                        if (player2BaseAttack == 1 && player2LS == true)
                        {
                            player2BaseAttack = 12;
                            MessageBox.Show("Lucky Shot has increased your base attack to 12.", "Lucky Shot Proc.");
                        }
                        if (player2Sword == true)
                        {
                            int swordModifier = roll.Rolld8();
                            player2AttackModifier += swordModifier;
                            MessageBox.Show("Player 2's Sword has given player 2 " + swordModifier + " more damage.", "Sword Proc");
                        }
                        if (player2Knuckles == true)
                        {
                            int knuckleModifier1 = roll.Rolld4();
                            int knuckleModifier2 = roll.Rolld4();
                            player2AttackModifier += knuckleModifier1;
                            player2AttackModifier += knuckleModifier2;
                            MessageBox.Show("Player 2's knuckles have given player 2 " + knuckleModifier1 + " + " + knuckleModifier2 + " more damage.", "knuckle Proc");
                        }
                        if (player2Greatsword == true)
                        {
                            int greatswordModifier1 = roll.Rolld8();
                            int greatswordModifier2 = roll.Rolld8();
                            player2AttackModifier += greatswordModifier1;
                            player2AttackModifier += greatswordModifier2;
                            MessageBox.Show("Player 2's greatsword have given player 2 " + greatswordModifier1 + " + " + greatswordModifier2 + " more damage.", "Greatsword Proc");
                        }
                        if (player2Op == true)
                        {
                            int opModifier = roll.Rolld20();
                            player2AttackModifier += opModifier;
                            MessageBox.Show("Player 2's operator has given player 2 " + opModifier + " more damage.", "Operator Proc");
                        }
                        if (player2SacDagger == true)
                        {
                            int sacDaggerModifier1 = roll.Rolld12();
                            int sacDaggerModifier2 = roll.Rolld12();
                            player2AttackModifier += sacDaggerModifier1;
                            player2AttackModifier += sacDaggerModifier2;
                            player2HPCount -= 6;
                            player2HPCountLabel.Text = player2HPCount.ToString(); ;
                            MessageBox.Show("Player 2's sacrificial dagger has given player 2 " + sacDaggerModifier1 + " + " + sacDaggerModifier2 + " more damage.", "Sacrificial Dagger Proc");
                        }
                        player2TotalAttack = player2BaseAttack + player2AttackModifier;
                        player2AttackTarget = 2;
                        player1DefendPanel.Enabled = true;
                        player1DefendPanel.Visible = true;
                        break;
                    case true:
                        MessageBox.Show("Player 2 is not attacking");
                        break;
                }
            }
        }
        private void player1LeftArm_Click(object sender, EventArgs e)
        {
            if (alreadyAttacking == true)
            {
                MessageBox.Show("You are already attacking something.");
            }
            else
            {
                switch (player1Attacking)
                {
                    case false:
                        alreadyAttacking = true;
                        player2BaseAttack = roll.Rolld6();
                        diceRollImage.Image = roll.SetD6Image(player1BaseAttack);
                        if (player2BaseAttack == 6 && player2Critical == true)
                        {
                            player2BaseAttack = 10;
                            MessageBox.Show("Critical has increased your base attack to 10.", "Critical Proc.");
                        }
                        if (player2BaseAttack == 1 && player2LS == true)
                        {
                            player2BaseAttack = 12;
                            MessageBox.Show("Lucky Shot has increased your base attack to 12.", "Lucky Shot Proc.");
                        }
                        if (player2Sword == true)
                        {
                            int swordModifier = roll.Rolld8();
                            player2AttackModifier += swordModifier;
                            MessageBox.Show("Player 2's Sword has given player 2 " + swordModifier + " more damage.", "Sword Proc");
                        }
                        if (player2Knuckles == true)
                        {
                            int knuckleModifier1 = roll.Rolld4();
                            int knuckleModifier2 = roll.Rolld4();
                            player2AttackModifier += knuckleModifier1;
                            player2AttackModifier += knuckleModifier2;
                            MessageBox.Show("Player 2's knuckles have given player 2 " + knuckleModifier1 + " + " + knuckleModifier2 + " more damage.", "knuckle Proc");
                        }
                        if (player2Greatsword == true)
                        {
                            int greatswordModifier1 = roll.Rolld8();
                            int greatswordModifier2 = roll.Rolld8();
                            player2AttackModifier += greatswordModifier1;
                            player2AttackModifier += greatswordModifier2;
                            MessageBox.Show("Player 2's greatsword have given player 2 " + greatswordModifier1 + " + " + greatswordModifier2 + " more damage.", "Greatsword Proc");
                        }
                        if (player2Op == true)
                        {
                            int opModifier = roll.Rolld20();
                            player2AttackModifier += opModifier;
                            MessageBox.Show("Player 2's operator has given player 2 " + opModifier + " more damage.", "Operator Proc");
                        }
                        if (player2SacDagger == true)
                        {
                            int sacDaggerModifier1 = roll.Rolld12();
                            int sacDaggerModifier2 = roll.Rolld12();
                            player2AttackModifier += sacDaggerModifier1;
                            player2AttackModifier += sacDaggerModifier2;
                            player2HPCount -= 6;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            MessageBox.Show("Player 2's sacrificial dagger has given player 2 " + sacDaggerModifier1 + " + " + sacDaggerModifier2 + " more damage.", "Sacrificial Dagger Proc");
                        }
                        player2TotalAttack = player2BaseAttack + player2AttackModifier;
                        player2AttackTarget = 3;
                        player1DefendPanel.Enabled = true;
                        player1DefendPanel.Visible = true;
                        break;
                    case true:
                        MessageBox.Show("Player 2 is not attacking");
                        break;
                }
            }
        }
        private void player1RightArm_Click(object sender, EventArgs e)
        {
            if (alreadyAttacking == true)
            {
                MessageBox.Show("You are already attacking something.");
            }
            else
            {
                switch (player1Attacking)
                {
                    case false:
                        alreadyAttacking = true;
                        player2BaseAttack = roll.Rolld6();
                        diceRollImage.Image = roll.SetD6Image(player1BaseAttack);
                        if (player2BaseAttack == 6 && player2Critical == true)
                        {
                            player2BaseAttack = 10;
                            MessageBox.Show("Critical has increased your base attack to 10.", "Critical Proc.");
                        }
                        if (player2BaseAttack == 1 && player2LS == true)
                        {
                            player2BaseAttack = 12;
                            MessageBox.Show("Lucky Shot has increased your base attack to 12.", "Lucky Shot Proc.");
                        }
                        if (player2Sword == true)
                        {
                            int swordModifier = roll.Rolld8();
                            player2AttackModifier += swordModifier;
                            MessageBox.Show("Player 2's Sword has given player 2 " + swordModifier + " more damage.", "Sword Proc");
                        }
                        if (player2Knuckles == true)
                        {
                            int knuckleModifier1 = roll.Rolld4();
                            int knuckleModifier2 = roll.Rolld4();
                            player2AttackModifier += knuckleModifier1;
                            player2AttackModifier += knuckleModifier2;
                            MessageBox.Show("Player 2's knuckles have given player 2 " + knuckleModifier1 + " + " + knuckleModifier2 + " more damage.", "knuckle Proc");
                        }
                        if (player2Greatsword == true)
                        {
                            int greatswordModifier1 = roll.Rolld8();
                            int greatswordModifier2 = roll.Rolld8();
                            player2AttackModifier += greatswordModifier1;
                            player2AttackModifier += greatswordModifier2;
                            MessageBox.Show("Player 2's greatsword have given player 2 " + greatswordModifier1 + " + " + greatswordModifier2 + " more damage.", "Greatsword Proc");
                        }
                        if (player2Op == true)
                        {
                            int opModifier = roll.Rolld20();
                            player2AttackModifier += opModifier;
                            MessageBox.Show("Player 2's operator has given player 2 " + opModifier + " more damage.", "Operator Proc");
                        }
                        if (player2SacDagger == true)
                        {
                            int sacDaggerModifier1 = roll.Rolld12();
                            int sacDaggerModifier2 = roll.Rolld12();
                            player2AttackModifier += sacDaggerModifier1;
                            player2AttackModifier += sacDaggerModifier2;
                            player2HPCount -= 6;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            MessageBox.Show("Player 2's sacrificial dagger has given player 2 " + sacDaggerModifier1 + " + " + sacDaggerModifier2 + " more damage.", "Sacrificial Dagger Proc");
                        }
                        player2TotalAttack = player2BaseAttack + player2AttackModifier;
                        player2AttackTarget = 4;
                        player1DefendPanel.Enabled = true;
                        player1DefendPanel.Visible = true;
                        break;
                    case true:
                        MessageBox.Show("Player 2 is not attacking");
                        break;
                }
            }
        }
        private void player1LeftLeg_Click(object sender, EventArgs e)
        {
            if (alreadyAttacking == true)
            {
                MessageBox.Show("You are already attacking something.");
            }
            else
            {
                switch (player1Attacking)
                {
                    case false:
                        alreadyAttacking = true;
                        player2BaseAttack = roll.Rolld6();
                        diceRollImage.Image = roll.SetD6Image(player1BaseAttack);
                        if (player2BaseAttack == 6 && player2Critical == true)
                        {
                            player2BaseAttack = 10;
                            MessageBox.Show("Critical has increased your base attack to 10.", "Critical Proc.");
                        }
                        if (player2BaseAttack == 1 && player2LS == true)
                        {
                            player2BaseAttack = 12;
                            MessageBox.Show("Lucky Shot has increased your base attack to 12.", "Lucky Shot Proc.");
                        }
                        if (player2Sword == true)
                        {
                            int swordModifier = roll.Rolld8();
                            player2AttackModifier += swordModifier;
                            MessageBox.Show("Player 2's Sword has given player 2 " + swordModifier + " more damage.", "Sword Proc");
                        }
                        if (player2Knuckles == true)
                        {
                            int knuckleModifier1 = roll.Rolld4();
                            int knuckleModifier2 = roll.Rolld4();
                            player2AttackModifier += knuckleModifier1;
                            player2AttackModifier += knuckleModifier2;
                            MessageBox.Show("Player 2's knuckles have given player 2 " + knuckleModifier1 + " + " + knuckleModifier2 + " more damage.", "knuckle Proc");
                        }
                        if (player2Greatsword == true)
                        {
                            int greatswordModifier1 = roll.Rolld8();
                            int greatswordModifier2 = roll.Rolld8();
                            player2AttackModifier += greatswordModifier1;
                            player2AttackModifier += greatswordModifier2;
                            MessageBox.Show("Player 2's greatsword have given player 2 " + greatswordModifier1 + " + " + greatswordModifier2 + " more damage.", "Greatsword Proc");
                        }
                        if (player2Op == true)
                        {
                            int opModifier = roll.Rolld20();
                            player2AttackModifier += opModifier;
                            MessageBox.Show("Player 2's operator has given player 2 " + opModifier + " more damage.", "Operator Proc");
                        }
                        if (player2SacDagger == true)
                        {
                            int sacDaggerModifier1 = roll.Rolld12();
                            int sacDaggerModifier2 = roll.Rolld12();
                            player2AttackModifier += sacDaggerModifier1;
                            player2AttackModifier += sacDaggerModifier2;
                            player2HPCount -= 6;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            MessageBox.Show("Player 2's sacrificial dagger has given player 2 " + sacDaggerModifier1 + " + " + sacDaggerModifier2 + " more damage.", "Sacrificial Dagger Proc");
                        }
                        player2TotalAttack = player2BaseAttack + player2AttackModifier;
                        player2AttackTarget = 5;
                        player1DefendPanel.Enabled = true;
                        player1DefendPanel.Visible = true;
                        break;
                    case true:
                        MessageBox.Show("Player 2 is not attacking");
                        break;
                }
            }
        }
        private void player1RightLeg_Click(object sender, EventArgs e)
        {
            if (alreadyAttacking == true)
            {
                MessageBox.Show("You are already attacking something.");
            }
            else
            {
                switch (player1Attacking)
                {
                    case false:
                        alreadyAttacking = true;
                        player2BaseAttack = roll.Rolld6();
                        diceRollImage.Image = roll.SetD6Image(player1BaseAttack);
                        if (player2BaseAttack == 6 && player2Critical == true)
                        {
                            player2BaseAttack = 10;
                            MessageBox.Show("Critical has increased your base attack to 10.", "Critical Proc.");
                        }
                        if (player2BaseAttack == 1 && player2LS == true)
                        {
                            player2BaseAttack = 12;
                            MessageBox.Show("Lucky Shot has increased your base attack to 12.", "Lucky Shot Proc.");
                        }
                        if (player2Sword == true)
                        {
                            int swordModifier = roll.Rolld8();
                            player2AttackModifier += swordModifier;
                            MessageBox.Show("Player 2's Sword has given player 2 " + swordModifier + " more damage.", "Sword Proc");
                        }
                        if (player2Knuckles == true)
                        {
                            int knuckleModifier1 = roll.Rolld4();
                            int knuckleModifier2 = roll.Rolld4();
                            player2AttackModifier += knuckleModifier1;
                            player2AttackModifier += knuckleModifier2;
                            MessageBox.Show("Player 2's knuckles have given player 2 " + knuckleModifier1 + " + " + knuckleModifier2 + " more damage.", "knuckle Proc");
                        }
                        if (player2Greatsword == true)
                        {
                            int greatswordModifier1 = roll.Rolld8();
                            int greatswordModifier2 = roll.Rolld8();
                            player2AttackModifier += greatswordModifier1;
                            player2AttackModifier += greatswordModifier2;
                            MessageBox.Show("Player 2's greatsword have given player 2 " + greatswordModifier1 + " + " + greatswordModifier2 + " more damage.", "Greatsword Proc");
                        }
                        if (player2Op == true)
                        {
                            int opModifier = roll.Rolld20();
                            player2AttackModifier += opModifier;
                            MessageBox.Show("Player 2's operator has given player 2 " + opModifier + " more damage.", "Operator Proc");
                        }
                        if (player2SacDagger == true)
                        {
                            int sacDaggerModifier1 = roll.Rolld12();
                            int sacDaggerModifier2 = roll.Rolld12();
                            player2AttackModifier += sacDaggerModifier1;
                            player2AttackModifier += sacDaggerModifier2;
                            player2HPCount -= 6;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            MessageBox.Show("Player 2's sacrificial dagger has given player 2 " + sacDaggerModifier1 + " + " + sacDaggerModifier2 + " more damage.", "Sacrificial Dagger Proc");
                        }
                        player2TotalAttack = player2BaseAttack + player2AttackModifier;
                        player2AttackTarget = 6;
                        player1DefendPanel.Enabled = true;
                        player1DefendPanel.Visible = true;
                        break;
                    case true:
                        MessageBox.Show("Player 2 is not attacking");
                        break;
                }
            }
        }

        private void player1BlockButton_Click(object sender, EventArgs e) //Player 1 Blocks
        {
            player2TotalAttack = player2TotalAttack / 2;
            diceRollImage.Image = unknown;
            switch (player2AttackTarget)
            {
                case 1: //If attacking head
                    if (player2TotalAttack >= 8 && player2Sheriff == true)
                    {
                        MessageBox.Show("Sheriff has caused a decapitation.", "Sheriff Proc");
                        combatCount++;
                        player1HPCount = 100;
                        if (player1Helmet == true)
                            player1HPCount += 25;
                        player1HPCountLabel.Text = player1HPCount.ToString();
                        player2HPCount = 100;
                        if (player2Helmet == true)
                            player2HPCount += 25;
                        player2HPCountLabel.Text = player2HPCount.ToString();
                        player1Attacking = true;
                        player2VictoryCount++;
                        player1DefendPanel.Enabled = false;
                        player2DefendPanel.Enabled = false;
                        alreadyAttacking = false;
                        CombatUpgradeSelection();
                    }
                    else if (player2TotalAttack >= 12)
                    {
                        if (player1Halo == true)
                        {
                            MessageBox.Show("Your Halo has saved you from decapitation.", "Halo Proc.");
                            player1Halo = false;
                        }
                        else
                        {
                            MessageBox.Show("Player 2 has decapitated Player 1, Player 2 wins the combat.");
                            combatCount++;
                            player1HPCount = 100;
                            if (player1Helmet == true)
                                player1HPCount += 25;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            player2HPCount = 100;
                            if (player2Helmet == true)
                                player2HPCount += 25;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            player1Attacking = true;
                            player2VictoryCount++;
                            player1DefendPanel.Enabled = false;
                            player2DefendPanel.Enabled = false;
                            alreadyAttacking = false;
                            CombatUpgradeSelection();
                        }
                    }
                    else
                    {
                        Player2AttackingDamageCalculation();
                        VictoryCheck();
                    }
                    break;
                case 2: //If attacking torso
                    switch (player2PP)
                    {
                        case true:
                            player2TotalAttack += 8;
                            MessageBox.Show("Piercing Point has turned your torso's 5 extra damage into 8 extra damage.", "PP Proc");
                            break;
                        case false:
                            player2TotalAttack += 5;
                            break;
                    }
                    Player2AttackingDamageCalculation();
                    VictoryCheck();
                    break;
                case 3: //If attacking left arm
                    if (player2TotalAttack >= 8)
                    {
                        player1HPCount -= player2TotalAttack;
                        player1HPCountLabel.Text = player1HPCount.ToString();
                        VictoryCheck();
                        MessageBox.Show("Player 2 has crippled Player 1's left arm, Player 2 gains an extra turn");
                        if (player2SE == true)
                        {
                            player1HPCount -= 4;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                        }
                        player1LeftArmCripple = true;
                        player1LeftArm.Visible = false;
                        alreadyAttacking = false;
                    }
                    else
                    {
                        Player2AttackingDamageCalculation();
                        VictoryCheck();
                    }
                    break;
                case 4: //If attacking right arm
                    if (player2TotalAttack >= 8)
                    {
                        player1HPCount -= player2TotalAttack;
                        player1HPCountLabel.Text = player1HPCount.ToString();
                        VictoryCheck();
                        MessageBox.Show("Player 2 has crippled Player 1's right arm, Player 1 gains an extra turn");
                        if (player2SE == true)
                        {
                            player1HPCount -= 4;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                        }
                        player1RightArmCripple = true;
                        player1RightArm.Visible = false;
                        alreadyAttacking = false;
                    }
                    else
                    {
                        Player2AttackingDamageCalculation();
                        VictoryCheck();
                    }
                    break;
                case 5: //If attacking left leg
                    if (player2TotalAttack >= 8)
                    {
                        player1HPCount -= player2TotalAttack;
                        player1HPCountLabel.Text = player1HPCount.ToString();
                        VictoryCheck();
                        MessageBox.Show("Player 2 has crippled Player 1's left leg, Player 2 gains an extra turn");
                        if (player2SE == true)
                        {
                            player1HPCount -= 4;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                        }
                        player1LeftLegCripple = true;
                        player1LeftLeg.Visible = false;
                        alreadyAttacking = false;
                    }
                    else
                    {
                        Player2AttackingDamageCalculation();
                        VictoryCheck();
                    }
                    break;
                case 6: //If attacking right leg

                    if (player2TotalAttack >= 8)
                    {
                        player1HPCount -= player2TotalAttack;
                        player1HPCountLabel.Text = player1HPCount.ToString();
                        VictoryCheck();
                        MessageBox.Show("Player 2 has crippled Player 1's right leg, Player 2 gains an extra turn");
                        if (player2SE == true)
                        {
                            player1HPCount -= 4;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                        }
                        player1RightLegCripple = true;
                        player1RightLeg.Visible = false;
                        alreadyAttacking = false;
                    }
                    else
                    {
                        Player2AttackingDamageCalculation();
                        VictoryCheck();
                    }
                    break;
            }
        }
        private void player1CounterButton_Click(object sender, EventArgs e) //Player 1 Counters
        {
            player1CounterRoll = roll.Rolld6();
            diceRollImage.Image = roll.SetD6Image(player1CounterRoll);
            if (player1CounterRoll > player2BaseAttack)
            {
                player2TotalAttack = 0;
                if (player1PR == true)
                {
                    player1CounterRoll *= 2;
                }
                player2HPCount -= player1CounterRoll;
                player2HPCountLabel.Text = player2HPCount.ToString();
                Player2AttackingDamageCalculation();
                VictoryCheck();
            }
            else if (player1CounterRoll == player2BaseAttack)
            {
                player2TotalAttack = 0;
                Player2AttackingDamageCalculation();
                VictoryCheck();
            }
            else
            {
                if (player1Shield == true)
                {
                    player2TotalAttack += 0;
                    MessageBox.Show("Shield has procced.", "Shield Proc.");
                }
                else
                    player2TotalAttack += player1CounterRoll;
                switch (player2AttackTarget)
                {
                    case 1: //If attacking head
                        if (player2TotalAttack >= 8 && player2Sheriff == true)
                        {
                            MessageBox.Show("Sheriff has caused a decapitation.", "Sheriff Proc");
                            combatCount++;
                            player1HPCount = 100;
                            if (player1Helmet == true)
                                player1HPCount += 25;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            player2HPCount = 100;
                            if (player2Helmet == true)
                                player2HPCount += 25;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            player1Attacking = true;
                            player2VictoryCount++;
                            player1DefendPanel.Enabled = false;
                            player2DefendPanel.Enabled = false;
                            alreadyAttacking = false;
                            CombatUpgradeSelection();
                        }
                        else if (player2TotalAttack >= 12)
                        {
                            if (player1Halo == true)
                            {
                                MessageBox.Show("Your Halo has saved you from decapitation.", "Halo Proc.");
                                player1Halo = false;
                            }
                            else
                            {
                                MessageBox.Show("Player 2 has decapitated Player 1, Player 2 wins the combat.");
                                combatCount++;
                                player1HPCount = 100;
                                if (player1Helmet == true)
                                    player1HPCount += 25;
                                player1HPCountLabel.Text = player1HPCount.ToString();
                                player2HPCount = 100;
                                if (player2Helmet == true)
                                    player2HPCount += 25;
                                player2HPCountLabel.Text = player2HPCount.ToString();
                                player1Attacking = true;
                                player2VictoryCount++;
                                player1DefendPanel.Enabled = false;
                                player2DefendPanel.Enabled = false;
                                alreadyAttacking = false;
                                CombatUpgradeSelection();
                            }
                        }
                        else
                        {
                            Player2AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 2: //If attacking torso
                        switch (player2PP)
                        {
                            case true:
                                player2TotalAttack += 8;
                                MessageBox.Show("Piercing Point has turned your torso's 5 extra damage into 8 extra damage.", "PP Proc");
                                break;
                            case false:
                                player2TotalAttack += 5;
                                break;
                        }
                        Player2AttackingDamageCalculation();
                        VictoryCheck();
                        break;
                    case 3: //If attacking left arm
                        if (player2TotalAttack >= 8)
                        {
                            player1HPCount -= player2TotalAttack;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 2 has crippled Player 1's left arm, Player 2 gains an extra turn");
                            if (player2SE == true)
                            {
                                player1HPCount -= 4;
                                player1HPCountLabel.Text = player1HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player1LeftArmCripple = true;
                            player1LeftArm.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player2AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 4: //If attacking right arm
                        if (player2TotalAttack >= 8)
                        {
                            player1HPCount -= player2TotalAttack;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 2 has crippled Player 1's right arm, Player 1 gains an extra turn");
                            if (player2SE == true)
                            {
                                player1HPCount -= 4;
                                player1HPCountLabel.Text = player1HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player1RightArmCripple = true;
                            player1RightArm.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player2AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 5: //If attacking left leg
                        if (player2TotalAttack >= 8)
                        {
                            player1HPCount -= player2TotalAttack;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 2 has crippled Player 1's left leg, Player 2 gains an extra turn");
                            if (player2SE == true)
                            {
                                player1HPCount -= 4;
                                player1HPCountLabel.Text = player1HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player1LeftLegCripple = true;
                            player1LeftLeg.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player2AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 6: //If attacking right leg

                        if (player2TotalAttack >= 8)
                        {
                            player1HPCount -= player2TotalAttack;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 2 has crippled Player 1's right leg, Player 2 gains an extra turn");
                            if (player2SE == true)
                            {
                                player1HPCount -= 4;
                                player1HPCountLabel.Text = player1HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player1RightLegCripple = true;
                            player1RightLeg.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player2AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                }
            }

        }
        private void Player1DodgeButton_Click(object sender, EventArgs e) //Player 1 Dodges
        {
            player1DodgeRoll = roll.Rolld6();
            diceRollImage.Image = roll.SetD6Image(player1DodgeRoll);
            if (player1Eye == true)
            {
                int eyeRoll = roll.Rolld6();
                if (eyeRoll > player1DodgeRoll)
                {
                    player1DodgeRoll = eyeRoll;
                    MessageBox.Show("Hawkeye has increased your dodge roll to " + eyeRoll + ".", "Hawkeye Proc.");
                }
            }
            if (player1DodgeRoll >= player2BaseAttack)
            {
                player2TotalAttack = 0;
                Player2AttackingDamageCalculation();
                VictoryCheck();
            }
            else
            {
                switch (player2AttackTarget)
                {
                    case 1: //If attacking head
                        if (player2TotalAttack >= 8 && player2Sheriff == true)
                        {
                            MessageBox.Show("Sheriff has caused a decapitation.", "Sheriff Proc");
                            combatCount++;
                            player1HPCount = 100;
                            if (player1Helmet == true)
                                player1HPCount += 25;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            player2HPCount = 100;
                            if (player2Helmet == true)
                                player2HPCount += 25;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            player1Attacking = true;
                            player2VictoryCount++;
                            player1DefendPanel.Enabled = false;
                            player2DefendPanel.Enabled = false;
                            alreadyAttacking = false;
                            CombatUpgradeSelection();
                        }
                        else if (player2TotalAttack >= 12)
                        {
                            if (player1Halo == true)
                            {
                                MessageBox.Show("Your Halo has saved you from decapitation.", "Halo Proc.");
                                player1Halo = false;
                            }
                            else
                            {
                                MessageBox.Show("Player 2 has decapitated Player 1, Player 2 wins the combat.");
                                combatCount++;
                                player1HPCount = 100;
                                if (player1Helmet == true)
                                    player1HPCount += 25;
                                player1HPCountLabel.Text = player1HPCount.ToString();
                                player2HPCount = 100;
                                if (player2Helmet == true)
                                    player2HPCount += 25;
                                player2HPCountLabel.Text = player2HPCount.ToString();
                                player1Attacking = true;
                                player2VictoryCount++;
                                player1DefendPanel.Enabled = false;
                                player2DefendPanel.Enabled = false;
                                alreadyAttacking = false;
                                CombatUpgradeSelection();
                            }
                        }
                        else
                        {
                            Player2AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 2: //If attacking torso
                        switch (player2PP)
                        {
                            case true:
                                player2TotalAttack += 8;
                                MessageBox.Show("Piercing Point has turned your torso's 5 extra damage into 8 extra damage.", "PP Proc");
                                break;
                            case false:
                                player2TotalAttack += 5;
                                break;
                        }
                        Player2AttackingDamageCalculation();
                        VictoryCheck();
                        break;
                    case 3: //If attacking left arm
                        if (player2TotalAttack >= 8)
                        {
                            player1HPCount -= player2TotalAttack;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 2 has crippled Player 1's left arm, Player 2 gains an extra turn");
                            if (player2SE == true)
                            {
                                player1HPCount -= 4;
                                player1HPCountLabel.Text = player1HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player1LeftArmCripple = true;
                            player1LeftArm.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player2AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 4: //If attacking right arm
                        if (player2TotalAttack >= 8)
                        {
                            player1HPCount -= player2TotalAttack;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 2 has crippled Player 1's right arm, Player 1 gains an extra turn");
                            if (player2SE == true)
                            {
                                player1HPCount -= 4;
                                player1HPCountLabel.Text = player1HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player1RightArmCripple = true;
                            player1RightArm.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player2AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 5: //If attacking left leg
                        if (player2TotalAttack >= 8)
                        {
                            player1HPCount -= player2TotalAttack;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 2 has crippled Player 1's left leg, Player 2 gains an extra turn");
                            if (player2SE == true)
                            {
                                player1HPCount -= 4;
                                player1HPCountLabel.Text = player1HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player1LeftLegCripple = true;
                            player1LeftLeg.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player2AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                    case 6: //If attacking right leg

                        if (player2TotalAttack >= 8)
                        {
                            player1HPCount -= player2TotalAttack;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            VictoryCheck();
                            MessageBox.Show("Player 2 has crippled Player 1's right leg, Player 2 gains an extra turn");
                            if (player2SE == true)
                            {
                                player1HPCount -= 4;
                                player1HPCountLabel.Text = player1HPCount.ToString();
                                MessageBox.Show("Serrated Edge has procced for 4 damage", "SE Proc.");
                            }
                            player1RightLegCripple = true;
                            player1RightLeg.Visible = false;
                            alreadyAttacking = false;
                        }
                        else
                        {
                            Player2AttackingDamageCalculation();
                            VictoryCheck();
                        }
                        break;
                }
            }
        }

        private void player1UpgradeChoice1Image_Click(object sender, EventArgs e)
        {
            switch (combatCount)
            {
                case 1:
                    switch (player1upgradeChoice1)
                    {
                        case 1:
                            player1Sword = true;
                            break;
                        case 2:
                            player1Knuckles = true;
                            break;
                        case 3:
                            player1Prayer = true;
                            break;
                        case 4:
                            player1Critical = true;
                            break;
                        case 5:
                            player1Helmet = true;
                            player1HPCount += 25;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            break;
                        case 6:
                            player1PP = true;
                            break;
                    }
                    break;
                case 2:
                    switch (player1upgradeChoice1)
                    {
                        case 1:
                            player1Halo = true;
                            break;
                        case 2:
                            player1Greatsword = true;
                            break;
                        case 3:
                            player1SE = true;
                            break;
                        case 4:
                            player1LS = true;
                            break;
                        case 5:
                            player1GA = true;
                            break;
                        case 6:
                            player1Shield = true;
                            break;
                    }
                    break;
                case 3:
                    switch (player1upgradeChoice1)
                    {
                        case 1:
                            player1Blessing = true;
                            break;
                        case 2:
                            player1Op = true;
                            break;
                        case 3:
                            player1Eye = true;
                            break;
                        case 4:
                            player1SacDagger = true;
                            break;
                        case 5:
                            player1PR = true;
                            break;
                        case 6:
                            player1Sheriff = true;
                            break;
                    }
                    break;
            }
            player1UpgradeSelectionPanel.Enabled = false;
            player1UpgradeSelectionPanel.Visible = false;
        }

        private void player1UpgradeChoice2Image_Click(object sender, EventArgs e)
        {
            switch (combatCount)
            {
                case 1:
                    switch (player1upgradeChoice2)
                    {
                        case 1:
                            player1Sword = true;
                            break;
                        case 2:
                            player1Knuckles = true;
                            break;
                        case 3:
                            player1Prayer = true;
                            break;
                        case 4:
                            player1Critical = true;
                            break;
                        case 5:
                            player1Helmet = true;
                            player1HPCount += 25;
                            player1HPCountLabel.Text = player1HPCount.ToString();
                            break;
                        case 6:
                            player1PP = true;
                            break;
                    }
                    break;
                case 2:
                    switch (player1upgradeChoice2)
                    {
                        case 1:
                            player1Halo = true;
                            break;
                        case 2:
                            player1Greatsword = true;
                            break;
                        case 3:
                            player1SE = true;
                            break;
                        case 4:
                            player1LS = true;
                            break;
                        case 5:
                            player1GA = true;
                            break;
                        case 6:
                            player1Shield = true;
                            break;
                    }
                    break;
                case 3:
                    switch (player1upgradeChoice2)
                    {
                        case 1:
                            player1Blessing = true;
                            break;
                        case 2:
                            player1Op = true;
                            break;
                        case 3:
                            player1Eye = true;
                            break;
                        case 4:
                            player1SacDagger = true;
                            break;
                        case 5:
                            player1PR = true;
                            break;
                        case 6:
                            player1Sheriff = true;
                            break;
                    }
                    break;
            }
            player1UpgradeSelectionPanel.Enabled = false;
            player1UpgradeSelectionPanel.Visible = false;
        }

        private void Player2UpgradeChoice1Image_Click(object sender, EventArgs e)
        {
            switch (combatCount)
            {
                case 1:
                    switch (player2upgradeChoice1)
                    {
                        case 1:
                            player2Sword = true;
                            break;
                        case 2:
                            player2Knuckles = true;
                            break;
                        case 3:
                            player2Prayer = true;
                            break;
                        case 4:
                            player2Critical = true;
                            break;
                        case 5:
                            player2Helmet = true;
                            player2HPCount += 25;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            break;
                        case 6:
                            player2PP = true;
                            break;
                    }
                    break;
                case 2:
                    switch (player2upgradeChoice1)
                    {
                        case 1:
                            player2Halo = true;
                            break;
                        case 2:
                            player2Greatsword = true;
                            break;
                        case 3:
                            player2SE = true;
                            break;
                        case 4:
                            player2LS = true;
                            break;
                        case 5:
                            player2GA = true;
                            break;
                        case 6:
                            player2Shield = true;
                            break;
                    }
                    break;
                case 3:
                    switch (player2upgradeChoice1)
                    {
                        case 1:
                            player2Blessing = true;
                            break;
                        case 2:
                            player2Op = true;
                            break;
                        case 3:
                            player2Eye = true;
                            break;
                        case 4:
                            player2SacDagger = true;
                            break;
                        case 5:
                            player2PR = true;
                            break;
                        case 6:
                            player2Sheriff = true;
                            break;
                    }
                    break;
            }
            player2UpgradeSelectionPanel.Enabled = false;
            player2UpgradeSelectionPanel.Visible = false;
        }

        private void player2UpgradeChoice2Image_Click(object sender, EventArgs e)
        {
            switch (combatCount)
            {
                case 1:
                    switch (player2upgradeChoice2)
                    {
                        case 1:
                            player2Sword = true;
                            break;
                        case 2:
                            player2Knuckles = true;
                            break;
                        case 3:
                            player2Prayer = true;
                            break;
                        case 4:
                            player2Critical = true;
                            break;
                        case 5:
                            player2Helmet = true;
                            player2HPCount += 25;
                            player2HPCountLabel.Text = player2HPCount.ToString();
                            break;
                        case 6:
                            player2PP = true;
                            break;
                    }
                    break;
                case 2:
                    switch (player2upgradeChoice2)
                    {
                        case 1:
                            player2Halo = true;
                            break;
                        case 2:
                            player2Greatsword = true;
                            break;
                        case 3:
                            player2SE = true;
                            break;
                        case 4:
                            player2LS = true;
                            break;
                        case 5:
                            player2GA = true;
                            break;
                        case 6:
                            player2Shield = true;
                            break;
                    }
                    break;
                case 3:
                    switch (player2upgradeChoice2)
                    {
                        case 1:
                            player2Blessing = true;
                            break;
                        case 2:
                            player2Op = true;
                            break;
                        case 3:
                            player2Eye = true;
                            break;
                        case 4:
                            player2SacDagger = true;
                            break;
                        case 5:
                            player2PR = true;
                            break;
                        case 6:
                            player2Sheriff = true;
                            break;
                    }
                    break;
            }
            player2UpgradeSelectionPanel.Enabled = false;
            player2UpgradeSelectionPanel.Visible = false;
        }
    }
}


