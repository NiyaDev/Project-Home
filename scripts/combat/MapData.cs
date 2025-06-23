using Godot;
using System;

public partial class MapData : Node {
	public bool initialized = false;
	public int height = 20, width = 20;
	
	public void print() {
		GD.Print("--Initialized: "+initialized+"\n--Size: "+height+" x "+width);
	}
}
