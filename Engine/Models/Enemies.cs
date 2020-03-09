using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engine.Models
{
    public class Enemies : INotifyPropertyChanged
    {
        public string _nameEnemies;
        public int _expierncePointsForKilling;
        public int _heatPoint;




        public event PropertyChangedEventHandler PropertyChanged;
    }
}
