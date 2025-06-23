using Godot;
using System;

public partial class MapHandler : Node {
	public MapData mapdata;
	public TileMapLayer tilemap;
	
	private 
	
	public override void _Ready() {
		tilemap = GetChild(0) as TileMapLayer;
	}
	
	public override void _Process(double delta) {
		if (mapdata == null) {
			// Attempt to grab mapdata
			mapdata = GetNode<Node>("../../GameManager/MapData") as MapData;
			if (mapdata == null) return;
			
			// Initialize map
			if (!mapdata.initialized) {
				GD.Print("Initializing map");
				mapdata.print();
				mapdata.initialized = true;
				tilemap.SetCell(new Vector2I(1,1), 0, new Vector2I(0,3));
				tilemap.SetCell(new Vector2I(2,1), 0, new Vector2I(1,3));
				tilemap.SetCell(new Vector2I(3,1), 0, new Vector2I(1,3));
				tilemap.SetCell(new Vector2I(4,1), 0, new Vector2I(1,3));
				tilemap.SetCell(new Vector2I(5,1), 0, new Vector2I(1,3));
				tilemap.SetCell(new Vector2I(5,2), 1, new Vector2I(1,3));
			}
		}
		
	}
}
