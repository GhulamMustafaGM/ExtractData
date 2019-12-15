using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Place the data file on drive C:\source.txt

namespace ExtractData
{
    class Program
    {
        public class ExtractData
        {
            //Setting Index & Length for Invoice data

            const int InvoicePeriodStartIndex = 2287;
            const int InvoicePeriodDataLength = 23;
            const int BuildingIdStartIndex = 2130;
            const int BuildingIdDataLength = 8;
            const int MeterNumberStartIndex = 2230;
            const int MeterNumberDataLength = 7;
            const int CostExVatStartIndex = 7104;
            const int CostExVatDataLength = 10;
            const int CostIncVatStartIndex = 7335;
            const int CostIncVatDataLength = 10;
            const int EnergyPriceStartIndex = 6754;
            const int EnergyPriceDataLength = 11;
            const int EffectPriceStartIndex = 6869;
            const int EffectPriceDataLength = 11;
            const int FlowPriceStartIndex = 6985;
            const int FlowPriceDataLength = 11;
            string DataString;

            public ExtractData(string str)
            {
                this.DataString = str;   
            }

           //Show Inoice Data
            public void ShowExtractedData()
            {
                Console.WriteLine("************** Customer Invoice Data *************\n");
                Console.WriteLine(String.Format("{0,-22} {1,23}","Invoice Period", InvoicePeriod));
                Console.WriteLine("{0,-22} {1,10}","Building Id", BuildingId);
                Console.WriteLine("{0,-22} {1,10}","Meter Number", MeterNumber);
                Console.WriteLine("{0,-22} {1,11}","Total Cost Ex Vat", CostExVat);
                Console.WriteLine("{0,-22} {1,11}", "Total Cost Inc Vat", CostIncVat);
                Console.WriteLine("{0,-22} {1,11}","Energy Price", EnergyPrice);
                Console.WriteLine("{0,-22} {1,11}", "Effect Price", EffectPrice);
                Console.WriteLine("{0,-22} {1,11}", "Flow Price", FlowPrice);
            }

            //Invoice Period property
            public string InvoicePeriod
            {
                get
                {
                    return DataString.Substring(InvoicePeriodStartIndex, InvoicePeriodDataLength);
                }
            }

            //Building Id property
            public string BuildingId
            {
                get
                {
                    return DataString.Substring(BuildingIdStartIndex, BuildingIdDataLength);
                }
            }

            //Meter Number property
            public string MeterNumber
            {
                get
                {
                    return DataString.Substring(MeterNumberStartIndex, MeterNumberDataLength);
                }
            }

            //Cost Excluding VAT property
            public string CostExVat
            {
                get
                {
                    return DataString.Substring(CostExVatStartIndex, CostExVatDataLength);
                }
            }

            //Cost Including VAT property
            public string CostIncVat
            {
                get
                {
                    return DataString.Substring(CostIncVatStartIndex, CostIncVatDataLength);
                }
            }

            //Energy Price Property
            public string EnergyPrice
            {
                get
                {
                    return DataString.Substring(EnergyPriceStartIndex, EnergyPriceDataLength);
                }
            }

            //Effect Price Property
            public string EffectPrice
            {
                get
                {
                    return DataString.Substring(EffectPriceStartIndex, EffectPriceDataLength);
                }
            }

            //Flow Price Property
            public string FlowPrice
            {
                get
                {
                    return DataString.Substring(FlowPriceStartIndex, FlowPriceDataLength);
                }
            }
        }
        static void Main(string[] args)
        {
            string filename = @"c:\source.txt";
            string fileData = System.IO.File.ReadAllText(filename);
            ExtractData ed = new ExtractData(fileData);
            ed.ShowExtractedData();
            Console.ReadKey();
        }
    }
}
