using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Throwables
{
	public class EndlessDyna : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Endless Dynamite";
			item.damage = 250;
			item.thrown = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 39;
			item.useAnimation = 39;
			item.useStyle = 1;
			item.maxStack = 1;
			item.toolTip = "A large explosion that will destroy most tiles.";
			item.consumable = false;
			item.knockBack = 8f;
			item.value = 10;
			item.rare = 4;
			item.shoot = 29;
			item.shootSpeed = 4f;
			item.noMelee = true; //Makes it so it cannot do damage like a sword
			item.noUseGraphic = true; //Makes it so the item can't be seen in hand when used.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Dynamite, 199);
			recipe.AddTile(125);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}