﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingWindow.WindowCommands
{
    internal class WindowLeftCommand : IWindowCommand
    {
        private Form currentForm;
        private int pixelsPerMove;

        public WindowLeftCommand(Form currentForm, int pixelsPerMove)
        {
            this.currentForm = currentForm;
            this.pixelsPerMove = pixelsPerMove;
        }

        public bool IsCommandAvailable(KeyEventArgs commandKey)
        {
            bool isCommandAvailable = false;
            if (commandKey.KeyData == Keys.Left)
            {
                isCommandAvailable = true;
            }
            return isCommandAvailable;
        }

        public void PerformCommand(KeyEventArgs commandKey)
        {
            if (commandKey.KeyData == Keys.Left)
            {
                if (currentForm.Left + currentForm.Width - pixelsPerMove > Screen.PrimaryScreen.Bounds.Width)
                {
                    currentForm.Left = currentForm.Left - pixelsPerMove;
                }
                else
                {
                    currentForm.Left = 0;
                }
            }
        }
    }
}
