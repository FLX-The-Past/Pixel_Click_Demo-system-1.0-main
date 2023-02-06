using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S_DoorUnlocked : MonoBehaviour
{
    public S_ClicktoMove Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.Active)
        {
            Destroy(gameObject);
        }
    }
}
