using ChildrenGifts.Client.Properties;
using ChildrenGifts.Data.Enums;
using ChildrenGifts.Data.Models;

namespace ChildrenGifts.Client;

public static class LocalizationExtensions
{
    public static string GetChildStatus(this DbChild child) => child.Type switch
    {
        ChildType.Grandchild when child.Sex == DbChild.MaleSex => Resources.Grandson,
        ChildType.Grandchild when child.Sex == DbChild.FemaleSex => Resources.Granddaughter,
        _ when child.Sex == DbChild.MaleSex => Resources.Son,
        _ when child.Sex == DbChild.FemaleSex => Resources.Daughter,
        _ => Resources.Child
    };

    public static string GetTypeName(this ChildType childType) => childType switch
    {
        ChildType.ChildUnder14 => Resources.ChildType_ChildUnder14,
        ChildType.ChildOver14 => Resources.ChildType_ChildOver14,
        ChildType.Grandchild => Resources.ChildType_Grandchild,
        _ => "?"
    };
}