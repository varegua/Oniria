using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    private const int MAX_SLOT_INVENTORY = 48;
    private List<GameObject> ItemSlotList;

    public GameObject itemSlot;
    public ItemsDatabase ItemsDatabase;
    public Dictionary<Item, int> InveDictionary;

	// Use this for initialization
	void Start () {
	    for (int i = 0; i < MAX_SLOT_INVENTORY; i++)
	    {
            itemSlot = new GameObject();
            ItemSlotList = new List<GameObject>();
            InveDictionary = new Dictionary<Item, int>();

            var slot = Instantiate(itemSlot);
            slot.transform.SetParent(this.transform);
            if(slot) ItemSlotList.Add(slot);
            else Console.WriteLine("INVENTORY> Slot null");
	    }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void insertInInventory(Item item)
    {
    }
}
