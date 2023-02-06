using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S_ClicktoMove : MonoBehaviour
{
    public float speed = 10f;
    private Vector2 lastClickedPos;
    public bool moving;
    [SerializeField] public float Score = 0;
    public bool CanOpen = false;
    public bool Active;
    public S_SetActive Cle;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }

        if (moving && (Vector2)transform.position != lastClickedPos)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
        }
        else
        {
            moving = false;
        }

        if (CanOpen == true)
        {
            Cle.gameObject.SetActive(true);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Key") && CanOpen == true )
        {
            Active = true;
        }
        
        if (other.gameObject.CompareTag("Object"))
        {
            Score++;
            CanOpen = true;
            Destroy(other.gameObject);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Key") && CanOpen == false)
        {
            Active = false;
        }
    }
}