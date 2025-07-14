using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKey : MonoBehaviour
{
    [SerializeField] private Bag bag;
    [SerializeField] private Text text;

    private void Start()
    {
       bag.ChangeAmountKey.AddListener(OnChangeHitPoint);
    }

    private void OnDestroy()
    {
        bag.ChangeAmountKey.RemoveListener(OnChangeHitPoint);
    }

    private void OnChangeHitPoint()
    {
        text.text = bag.GetAmountKey().ToString();
    }
}
