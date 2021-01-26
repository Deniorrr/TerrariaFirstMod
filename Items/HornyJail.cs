using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DeniorrsTest.Items
{
    public class HornyJail : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("ExampleSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("I do not wish to by horny anymore");
        }

        public override void SetDefaults()
        {
            item.damage = 55;
            item.melee = true;
            item.width = 48;
            item.height = 52;
            item.useTime = 10;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.healLife = 10;
            //item.mana = 10;
            item.knockBack = 10;
            item.value = 690000;
            item.rare = 2;
            item.UseSound = SoundID.Item37;
            item.autoReuse = true;
            //item.healLife = 5;
            item.shoot = mod.ProjectileType("FirstProjectile");
            item.shootSpeed = 14f;
            item.useAmmo = AmmoID.Gel;
            item.UseSound = SoundID.Item122;
        }

        // public override void GetHealLife(Player player, bool quickHeal, ref int healValue)
        // {
        //     // Make the item heal half the player's max health normally, or one fourth if used with quick heal
        //     //healValue = 5;
        // }
        //public override bool UseItem(Player player)
        //{
        //
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            //recipe.AddIngredient(ItemID.IceSickle, 1);
            recipe.AddIngredient(ItemID.Stinger, 5);
            recipe.AddIngredient(ItemID.JungleSpores, 5);
            recipe.AddIngredient(ItemID.HellstoneBar, 2);
            recipe.AddIngredient(ItemID.Obsidian, 10);
            recipe.AddIngredient(ItemID.NightsEdge, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}