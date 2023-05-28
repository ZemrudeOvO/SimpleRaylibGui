using System;
using Raylib_cs;

namespace Raylib_GUI
{
	public abstract class BaseSlider
	{
        public int x, y, width, height;
        public int handleWidth = 10;
        public Color handleColor = Color.LIGHTGRAY, baseColor = Color.DARKGRAY;
        public float minValue = 0, maxValue = 100, value = 0;
    }

    public class HSlider : BaseSlider
    {
        public void DrawHSlider(int _x, int _y, int _width, int _height)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            Raylib.DrawRectangle(x, y, width, height, Color.DARKGRAY);
            Raylib.DrawRectangle(x, y, handleWidth, height, Color.GRAY);
            if (Raylib.GetMouseX() <= x + handleWidth && Raylib.GetMouseX() >= x && Raylib.GetMouseY() <= y + height && Raylib.GetMouseY() >= y)
            {
                Raylib.DrawRectangle(x, y, handleWidth, height, Color.LIGHTGRAY);
                
                if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT))
                {
                    Raylib.DrawRectangle(Raylib.GetMouseX(), y, handleWidth, height, Color.LIGHTGRAY);
		        }
	        }
        }
    }

    public class VSlider : BaseSlider
    { 
    }
}

