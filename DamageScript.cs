using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageScript : MonoBehaviour
{
    public int damageAmount = 20;


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyScript>().TakeDamage(damageAmount);
            
        }
    }
}
