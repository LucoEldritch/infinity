using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.ModSupport.Calamity.Items.Throwables
{
	public class EndlessCalamityToothBall : ModItem
	{
        Mod otherMod = ModLoader.GetMod("CalamityMod");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Tooth Ball");
        }

        public override void SetDefaults()
        {
            if (otherMod != null)
            {
                item.CloneDefaults(otherMod.ItemType("ToothBall"));
                item.consumable = false;               
                item.maxStack = 1;
            }
        }

		public override void AddRecipes()
		{
            if (otherMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(otherMod.ItemType("ToothBall"), 396);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}