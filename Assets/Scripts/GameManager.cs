using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public Character PlayerCharacter {  get; private set; }

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
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
            PlayerCharacter = new Character("Groove", "Demolish enemy with Great Fire Sworld", 12, 50, 30, 150, 999999, 100, 45);
        }

        else
        {
            if(_instance != null)
            {
                Destroy(gameObject);
            }
        }
    }
}
