using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Typesafe_Calling
{
    public delegate void SampleDelegate(int returnValue);
    

    public class DelegateUsage
    {
        private object _lock = new object();
        public object Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        public delegate object Lock_Delegate();
        public void Lock_PrintText(object _lock)
        {
            
            Console.WriteLine(_lock.ToString() + "Lock - [INACTIVE]");
            if (Lock_PrintText != null)
            {
                Console.WriteLine("Lock - [ACTIVE]");
            }
            
        }

        public int Lock_PrintValue(object _lock)
        {

            int i = 0;

            Console.WriteLine(_lock.ToString() + "Lock - [INACTIVE]");
            if (Lock_PrintText != null)
            {
                Console.WriteLine("Lock - [ACTIVE]");
                
                return i;
   
            }

            return i;
        }
    }
    public class Typesafe_Call
    {
        private int _input;
        public int Input
        {
            get { return _input; }
            set { _input = value; }
        }

        private SampleDelegate _sampleDelegateObj;
        public Typesafe_Call(int num)
        {
            Input = num;
        }
        
        public Typesafe_Call(int num, SampleDelegate sample_Del)
        {
            Input = num;
            _sampleDelegateObj = sample_Del;
        }
        public void PrintNew()
        {
            for(int i = 0; i < Input; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void GenerateSum()
        {
            int sum_Val = 0;
            for(int i = 0; i < 10; i++)
            {
                sum_Val += 1;
            }
            if(_sampleDelegateObj != null)
            {
                _sampleDelegateObj(sum_Val);
            }
        }
    }
}
