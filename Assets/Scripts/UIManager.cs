using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private UIMainMenu m_Menu;
    private UIStatus m_Status;
    private UIInventory m_Inventory;

    public UIMainMenu mainMenu { get => m_Menu;}
    public UIStatus status {  get => m_Status;}

    public UIInventory inventory { get => m_Inventory;}

    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        else
        {
            Destroy(gameObject);
            return;
        }
    }
}
