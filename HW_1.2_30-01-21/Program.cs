using System;

namespace HW_1._2_30_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Player action = new Player();
            Console.WriteLine("Выди действый: ");
            action.Play();
            action.Record();
            action.Pause();
            action.Stop();
        }
    }
    interface IPlayable
    {
        void Play(); void Pause(); void Stop();
    }
    interface IRecodable
    {
        void Record(); void Pause(); void Stop();
    }
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("play-------|>");
        }
        public void Pause()
        {
            Console.WriteLine("pause------|>");
        }
        public void Stop()
        {
            Console.WriteLine("stop-------|>");
        }
        public void Record()
        {
            Console.WriteLine("record-----|>");
        }
    }
}   
