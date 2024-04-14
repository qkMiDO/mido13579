using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score12 : MonoBehaviour
{
    public GameObject pnal12;
    Text Text;
    public static int scor12 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor12.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (scor12 == 144){ Destroy(gameObject); Destroy(pnal12);scor12 = 0; }
        
    }
}
