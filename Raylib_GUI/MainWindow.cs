using Raylib_cs;
using Raylib_GUI;

namespace GUI
{ 
    class MainWindow
    { 
        public static void Main()
        {
            RectangleButton rectangleButton = new RectangleButton();
            CircleButton circleButton = new CircleButton();

            rectangleButton.pressed += () => Console.WriteLine("rect");
            circleButton.pressed += () => Console.WriteLine("circle");

            Raylib.InitWindow(640, 360, "button");
            Raylib.SetTargetFPS(50);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLANK);

                rectangleButton.DrawRectangleButton(50, 50, 100, 50);
                circleButton.DrawCircleButton(320, 180, 25);

                Raylib.EndDrawing();
	        }
        }
    }
}