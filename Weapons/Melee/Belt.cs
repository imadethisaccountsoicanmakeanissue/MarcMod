using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MArcMod.Weapons.Melee
{
	public class Belt : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("a"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Sends your foes to space with a whacking!");
		}

		public override void SetDefaults()
		{
			Item.damage = 10300;
			Item.DamageType = DamageClass.Melee;
			Item.width = 26;
			Item.height = 20;
			Item.useTime = 2;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 60000;
			Item.value = 10000;
			Item.rare = 4;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 140);
			recipe.AddIngredient(ItemID.MythrilBar, 140);
			recipe.AddIngredient(ItemID.SilverBar, 140);
			recipe.AddIngredient(ItemID.AdamantiteBar, 140);
			recipe.AddIngredient(ItemID.CobaltBar, 140);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
}