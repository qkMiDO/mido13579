using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score10 : MonoBehaviour
{
    public GameObject pnal1;
    public GameObject pnal2;
    public GameObject pnal3;
    public GameObject pnal4;
    public GameObject pnal5;
    public GameObject pnal6;
    public GameObject pnal7;
    public GameObject pnal8;
    public GameObject pnal9;
    public GameObject pnal10;
    public GameObject pnal11;
    public GameObject pnal12;
    Text Text;
    public static int scor10 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor10.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scor10 == 10)
        {
            Destroy(gameObject); Destroy(pnal1);
            scor10 = 0;
        }
        else if (scor10 == 20)
        {
            Destroy(gameObject); Destroy(pnal2);
            scor10 = 0;
        }
        else if (scor10 == 30)
        {
            Destroy(gameObject); Destroy(pnal3);
            scor10 = 0;
        }
        else if (scor10 == 40)
        {
            Destroy(gameObject); Destroy(pnal4);
            scor10 = 0;
        }
        else if (scor10 == 50)
        {
            Destroy(gameObject); Destroy(pnal5);
            scor10 = 0;
        }
        else if (scor10 == 60)
        {
            Destroy(gameObject); Destroy(pnal6);
            scor10 = 0;
        }
        else if (scor10 == 70)
        {
            Destroy(gameObject); Destroy(pnal7);
            scor10 = 0;
        }
        else if (scor10 == 80)
        {
            Destroy(gameObject); Destroy(pnal8);
            scor10 = 0;
        }
        else if (scor10 == 90)
        {
            Destroy(gameObject); Destroy(pnal9);
            scor10 = 0;
        }
        else if (scor10 == 100)
        {
            Destroy(gameObject); Destroy(pnal10);
            scor10 = 0;
        }
        else if (scor10 == 110)
        {
            Destroy(gameObject); Destroy(pnal11);
            scor10 = 0;
        }
        else if (scor10 == 120)
        {
            Destroy(gameObject); Destroy(pnal12);
            scor10 = 0;
        }

    }
}
