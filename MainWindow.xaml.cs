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
using TYITools.MongoService;

namespace MongoDBTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Armour> ListOfArmours = new();
        private List<UnitsRules> UnitRules = new();
        private List<UnitsRules> WeaponSpecialRules = new();
        private List<Weapons> ListOfWeapons = new();
        private TankUnit Unit = new();
        private List<Options> Options = new();


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
            weapon.Notes = WeaponSpecialRules;

            ListOfWeapons.Add(weapon);

            WeaponSpecialRules = new();
        }

        private void AddSpecialRules_Click(object sender, RoutedEventArgs e)
        {
            UnitsRules SpecialRule = new();

            SpecialRule.Reference = Reference.Text;
            SpecialRule.Name = WeaponSpecialRule.Text;
            SpecialRule.Text = WeaponSpecialRuleText.Text;

            WeaponSpecialRules.Add(SpecialRule);
        }

        private void AddUnitSpecialRules_Click(object sender, RoutedEventArgs e)
        {
            UnitsRules SpecialRule = new();

            SpecialRule.Reference = UnitReference.Text;
            SpecialRule.Name = UnitSpecialRules.Text;
            SpecialRule.Text = UnitSpecialRuleText.Text;

            UnitRules.Add(SpecialRule);
        }

        private async Task SaveUnit_ClickAsync(object sender, RoutedEventArgs e)
        {
            Unit.Courage = int.Parse(CourageTank.Text);
            Unit.Morale = int.Parse(MoraleTank.Text);
            Unit.Remount = int.Parse(Remount.Text);
            Unit.Skill = int.Parse(Skill.Text);
            Unit.Assault = int.Parse(Assault.Text);
            Unit.CounterAttack = int.Parse(CounterAttack.Text);
            Unit.IsHitOn = int.Parse(IsHitOn.Text);
            Unit.Armours = ListOfArmours;
            Unit.Tactical = Tacticel.Text;
            Unit.TerrainDash = TerrainDash.Text;
            Unit.CrossCountryDash = CrossCountryDash.Text;
            Unit.RoadDash = RoadDash.Text;
            Unit.Cross = int.Parse(Cross.Text);
            Unit.Weapons = ListOfWeapons;
            Unit.SpecialRules = UnitRules;
            Unit.Options = Options;

            await Insert.SaveTankDocsAsync(Unit);

            ListOfArmours = new();
            ListOfWeapons = new();
            UnitRules = new();
            Options = new();
        }

        private void AddOption_Click(object sender, RoutedEventArgs e)
        {
            Options option = new();

            option.Quantity = int.Parse(Quantity.Text);
            option.Content = Content.Text;
            option.Cost = int.Parse(Cost.Text);

            Options.Add(option);
        }
    }
}
