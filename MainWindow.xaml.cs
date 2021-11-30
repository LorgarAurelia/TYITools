using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TYITools.Models.Rules;
using TYITools.Models.Units;
using TYITools.Models.Units.Tanks;

namespace MongoDBTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Armour> ListOfArmours = new();
        private List<UnitsRules> WeaponsSpecialRules = new();
        private List<Weapons> ListOfWeapons = new();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddArmour_Click(object sender, RoutedEventArgs e)
        {
            Armour CurrentArmour = new();

            CurrentArmour.Front = int.Parse(Front.Text);
            CurrentArmour.Side = int.Parse(Side.Text);
            CurrentArmour.Top = int.Parse(Top.Text);

            ListOfArmours.Add(CurrentArmour);
        }

        private void AddWeapon_Click(object sender, RoutedEventArgs e)
        {
            Weapons weapon = new();

            weapon.Name = WeaponName.Text;
            weapon.Range = Range.Text;
            weapon.Halted = Halted.Text;
            weapon.Moved = Moved.Text;
            weapon.Antitank = int.Parse(AntiTank.Text);
            weapon.FirePower = int.Parse(FirePower.Text);
            weapon.Notes = WeaponsSpecialRules;

            ListOfWeapons.Add(weapon);
        }

        private void AddSpecialRules_Click(object sender, RoutedEventArgs e)
        {
            UnitsRules SpecialRules = new();

            SpecialRules.Reference = Reference.Text;
            SpecialRules.Name = WeaponSpecialRule.Text;
            SpecialRules.Text = WeaponSpecialRuleText.Text;

            WeaponsSpecialRules.Add(SpecialRules);
        }
    }
}
