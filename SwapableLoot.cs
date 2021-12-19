namespace SwapableLoot
{
	using System;
	using Terraria;
	using Terraria.ModLoader;

	public class SwapableLoot1 : Mod
	{
		public override void AddRecipes() 
		{
			//King Slime Treasure Bag
            Recipe recipe1 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(2585, 1);    //Creates Slime Hook using Slime Gun
			recipe1.AddIngredient(2610, 1);
			recipe1.AddTile(114);
			recipe1.Register();
            Recipe recipe2 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(2430, 1);    //Creates Slimy Saddle using Slime Hook
            recipe2.AddIngredient(2585, 1);
            recipe2.AddTile(114);
            recipe2.Register();
            Recipe recipe = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(2610, 1);    //Creates Slime gun using Slimy Saddle
            recipe.AddIngredient(2430, 1);
            recipe.AddTile(114);
            recipe.Register();
            //Bee Queen Treasure Bag
			Recipe recipe3 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1121, 1);	//Creates Bee Gun using Bee Keeper
			recipe3.AddIngredient(1123, 1);
			recipe3.AddTile(114);
			recipe3.Register();
            Recipe recipe4 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(2888, 1);    //Creates The Bee's Knees using Bee Gun
            recipe4.AddIngredient(1121, 1);
            recipe4.AddTile(114);
            recipe4.Register();
            Recipe recipe5 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1123, 1);    //Creates Bee Keeper using The Bee's Knees
            recipe5.AddIngredient(2888, 1);
            recipe5.AddTile(114);
            recipe5.Register();
            //Deerclops Treasure Bag
            Recipe recipe6 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(5098, 1);    //Creates Eye Bone using Eyebrella
            recipe6.AddIngredient(5101, 1);
            recipe6.AddTile(114);
            recipe6.Register();
            Recipe recipe7 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(5101, 1);    //Creates Eyebrella using Radio Thing
            recipe7.AddIngredient(5113, 1);
            recipe7.AddTile(114);
            recipe7.Register();
            Recipe recipe8 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(5113, 1);    //Creates Radio Think using Eye Bone
            recipe8.AddIngredient(5098, 1);
            recipe8.AddTile(114);
            recipe8.Register();
            Recipe recipe9 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(5117, 1);    //Creates Pew-matic Horn using Weather Pain
            recipe9.AddIngredient(5118, 1);
            recipe9.AddTile(114);
            recipe9.Register();
            Recipe recipe10 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(5118, 1);   //Creates Weather Pain using Houndius Shootius
            recipe10.AddIngredient(5119, 1);
            recipe10.AddTile(114);
            recipe10.Register();
            Recipe recipe11 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(5119, 1);   //Creates Houndius Shootius using Lucy the Axe
            recipe11.AddIngredient(5095, 1);
            recipe11.AddTile(114);
            recipe11.Register();
            Recipe recipe12 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(5095, 1);   //Creates Lucy the Axe using Pew-matic Horn
            recipe12.AddIngredient(5117, 1);
            recipe12.AddTile(114);
            recipe12.Register();
            //Wall of Flesh Treasure Bag
            Recipe recipe13 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(2998, 1);   //Creates Summoner Emblem using Sorcerer Emblem
            recipe13.AddIngredient(489, 1);
            recipe13.AddTile(114);
            recipe13.Register();
            Recipe recipe14 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(489, 1);    //Creates Sorcerer Emblem using Warrior Emblem
            recipe14.AddIngredient(490, 1);
            recipe14.AddTile(114);
            recipe14.Register();
            Recipe recipe15 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(490, 1);    //Creates Warrior Emblem using Ranger Emblem
            recipe15.AddIngredient(491, 1);
            recipe15.AddTile(114);
            recipe15.Register();
            Recipe recipe16 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(491, 1);    //Creates Ranger Emblem using Summoner Emblem
            recipe16.AddIngredient(2998, 1);
            recipe16.AddTile(114);
            recipe16.Register();
            Recipe recipe17 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(514, 1);    //Creates Laser Rifle using Breaker Blade
            recipe17.AddIngredient(426, 1);
            recipe17.AddTile(114);
            recipe17.Register();
            Recipe recipe18 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(426, 1);    //Creates Breaker Blade using Clockwork Assault Rifle
            recipe18.AddIngredient(434, 1);
            recipe18.AddTile(114);
            recipe18.Register();
            Recipe recipe19 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(434, 1);    //Creates Clockwork Assault Rifle using Firecracker
            recipe19.AddIngredient(4912, 1);
            recipe19.AddTile(114);
            recipe19.Register();
            Recipe recipe20 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(4912, 1);   //Creates Firecracker using Laser Rifle
            recipe20.AddIngredient(514, 1);
            recipe20.AddTile(114);
            recipe20.Register();
            //Skeletron Treasure Bag
            Recipe recipe21 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1281, 1);   //Creates Skeletron Mask using Skeletron Hand
            recipe21.AddIngredient(1273, 1);
            recipe21.AddTile(114);
            recipe21.Register();
            Recipe recipe22 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1273, 1);   //Creates Skeletron Hand using Book of Skulls
            recipe22.AddIngredient(1313, 1);
            recipe22.AddTile(114);
            recipe22.Register();
            Recipe recipe23 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1313, 1);   //Creates Book of Skulls using Skeletron Mask
            recipe23.AddIngredient(1281, 1);
            recipe23.AddTile(114);
            recipe23.Register();
            //Plantera Treasure Bag
            Recipe recipe24 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(758, 1);    //Creates Grenade Launcher using Venus Magnum
            recipe24.AddIngredient(1255, 1);
            recipe24.AddTile(114);
            recipe24.Register();
            Recipe recipe25 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1255, 1);   //Creates Venus Magnum using Nettle Burst
            recipe25.AddIngredient(788, 1);
            recipe25.AddTile(114);
            recipe25.Register();
            Recipe recipe26 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(788, 1);    //Creates Nettle Burst using Leaf Blower
            recipe26.AddIngredient(1178, 1);
            recipe26.AddTile(114);
            recipe26.Register();
            Recipe recipe27 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1178, 1);   //Creates Leaf Blower using Seedler
            recipe27.AddIngredient(3018, 1);
            recipe27.AddTile(114);
            recipe27.Register();
            Recipe recipe28 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(3018, 1);   //Creates Seedler using Flower Pow
            recipe28.AddIngredient(1259, 1);
            recipe28.AddTile(114);
            recipe28.Register();
            Recipe recipe29 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1259, 1);   //Creates Flower Pow using Wasp Gun
            recipe29.AddIngredient(1155, 1);
            recipe29.AddTile(114);
            recipe29.Register();
            Recipe recipe30 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1155, 1);   //Creates Wasp Gun using Grenade Launcher
            recipe30.AddIngredient(758);
            recipe30.AddTile(114);
            recipe30.Register();
            //Golem Treasure Bag
            Recipe recipe31 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1258, 1);   //Creates Stynger using Possessed Hatchet
            recipe31.AddIngredient(1122, 1);
            recipe31.AddTile(114);
            recipe31.Register();
            Recipe recipe32 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1122, 1);   //Creates Possessed Hatchet using Sun Stone
            recipe32.AddIngredient(899, 1);
            recipe32.AddTile(114);
            recipe32.Register();
            Recipe recipe33 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(899, 1);   //Creates Sun Stone using Eye of the Golem
            recipe33.AddIngredient(1248, 1);
            recipe33.AddTile(114);
            recipe33.Register();
            Recipe recipe34 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1248, 1);   //Creates Eye of the Golem using Picksaw
            recipe34.AddIngredient(1294, 1);
            recipe34.AddTile(114);
            recipe34.Register();
            Recipe recipe35 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1294, 1);   //Creates Picksaw using Heat Ray
            recipe35.AddIngredient(1295, 1);
            recipe35.AddTile(114);
            recipe35.Register();
            Recipe recipe36 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1295, 1);   //Creates Heat Ray using Staff of Earth
            recipe36.AddIngredient(1296, 1);
            recipe36.AddTile(114);
            recipe36.Register();
            Recipe recipe37 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1296, 1);   //Creates Staff of Earth using Golem Fist
            recipe37.AddIngredient(1297, 1);
            recipe37.AddTile(114);
            recipe37.Register();
            Recipe recipe38 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1297, 1);   //Creates Golem Fist using Stynger
            recipe38.AddIngredient(1258);
            recipe38.AddTile(114);
            recipe38.Register();
            //Duke Fishron Treasure Bag
            Recipe recipe39 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(2611, 1);   //Creates Flairon using Tsunami
            recipe39.AddIngredient(2624, 1);
            recipe39.AddTile(114);
            recipe39.Register();
            Recipe recipe40 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(2624, 1);   //Creates Tsunami using Razorblade Typhoon
            recipe40.AddIngredient(2622, 1);
            recipe40.AddTile(114);
            recipe40.Register();
            Recipe recipe41 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(2622, 1);   //Creates Razorblade Typhoon using Tempest Staff
            recipe41.AddIngredient(2621, 1);
            recipe41.AddTile(114);
            recipe41.Register();
            Recipe recipe42 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(2621, 1);   //Creates Tempest Staff using Bubble Gun
            recipe42.AddIngredient(2623, 1);
            recipe42.AddTile(114);
            recipe42.Register();
            Recipe recipe43 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(2623, 1);   //Creates Bubble Gun using Flairon
            recipe43.AddIngredient(2611, 1);
            recipe43.AddTile(114);
            recipe43.Register();
            //Moon Lord Treasure Bag
            Recipe recipe44 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(3063, 1);   //Creates Meowmere using Terrarian
            recipe44.AddIngredient(3389, 1);
            recipe44.AddTile(114);
            recipe44.Register();
            Recipe recipe45 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(3389, 1);   //Creates Terrarian using Star Wrath
            recipe45.AddIngredient(3065, 1);
            recipe45.AddTile(114);
            recipe45.Register();
            Recipe recipe46 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(3065, 1);   //Creates Star Wrath using S.D.M.G
            recipe46.AddIngredient(1553, 1);
            recipe46.AddTile(114);
            recipe46.Register();
            Recipe recipe47 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(1553, 1);   //Creates S.D.M.G using Celebration Mk2
            recipe47.AddIngredient(3930, 1);
            recipe47.AddTile(114);
            recipe47.Register();
            Recipe recipe48 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(3930, 1);   //Creates Celebration Mk2 using Celebration
            recipe48.AddIngredient(3546, 1);
            recipe48.AddTile(114);
            recipe48.Register();
            Recipe recipe49 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(3546, 1);   //Creates Celebration using Last Prism
            recipe49.AddIngredient(3541, 1);
            recipe49.AddTile(114);
            recipe49.Register();
            Recipe recipe50 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(3541, 1);   //Creates Last Prism using Lunar Flare
            recipe50.AddIngredient(3570, 1);
            recipe50.AddTile(114);
            recipe50.Register();
            Recipe recipe51 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(3570, 1);   //Creates Lunar Flare using Rainbow Crystal Staff
            recipe51.AddIngredient(3571, 1);
            recipe51.AddTile(114);
            recipe51.Register();
            Recipe recipe52 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(3571, 1);   //Creates Rainbow Crystal Staff using Lunar Portal Staff
            recipe52.AddIngredient(3569, 1);
            recipe52.AddTile(114);
            recipe52.Register();
            Recipe recipe53 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(3569, 1);   //Creates Lunar Portal Staff using Meowmere
            recipe53.AddIngredient(3063, 1);
            recipe53.AddTile(114);
            recipe53.Register();
            //Betsy Treasure Bag
            Recipe recipe54 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(3859, 1);   //Creates Aerial Bane using Flying Dragon
            recipe54.AddIngredient(3827, 1);
            recipe54.AddTile(114);
            recipe54.Register();
            Recipe recipe55 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(3827, 1);   //Creates Flying Dragon using Betsy's Wrath
            recipe55.AddIngredient(3870, 1);
            recipe55.AddTile(114);
            recipe55.Register();
            Recipe recipe56 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(3870, 1);   //Creates Betsy's Wrath using Sky Dragon's Fury
            recipe56.AddIngredient(3858, 1);
            recipe56.AddTile(114);
            recipe56.Register();
            Recipe recipe57 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(3858, 1);   //Creates Sky Dragon's Fury using Aerial Bane
            recipe57.AddIngredient(3859, 1);
            recipe57.AddTile(114);
            recipe57.Register();
            //Enpress of Light Treasure Bag
            Recipe recipe58 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(4923, 1);   //Creates Starlight using Nightglow
            recipe58.AddIngredient(4952, 1);
            recipe58.AddTile(114);
            recipe58.Register();
            Recipe recipe59 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(4952, 1);   //Creates Nightglow using Eventide
            recipe59.AddIngredient(4953, 1);
            recipe59.AddTile(114);
            recipe59.Register();
            Recipe recipe60 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(4953, 1);   //Creates Eventide using Kaleidoscope
            recipe60.AddIngredient(4914, 1);
            recipe60.AddTile(114);
            recipe60.Register();
            Recipe recipe61 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(4914, 1);   //Creates Kaleidoscope using Starlight
            recipe61.AddIngredient(4923, 1);
            recipe61.AddTile(114);
            recipe61.Register();
            //Queen Slime Treasure Bag
            Recipe recipe62 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(4981, 1);   //Creates Gelatinous Pillion using Hook of Dissonance
            recipe62.AddIngredient(4980, 1);
            recipe62.AddTile(114);
            recipe62.Register();
            Recipe recipe63 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(4980, 1);   //Creates Hook of Dissonance using Gelatinous Pillion
            recipe63.AddIngredient(4981, 1);
            recipe63.AddTile(114);
            recipe63.Register();
            Recipe recipe64 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(4982, 1);   //Creates Crystal Assassin Hood using Crystal Assassin Shirt
            recipe64.AddIngredient(4983, 1);
            recipe64.AddTile(114);
            recipe64.Register();
            Recipe recipe65 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(4983, 1);   //Creates Crystal Assassin Shirt using Crystal Assassin Pants
            recipe65.AddIngredient(4984, 1);
            recipe65.AddTile(114);
            recipe65.Register();
            Recipe recipe66 = ModContent.GetInstance<SwapableLoot.SwapableLoot1>().CreateRecipe(4984, 1);   //Creates Crystal Assassin Pants using Crystal Assassin Hood
            recipe66.AddIngredient(4982, 1);
            recipe66.AddTile(114);
            recipe66.Register();
		}
	}
}

