using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    //int angleSum;
    GameObject car;
    GameObject flag;
    GameObject distance;
    GameObject greenCar;
    GameObject greenCarFlag;
    int rotation = 0;

    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
        this.greenCar = GameObject.Find("greenCar");
        this.greenCarFlag = GameObject.Find("greenCarFlag");
        //this.angleSum = GameObject.Find("flag").GetComponent<FlagController>().angleSum;
    }

    void Update()
    {
        //CountText.text = "��� ȸ�� Ƚ��" + count + "ȸ";
        //float flagRatationTimes = this.flag.transform.rotation.eulerAngles.y;
        float rotationTimes = this.flag.transform.eulerAngles.y;
        if(rotationTimes>179 && rotationTimes < 180)
        {
            this.rotation += 1;
        }
        float greenlength = this.greenCar.transform.position.y - this.greenCarFlag.transform.position.y;
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<Text>().text ="��� ȸ�� Ƚ��" + this.rotation + "ȸ" +System.Environment.NewLine
            + "Green Car ��ǥ ��������" + greenlength.ToString("F2") + "m" + System.Environment.NewLine + "Red Car ��ǥ ��������" + length.ToString("F2") + "m";
    }
}
