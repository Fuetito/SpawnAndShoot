using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuddenDeath : MonoBehaviour, ITakeDamage
{
    public void TakeDamage(float amount)
    {
        Destroy(gameObject);
    }
}
