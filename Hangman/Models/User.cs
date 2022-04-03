using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Hangman.Models
{
    [Serializable]
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [XmlAttribute]
        private string name;
        [XmlAttribute]
        private int imageIndex;
        [XmlAttribute]
        private Game game;
        [XmlAttribute]
        private Statistics statistics = new Statistics();

        public User()
        {

        }

        public User(string name, int imageIndex)
        {
            Name = name;
            ImageIndex = imageIndex;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public int ImageIndex
        {
            get
            {
                return imageIndex;
            }
            set
            {
                imageIndex = value;
                NotifyPropertyChanged("ImageIndex");
            }
        }

        public Game GameProperty
        {
            get
            {
                return game;
            }
            set
            {
                game = value;
                NotifyPropertyChanged("GameProperty");
            }
        }

        public Statistics StatisticsProperty
        {
            get
            {
                return statistics;
            }
            set
            {
                statistics = value;
                NotifyPropertyChanged("StatisticsProperty");
            }
        }
    }
}
