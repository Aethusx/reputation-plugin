using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RBot;
using RBot.Options;
using RBot.Plugins;

namespace ReputationPlugin
{
	public class Loader : RPlugin
	{
		public override string Name => "Reputation Plugin";
		public override string Author => "Aethus";
		public override string Description => "Plugin that shows reputations";

		private ToolStripItem menuItem;

		public override List<IOption> Options => new List<IOption>{
			new Option<string>("creator", "Creator", "Created by Aethus (https://github.com/Aethusx/)", "Aethus", false)
		};

		public override void Load()
		{
			Bot.Log("Reputation Plugin Loaded.");
			menuItem = Forms.Main.Plugins.DropDownItems.Add("Reputations");
			menuItem.Click += MenuStripItem_Click;
		}

		public override void Unload()
		{
			// Unloading plugins is buggy in rbot so recommend not unloading but instead removing the plugin from the plugin folder
			// *this may be fixed in the future*
			Bot.Log("Reputation Plugin Unloaded.");
			menuItem.Click -= MenuStripItem_Click;
			Forms.Main.Plugins.DropDownItems.Remove(menuItem);
		}

		private void MenuStripItem_Click(object sender, EventArgs e)
		{
			// This will show/hide the example form when the menu strip button is click
			if (ReputationForm.Instance.Visible)
			{
				ReputationForm.Instance.Hide();
			}
			else
			{
				ReputationForm.Instance.Show();
				ReputationForm.Instance.BringToFront();
			}
		}
	}
}
