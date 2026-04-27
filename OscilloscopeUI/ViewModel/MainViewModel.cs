using System.ComponentModel;
using System.Threading.Tasks;
using OscilloscopeUI.Model;

namespace OscilloscopeUI.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _voltageText;
        public string VoltageText
        {
            get { return _voltageText; }
            set
            {
                _voltageText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(VoltageText)));
            }
        }

        public MainViewModel()
        {
            VoltageText = "starting..."; 
        }

        public async Task StartReadingAsync()
        {
            while (true)
            {
                try
                {
                    float voltage = HardwareDriver.GetVoltage();
                    VoltageText = voltage.ToString("F2") + " V";
                }
                catch (Exception ex)
                {
                    VoltageText = "ERRORE: " + ex.Message;
                    break;
                }
                await Task.Delay(100);
            }
        }
    }
}