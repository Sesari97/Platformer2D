using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FruitsCollected : MonoBehaviour
{

    public AudioSource sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

        
        GetComponent<SpriteRenderer>().enabled = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        GetComponent<Collider2D>().enabled = false;
        Destroy(gameObject,0.3f);
        SceneController.fruitsRemaining--;
        GameObject.Find("controlCenter").GetComponent<SceneController>().checkFruitsRemaining();

            sound.Play();
        }
    }
}
