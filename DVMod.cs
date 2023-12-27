using Terraria.ModLoader;

namespace DVMod
{
	public class DVMod : Mod
	{
		internal static DVMod Instance;

        public override void Load()
        {
            Instance = this;
        }

        public override void Unload()
        {
            Instance = null;
        }
    }
}