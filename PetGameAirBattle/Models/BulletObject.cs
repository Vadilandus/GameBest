using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PetGameAirBattle.Models
{
    // ToDo: Сделать класс для пули, реализовать ее отрисовку в этом классе
    // а также добавиь метод, который изменяет ее положение по оси X.
    internal class BulletObject : BaseObject
    {
        public override void Draw(Canvas canvas)
        {
            // Думаю это условие не нужно, потому что пуль может быть
            // сколько угодно во время "матча" :)
            // либо как у игры родителя, сделать только 3 выстрела,
            // а потом перезарядка.
            if (UiElement == null)
            {
                // Создаем элемент
                var rect = new Ellipse
                {
                    Width = Width,
                    Height = Height,
                    Fill = Brushes.Red
                };

                UiElement = rect;
                canvas.Children.Add(rect);
            }

            // Обновляем позицию
            Canvas.SetLeft(UiElement, base.X);
            Canvas.SetTop(UiElement, base.Y);
        }
    }
}
