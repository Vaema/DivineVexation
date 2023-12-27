using Microsoft.Xna.Framework;

namespace DVMod
{
    // Used for colors that will be often used without the need to remember
    // what the exact color is.
    public static partial class DVUtils
    {
        public static readonly Color DeveloperTooltip = Color.Lerp(new Color(110, 12, 88), new Color(194, 73, 167), 2);
        public static readonly Color DonorTooltip = new(181, 16, 73);

        public static readonly Color RarityVaema = Color.Lerp(new Color(82, 0, 76), Color.Black, 2);
        public static readonly Color RarityDonor = new(148, 29, 29);
    }
}