using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class che : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player; public GameObject player2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        transform.position = new Vector3(player2.transform.position.x, transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player1"))
        { 
            Destroy(player);
            SceneManager.LoadScene(1);
            Destroy(player2);
            SceneManager.LoadScene(1);
        }
        if (collision.CompareTag("player2"))
        {
            Destroy(player);
            SceneManager.LoadScene(2);
            Destroy(player2);
            SceneManager.LoadScene(2);
        }
        if (collision.CompareTag("player3"))
        {
            Destroy(player);
            SceneManager.LoadScene(5);
            Destroy(player2);
            SceneManager.LoadScene(5);
        }
        if (collision.CompareTag("player4"))
        {
            Destroy(player);
            SceneManager.LoadScene(6);
            Destroy(player2);
            SceneManager.LoadScene(6);
        }
        if (collision.CompareTag("player5"))
        {
            Destroy(player);
            SceneManager.LoadScene(7);
            Destroy(player2);
            SceneManager.LoadScene(7);
        }
        if (collision.CompareTag("player6"))
        {
            Destroy(player);
            SceneManager.LoadScene(8);
            Destroy(player2);
            SceneManager.LoadScene(8);
        }
        if (collision.CompareTag("player7"))
        {
            Destroy(player);
            SceneManager.LoadScene(9);
            Destroy(player2);
            SceneManager.LoadScene(9);
        }
        if (collision.CompareTag("player8"))
        {
            Destroy(player);
            SceneManager.LoadScene(10);
            Destroy(player2);
            SceneManager.LoadScene(10);
        }
        if (collision.CompareTag("player9"))
        {
            Destroy(player);
            SceneManager.LoadScene(11);
            Destroy(player2);
            SceneManager.LoadScene(11);
        }
        if (collision.CompareTag("player10"))
        {
            Destroy(player);
            SceneManager.LoadScene(4);
            Destroy(player2);
            SceneManager.LoadScene(4);
        }
        if (collision.CompareTag("player11"))
        {
            Destroy(player);
            SceneManager.LoadScene(13);
            Destroy(player2);
            SceneManager.LoadScene(13);
        }
        if (collision.CompareTag("player12"))
        {
            Destroy(player);
            SceneManager.LoadScene(14);
            Destroy(player2);
            SceneManager.LoadScene(14);
        }

    }
}