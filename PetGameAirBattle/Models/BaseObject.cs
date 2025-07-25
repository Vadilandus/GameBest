﻿using PetGameAirBattle.ConstValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PetGameAirBattle.Models
{
    abstract class BaseObject
    {
        public double X { get; set; } = Consts._zeroValue;
        public double Y { get; set; } = Consts._zeroValue;
        public double Width { get; set; }
        public double Height { get; set; }
        public UIElement? UiElement { get; protected set; }
        public abstract void Draw(Canvas canvas);
    }
}
