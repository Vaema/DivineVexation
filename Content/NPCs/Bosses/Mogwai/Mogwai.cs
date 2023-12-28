/*using System.IO;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;

namespace DVMod.Content.NPCs.Bosses.Mogwai
{
    public class Mogwai : ModNPC
    {
        private ref float Timer => ref NPC.ai[1];

        private Player Target => Main.player[NPC.target];

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = 8;
            NPCID.Sets.TrailCacheLength[Type] = 5;
            NPCID.Sets.TrailingMode[Type] = 0;
            NPCID.Sets.MPAllowedEnemies[Type] = true;
        }

        public override void SetDefaults()
        {
            NPC.width = 122;
            NPC.height = 132;
            NPC.scale = 1.2f;

            NPC.lifeMax = 3400;
            NPC.damage = 20;
            NPC.defense = 13;
            NPC.knockBackResist = 0f;
            NPC.npcSlots = 5f;

            NPC.aiStyle = -1;
            AIType = -1;

            NPC.boss = true;
            NPC.lavaImmune = true;
            NPC.noGravity = true;
            NPC.noTileCollide = true;
            NPC.netAlways = true;
            NPC.value = Item.buyPrice(0, 4);

            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            Music = MusicID.Boss1;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            
        }

        public override void SendExtraAI(BinaryWriter writer)
        {
            writer.Write(NPC.dontTakeDamage);
        }

        public override void ReceiveExtraAI(BinaryReader reader)
        {
            NPC.dontTakeDamage = reader.ReadBoolean();
        }

        public override void AI()
        {
            NPC.rotation = NPC.velocity.X * 0.05f;

            NPC.TargetClosest();
            if (!Target.active || Target.dead)
            {
                NPC.TargetClosest(false);
                NPC.velocity.Y -= 1.5f;
                Timer = 0f;
            }


        }

        public override void ApplyDifficultyAndPlayerScaling(int numPlayers, float balance, float bossAdjustment)
        {
            NPC.lifeMax = (int)(NPC.lifeMax * 0.85f * balance);
            NPC.damage = 32;
        }
    }
}
*/