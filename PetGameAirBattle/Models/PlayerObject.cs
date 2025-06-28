using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PetGameAirBattle.Models
{
    class PlayerObject : BaseObject
    {
        public override void Draw(Canvas canvas)
        {
            if (UiElement == null)
            {
                // Создаем элемент
                var rect = new Rectangle
                {
                    Width = Width,
                    Height = Height,
                    Fill = Brushes.Blue
                };
                UiElement = rect;
                canvas.Children.Add(rect);
            }

            // Обновляем позицию
            Canvas.SetLeft(UiElement, X);
            Canvas.SetTop(UiElement, Y);
        }
    }
}
