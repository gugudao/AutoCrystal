using System.ComponentModel;
using Terraria.ModLoader.Config;
using static ARLC.Utils;

namespace ARLC
{
	//[BackgroundColor(153, 61, 97, 200)]

	public class ARLCConfigs : ModConfig
	{
		const string _path = "Mods.ARLC.Config";
		public override ConfigScope Mode => ConfigScope.ServerSide;

		public override void OnLoaded() => Config = this;

		[Header($"${_path}.SpeedConfig.Header")]

		[DefaultValue(true)]
		public bool AutoCrystal;

		[Slider]
		[DefaultValue(30)]
		[Range(1, 30)]
		[Increment(1)]
		public int ItemUseTime;
	}
}
