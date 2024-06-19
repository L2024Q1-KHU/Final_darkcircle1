using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Action_LoadScene : MonoBehaviour
{
    public string LoadSceneName; // cannot assign scene object!!!

    public void RunAction(RaycastHit hit)
    {
        SceneManager.LoadScene(LoadSceneName);
    }
}
