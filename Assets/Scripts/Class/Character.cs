using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    public string Name { get; private set; } 
    public string Description { get; private set; } 
    public int Level { get; private set; } 
    public int Exp { get; private set; } 
    public int Atk { get; private set; } 
    public int Def { get; private set; } 
    public int Hp { get; private set; } 
    public int Crit { get; private set; } 
    public int Gold { get; private set; } 
    public List<Item> E_Item { get; private set; } // 장착된 아이템
    public List<Item> Inventory { get; private set; } // 인벤토리

    // 생성자
    public Character(string name, string description, int level, int exp, int def, int hp, int gold, int crit, int atk, List<Item> inventory = null)
    {
        Name = name;
        Description = description;
        Level = level;
        Exp = exp;
        Def = def;
        Hp = hp;
        Gold = gold;
        Crit = crit;
        Atk = atk;
        Inventory = inventory ?? new List<Item>();
        E_Item = new List<Item>();
    }

    // 아이템 추가
    public void AddItem(Item item)
    {
        if (item != null)
        {
            Inventory.Add(item);
            Debug.Log($"{item.itemName}을 인벤토리에 추가했습니다!");

        }
    }

    // 아이템 장착 (여러 개 가능하도록 변경)
    public void EquipItem(Item item)
    {
        if (Inventory.Contains(item) && !E_Item.Contains(item))
        {
            E_Item.Add(item);
            item.isEquipped = true;
            GameManager.Instance.SetData();
        }
        else
        {
            Debug.Log($"{item.itemName}은 인벤토리에 없거나 이미 장착되어 있습니다.");
        }
    }

    // 특정 아이템 해제
    public void UnequipItem(Item item)
    {
        if (E_Item.Contains(item))
        {
            E_Item.Remove(item);
            item.isEquipped = false;
            GameManager.Instance.SetData();
        }
        else
        {
            Debug.Log("해제할 아이템이 없습니다.");
        }
    }

    // 아이템 장착/해제 토글 (리스트 반영)
    public void ToggleEquip(Item item)
    {
        if (E_Item.Contains(item))
        {
            UnequipItem(item);
            Debug.Log($"{item.itemName}이 해제되었습니다!");
        }
        else
        {
            EquipItem(item);
            Debug.Log($"{item.itemName}이 장착되었습니다!");
        }
    }

}
