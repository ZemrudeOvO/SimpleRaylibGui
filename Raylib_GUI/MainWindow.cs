using Raylib_cs;
using Raylib_GUI;

namespace GUI
{ 
    class MainWindow
    { 
        public static void Main()
        {
            Button button = new Button();
            button.pressed += () => Console.WriteLine("pressed");

            Raylib.InitWindow(640, 360, "button");
            Raylib.SetTargetFPS(50);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLANK);

                button.DrawRectangleButton(50, 50, 100, 50);
                button.DrawCircleButton(320, 180, 25);

                Raylib.EndDrawing();
	        }
        }
    }
}