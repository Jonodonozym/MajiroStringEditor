@echo off

Echo You'll need to extract the mjo files manually with arc_conv before running this.
Echo Check the Readme at https://github.com/Jonodonozym/MajiroStringEditor for more details
Echo Also delete any empty files in the output directory; they are not scenario scripts

if not exist scenario-extracted mkdir scenario-extracted
for %%i in (scenario\*.mjo) do MajiroStringEditor --extract "%%i" "scenario-extracted\%%~nxi"
pause
