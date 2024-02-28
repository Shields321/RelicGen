using System.Collections.Generic;
using System.Linq;

public class BattleRelic
{
    public int BattleRelicId { get; set; }
    public int Level { get; set; }
    public int MainAffixId { get; set; }
    public List<RelicAffix> SubAffixes { get; set; } = new List<RelicAffix>();

    public override string ToString()
    {
        // Create a string representation of the BattleRelic object including SubAffixes
        string subAffixesString = string.Join(", ", SubAffixes.Select(affix => affix.ToString()));
        return $"BattleRelicId: {BattleRelicId}, Level: {Level}, MainAffixId: {MainAffixId}, SubAffixes: [{subAffixesString}]";
    }
}

public partial class RelicAffix
{
    public uint AffixId { get; set; }
    public uint Cnt { get; set; }
    public uint Step { get; set; }

    public override string ToString()
    {
        // Create a string representation of the RelicAffix object
        return $"AffixId: {AffixId}, Cnt: {Cnt}, Step: {Step}";
    }
}
