using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX;
using SharpDX.DirectInput;

namespace prs_simple_pedal_app
{
    public partial class Form1 : Form
    {
        private DirectInput _directInput;
        private Joystick _joystick;
        private Timer _timer;
        public Form1()
        {
            InitializeComponent();
            InitializeJoystick();
            InitializeTimer();
            
        }

        private void InitializeJoystick()
        {
            var _directInput = new DirectInput();

            // Localize o primeiro dispositivo de joystick conectado
            var joystickGuid = Guid.Empty;

            foreach (var deviceInstance in _directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                joystickGuid = deviceInstance.InstanceGuid;

            if (joystickGuid == Guid.Empty)
            {
                foreach (var deviceInstance in _directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;
            }

            if (joystickGuid == Guid.Empty)
            {
                MessageBox.Show("Nenhum joystick/gamepad encontrado.");
                return;
            }

            _joystick = new Joystick(_directInput, joystickGuid);

            _joystick.Properties.AxisMode = DeviceAxisMode.Absolute;
            _joystick.Acquire();

        }

        private void InitializeTimer()
        {
            _timer = new Timer();
            _timer.Interval = 100; // Intervalo de 100ms
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_joystick != null)
            {
                JoystickState status = new JoystickState();
                _joystick.GetCurrentState(ref status);
                _joystick.Poll();

                if (status.X > 225000)
                {
                    status.X = 225000;
                }

                if (status.Y > 225000)
                {
                    status.Y = 225000;
                }

                if (status.RotationX > 225000)
                {
                    status.RotationX = 225000;
                }

                acceleratorBar.Value = status.Y;
                brakeBar.Value = status.X;
                clutchBar.Value = status.RotationX;

            }
        }

 
    }
}
