using System.Runtime.Serialization;

namespace Elsa.Client.Models
{
    [DataContract]
    public class ActivityDescriptor
    {
        [DataMember(Order = 1)] public string Type { get; set; } = default!;
        [DataMember(Order = 2)] public string DisplayName { get; set; } = default!;
        [DataMember(Order = 3)] public string? Description { get; set; }
        [DataMember(Order = 4)] public string? RuntimeDescription { get; set; }
        [DataMember(Order = 5)] public string Category { get; set; } = default!;
        [DataMember(Order = 6)] public string? Icon { get; set; }
        [DataMember(Order = 7)] public string[] Outcomes { get; set; } = new string[0];
        [DataMember(Order = 8)] public ActivityPropertyDescriptor[] Properties { get; set; } = new ActivityPropertyDescriptor[0];
    }
}