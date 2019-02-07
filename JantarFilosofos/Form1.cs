using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace JantarFilosofos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Semaphore semaf;
        private static Filosofo f1 = new Filosofo();
        private static Filosofo f2 = new Filosofo();
        private static Filosofo f3 = new Filosofo();
        private static Filosofo f4 = new Filosofo();
        private static Filosofo f5 = new Filosofo();
        private static Garfo g1 = new Garfo();
        private static Garfo g2 = new Garfo();
        private static Garfo g3 = new Garfo();
        private static Garfo g4 = new Garfo();
        private static Garfo g5 = new Garfo();
        private static Random sleeping = new Random();

        public static void F1Comendo()
        {
            semaf.WaitOne();
            /*if (g1.EmUso || g5.EmUso)
            {               
                return;
            }*/
            if (!g1.EmUso && !g5.EmUso)
            {
                g1.EmUso = true;
                g5.EmUso = true;
                f1.Comendo = true;
                Thread.Sleep(sleeping.Next(3000, 5000));
                f1.Comendo = false;
                g1.EmUso = false;
                g5.EmUso = false;
            }
            semaf.Release();
        }
        public static void F2Comendo()
        {
            semaf.WaitOne();
            /*if (g1.EmUso || g2.EmUso)
            {               
                return;
            } */
            if (!g1.EmUso && !g2.EmUso)
            {
                g1.EmUso = true;
                g2.EmUso = true;
                f2.Comendo = true;
                Thread.Sleep(sleeping.Next(3000, 5000));
                f2.Comendo = false;
                g1.EmUso = false;
                g2.EmUso = false;
            }
            semaf.Release();
        }

        public static void F3Comendo()
        {
            semaf.WaitOne();
            /*if (g2.EmUso || g3.EmUso)
            {             
                return;
            }*/
            if (!g2.EmUso && !g3.EmUso)
            {
                g2.EmUso = true;
                g3.EmUso = true;
                f3.Comendo = true;
                Thread.Sleep(sleeping.Next(3000, 5000));
                f3.Comendo = false;
                g2.EmUso = false;
                g3.EmUso = false;
            }
            semaf.Release();
        }

        public static void F4Comendo()
        {
            semaf.WaitOne();
            /*if (g3.EmUso || g4.EmUso)
            {               
                return;
            }*/
            if (!g3.EmUso && !g4.EmUso)
            {
                g3.EmUso = true;
                g4.EmUso = true;
                f4.Comendo = true;
                Thread.Sleep(sleeping.Next(3000, 5000));
                f4.Comendo = false;
                g3.EmUso = false;
                g4.EmUso = false;
            }
            semaf.Release();
        }

        public static void F5Comendo()
        {
            semaf.WaitOne();
            /*if (g4.EmUso || g5.EmUso)
            {               
                return;
            }*/
            if (!g4.EmUso && !g5.EmUso)
            {
                g4.EmUso = true;
                g5.EmUso = true;
                f5.Comendo = true;
                Thread.Sleep(sleeping.Next(3000, 5000));
                f5.Comendo = false;
                g4.EmUso = false;
                g5.EmUso = false;
            }
            semaf.Release();
        }


        public static void Executa()
        {
            semaf = new Semaphore(2, 2);
            Thread threadF1 = new Thread(new ThreadStart(F1Comendo));
            threadF1.Start();
            Thread threadF2 = new Thread(new ThreadStart(F2Comendo));
            threadF2.Start();
            Thread threadF3 = new Thread(new ThreadStart(F3Comendo));
            threadF3.Start();
            Thread threadF4 = new Thread(new ThreadStart(F4Comendo));
            threadF4.Start();
            Thread threadF5 = new Thread(new ThreadStart(F5Comendo));
            threadF5.Start();
            while (true)
            {
                if (!threadF1.IsAlive)
                {
                    threadF1 = new Thread(new ThreadStart(F1Comendo));
                    threadF1.Start();
                }
                if (!threadF2.IsAlive)
                {
                    threadF2 = new Thread(new ThreadStart(F2Comendo));
                    threadF2.Start();
                }
                if (!threadF3.IsAlive)
                {
                    threadF3 = new Thread(new ThreadStart(F3Comendo));
                    threadF3.Start();
                }
                if (!threadF4.IsAlive)
                {
                    threadF4 = new Thread(new ThreadStart(F4Comendo));
                    threadF4.Start();
                }
                if (!threadF5.IsAlive)
                {
                    threadF5 = new Thread(new ThreadStart(F5Comendo));
                    threadF5.Start();
                }
            }            
        }

        private void cmdExecutar_Click(object sender, EventArgs e)
        {

            Thread threadA = new Thread(new ThreadStart(Executa));
            threadA.Start();
            timer1.Enabled = true;
            //Lembrar de tirar o parâmetro do release 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (f1.Comendo)
            { listBox1.Items.Add("Filósofo 1 está COMENDO"); }
            else
            { listBox1.Items.Add("Filósofo 1 está pensando"); }

            if (f2.Comendo)
            { listBox1.Items.Add("Filósofo 2 está COMENDO"); }
            else
            { listBox1.Items.Add("Filósofo 2 está pensando"); }

            if (f3.Comendo)
            { listBox1.Items.Add("Filósofo 3 está COMENDO"); }
            else
            { listBox1.Items.Add("Filósofo 3 está pensando"); }

            if (f4.Comendo)
            { listBox1.Items.Add("Filósofo 4 está COMENDO"); }
            else
            { listBox1.Items.Add("Filósofo 4 está pensando"); }

            if (f5.Comendo)
            { listBox1.Items.Add("Filósofo 5 está COMENDO"); }
            else
            { listBox1.Items.Add("Filósofo 5 está pensando"); }
            listBox1.Items.Add("");
        }
    }
}
