using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public Button btnStatus;
    public Button btnInven;
 

    public void Start()
    {
        btnStatus.onClick.AddListener(OpenStatus);
        btnInven.onClick.AddListener(OpenInventory);
        GameManager.Instance.SetData();
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.ShowUI(UIManager.Instance.mainMenu.gameObject);
    }

    public void OpenStatus()
    {
        UIManager.Instance.ShowUI(UIManager.Instance.status.gameObject);
    }

    public void OpenInventory()
    {
        UIManager.Instance.ShowUI(UIManager.Instance.inventory.gameObject);
    }

 
}
