using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_SetActive : MonoBehaviour
{
    public S_ClicktoMove Player;
    public bool Desactive;
    void Start()
    {
        gameObject.SetActive(false);
        Desactive = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
