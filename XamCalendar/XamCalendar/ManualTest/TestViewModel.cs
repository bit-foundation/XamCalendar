﻿using System.ComponentModel;

namespace XamCalendar
{
    public class TestViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Test { get; set; } = "Test";
    }
}
