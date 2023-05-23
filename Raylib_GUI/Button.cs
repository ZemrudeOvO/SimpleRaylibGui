using Raylib_cs;
using System.Numerics;

namespace Raylib_GUI
{
    public class Button
    {
        public delegate void Pressed();
        public event Pressed? pressed;

        int x, y, width, height,radius;
        Color baseColor = Color.DARKGRAY;
        Color highLightColor = Color.GRAY;
        Color pressedColor = Color.LIGHTGRAY;

        public void DrawRectangleButton(int _x, int _y, int _width, int _height)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;

            Raylib.DrawRectangle(x, y, width, height, baseColor);

            if (Raylib.GetMouseX() <= x + width && Raylib.GetMouseX() >= x && Raylib.GetMouseY() <= y + height && Raylib.GetMouseY() > y)
            {
                Raylib.DrawRectangle(x, y, width, height, highLightColor);

                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
                {
                    Raylib.DrawRectangle(x, y, width, height, pressedColor);
                    Raylib.DrawRectangleLinesEx(new Rectangle(x, y, width, height), 2, Color.WHITE);

                    if (pressed != null)
                    {
                        pressed();
                    }
                }
            }
        }

        public void DrawCircleButton(int _x, int _y, int _radius)
        {
            x = _x;
            y = _y;
            radius = _radius;

            Raylib.DrawCircle(x, y, radius, baseColor);

            if (Vector2.Distance(Raylib.GetMousePosition(), new Vector2(x, y)) <= radius)
            {
                Raylib.DrawCircle(x, y, radius, highLightColor);

                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
                {
                    Raylib.DrawCircle(x, y, radius, pressedColor);
                    Raylib.DrawCircleLines(x, y, radius, Color.WHITE);

                    if (pressed != null)
                    {
                        pressed();
                    }
                }
            }
        }
    }
}

