@echo off
if not exist scenario-repack mkdir scenario-repack
for %%i in (scenario-extracted\*.mjo) do MajiroStringEditor --inject "scenario\%%~nxi" "%%i" "scenario-repack\%%~nxi"
for %%i in (scenario\*) do (
 if not exist "scenario-repack\%%~nxi" copy "%%i" "scenario-repack\%%~nxi"
)
arc_conv.exe --pack majiro .\scenario-repack .\scenario.arc 3
pause