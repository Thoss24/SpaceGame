using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            // log warning message to console if another instance of inventory exists
            Debug.LogWarning("More than one instance of inventory found!");
            return;
        }
        Instance = this;
    }

    public List<string> items = new List<string>();

    public void AddItem(ItemPickupScript item)
    {
        items.Add(item.itemName);
        Debug.Log("Item added" + item.itemName);
    }
}

