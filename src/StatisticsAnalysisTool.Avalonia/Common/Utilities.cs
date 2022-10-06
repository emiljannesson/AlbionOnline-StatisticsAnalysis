using System;
using System.Globalization;

namespace StatisticsAnalysisTool.Avalonia.Common
{
    public static class Utilities
    {
        public static long GetHighestLength(params Array[] arrays)
        {
            long highestLength = 0;

            foreach (var array in arrays)
            {
                if (array.Length > highestLength)
                {
                    highestLength = array.Length;
                }
            }

            return highestLength;
        }

        //public static void CenterWindowOnScreen(MainWindow window)
        //{
        //    var screenWidth = SystemParameters.PrimaryScreenWidth;
        //    var screenHeight = SystemParameters.PrimaryScreenHeight;
        //    var windowWidth = window.Width;
        //    var windowHeight = window.Height;
        //    window.Left = (screenWidth / 2) - (windowWidth / 2);
        //    window.Top = (screenHeight / 2) - (windowHeight / 2);
        //}

        //public static bool IsWindowOpen<T>(string name = "") where T : Window
        //{
        //    return string.IsNullOrEmpty(name)
        //        ? Application.Current.Windows.OfType<T>().Any()
        //        : Application.Current.Windows.OfType<T>().Any(w => w.Name!.Equals(name));
        //}

        public static string UlongMarketPriceToString(ulong value)
        {
            return value.ToString("N0", new CultureInfo(LanguageController.CurrentCultureInfo?.TextInfo.CultureName ?? "0"));
        }

        public static double GetValuePerHourToDouble(double value, double seconds)
        {
            try
            {
                var hours = seconds / 60d / 60d;
                return value / hours;
            }
            catch (OverflowException)
            {
                return double.MaxValue;
            }
        }

        public static double GetValuePerSecondToDouble(double value, DateTime? combatStart, TimeSpan time, double maxValue = -1)
        {
            if (double.IsInfinity(value)) return maxValue > 0 ? maxValue : double.MaxValue;

            if (time.Ticks <= 1 && combatStart != null)
            {
                var startTimeSpan = DateTime.UtcNow - (DateTime)combatStart;
                var calculation = value / startTimeSpan.TotalSeconds;
                return calculation > maxValue ? maxValue : calculation;
            }

            var valuePerSeconds = value / time.TotalSeconds;
            if (maxValue > 0 && valuePerSeconds > maxValue) return maxValue;

            return valuePerSeconds;
        }

        public static bool IsBlockingTimeExpired(DateTime dateTime, int waitingSeconds)
        {
            var currentDateTime = DateTime.UtcNow;
            var difference = currentDateTime.Subtract(dateTime);
            return difference.Seconds >= waitingSeconds;
        }

        public static double AddValue(double value, double? lastValue, out double? newLastValue)
        {
            if (lastValue == null)
            {
                newLastValue = value;
                return 0;
            }

            var newValue = (double)(value - lastValue);
            if (newValue == 0)
            {
                newLastValue = value;
                return 0;
            }

            newLastValue = value;
            return newValue;
        }
    }
}