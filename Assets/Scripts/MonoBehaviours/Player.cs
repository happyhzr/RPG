using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CanBePickedUp"))
        {
            Item hitObject = collision.gameObject.GetComponent<Consumable>().item;
            if (hitObject != null)
            {
                print("it: " + hitObject.objectName);
                switch (hitObject.itemType)
                {
                    case Item.ItemType.COIN:
                        break;
                    case Item.ItemType.HEALTH:
                        AdjustHitPoints(hitObject.quantity);
                        break;
                    default:
                        break;
                }
                collision.gameObject.SetActive(false);
            }
        }
    }

    public void AdjustHitPoints(int amount)
    {
        hitPoints = hitPoints + amount;
        print("Adjusted hitpoints by: " + amount + ". New value: " + hitPoints);
    }
}
