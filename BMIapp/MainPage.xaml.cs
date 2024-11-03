namespace BMIapp;
using Microsoft.Maui.Controls;
using BMIapp.Models;


    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new BMIViewModel();
        }
    }
