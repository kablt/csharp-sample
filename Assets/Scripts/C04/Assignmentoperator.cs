using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignmentoperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a;
        a = 100;
        Debug.Log($"a = 100: {a}");
        a += 90;
        //a= a+90
        Debug.Log($"a += 60: {a}");
        a -= 80;
        //a = a - 80;
        Debug.Log($"a -= 80: {a}");
        a *= 70;
        //a = a * 70;
        Debug.Log($"a *= 70: {a}");
        a /= 60;
        //a=a/60;
        Debug.Log($"a /= 60: {a}");
        a %= 50;
        //a=a%50; a를50으로 나누고 남은 나머지
        Debug.Log($"a %= 50: {a}");
        a &= 40;
        //비트 비교 28, 40 28 11100 101000  1000 8
        Debug.Log($"a &= 40: {a}");
        a |= 30;
        //8 30 비트 1000,11110 11110
        Debug.Log($"a |= 30: {a}");
        a ^= 20;
        // 11110 10100 1010? 검색
        Debug.Log($"a ^= 20: {a}");
        a <<= 10;
        Debug.Log($"a <<= 10: {a}");
        a >>= 2;
        Debug.Log($"a =>>2 : {a}");

    }
}
