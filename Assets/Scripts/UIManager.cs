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
    private GameObject previousUI; // ���� UI ����

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
        if (uiObject== null) return;

        if (previousUI != null)
            previousUI.SetActive(false); // ���� UI �ݱ�

        uiObject.SetActive(true);
        previousUI = uiObject; // ���� UI�� ����
    }

    public void Back()
    {
        if (previousUI != null)
        {
            previousUI.SetActive(false);
            previousUI = null;
        }

        mainMenu.gameObject.SetActive(true); // ���� �޴��� ���ư�
    }
}
