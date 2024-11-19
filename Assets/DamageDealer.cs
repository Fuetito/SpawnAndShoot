using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public float Damage = 5;

    private void OnCollisionEnter(Collision collision) //el objeto tiene collider entonces usamor collision enter
    {
        ITakeDamage[] damageTakers = collision.collider.GetComponents<ITakeDamage>();  //el collider es con quién he chocado. Con quien haya chocado quiero coger el take damage        Si ponemos ComponentS, coge varios

        if (damageTakers != null)
        {
            foreach(var item in damageTakers) //sin el plural de components el foreach no se pone y en vez de item se pone damageTaker.algo
            {
                item.TakeDamage(Damage);

            }
        }
    }
}
