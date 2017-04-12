using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private string ItemDataBasePath = Utils.DataBasePath + "Item.xml";

    private const int MAX_SLOT_INVENTORY = 48;
    private List<GameObject> ItemSlotList;

    private static IMG2Sprite img2Sprite;
    public GameObject itemSlot;
    public ItemsDatabase _ItemsDatabase;
    public Dictionary<Item, int> InveDictionary;

	// Use this for initialization
	void Start ()
    {
        img2Sprite = IMG2Sprite.instance;
        LoadInventoryAndDataBase();
    }

    private void LoadInventoryAndDataBase()
    {
        _ItemsDatabase = ItemsDatabase.Load(ItemDataBasePath);
        ItemSlotList = new List<GameObject>();
        InveDictionary = new Dictionary<Item, int>();
        for (int i = 0; i < MAX_SLOT_INVENTORY; i++)
        {
            var slot = Instantiate(itemSlot);
            slot.name = "ItemSlot" + i;
            slot.transform.SetParent(this.transform);
            ItemSlotList.Add(slot);
        }
        foreach (Item item in _ItemsDatabase.ItemList)
        {
            print(item);
            insertInInventory(item);
        }

    }

    // Update is called once per frame
	void Update () {
	
	}

    private void OnMouseOver()
    {
        
    }

    void insertInInventory(Item item)
    {
        if (item != null)
        {
            foreach (GameObject slot in ItemSlotList)
            {
                ItemSlot itemslot = slot.GetComponent<ItemSlot>();
                if (itemslot.itemInSlot == null || string.IsNullOrEmpty(itemslot.itemInSlot.ItemName))
                {
                    itemslot.itemInSlot = item;
                    Image image = itemslot.GetComponent<Image>();
                    image.sprite = img2Sprite.LoadNewSprite(Utils.ImagePath + item.ItemIcon);
                    return;
                }
            }
        }
    }
}
