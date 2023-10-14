using System.Drawing;

namespace ds.test.impl
{
    public interface IPlugin
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string PluginName { get; }
        /// <summary>
        /// Версия
        /// </summary>
        string Version { get; }
        /// <summary>
        /// Изображение
        /// </summary>
        Image Image { get; }
        /// <summary>
        /// Описание
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Выполнить
        /// </summary>
        int Run(int input1, int input2);
    }
}