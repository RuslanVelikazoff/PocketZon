using System;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public int i;
    
    private Inventory inventory;

    private void Start()
    {
        inventory = GameObject.FindWithTag(Constants.Data.PLAYER).GetComponent<Inventory>();
    }

    private void Update()
    {
        if (transform.childCount <= 0)
        {
            inventory.isFull[i] = false;
        }
    }

    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
