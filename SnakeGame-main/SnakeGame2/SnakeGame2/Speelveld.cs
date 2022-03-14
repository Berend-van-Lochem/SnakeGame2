using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace SnakeGame2
{
    public partial class Speelveld : Form
    {
        SpeelveldFields[,] SpeelveldField;
        Directions direction;
        SnakeCoordinates[] snakeXY;
        private int snakeLength;
        private int bombAmount;
        private int timeTicks;
        Graphics g;
        Random r;

        public int SnakeLength
        {
            get
            {
                return this.snakeLength;
            }
            set
            {
                this.snakeLength = value;
            }
        }

        public int BombAmount
        {
            get
            {
                return this.bombAmount;
            }
            set
            {
                this.bombAmount = value;
            }
        }

        public int TimeTicks
        {
            get
            {
                return this.timeTicks;
            }
            set
            {
                this.timeTicks = value;
            }
        }

        public Speelveld(int difficulty)
        {
            InitializeComponent();
            SpeelveldField = new SpeelveldFields[11, 11];
            snakeXY = new SnakeCoordinates[100];
            r = new Random();
            this.TimeTicks = 0;
            timTimer.Interval = difficulty;
        }

        private void Speelveld_Load(object sender, EventArgs e)
        {
            picSpeelveld.Image = new Bitmap(420, 420);
            g = Graphics.FromImage(picSpeelveld.Image);
            g.Clear(Color.White);
            // Maakt het picture 420x420. Een vakje is 35 pixels, dus het speelveeld is 10x10 vakjes en het totale bord met rand is 12x12.

            for (int i = 1; i <= 10; i++)
            {
                g.DrawImage(ImgList.Images[3], i * 35, 0);
                g.DrawImage(ImgList.Images[3], i * 35, 385);
            }

            for (int i = 0; i <= 11; i++)
            {
                g.DrawImage(ImgList.Images[3], 0, i * 35);
                g.DrawImage(ImgList.Images[3], 385, i * 35);
            }
            // Deze twee tekenen de rand van het speelvelt met de juiste afbeelding. 

            // Dit stelt vast waar de slang begint. Het hoofd [0] begint op 5,5 en het lichaam 1 en 2 komen daar onder. 
            snakeXY[0].x = 5;
            snakeXY[0].y = 5;
            snakeXY[1].x = 5;
            snakeXY[1].y = 6;
            snakeXY[2].x = 5;
            snakeXY[2].y = 7;

            // Dit tekent de beginslang. 
            g.DrawImage(ImgList.Images[2], 5 * 35, 5 * 35);
            g.DrawImage(ImgList.Images[1], 5 * 35, 6 * 35);
            g.DrawImage(ImgList.Images[1], 5 * 35, 7 * 35);

            // Dit zet de vakjes waar de slang start vast als Snake. 
            SpeelveldField[5, 5] = SpeelveldFields.Snake;
            SpeelveldField[5, 6] = SpeelveldFields.Snake;
            SpeelveldField[5, 7] = SpeelveldFields.Snake;

            // Dit stelt de start lengte en richting in. 
            direction = Directions.None; 
            this.SnakeLength = 3;
            this.BombAmount = 0; 
            // Dit tekent 4 appels aan het begin van het spel. 
            for (int i = 0; i < 4; i++)
            {
                Bonus();
            }
        }

        /// Dit is de methode voor het kiezen van een random vakje op het veld. Vervolgens kijkt het of het vakje leeg is. 
        /// Als dat klopt maakt het het vakje Bonus en tekent het de bonus op het bord.
        private void Bonus()
        {
            int x, y;

            do
            {
                x = r.Next(1, 10);
                y = r.Next(1, 10);

            }
            while (SpeelveldField[x, y] != SpeelveldFields.Free);

            SpeelveldField[x, y] = SpeelveldFields.Bonus;
            g.DrawImage(ImgList.Images[0], x * 35, y * 35);
        }

        /// Het zelfde as hierboven, maar dan een bomb in plaats van een bonus. 
        private void Bomb() 
        {   
            int x, y;

            do
            {

                x = r.Next(1, 10);
                y = r.Next(1, 10);

                x = r.Next(1, 10);
                y = r.Next(1, 10);

            }
            while (SpeelveldField[x, y] != SpeelveldFields.Free);

            this.BombAmount++; 
            SpeelveldField[x, y] = SpeelveldFields.Bomb;
            g.DrawImage(ImgList.Images[4], x * 35, y * 35);
        }

        /// Dit zet de direction van de slang wat correspondeerd met de pijltjestoetsen. Als je nog geen direction heb dan start het spel. 
        private void Speelveld_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W: 
                    if (direction == Directions.None)
                    {
                        direction = Directions.Up;
                        timTimer.Start();
                        timTimeTracker.Start();
                        break; 
                    }
                    if (direction != Directions.Down)
                    {
                        direction = Directions.Up;
                    } 
                    break;

                case Keys.Down:
                case Keys.S: 
                    if (direction != Directions.Up && direction != Directions.None)
                    {
                        direction = Directions.Down; 
                    }
                    break;

                case Keys.Left:
                case Keys.A:
                    if (direction == Directions.None)
                    {
                        direction = Directions.Left;
                        timTimer.Start();
                        timTimeTracker.Start();
                        break;
                    }
                    if (direction != Directions.Right)
                    {
                        direction = Directions.Left;
                    }
                    break;

                case Keys.Right:
                case Keys.D:
                    if (direction == Directions.None)
                    {
                        direction = Directions.Right;
                        timTimer.Start();
                        timTimeTracker.Start();
                        break;
                    }
                    if (direction != Directions.Left)
                    {
                        direction = Directions.Right;
                    }
                    break;
            }
        }

        /// Een methode voor als je game over bent. Eindigt Speelveld-form en start het GameOver form die
        /// de gebruiker zijn score laat zien met 3 opties: 
        /// 1. Opnieuw spelen - 2. Terug naar het menu - 3. Applicatie afsluiten
        private void GameOver()
        {
            timTimer.Enabled = false;
            this.Close();

            GameOver gameover = new GameOver(snakeLength - 3);
            DialogResult antwoord = gameover.ShowDialog();

            if (antwoord == DialogResult.Yes)
            {
                gameover.Close();
                Speelveld snakegame = new Speelveld(timTimer.Interval);
                snakegame.Show();
            }

            if (antwoord == DialogResult.No)
            {
                gameover.Close();
                Mainmenu mainmenu = new Mainmenu();
                mainmenu.Show();
            }

            if (antwoord == DialogResult.Abort)
            {
                Application.Exit();
            }
        }

        /// Zolang de timer actief is. Dit gebeurd elke 500 miliseconden door een Tick event.
        private void timTimer_Tick(object sender, EventArgs e)
        {
            // Zet de titel van de form met de score en de tijd in seconden. 
            this.Text = "Snake - score: " + (snakeLength - 3) + " - Time: " + timeTicks.ToString();

            // Teken het laatste vakje van de slang wit. Zet vervolgens het vakje als Free. 
            g.FillRectangle(Brushes.White, snakeXY[snakeLength - 1].x * 35,
                snakeXY[snakeLength - 1].y * 35, 35, 35);
            SpeelveldField[snakeXY[snakeLength - 1].x, snakeXY[snakeLength - 1].y] = SpeelveldFields.Free;

            // De coordinaten van het laatste segment worden verandert naar de coordinaten van het eenalaatse segment, en zo voort. Tot aan het hoofd.
            for (int i = snakeLength; i >= 1; i--)
            {
                snakeXY[i].x = snakeXY[i - 1].x;
                snakeXY[i].y = snakeXY[i - 1].y;
            }
            // Het lichaam wordt getekend voor de slang. 
            g.DrawImage(ImgList.Images[1], snakeXY[0].x * 35, snakeXY[0].y * 35);

            // De locatie van het hoofd wordt aangepast aan de hand van de richting. 
            switch (direction)
            {
                case Directions.Up:
                    snakeXY[0].y = snakeXY[0].y - 1;
                    break;
                case Directions.Down:
                    snakeXY[0].y = snakeXY[0].y + 1;
                    break;
                case Directions.Left:
                    snakeXY[0].x = snakeXY[0].x - 1;
                    break;
                case Directions.Right:
                    snakeXY[0].x = snakeXY[0].x + 1;
                    break;
            }

            // Check of de slang buiten het speelveld valt en dus tegen de rand is. Als dat zo is, game over. Speel een geluidje. 
            if (snakeXY[0].x < 1 || snakeXY[0].x > 10 || snakeXY[0].y < 1 || snakeXY[0].y > 10)
            {
                SoundPlayer wallSound = new SoundPlayer(@"bonk.wav");
                // wallSound.Play();
                GameOver();
                picSpeelveld.Refresh();
                return;
            }

            // Check of het hoofd van de slang overlapt met een deel van de slang. Als dat zo is, game over. Speel je een geluidje.
            if (SpeelveldField[snakeXY[0].x, snakeXY[0].y] == SpeelveldFields.Snake)
            {
                GameOver();
                picSpeelveld.Refresh();
                return;
            }

            // Check of het hoofd van de slang overlapt met een deel van de bomb. Als dat zo is, game over. Speel een geluidje. 
            if (SpeelveldField[snakeXY[0].x, snakeXY[0].y] == SpeelveldFields.Bomb)
            {
                SoundPlayer bombSound = new SoundPlayer(@"bomb.wav");
                // bombSound.Play(); 
                GameOver();
                picSpeelveld.Refresh();
                return;
            }

            // Check of het hoofd van de slang overlapt met een deel van de slang. Als dat zo is, teken een extra slang segment
            // (wat zichbaar wordt op de refresh en dus op de juiste locatie is, ipv van -1 of zo iets). Zet dat vakje als een Snake en maak de length langer. 
            // Vervolgens kijken of het bord niet te vol is en dan een nieuwe bonus spawnen. 
            // Als de slang lang genoeg is, spawn een bomb. 
            if (SpeelveldField[snakeXY[0].x, snakeXY[0].y] == SpeelveldFields.Bonus)
            {
                g.DrawImage(ImgList.Images[1], snakeXY[snakeLength].x * 35,
                    snakeXY[snakeLength].y * 35);
                SpeelveldField[snakeXY[snakeLength].x, snakeXY[snakeLength].y] = SpeelveldFields.Snake;
                SoundPlayer eatSound = new SoundPlayer(@"eat.wav");
                // eatSound.Play();
                snakeLength++;
                
                if (snakeLength < 96)
                    Bonus();
                if (12 < snakeLength && snakeLength < 96 && bombAmount < 6)
                    Bomb();
            }

            // Als laatste tekent het een hoofd van de slang en zet het het vakje naar Snake.  
            g.DrawImage(ImgList.Images[2], snakeXY[0].x * 35, snakeXY[0].y * 35);
            SpeelveldField[snakeXY[0].x, snakeXY[0].y] = SpeelveldFields.Snake;
            // Het wordt gerefreshed en de veranderingen in de visuals worden zichtbaar. 
            picSpeelveld.Refresh();
        }

        //  Dit houd de gametime bij, onafhankelijk van de snelheid van de slang/ticks. 
        private void timTimeTracker_Tick(object sender, EventArgs e)
        {
            this.TimeTicks++;
        }

        // Een Enum voor het type vakje op het bord. 
        enum SpeelveldFields
        {
            Free,
            Snake,
            Bonus,
            Bomb
        }
        // Een Enum voor de type directions. 
        enum Directions
        {
            Up,
            Down,
            Left,
            Right,
            None
        }

        /// Een structure voor de coordinaten van de snake. 
        struct SnakeCoordinates
        {
            public int x;
            public int y;
        }
    }
}
