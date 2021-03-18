using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoxRobot : MonoBehaviour
{
    //Наши объекты.
    public GameObject robot;
    public GameObject box;

    //Целочисленная переменная определяющая дистанцию перемещения.
    public int S;

    //Метод который будет выполнятся по нажатию нашей кнопки.
    public void OnButtonDown()
    {
        //Задаем нашей переменной целочисленное значение 1 или 2.
        S = Random.Range(10, 50);
        //крутим наш объект на S  x.
        robot.transform.Rotate(0, S, 0);
        box.transform.Rotate(0, S, 0);
    }
}
