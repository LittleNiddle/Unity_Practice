using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity");

        int level = 5;
        float strength = 15.5f;
        string playerName = "�˻�";
        bool isFullLevel = false;

        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("�ʿ� �����ϴ� ���� ����");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);
    }

}
