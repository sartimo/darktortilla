using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Tk1f;

namespace So
{
	// Token: 0x02000012 RID: 18
	public class Tf
	{
		// Token: 0x0600004C RID: 76 RVA: 0x0000295F File Offset: 0x00000B5F
		public Tf()
		{
			this.y = new Tf.Qc();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00007234 File Offset: 0x00005434
		private void Pj(object A_1, EventArgs A_2)
		{
			Tf.Qc qc = this.y;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "DefaultTimeout", new object[]
			{
				qc.M
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "DefaultMessage", new object[]
			{
				qc.b
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "emerg_delay", new object[]
			{
				qc.j
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "emerg_message", new object[]
			{
				qc.q
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "Sound", new object[]
			{
				qc.D
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "Force", new object[]
			{
				qc.e
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "Reboot", new object[]
			{
				qc.M
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "ShowSplash", new object[]
			{
				qc.K
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "dbPath", new object[]
			{
				qc.A
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "autocheckUpdates", new object[]
			{
				qc.y
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "Language", new object[]
			{
				qc.C
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "Threads", new object[]
			{
				qc.g
			}, null, null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "repeatInterval", new object[]
			{
				qc.x
			}, null, null, false, true);
			NewLateBinding.LateCall(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "Save", new object[0], null, null, null, true);
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Aquila Technology\\WakeOnLAN", true);
				registryKey.SetValue("RepeatInterval", RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "repeatInterval", new object[0], null, null, null)), RegistryValueKind.DWord);
				registryKey.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show((IWin32Window)this, ex.Message, "Save RepeatInterval to registry.");
			}
			bool flag = Operators.ConditionalCompareObjectNotEqual(this.D, NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "dbPath", new object[0], null, null, null), false);
			if (flag)
			{
				try
				{
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Aquila Technology\\WakeOnLAN", true);
					registryKey.SetValue("Database", Path.GetDirectoryName(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "dbPath", new object[0], null, null, null))), RegistryValueKind.String);
					registryKey.Close();
				}
				catch (Exception ex2)
				{
					MessageBox.Show((IWin32Window)this, ex2.Message, "Save database path.");
				}
				Application.Exit();
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000028DD File Offset: 0x00000ADD
		private void d3(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000076D4 File Offset: 0x000058D4
		private void Nn(object A_1, EventArgs A_2)
		{
			this.D = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "dbPath", new object[0], null, null, null));
			this.r4();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00007724 File Offset: 0x00005924
		private void r4()
		{
			Tf.Qc qc = this.y;
			qc.M = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "DefaultTimeout", new object[0], null, null, null));
			qc.b = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "DefaultMessage", new object[0], null, null, null));
			qc.j = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "emerg_delay", new object[0], null, null, null));
			qc.q = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "emerg_message", new object[0], null, null, null));
			qc.D = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "Sound", new object[0], null, null, null));
			qc.e = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "Force", new object[0], null, null, null));
			qc.M = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "Reboot", new object[0], null, null, null));
			qc.K = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "ShowSplash", new object[0], null, null, null));
			qc.A = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "dbPath", new object[0], null, null, null));
			qc.y = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "autocheckUpdates", new object[0], null, null, null));
			qc.C = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "Language", new object[0], null, null, null));
			qc.g = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "Threads", new object[0], null, null, null));
			qc.x = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "repeatInterval", new object[0], null, null, null));
			object instance = this.x;
			NewLateBinding.LateSet(instance, null, "SelectedObject", new object[]
			{
				this.y
			}, null, null);
			NewLateBinding.LateSet(this.x, null, "Enabled", new object[]
			{
				false
			}, null, null);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007A70 File Offset: 0x00005C70
		internal static object q3()
		{
			return q2B3.y2WK();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002973 File Offset: 0x00000B73
		private void Mt(object A_1, PropertyValueChangedEventArgs A_2)
		{
			NewLateBinding.LateSet(this.x, null, "Enabled", new object[]
			{
				true
			}, null, null);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00007A88 File Offset: 0x00005C88
		private void Ca(object A_1, EventArgs A_2)
		{
			bool flag = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "AreYouSure", new object[0], null, null, null)), MsgBoxStyle.YesNo | MsgBoxStyle.Question, null) == MsgBoxResult.No;
			if (!flag)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "Reset", new object[0], null, null, null, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "DefaultMessage", new object[]
				{
					NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "DefaultMessage", new object[0], null, null, null)
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.j, null, "Settings", new object[0], null, null, null), null, "emerg_message", new object[]
				{
					NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.j, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "DefaultEmergency", new object[0], null, null, null)
				}, null, null, false, true);
				NewLateBinding.LateCall(this.j, null, "GetFile", new object[0], null, null, null, true);
				this.r4();
				NewLateBinding.LateSet(this.x, null, "Enabled", new object[]
				{
					true
				}, null, null);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00007C54 File Offset: 0x00005E54
		internal static bool Qw(string A_0, string A_1)
		{
			return A_0.Contains(A_1);
		}

		// Token: 0x04000048 RID: 72
		private object j;

		// Token: 0x04000049 RID: 73
		private readonly Tf.Qc y;

		// Token: 0x0400004A RID: 74
		private string D;

		// Token: 0x0400004B RID: 75
		private object x;

		// Token: 0x02000013 RID: 19
		private sealed class Qc
		{
			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000056 RID: 86 RVA: 0x00002999 File Offset: 0x00000B99
			// (set) Token: 0x06000057 RID: 87 RVA: 0x000029A3 File Offset: 0x00000BA3
			public object M
			{
				[CompilerGenerated]
				get
				{
					return this.P;
				}
				[CompilerGenerated]
				set
				{
					this.P = RuntimeHelpers.GetObjectValue(value);
				}
			}

			// Token: 0x0400004C RID: 76
			private bool Q;

			// Token: 0x0400004D RID: 77
			private object t;

			// Token: 0x0400004E RID: 78
			private int F;

			// Token: 0x0400004F RID: 79
			internal object b;

			// Token: 0x04000050 RID: 80
			internal object j;

			// Token: 0x04000051 RID: 81
			internal object q;

			// Token: 0x04000052 RID: 82
			internal object D;

			// Token: 0x04000053 RID: 83
			internal object e;

			// Token: 0x04000054 RID: 84
			internal object M;

			// Token: 0x04000055 RID: 85
			internal object y;

			// Token: 0x04000056 RID: 86
			internal object x;

			// Token: 0x04000057 RID: 87
			internal object K;

			// Token: 0x04000058 RID: 88
			internal object A;

			// Token: 0x04000059 RID: 89
			internal object C;

			// Token: 0x0400005A RID: 90
			internal object g;

			// Token: 0x0400005B RID: 91
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private object P;
		}
	}
}
