using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right : MonoBehaviour
{
    
        //���� �������.
        public GameObject robot;
        public GameObject box;

        //������������� ���������� ������������ ��������� �����������.
        public int r = 1;

        //����� ������� ����� ���������� �� ������� ����� ������.
        public void OnButtonDown()
        {
            //������� ������
            robot.transform.Translate(r, 0, 0);
            box.transform.Translate(r, 0, 0);
    }

}