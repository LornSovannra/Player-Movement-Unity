using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Inventory : MonoBehaviour
{
    public Text appleCounter;

    private int apples = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collectible"))
        {
            Collect(collision.GetComponent<Collectible>());
        }
    }

    private void Collect(Collectible collectible)
    {
        if (collectible.Collect())
        {
            if(collectible is AppleCollectible)
            {
                SoundManager.PlaySound();
                apples++;
            }
        }

        UpdateUI();
    }

    private void UpdateUI()
    {
        appleCounter.text = apples.ToString();
    }
}
