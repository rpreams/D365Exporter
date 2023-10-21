using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace D365Exporter;

// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(Trace));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Trace)serializer.Deserialize(reader);
// }

[XmlRoot(ElementName = "TraceCriteria")]
public class TraceCriteria
{

    [XmlAttribute(AttributeName = "Direction")]
    public string Direction { get; set; }

    [XmlAttribute(AttributeName = "ItemId")]
    public string ItemId { get; set; }

    [XmlAttribute(AttributeName = "inventBatchId")]
    public int InventBatchId { get; set; }
}

[XmlRoot(ElementName = "CurrentOnHand")]
public class CurrentOnHand
{

    [XmlAttribute(AttributeName = "Qty")]
    public double Qty { get; set; }

    [XmlAttribute(AttributeName = "UnitId")]
    public string UnitId { get; set; }
}

[XmlRoot(ElementName = "ItemNode")]
public class ItemNode
{

    [XmlElement(ElementName = "ItemNode")]
    public List<ItemNode> ChildItemNode { get; set; }

    [XmlAttribute(AttributeName = "Item")]
    public string Item { get; set; }

    [XmlAttribute(AttributeName = "Category")]
    public string Category { get; set; }

    [XmlAttribute(AttributeName = "Reference")]
    public string Reference { get; set; }

    [XmlAttribute(AttributeName = "Qty")]
    public double Qty { get; set; }

    [XmlAttribute(AttributeName = "UnitId")]
    public string UnitId { get; set; }

    [XmlAttribute(AttributeName = "Date")]
    public DateTime Date { get; set; }

    [XmlAttribute(AttributeName = "InventSizeId")]
    public string InventSizeId { get; set; }

    [XmlAttribute(AttributeName = "InventStyleId")]
    public string InventStyleId { get; set; }

    [XmlAttribute(AttributeName = "InventSiteId")]
    public string InventSiteId { get; set; }

    [XmlAttribute(AttributeName = "InventLocationId")]
    public string InventLocationId { get; set; }

    [XmlAttribute(AttributeName = "wMSLocationId")]
    public string WMSLocationId { get; set; }

    [XmlAttribute(AttributeName = "InventStatusId")]
    public string InventStatusId { get; set; }

    [XmlAttribute(AttributeName = "inventBatchId")]
    public int InventBatchId { get; set; }

    [XmlAttribute(AttributeName = "AlreadyIncluded")]
    public int AlreadyIncluded { get; set; }

    [XmlAttribute(AttributeName = "PickedOnly")]
    public int PickedOnly { get; set; }

    [XmlAttribute(AttributeName = "InventColorId")]
    public int InventColorId { get; set; }
}

[XmlRoot(ElementName = "TraceHierarchy")]
public class TraceHierarchy
{

    [XmlElement(ElementName = "ItemNode")]
    public List<ItemNode> ItemNode { get; set; }
}

[XmlRoot(ElementName = "Trace")]
public class Trace
{

    [XmlElement(ElementName = "TraceCriteria")]
    public TraceCriteria TraceCriteria { get; set; }

    [XmlElement(ElementName = "CurrentOnHand")]
    public CurrentOnHand CurrentOnHand { get; set; }

    [XmlElement(ElementName = "TraceHierarchy")]
    public TraceHierarchy TraceHierarchy { get; set; }
}

