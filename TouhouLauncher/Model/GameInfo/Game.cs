﻿using System.Diagnostics;
using System.Windows;

namespace TouhouLauncher.Model.GameInfo {
	public abstract class Game {
		public string Title { get; set; }
		public string Subtitle { get; set; }
		public string ImageLocation { get; set; }
		public string AudioLocation { get; set; }
		public int ReleaseYear { get; set; }
		public string LocalFileLocation { get; set; }
		public void Launch(bool exitOnLaunch = false) {
			if (LocalFileLocation.Length == 0) {
				return;
			}
			Process proc = new Process();
			proc.StartInfo.FileName = LocalFileLocation;
			proc.Start();
			if (exitOnLaunch) {
				Application.Current.Shutdown();
			}
		}
	}
}