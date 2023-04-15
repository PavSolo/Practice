using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image bar;
    public float HP;
    public float maxHealth=100f;
    public float damage;
    public GameObject restartButton;
    public void Heal(float heal)
    {
        HP += heal;
    }
    public void Kill()
    {
        HP -= maxHealth;
    }
    void Start()
    {
        bar = GetComponent<Image>();
         
    }

    // Update is called once per frame
    void Update()
    {
        HP -= Time.deltaTime * damage;
        bar.fillAmount = HP / maxHealth;
        if (bar.fillAmount <= 0)
        {
            restartButton.SetActive(true);
        }
    }
}
