using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score7 : MonoBehaviour
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
    public static int scor7 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor7.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scor7 == 7) { Destroy(gameObject); Destroy(pnal1);       scor7  = 0;}
        else if (scor7 == 14) { Destroy(gameObject); Destroy(pnal2); scor7  = 0; }
        else if (scor7 == 21) { Destroy(gameObject); Destroy(pnal3); scor7  = 0; }
        else if (scor7 == 28) { Destroy(gameObject); Destroy(pnal4); scor7  = 0; }
        else if (scor7 == 35) { Destroy(gameObject); Destroy(pnal5); scor7  = 0; }
        else if (scor7 == 42) { Destroy(gameObject); Destroy(pnal6); scor7  = 0; }
        else if (scor7 == 49) { Destroy(gameObject); Destroy(pnal7); scor7  = 0; }
        else if (scor7 == 56) { Destroy(gameObject); Destroy(pnal8); scor7  = 0; }
        else if (scor7 == 63) { Destroy(gameObject); Destroy(pnal9); scor7 = 0; }
        else if (scor7 == 70) { Destroy(gameObject); Destroy(pnal10); scor7  = 0;}
        else if (scor7 == 77) { Destroy(gameObject); Destroy(pnal11); scor7  = 0;}
        else if (scor7 == 84) { Destroy(gameObject); Destroy(pnal12); scor7 = 0; }
       
    }
}
