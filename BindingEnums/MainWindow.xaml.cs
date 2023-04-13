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
            // this causes the initial Quality value to be
            // displayed in the ComboBox on startup, because
            // SelectedItem in bound to the Quality property
            Quality = Status.Best;
        }        

        private Status quality;

        
        public Status Quality
        {
            get { return quality; }
            set 
            { 
                quality = value;
                OnPropertyChanged(nameof(Quality));
            }
        }
        protected void OnPropertyChanged( string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
