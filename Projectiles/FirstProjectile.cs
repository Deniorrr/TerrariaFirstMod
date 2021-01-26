using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DeniorrsTest.Projectiles
{
    public class FirstProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("First Projectile");
        }
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.HolyArrow);

            // projectile.arrow = true;
            projectile.width = 46;
            projectile.height = 22;
            // projectile.aiStyle = 1;
            // projectile.friendly = true;
            // projectile.ranged = true;
            // aiType = ProjectileID.WoodenArrowFriendly;

        }
        // public override void ModifyHitPlayer(Player target, ref int damage, ref bool crit)
        // {
        //     //target.AddBuff(BuffID.Wet, 240);
        //     target.AddBuff(BuffID.Inferno, 1000);
        //     //target.AddBuff(BuffID.BabySnowman, 240);
        // }
        // public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        // {
        //     target.AddBuff(BuffID.Inferno, 1000);
        // }

    }
}