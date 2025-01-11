using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI CoinText, OrbText;
    public Image[] Items;
    public static GameManager gameManager;
    public int Orbs = 0, Coins = 0;
    private void Awake()
    {
        if (GameManager.gameManager != null && GameManager.gameManager != this)
            Destroy(gameObject);
        else
        {
            GameManager.gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void OrbCollected(int amount)
    {
        Orbs+= amount;
        OrbText.text = "Orbs: " + Orbs;
    }

    public void CoinCollected(int i)
    {
        Coins+= i;
        CoinText.text = "Coins: " + Coins;
    }
    public void ItemCollected(Sprite sprite, int id)
    {
        Items[id].sprite = sprite;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
