namespace BMIapp;
using Microsoft.Maui.Controls;
using BMIapp.Models;

    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new BMIViewModel();
        }

       
    }
