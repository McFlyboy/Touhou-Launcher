﻿namespace TouhouLauncher.Models.GameInfo {
	public abstract class Game {
		public string Title { get; set; }
		public string Subtitle { get; set; }
		public string ImageLocation { get; set; }
		public string AudioLocation { get; set; }
		public int ReleaseYear { get; set; }
		public string FileLocation { get; set; }
	}
}