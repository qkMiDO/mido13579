using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class gameleve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("player1"))
        SceneManager.LoadScene(2);
        if (collision.CompareTag("player2"))
            SceneManager.LoadScene(5);
        if (collision.CompareTag("player3"))
            SceneManager.LoadScene(6);
        if (collision.CompareTag("player4"))
            SceneManager.LoadScene(7);
        if (collision.CompareTag("player5"))
            SceneManager.LoadScene(8);
        if (collision.CompareTag("player6"))
            SceneManager.LoadScene(9);
        if (collision.CompareTag("player7"))
            SceneManager.LoadScene(10);
        if (collision.CompareTag("player8"))
            SceneManager.LoadScene(11);
        if (collision.CompareTag("player9"))
            SceneManager.LoadScene(12);
        if (collision.CompareTag("player10"))
            SceneManager.LoadScene(13);
        if (collision.CompareTag("player11"))
            SceneManager.LoadScene(14);
        if (collision.CompareTag("player12"))
            SceneManager.LoadScene(15);
        if (collision.CompareTag("player13"))
            SceneManager.LoadScene(18);
        if (collision.CompareTag("player14"))
            SceneManager.LoadScene(19);
        if (collision.CompareTag("player15"))
            SceneManager.LoadScene(20);
        if (collision.CompareTag("player16"))
            SceneManager.LoadScene(0);

    }
}
