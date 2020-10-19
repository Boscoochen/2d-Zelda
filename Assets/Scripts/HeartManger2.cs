using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartManger2 : MonoBehaviour
{
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite halfFullHeart;
    public Sprite emptyHeart;
    public FloatValue2 heartContainers;
    public FloatValue2 playerCurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        InitHearts();
    }

    public void InitHearts()
    {
        for (int i = 0; i < heartContainers.initialValue; i++)
        {
            hearts[i].gameObject.SetActive(true);
            hearts[i].sprite = fullHeart;
        }
    }

    public void UpdateHearts()
    {
        float tempHealth = playerCurrentHealth.initialValue / 2;
        for(int i = 0; i < heartContainers.initialValue; i++)
        {
            if(i <= tempHealth-1)
            {
                //full heart
                hearts[i].sprite = fullHeart;
            }else if(i >= tempHealth)
            {
                //empty
                hearts[i].sprite = emptyHeart;
            }
            else
            {
                //half
                hearts[i].sprite = halfFullHeart;
            }
        }
    }
}
