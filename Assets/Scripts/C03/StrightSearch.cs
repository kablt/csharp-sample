using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using C0301;

public class StrightSearch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string greeting = "Good Morning";
        Debug.Log(greeting);

        //IndexOf()

        //var result = greeting.IndexOf("Good");
        //result = 0; Good라는 단어가 시작하는 위치는 0이니 결과값은 0이다.
        //result = greeting.IndexOf("o");
        //o가 시작하는 위치가 1이므로 결과값은 1이 나온다. 컴퓨터의 숫자는 0부터 시작하므로 두번쨰자리이지만 결과값은 1이된다.

        Debug.Log($"IndexOf: 'Good': {greeting.IndexOf("Good") } " );
        Debug.Log($"IndexOf: 'o' : {greeting.IndexOf("o")} ");

        //LastIndexOf()
        //괄호안의 것을 찾는것?
        Debug.Log($"LastIndexOf 'Good' : {greeting.IndexOf("Good")}");
        Debug.Log($"LastInexOf 'g' : {greeting.IndexOf("g")}");

        //Startwith()
        //시작하는 문자가 괄호냐
        var result2 = greeting.StartsWith("Good");//true
        result2 = greeting.StartsWith("Morning");//false
        Debug.Log($"StartWith 'Good' : {greeting.StartsWith("Good")}");
        Debug.Log($"StartWith 'g' : {greeting.StartsWith("Morning")}");

        //EndWith()
        //Good로 끝나냐 false
        //Morning로 끝나냐 true
        Debug.Log($"EndWith 'Good' : {greeting.EndsWith("Good")}");
        Debug.Log($"EndWith 'Morning' : {greeting.EndsWith("Morning")}");

        //Contains()
        //괄호안의 문자를 포함하고 있느냐? 위:True, 아래:False
        Debug.Log($"Contains 'Evening' : {greeting.Contains("Evening")}");
        Debug.Log($"Contains 'Morning' : {greeting.Contains("Morning")}");

        //Replace
        //var result3 = greeting.Replace("Morning", "Evening");
        Debug.Log($"Reaplaced 'Morning' : {greeting.Replace("Morning","Evening")}");

    }

    // Update is called once per frame

}
