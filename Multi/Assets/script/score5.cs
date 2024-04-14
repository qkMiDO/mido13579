using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score5 : MonoBehaviour
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
    public static int scor5 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor5.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scor5 == 5) { Destroy(gameObject); Destroy(pnal1);        scor5    = 0;}
        else if (scor5   == 10) { Destroy(gameObject); Destroy(pnal2); scor5 = 0; }
        else if (scor5 == 15) { Destroy(gameObject); Destroy(pnal3); scor5    = 0;}
        else if (scor5 == 20) { Destroy(gameObject); Destroy(pnal4); scor5    = 0;}
        else if (scor5 == 25) { Destroy(gameObject); Destroy(pnal5); scor5    = 0;}
        else if (scor5 == 30) { Destroy(gameObject); Destroy(pnal6); scor5    = 0;}
        else if (scor5 == 35) { Destroy(gameObject); Destroy(pnal7); scor5    = 0;}
        else if (scor5 == 40) { Destroy(gameObject); Destroy(pnal8); scor5    = 0;}
        else if (scor5 == 45) { Destroy(gameObject); Destroy(pnal9); scor5 = 0; }
        else if (scor5 == 50) { Destroy(gameObject); Destroy(pnal10); scor5    = 0;}
        else if (scor5 == 55) { Destroy(gameObject); Destroy(pnal11); scor5    = 0;}
        else if (scor5 == 60) { Destroy(gameObject); Destroy(pnal12); scor5 = 0; }
        
    }
}
