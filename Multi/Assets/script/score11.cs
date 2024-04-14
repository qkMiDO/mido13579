using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score11 : MonoBehaviour
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
    public static int scor11 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor11.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scor11 == 11) { Destroy(gameObject); Destroy(pnal1); scor11 = 0; }
        else if (scor11 == 22) { Destroy(gameObject); Destroy(pnal2); scor11 = 0; }
        else if (scor11 == 33) { Destroy(gameObject); Destroy(pnal3); scor11 = 0; }
        else if (scor11 == 44) { Destroy(gameObject); Destroy(pnal4); scor11 = 0; }
        else if (scor11 == 55) { Destroy(gameObject); Destroy(pnal5); scor11 = 0; }
        else if (scor11 == 66) { Destroy(gameObject); Destroy(pnal6); scor11 = 0; }
        else if (scor11 == 77) { Destroy(gameObject); Destroy(pnal7); scor11 = 0; }
        else if (scor11 == 88) { Destroy(gameObject); Destroy(pnal8); scor11 = 0; }
        else if (scor11 == 99) { Destroy(gameObject); Destroy(pnal9); scor11 = 0; }
        else if (scor11 == 110) { Destroy(gameObject); Destroy(pnal10); scor11 = 0; }
        else if (scor11 == 121) { Destroy(gameObject); Destroy(pnal11); scor11 = 0; }
        else if (scor11 == 133) { Destroy(gameObject); Destroy(pnal12); scor11 = 0; }
        
    }
}
