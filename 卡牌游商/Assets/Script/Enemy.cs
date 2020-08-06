using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string name;
    public EnemyState m_state;
    public EnemyState m_nextState;
    public int m_bloodNum;
    public int m_damage;

    public void Injured(ActionType actionType,int damage)
    {
        Debug.Log("敌人受伤啦。");
        switch (actionType)
        {
            case ActionType.MagicalAttack:
                break;
            case ActionType.PhysicalAttack:
                m_bloodNum -= damage;
                Debug.Log("是物理攻击啊！！！！");
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 敌人内部循环，控制状态。控制生死。向上面传送信息。
    /// </summary>
    private void Update()
    {
        
    }
}

public enum EnemyState
{
    Calm,
    Vigilance,
    Attack,
    Defence,
    Dizzy
}
