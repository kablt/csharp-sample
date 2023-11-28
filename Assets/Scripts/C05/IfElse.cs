
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IfElse : MonoBehaviour
{
    //화면에 결과를 출력할 TEXT
   public  TMP_Text text;
   //사용자에게 입력을 받을 Input Field
   public TMP_InputField inputField;

//버튼을 클릭 되었을 떄 동작할 함수
   public void ButtonCliked()
   {
        string input = inputField.text;
        int number = int.Parse(input);

        if (number < 0)
        {
            text.text="음수";
        }
        else if (number > 0)
        {
            text.text="얌수";
        }
        else
        {
            text.text="0";
        }

        if (number % 2 == 0)
        {
            text.text="짝수";
        }
        else
        {
            text.text="홀수";
        }
   }

    // Start is called before the first frame update
    void Start()
    {

    }
}
