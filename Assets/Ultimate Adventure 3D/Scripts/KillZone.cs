using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destrictable destrictable = other.GetComponent<Destrictable>();

        if (destrictable != null)
        {
            destrictable.Kill();
        }
    }
}
