using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score8 : MonoBehaviour
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
    public static int scor8 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor8.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scor8 == 8) { Destroy(gameObject); Destroy(pnal1); scor8 = 0; }
        else if (scor8 == 16) { Destroy(gameObject); Destroy(pnal2); scor8  = 0;}
        else if (scor8 == 24) { Destroy(gameObject); Destroy(pnal3); scor8  = 0;}
        else if (scor8 == 32) { Destroy(gameObject); Destroy(pnal4); scor8  = 0;}
        else if (scor8 == 40) { Destroy(gameObject); Destroy(pnal5); scor8  = 0;}
        else if (scor8 == 48) { Destroy(gameObject); Destroy(pnal6); scor8  = 0;}
        else if (scor8 == 56) { Destroy(gameObject); Destroy(pnal7); scor8  = 0;}
        else if (scor8 == 64) { Destroy(gameObject); Destroy(pnal8); scor8  = 0;}
        else if (scor8 == 72) { Destroy(gameObject); Destroy(pnal9); scor8  = 0;}
        else if (scor8 == 80) { Destroy(gameObject); Destroy(pnal10);scor8  = 0; }
        else if (scor8 == 88) { Destroy(gameObject); Destroy(pnal11);scor8  = 0; }
        else if (scor8 == 96) { Destroy(gameObject); Destroy(pnal12); scor8 = 0; }
        
    }
}
