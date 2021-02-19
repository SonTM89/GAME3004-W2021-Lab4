using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class HealthBar : MonoBehaviour
{
    [Range(0,100)]
    public int currentHealth = 0;

    [Range(0, 100)]
    public int maximumHealth = 0;

    public Slider healthBarSlider;

    // Start is called before the first frame update
    void Start()
    {
        healthBarSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            TakeDame(10);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
    }

    public void Reset()
    {
        healthBarSlider.value = maximumHealth;
        currentHealth = maximumHealth;
    }

    public void TakeDame(int damage)
    {
        healthBarSlider.value -= damage;
        currentHealth -= damage;
    }
}
