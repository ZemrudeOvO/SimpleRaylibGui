using Raylib_cs;
using Raylib_GUI;

namespace GUI
{ 
    class MainWindow
    { 
        public static void Main()
        {
            #region Button
            RectangleButton rectangleButton = new RectangleButton();
            CircleButton circleButton = new CircleButton();

            rectangleButton.pressed += () => Console.WriteLine("rect");
            circleButton.pressed += () => Console.WriteLine("circle");
            #endregion

            Raylib.InitWindow(640, 360, "button");
            Raylib.SetTargetFPS(50);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLANK);

                #region Button
                rectangleButton.DrawRectangleButton(50, 50, 100, 50);
                circleButton.DrawCircleButton(320, 180, 25);
                #endregion

                Raylib.EndDrawing();
	        }
        }
    }
}