using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
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
    public Item E_Item { get; private set; } // ������ ������
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

    // ������ ����
    public void EquipItem(Item item)
    {
        if (Inventory.Contains(item))
        {
            if (E_Item != null)
            {
                Debug.Log($"{E_Item.itemName}�� �̹� �����Ǿ� �ֽ��ϴ�!");
            }
            else
            {
                E_Item = item;
                item.isEquipped = true;
                Debug.Log($"{item.itemName}�� �����߽��ϴ�!");
            }
        }
        else
        {
            Debug.Log($"{item.itemName}�� �κ��丮�� �����ϴ�.");
        }
    }

    // ������ ����
    public void UnequipItem()
    {
        if (E_Item != null)
        {
            Debug.Log($"{E_Item.itemName}�� �����߽��ϴ�!");
            E_Item.isEquipped = false;
            E_Item = null;
        }
        else
        {
            Debug.Log("������ �������� �����ϴ�.");
        }
    }

    // ������ ����/���� ���
    public void ToggleEquip(Item item)
    {
        if (E_Item == item)
        {
            UnequipItem();
        }
        else
        {
            EquipItem(item);
        }
    }
}
