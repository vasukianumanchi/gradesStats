﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! This is a great book program");
            GradeBook gBook = new GradeBook();
            gBook.AddGrade(91);
            gBook.AddGrade(89.5f);
            gBook.AddGrade(75);
            GradeStatistics stats = gBook.computeStatistics();
            Console.WriteLine("Average Grade is '" + stats.AverageGrade+"'");
            Console.WriteLine("Lowest Grade is '" + stats.LowestGrade+"'");
            Console.WriteLine("Highest Grade is '" + stats.HighestGrade+"'");
        }
    }
}
