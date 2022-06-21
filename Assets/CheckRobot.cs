using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRobot : MonoBehaviour
{
    private Animator _animator;
    public GameObject light;
    public AudioSource sound;
    private void OnCollisionEnter(Collision collision)
    {
        light.SetActive(true);
        _animator.SetBool("Go", true);
        sound.Play();
    }

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
    }
}
