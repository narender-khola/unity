using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenuManager : MonoBehaviour
{
    public static int howManyPlayers;

    public void TwoPlayers()
    {
        SoundManager.buttonAudioSource.Play();
        howManyPlayers = 2;
        SceneManager.LoadScene("Ludo");

    }

    public void TheePlayers()
    {
        SoundManager.buttonAudioSource.Play();
        howManyPlayers = 3;
        SceneManager.LoadScene("Ludo");

    }

    public void Fourlayers()
    {
        SoundManager.buttonAudioSource.Play();
        howManyPlayers = 4;
        SceneManager.LoadScene("Ludo");

    }

    public void Quit()
    {
        SoundManager.buttonAudioSource.Play();
        if (EditorApplication.isPlaying == true)
        {
            EditorApplication.isPlaying = false;
        }
    }
}
