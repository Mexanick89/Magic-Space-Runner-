using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLvl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Restart")
        {
            SceneManager.LoadScene(0);
        }
        if (other.tag == "Restart1")
        {
            SceneManager.LoadScene(1);
        }
        if (other.tag == "Restart2")
        {
            SceneManager.LoadScene(2);
        }
        if (other.tag == "NextLvl")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
