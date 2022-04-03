using System;
using System.Collections.ObjectModel;

namespace Hangman.Models
{
    [Serializable]
    public class Users
    {
        public ObservableCollection<User> List { get; set; } = new ObservableCollection<User>();
    }
}
