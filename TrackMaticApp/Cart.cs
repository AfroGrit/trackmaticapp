using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace TrackMaticApp
{
    public enum Type
    {
        Local,
        Import,
        Exempt
    }

    public class Cart : INotifyPropertyChanged, IDisposable
    {
        private string _name;

        public Type Type { get; }

        public List<string> Item { get; }

        public Cart(Type type)
        {
            Type = type;
            Item = new List<string>();
        }

        public Cart(Type type, string name, double amount) : this(type)
        {
            Name = name;
            Amount = amount;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public double Amount { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return Name;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public void Dispose()
        {
        }


    }
}