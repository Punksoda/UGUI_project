using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            return _instance;
        }
    }
    public Sprite swordIcon;
    public TMP_Text playerNameText;
    public TMP_Text playerDescriptionText;
    public TMP_Text playerGoldText;
    public TMP_Text playerLevelText;
    public TMP_Text playerExpText;
    public TMP_Text playerCritText;
    public TMP_Text playerHealthText;
    public TMP_Text playerAttackText;
    public TMP_Text playerDefenseText;
    public Character PlayerCharacter { get; private set; }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("GameManager initialized.");
            // 플레이어 캐릭터 생성
            PlayerCharacter = new Character("Groove", "Basic adventurer", 5, 10, 10, 100, 150, 0, 5, new List<Item>());

            // 아이템 생성 및 인벤토리에 추가, 예시 아이템 임시로 미리 추가
            Item fireSword = new Item("Fire Sword", "A sword imbued with fire", 100, 50, 10, swordIcon);
            PlayerCharacter.AddItem(fireSword);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetData()
    {
        Character player = PlayerCharacter;

        playerNameText.text = $"{player.Name}";
        playerDescriptionText.text = $"{player.Description}";
        playerLevelText.text = $"{player.Level}";
        playerGoldText.text = $"{player.Gold}G";
        playerExpText.text = $"{player.Exp} / 150 ";
        playerHealthText.text = $"{player.Hp}";

        // 기본 스탯
        int totalCrit = player.Crit;
        int totalDefense = player.Def;
        int totalAttack = player.Atk;

        Debug.Log($"{player.Name}의 기본 스탯: Atk: {totalAttack}, Def: {totalDefense}, Crit: {totalCrit}");

        // 장착된 아이템의 효과 반영
        foreach (Item item in player.E_Item)
        {
            if (item != null)
            {
                totalCrit += item.itemCritical;
                totalDefense += item.itemDeffense;
                totalAttack += item.itemAttack;
            }
            else
            {
                Debug.LogError("장착된 아이템 중 null이 있습니다!");
            }
        }

        Debug.Log($"최종 스탯 계산 완료: Atk: {totalAttack}, Def: {totalDefense}, Crit: {totalCrit}");

        // UI 업데이트
        playerCritText.text = $"{totalCrit}";
        playerDefenseText.text = $"{totalDefense}";
        playerAttackText.text = $"{totalAttack}";
    }
}
