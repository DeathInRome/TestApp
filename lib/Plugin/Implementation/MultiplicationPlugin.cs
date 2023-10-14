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

        public override int Run(int input1, int input2)
        {
            return input1 * input2;
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
