using System;
using System.Collections.Generic;
using System.Text;
using ElectricKettleConsole.Services;

namespace ElectricKettleConsole
{
    public static class KettleExtentions
    {
        public static void Invoke(this SingletonKettleContainer kettle, KettleStatusEnum.KettleStatus status)
        {
            switch (status)
            {
                case KettleStatusEnum.KettleStatus.Empty:
                    kettle.Fill();
                    break;
                case KettleStatusEnum.KettleStatus.InProgress:
                    kettle.Boil();
                    break;
                case KettleStatusEnum.KettleStatus.Boiled:
                    kettle.Drain();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
