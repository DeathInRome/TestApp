using ds.test.impl;
using System.Drawing;

namespace lib.Plugin.Implementation
{
    /// <summary>
    /// Плагин для деления
    /// </summary>
    internal class DivisionPlugin : PluginBase
    {
        public override string PluginName { get; }
        public override string Version { get; }
        public override Image Image { get; } = null!;
        public override string Description { get; }

    /// <summary>
    /// Делит первое число на второе число
    /// </summary>
    /// <param name="value1">Делимое</param>
    /// <param name="value2">Делитель</param>
        public override int Run(int value1, int value2)
        {
            if (value2 == 0)
                throw new DivideByZeroException();

            return value1 / value2;
        }

        public DivisionPlugin(string pluginName, string version, Image image, string description) 
        {
            PluginName = pluginName;
            Version = version;
            Image = image;
            Description = description;
        }
    }
}
