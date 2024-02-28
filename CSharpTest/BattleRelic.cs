using System.Collections.Generic;
using System.Linq;

public class BattleRelic
{
    public int BattleRelicId { get; set; }
    public int Level { get; set; }
    public int MainAffixId { get; set; }
    public List<RelicAffix> subAffixes { get; set; } = new List<RelicAffix>();
}

public class BattleRelicList : List<BattleRelic>
{
    public BattleRelic GetByMainAffixId(int id)
    {
        return this.FirstOrDefault(x => x.MainAffixId == id);
    }
}

public partial class RelicAffix
{
    public uint AffixId { get; set; }
    public uint Cnt { get; set; }
    public uint Step { get; set; }
}
