using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private GameObject slotPrefab;  // UISlot ������
    [SerializeField] private Transform slotParent;  // ������ ��ġ�� �θ� ��ü

    public Button backBtn;

    private List<UISlot> slotList = new List<UISlot>();  // ���� ���
    private Character player;  // �÷��̾� ĳ����

    private void Start()
    {
        player = GameManager.Instance.PlayerCharacter;
        backBtn.onClick.AddListener(Back);
        InitInventoryUI();
    }

    // �κ��丮 UI �ʱ�ȭ
    public void InitInventoryUI()
    {
        // ���� ���� ����
        foreach (var slot in slotList)
        {
            Destroy(slot.gameObject);
        }
        slotList.Clear();

        // �÷��̾� �κ��丮�� ������ �� ��ŭ ������ ����
        foreach (var item in player.Inventory)
        {
            GameObject newSlotObj = Instantiate(slotPrefab, slotParent);
            UISlot newSlot = newSlotObj.GetComponent<UISlot>();
            newSlot.SetItem(item);  // ������ ����
            slotList.Add(newSlot);  // ���� ��Ͽ� �߰�
        }
    }

    // �κ��丮 UI ����
    public void UpdateInventoryUI()
    {
        foreach (var slot in slotList)
        {
            slot.RefreshUI();  // �� ������ UI ����
        }
    }

    private void Back()
    {
        UIManager.Instance.Back();
    }

}
