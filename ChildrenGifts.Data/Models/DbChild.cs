using ChildrenGifts.Data.Enums;

namespace ChildrenGifts.Data.Models;

public record DbChild
{
    public const bool MaleSex = false;
    public const bool FemaleSex = true;
    public required int Id { get; set; }
    public required string Organization { get; set; }
    public required string ParentFullName { get; set; }
    public required string ChildFullName { get; set; }
    public required bool Sex { get; set; }
    public required ChildType Type { get; set; }
    public required DateOnly DateOfBirth { get; set; }
    public required int FormDate { get; set; }
}