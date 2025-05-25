using UnityEngine;

public class Key : MonoBehaviour
{
    public string keyID = "red"; // Уникальный ID ключа

    private void OnTriggerEnter2D(Collider2D other)
    {
        KeyInventory inventory = other.GetComponent<KeyInventory>();
        if (inventory != null)
        {
            inventory.AddKey(keyID);
            Destroy(gameObject); // Удаляем ключ
        }
    }
}