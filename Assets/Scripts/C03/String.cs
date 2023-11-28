
using System;
using UnityEngine;
using UnityEngine.Rendering;

public class String : MonoBehaviour
{
    enum DialogResult {YES, NO, CANCLE, CONFIRM, OK}
    
    // Start is called before the first frame update
    void Start()
    {
        //enum1
        {
            Debug.Log((int)DialogResult.YES);
            Debug.Log((int)DialogResult.NO);
            Debug.Log((int)DialogResult.CANCLE);
            Debug.Log((int)DialogResult.CONFIRM);
            Debug.Log((int)DialogResult.OK);
        }

        //enum2
        {
          DialogResult result = DialogResult.YES;

            Debug.Log(result==DialogResult.YES);
            Debug.Log(result==DialogResult.NO);
            Debug.Log(result==DialogResult.CANCLE);
            Debug.Log(result==DialogResult.CONFIRM);
            Debug.Log(result==DialogResult.OK);

         }

        {
        string a = "안녕하세요";
        string b = "금강선입니다";

        Debug.Log(a);
        Debug.Log(b);
        }

        {
            int a =123;
            string b = a.ToString();
            Debug.Log(b);

            float c = 3.14f;
            string d = c.ToString();
            Debug.Log(d);

            string e = "123456";
            int f = Convert.ToInt32(e);
            Debug.Log(f);

            string g = "1.2345";
            float h = float.Parse(g);
            Debug.Log(h);
            
        }   

        {
            const int MAX_INT = 214783647;
            const int MIN_INT = -2147483648;

            Debug.Log(MAX_INT);
            Debug.Log(MIN_INT);
            
        }
    }

    
    // Update is called once per frame

}
