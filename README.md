![banner](https://github.com/core-hacked/SimpleLoader-Revamped/blob/master/.net%20loader%20image%20git.png)

# [SimpleLoader by Wilson](https://github.com/WilsonPublic/SimpleLoader), [SimpleLoader Revamped by core-hacked](https://github.com/core-hacked/SimpleLoader-Revamped).

This is a port of WilsonPublic's Github SimpleLoader which was made with .NET Framework WindowsForms (C#) into .NET 6 WPF (Windows Presentation Framework). It includes no protection mechanisms, obfuscation or encryption. It can be cracked by people with enough knowledge, although it is significantly harder to crack than the original SimpleLoader due to the fact that it is now a WPF application using .NET 6.

## Changes:

```diff
+ Added comments to make it beginner friendly

- Removed previous name variable to store the name so the labels and form name can be updated easily

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
+ Ported to .NET 6 WPF from .NET 5 WinForms
```

## Dependancies:

```
- .NET 6 SDK

- Visual Studio Version that supports .NET 6

- Administrator access on your machine.
```
