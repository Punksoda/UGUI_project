using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName;  // 아이템 이름
    public string itemDescription;  // 아이템 설명
    public int itemAttack; // 아이템 공격력
    public int itemDeffense; // 아이템 방어력
    public int itemCritical; // 아이템 치명타율
    public Sprite itemIcon;  // 아이템 아이콘
    public bool isEquipped;  // 아이템 장착 여부

    // 생성자
    public Item(string name, string description, int i_Atk, int i_Def, int i_Crit, Sprite icon)
    {
        itemName = name;
        itemDescription = description;
        itemAttack = i_Atk;
        itemDeffense = i_Def;
        itemCritical = i_Crit;
        itemIcon = icon;
        isEquipped = false;  // 기본적으로 장착되지 않음
    }
}
