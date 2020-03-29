using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ElectricKettleConsole.Services.IServices;

namespace ElectricKettleConsole.Services
{
    public class SingletonKettleContainer : IKettleActions
    {
        private SingletonKettleContainer()
        {
            Console.WriteLine("Starting");
        }
        public void Fill()
        {
            Console.WriteLine("Filling...");
            Thread.Sleep(3000);
        }

        public void Boil()
        {
            Console.WriteLine("Boiling...");
            Thread.Sleep(3000);
        }

        public void Drain()
        {
            Console.WriteLine("Draining...");
            Thread.Sleep(3000);
        }

        private static readonly Lazy<SingletonKettleContainer> instance = new Lazy<SingletonKettleContainer>(() => new SingletonKettleContainer());
        public static SingletonKettleContainer Instance => instance.Value;
    }
}
