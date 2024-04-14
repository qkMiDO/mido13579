using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score6 : MonoBehaviour
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
    public static int scor6 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor6.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scor6 == 6) { Destroy(gameObject); Destroy(pnal1);       scor6 = 0;}
        else if (scor6 == 12) { Destroy(gameObject); Destroy(pnal2); scor6 = 0;}
        else if (scor6  == 18) { Destroy(gameObject); Destroy(pnal3);scor6 = 0;}
        else if (scor6 == 24) { Destroy(gameObject); Destroy(pnal4); scor6 = 0;}
        else if (scor6 == 30) { Destroy(gameObject); Destroy(pnal5); scor6 = 0;}
        else if (scor6 == 36) { Destroy(gameObject); Destroy(pnal6); scor6 = 0;}
        else if (scor6 == 42) { Destroy(gameObject); Destroy(pnal7); scor6 = 0;}
        else if (scor6 == 48) { Destroy(gameObject); Destroy(pnal8); scor6 = 0;}
        else if (scor6 == 54) { Destroy(gameObject); Destroy(pnal9); scor6 = 0;}
        else if (scor6 == 60) { Destroy(gameObject); Destroy(pnal10);scor6 = 0;}
        else if (scor6 == 66) { Destroy(gameObject); Destroy(pnal11);scor6 = 0;}
        else if (scor6  == 72) { Destroy(gameObject); Destroy(pnal12);scor6 = 0;}
        
    }
}
