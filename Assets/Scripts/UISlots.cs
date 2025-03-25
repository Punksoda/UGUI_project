using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemIcon;  // ������ ������ �̹���
    [SerializeField] private Text itemNameText;  // ������ �̸� �ؽ�Ʈ
    [SerializeField] private Button slotButton;  // ���� ��ư

    private Item currentItem;  // ���� ���Կ� ����� ������

    // ������ ����
    public void SetItem(Item item)
    {
        currentItem = item;

        if (currentItem != null)
        {
            itemIcon.sprite = currentItem.itemIcon;  // ������ ����
            itemNameText.text = currentItem.itemName;  // �̸� ����
            slotButton.onClick.RemoveAllListeners();
            slotButton.onClick.AddListener(() => ToggleEquip());  // ���� Ŭ�� �� ����/����
        }
        else
        {
            itemIcon.sprite = null;  // �������� ������ ������ ����
            itemNameText.text = "Empty";  // �� ���� ǥ��
        }
    }

    // UI ����
    public void RefreshUI()
    {
        if (currentItem != null)
        {
            itemIcon.color = currentItem.isEquipped ? Color.green : Color.white;  // ������ �������� ���� ����
        }
    }

    // ������ ����/����
    private void ToggleEquip()
    {
        if (currentItem != null)
        {
            GameManager.Instance.PlayerCharacter.ToggleEquip(currentItem);
            RefreshUI();  // UI ����
        }
    }
}
