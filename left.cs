using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left : MonoBehaviour
{
    //���� �������.
    public GameObject robot;
    public GameObject box;

    //������������� ���������� ������������ ��������� �����������.
    public int l =-1;

    //����� ������� ����� ���������� �� ������� ����� ������.
    public void OnButtonDown()
    {
        //������� ������
        robot.transform.Translate(l, 0, 0);
        box.transform.Translate(l, 0, 0);
    }
}
