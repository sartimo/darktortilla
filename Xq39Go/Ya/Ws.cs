using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Ya
{
	// Token: 0x0200000E RID: 14
	[DesignerGenerated]
	public partial class Ws : Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000028EF File Offset: 0x00000AEF
		public Ws()
		{
			this.Fx();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004FDC File Offset: 0x000031DC
		[DebuggerNonUserCode]
		protected virtual void Xy(bool A_1)
		{
			try
			{
				bool flag = A_1 && this.J != null;
				if (flag)
				{
					this.J.Dispose();
				}
			}
			finally
			{
				base.Dispose(A_1);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000028FD File Offset: 0x00000AFD
		[DebuggerStepThrough]
		private void Fx()
		{
			this.J = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(800, 450);
			this.Text = "Form1";
		}

		// Token: 0x04000025 RID: 37
		private IContainer J;
	}
}
