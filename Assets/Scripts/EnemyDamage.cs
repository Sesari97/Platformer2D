using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Ay! " + collision.gameObject);
            Debug.Log("el objeto " + collision.gameObject + " se ha hecho daño");
            collision.gameObject.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }
}
