using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullConditiona10perator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ArrayList a = null;
        a?.Add("�߱�");
        a?.Add("�౸");
        Debug.Log($"Count : {a?.Count}");
        Debug.Log($"{a?[0]}");
        Debug.Log($"{a?[1]}");

        a = new ArrayList();

        a?.Add("�߱�");
        a?.Add("�౸");
        a?.Add("�״Ͻ�");
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

        //����
        public int age;
        //������ �ǹ��ϴ� �Լ�
        public void work()
        {

        }
    }
 
}
