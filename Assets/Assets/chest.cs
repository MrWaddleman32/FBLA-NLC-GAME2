using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chest : MonoBehaviour
{

    public bool isClose;
    public static bool lvl1Completed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isClose)
        {
            lvl1Completed = true;
            SceneManager.LoadSceneAsync(1);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isClose = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isClose = false;
    }
}
