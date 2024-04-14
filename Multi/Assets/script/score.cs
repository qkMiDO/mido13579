using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//level 1
public class score : MonoBehaviour
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
    public static int scor=0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
     Text.text = scor.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (scor == 1) {Destroy(gameObject); Destroy(pnal1); scor = 0; }
    else if (scor == 2){ Destroy(gameObject); Destroy(pnal2); scor = 0; }
   else if (scor == 3) {Destroy(gameObject); Destroy(pnal3); scor = 0; }
   else if (scor == 4) { Destroy(gameObject); Destroy(pnal4); scor = 0; }
   else if (scor == 5) { Destroy(gameObject); Destroy(pnal5); scor = 0; }
   else if (scor == 6) {Destroy(gameObject); Destroy(pnal6); scor = 0; }
   else if (scor == 7) { Destroy(gameObject); Destroy(pnal7); scor = 0; }
   else if (scor == 8) {Destroy(gameObject); Destroy(pnal8); scor = 0; }
   else if (scor == 9) {Destroy(gameObject); Destroy(pnal9); scor = 0; }
   else if (scor == 10){ Destroy(gameObject); Destroy(pnal10); scor = 0; }
   else if (scor == 11){Destroy(gameObject); Destroy(pnal11); scor = 0; }
   else if (scor == 12){ Destroy(gameObject); Destroy(pnal12); scor = 0; }
           
    }
}
