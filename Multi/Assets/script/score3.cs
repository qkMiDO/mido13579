using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score3 : MonoBehaviour
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
    public static int scor3 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor3.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scor3 == 3) {Destroy(gameObject); Destroy(pnal1); scor3 = 0; }
        else if (scor3 == 6) { Destroy(gameObject); Destroy(pnal2); scor3 = 0; }
        else if (scor3 == 9) {Destroy(gameObject); Destroy(pnal3); scor3 = 0; }
        else if (scor3 == 12){ Destroy(gameObject); Destroy(pnal4); scor3 = 0; }
        else if (scor3 == 15){ Destroy(gameObject); Destroy(pnal5); scor3 = 0; }
        else if (scor3 == 18){Destroy(gameObject); Destroy(pnal6); scor3 = 0; }
        else if (scor3 == 21){ Destroy(gameObject); Destroy(pnal7); scor3 = 0; }
        else if (scor3 == 24){Destroy(gameObject); Destroy(pnal8); scor3 = 0; }
        else if (scor3 == 27){Destroy(gameObject); Destroy(pnal9); scor3 = 0; }
        else if (scor3 == 30){ Destroy(gameObject); Destroy(pnal10); scor3 = 0; }
        else if (scor3 == 33){Destroy(gameObject); Destroy(pnal11); scor3 = 0; }
        else if (scor3 == 36) { Destroy(gameObject); Destroy(pnal12); scor3 = 0; }
        
    }
}
