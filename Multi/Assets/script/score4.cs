using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score4 : MonoBehaviour
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
    public static int scor4 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor4.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scor4 == 4) { Destroy(gameObject); Destroy(pnal1); scor4 = 0; }
        else if (scor4 == 8) { Destroy(gameObject); Destroy(pnal2); scor4 = 0;}
        else if (scor4 == 12) { Destroy(gameObject); Destroy(pnal3);scor4 = 0; }
        else if (scor4 == 16) { Destroy(gameObject); Destroy(pnal4);scor4 = 0; }
        else if (scor4 == 20) { Destroy(gameObject); Destroy(pnal5);scor4 = 0; }
        else if (scor4 == 24) { Destroy(gameObject); Destroy(pnal6);scor4 = 0; }
        else if (scor4 == 28) { Destroy(gameObject); Destroy(pnal7);scor4 = 0; }
        else if (scor4 == 32) { Destroy(gameObject); Destroy(pnal8);scor4 = 0; }
        else if (scor4 == 36) { Destroy(gameObject); Destroy(pnal9); scor4 = 0; }
        else if (scor4 == 40) { Destroy(gameObject); Destroy(pnal10); scor4 = 0; }
        else if (scor4 == 44) { Destroy(gameObject); Destroy(pnal11); scor4 = 0; }
        else if (scor4 == 48) { Destroy(gameObject); Destroy(pnal12); scor4 = 0; }
        
    }
}
