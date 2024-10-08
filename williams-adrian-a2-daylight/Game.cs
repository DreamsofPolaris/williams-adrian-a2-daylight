// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color daySky = new Color(0x7f, 0xa8, 0xb5);
        Color nightSky = new Color(0x4c, 0x54, 0x9b);
        Color sun = new Color(0xff, 0xfd, 0x95);
        Color moon = new Color(0xfe, 0xfe, 0xfe);
        Color clouds = new Color(0x78, 0x78, 0x9e);

        float xCursor;
        float nightzone = 200;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Day to Night");

            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(daySky);
            
            MakeCloud();

            Draw.LineSize = 0;
            Draw.FillColor = sun;
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 50);

            xCursor = Input.GetMouseX();

            if (xCursor > nightzone)
            {
                Window.ClearBackground(nightSky);
                Draw.FillColor = moon;
                Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 50);
            }

        }
        void MakeCloud()
        {
            Draw.LineSize = 0;
            Draw.FillColor = clouds;
            for (int i = 0; i < 2; i++)
            {
                int xoffset = i * 50;
                Draw.Circle(100 + xoffset, 200, 35);
            }
            for (int i = 0; i < 3; i++)
            {
                int xoffset = i * 50;
                Draw.Circle(80 + xoffset, 230, 35);
            }
        }
    }
}
