﻿using System.Collections.Generic;

namespace TouhouLauncher.Models.GameInfo {
	public class GameDB {
		public OfficialGame[] OfficialGames { get; set; }
		public List<FanGame> FanGames { get; set; }
	}
}