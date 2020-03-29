using System;
using ElectricKettleConsole.Services;

namespace ElectricKettleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var kettle = SingletonKettleContainer.Instance;
            
            kettle.Invoke(KettleStatusEnum.KettleStatus.Empty);
            kettle.Invoke(KettleStatusEnum.KettleStatus.InProgress);
            kettle.Invoke(KettleStatusEnum.KettleStatus.Boiled);
        }
    }
}
