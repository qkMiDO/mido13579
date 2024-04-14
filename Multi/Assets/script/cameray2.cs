using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameray2 : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject player2;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, player2.transform.position.y, transform.position.z);
    }

}
