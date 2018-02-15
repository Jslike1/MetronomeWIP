using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetronomeWIP.Classes
{
    public class MetronomeClass
    {

        public int BeatsPerMeasure { get; set; }

        public int NoteLength { get; set; }

        public int CurrentBeat { get; set; }

        public MetronomeClass()
        {
            this.CurrentBeat = 1;
        }



        public void MetronomeTick()
        {
            if (CurrentBeat != 1)
            {
                Console.Beep(440, NoteLength);
                if (CurrentBeat + 1 <= BeatsPerMeasure)
                {
                    CurrentBeat += 1;
                }
                else
                {
                    CurrentBeat = 1;
                }
            }
            else
            {
                Console.Beep(880, NoteLength);
                if (CurrentBeat + 1 <= BeatsPerMeasure)
                {
                    CurrentBeat += 1;
                }
                else
                {
                    CurrentBeat = 1;
                }
            }
        }

    }
}
