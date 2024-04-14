using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player2;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player2.transform.position.x, transform.position.y, transform.position.z);
    }
}
