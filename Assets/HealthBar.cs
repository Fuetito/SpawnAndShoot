using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Slider _mySlider;

    // Start is called before the first frame update
    void Start()
    {
        _mySlider = GetComponent < Slider>();
        PlayerHealth.OnDamage += Redraw;
    }

    private void Redraw(float value)
    {

    }
}