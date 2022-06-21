using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Cor(other.gameObject));
        }
    }
    
    // private void OnCollisionEnter(Collision other)
    // {
    //     if (other.gameObject.tag == "Player")
    //     {
    //         StartCoroutine(Cor(other.gameObject));
    //     }
    // }
    
    

    IEnumerator Cor(GameObject pl)
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.2f);
        pl.GetComponent<Player>().haveKey = true;
        Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
