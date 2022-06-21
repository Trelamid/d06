using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeNotes : MonoBehaviour
{
    public GameObject text;
    private bool _near; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            text.SetActive(true);
            _near = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        // if (_near && Input.GetKey(KeyCode.F))
        // {
        //     other.gameObject.GetComponent<Player>().Win();
        //     Destroy(this.gameObject);
        // }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _near = false;
            text.SetActive(false);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_near && Input.GetKey(KeyCode.F))
        {
            GameObject.FindWithTag("Player").GetComponent<Player>().Win();
            Destroy(this.gameObject);
        }
    }
}
