using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private static ItemManager _instance;
    public static ItemManager Instance => _instance;

    public Sprite swordIcon;
    public Sprite shieldIcon;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Item CreateItem(string itemName)
    {
        switch (itemName)
        {
            case "Fire Sword":
                return new Item("Fire Sword", "A sword imbued with fire", 100, 50, 10, swordIcon);
            case "Stout Shield":
                return new Item("Stout Shield", "Strong shield can prevent fire", 0, 100, 0, shieldIcon);
            default:
                Debug.LogError($"아이템 '{itemName}'을 찾을 수 없습니다!");
                return null;
        }
    }
}