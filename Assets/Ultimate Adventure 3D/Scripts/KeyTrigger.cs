using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AudioSource))]
public class KeyTrigger : MonoBehaviour
{
    [SerializeField] private GameObject messageBox;
    [SerializeField] private UnityEvent Enter;
    [SerializeField] private int AmountKeyActivate;

    private new AudioSource audio;

    private bool IsActive;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    protected void OnTriggerEnter(Collider other)
    {
        if (IsActive == true) return;

        Bag bag = other.GetComponent<Bag>();

        if (bag != null)
        {
           if (bag.DrawKey(AmountKeyActivate) == true)
           {
                Enter.Invoke();
                IsActive = true;
                audio.Play();
            }
           else
            {
                messageBox.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        messageBox.SetActive(false);
    }
}
