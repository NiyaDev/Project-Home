using Godot;
using System;

public partial class MapHandler : Node {
	public Node mapdata;
	
	public override void _Process(double delta) {
		if (mapdata == null) {
			// Attempt to grab mapdata
			mapdata = GetNode<Node>("/root/SceneHandler/MapData");
			if (mapdata == null) return;
			
			// Initialize map
			GD.Print("Initializing map");
			mapdata.SetMeta("Initialized", true);
		}
		
	}
}
