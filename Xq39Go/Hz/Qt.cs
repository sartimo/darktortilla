using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using d5;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Wt;
using Ya;

namespace Hz
{
	// Token: 0x02000004 RID: 4
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[StandardModule]
	[HideModuleName]
	internal sealed class Qt
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000029D0 File Offset: 0x00000BD0
		[HelpKeyword("My.Computer")]
		internal static k7 C
		{
			[DebuggerHidden]
			get
			{
				return Qt.y.J();
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000029EC File Offset: 0x00000BEC
		[HelpKeyword("My.Application")]
		internal static Go C
		{
			[DebuggerHidden]
			get
			{
				return Qt.u.J();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002A08 File Offset: 0x00000C08
		[HelpKeyword("My.User")]
		internal static User F
		{
			[DebuggerHidden]
			get
			{
				return Qt.V.J();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002A24 File Offset: 0x00000C24
		[HelpKeyword("My.Forms")]
		internal static Qt.La K
		{
			[DebuggerHidden]
			get
			{
				return Qt.i.J();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002A40 File Offset: 0x00000C40
		[HelpKeyword("My.WebServices")]
		internal static Qt.Yi N
		{
			[DebuggerHidden]
			get
			{
				return Qt.t.J();
			}
		}

		// Token: 0x04000005 RID: 5
		private static readonly Qt<k7>.z5 y = new Qt<k7>.z5();

		// Token: 0x04000006 RID: 6
		private static readonly Qt<Go>.z5 u = new Qt<Go>.z5();

		// Token: 0x04000007 RID: 7
		private static readonly Qt<User>.z5 V = new Qt<User>.z5();

		// Token: 0x04000008 RID: 8
		private static Qt<Qt.La>.z5 i = new Qt<Qt.La>.z5();

		// Token: 0x04000009 RID: 9
		private static readonly Qt<Qt.Yi>.z5 t = new Qt<Qt.Yi>.z5();

		// Token: 0x02000005 RID: 5
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class La
		{
			// Token: 0x0600000A RID: 10 RVA: 0x00002A5C File Offset: 0x00000C5C
			[DebuggerHidden]
			private static b0 x3<b0>(b0 A_0) where b0 : Form, new()
			{
				bool flag = A_0 == null || A_0.IsDisposed;
				if (flag)
				{
					bool flag2 = Qt.La.N != null;
					if (flag2)
					{
						bool flag3 = Qt.La.N.ContainsKey(typeof(b0));
						if (flag3)
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						Qt.La.N = new Hashtable();
					}
					Qt.La.N.Add(typeof(b0), null);
					try
					{
						return Activator.CreateInstance<b0>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						});
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						Qt.La.N.Remove(typeof(b0));
					}
				}
				return A_0;
			}

			// Token: 0x0600000B RID: 11 RVA: 0x00002834 File Offset: 0x00000A34
			[DebuggerHidden]
			private void o2<Gi>(ref Gi A_1) where Gi : Form
			{
				A_1.Dispose();
				A_1 = default(Gi);
			}

			// Token: 0x0600000C RID: 12 RVA: 0x0000284B File Offset: 0x00000A4B
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public La()
			{
			}

			// Token: 0x0600000D RID: 13 RVA: 0x00002B84 File Offset: 0x00000D84
			[EditorBrowsable(EditorBrowsableState.Never)]
			public bool e3(object A_1)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(A_1));
			}

			// Token: 0x0600000E RID: 14 RVA: 0x00002BA4 File Offset: 0x00000DA4
			[EditorBrowsable(EditorBrowsableState.Never)]
			public int Sr()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600000F RID: 15 RVA: 0x00002BBC File Offset: 0x00000DBC
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal Type w9()
			{
				return typeof(Qt.La);
			}

			// Token: 0x06000010 RID: 16 RVA: 0x00002BD8 File Offset: 0x00000DD8
			[EditorBrowsable(EditorBrowsableState.Never)]
			public string p9()
			{
				return base.ToString();
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000011 RID: 17 RVA: 0x00002855 File Offset: 0x00000A55
			// (set) Token: 0x06000012 RID: 18 RVA: 0x00002870 File Offset: 0x00000A70
			public Ws W
			{
				[DebuggerHidden]
				get
				{
					this.l = Qt.La.x3<Ws>(this.l);
					return this.l;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.l)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.o2<Ws>(ref this.l);
					}
				}
			}

			// Token: 0x0400000A RID: 10
			[ThreadStatic]
			private static Hashtable N;

			// Token: 0x0400000B RID: 11
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Ws l;
		}

		// Token: 0x02000006 RID: 6
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class Yi
		{
			// Token: 0x06000013 RID: 19 RVA: 0x00002B84 File Offset: 0x00000D84
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public bool Md(object A_1)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(A_1));
			}

			// Token: 0x06000014 RID: 20 RVA: 0x00002BA4 File Offset: 0x00000DA4
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public int c3()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000015 RID: 21 RVA: 0x00002BF0 File Offset: 0x00000DF0
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal Type y6()
			{
				return typeof(Qt.Yi);
			}

			// Token: 0x06000016 RID: 22 RVA: 0x00002BD8 File Offset: 0x00000DD8
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public string o3()
			{
				return base.ToString();
			}

			// Token: 0x06000017 RID: 23 RVA: 0x00002C0C File Offset: 0x00000E0C
			[DebuggerHidden]
			private static Ec Yr<Ec>(Ec A_0) where Ec : new()
			{
				bool flag = A_0 == null;
				Ec result;
				if (flag)
				{
					result = Activator.CreateInstance<Ec>();
				}
				else
				{
					result = A_0;
				}
				return result;
			}

			// Token: 0x06000018 RID: 24 RVA: 0x0000289C File Offset: 0x00000A9C
			[DebuggerHidden]
			private void Qx<y4>(ref y4 A_1)
			{
				A_1 = default(y4);
			}

			// Token: 0x06000019 RID: 25 RVA: 0x0000284B File Offset: 0x00000A4B
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public Yi()
			{
			}
		}

		// Token: 0x02000007 RID: 7
		[ComVisible(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class z5<Rr> where Rr : new()
		{
			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600001A RID: 26 RVA: 0x00002C38 File Offset: 0x00000E38
			internal Rr Q
			{
				[DebuggerHidden]
				get
				{
					bool flag = Qt<Rr>.z5.Q == null;
					if (flag)
					{
						Qt<Rr>.z5.Q = Activator.CreateInstance<Rr>();
					}
					return Qt<Rr>.z5.Q;
				}
			}

			// Token: 0x0600001B RID: 27 RVA: 0x0000284B File Offset: 0x00000A4B
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public z5()
			{
			}

			// Token: 0x0400000C RID: 12
			[ThreadStatic]
			[CompilerGenerated]
			private static Rr Q;
		}
	}
}
