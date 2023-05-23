using Raylib_cs;
using Raylib_GUI;

namespace GUI
{ 
    class MainWindow
    { 
        public static void Main()
        {
            Button button = new Button();

            Raylib.InitWindow(640, 360, "button");
            Raylib.SetTargetFPS(50);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLANK);

                button.DrawRectangleButton(320, 180, 100, 50);

                Raylib.EndDrawing();
	        }
        }
    }
}