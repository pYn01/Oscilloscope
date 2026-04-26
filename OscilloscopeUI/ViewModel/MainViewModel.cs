using System.ComponentModel;
using System.Threading.Tasks;
using OscilloscopeUI.Models;

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
                // TUO COMPITO QUI DENTRO:
                // 1. Chiama HardwareDriver.GetVoltage() per farti dare il numero (il float).
                // 2. Trasforma il numero in stringa (es. con .ToString("F2")) e aggiungi " V".
                // 3. Salva la stringa dentro la proprietà 'VoltageText'.

                // 4. Metti in pausa il ciclo per 100 millisecondi per non fondere il PC
                await Task.Delay(100);
            }
        }
    }
}