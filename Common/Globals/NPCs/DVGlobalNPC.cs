using DVMod.Content.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace DVMod.Common.Globals.NPCs
{
    public class DVGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;

        // Buffs
        public bool eCurse = false;
        public int eCurseDMG = Main.expertMode ? 16 : 32;

        public override GlobalNPC Clone(NPC npc, NPC npcClone)
        {
            DVGlobalNPC myClone = (DVGlobalNPC)Clone(npc, npcClone);

            myClone.eCurse = eCurse;
            myClone.eCurseDMG = eCurseDMG;

            return myClone;
        }

        public override void ResetEffects(NPC npc)
        {
            eCurse = false;
        }

        public override void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (eCurse)
            {
                if (Main.rand.Next(4) < 3)
                {
                    int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, ModContent.DustType<EtherealCurseDust>(), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 1f);
                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].velocity *= 1.8f;
                    Main.dust[dust].velocity.Y -= 0.5f;

                    if (Main.rand.NextBool(4))
                        Main.dust[dust].noGravity = false;
                }
            }
        }

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (eCurse)
            {
                npc.lifeRegen -= eCurseDMG;

                if (npc.lifeRegen > 0)
                    npc.lifeRegen = 0;

                if (damage < 2)
                    damage = 2;
            }
        }
    }
}