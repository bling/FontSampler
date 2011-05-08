using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace FontSampler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty CurrentFontProperty =
            DependencyProperty.Register("CurrentFont", typeof(FontFamily), typeof(MainWindow));

        public FontFamily CurrentFont
        {
            get { return (FontFamily)GetValue(CurrentFontProperty); }
            set { SetValue(CurrentFontProperty, value); }
        }

        public List<FontFamily> Fonts { get; private set; }

        public string Code
        {
            get { return @"
#region codinghorror.com
class Program : Object
{
    static int _I = 1;

    /// <summary>
    /// The quick brown fox jumps over the lazy dog
    /// THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG
    /// </summary>
    static void Main(string[] args)
    {
        Uri Illegal1Uri = new Uri(""http://packmyboxwith/jugs.html?q=five-dozen&t=liquor"");
        Regex OperatorRegex = new Regex(@""\S#$"", RegexOptions.IgnorePatternWhitespace);

        for (int O = 0; O &lt; 123456789; O++)
        {
            _I += (O % 3) * ((O / 1) ^ 2) - 5;
            if (!OperatorRegex.IsMatch(Illegal1Uri.ToString()))
            {
                Console.WriteLine(Illegal1Uri);
            }
        }
    }
}
#endregion
        "; }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Fonts = new List<FontFamily>(System.Windows.Media.Fonts.SystemFontFamilies);
        }
    }
}