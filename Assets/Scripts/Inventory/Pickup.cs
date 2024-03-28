using System;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject slotButton;
    
    private Inventory inventory;

    private void Start()
    {
        inventory = GameObject.FindWithTag(Constants.Data.PLAYER).GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(Constants.Data.PLAYER))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(slotButton, inventory.slots[i].transform);
                    Destroy(this.gameObject);
                    break;
                }
            }
        }
    }
}
