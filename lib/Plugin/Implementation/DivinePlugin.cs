using ds.test.impl;
using System.Drawing;

namespace lib.Plugin.Implementation
{
    /// <summary>
    /// Плагин для деления
    /// </summary>
    internal class DivinePlugin : PluginBase
    {
        public override string PluginName { get; }
        public override string Version { get; }
        public override Image Image { get; } = null!;
        public override string Description { get; }

        public override int Run(int input1, int input2)
        {
            if (input2 == 0)
                throw new DivideByZeroException();

            return input1 / input2;
        }

        public DivinePlugin(string pluginName, string version, Image image, string description) 
        {
            PluginName = pluginName;
            Version = version;
            Image = image;
            Description = description;
        }
    }
}
