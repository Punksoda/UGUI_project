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
        string[] itemPool = { "Fire Sword", "Stout Shield" };
        string randomItemName = itemPool[Random.Range(0, itemPool.Length)]; // 랜덤으로 아이템 값 선택

        Item newItem = ItemManager.Instance.CreateItem(randomItemName); // 랜덤 아이템 값 생성
        if (newItem != null)
        {
            player.Inventory.Add(newItem);
            AddItemToUI(newItem);
            GameManager.Instance.SetData();
        }
     
    }

    private void AddItemToUI(Item item) // 슬롯에서 보여줄 아이템 프리팹 선택
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
