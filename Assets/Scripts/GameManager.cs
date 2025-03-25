using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public Sprite swordIcon;
    public Character PlayerCharacter { get; private set; }

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);

            // �÷��̾� ĳ���� ����
            PlayerCharacter = new Character(
                "Groove", "A brave warrior", 1, 0, 5, 100, 50, 10, 20, new List<Item>()
            );

            // ������ ���� �� �κ��丮�� �߰�
            Item fireSword = new Item("Fire Sword", "A sword imbued with fire", 1, swordIcon);
            PlayerCharacter.AddItem(fireSword);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
