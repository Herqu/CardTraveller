using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Self : MonoBehaviour
{
    public List<SelfCard> m_cards = new List<SelfCard>();
    public int m_damage;
    public int m_bloodNum;

    public void AddDefence()
    {
        Debug.Log("角色转变为抵抗状态。但是我还没有在代码上实现。");
    }
}


/// <summary>
/// 用来做卡牌的。
/// </summary>
[CreateAssetMenu(fileName ="Card",menuName ="SelfCard")]
public class SelfCard : ScriptableObject
{
    //名称，cd时间。已经响应效果。
    public string name;
    public CardType cardType;
    public float cDtime;
    public Sprite image;

    public void Play()
    {
        ;
    }
}



public enum CardType
{
    Attack,
    Defence,
    Blank,
}


