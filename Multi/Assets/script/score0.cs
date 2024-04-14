using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score0 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
         Destroy(gameObject);
        score.scor = 0;
        score2.scor2 = 0;
        score3.scor3 = 0;
        score4.scor4 = 0;
        score5.scor5 = 0;
        score6.scor6 = 0;
        score7.scor7 = 0;
        score8.scor8 = 0;
        score9.scor9 = 0;
        score10.scor10 = 0;
        score11.scor11 = 0; 
        score12.scor12 = 0;
    }
}
