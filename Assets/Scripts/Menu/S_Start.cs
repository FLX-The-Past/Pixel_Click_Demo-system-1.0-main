using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_Start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangeScene(string _scenename)
    {
        SceneManager.LoadScene(_scenename);
    }

    public void quit()
    {
        Application.Quit();
    }
}
