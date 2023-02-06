using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_GoScene_1 : MonoBehaviour
{
    public Animator NOIR;
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("House");
    }
}
