using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricKettleConsole.Services.IServices
{
    public interface IKettleActions
    {
        void Fill();
        void Boil();
        void Drain();
    }
}
