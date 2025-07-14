using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFPS;

[RequireComponent(typeof(AudioSource))]

public class Acceleretion : MonoBehaviour
{
    [SerializeField] private int bonus;
    private new AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed += bonus;
            fps.m_WalkSpeed += bonus;
            fps.m_RunSpeed += bonus;
            audio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed -= bonus;
            fps.m_WalkSpeed -= bonus;
            fps.m_RunSpeed -= bonus;
        }
    }

}
