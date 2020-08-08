using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snaaker
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public static class Settings
    {
        public static int width = 20;
        public static int height = 20;
        public static int speed = 15;
        public static int score = 0;
        public static int points = 0;
        public static bool gameOver = false;
        public static Direction direction = Direction.Left;

        public static void ResetSettings()
        {
            width = 20;
            height = 20;
            speed = 15;
            score = 0;
            points = 0;
            gameOver = false;
            direction = Direction.Left;
        }
    }
}
