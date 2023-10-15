using System.Drawing;

namespace ds.test.impl
{
    /// <summary>
    /// Плагин для умножения
    /// </summary>
    internal class MultiplicationPlugin : PluginBase
    {
        public override string PluginName { get; }
        public override string Version { get; }
        public override Image Image { get; } = null!;
        public override string Description { get; }

        /// <summary>
        /// Перемножает два числа
        /// </summary>
        public override int Run(int value1, int value2)
        {
            return value1 * value2;
        }

        public MultiplicationPlugin(string pluginName, string version, Image image, string description) 
        {
            PluginName = pluginName;
            Version = version;
            Image = image;
            Description = description;
        }
    }
}
