using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name { get; private set; } // 프로퍼티를 선언
    public string Description { get; private set; }
    public int Level {  get; private set; }
    public int Exp { get; private set; }

    public int Def { get; private set; }

    public int Hp {  get; private set; }

    public int Gold {  get; private set; }

    //생성자 만들기, 생성자를 만들어줄 필요는 없다 왜냐하면, Monobehaviour를 상속받는 이상, 생성자를 만들 수 없다구리
    public Character (string name, string description, int level, int exp, int def, int hp, int gold)
    {
        Name = name;
        Description = description;
        Level = level;
        Exp = exp;
        Def = def;
        Hp = hp;
        Gold = gold;
    }
}
