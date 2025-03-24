using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name { get; private set; } // ������Ƽ�� ����
    public string Description { get; private set; }
    public int Level {  get; private set; }
    public int Exp { get; private set; }
    public int Atk { get; private set; }
    public int Def { get; private set; }
    public int Hp {  get; private set; }
    public int Crit { get; private set; }
    public int Gold {  get; private set; }
    public GameObject E_Item { get; private set; }
    public List<GameObject>Inventory = new List<GameObject>();

    // ������ �����, �����ڸ� ������� �ʿ�� ���� �ֳ��ϸ�, Monobehaviour�� ��ӹ޴� �̻�, �����ڸ� ���� �� ���ٱ���
    // ��Ȯ�ϰԴ� �����͸� �������ְ�, ���� �Ҵ����ִ� ���� ���������� ������Ʈ�� ����� ����� �� ����
    public Character (string name, string description, int level, int exp, int def, int hp, int gold, int crit, int atk)
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
    }

    public void Additem(GameObject item)
    {
        if(item != null)
        {
            Inventory.Add(item);
            Debug.Log($"{item.name}�� �κ��丮�� �߰��߽��ϴ�!");
        }
    }

    public void Equipitem(GameObject item)
    {
        if(Inventory.Contains(item))
        {
           E_Item = item;
           Debug.Log($"{item.name}�� �����߽��ϴ�!");
        }
    }

    public void UnequipItem()
    {
        if(E_Item != null)
        {
            Debug.Log($"{E_Item.name}�� �����߽��ϴ�!");
            E_Item = null;
        }
    }
}
