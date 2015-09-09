using System;
using System.Collections.Generic; // stuff like this
using System.Linq; // This concept
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
//using System.Windows.Shapes;
using Shapes;
using System.Reflection;

namespace SharpShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetComboBoxItems();
        }
        
        private void SetComboBoxItems()
        {
            List<string> stuff = new List<string>();
            //stuff.Add("Square");
            //stuff.Add("Rectangle");
            var quadType = typeof(Quadrilateral);

            //combo1.ItemsSource = stuff; // combo1 came from <Combobox1> in xaml
            // Here only returning types that are a sublass of quadrilateral
            combo1.ItemsSource = Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes().Where(shapeType => shapeType.IsSubclassOf(typeof(Quadrilateral)));
        }

        // To do with the number of textboxes that need to be enabled
        // Give me the assembly for the class that matches this className
        public int NumberOfArguments(string className)
        {                                                                                                   /*Here's where className comes in*/
            var theClass = Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes().Where(shapeType => shapeType.Name == className).First();
            // Immediately referencing the prior variable in this theClassConstructor
            var theClassConstructor = theClass.GetConstructors().First();
            return theClassConstructor.GetParameters().Length;
        }

        // In xaml: Click="Button_Click"

        private void Button_Click (object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked!");
        }

        // This is kicked off by "Selection Changed" on combo1 in corresponding xaml file
        private void combo1_SelectionChanged (object sender, SelectionChangedEventArgs e)
        {
            // Saving the name/type of the shape selected in the combobox as a variable
            var classType = combo1.SelectedValue as Type;
            shapeWidth.IsEnabled = true;
            // Check out the argument count to determine if need to enable height
            // Pulling in the Name of the shape referenced in the above classType variable here
            int argCount = NumberOfArguments(classType.Name);
            // The height box will be enabled depending upon the result assigned to the argCount variable
            shapeHeight.IsEnabled = (argCount > 1);  // 2nd way: could say "if shapeName Rectangle"
        }
    }
}
