using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace WheresMyRuin;

public class WheresMyRuinSettings : ISettings
{
    //Mandatory setting to allow enabling/disabling your plugin
    public ToggleNode Enable { get; set; } = new ToggleNode(false);
    public RangeNode<int> RuinCharges { get; set; } = new RangeNode<int>(4, 1, 7);
}