using System.Collections.Generic;
using System.Windows;
using wpf_rappel_OOP.Models;

namespace wpf_rappel_OOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Cake> cakes;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void CreateSomeThings()
        {
            /// Instanciation classique
            Car flash = new Car();
            flash.Brand = "Chevrolet";
            flash.Model = "Corvette C1";
            flash.Year = 1995;

            /// Méthode simplifiée
            Car herbie = new Car()
            {
                Brand = "VolksWagen",
                Model = "Beetle",
                Year = 1963
            };

            /// Méthode inférée
            var boumbo = new Car()
            {
                Brand = "Car",
                Model = "Yellow",
                Year = 1985
            };


            cakes = new List<Cake>();

            cakes.Add(new WeddingCake("Chocolate"));
            cakes.Add(new Cake("Vanilla"));
            cakes.Add(new BirthdayCake("Marbled"));

        }
    }
}
