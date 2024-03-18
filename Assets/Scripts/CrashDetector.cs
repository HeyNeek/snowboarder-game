using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] AudioClip crashSfx;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            Debug.Log("Ouch!");
            FindObjectOfType<PlayerController>().DisableControls();
            GetComponent<AudioSource>().PlayOneShot(crashSfx);
            Invoke("ReloadScene", 0.5f);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
