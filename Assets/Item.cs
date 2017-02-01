using System.Collections;
using System.Xml.Serialization;

public class Item
{
    public string ItemName { get; set; }

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
        //var itemAttributes = JsonConvert.SerializeObject(this);
        return this;
    }
}
 