using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource playAudio;
    private IEnumerator DelayLoadgame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PlayGame()
    {
       // playAudio.Play();
        StartCoroutine(DelayLoadgame());
        Debug.Log("play");
    }
    public void QuitGame ()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
