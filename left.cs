using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left : MonoBehaviour
{
    //Наши объекты.
    public GameObject robot;
    public GameObject box;

    //Целочисленная переменная определяющая дистанцию перемещения.
    public int l =-1;

    //Метод который будет выполнятся по нажатию нашей кнопки.
    public void OnButtonDown()
    {
        //двигаем объект
        robot.transform.Translate(l, 0, 0);
        box.transform.Translate(l, 0, 0);
    }
}
