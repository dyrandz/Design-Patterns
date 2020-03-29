using System;
using ElectricKettleConsole.Services;

namespace ElectricKettleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var kettle = SingletonKettleContainer.Instance;
            
            kettle.Invoke(KettleStatus.Empty);
            kettle.Invoke(KettleStatus.InProgress);
            kettle.Invoke(KettleStatus.Boiled);
        }
    }
}
