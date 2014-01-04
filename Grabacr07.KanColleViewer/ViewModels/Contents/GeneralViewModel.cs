﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livet;

namespace Grabacr07.KanColleViewer.ViewModels.Contents
{
	public class GeneralViewModel : TabItemViewModel
	{
		public MainContentViewModel Content { get; private set; }

		public GeneralViewModel(MainContentViewModel owner)
		{
			this.Name = "総合";

			this.Content = owner;
		}


		public void Jump(string tabName)
		{
			TabItemViewModel target = null;

			switch (tabName)
			{
				case "Expeditions":
					target = this.Content.Expeditions;
					break;
				case "Quests":
					target = this.Content.Quests;
					break;
				case "Repairyard":
					target = this.Content.Repairyard;
					break;
				case "Dockyard":
					target = this.Content.Dockyard;
					break;
			}

			if (target != null) target.IsSelected = true;
		}
	}
}