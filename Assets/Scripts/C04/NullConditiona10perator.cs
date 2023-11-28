using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullConditiona10perator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ArrayList a = null;
        a?.Add("야구");
        a?.Add("축구");
        Debug.Log($"Count : {a?.Count}");
        Debug.Log($"{a?[0]}");
        Debug.Log($"{a?[1]}");

        a = new ArrayList();

        a?.Add("야구");
        a?.Add("축구");
        a?.Add("테니스");
        a?.Add("fall");
        Debug.Log($"Count : {a?.Count}");
        Debug.Log($"{a?[0]}");
        Debug.Log($"{a?[1]}");
        Debug.Log($"{a?[3]}");

        person child = new person();
        child.work();
        child.age = 10;
        Debug.Log(child.age);

    }

    public class person
    {

        //변수
        public int age;
        //동작을 의미하는 함수
        public void work()
        {

        }
    }
 
}
