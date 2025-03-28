using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemIcon;  
    [SerializeField] private Text itemNameText;  
    [SerializeField] private Button slotButton; 

    private Item currentItem;  // 현재 슬롯에 저장된 아이템

    // 아이템 설정
    public void SetItem(Item item)
    {
        currentItem = item;

        if (currentItem != null)
        {
            itemIcon.sprite = currentItem.itemIcon;  // 아이콘 설정
            itemNameText.text = currentItem.itemName;  // 이름 설정
            slotButton.onClick.RemoveAllListeners();
            slotButton.onClick.AddListener(() => UEquip());  // 슬롯 클릭 시 장착/해제
        }
        else
        {
            itemIcon.sprite = null;  // 아이템이 없으면 아이콘 제거
            itemNameText.text = "Empty";  // 빈 슬롯 표시
        }
    }

    // UI 갱신
    public void RefreshUI()
    {
        if (currentItem != null)
        {
            itemIcon.color = currentItem.isEquipped ? Color.green : Color.white;  // 장착된 아이템은 색상 변경
        }
    }

    // 아이템 장착/해제
    private void UEquip()
    {
        if (currentItem != null)
        {
            GameManager.Instance.PlayerCharacter.ToggleEquip(currentItem);
            RefreshUI();  // UI 갱신
        }
    }
}
