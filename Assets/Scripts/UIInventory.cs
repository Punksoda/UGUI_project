using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button backBtn;
    public Button checkBtn;
    public GameObject slot;
    public Transform slotTransform;


    List<GameObject> inventoryslots = new List<GameObject>();
 
    private void Start()
    {
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
}
