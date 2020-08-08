using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snaaker
{    
    public partial class Snaaker : Form
    {
        List<Ball> snake = new List<Ball>();
        List<Ball> snookerBalls = new List<Ball>();
        RedBall redBall = new RedBall();
        Brush requiredColour;
        int minX, maxX, minY, maxY, collectedRedsCount, maxReds = 15;
        bool requiresColour, colourAfterFinalRed;

        public Snaaker()
        {
            InitializeComponent();
            
            Settings.ResetSettings();

            minX = 1;
            maxX = (pictureBoxCanvas.Size.Width / Settings.width) - 2;
            minY = 1;
            maxY = (pictureBoxCanvas.Size.Height / Settings.height) - 2;
            
            //Set game speed and tick function
            gameTimer.Interval = 1000 / Settings.speed;
            gameTimer.Tick += UpdateInput;

            gameOverLabel.Visible = false;
        }

        private void StartGame()
        {
            gameOverLabel.Visible = false;

            Settings.ResetSettings();

            // Create new snake
            snake.Clear();

            Ball head = new WhiteBall();
            
            snake.Add(head);

            scoreLabel.Text = Settings.score.ToString();
            requiresColour = false;
            colourAfterFinalRed = false;
            collectedRedsCount = 0;

            GenerateInitialBalls();

            gameTimer.Start();
        }

        private void GenerateInitialBalls()
        {
            snookerBalls.Clear();

            snookerBalls.Add(new YellowBall());
            snookerBalls.Add(new GreenBall());
            snookerBalls.Add(new BrownBall());
            snookerBalls.Add(new BlueBall());
            snookerBalls.Add(new PinkBall());
            snookerBalls.Add(new BlackBall());
            GenerateRandomRedBall();

        }

        private void GenerateRandomRedBall()
        {
            Random random = new Random();
            bool clear = false;
            int xR, yR;
            while (!clear)
            {
                bool match = false;
                // First red should always be infront of the snake
                if (!gameTimer.Enabled)
                {
                    xR = random.Next(minX, (maxX / 3) * 2);
                    yR = random.Next(minY, maxY);
                }
                else
                {
                    xR = random.Next(minX, maxX);
                    yR = random.Next(minY, maxY);
                }
                for (int i = 0; i < snookerBalls.Count; i++)
                {
                    if(xR == snookerBalls[i].x && yR == snookerBalls[i].y)
                    {
                        match = true;
                    }
                }
                if (!match)
                {
                    redBall = new RedBall()
                    {
                        x = xR,
                        y = yR
                    };
                    snookerBalls.Add(redBall);
                    clear = true;
                }
            }
            
        }

        private void UpdateInput(object sender, EventArgs e)
        {
            
            switch (Settings.gameOver)
            {
                case false:
                default:                    
                    if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                        Settings.direction = Direction.Right;
                    else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                        Settings.direction = Direction.Left;
                    else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                        Settings.direction = Direction.Up;
                    else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                        Settings.direction = Direction.Down;

                    MoveSnake();

                    break;
                case true:
                    //Check if Enter is pressed
                    if (Input.KeyPressed(Keys.Enter))
                    {
                        StartGame();
                    }
                    break;
            }
            pictureBoxCanvas.Invalidate();

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Snaaker Rules:\n\nEat a red, then any colour, back to red, back to any colour.\n\nOnce you have eaten 15 reds and 15 colours, you must then eat the colours in order:\n\nYellow\nGreen\nBrown\nBlue\nPink\nBlack\n\nUse Arrow keys to control direction.", "Snaaker Rules");
        }

        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            
            if (!Settings.gameOver)
            {
                //Set colour of snake
                Brush snakeColour;
                Brush ballColour;

                //Draw balls
                for (int i = 0; i < snookerBalls.Count; i++)
                {
                    ballColour = snookerBalls[i].ballColor;

                    //Draw balls
                    canvas.FillEllipse(ballColour,
                        new Rectangle(snookerBalls[i].x * Settings.width,
                                      snookerBalls[i].y * Settings.height,
                                      Settings.width, Settings.height));
                }

                //Draw snake
                for (int i = 0; i < snake.Count; i++)
                {
                    snakeColour = snake[i].ballColor;

                    //Draw snake
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(snake[i].x * Settings.width,
                                      snake[i].y * Settings.height,
                                      Settings.width, Settings.height));
                }
            }
            else
            {
                gameOverLabel.Visible = true;
            }
        }

        private void MoveSnake()
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            snake[i].x++;
                            break;
                        case Direction.Left:
                            snake[i].x--;
                            break;
                        case Direction.Up:
                            snake[i].y--;
                            break;
                        case Direction.Down:
                            snake[i].y++;
                            break;
                    }

                    //Detect collission with game borders.
                    if (snake[i].x < minX || snake[i].y < minY
                        || snake[i].x > maxX || snake[i].y > maxY)
                    {
                        Die();
                    }

                    //Detect collission with body
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].x == snake[j].x &&
                           snake[i].y == snake[j].y)
                        {
                            Die();
                        }
                    }

                    //Detect collision with ball
                    for (int j = 0; j < snookerBalls.Count; j++)
                    {
                        if (snake[i].x == snookerBalls[j].x && snake[i].y == snookerBalls[j].y)
                        {
                            if (collectedRedsCount == maxReds)
                            {
                                if (colourAfterFinalRed)
                                {
                                    Eat(snookerBalls[j]);
                                }
                                else
                                {
                                    if (snookerBalls[j].ballColor == requiredColour)
                                    {
                                        Eat(snookerBalls[j]);
                                    }
                                }
                            }             
                            else if ((requiresColour && snookerBalls[j].ballColor != Brushes.Red) || (!requiresColour && snookerBalls[j].ballColor == Brushes.Red))
                            {
                                Eat(snookerBalls[j]);
                                requiresColour = !requiresColour;
                                break;
                            }
                            else
                            {
                                Die();
                            }
                        }
                    }
                }
                else
                {
                    //Move body
                    snake[i].x = snake[i - 1].x;
                    snake[i].y = snake[i - 1].y;
                }
            }
        }
        
        private void Snaaker_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Eat(Ball ball)
        {
            //Add ball to body
            snake.Add(ball);
            //Update Score
            Settings.score += ball.value;
            scoreLabel.Text = Settings.score.ToString();
            
            switch (ball.value)
            {
                case 1:
                default:
                    snookerBalls.Remove(ball);
                    collectedRedsCount += 1;
                    if (collectedRedsCount < maxReds)
                    {
                        GenerateRandomRedBall();
                    }
                    if(collectedRedsCount == maxReds)
                    {
                        colourAfterFinalRed = true;
                    }
                    break;
                case 2:
                    snookerBalls.Remove(ball);
                    if (collectedRedsCount < maxReds)
                    {
                        snookerBalls.Add(new YellowBall());
                    }
                    if (collectedRedsCount == maxReds && !colourAfterFinalRed)
                    {
                        requiredColour = Brushes.Green;
                    }
                    if (collectedRedsCount == maxReds && colourAfterFinalRed)
                    {
                        snookerBalls.Add(new YellowBall());
                        requiredColour = Brushes.Yellow;
                        colourAfterFinalRed = false;
                    }              
                    break;
                case 3:
                    snookerBalls.Remove(ball);
                    if (collectedRedsCount < maxReds)
                    {
                        snookerBalls.Add(new GreenBall());
                    }
                    if (collectedRedsCount == maxReds && !colourAfterFinalRed)
                    {
                        requiredColour = Brushes.Brown;
                    }
                    if (collectedRedsCount == maxReds && colourAfterFinalRed)
                    {
                        snookerBalls.Add(new GreenBall());
                        requiredColour = Brushes.Yellow;
                        colourAfterFinalRed = false;
                    }
                    break;
                case 4:
                    snookerBalls.Remove(ball);
                    if (collectedRedsCount < maxReds)
                    {
                        snookerBalls.Add(new BrownBall());
                    }
                    if (collectedRedsCount == maxReds && !colourAfterFinalRed)
                    {
                        requiredColour = Brushes.Blue;
                    }
                    if (collectedRedsCount == maxReds && colourAfterFinalRed)
                    {
                        snookerBalls.Add(new BrownBall());
                        requiredColour = Brushes.Yellow;
                        colourAfterFinalRed = false;
                    }
                    break;
                case 5:
                    snookerBalls.Remove(ball);
                    if (collectedRedsCount < maxReds)
                    {
                        snookerBalls.Add(new BlueBall());
                    }
                    if (collectedRedsCount == maxReds && !colourAfterFinalRed)
                    {
                        requiredColour = Brushes.Pink;
                    }
                    if (collectedRedsCount == maxReds && colourAfterFinalRed)
                    {
                        snookerBalls.Add(new BlueBall());
                        requiredColour = Brushes.Yellow;
                        colourAfterFinalRed = false;
                    }
                    break;
                case 6:
                    snookerBalls.Remove(ball);
                    if (collectedRedsCount < maxReds)
                    {
                        snookerBalls.Add(new PinkBall());
                    }
                    if (collectedRedsCount == maxReds && !colourAfterFinalRed)
                    {
                        requiredColour = Brushes.Black;
                    }
                    if (collectedRedsCount == maxReds && colourAfterFinalRed)
                    {
                        snookerBalls.Add(new PinkBall());
                        requiredColour = Brushes.Yellow;
                        colourAfterFinalRed = false;
                    }
                    break;
                case 7:
                    snookerBalls.Remove(ball);
                    if (collectedRedsCount < maxReds)
                    {
                        snookerBalls.Add(new BlackBall());
                    }
                    if (collectedRedsCount == maxReds && !colourAfterFinalRed)
                    {
                        Die();
                    }
                    if (collectedRedsCount == maxReds && colourAfterFinalRed)
                    {
                        snookerBalls.Add(new BlackBall());
                        requiredColour = Brushes.Yellow;
                        colourAfterFinalRed = false;
                    }
                    break;
            }
        }

        private void Die()
        {
            Settings.gameOver = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int WM_KEYDOWN = 0x100;
            const int WM_SYSKEYDOWN = 0x104;

            if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN))
            {
                switch (keyData)
                {
                    case Keys.Down:
                        Input.ChangeState(Keys.Down, true);
                        break;

                    case Keys.Up:
                        Input.ChangeState(Keys.Up, true);
                        break;

                    case Keys.Left:
                        Input.ChangeState(Keys.Left, true);
                        break;

                    case Keys.Right:
                        Input.ChangeState(Keys.Right, true);
                        break;

                    case Keys.Enter:
                        Input.ChangeState(Keys.Enter, true);
                        break;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
