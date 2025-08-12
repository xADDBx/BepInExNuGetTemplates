## Usage

### Environmental Setup (Only needs to be done the first time)
- Open Windows command prompt (cmd.exe)
- Install .NET SDK with the command:  
  `winget install Microsoft.Dotnet.SDK.9`
- I suggest using Visual Studio 2022 to edit the project. Use the following cmd command to install it:  
  `winget install Microsoft.VisualStudio.2022.Community --override "--add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.Net.Component.4.8.1.SDK"`
- If you haven't done this before (If you're not sure, just execute in anyways), you might need to add the NuGet repository as a source with the following command:  
  `dotnet nuget add source https://api.nuget.org/v3/index.json -n nuget.org`  
  (Just ignore the following error if it appears: "`The name specified has already been added to the list of available package sources. Provide a unique name.`")
- `dotnet new install ADDB.BepInEx.Templates`

### Creating a Project
- Either create a new project based on the respective template via Visual Studio GUI or
- Create the project via CLI:
  - Open Windows command prompt (cmd.exe) in the directory which should contain project folder
  - `dotnet new <TemplateName> -n <ModID> -D "<Mod Name>" -G "<Game Name>" -A "<Path/To/Game/AppData>" -P "<GameDataFolderName>"`  (Replace the `<value>` placeholder with actual values; See a list of TemplateNames just below.)
  - Open the resulting project (open the .sln file with Visual Studio)
  - Examples: 
    - `dotnet new bepinexmonomod -n MyAmazingMod -D "My Amazing Mod" -G Peak -A "$(LocalAppData)Low\LandCrab\PEAK" -P "PEAK_Data"`
    - `dotnet new bepinexil2cppmod -n MyAmazingIl2CppMod -D "My Amazing Mod" -G NoRestForTheWicked -A "$(LocalAppData)Low\Moon Studios\NoRestForTheWicked"` (Note: Il2Cpp mods don't have a -P option)

## Existing Template:

- `bepinexmonomod`  - BepInEx Template for a Unity Mono game.
- `bepinexil2cppmod` - BepInEx Template for a Unity Il2Cpp game.

After that you should working setup for a UnityModManager mod which:

- automatically installs the mod when building
- has the correct path and already references a few assemblies (with some of them publicized)


## Requirements

- The target game needs to be installed. The game must've been started once (for a Player.log file).
- BepInEx needs to be installed in the game's folder
- You need .NET SDK 9 or newer installed. The Environmental Setup step includes a command which installs one such version.
