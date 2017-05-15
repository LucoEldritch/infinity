using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infinity.Items.Ammo
{
	public class EndlessIchorDart : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Infinite Ichor Dart";
			item.damage = 10;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.toolTip = "Bingo bango bongo!";
			item.consumable = false;
			item.knockBack = 2.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.IchorDart;
			item.shootSpeed = 3f;
			item.ammo = AmmoID.Dart;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IchorDart, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}