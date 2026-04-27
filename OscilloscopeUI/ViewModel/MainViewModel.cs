using System.ComponentModel;
using System.Threading.Tasks;
using LiveCharts;
using OscilloscopeUI.Model;
using LiveCharts;
using LiveCharts.Wpf;

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

        public SeriesCollection VoltageGraph { get; set; } = new SeriesCollection
        {
            new LineSeries
            {
                Title = "Voltage",
                Values = new ChartValues<float>()
            }
        };

        public async Task StartReadingAsync()
        {
            while (true)
            {
                try
                {
                    float voltage = HardwareDriver.GetVoltage();
                    VoltageText = voltage.ToString("F2") + " V";
                    VoltageGraph[0].Values.Add(voltage);
                    if (VoltageGraph[0].Values.Count > 100)
                    {
                        VoltageGraph[0].Values.RemoveAt(0);
                    }
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