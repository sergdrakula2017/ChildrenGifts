using ChildrenGifts.Data;
using Microsoft.AspNetCore.Components;

namespace ChildrenGifts.Client.Pages;

public partial class Index : ComponentBase
{
    [Inject]
    public ChildContext ChildContext { get; set; } = null!;
}