﻿using Microsoft.VisualBasic;

namespace BlazorServerDemo.Data
{
    public class Demo : IDemo
    {
        public DateTime StartupTime { get; init; }

        public Demo()
        {
            StartupTime = DateTime.Now;
        }
    }
}
