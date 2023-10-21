using System.Text;
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
    public string InventBatchId { get; set; }

    public string DisplayText
    {
        get => $"{ItemId} - {InventBatchId}";
    }
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

    public bool HasChildren
    {
        get => ChildItemNode != null && ChildItemNode.Any();
    }

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
    public string InventBatchId { get; set; }

    [XmlAttribute(AttributeName = "AlreadyIncluded")]
    public string AlreadyIncluded { get; set; }

    [XmlAttribute(AttributeName = "PickedOnly")]
    public int PickedOnly { get; set; }

    [XmlAttribute(AttributeName = "InventColorId")]
    public string InventColorId { get; set; }

    public string DisplayLabel
    {
        get
        {
            var sb = new StringBuilder($"{Item} * {Category} {Reference} * {Date.ToString("d")} * {Math.Round(Qty, 0)}{UnitId}");
            if (!string.IsNullOrWhiteSpace(InventColorId))
                sb.Append($"Color={InventColorId}");
            if (!string.IsNullOrWhiteSpace(InventStyleId))
                sb.Append($" * Style={InventStyleId}");
            if (!string.IsNullOrWhiteSpace(InventSizeId))
                sb.Append($" * Size={InventSizeId}");
            if (!string.IsNullOrWhiteSpace(InventSiteId))
                sb.Append($" * Site={InventSiteId}");
            sb.Append($" * Warehouse={InventLocationId},Location={WMSLocationId},Inventory Status={InventStatusId},Batch Number={InventBatchId}");


            return sb.ToString();
        }
    }
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

