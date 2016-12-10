﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"ukulele.wav");
            simpleSound.PlayLooping();
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            playSimpleSound();
            Application.Run(new Menu());
        }
    }
}
