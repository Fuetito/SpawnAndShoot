using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, ITakeDamage
{

    private float _currentHealth;
    private float _maxHealth = 100;

    private bool _dead;
    public static Action OnDeath;
    public static Action <float>OnDamage; //tengo que poner float para que cuando lo invoque le paso un parametro tipo float


    private void Start()
    {
        _currentHealth = _maxHealth;
    }
    public void TakeDamage(float amount)
    {
        _currentHealth -= amount;
        Debug.Log("illo k daño" + _currentHealth);

        OnDamage?.Invoke(_currentHealth/_maxHealth);
        if(_currentHealth <=0 && !_dead) //si la vida es menor que 0 y no estoy muerto ya, muero
        {
            Die();
        }
    }

    private void Die()
    {
        _dead = true;
        OnDeath?.Invoke(); //invoke es de unity. Invoca el ondeath
    }
}
