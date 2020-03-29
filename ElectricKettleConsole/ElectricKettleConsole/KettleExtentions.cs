using System;
using System.Collections.Generic;
using System.Text;
using ElectricKettleConsole.Services;

namespace ElectricKettleConsole
{
    public static class KettleExtentions
    {
        public static void Invoke(this SingletonKettleContainer kettle, KettleStatus status)
        {
            switch (status)
            {
                case KettleStatus.Empty:
                    kettle.Fill();
                    break;
                case KettleStatus.InProgress:
                    kettle.Boil();
                    break;
                case KettleStatus.Boiled:
                    kettle.Drain();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
