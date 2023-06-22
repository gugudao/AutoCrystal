using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static ARLC.Utils;


namespace ARLC.Global
{
	public class GItem: GlobalItem
	{
		public override void SetDefaults(Item item)
		{
		}
		public override bool PreDrawInInventory(Item item, SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
		{
			if (item.type == ItemID.LifeCrystal || item.type == ItemID.ManaCrystal || item.type == ItemID.LifeFruit)
			{
				if (Config.AutoCrystal) item.autoReuse = true;
				item.useTime = item.useAnimation = Config.ItemUseTime;
			}
			return true;
		}

	}
}
