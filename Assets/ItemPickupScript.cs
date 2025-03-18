using UnityEngine;

public class ItemPickupScript : MonoBehaviour
{
    public string itemName;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Notify the player to pick up the item
            Inventory.Instance.AddItem(this);
            Destroy(gameObject);
        }
    }
}
