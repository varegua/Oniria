using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Assets;

[XmlRoot("ItemsCollection")]
public class ItemsDatabase
{
    [XmlArray("Items")]
    [XmlArrayItem("Item")]
    public List<Item> ItemList = new List<Item>();

    // Use this for initialization
    void Start ()
    {
    }

    public static ItemsDatabase Load(string path)
    {
        var xml = File.ReadAllText(path);
        XmlSerializer serializer = new XmlSerializer(typeof(ItemsDatabase));
        StringReader reader = new StringReader(xml);
        ItemsDatabase items = serializer.Deserialize(reader) as ItemsDatabase;
        reader.Close();
        return items;
    }

    public List<string> GetAllItems()
    {
        //List<string> Items = new List<string>();
        //foreach (var item in ItemDatabase)
        //{
        //    Items.Add(item.getAttributes());
        //}
        //return Items;
        return new List<string>();
    }
}
