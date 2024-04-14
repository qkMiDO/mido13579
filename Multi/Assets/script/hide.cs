using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hide : MonoBehaviour
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
        if (collision.CompareTag("player1"))
        {

            score.scor += 1;

            Destroy(gameObject);

        }
        else if (collision.CompareTag("player2"))
        {

            score2.scor2 += 1;

            Destroy(gameObject);

        }
        else if (collision.CompareTag("player3"))
        {

            score3.scor3 += 1;

            Destroy(gameObject);

        }
        else if (collision.CompareTag("player4"))
        {

            score4.scor4 += 1;

            Destroy(gameObject);

        }
        else if (collision.CompareTag("player5"))
        {

            score5.scor5 += 1;

            Destroy(gameObject);

        }
        else if (collision.CompareTag("player6"))
        {

            score6.scor6 += 1;

            Destroy(gameObject);

        }
        else if (collision.CompareTag("player7"))
        {

            score7.scor7 += 1;

            Destroy(gameObject);

        }
        else if (collision.CompareTag("player8"))
        {

            score8.scor8 += 1;

            Destroy(gameObject);

        }
        else if (collision.CompareTag("player9"))
        {

            score9.scor9 += 1;

            Destroy(gameObject);

        }
        else if (collision.CompareTag("player10"))
        {

            score10.scor10 += 1;

            Destroy(gameObject);

        }
        else if (collision.CompareTag("player11"))
        {

            score11.scor11 += 1;

            Destroy(gameObject);

        }
        else if (collision.CompareTag("player12"))
        {

            score12.scor12 += 1;

            Destroy(gameObject);

        }

    }

}
