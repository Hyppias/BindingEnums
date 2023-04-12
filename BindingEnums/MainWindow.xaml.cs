using System.ComponentModel;
using System.Windows;

namespace BindingEnums
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// <seealso cref="https://www.youtube.com/watch?v=Bp5LFXjwtQ0">
    /// Lagunas
    /// </seealso>
    /// </summary>
    public partial class MainWindow : Window , INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext=this;
            Bad = Status.Best;
        }        

        private Status bad;

        
        public Status Bad
        {
            get { return bad; }
            set 
            { 
                bad = value;
                OnPropertyChanged(nameof(Bad));
            }
        }
        protected void OnPropertyChanged( string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
