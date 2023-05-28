using Raylib_cs;
using System.Numerics;

namespace Raylib_GUI
{
    public abstract class BaseButton
    {
        protected Color baseColor = Color.DARKGRAY;
        protected Color highLightColor = Color.GRAY;
        protected Color pressedColor = Color.LIGHTGRAY;
    }

    public class RectangleButton : BaseButton
    {
        int x, y, width, height;

        public delegate void Pressed();
        public event Pressed? pressed;

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

                if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT))
                {
                    Raylib.DrawRectangle(x, y, width, height, pressedColor);
                    Raylib.DrawRectangleLinesEx(new Rectangle(x, y, width, height), 2, Color.WHITE);
                }

                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
                {
                    if (pressed != null)
                    {
                        pressed();
                    }
                }
            }
        }
    }
    public class CircleButton : BaseButton
    {
        int x, y, radius;

        public delegate void Pressed();
        public event Pressed? pressed;

        public void DrawCircleButton(int _x, int _y, int _radius)
        {
            x = _x;
            y = _y;
            radius = _radius;

            Raylib.DrawCircle(x, y, radius, baseColor);

            if (Vector2.Distance(Raylib.GetMousePosition(), new Vector2(x, y)) <= radius)
            {
                Raylib.DrawCircle(x, y, radius, highLightColor);

                if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT))
                { 
                    Raylib.DrawCircle(x, y, radius, pressedColor);
                    Raylib.DrawCircleLines(x, y, radius, Color.WHITE);
		        }

                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
                {
                    if (pressed != null)
                    {
                        pressed();
                    }
                }
            }
        }
    }
}

