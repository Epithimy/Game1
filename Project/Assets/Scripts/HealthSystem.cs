using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    // Start is called before the first frame update
   public int Health;
   public int hearthAmount;
   
   public Image[] hearts;
   public Sprite FullHeart;
   public Sprite EmptyHeart;

   void Update() 
   {

    if (Health > hearthAmount)
    {
        Health = hearthAmount;
    }
    
    for (int i = 0; i < hearts.Length; i++)
    {
        if (i < Health) {
            hearts[i].sprite = FullHeart;
        } else
        {
            hearts[i].sprite = EmptyHeart;
        }
        
        if (i < hearthAmount) 
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
    }
   }
}
