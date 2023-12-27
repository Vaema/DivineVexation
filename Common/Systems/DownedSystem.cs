using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

// For ease of access, DownedSystem will not be using the Systems directory as its namespace.
namespace DVMod
{
    public class DownedSystem : ModSystem
    {
        // Bosses
        public static bool DownedHyperborea = false;

        // Minibosses
        // ...

        // Events
        // ...

        public override void SaveWorldData(TagCompound tag)
        {
            var downed = new List<string>();
            if (DownedHyperborea)
                downed.Add("hyperborea");

            tag.Add("downed", downed);
        }

        public override void LoadWorldData(TagCompound tag)
        {
            var downed = tag.GetList<string>("downed");
            DownedHyperborea = downed.Contains("hyperborea");
        }

        public override void NetSend(BinaryWriter writer)
        {
            // TO-DO: Add another parameter when there is another boss.
            BitsByte bosses = new(DownedHyperborea);
            writer.Write(bosses);
        }

        public override void NetReceive(BinaryReader reader)
        {
            BitsByte bosses = reader.ReadByte();
            DownedHyperborea = bosses[0];
        }

        public override void OnWorldLoad()
        {
            DownedHyperborea = false;
        }

        public override void OnWorldUnload()
        {
            DownedHyperborea = false;
        }
    }
}