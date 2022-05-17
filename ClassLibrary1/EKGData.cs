using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class EKGData
    {
        public EKGData() { }
        private FileStream input;
        private StreamReader reader;

        public double EKG { get; set; }

        public EKGData(double ekg)
        {
            EKG = ekg;  
        }

        public List<EKGData> getEKGData()
        {
            List<EKGData> _EKGliste = new List<EKGData>();
            input = new FileStream("EKG-signal-fra-physionet-AFIB.txt", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(input);
            string inputRecord;
            string[] inputFields;

            while ((inputRecord = reader.ReadLine()) != null)
            {
                inputFields = inputRecord.Split(';');
                double EKGD = Convert.ToDouble(inputFields[0]);
                EKGData data = new EKGData(EKGD);
                _EKGliste.Add(data);

            }
            reader.Close();
            return _EKGliste;
        }
        // tilføj
    }

}
