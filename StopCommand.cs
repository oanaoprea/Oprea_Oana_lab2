﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Oprea_Oana_lab2.CustomCommands
{
    class StopCommand
    {
        private static RoutedUICommand launch_command;

        static StopCommand()
        {
            InputGestureCollection myInputGestures = new InputGestureCollection();
            myInputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
            launch_command = new RoutedUICommand("Launch", "Launch",
typeof(StopCommand), myInputGestures);
        }

        public static RoutedUICommand Launch
        {
            get
            {
                return launch_command;
            }
        }
    }
}

