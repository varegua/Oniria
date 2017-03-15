using System.Collections;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

public class Item
{
    [XmlAttribute("ItemName")]
    public string ItemName { get; set; }

    [XmlElement("ItemType")]
    public ItemTypes ItemType { get; set; }
    public enum ItemTypes
    {
        Consommable,
        Armure,
        Batiment
    }

    public Item()
    {
        
    }

    public Item(string name, ItemTypes type)
    {
        ItemName = name;
        ItemType = type;
    }

    public Item getAttributes()
    {
        return this;
    }

    public override string ToString()
    {
        return ItemName;
    }
}
 