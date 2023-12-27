using DVMod.Common.Globals.NPCs;
using DVMod.Common.Globals.Players;
using Terraria;

namespace DVMod
{
    public static partial class DVUtils
    {
        public static DVPlayer DV(this Player player) => player.GetModPlayer<DVPlayer>();

        public static DVGlobalNPC DV(this NPC npc) => npc.GetGlobalNPC<DVGlobalNPC>();
    }
}