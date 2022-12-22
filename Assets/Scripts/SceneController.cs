using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SceneController : MonoBehaviour
{
    public GameObject fruitCollection;
    public static int fruitsRemaining;

    public TextMeshProUGUI textFruitsTotal;
    public TextMeshProUGUI textFruitsCollected;

    void Start()
    {
        fruitsRemaining = fruitCollection.gameObject.transform.childCount;
        textFruitsTotal.text = fruitsRemaining.ToString();
        checkFruitsRemaining();
    }

    public void checkFruitsRemaining()
    {
        Debug.Log("Quedan " + fruitsRemaining + " frutas");
        textFruitsCollected.text = (int.Parse(textFruitsTotal.text) - fruitsRemaining).ToString();

        if (fruitsRemaining == 0)
        {
            Debug.Log("Has recogido todas las frutas");
        }

    }

}
