using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace C06
{
    public class Calculator : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // int result = Mycalculator.Plus(5,6);
            // Debug.Log(result);

            // result = Mycalculator.Minus(9,5);
            // Debug.Log(result);
            MyCalculator mycalculator = new MyCalculator();
            mycalculator.Plus(5,5);
            
               

        }

    }
    
    public class MyCalculator
    {
        public int temp;
        public int Plus(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public int Minus(int a, int b)
        {
            int result = a - b ;
            return result;
        }
        
    }


}
