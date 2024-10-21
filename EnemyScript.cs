using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{

    
    private int HP = 100;
    public Animator animation;
    public Slider healthBar;

    private void Update()
    {
        healthBar.value = HP;
    }

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;

        if (HP <= 0)
        {
            animation.SetTrigger("Death");
            GetComponent<Collider>().enabled = false;
            healthBar.gameObject.SetActive(false);
            
        }
        else
        {
            animation.SetTrigger("GetHit");
        }
    }
    public void EnemyGolemDead()
    {
        if (HP <= 0) 
        { 

        }
    }
}
