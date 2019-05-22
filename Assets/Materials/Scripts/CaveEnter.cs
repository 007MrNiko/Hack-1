using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveEnter : MonoBehaviour
{
    public GameObject QueUI; 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Door"))
        {
            QueUI.SetActive(true);
        }
    }
    public void CaveEntering()
    {
        SceneManager.LoadScene("Level3");
    }
}
