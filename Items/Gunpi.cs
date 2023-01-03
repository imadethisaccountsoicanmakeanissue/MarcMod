using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MArcMod.Items
{
    public class Gunpi : ModItem
    {

        public override void SetStaticDefaults()
		{
		    DisplayName.SetDefault("Bullet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A Bullet for A Gun");
		}

        public override void SetDefaults() {
			Item.damage = 200; // The damage for projectiles isn't actually 12, it actually is the damage combined with the projectile and the item together.
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 999;
			Item.consumable = true; // This marks the item as consumable, making it automatically be consumed when it's used as ammunition, or something else, if possible.
			Item.knockBack = 1.5f;
			Item.value = 10;
			Item.rare = ItemRarityID.Green;
			Item.shoot = ModContent.ProjectileType<Projectiles.Gunp>(); // The projectile that weapons fire when using this item as ammunition.
			Item.shootSpeed = 16f; // The speed of the projectile.
			Item.ammo = ModContent.ItemType<Items.Gunpi>(); // The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(1);
			recipe.AddIngredient(ItemID.GoldCoin, 1);
			recipe.AddIngredient(ItemID.EmptyBullet, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
    }
}
