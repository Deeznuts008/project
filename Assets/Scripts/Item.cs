using Cainos.PixelArtTopDown_Basic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item
{
    public enum ItemType
    {
        Sword,
        HealthPotion,
        ManaPotion,
        Coin,
        Medikit,
    }
    public ItemType itemType;
    public int amount;


    public Sprite getSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Sword:  return ItemAssets.Instance.swordSprite;
            case ItemType.Health: return ItemAssets.Instance.healthSprite;
            case ItemType.Mana:   return ItemAssets.Instance.manaSprite;
            case ItemType.Coin:   return ItemAssets.Instance.coinSprite;
        }
    }
}

