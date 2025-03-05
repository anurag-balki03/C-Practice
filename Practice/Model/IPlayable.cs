using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Model
{
    interface IPlayable
    {
        void Play();
    }

    public class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("The IPlayable is playing on Music Player.");
        }
    }

    public class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("the IPlayable is playing on the Video Player.");
        }
    }
}
