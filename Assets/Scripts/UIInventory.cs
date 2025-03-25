using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private GameObject slotPrefab;  // UISlot 프리팹
    [SerializeField] private Transform slotParent;  // 슬롯이 배치될 부모 객체

    public Button backBtn;

    private List<UISlot> slotList = new List<UISlot>();  // 슬롯 목록
    private Character player;  // 플레이어 캐릭터

    private void Start()
    {
        player = GameManager.Instance.PlayerCharacter;
        backBtn.onClick.AddListener(Back);
        InitInventoryUI();
    }

    // 인벤토리 UI 초기화
    public void InitInventoryUI()
    {
        // 기존 슬롯 삭제
        foreach (var slot in slotList)
        {
            Destroy(slot.gameObject);
        }
        slotList.Clear();

        // 플레이어 인벤토리의 아이템 수 만큼 슬롯을 생성
        foreach (var item in player.Inventory)
        {
            GameObject newSlotObj = Instantiate(slotPrefab, slotParent);
            UISlot newSlot = newSlotObj.GetComponent<UISlot>();
            newSlot.SetItem(item);  // 아이템 설정
            slotList.Add(newSlot);  // 슬롯 목록에 추가
        }
    }

    // 인벤토리 UI 갱신
    public void UpdateInventoryUI()
    {
        foreach (var slot in slotList)
        {
            slot.RefreshUI();  // 각 슬롯의 UI 갱신
        }
    }

    private void Back()
    {
        UIManager.Instance.Back();
    }

}
