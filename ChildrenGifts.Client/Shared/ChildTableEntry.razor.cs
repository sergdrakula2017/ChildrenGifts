using ChildrenGifts.Data.Models;
using Microsoft.AspNetCore.Components;

namespace ChildrenGifts.Client.Shared;

public partial class ChildTableEntry : ComponentBase
{
    [Parameter]
    public DbChild Child { get; set; } = null!;
}