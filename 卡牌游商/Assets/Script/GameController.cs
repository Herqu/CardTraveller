using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{


    public Enemy enemy;

    public Self self;

    /// <summary>
    /// 由UI调用。self对Enemy的作用。
    /// </summary>
    public void SelfAction(CardType cardType)
    {
        switch (cardType)
        {
            case CardType.Attack:
                enemy.Injured(ActionType.PhysicalAttack,self.m_damage);
                break;
            case CardType.Defence:
                self.AddDefence();
                break;
            case CardType.Blank:
                Debug.Log("空白形式的");
                break;
            default:
                Debug.Log("无。");
                break;
        }
    }

    /// <summary>
    /// 由Enemy调用。对self进行作用。
    /// </summary>
    public void EnemyAction()
    {
        
    }












    public void Update()
    {
        GameUpdate();
    }
    /// <summary>
    /// enmey和self的检查。看看游戏逻辑下一步怎么走。
    /// </summary>
    public void GameUpdate()
    {
        Debug.Log("程序正在运行，没有检测胜负的逻辑。");
    }
}



public enum ActionType
{
    PhysicalAttack,
    MagicalAttack,
}

