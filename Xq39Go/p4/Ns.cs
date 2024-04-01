using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace p4
{
	// Token: 0x02000008 RID: 8
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[StandardModule]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[HideModuleName]
	internal sealed class Ns
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002C6C File Offset: 0x00000E6C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager N
		{
			get
			{
				bool flag = object.ReferenceEquals(Ns.i, null);
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("WindowsApp1.Resources", typeof(Ns).Assembly);
					Ns.i = resourceManager;
				}
				return Ns.i;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002CB4 File Offset: 0x00000EB4
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000028A6 File Offset: 0x00000AA6
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo n
		{
			get
			{
				return Ns.n;
			}
			set
			{
				Ns.n = value;
			}
		}

		// Token: 0x0400000D RID: 13
		private static ResourceManager i;

		// Token: 0x0400000E RID: 14
		private static CultureInfo n;
	}
}
