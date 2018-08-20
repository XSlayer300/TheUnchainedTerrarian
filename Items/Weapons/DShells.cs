using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheUnchainedTerrarian.Items.Weapons
{
	public class DShells : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shell Ammo");
			Tooltip.SetDefault("Standard shells for shotguns");
		}

		public override void SetDefaults()
		{
			item.damage = 9;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = Item.sellPrice(0, 0, 1, 0);
			item.rare = 8;
			item.shoot = mod.ProjectileType("DBullets");
			item.shootSpeed = 16f;
			item.ammo = item.type; // The first item in an ammo class sets the AmmoID to it's type
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
