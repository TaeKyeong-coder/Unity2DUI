using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    int isClicked = 1;
    public int angleSum = 0;

    void Start()
    {
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(2))
        {
            this.isClicked += 1;
        }
        
        if((this.isClicked)%2 == 0)
        {
            transform.Rotate(0, 10, 0);
            this.angleSum += 10;
        }
    }

}
