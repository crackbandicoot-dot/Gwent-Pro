using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Image image;
    public TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateCard(Card card)
    {
      image.sprite = Resources.Load<Sprite>(card.Name);
      if (card is UnityCard unity && card is not DecoyCard) textMeshPro.text = ((int)unity.PowerPoints).ToString();
      else  textMeshPro.text = "";
      this.card = card;
    }
}
