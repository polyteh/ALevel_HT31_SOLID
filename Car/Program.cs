using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            CarWithDVDPlayer newDVDcar = new CarWithDVDPlayer();
            newDVDcar.PlayMusic();
            CarWithUSBlayer newUSBCar = new CarWithUSBlayer();
            newUSBCar.PlayMusic();
            Console.ReadKey();
        }
    }
    public class DVDPlayer
    {
        public void PlayDVD()
        {
            Console.WriteLine("DVD player is working");
        }
    }
    public class USBPlayer
    {
        public void PlayUSB()
        {
            Console.WriteLine("USB player is working");
        }

    }
    public class CarWithDVDPlayer
    {
        DVDPlayer _carPlayer = new DVDPlayer();
        public void PlayMusic()
        {
            Console.WriteLine("Car with DVD player");
            _carPlayer.PlayDVD();
        } 
    }
    public class CarWithUSBlayer
    {
        USBPlayer _carPlayer = new USBPlayer();
        public void PlayMusic()
        {
            Console.WriteLine("Car with USB player");
            _carPlayer.PlayUSB();
        }
    }
}
