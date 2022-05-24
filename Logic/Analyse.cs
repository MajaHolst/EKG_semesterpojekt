using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_tier;

namespace Logic
{
    class Analyse
    {
        Analyse()
        {
            DataBase data = new DataBase();
            List<int> result = new List<int>();
            List<EKGData> dto = new List<EKGData>();
            dto = data.GetEKGData(); 
            var max = dto.Max();
            var min = dto.Min();

            //Pulse counter
            double pThreshold = (Convert.ToDouble(max) - Convert.ToDouble(min)) * 0.7; //Tune
            bool belowpThreshold = false;
            int Rtak_new = 0;
            int Rtak_old = 0;
            int Samplerate = 500;
            double diff = 0;
            List<double> RRList = new List<double>();

            for (int i = 0; i < dto.Count; i++)
            {
                if (Convert.ToDouble(dto[i]) > pThreshold && belowpThreshold == true)
                {
                    Rtak_new = i;
                    diff = (Rtak_new - Rtak_old) / Convert.ToDouble(Samplerate);
                    RRList.Add(diff);
                    Rtak_old = Rtak_new;
                }
                if (Convert.ToDouble(dto[i]) < pThreshold)
                {
                    belowpThreshold = true;
                }
                else
                {
                    belowpThreshold = false;
                }
            }
            RRList.RemoveAt(0);
            int Pulse = (int)(60 / RRList.Average());
            result.Add(Pulse);

            //Baseline algorithm
            int nBins = 50;
            int[] intervals = new int[nBins];
            double delta = (Convert.ToDouble(max) - Convert.ToDouble(min)) / nBins;


            foreach (EKGData EKG in dto)
            {
                if (EKG == max)
                {
                    intervals[nBins - 1]++;
                }
                else
                {
                    int bin = (int)Math.Floor((Convert.ToDouble(EKG) - Convert.ToDouble(min)) / delta);
                    intervals[bin]++;
                }
            }

            int m = intervals.Max();

            int p = Array.IndexOf(intervals, m);

            double baseline = (Convert.ToDouble(min) + (p + 1) * delta - delta / 2) / 1000; //Change /1000 for V/mV

            //Fibriliation counter
            int Fib = 0;
            double offset = (Convert.ToDouble(max) - Convert.ToDouble(min)) * 0.2; //Tune
            double fThreshold = baseline + offset;
            bool belowfThreshold = false;

            for (int i = 0; i < dto.Count; i++)
            {
                if (Convert.ToDouble(dto[i]) > fThreshold && belowfThreshold == true)
                {
                    Fib++;
                }
                if (Convert.ToDouble(dto[i]) < pThreshold)
                {
                    belowfThreshold = true;
                }
                else
                {
                    belowfThreshold = false;
                }

            }
            result.Add(Fib);

        }
    }
}
        
