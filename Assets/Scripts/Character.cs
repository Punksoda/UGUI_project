using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name { get; private set; } // ������Ƽ�� ����
    public string Description { get; private set; }
    public int Level {  get; private set; }
    public int Exp { get; private set; }

    public int Def { get; private set; }

    public int Hp {  get; private set; }

    public int Gold {  get; private set; }

    //������ �����, �����ڸ� ������� �ʿ�� ���� �ֳ��ϸ�, Monobehaviour�� ��ӹ޴� �̻�, �����ڸ� ���� �� ���ٱ���
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
