using ChildrenGifts.Data.Enums;

namespace ChildrenGifts.Data.Models;

public record DbChild
{
    public required int Id { get; set; }
    public required string ParentFullName { get; set; }
    public required string ChildFullName { get; set; }
    public required ChildType Type { get; set;}
    public required DateOnly DateOfBirth { get; set; }
    public required int FormDate { get; set; }

}