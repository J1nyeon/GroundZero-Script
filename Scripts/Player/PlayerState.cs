using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    public InGameUIManager gameUIManager; 
    public float currentHp;
    public float maxHp = 100f;

    public List<Slider> hpSlider;
    
    private void Start()
    {
        for (int i = 0; i < hpSlider.Count; i++)
        {
            hpSlider[i].value = 1f;
        }
        currentHp = maxHp;      
    }
    public void Update()
    {
        for (int i = 0; i < hpSlider.Count; i++)
        {
            gameUIManager.HpUI(hpSlider[i], currentHp, maxHp);
        }
    }

    public void TakeDamage(float damage)
    {
        currentHp = Mathf.Clamp(currentHp, 0, maxHp);
        currentHp -= damage;

        if (currentHp <= 0)
        {
            currentHp = 0f;
            gameUIManager.Lose();
            //Debug.Log("체력 0 패배");
        }
        //UIManager.instance.HpUI(hpSlider, currentHp, maxHp);
    }
}
