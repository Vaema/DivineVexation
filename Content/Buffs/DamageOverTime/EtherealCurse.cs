using Terraria;
using Terraria.ModLoader;

namespace DVMod.Content.Buffs.DamageOverTime
{
    public class EtherealCurse : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.DV().eCurse = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.DV().eCurse = true;
        }
    }
}