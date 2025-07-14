using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingBottle : Pickup
{
    [SerializeField] private GameObject impactEffect;
    [SerializeField] private int Healing;

    private Destrictable destrictable;

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        destrictable = other.GetComponent<Destrictable>();

        if(destrictable != null)
        {
            destrictable.HpHeal(Healing);
            Instantiate(impactEffect);
        }
    }
}
