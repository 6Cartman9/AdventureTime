using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destrictable : MonoBehaviour
{
    [SerializeField] private int MaxHitPoint;

    public UnityEvent Died;
    public UnityEvent ChangeHitPoint;
    private int hitPoint;

    private void Start()
    {
        hitPoint = MaxHitPoint;
        ChangeHitPoint.Invoke();
    }

    public void ApplyDamage(int damage)
    {
        hitPoint -= damage;

        ChangeHitPoint.Invoke();

        if(hitPoint <= 0)
        {
            Kill();
        }
    }
    public void Kill()
    {
        hitPoint = 0;

        ChangeHitPoint.Invoke();
        Died.Invoke();
    }    
   public int GetHitPoint()
    {
        return hitPoint;
    }

    public int GetMaxHitPoint()
    {
        return MaxHitPoint;
    }
    public void HpHeal(int heal)
    {
        hitPoint += heal;
        ChangeHitPoint.Invoke();
        if (hitPoint >= MaxHitPoint) hitPoint = MaxHitPoint;
    }
}
