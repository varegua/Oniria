using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    private string path = "E:\\Projet\\Oniria\\Assets\\Database\\Item.xml";

    private const int MAX_SLOT_INVENTORY = 48;
    private List<GameObject> ItemSlotList;

    public GameObject itemSlot;
    public ItemsDatabase _ItemsDatabase;
    public Dictionary<Item, int> InveDictionary;

	// Use this for initialization
	void Start ()
	{
	    LoadInventoryAndDataBase();
    }

    private void LoadInventoryAndDataBase()
    {
        _ItemsDatabase = ItemsDatabase.Load(path);
        foreach (Item item in _ItemsDatabase.ItemList)
        {
            print(item);
        }
        ItemSlotList = new List<GameObject>();
        InveDictionary = new Dictionary<Item, int>();
        for (int i = 0; i < MAX_SLOT_INVENTORY; i++)
        {
            var slot = Instantiate(itemSlot);
            slot.name = "ItemSlot" + i;
            slot.transform.SetParent(this.transform);
            ItemSlotList.Add(slot);
        }
    }

    // Update is called once per frame
	void Update () {
	
	}

    void insertInInventory(Item item)
    {
    }
}
