using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour
{
    private void Start()
    {
        ReadCard();
        ReadEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        //ReadCard();
        //ReadEnemy();
    }






    public GameController m_controller;
    public GameObject cardSample;
    public Transform m_selfCardUI;
    /// <summary>
    /// 从gamecontroller中读取数据。然后实时改变ui变化。包括角色变化和其他变化。
    /// </summary>
    public void ReadCard()
    {

        for (int i = 0; i < m_selfCardUI.childCount; i++)
        {

            Destroy(m_selfCardUI.GetChild(i).gameObject);

        }

        foreach (SelfCard card in m_controller.self.m_cards)
        {
            Instantiate(cardSample, m_selfCardUI);
            cardSample.GetComponent<Image>().sprite = card.image;
            cardSample.GetComponentInChildren<Text>().text = card.name;
            cardSample.GetComponent<CardButton>().m_cardType = card.cardType;
        }
    }
    /// <summary>
    /// 这一个没有想好。我打算。啊，就是说。嗯，就是说。放一边。在update中刷新角色的现在cd值。
    /// </summary>
    public void RefreshCard()
    {

    }


    public GameObject m_enmeyUI;
    public List<Sprite> m_enmeyStateSprites = new List<Sprite>(); 
    /// <summary>
    /// 根据实际情况反应enmey的情况。现在暂时只做一个。
    /// </summary>
    public void ReadEnemy()
    {
        m_enmeyUI.GetComponentInChildren<Text>().text = m_controller.enemy.name;

        switch (m_controller.enemy.m_state)
        {
            case EnemyState.Attack:
                m_enmeyUI.transform.GetChild(1).GetComponent<Image>().sprite = m_enmeyStateSprites[0];
                break;
            case EnemyState.Defence:
                m_enmeyUI.transform.GetChild(1).GetComponent<Image>().sprite = m_enmeyStateSprites[1];

                break;
            default:
                m_enmeyUI.transform.GetChild(1).GetComponent<Image>().sprite = m_enmeyStateSprites[2];

                break;
        }
        switch (m_controller.enemy.m_nextState)
        {
            case EnemyState.Attack:
                m_enmeyUI.transform.GetChild(2).GetComponent<Image>().sprite = m_enmeyStateSprites[0];
                break;
            case EnemyState.Defence:
                m_enmeyUI.transform.GetChild(2).GetComponent<Image>().sprite = m_enmeyStateSprites[1];

                break;
            default:
                m_enmeyUI.transform.GetChild(2).GetComponent<Image>().sprite = m_enmeyStateSprites[2];

                break;
        }
    }




    public void CallByCardButton(CardType cardType)
    {
        m_controller.SelfAction(cardType);
    }

}
