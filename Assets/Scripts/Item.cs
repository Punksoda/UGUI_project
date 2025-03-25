using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName;  // 아이템 이름
    public string itemDescription;  // 아이템 설명
    public int itemID;  // 아이템 고유 ID
    public Sprite itemIcon;  // 아이템 아이콘
    public bool isEquipped;  // 아이템 장착 여부

    // 생성자
    public Item(string name, string description, int id, Sprite icon)
    {
        itemName = name;
        itemDescription = description;
        itemID = id;
        itemIcon = icon;
        isEquipped = false;  // 기본적으로 장착되지 않음
    }
}
