using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoxRobot : MonoBehaviour
{
    //���� �������.
    public GameObject robot;
    public GameObject box;

    //������������� ���������� ������������ ��������� �����������.
    public int S;

    //����� ������� ����� ���������� �� ������� ����� ������.
    public void OnButtonDown()
    {
        //������ ����� ���������� ������������� �������� 1 ��� 2.
        S = Random.Range(10, 50);
        //������ ��� ������ �� S  x.
        robot.transform.Rotate(0, S, 0);
        box.transform.Rotate(0, S, 0);
    }
}
