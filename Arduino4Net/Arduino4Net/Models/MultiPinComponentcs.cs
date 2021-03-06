﻿using System.Collections.Generic;
using Arduino4Net.Interfaces;

namespace Arduino4Net.Models
{
    public abstract class MultiPinComponentcs : Component
    {
        public MultiPinComponentcs(IArduino board, IEnumerable<int> pins, ITimer timer = null)
            : base(board, timer)
        {
            Pins = pins;
        }

        public IEnumerable<int> Pins { get; set; }

        protected void SetPinMode(PinMode mode)
        {
            foreach (var pin in Pins)
            {
                Board.PinMode(pin, mode);
            }
        }
    }
}