using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MArcMod.Projectiles
{
    public class Gunp : ModProjectile
    {

        public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("a"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			DisplayName.SetDefault("Bullet");
		}
        public override void SetDefaults()
        {
            Projectile.width = 8; // The width of projectile hitbox
			Projectile.height = 8; // The height of projectile hitbox
			Projectile.aiStyle = 1; // The ai style of the projectile, please reference the source code of Terraria
			Projectile.friendly = true; // Can the projectile deal damage to enemies?
			Projectile.hostile = false; // Can the projectile deal damage to the player?
			Projectile.DamageType = DamageClass.Ranged; // Is the projectile shoot by a ranged weapon?
			Projectile.penetrate = 5; // How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
			Projectile.timeLeft = 600; // The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			Projectile.alpha = 255; // The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in) Make sure to delete this if you aren't using an aiStyle that fades in. You'll wonder why your projectile is invisible.
			Projectile.light = 0.5f; // How much light emit around the projectile
			Projectile.ignoreWater = true; // Does the projectile's speed be influenced by water?
			Projectile.tileCollide = true; // Can the projectile collide with tiles?
			Projectile.extraUpdates = 1; // Set to above 0 if you want the projectile to update multiple time in a frame

			AIType = ProjectileID.Bullet; // Act exactly like default Bullet
        }

        public override void AI()
        {
            // Add custom AI behavior for the projectile here
            // For example, you could make the projectile move in a specific pattern or follow a target
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            // Add custom code to be executed when the projectile hits an NPC here
            // For example, you could apply debuffs or inflict additional damage to the target
        }

        public override void Kill(int timeLeft)
        {
            // Add custom code to be executed when the projectile is destroyed here
            // For example, you could create a explosion or spawn additional projectiles
        }
    }
}
