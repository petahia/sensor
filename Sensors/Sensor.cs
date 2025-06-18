namespace Sensors
{

    public enum SensorType
    {
        Thermal, Audio, Motion, Pulse, Magnetic, Signal, Light
    }



    internal class Sensor
    {
        public SensorType Type { get; set; }


        public Sensor() { }

        void Activate()
        {

        }

        

    }
}  