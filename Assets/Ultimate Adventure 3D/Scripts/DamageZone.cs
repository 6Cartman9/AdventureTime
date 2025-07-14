using SimpleFPS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class DamageZone : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private float damageRate;

    private Destrictable destrictable;
    private float timer;
    private new AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (destrictable == null) return;

        timer += Time.deltaTime;

        if(timer >= damageRate)
        {
            if(destrictable != null)
            {
                destrictable.ApplyDamage(damage);
            }
            audio.Play();
            timer = 0;
        }    
    }
    private void OnTriggerEnter(Collider other)
    {
        destrictable = other.GetComponent<Destrictable>();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Destrictable>() == destrictable)
            destrictable = null;
    }
}
