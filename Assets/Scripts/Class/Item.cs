using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName;  
    public string itemDescription;  
    public int itemAttack; 
    public int itemDeffense; 
    public int itemCritical; 
    public Sprite itemIcon;  
    public bool isEquipped;  

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
