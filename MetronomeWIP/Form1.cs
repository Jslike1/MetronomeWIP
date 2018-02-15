using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MetronomeWIP.Classes;
using System.Timers;

namespace MetronomeWIP
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        MetronomeClass metronome = new MetronomeClass();
        int frequency = 440;
        int tempo = 120;
        int beatsPerMeasure = 4;
        int measures = -1;
        int measureCounter = 1;
        int beatCounter = 1;
        System.Timers.Timer tick;

        bool metronomeOn = false; 


        private void button1_Click(object sender, EventArgs e)
        {
            int noteMil = 60000 / tempo;
            int noteRest = noteMil / 2;
            metronome.NoteLength = noteRest;

            metronomeOn = !metronomeOn;

            if(!metronomeOn)
            {
                tick.Stop();
                tick.Dispose();
            }
            else
            {
                metronome.NoteLength = noteRest;
                metronome.BeatsPerMeasure = beatsPerMeasure;
                metronome.CurrentBeat = 1;
                tick = new System.Timers.Timer(noteMil);

                tick.Elapsed += TimerOut;
                tick.AutoReset = true;
                tick.Enabled = true;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int num))
            {
                beatsPerMeasure = num;
            }
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int num))
            {
                measures = num;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBox3.Text, out int num))
            {
                beatsPerMeasure = num;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            {
                if (int.TryParse(textBox2.Text, out int num))
                {
                    tempo = num;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{

        //}

        private void TimerOut(Object source, ElapsedEventArgs e)
        {         
            metronome.MetronomeTick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (metronomeOn)
            {
                tick.Enabled =!tick.Enabled;
            }


        }
    }
}
