using System.Text.Json.Serialization;

namespace D365XMLExplorer;
public class CurrentOnHand
{
    [JsonPropertyName("_Qty")]
    public string Qty { get; set; }

    [JsonPropertyName("_UnitId")]
    public string UnitId { get; set; }
}

public class ItemNode
{
    [JsonPropertyName("ItemNode")]
    public List<ItemNode> ItemNodes { get; set; }

    [JsonPropertyName("_Item")]
    public string Item { get; set; }

    [JsonPropertyName("_Category")]
    public string Category { get; set; }

    [JsonPropertyName("_Reference")]
    public string Reference { get; set; }

    [JsonPropertyName("_Qty")]
    public string Qty { get; set; }

    [JsonPropertyName("_UnitId")]
    public string UnitId { get; set; }

    [JsonPropertyName("_Date")]
    public string Date { get; set; }

    [JsonPropertyName("_InventSizeId")]
    public string InventSizeId { get; set; }

    [JsonPropertyName("_InventStyleId")]
    public string InventStyleId { get; set; }

    [JsonPropertyName("_InventSiteId")]
    public string InventSiteId { get; set; }

    [JsonPropertyName("_InventLocationId")]
    public string InventLocationId { get; set; }

    [JsonPropertyName("_wMSLocationId")]
    public string WMSLocationId { get; set; }

    [JsonPropertyName("_InventStatusId")]
    public string InventStatusId { get; set; }

    [JsonPropertyName("_inventBatchId")]
    public string InventBatchId { get; set; }

    [JsonPropertyName("_PickedOnly")]
    public string PickedOnly { get; set; }

    [JsonPropertyName("_AlreadyIncluded")]
    public string AlreadyIncluded { get; set; }
}

public class Base
{
    [JsonPropertyName("Trace")]
    public Trace Trace { get; set; }
}

public class Trace
{
    [JsonPropertyName("TraceCriteria")]
    public TraceCriteria TraceCriteria { get; set; }

    [JsonPropertyName("CurrentOnHand")]
    public CurrentOnHand CurrentOnHand { get; set; }

    [JsonPropertyName("TraceHierarchy")]
    public TraceHierarchy TraceHierarchy { get; set; }
}

public class TraceCriteria
{
    [JsonPropertyName("_Direction")]
    public string Direction { get; set; }

    [JsonPropertyName("_ItemId")]
    public string ItemId { get; set; }

    [JsonPropertyName("_inventBatchId")]
    public string InventBatchId { get; set; }
}

public class TraceHierarchy
{
    [JsonPropertyName("ItemNode")]
    public List<ItemNode> ItemNode { get; set; }
}
