using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    public string Name { get; private set; } // ĳ���� �̸�
    public string Description { get; private set; } // ĳ���� ����
    public int Level { get; private set; } // ����
    public int Exp { get; private set; } // ����ġ
    public int Atk { get; private set; } // ���ݷ�
    public int Def { get; private set; } // ����
    public int Hp { get; private set; } // ü��
    public int Crit { get; private set; } // ġ��Ÿ Ȯ��
    public int Gold { get; private set; } // ���� �ݾ�
    public List<Item> E_Item { get; private set; } // ������ ������
    public List<Item> Inventory { get; private set; } // �κ��丮

    // ������
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
        Inventory = inventory ?? new List<Item>();  // �⺻������ �� ����Ʈ �Ҵ�
        E_Item = new List<Item>();
    }

    // ������ �߰�
    public void AddItem(Item item)
    {
        if (item != null)
        {
            Inventory.Add(item);
            Debug.Log($"{item.itemName}�� �κ��丮�� �߰��߽��ϴ�!");

        }
    }

    // ������ ���� (���� �� �����ϵ��� ����)
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
            Debug.Log($"{item.itemName}�� �κ��丮�� ���ų� �̹� �����Ǿ� �ֽ��ϴ�.");
        }
    }

    // Ư�� ������ ����
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
            Debug.Log("������ �������� �����ϴ�.");
        }
    }

    // ������ ����/���� ��� (����Ʈ �ݿ�)
    public void ToggleEquip(Item item)
    {
        if (E_Item.Contains(item))
        {
            UnequipItem(item);
            Debug.Log($"{item.itemName}�� �����Ǿ����ϴ�!");
        }
        else
        {
            EquipItem(item);
            Debug.Log($"{item.itemName}�� �����Ǿ����ϴ�!");
        }
    }

}
