using Godot;
using System;

public partial class GameManager : Node {
	private CurrentScene cur_scene = CurrentScene.NONE;
	public PackedScene title_scene;
	public PackedScene combat_scene;
	public PackedScene overworld_scene;
	
	public override void _Ready() {
		title_scene = ResourceLoader.Load<PackedScene>("res://scenes/title.tscn");
		combat_scene = ResourceLoader.Load<PackedScene>("res://scenes/combat.tscn");
		overworld_scene = ResourceLoader.Load<PackedScene>("res://scenes/overworld.tscn");
		
	}
	
	public override void _Process(double delta) {
		
	}
	
	public override void _Input(InputEvent @event) {
		if (@event.IsActionPressed("test1")) {
			switch (cur_scene) {
				case CurrentScene.NONE:
					GetTree().Root.AddChild(title_scene.Instantiate());
					cur_scene = CurrentScene.TITLE;
					break;
				case CurrentScene.TITLE:
					GetTree().Root.GetChild(1).Free();
					GetTree().Root.AddChild(combat_scene.Instantiate());
					cur_scene = CurrentScene.COMBAT;
					break;
				case CurrentScene.COMBAT:
					GetTree().Root.GetChild(1).Free();
					GetTree().Root.AddChild(overworld_scene.Instantiate());
					cur_scene = CurrentScene.OVERWORLD;
					break;
				case CurrentScene.OVERWORLD:
					GetTree().Root.GetChild(1).Free();
					cur_scene = CurrentScene.NONE;
					break;
			}
		}
	}
}

enum CurrentScene {
	NONE,
	TITLE,
	COMBAT,
	OVERWORLD,
}
