using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private GameObject slotPrefab; 
    [SerializeField] private GameObject slotPrefab_2;
    [SerializeField] private Transform slotParent;

    public Button backBtn;
    public Button itemBtn;
    public Sprite shieldIcon;

    private List<UISlot> slotList = new List<UISlot>();
    private Character player;

    private void Start()
    {
        player = GameManager.Instance.PlayerCharacter;
        backBtn.onClick.AddListener(Back);
        itemBtn.onClick.AddListener(FarmItem); 
        InitInventoryUI();
    }

    public void InitInventoryUI()
    {
        for (int i = slotList.Count - 1; i >= 0; i--)
        {
            Destroy(slotList[i].gameObject);
        }
        slotList.Clear();

        for (int i = 0; i < player.Inventory.Count; i++)
        {
            AddItemToUI(player.Inventory[i]);
        }
    }

    public void FarmItem()
    {
        // 가상의 아이템 생성
        Item newItem = new Item("Stout Shield", "Strong shield can prevent fire", 0, 100, 0, shieldIcon); 
        player.Inventory.Add(newItem);  
        AddItemToUI(newItem);  
        GameManager.Instance.SetData();
    }

    private void AddItemToUI(Item item)
    {
        GameObject selectedPrefab = Random.value < 0.5f ? slotPrefab : slotPrefab_2;
        GameObject newSlotObj = Instantiate(selectedPrefab, slotParent);
        UISlot newSlot = newSlotObj.GetComponent<UISlot>();
        newSlot.SetItem(item);
        slotList.Add(newSlot);
    }

    private void Back()
    {
        UIManager.Instance.Back();
    }
}
