using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private string _name;
        private string _characterClass;
        private int _hitpoints;
        private int _expirecePiont;
        private int _lavel;
        private int _gold;



        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string CharacterClass
        {
            get { return _characterClass; }
            set
            {
                _characterClass = value;
                OnPropertyChanged("CharacterClass");
            }

        }
        public int HitPoints
        {
            get { return _hitpoints; }
            set
            {
                _hitpoints = value;
                OnPropertyChanged("HitPoints");
            }

        }
        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }

        }
        public int ExperiencePoints
        {
            get { return _expirecePiont; }
            set
            {
                _expirecePiont = value;
                OnPropertyChanged("ExperiencePoints");
            }

        }
        public int Level
        {
            get { return _lavel; }
            set
            {
                _lavel = value;
                OnPropertyChanged("Level");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}