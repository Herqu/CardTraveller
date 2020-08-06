using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardButton : MonoBehaviour
{
    public CardType m_cardType;

    public void OnButtonDown()
    {
        this.GetComponentInParent<UIController>().CallByCardButton(m_cardType);

    }
}
