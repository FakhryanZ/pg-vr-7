using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChooseAudio : MonoBehaviour
{
    public void MoveAudioScene(string scene){
        SceneManager.LoadScene(scene);
    }

    public void QuitApp(){
        Application.Quit();
    }
}
