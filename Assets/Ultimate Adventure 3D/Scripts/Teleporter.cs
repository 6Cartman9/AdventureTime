using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFPS;

[RequireComponent(typeof(AudioSource))]
public class Teleporter : MonoBehaviour
{
    [SerializeField] private Teleporter target;

    [HideInInspector] public bool IsReceive;
    private new AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (IsReceive == true) return;

        FirstPersonController fps = other.GetComponent<FirstPersonController>();
        
        if (fps != null)
        {
            target.IsReceive = true;

            fps.transform.position = target.transform.position;

            audio.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            IsReceive = false;

        }
    }
}
