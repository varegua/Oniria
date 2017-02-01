using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class ItemsDatabase : MonoBehaviour
{
    public List<Item> ItemDatabase = new List<Item>();

    private string path = "E:\\Game Project\\Oniria\\Assets\\Database\\Item.xml";

	// Use this for initialization
	void Start ()
    {
        var serializer = new XmlSerializer(typeof(Item), new XmlRootAttribute("ItemsCollection"));
        var stream = new FileStream(path, FileMode.Open);
        List<Item> container = new List<Item>();
        //XmlReader reader = XmlReader.Create(stream);
        //var container = serializer.Deserialize(reader) as Item[];
        using (var reader = XmlReader.Create(stream))
        {
            container.Add((Item)serializer.Deserialize(reader));
        }
        Console.WriteLine(container.ToString());
        stream.Close();
    }

    private void LoadXml()
    {
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
