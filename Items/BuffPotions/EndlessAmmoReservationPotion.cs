using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.BuffPotions
{
	public class EndlessAmmoReservationPotion : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Bottomless Ammo Reservation Potion";
			item.width = 14;
			item.height = 24;
            item.useStyle = 2;
            item.useTime = 17;
            item.useAnimation = 17;
            item.UseSound = SoundID.Item3;
            item.buffType = BuffID.AmmoReservation;
            item.buffTime = 216000;
            item.toolTip = "Infinitely provides Ammo Reservation";
			item.value = 25000;
			item.rare = 2;
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AmmoReservationPotion, 30);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}