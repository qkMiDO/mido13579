using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score9 : MonoBehaviour
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
    public static int scor9 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor9.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scor9 == 9) { Destroy(gameObject); Destroy(pnal1);scor9 = 0;}
        else if (scor9 == 18) { Destroy(gameObject); Destroy(pnal2);scor9 = 0;}
        else if (scor9 == 27) { Destroy(gameObject); Destroy(pnal3);scor9 = 0;}
        else if (scor9 == 36) { Destroy(gameObject); Destroy(pnal4);scor9 = 0;}
        else if (scor9 == 45) { Destroy(gameObject); Destroy(pnal5);scor9 = 0;}
        else if (scor9 == 54) { Destroy(gameObject); Destroy(pnal6);scor9 = 0;}
        else if (scor9 == 63) { Destroy(gameObject); Destroy(pnal7);scor9 = 0;}
        else if (scor9 == 72) { Destroy(gameObject); Destroy(pnal8);scor9 = 0;}
        else if (scor9 == 81) { Destroy(gameObject); Destroy(pnal9);scor9 = 0;}
        else if (scor9 == 90) { Destroy(gameObject); Destroy(pnal10);scor9 = 0;}
        else if (scor9 == 99) { Destroy(gameObject); Destroy(pnal11);scor9 = 0;}
        else if (scor9 == 108) { Destroy(gameObject); Destroy(pnal12);scor9 = 0;}
        
    }
}
