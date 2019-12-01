using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_correct
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car(new DVDPlayer());
            newCar.PlayMusic();
            //change device
            newCar.CarPlayer = new USBPlayer();
            newCar.PlayMusic();
            Console.ReadKey();
        }
    }
    public interface IMusicPlayer
    {
        void Play();
    }
    public class DVDPlayer : IMusicPlayer
    {
        public void Play()
        {
            Console.WriteLine("DVD player is working");
        }
    }
    public class USBPlayer : IMusicPlayer
    {
        public void Play()
        {
            Console.WriteLine("USB player is working");
        }
    }
    public class Car
    {
        public IMusicPlayer CarPlayer { get; set; }
        public Car(IMusicPlayer curPlayer)
        {
            CarPlayer = curPlayer;
        }
        public void PlayMusic()
        {
            Console.WriteLine("Music in the car");
            CarPlayer.Play();
        }
    }
}
