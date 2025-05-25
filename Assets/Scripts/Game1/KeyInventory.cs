using System.Collections.Generic;
using UnityEngine;

public class KeyInventory : MonoBehaviour
{
    private HashSet<string> keys = new HashSet<string>();

    public void AddKey(string key)
    {
        keys.Add(key);
        Debug.Log("Ключ добавлен: " + key);
    }

    public bool HasKey(string key)
    {
        return keys.Contains(key);
    }
}