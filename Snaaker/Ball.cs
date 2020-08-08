using System.Drawing;

namespace Snaaker
{    
    class Ball
    {
        public int x;
        public int y;
        public Brush ballColor;
        public int value;

    }

    class WhiteBall : Ball
    {
        public WhiteBall()
        {
            x = 32;
            y = 8;
            ballColor = Brushes.White;
            value = 0;
        }
    }

    class RedBall : Ball
    {
        public RedBall()
        {
            ballColor = Brushes.Red;
            value = 1;
        }
    }

    class YellowBall : Ball
    {
        public YellowBall()
        {
            x = 30;
            y = 6;
            ballColor = Brushes.Yellow;
            value = 2;
        }
    }

    class GreenBall : Ball
    {
        public GreenBall()
        {
            x = 30;
            y = 14;
            ballColor = Brushes.Green;
            value = 3;
        }
    }

    class BrownBall : Ball
    {
        public BrownBall()
        {
            x = 30;
            y = 10;
            ballColor = Brushes.Brown;
            value = 4;
        }
    }

    class BlueBall : Ball
    {
        public BlueBall()
        {
            x = 20;
            y = 10;
            ballColor = Brushes.Blue;
            value = 5;
        }
    }

    class PinkBall : Ball
    {
        public PinkBall()
        {
            x = 12;
            y = 10;
            ballColor = Brushes.Pink;
            value = 6;
        }
    }

    class BlackBall : Ball
    {
        public BlackBall()
        {
            x = 5;
            y = 10;
            ballColor = Brushes.Black;
            value = 7;
        }
    }
}
