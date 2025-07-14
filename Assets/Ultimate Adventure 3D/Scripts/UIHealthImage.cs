using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthImage : MonoBehaviour
{
    [SerializeField] private Destrictable destrictable;
    [SerializeField] private Image image;

    private void Start()
    {
        destrictable.ChangeHitPoint.AddListener(OnChangeHitPoint);
    }

    private void OnDestroy()
    {
        destrictable.ChangeHitPoint.RemoveListener(OnChangeHitPoint);
    }

    private void OnChangeHitPoint()
    {
        image.fillAmount = (float) destrictable.GetHitPoint() / (float) destrictable.GetMaxHitPoint();
    }
}
