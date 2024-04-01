using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Jc97
{
	// Token: 0x02000017 RID: 23
	[CompilerGenerated]
	internal sealed class Xf0i
	{
		// Token: 0x06000074 RID: 116 RVA: 0x0000BBE8 File Offset: 0x00009DE8
		internal static uint Da7j(string k8A2)
		{
			uint num = 2166136261U;
			if (k8A2 != null)
			{
				for (int i = 0; i < k8A2.Length; i++)
				{
					num = ((uint)k8A2[i] ^ num) * 16777619U;
				}
			}
			return num;
		}

		// Token: 0x0400006B RID: 107 RVA: 0x000027A0 File Offset: 0x000009A0
		internal static readonly Xf0i.p0KH 377A23F52C6B357696238C3318F677A082DD3430BB6691042BD550A5CDA28EBB;

		// Token: 0x0400006C RID: 108 RVA: 0x000027A8 File Offset: 0x000009A8
		internal static readonly Xf0i.o2CQ 8BEF788024D30FE084B7DA5B4C62CF15B84F9862E73CA163C94A2C4BA6C65058;

		// Token: 0x0400006D RID: 109 RVA: 0x000027B0 File Offset: 0x000009B0
		internal static readonly Xf0i.Qt09 DFEA2964B5DEEDEA7B1EF077DE529C3959E6788BDBB3441E70C77A1AE875BB48;

		// Token: 0x02000018 RID: 24
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 5)]
		private struct p0KH
		{
		}

		// Token: 0x02000019 RID: 25
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 6)]
		private struct Qt09
		{
		}

		// Token: 0x0200001A RID: 26
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 7)]
		private struct o2CQ
		{
		}
	}
}
