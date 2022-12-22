using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitsCollected : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<SpriteRenderer>().enabled = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        GetComponent<Collider2D>().enabled = false;
        Destroy(gameObject,0.5f);
        SceneController.fruitsRemaining--;
        GameObject.Find("controlCenter").GetComponent<SceneController>().checkFruitsRemaining();
    }
}
