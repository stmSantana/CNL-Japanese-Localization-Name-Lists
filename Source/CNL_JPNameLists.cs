using System;
using System.Reflection;
using UnityEngine;
using ColossalFramework.UI;
using ICities;

namespace CNL_JPNameLists
{
public class CNL_JPNameLists: IUserMod
{
public string Name
{
get { return "CNL Japanese Localization Name Lists"; }
}

public string Description
{
	get { return "(By stmSantana) このMODは単独では働きません. Subscribe 'Custom Name Lists' Mod, Then, Enable both Mod."; }
}
}
} 