using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right : MonoBehaviour
{
    
        //Наши объекты.
        public GameObject robot;
        public GameObject box;

        //Целочисленная переменная определяющая дистанцию перемещения.
        public int r = 1;

        //Метод который будет выполнятся по нажатию нашей кнопки.
        public void OnButtonDown()
        {
            //двигаем объект
            robot.transform.Translate(r, 0, 0);
            box.transform.Translate(r, 0, 0);
    }

}