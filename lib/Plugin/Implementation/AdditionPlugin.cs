using System.Drawing;

namespace ds.test.impl
{
    /// <summary>
    /// Плагин для сложения
    /// </summary>
    internal class AdditionPlugin : PluginBase
    {
        public override string PluginName { get; }
        public override string Version  { get; }
        public override Image Image { get; } = null!;
        public override string Description { get; }

        /// <summary>
        /// Складывает два числа
        /// </summary>
        public override int Run(int value1, int value2)
        {
            return value1 + value2;
        }

        public AdditionPlugin(string pluginName, string version, Image image, string description) 
        {
            PluginName = pluginName;
            Version = version;
            Image = image;
            Description = description;
        }

    }

}
