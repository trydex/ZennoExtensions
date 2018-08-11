using System;
using ZennoLab.CommandCenter;

namespace ZennoExtensionsNew.Extensions
{
    public static class TabExtensions
    {
        /// <summary>
        /// Ожидать, пока на странице не будет найден HTML элемент с указанным XPath.
        /// </summary>
        /// <param name="tab">Tab</param>
        /// <param name="xpath">XPath для поиска.</param>
        /// <param name="timeout">Длительность поиска в миллисекундах. По умолчанию 5000.</param>
        /// <returns></returns>
        public static void Wait(this Tab tab, string xpath, long timeout = 5000)
        {
            for (var i = 0; i < timeout / 100; i++)
            {
                if (!tab.FindElementByXPath(xpath, 0).IsVoid)
                {
                    return;
                }
                System.Threading.Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Ожидать, пока не будет выполнено выражение предиката.
        /// </summary>
        /// <param name="tab">Tab</param>
        /// <param name="predicate">Условное выражение.</param>
        /// <param name="timeout">Длительность проверки выражения в миллисекундах. По умолчанию 5000.</param>
        /// <returns></returns>
        public static void Wait(this Tab tab, Func<bool> predicate, long timeout = 5000)
        {
            for (var i = 0; i < timeout / 100; i++)
            {
                if (predicate.Invoke())
                {
                    return;
                }
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}   