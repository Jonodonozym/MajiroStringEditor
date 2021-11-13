# MajiroStringEditor - v1.1

Forked from [marcussacana's repo](https://github.com/marcussacana/MajiroStringEditor). Rewritten to run on the command line, and export / import strings from .txt files. This lets you use your prefered text editor program and batch scripts.

A tool to transalte the MJO files from Majiro Engine,  
Tested with "If You Love Me, Then Say So!"
	
## Extract/Repack .arc Files
This tool don't include .arc extractor or repacker,  
to this you can use the [arc_conv](https://github.com/amayra/arc_conv)
- **Extract:** Drag&Drop the .arc
- **Repack:**  arc_conv.exe --pack majiro .\scenario .\scenario.arc 3  
	- **.\scenario** = Input Directory
	- **.\scenario.arc** = Output Archive
	- **3 = Arc version** (1, 2 or 3)

## Command usage
- MajiroStringEditor.exe --extract [input MJO file] [output txt file]
- MajiroStringEditor.exe --inject [input MJO file] [input txt file] [output MJO file]

## Tags
This tags is someting automatically converted to the Majiro script  
and don't represent an real tag of this engine.
- **\n** Linebreak
- **[wait]** Wait for the user to click to show the remaining text
- **[clear]** Clears the text box
- **[line]** Marks where the character name ends and where the character's dialogue begins

## Samples Lines
- Splitting the dialogue in two parts
	`Name 1[line]Dialogue 1[wait][clear]Name 2[line]Dialogue 2`
- Spliting the line in two
	`Line 1\nLine 2`
