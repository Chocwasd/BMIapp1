using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BMIapp.Models
{
   public class BMIViewModel : INotifyPropertyChanged
    {
        private double _height;
        private double _weight;
        private double _result;
        private string _resultText;

        public double Height
        {
            get => _height;
            set
            {
                _height = value;
                OnPropertyChanged();
                CalculateBMI();
            }
        }

        public double Weight
        {
            get => _weight;
            set
            {
                _weight = value;
                OnPropertyChanged();
                CalculateBMI();
            }
        }

        public double Result
        {
            get => _result;
            private set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        public string ResultText
        {
            get => _resultText;
            private set
            {
                _resultText = value;
                OnPropertyChanged();
            }
        }

        public BMIViewModel()
        {
            Height = 170; // Default height in cm
            Weight = 70;  // Default weight in kg
        }

        private void CalculateBMI()
        {
            if (Height > 0)
            {
                double heightInMeters = Height / 100;
                Result = Weight / (heightInMeters * heightInMeters);

                // Determine BMI category
                if (Result < 16)
                    ResultText = "Severely Underweight";
                else if (Result < 17)
                    ResultText = "Moderately Underweight";
                else if (Result < 18.5)
                    ResultText = "Mildly Underweight";
                else if (Result < 25)
                    ResultText = "Normal";
                else if (Result < 30)
                    ResultText = "Overweight";
                else
                    ResultText = "Obese";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}