using System;


namespace StructEnum
{
    public struct Struct_Data
    {
        enum NumRef_Data
        {
            //ref. Fiscal Year
            FY2019, //[0] ... total[3]
            FY2020, 
            FY2021, 
            FY2022
        }

        private int _NumRef;
        public int NumRef
        {
            get { return _NumRef; }
            set { _NumRef = value; }
        }

        private string _StrRef;
        public string StrRef
        {
            get { return _StrRef; }
            set { _StrRef = value; }
        }

        public class StructEnum_Data
        {
            public void return_IntFY(ref Struct_Data outputInt)
            {
               

                int val0 = (int)NumRef_Data.FY2019;
                int val1 = (int)NumRef_Data.FY2020;
                int val2 = (int)NumRef_Data.FY2021;
                int val3 = (int)NumRef_Data.FY2022;

                
                outputInt.NumRef = 0;//*Bug-fix
                ValueTuple<int, int, int, int> NumRef_DataTpl =
                    new ValueTuple<int, int, int, int>
                    (val0, val1, val2, val3);

                Console.WriteLine(NumRef_DataTpl.Item1);
                Console.WriteLine(NumRef_DataTpl.Item2);
                Console.WriteLine(NumRef_DataTpl.Item3);
                Console.WriteLine(NumRef_DataTpl.Item4);
                
            }
            public void return_StrFY(ref Struct_Data output)
            {
                

                string str0 = (string)NumRef_Data.FY2019.ToString();
                string str1 = (string)NumRef_Data.FY2019.ToString();
                string str2 = (string)NumRef_Data.FY2019.ToString();
                string str3 = (string)NumRef_Data.FY2019.ToString();

                output.StrRef = "examine [...]";
                
                Tuple<string, string, string, string> DataTpl = 
                    new Tuple<string, string, string, string>
                    (("[0]..." + str0), ("[1]..." + str1), ("[2]..." + str2), ("[3]..." + str3));

                Console.WriteLine(DataTpl.Item1);
                Console.WriteLine(DataTpl.Item2);
                Console.WriteLine(DataTpl.Item3);
                Console.WriteLine(DataTpl.Item4);
            }

            public void customFY_Obj(ref Struct_Data output)
            {
                Struct_Data objInt = new Struct_Data();
                Struct_Data objStr = new Struct_Data();

                int val0 = (int)NumRef_Data.FY2019;
                int val1 = (int)NumRef_Data.FY2020;
                int val2 = (int)NumRef_Data.FY2021;
                int val3 = (int)NumRef_Data.FY2022;

                string str0 = (string)NumRef_Data.FY2019.ToString();
                string str1 = (string)NumRef_Data.FY2019.ToString();
                string str2 = (string)NumRef_Data.FY2019.ToString();
                string str3 = (string)NumRef_Data.FY2019.ToString();

                var OBJ_0 = (id: val0, name: str0);
                var OBJ_1 = (id: val1, name: str1);
                var OBJ_2 = (id: val2, name: str2);
                var OBJ_3 = (id: val3, name: str3);


                Console.WriteLine(OBJ_0);
                Console.WriteLine(OBJ_1);
                Console.WriteLine(OBJ_2);
                Console.WriteLine(OBJ_3);


                try
                {

                    int intFormat_FY = (int)objInt.NumRef;
                    string strFormat_FY = (string)objStr.StrRef;
                    Console.WriteLine(intFormat_FY);
                    Console.WriteLine(strFormat_FY);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Null Execption thrown ...");
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
