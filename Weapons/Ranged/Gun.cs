using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace MArcMod.Weapons.Ranged
{
	public class Gun : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("a"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shoot the slime!");
		}

		public override void SetDefaults()
        {
            Item.damage = 800; // Set the damage of the gun
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40; // Set the width of the hitbox for the Item
            Item.height = 20; // Set the height of the hitbox for the Item
            Item.useTime = 20; // Set the time it takes to use the gun
            Item.useAnimation = 20; // Set the animation time for using the gun
            Item.useStyle = ItemUseStyleID.HoldUp; // Set the use style of the gun
            Item.noMelee = true; // Set the gun to not be a melee weapon
            Item.value = 1000; // Set the value of the gun
            Item.rare = ItemRarityID.Green; // Set the rarity of the gun
            Item.UseSound = SoundID.Item11; // Set the sound that plays when the gun is used
            Item.autoReuse = true; // Set the gun to automatically fire when the button is held down
            Item.shoot = ProjectileID.Bullet; // Set the type of projectile the gun fires
            Item.shootSpeed = 50f; // Set the speed at which the projectile is fired
            Item.useAmmo = ModContent.ItemType<Items.Gunpi>(); // Set the type of ammo the gun uses
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			return true; // return false to stop vanilla from calling Projectile.NewProjectile.
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.HellstoneBar, 30);
			recipe.AddIngredient(ItemID.MythrilBar, 90);
			recipe.AddIngredient(ItemID.AdamantiteBar, 90);
			recipe.AddIngredient(ItemID.SilverBar, 80);
			recipe.AddIngredient(ItemID.CopperBar, 80);
			recipe.AddTile(TileID.DemonAltar);
			recipe.Register();
		}
	}
}