namespace Binner.Model.Common
{
    /// <summary>
    /// Global default data
    /// </summary>
    public static class SystemDefaults
    {
        /// <summary>
        /// The part should be reordered when it gets below this value
        /// </summary>
        public const int LowStockThreshold = 1;

        /// <summary>
        /// Default part type definitions
        /// </summary>
        public enum DefaultPartTypes
        {
            Resistor = 1,
            Capacitor,
            Inductor,
            Diode,
            LED,
            Transistor,
            Relay,
            Transformer,
            Crystal,
            Sensor,
            Switch,
            Cable,
            Connector,
            IC,
            Hardware,
            Other,
            [ParentPartType(DefaultPartTypes.IC)]
            OpAmp,
            [ParentPartType(DefaultPartTypes.IC)]
            Amplifier,
            [ParentPartType(DefaultPartTypes.IC)]
            Memory,
            [ParentPartType(DefaultPartTypes.IC)]
            Logic,
            [ParentPartType(DefaultPartTypes.IC)]
            Interface,
            [ParentPartType(DefaultPartTypes.IC)]
            Microcontroller,
            [ParentPartType(DefaultPartTypes.IC)]
            Clock,
            [ParentPartType(DefaultPartTypes.IC)]
            ADC,
            [ParentPartType(DefaultPartTypes.IC)]
            VoltageRegulator,
            [ParentPartType(DefaultPartTypes.IC)]
            EnergyMetering,
            [ParentPartType(DefaultPartTypes.IC)]
            LedDriver,
            [ParentPartType(DefaultPartTypes.Transistor)]
            MOSFET,
            [ParentPartType(DefaultPartTypes.Transistor)]
            IGBT,
            [ParentPartType(DefaultPartTypes.Transistor)]
            JFET,
            [ParentPartType(DefaultPartTypes.Transistor)]
            SCR,
            [ParentPartType(DefaultPartTypes.Transistor)]
            DIAC,
            [ParentPartType(DefaultPartTypes.Transistor)]
            TRIAC,
        }
    }
}
