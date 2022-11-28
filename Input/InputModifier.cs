using System;
using JetBrains.Annotations;

namespace Dark5.SDK.Core.Input
{
	[PublicAPI]
	[Flags]
	public enum InputModifier
	{
		Any = -1,
		None = 0,
		Ctrl = 1,
		Alt = 1 << 1,
		Shift = 1 << 2
	}
}
