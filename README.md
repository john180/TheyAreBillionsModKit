# TheyAreBillionsModKit
Tools &amp; Research notes for modding "They Are Billions"

# What is this?

 - This is a set of tools and notes for creating mods for "They Are Billions". This project must not be used for illegal purposes, or for getting a highscore on any leaderboards that are present in the game, it is strictly for educational purposes and for people to experiment with.

# Tools

## Map Editor
 - The map editor allows you to edit save files
 - You can use the map editor in your browser [here](https://ash47.github.io/TheyAreBillionsModKit/MapEditorHtml/)
 - Simply load in a save file, and the editor will let you edit it

## Data Editors
 - Currently only `ZXRules.dat` can be edited.
 - Place `.dat` files into `DataEditor/input/` folder.
 - Execute `run.bat` (ensure you ran `npm install` if it's your first use)
 - The `working` folder will contain a JSON editable file, any changes made to this will be updated in the `output` folder after you run `run.bat` again
 - Copy the file from `output` into your game's directory
