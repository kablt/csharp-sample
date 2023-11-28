using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 10;
         while(i>0)
         {
            Debug.Log($"i : {i--}");

         }

         int j = 10;
         do
         {
            Debug.Log($"j : {j--}");
         }
         while(j>0);

         {
            for(int k = 0; k<5; k++)
            {
                Debug.Log(k);
            }
         }

         {
            int[] arr = new int[]{0,1,2,3,4};
            foreach(int a in arr)
            {
                Debug.Log(a);
            }

         }
    }
}

