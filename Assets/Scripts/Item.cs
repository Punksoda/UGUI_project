using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName;  // ������ �̸�
    public string itemDescription;  // ������ ����
    public int itemID;  // ������ ���� ID
    public Sprite itemIcon;  // ������ ������
    public bool isEquipped;  // ������ ���� ����

    // ������
    public Item(string name, string description, int id, Sprite icon)
    {
        itemName = name;
        itemDescription = description;
        itemID = id;
        itemIcon = icon;
        isEquipped = false;  // �⺻������ �������� ����
    }
}
