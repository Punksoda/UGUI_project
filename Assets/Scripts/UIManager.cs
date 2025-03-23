using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIMainMenu m_Menu;
    [SerializeField] private UIStatus m_Status;
    [SerializeField] private UIInventory m_Inventory;

    public UIMainMenu mainMenu // ������Ƽ�� ����Ͽ�, ���� �����ϰ�, ���ο����� �ش����� �Ҵ�� UI ��ɵ��� �Ŵ����� ���� �����ϴ� ���
    {
        get { return m_Menu; }
        private set { m_Menu = value; }
    }
    public UIStatus status
    {
        get { return m_Status; }
        private set { m_Status = value; }
    }

    public UIInventory inventory
    {
        get { return m_Inventory; }
        private set { m_Inventory = value; }
    }

    public static UIManager Instance { get; private set; }


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void ShowUI(GameObject uiObject)
    {
        if (uiObject == null) return;
        uiObject.SetActive(true);
       
    }

    public void Back()
    {
        status.gameObject.SetActive(false);
        inventory.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true); // ���� �޴��� ���ư�
    }
}
