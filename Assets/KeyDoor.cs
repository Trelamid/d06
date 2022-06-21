using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    public GameObject lazer;
    public AudioSource _soundOpen;
    public GameObject _Text;

    public Shader _Shader;
    public Material Material;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _Text.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && other.gameObject.GetComponent<Player>().haveKey && Input.GetKey(KeyCode.F))
        {
            _soundOpen.Play();
            lazer.SetActive(false);
            // Material.
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _Text.SetActive(false);
        }
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
