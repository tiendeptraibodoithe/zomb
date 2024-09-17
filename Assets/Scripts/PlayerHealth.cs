using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHitPoints = 100f;

    public void PlayerTakeDamge(float damage)
    {
        playerHitPoints -= damage;
        if(playerHitPoints <= 0)
        {
            Debug.Log("Dead");
        }
    }
}
