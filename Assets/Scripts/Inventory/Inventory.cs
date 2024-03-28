using System;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    private bool inventoryOn;
    
    public GameObject[] slots;
    [SerializeField]
    private GameObject inventory;

    private void Start()
    {
        inventoryOn = false;
        inventory.SetActive(false);
    }

    public void Chest()
    {
        if (inventoryOn == false)
        {
            inventoryOn = true;
            inventory.SetActive(true);
        }
        else
        {
            inventoryOn = false;
            inventory.SetActive(false);
        }
    }
}
