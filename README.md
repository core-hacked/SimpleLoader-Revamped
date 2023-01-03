> This branch is unfinished - the groundwork is being layed out. Please go to the master branch (master-dotnet5-winforms) for a working version of SimpleLoader-Revamped.

![banner](https://raw.githubusercontent.com/core-hacked/SimpleLoader-Revamped/master-dotnet-7-wpf/banner.png)

# [SimpleLoader by Wilson](https://github.com/WilsonPublic/SimpleLoader), [SimpleLoader Revamped by core-hacked](https://github.com/core-hacked/SimpleLoader-Revamped).

This is a port of WilsonPublic's Github SimpleLoader which was made with .NET Framework WindowsForms (C#) into .NET 7. It includes no protection mechanisms, obfuscation or encryption. It can be cracked by people with enough knowledge, although it is significantly harder to crack than the original SimpleLoader due to the fact that it is now a WPF (Windows Presentation Framework) application using .NET 7.

## Changes:

```diff
+ Added comments to make it beginner friendly

- Remove previous name variable that stores the name for the labels and form name (unnecessary)

+ Changed Formatting

- Removed easy to crack comment and replaced by not protected comment.

+ Changed how comments are expressed.
+ Changed how things are named.
+ Changed `checkonline()` to be updated live with a timer.

+ Changed `checkonline()` request URL to be duckduckgo instead of google, because google blocks requests after a while, which resulted in the status being offline.

+ Changed the design to be a DarkUI
+ Changed Icon
+ Added Panel at the top
+ Changed Form Border to none
+ Made form movable when dragging panel
+ Added minimize and Close buttons to the panel.
+ Added PictureBox and Text to the Panel.
+ Ported to .NET 7 WPF from .NET 5 Winforms
```

## Dependancies:

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)

- [Visual Studio Version that supports .NET 7](https://visualstudio.microsoft.com/)

- [Administrator access on your machine.](https://support.microsoft.com/en-us/windows/how-do-i-log-on-as-an-administrator-63267a09-9926-991a-1c77-d203160c8563#:~:text=An%20administrator%20is%20someone%20who,changes%20to%20other%20user%20accounts.)
