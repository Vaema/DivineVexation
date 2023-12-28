using DVMod.Content.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace DVMod.Common.Globals.Players
{
    public class DVPlayer : ModPlayer
    {
        // Buffs
        public bool eCurse = false;
        public int eCurseDMG = Main.expertMode ? 16 : 32;

        public override void ResetEffects()
        {
            eCurse = false;
        }

        public override void DrawEffects(PlayerDrawSet drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright)
        {
            if (eCurse)
            {
                if (Main.rand.Next(4) < 3 && !Player.dead)
                {
                    int dust = Dust.NewDust(drawInfo.Position - new Vector2(2f, 2f), Player.width + 4, Player.height + 4, ModContent.DustType<EtherealCurseDust>(), Player.velocity.X * 0.4f, Player.velocity.Y * 0.4f, 100, default, 1.5f);
                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].velocity *= 0.75f;
                    Main.dust[dust].velocity.Y -= 0.5f;

                    if (Main.rand.NextBool(4))
                        Main.dust[dust].noGravity = false;

                    drawInfo.DustCache.Add(dust);
                }
            }
        }

        public override void UpdateBadLifeRegen()
        {
            if (eCurse)
            {
                if (Player.lifeRegen > 0)
                    Player.lifeRegen = 0;

                Player.lifeRegen -= eCurseDMG;
            }
        }
    }
}