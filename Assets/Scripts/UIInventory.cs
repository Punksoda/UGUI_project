using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button backBtn;
    public Button checkBtn;
    public GameObject slot;
    public Transform slotTransform;

    private Character player;
    private List<GameObject> inventoryslots = new List<GameObject>();
 
    private void Start()
    {
        player = GameManager.Instance.PlayerCharacter;
        backBtn.onClick.AddListener(Back);
        checkBtn.onClick.AddListener(InventoryUI);
    }


    private void Back()
    {
        UIManager.Instance.Back();
    }

    private void InventoryUI()
    {
        GameObject newSlot = Instantiate(slot, slotTransform);
        inventoryslots.Add(newSlot);
    }

    private void ToggleEquip(GameObject item)
    {
        if(player.E_Item == item)
        {
            player.UnequipItem();
            Debug.Log($"{item.name} «ÿ¡¶µ ");
        }
        else
        {
            player.Equipitem(item);
            Debug.Log($"{item.name} ¿Â¬¯µ ");
        }
    }
}
