using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Px
{
	// Token: 0x0200000B RID: 11
	public class Dj : StringConverter
	{
		// Token: 0x06000023 RID: 35
		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "IsValidLocale", ExactSpelling = true, SetLastError = true)]
		public static extern int E(int, int);

		// Token: 0x06000024 RID: 36 RVA: 0x00002CFC File Offset: 0x00000EFC
		public Dj()
		{
			this.h = new string[]
			{
				"ar-JO",
				"pt-BR",
				"de-DE",
				"es-ES",
				"fr-FR",
				"hu-HU",
				"it-IT",
				"nl-NL",
				"en-US",
				"ru-RU",
				"ro-RO",
				"fi-FI",
				"zh-TW"
			};
			checked
			{
				this.g = new string[this.h.Length + 1];
				int num = 0;
				foreach (string name in this.h)
				{
					CultureInfo cultureInfo = new CultureInfo(name);
					bool flag = Dj.E(cultureInfo.LCID, 1) != 0;
					if (flag)
					{
						this.g[num] = cultureInfo.NativeName;
					}
					else
					{
						this.g[num] = cultureInfo.EnglishName;
					}
					num++;
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002E04 File Offset: 0x00001004
		public virtual TypeConverter.StandardValuesCollection Bs(ITypeDescriptorContext A_1)
		{
			return new TypeConverter.StandardValuesCollection(this.h);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002E24 File Offset: 0x00001024
		public virtual bool Kr(ITypeDescriptorContext A_1)
		{
			return true;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002E24 File Offset: 0x00001024
		public virtual bool n9(ITypeDescriptorContext A_1)
		{
			return true;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002E38 File Offset: 0x00001038
		public virtual object i6(ITypeDescriptorContext A_1, CultureInfo A_2, object A_3, Type A_4)
		{
			bool flag = A_3 is string && A_4 == typeof(string);
			checked
			{
				if (flag)
				{
					int num = this.h.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						bool flag2 = Operators.ConditionalCompareObjectEqual(this.h[i], A_3, false);
						if (flag2)
						{
							return this.g[i];
						}
					}
				}
				return base.ConvertTo(A_1, A_2, RuntimeHelpers.GetObjectValue(A_3), A_4);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002EB4 File Offset: 0x000010B4
		public virtual object Sg(ITypeDescriptorContext A_1, CultureInfo A_2, object A_3)
		{
			string right = A_3 as string;
			checked
			{
				int num = this.h.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					bool flag = Operators.CompareString(this.g[i], right, false) == 0;
					if (flag)
					{
						return this.h[i];
					}
				}
				return base.ConvertFrom(A_1, A_2, RuntimeHelpers.GetObjectValue(A_3));
			}
		}

		// Token: 0x04000010 RID: 16
		private const long t = 1L;

		// Token: 0x04000011 RID: 17
		private readonly string[] h;

		// Token: 0x04000012 RID: 18
		private readonly string[] g;
	}
}
