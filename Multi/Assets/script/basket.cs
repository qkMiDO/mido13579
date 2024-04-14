
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player2"))
        {   
            score2.scor2 += 10;

            Destroy(gameObject);
        }
        if (collision.CompareTag("player3"))
        {
            score3.scor3 += 10;

            Destroy(gameObject);
        }
        if (collision.CompareTag("player4"))
        {
            score4.scor4 += 10;

            Destroy(gameObject);
        }
        if (collision.CompareTag("player5"))
        {
            score5.scor5 += 10;

            Destroy(gameObject);
        }
        else if (collision.CompareTag("player6"))
        {

            score6.scor6 += 10;

            Destroy(gameObject);

        }
        else if (collision.CompareTag("player7"))
        {

            score7.scor7 += 10;

            Destroy(gameObject);

        }
        else if (collision.CompareTag("player8"))
        {

            score8.scor8 += 10;

            Destroy(gameObject);

        }
        else if (collision.CompareTag("player9"))
        {

            score9.scor9 += 10;

            Destroy(gameObject);

        }
       else if (collision.CompareTag("player10"))
        {
            score10.scor10 += 10;

            Destroy(gameObject);
        }
        else if (collision.CompareTag("player11"))
        {
            score11.scor11 += 10;

            Destroy(gameObject);
        }
        else if (collision.CompareTag("player12"))
        {
            score12.scor12 += 10;

            Destroy(gameObject);
        }
    }
}
