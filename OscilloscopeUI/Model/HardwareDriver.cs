using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OscilloscopeUI.Model
{
    internal class HardwareDriver
    {
        [DllImport("HardwareEmulator.dll")]
        public static extern float GetVoltage();
    }
}
