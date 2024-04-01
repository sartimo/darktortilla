using System;
using System.Collections;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qd;
using r2WL;

namespace Tk1f
{
	// Token: 0x02000015 RID: 21
	public class q2B3
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00007EA0 File Offset: 0x000060A0
		private void e6SA(object A_1, EventArgs A_2)
		{
			bool flag = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "schedulerWindowLocation", new object[0], null, null, null), null, "X", new object[0], null, null, null), 0, false), Operators.CompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "schedulerWindowLocation", new object[0], null, null, null), null, "Y", new object[0], null, null, null), 0, false)), Operators.CompareObjectLess(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "schedulerWindowLocation", new object[0], null, null, null), null, "X", new object[0], null, null, null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Computer", new object[0], null, null, null), null, "Screen", new object[0], null, null, null), null, "WorkingArea", new object[0], null, null, null), null, "Right", new object[0], null, null, null), false)), Operators.CompareObjectLess(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "schedulerWindowLocation", new object[0], null, null, null), null, "Y", new object[0], null, null, null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Computer", new object[0], null, null, null), null, "Screen", new object[0], null, null, null), null, "WorkingArea", new object[0], null, null, null), null, "Height", new object[0], null, null, null), false)));
			if (flag)
			{
				this.H = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "schedulerWindowLocation", new object[0], null, null, null));
				this.V = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "schedulerWindowSize", new object[0], null, null, null));
			}
			this.k4E6(RuntimeHelpers.GetObjectValue(this.f), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "schedulerColumns", new object[0], null, null, null)));
			this.V = RuntimeHelpers.GetObjectValue(new object());
			NewLateBinding.LateCall(this.V, null, "Connect", new object[0], null, null, null, true);
			this.r = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.V, null, "GetFolder", new object[]
			{
				"\\"
			}, null, null, null));
			try
			{
				this.r = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.r, null, "GetFolder", new object[]
				{
					"Aquila Technology"
				}, null, null, null));
			}
			catch (Exception ex)
			{
				this.r = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.r, null, "CreateFolder", new object[]
				{
					"Aquila Technology"
				}, null, null, null));
			}
			try
			{
				this.r = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.r, null, "GetFolder", new object[]
				{
					"Wake On LAN"
				}, null, null, null));
			}
			catch (Exception ex2)
			{
				this.r = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.r, null, "CreateFolder", new object[]
				{
					"Wake On LAN"
				}, null, null, null));
			}
			this.Mo86();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002957 File Offset: 0x00000B57
		private void k4E6(object A_1, object A_2)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000082B0 File Offset: 0x000064B0
		private void Fp52(object A_1, FormClosingEventArgs A_2)
		{
			bool flag = this.D == FormWindowState.Normal;
			if (flag)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "schedulerColumns", new object[]
				{
					this.Ct95(RuntimeHelpers.GetObjectValue(this.f))
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "schedulerWindowLocation", new object[]
				{
					this.H
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "schedulerWindowSize", new object[]
				{
					this.V
				}, null, null, false, true);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00008388 File Offset: 0x00006588
		private object C
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000839C File Offset: 0x0000659C
		private void Mo86()
		{
			NewLateBinding.LateCall(this.V, null, "Stop", new object[0], null, null, null, true);
			object instance = this.r;
			Type type = null;
			string memberName = "GetTasks";
			object[] array = new object[1];
			int num = 0;
			object instance2 = this.W;
			array[num] = NewLateBinding.LateGet(instance2, null, "TASK_ENUM_HIDDEN", new object[0], null, null, null);
			object[] array2 = array;
			bool[] array3;
			object obj = NewLateBinding.LateGet(instance, type, memberName, array, null, null, array3 = new bool[]
			{
				true
			});
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "TASK_ENUM_HIDDEN", new object[]
				{
					array2[0]
				}, null, null, true, false);
			}
			object objectValue = RuntimeHelpers.GetObjectValue(obj);
			NewLateBinding.LateCall(this.f, null, "SuspendLayout", new object[0], null, null, null, true);
			object instance3 = this.f;
			NewLateBinding.LateCall(NewLateBinding.LateGet(instance3, null, "Items", new object[0], null, null, null), null, "Clear", new object[0], null, null, null, true);
			try
			{
				foreach (object obj2 in ((IEnumerable)objectValue))
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
					object instance4 = NewLateBinding.LateGet(instance3, null, "Items", new object[0], null, null, null);
					Type type2 = null;
					string memberName2 = "Add";
					object[] array4 = new object[1];
					int num2 = 0;
					instance2 = objectValue2;
					array4[num2] = NewLateBinding.LateGet(instance2, null, "Name", new object[0], null, null, null);
					array2 = array4;
					obj = NewLateBinding.LateGet(instance4, type2, memberName2, array4, null, null, array3 = new bool[]
					{
						true
					});
					if (array3[0])
					{
						NewLateBinding.LateSetComplex(instance2, null, "Name", new object[]
						{
							array2[0]
						}, null, null, true, false);
					}
					ListViewItem listViewItem = (ListViewItem)obj;
					listViewItem.ImageIndex = 0;
					listViewItem.SubItems.Add("");
					listViewItem.SubItems.Add("");
					listViewItem.SubItems.Add("");
					listViewItem.SubItems.Add("");
					listViewItem.SubItems.Add("");
					listViewItem.SubItems.Add("");
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
			this.w7YQ();
			NewLateBinding.LateCall(this.f, null, "ResumeLayout", new object[0], null, null, null, true);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000860C File Offset: 0x0000680C
		private string o5D4(int A_1)
		{
			string result;
			switch (A_1)
			{
			case 1:
				result = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_Disabled", new object[0], null, null, null));
				break;
			case 2:
				result = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_Queued", new object[0], null, null, null));
				break;
			case 3:
				result = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_Ready", new object[0], null, null, null));
				break;
			case 4:
				result = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_Running", new object[0], null, null, null));
				break;
			default:
				result = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_Unknown", new object[0], null, null, null));
				break;
			}
			return result;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000087BC File Offset: 0x000069BC
		private void z2LS(object A_1, EventArgs A_2)
		{
			try
			{
				foreach (object obj in ((IEnumerable)NewLateBinding.LateGet(this.f, null, "SelectedItems", new object[0], null, null, null)))
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					ListViewItem listViewItem2;
					object[] array;
					bool[] array2;
					object obj2 = NewLateBinding.LateGet(this.r, null, "GetTask", array = new object[]
					{
						(listViewItem2 = listViewItem).Text
					}, null, null, array2 = new bool[]
					{
						true
					});
					if (array2[0])
					{
						listViewItem2.Text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					object objectValue = RuntimeHelpers.GetObjectValue(obj2);
					NewLateBinding.LateCall(objectValue, null, "Run", new object[]
					{
						VariantType.Null
					}, null, null, null, true);
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
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000088C4 File Offset: 0x00006AC4
		private void Cc2y(object A_1, EventArgs A_2)
		{
			try
			{
				foreach (object obj in ((IEnumerable)NewLateBinding.LateGet(this.f, null, "SelectedItems", new object[0], null, null, null)))
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					ListViewItem listViewItem2;
					object[] array;
					bool[] array2;
					object obj2 = NewLateBinding.LateGet(this.r, null, "GetTask", array = new object[]
					{
						(listViewItem2 = listViewItem).Text
					}, null, null, array2 = new bool[]
					{
						true
					});
					if (array2[0])
					{
						listViewItem2.Text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					object objectValue = RuntimeHelpers.GetObjectValue(obj2);
					NewLateBinding.LateCall(objectValue, null, "Stop", new object[]
					{
						0
					}, null, null, null, true);
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
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000089CC File Offset: 0x00006BCC
		private void d0GQ(object A_1, EventArgs A_2)
		{
			try
			{
				foreach (object obj in ((IEnumerable)NewLateBinding.LateGet(this.f, null, "SelectedItems", new object[0], null, null, null)))
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					object instance = this.r;
					Type type = null;
					string memberName = "DeleteTask";
					ListViewItem listViewItem2;
					object[] array;
					object[] arguments = array = new object[]
					{
						(listViewItem2 = listViewItem).Text,
						0
					};
					string[] argumentNames = null;
					Type[] typeArguments = null;
					bool[] array2 = new bool[2];
					array2[0] = true;
					bool[] array3 = array2;
					NewLateBinding.LateCall(instance, type, memberName, arguments, argumentNames, typeArguments, array2, true);
					if (array3[0])
					{
						listViewItem2.Text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
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
			this.Mo86();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00008AB4 File Offset: 0x00006CB4
		private void Xe58(object A_1, EventArgs A_2)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(new object());
			this.Nw7j((Task)objectValue);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00008ADC File Offset: 0x00006CDC
		private void Dq30(object A_1, EventArgs A_2)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(new object());
			bool flag = Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(this.f, null, "SelectedItems", new object[0], null, null, null), null, "Count", new object[0], null, null, null), 1, false);
			if (!flag)
			{
				ListViewItem listViewItem = (ListViewItem)NewLateBinding.LateGet(this.f, null, "SelectedItems", new object[]
				{
					0
				}, null, null, null);
				ListViewItem listViewItem2;
				object[] array;
				bool[] array2;
				object obj = NewLateBinding.LateGet(this.r, null, "GetTask", array = new object[]
				{
					(listViewItem2 = listViewItem).Text
				}, null, null, array2 = new bool[]
				{
					true
				});
				if (array2[0])
				{
					listViewItem2.Text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
				object obj2 = NewLateBinding.LateGet(objectValue, null, "Deserialize", array = new object[]
				{
					NewLateBinding.LateGet(obj = NewLateBinding.LateGet(objectValue2, null, "Definition", new object[0], null, null, null), null, "Data", new object[0], null, null, null)
				}, null, null, array2 = new bool[]
				{
					true
				});
				if (array2[0])
				{
					NewLateBinding.LateSetComplex(obj, null, "Data", new object[]
					{
						array[0]
					}, null, null, true, true);
				}
				objectValue = RuntimeHelpers.GetObjectValue(obj2);
				bool flag2 = objectValue == null;
				if (!flag2)
				{
					this.Nw7j((Task)objectValue);
				}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00008C6C File Offset: 0x00006E6C
		private bool Nw7j(Task A_1)
		{
			bool result = false;
			object objectValue = RuntimeHelpers.GetObjectValue(new object());
			object obj;
			string text = "-p " + this.i6FA(Conversions.ToString(NewLateBinding.LateGet(obj, null, "GetFile", new object[0], null, null, null)));
			object[] array;
			bool[] array2;
			object obj2 = NewLateBinding.LateGet(this.c, null, "ShowDialog", array = new object[]
			{
				this,
				A_1
			}, null, null, array2 = new bool[]
			{
				default(bool),
				true
			});
			if (array2[1])
			{
				A_1 = (Task)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(Task));
			}
			bool flag = Operators.ConditionalCompareObjectEqual(obj2, DialogResult.OK, false);
			if (flag)
			{
				string text2 = this.i6FA("C:\\Projects\\WakeOnLan\\Console\\WakeOnLanC\\bin\\Debug\\WakeOnLANc.exe");
				try
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.V, null, "NewTask", new object[]
					{
						0
					}, null, null, null));
					object instance = objectValue2;
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(instance, null, "RegistrationInfo", new object[0], null, null, null), null, "Author", new object[]
					{
						NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "User", new object[0], null, null, null), null, "Name", new object[0], null, null, null)
					}, null, null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(instance, null, "RegistrationInfo", new object[0], null, null, null), null, "Description", new object[]
					{
						NewLateBinding.LateGet(obj, null, "Description", new object[0], null, null, null)
					}, null, null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(instance, null, "Settings", new object[0], null, null, null), null, "MultipleInstances", new object[]
					{
						NewLateBinding.LateGet(this.D, null, "TASK_INSTANCES_STOP_EXISTING", new object[0], null, null, null)
					}, null, null, false, true);
					object obj4;
					try
					{
						foreach (object obj3 in ((IEnumerable)NewLateBinding.LateGet(obj, null, "Triggers", new object[0], null, null, null)))
						{
							object objectValue3 = RuntimeHelpers.GetObjectValue(obj3);
							object left = NewLateBinding.LateGet(objectValue3, null, "Mode", new object[0], null, null, null);
							bool flag2 = Operators.ConditionalCompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.l, null, "TriggerModes", new object[0], null, null, null), null, "OneTime", new object[0], null, null, null), false);
							if (flag2)
							{
								object instance2 = NewLateBinding.LateGet(instance, null, "Triggers", new object[0], null, null, null);
								Type type = null;
								string memberName = "Create";
								object[] array3 = new object[1];
								int num = 0;
								obj2 = this.T;
								array3[num] = NewLateBinding.LateGet(obj2, null, "TASK_TRIGGER_TIME", new object[0], null, null, null);
								array = array3;
								obj4 = NewLateBinding.LateGet(instance2, type, memberName, array3, null, null, array2 = new bool[]
								{
									true
								});
								if (array2[0])
								{
									NewLateBinding.LateSetComplex(obj2, null, "TASK_TRIGGER_TIME", new object[]
									{
										array[0]
									}, null, null, true, false);
								}
								object objectValue4 = RuntimeHelpers.GetObjectValue(obj4);
								object instance3 = objectValue4;
								NewLateBinding.LateSet(instance3, null, "Id", new object[]
								{
									NewLateBinding.LateGet(objectValue3, null, "Tag", new object[0], null, null, null)
								}, null, null);
								NewLateBinding.LateSet(instance3, null, "StartBoundary", new object[]
								{
									NewLateBinding.LateGet(objectValue3, null, "StartBoundary", new object[0], null, null, null).ToString()[Conversions.ToInteger("o")]
								}, null, null);
								NewLateBinding.LateSet(instance3, null, "Enabled", new object[]
								{
									NewLateBinding.LateGet(objectValue3, null, "Enabled", new object[0], null, null, null)
								}, null, null);
							}
							else
							{
								flag2 = Operators.ConditionalCompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.l, null, "TriggerModes", new object[0], null, null, null), null, "Daily", new object[0], null, null, null), false);
								if (flag2)
								{
									object instance4 = NewLateBinding.LateGet(instance, null, "Triggers", new object[0], null, null, null);
									Type type2 = null;
									string memberName2 = "Create";
									object[] array4 = new object[1];
									int num2 = 0;
									obj2 = this.T;
									array4[num2] = NewLateBinding.LateGet(obj2, null, "TASK_TRIGGER_DAILY", new object[0], null, null, null);
									array = array4;
									obj4 = NewLateBinding.LateGet(instance4, type2, memberName2, array4, null, null, array2 = new bool[]
									{
										true
									});
									if (array2[0])
									{
										NewLateBinding.LateSetComplex(obj2, null, "TASK_TRIGGER_DAILY", new object[]
										{
											array[0]
										}, null, null, true, false);
									}
									object objectValue5 = RuntimeHelpers.GetObjectValue(obj4);
									object instance5 = objectValue5;
									NewLateBinding.LateSet(instance5, null, "Id", new object[]
									{
										NewLateBinding.LateGet(objectValue3, null, "Tag", new object[0], null, null, null)
									}, null, null);
									NewLateBinding.LateSet(instance5, null, "StartBoundary", new object[]
									{
										NewLateBinding.LateGet(objectValue3, null, "StartBoundary", new object[0], null, null, null).ToString()[Conversions.ToInteger("o")]
									}, null, null);
									NewLateBinding.LateSet(instance5, null, "DaysInterval", new object[]
									{
										NewLateBinding.LateGet(objectValue3, null, "DailyRecurs", new object[0], null, null, null)
									}, null, null);
									NewLateBinding.LateSet(instance5, null, "Enabled", new object[]
									{
										NewLateBinding.LateGet(objectValue3, null, "Enabled", new object[0], null, null, null)
									}, null, null);
								}
								else
								{
									flag2 = Operators.ConditionalCompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(this.l, null, "TriggerModes", new object[0], null, null, null), null, "Weekly", new object[0], null, null, null), false);
									if (flag2)
									{
										object instance6 = NewLateBinding.LateGet(instance, null, "Triggers", new object[0], null, null, null);
										Type type3 = null;
										string memberName3 = "Create";
										object[] array5 = new object[1];
										int num3 = 0;
										obj2 = this.T;
										array5[num3] = NewLateBinding.LateGet(obj2, null, "TASK_TRIGGER_WEEKLY", new object[0], null, null, null);
										array = array5;
										obj4 = NewLateBinding.LateGet(instance6, type3, memberName3, array5, null, null, array2 = new bool[]
										{
											true
										});
										if (array2[0])
										{
											NewLateBinding.LateSetComplex(obj2, null, "TASK_TRIGGER_WEEKLY", new object[]
											{
												array[0]
											}, null, null, true, false);
										}
										object objectValue6 = RuntimeHelpers.GetObjectValue(obj4);
										object instance7 = objectValue6;
										NewLateBinding.LateSet(instance7, null, "Id", new object[]
										{
											NewLateBinding.LateGet(objectValue3, null, "Tag", new object[0], null, null, null)
										}, null, null);
										NewLateBinding.LateSet(instance7, null, "StartBoundary", new object[]
										{
											NewLateBinding.LateGet(objectValue3, null, "StartBoundary", new object[0], null, null, null).ToString()[Conversions.ToInteger("o")]
										}, null, null);
										NewLateBinding.LateSet(instance7, null, "WeeksInterval", new object[]
										{
											NewLateBinding.LateGet(objectValue3, null, "WeeklyRecurs", new object[0], null, null, null)
										}, null, null);
										NewLateBinding.LateSet(instance7, null, "DaysOfWeek", new object[]
										{
											NewLateBinding.LateGet(objectValue3, null, "WeeklyDaysOfWeek", new object[0], null, null, null)
										}, null, null);
										NewLateBinding.LateSet(instance7, null, "Enabled", new object[]
										{
											NewLateBinding.LateGet(objectValue3, null, "Enabled", new object[0], null, null, null)
										}, null, null);
									}
								}
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
					try
					{
						foreach (object obj5 in ((IEnumerable)NewLateBinding.LateGet(obj, null, "Actions", new object[0], null, null, null)))
						{
							Action action = (Action)obj5;
							object h = this.H;
							bool flag3 = Operators.ConditionalCompareObjectEqual(h, NewLateBinding.LateGet(NewLateBinding.LateGet(this.H, null, "ActionItems", new object[0], null, null, null), null, "Start", new object[0], null, null, null), false);
							if (flag3)
							{
								object instance8 = NewLateBinding.LateGet(instance, null, "Actions", new object[0], null, null, null);
								Type type4 = null;
								string memberName4 = "Create";
								object[] array6 = new object[1];
								int num4 = 0;
								obj2 = this.b;
								array6[num4] = NewLateBinding.LateGet(obj2, null, "TASK_ACTION_EXEC", new object[0], null, null, null);
								array = array6;
								obj4 = NewLateBinding.LateGet(instance8, type4, memberName4, array6, null, null, array2 = new bool[]
								{
									true
								});
								if (array2[0])
								{
									NewLateBinding.LateSetComplex(obj2, null, "TASK_ACTION_EXEC", new object[]
									{
										array[0]
									}, null, null, true, false);
								}
								object objectValue7 = RuntimeHelpers.GetObjectValue(obj4);
								object objectValue8 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, new object[]
								{
									NewLateBinding.LateGet(this.H, null, "Name", new object[0], null, null, null)
								}, null));
								object instance9 = objectValue7;
								NewLateBinding.LateSet(instance9, null, "Id", new object[]
								{
									NewLateBinding.LateGet(this.H, null, "Tag", new object[0], null, null, null)
								}, null, null);
								NewLateBinding.LateSet(instance9, null, "Path", new object[]
								{
									text2
								}, null, null);
								NewLateBinding.LateSet(instance9, null, "Arguments", new object[]
								{
									text + " -w -m " + this.i6FA(Conversions.ToString(NewLateBinding.LateGet(objectValue8, null, "Name", new object[0], null, null, null)))
								}, null, null);
							}
							else
							{
								flag3 = Operators.ConditionalCompareObjectEqual(h, NewLateBinding.LateGet(NewLateBinding.LateGet(this.H, null, "ActionItems", new object[0], null, null, null), null, "StartGroup", new object[0], null, null, null), false);
								if (flag3)
								{
									object instance10 = NewLateBinding.LateGet(instance, null, "Actions", new object[0], null, null, null);
									Type type5 = null;
									string memberName5 = "Create";
									object[] array7 = new object[1];
									int num5 = 0;
									obj2 = this.b;
									array7[num5] = NewLateBinding.LateGet(obj2, null, "TASK_ACTION_EXEC", new object[0], null, null, null);
									array = array7;
									obj4 = NewLateBinding.LateGet(instance10, type5, memberName5, array7, null, null, array2 = new bool[]
									{
										true
									});
									if (array2[0])
									{
										NewLateBinding.LateSetComplex(obj2, null, "TASK_ACTION_EXEC", new object[]
										{
											array[0]
										}, null, null, true, false);
									}
									object objectValue9 = RuntimeHelpers.GetObjectValue(obj4);
									object instance11 = objectValue9;
									NewLateBinding.LateSet(instance11, null, "Id", new object[]
									{
										NewLateBinding.LateGet(this.H, null, "Tag", new object[0], null, null, null)
									}, null, null);
									NewLateBinding.LateSet(instance11, null, "Path", new object[]
									{
										text2
									}, null, null);
									NewLateBinding.LateSet(instance11, null, "Arguments", new object[]
									{
										text + " -w -g " + this.i6FA(Conversions.ToString(NewLateBinding.LateGet(this.H, null, "Name", new object[0], null, null, null)))
									}, null, null);
								}
								else
								{
									flag3 = Operators.ConditionalCompareObjectEqual(h, NewLateBinding.LateGet(NewLateBinding.LateGet(this.H, null, "ActionItems", new object[0], null, null, null), null, "StartAll", new object[0], null, null, null), false);
									if (flag3)
									{
										object instance12 = NewLateBinding.LateGet(instance, null, "Actions", new object[0], null, null, null);
										Type type6 = null;
										string memberName6 = "Create";
										object[] array8 = new object[1];
										int num6 = 0;
										obj2 = this.b;
										array8[num6] = NewLateBinding.LateGet(obj2, null, "TASK_ACTION_EXEC", new object[0], null, null, null);
										array = array8;
										obj4 = NewLateBinding.LateGet(instance12, type6, memberName6, array8, null, null, array2 = new bool[]
										{
											true
										});
										if (array2[0])
										{
											NewLateBinding.LateSetComplex(obj2, null, "TASK_ACTION_EXEC", new object[]
											{
												array[0]
											}, null, null, true, false);
										}
										object objectValue10 = RuntimeHelpers.GetObjectValue(obj4);
										object instance13 = objectValue10;
										NewLateBinding.LateSet(instance13, null, "Id", new object[]
										{
											NewLateBinding.LateGet(this.H, null, "Tag", new object[0], null, null, null)
										}, null, null);
										NewLateBinding.LateSet(instance13, null, "Path", new object[]
										{
											text2
										}, null, null);
										NewLateBinding.LateSet(instance13, null, "Arguments", new object[]
										{
											text + " -w -all"
										}, null, null);
									}
									else
									{
										flag3 = Operators.ConditionalCompareObjectEqual(h, NewLateBinding.LateGet(NewLateBinding.LateGet(this.H, null, "ActionItems", new object[0], null, null, null), null, "Shutdown", new object[0], null, null, null), false);
										if (flag3)
										{
											object instance14 = NewLateBinding.LateGet(instance, null, "Actions", new object[0], null, null, null);
											Type type7 = null;
											string memberName7 = "Create";
											object[] array9 = new object[1];
											int num7 = 0;
											obj2 = this.b;
											array9[num7] = NewLateBinding.LateGet(obj2, null, "TASK_ACTION_EXEC", new object[0], null, null, null);
											array = array9;
											obj4 = NewLateBinding.LateGet(instance14, type7, memberName7, array9, null, null, array2 = new bool[]
											{
												true
											});
											if (array2[0])
											{
												NewLateBinding.LateSetComplex(obj2, null, "TASK_ACTION_EXEC", new object[]
												{
													array[0]
												}, null, null, true, false);
											}
											object objectValue11 = RuntimeHelpers.GetObjectValue(obj4);
											object objectValue8 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, new object[]
											{
												NewLateBinding.LateGet(this.H, null, "Name", new object[0], null, null, null)
											}, null));
											object obj6 = objectValue11;
											NewLateBinding.LateSet(obj6, null, "Id", new object[]
											{
												NewLateBinding.LateGet(this.H, null, "Tag", new object[0], null, null, null)
											}, null, null);
											NewLateBinding.LateSet(obj6, null, "Path", new object[]
											{
												text2
											}, null, null);
											NewLateBinding.LateSet(obj6, null, "Arguments", new object[]
											{
												Operators.ConcatenateObject(text + " -s -m " + this.i6FA(Conversions.ToString(NewLateBinding.LateGet(objectValue8, null, "Name", new object[0], null, null, null))) + " -t ", NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "DefaultTimeout", new object[0], null, null, null))
											}, null, null);
											bool flag4 = Conversions.ToBoolean(NewLateBinding.LateGet(this.H, null, "Force", new object[0], null, null, null));
											if (flag4)
											{
												obj2 = obj6;
												NewLateBinding.LateSet(obj2, null, "Arguments", new object[]
												{
													Operators.ConcatenateObject(NewLateBinding.LateGet(obj2, null, "Arguments", new object[0], null, null, null), " -f")
												}, null, null);
											}
											bool flag5 = Conversions.ToBoolean(NewLateBinding.LateGet(this.H, null, "Reboot", new object[0], null, null, null));
											if (flag5)
											{
												obj2 = obj6;
												NewLateBinding.LateSet(obj2, null, "Arguments", new object[]
												{
													Operators.ConcatenateObject(NewLateBinding.LateGet(obj2, null, "Arguments", new object[0], null, null, null), " -r")
												}, null, null);
											}
										}
										else
										{
											flag3 = Operators.ConditionalCompareObjectEqual(h, NewLateBinding.LateGet(NewLateBinding.LateGet(this.H, null, "ActionItems", new object[0], null, null, null), null, "Sleep", new object[0], null, null, null), false);
											if (flag3)
											{
												object instance15 = NewLateBinding.LateGet(instance, null, "Actions", new object[0], null, null, null);
												Type type8 = null;
												string memberName8 = "Create";
												object[] array10 = new object[1];
												int num8 = 0;
												obj2 = this.b;
												array10[num8] = NewLateBinding.LateGet(obj2, null, "TASK_ACTION_EXEC", new object[0], null, null, null);
												array = array10;
												obj4 = NewLateBinding.LateGet(instance15, type8, memberName8, array10, null, null, array2 = new bool[]
												{
													true
												});
												if (array2[0])
												{
													NewLateBinding.LateSetComplex(obj2, null, "TASK_ACTION_EXEC", new object[]
													{
														array[0]
													}, null, null, true, false);
												}
												object objectValue12 = RuntimeHelpers.GetObjectValue(obj4);
												object objectValue8 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, new object[]
												{
													NewLateBinding.LateGet(this.H, null, "Name", new object[0], null, null, null)
												}, null));
												object obj7 = objectValue12;
												NewLateBinding.LateSet(obj7, null, "Id", new object[]
												{
													NewLateBinding.LateGet(this.H, null, "Tag", new object[0], null, null, null)
												}, null, null);
												NewLateBinding.LateSet(obj7, null, "Path", new object[]
												{
													text2
												}, null, null);
												NewLateBinding.LateSet(obj7, null, "Arguments", new object[]
												{
													Operators.ConcatenateObject(text + " -s1 -m " + this.i6FA(Conversions.ToString(NewLateBinding.LateGet(objectValue8, null, "Name", new object[0], null, null, null))) + " -t ", NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "DefaultTimeout", new object[0], null, null, null))
												}, null, null);
												bool flag6 = Conversions.ToBoolean(NewLateBinding.LateGet(this.H, null, "Force", new object[0], null, null, null));
												if (flag6)
												{
													obj2 = obj7;
													NewLateBinding.LateSet(obj2, null, "Arguments", new object[]
													{
														Operators.ConcatenateObject(NewLateBinding.LateGet(obj2, null, "Arguments", new object[0], null, null, null), " -f")
													}, null, null);
												}
											}
											else
											{
												flag3 = Operators.ConditionalCompareObjectEqual(h, NewLateBinding.LateGet(NewLateBinding.LateGet(this.H, null, "ActionItems", new object[0], null, null, null), null, "Hibernate", new object[0], null, null, null), false);
												if (flag3)
												{
													object instance16 = NewLateBinding.LateGet(instance, null, "Actions", new object[0], null, null, null);
													Type type9 = null;
													string memberName9 = "Create";
													object[] array11 = new object[1];
													int num9 = 0;
													obj2 = this.b;
													array11[num9] = NewLateBinding.LateGet(obj2, null, "TASK_ACTION_EXEC", new object[0], null, null, null);
													array = array11;
													obj4 = NewLateBinding.LateGet(instance16, type9, memberName9, array11, null, null, array2 = new bool[]
													{
														true
													});
													if (array2[0])
													{
														NewLateBinding.LateSetComplex(obj2, null, "TASK_ACTION_EXEC", new object[]
														{
															array[0]
														}, null, null, true, false);
													}
													object objectValue13 = RuntimeHelpers.GetObjectValue(obj4);
													object objectValue8 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, new object[]
													{
														NewLateBinding.LateGet(this.H, null, "Name", new object[0], null, null, null)
													}, null));
													object obj8 = objectValue13;
													NewLateBinding.LateSet(obj8, null, "Id", new object[]
													{
														NewLateBinding.LateGet(this.H, null, "Tag", new object[0], null, null, null)
													}, null, null);
													NewLateBinding.LateSet(obj8, null, "Path", new object[]
													{
														text2
													}, null, null);
													NewLateBinding.LateSet(obj8, null, "Arguments", new object[]
													{
														Operators.ConcatenateObject(text + " -s4 -m " + this.i6FA(Conversions.ToString(NewLateBinding.LateGet(objectValue8, null, "Name", new object[0], null, null, null))) + " -t ", NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "DefaultTimeout", new object[0], null, null, null))
													}, null, null);
													bool flag7 = Conversions.ToBoolean(NewLateBinding.LateGet(this.H, null, "Force", new object[0], null, null, null));
													if (flag7)
													{
														obj2 = obj8;
														NewLateBinding.LateSet(obj2, null, "Arguments", new object[]
														{
															Operators.ConcatenateObject(NewLateBinding.LateGet(obj2, null, "Arguments", new object[0], null, null, null), " -f")
														}, null, null);
													}
												}
												else
												{
													flag3 = Operators.ConditionalCompareObjectEqual(h, NewLateBinding.LateGet(NewLateBinding.LateGet(this.H, null, "ActionItems", new object[0], null, null, null), null, "ShutdownGroup", new object[0], null, null, null), false);
													if (flag3)
													{
														object instance17 = NewLateBinding.LateGet(instance, null, "Actions", new object[0], null, null, null);
														Type type10 = null;
														string memberName10 = "Create";
														object[] array12 = new object[1];
														int num10 = 0;
														obj2 = this.b;
														array12[num10] = NewLateBinding.LateGet(obj2, null, "TASK_ACTION_EXEC", new object[0], null, null, null);
														array = array12;
														obj4 = NewLateBinding.LateGet(instance17, type10, memberName10, array12, null, null, array2 = new bool[]
														{
															true
														});
														if (array2[0])
														{
															NewLateBinding.LateSetComplex(obj2, null, "TASK_ACTION_EXEC", new object[]
															{
																array[0]
															}, null, null, true, false);
														}
														object objectValue14 = RuntimeHelpers.GetObjectValue(obj4);
														object obj9 = objectValue14;
														NewLateBinding.LateSet(obj9, null, "Id", new object[]
														{
															NewLateBinding.LateGet(this.H, null, "Tag", new object[0], null, null, null)
														}, null, null);
														NewLateBinding.LateSet(obj9, null, "Path", new object[]
														{
															text2
														}, null, null);
														NewLateBinding.LateSet(obj9, null, "Arguments", new object[]
														{
															Operators.ConcatenateObject(text + " -s -g " + this.i6FA(Conversions.ToString(NewLateBinding.LateGet(this.H, null, "Name", new object[0], null, null, null))) + " -t ", NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "DefaultTimeout", new object[0], null, null, null))
														}, null, null);
														bool flag8 = Conversions.ToBoolean(NewLateBinding.LateGet(this.H, null, "Force", new object[0], null, null, null));
														if (flag8)
														{
															obj2 = obj9;
															NewLateBinding.LateSet(obj2, null, "Arguments", new object[]
															{
																Operators.ConcatenateObject(NewLateBinding.LateGet(obj2, null, "Arguments", new object[0], null, null, null), " -f")
															}, null, null);
														}
														bool flag9 = Conversions.ToBoolean(NewLateBinding.LateGet(this.H, null, "Reboot", new object[0], null, null, null));
														if (flag9)
														{
															obj2 = obj9;
															NewLateBinding.LateSet(obj2, null, "Arguments", new object[]
															{
																Operators.ConcatenateObject(NewLateBinding.LateGet(obj2, null, "Arguments", new object[0], null, null, null), " -r")
															}, null, null);
														}
													}
													else
													{
														flag3 = Operators.ConditionalCompareObjectEqual(h, NewLateBinding.LateGet(NewLateBinding.LateGet(this.H, null, "ActionItems", new object[0], null, null, null), null, "ShutdownAll", new object[0], null, null, null), false);
														if (flag3)
														{
															object instance18 = NewLateBinding.LateGet(instance, null, "Actions", new object[0], null, null, null);
															Type type11 = null;
															string memberName11 = "Create";
															object[] array13 = new object[1];
															int num11 = 0;
															obj2 = this.b;
															array13[num11] = NewLateBinding.LateGet(obj2, null, "TASK_ACTION_EXEC", new object[0], null, null, null);
															array = array13;
															obj4 = NewLateBinding.LateGet(instance18, type11, memberName11, array13, null, null, array2 = new bool[]
															{
																true
															});
															if (array2[0])
															{
																NewLateBinding.LateSetComplex(obj2, null, "TASK_ACTION_EXEC", new object[]
																{
																	array[0]
																}, null, null, true, false);
															}
															object objectValue15 = RuntimeHelpers.GetObjectValue(obj4);
															object obj10 = objectValue15;
															NewLateBinding.LateSet(obj10, null, "Id", new object[]
															{
																NewLateBinding.LateGet(this.H, null, "Tag", new object[0], null, null, null)
															}, null, null);
															NewLateBinding.LateSet(obj10, null, "Path", new object[]
															{
																text2
															}, null, null);
															NewLateBinding.LateSet(obj10, null, "Arguments", new object[]
															{
																Operators.ConcatenateObject(text + " -s -all -t ", NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "DefaultTimeout", new object[0], null, null, null))
															}, null, null);
															bool flag10 = Conversions.ToBoolean(NewLateBinding.LateGet(this.H, null, "Force", new object[0], null, null, null));
															if (flag10)
															{
																obj2 = obj10;
																NewLateBinding.LateSet(obj2, null, "Arguments", new object[]
																{
																	Operators.ConcatenateObject(NewLateBinding.LateGet(obj2, null, "Arguments", new object[0], null, null, null), " -f")
																}, null, null);
															}
															bool flag11 = Conversions.ToBoolean(NewLateBinding.LateGet(this.H, null, "Reboot", new object[0], null, null, null));
															if (flag11)
															{
																obj2 = obj10;
																NewLateBinding.LateSet(obj2, null, "Arguments", new object[]
																{
																	Operators.ConcatenateObject(NewLateBinding.LateGet(obj2, null, "Arguments", new object[0], null, null, null), " -r")
																}, null, null);
															}
														}
														else
														{
															flag3 = Operators.ConditionalCompareObjectEqual(h, NewLateBinding.LateGet(NewLateBinding.LateGet(this.H, null, "ActionItems", new object[0], null, null, null), null, "SleepAll", new object[0], null, null, null), false);
															if (flag3)
															{
																object instance19 = NewLateBinding.LateGet(instance, null, "Actions", new object[0], null, null, null);
																Type type12 = null;
																string memberName12 = "Create";
																object[] array14 = new object[1];
																int num12 = 0;
																obj2 = this.b;
																array14[num12] = NewLateBinding.LateGet(obj2, null, "TASK_ACTION_EXEC", new object[0], null, null, null);
																array = array14;
																obj4 = NewLateBinding.LateGet(instance19, type12, memberName12, array14, null, null, array2 = new bool[]
																{
																	true
																});
																if (array2[0])
																{
																	NewLateBinding.LateSetComplex(obj2, null, "TASK_ACTION_EXEC", new object[]
																	{
																		array[0]
																	}, null, null, true, false);
																}
																object objectValue16 = RuntimeHelpers.GetObjectValue(obj4);
																object obj11 = objectValue16;
																NewLateBinding.LateSet(obj11, null, "Id", new object[]
																{
																	NewLateBinding.LateGet(this.H, null, "Tag", new object[0], null, null, null)
																}, null, null);
																NewLateBinding.LateSet(obj11, null, "Path", new object[]
																{
																	text2
																}, null, null);
																NewLateBinding.LateSet(obj11, null, "Arguments", new object[]
																{
																	Operators.ConcatenateObject(text + " -s1 -all -t ", NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "DefaultTimeout", new object[0], null, null, null))
																}, null, null);
																bool flag12 = Conversions.ToBoolean(NewLateBinding.LateGet(this.H, null, "Force", new object[0], null, null, null));
																if (flag12)
																{
																	obj2 = obj11;
																	NewLateBinding.LateSet(obj2, null, "Arguments", new object[]
																	{
																		Operators.ConcatenateObject(NewLateBinding.LateGet(obj2, null, "Arguments", new object[0], null, null, null), " -f")
																	}, null, null);
																}
															}
															else
															{
																flag3 = Operators.ConditionalCompareObjectEqual(h, NewLateBinding.LateGet(NewLateBinding.LateGet(this.H, null, "ActionItems", new object[0], null, null, null), null, "HibernateAll", new object[0], null, null, null), false);
																if (flag3)
																{
																	object instance20 = NewLateBinding.LateGet(instance, null, "Actions", new object[0], null, null, null);
																	Type type13 = null;
																	string memberName13 = "Create";
																	object[] array15 = new object[1];
																	int num13 = 0;
																	obj2 = this.b;
																	array15[num13] = NewLateBinding.LateGet(obj2, null, "TASK_ACTION_EXEC", new object[0], null, null, null);
																	array = array15;
																	obj4 = NewLateBinding.LateGet(instance20, type13, memberName13, array15, null, null, array2 = new bool[]
																	{
																		true
																	});
																	if (array2[0])
																	{
																		NewLateBinding.LateSetComplex(obj2, null, "TASK_ACTION_EXEC", new object[]
																		{
																			array[0]
																		}, null, null, true, false);
																	}
																	object objectValue17 = RuntimeHelpers.GetObjectValue(obj4);
																	object obj12 = objectValue17;
																	NewLateBinding.LateSet(obj12, null, "Id", new object[]
																	{
																		NewLateBinding.LateGet(this.H, null, "Tag", new object[0], null, null, null)
																	}, null, null);
																	NewLateBinding.LateSet(obj12, null, "Path", new object[]
																	{
																		text2
																	}, null, null);
																	NewLateBinding.LateSet(obj12, null, "Arguments", new object[]
																	{
																		Operators.ConcatenateObject(text + " -s4 -all -t ", NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "DefaultTimeout", new object[0], null, null, null))
																	}, null, null);
																	bool flag13 = Conversions.ToBoolean(NewLateBinding.LateGet(this.H, null, "Force", new object[0], null, null, null));
																	if (flag13)
																	{
																		obj2 = obj12;
																		NewLateBinding.LateSet(obj2, null, "Arguments", new object[]
																		{
																			Operators.ConcatenateObject(NewLateBinding.LateGet(obj2, null, "Arguments", new object[0], null, null, null), " -f")
																		}, null, null);
																	}
																}
																else
																{
																	flag3 = Operators.ConditionalCompareObjectEqual(h, NewLateBinding.LateGet(NewLateBinding.LateGet(this.H, null, "ActionItems", new object[0], null, null, null), null, "SendMessage", new object[0], null, null, null), false);
																	if (flag3)
																	{
																		object instance21 = NewLateBinding.LateGet(instance, null, "Actions", new object[0], null, null, null);
																		Type type14 = null;
																		string memberName14 = "Create";
																		object[] array16 = new object[1];
																		int num14 = 0;
																		obj2 = this.b;
																		array16[num14] = NewLateBinding.LateGet(obj2, null, "TASK_ACTION_EXEC", new object[0], null, null, null);
																		array = array16;
																		obj4 = NewLateBinding.LateGet(instance21, type14, memberName14, array16, null, null, array2 = new bool[]
																		{
																			true
																		});
																		if (array2[0])
																		{
																			NewLateBinding.LateSetComplex(obj2, null, "TASK_ACTION_EXEC", new object[]
																			{
																				array[0]
																			}, null, null, true, false);
																		}
																		object objectValue18 = RuntimeHelpers.GetObjectValue(obj4);
																		object objectValue8 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, new object[]
																		{
																			NewLateBinding.LateGet(this.H, null, "Name", new object[0], null, null, null)
																		}, null));
																		bool flag14 = objectValue8 == null;
																		if (flag14)
																		{
																			NewLateBinding.LateCall(null, typeof(MessageBox), "Show", new object[]
																			{
																				Operators.AddObject("Unable to locate host ", NewLateBinding.LateGet(this.H, null, "Name", new object[0], null, null, null)),
																				"Task Scheduler"
																			}, null, null, null, true);
																		}
																		else
																		{
																			object instance22 = objectValue18;
																			NewLateBinding.LateSet(instance22, null, "Id", new object[]
																			{
																				NewLateBinding.LateGet(this.H, null, "Tag", new object[0], null, null, null)
																			}, null, null);
																			NewLateBinding.LateSet(instance22, null, "Path", new object[]
																			{
																				text2
																			}, null, null);
																			NewLateBinding.LateSet(instance22, null, "Arguments", new object[]
																			{
																				string.Concat(new string[]
																				{
																					text,
																					" -m ",
																					this.i6FA(Conversions.ToString(NewLateBinding.LateGet(objectValue8, null, "Name", new object[0], null, null, null))),
																					" -msg -c ",
																					this.i6FA(Conversions.ToString(NewLateBinding.LateGet(this.H, null, "MessageText", new object[0], null, null, null)))
																				})
																			}, null, null);
																		}
																	}
																	else
																	{
																		flag3 = Operators.ConditionalCompareObjectEqual(h, NewLateBinding.LateGet(NewLateBinding.LateGet(this.H, null, "ActionItems", new object[0], null, null, null), null, "SendEmail", new object[0], null, null, null), false);
																		if (flag3)
																		{
																			object instance23 = NewLateBinding.LateGet(instance, null, "Actions", new object[0], null, null, null);
																			Type type15 = null;
																			string memberName15 = "Create";
																			object[] array17 = new object[1];
																			int num15 = 0;
																			obj2 = this.b;
																			array17[num15] = NewLateBinding.LateGet(obj2, null, "TASK_ACTION_SEND_EMAIL", new object[0], null, null, null);
																			array = array17;
																			obj4 = NewLateBinding.LateGet(instance23, type15, memberName15, array17, null, null, array2 = new bool[]
																			{
																				true
																			});
																			if (array2[0])
																			{
																				NewLateBinding.LateSetComplex(obj2, null, "TASK_ACTION_SEND_EMAIL", new object[]
																				{
																					array[0]
																				}, null, null, true, false);
																			}
																			object objectValue19 = RuntimeHelpers.GetObjectValue(obj4);
																			object instance24 = objectValue19;
																			NewLateBinding.LateSet(instance24, null, "Id", new object[]
																			{
																				NewLateBinding.LateGet(this.H, null, "Tag", new object[0], null, null, null)
																			}, null, null);
																			NewLateBinding.LateSet(instance24, null, "From", new object[]
																			{
																				NewLateBinding.LateGet(this.H, null, "EmailFrom", new object[0], null, null, null)
																			}, null, null);
																			NewLateBinding.LateSet(instance24, null, "To", new object[]
																			{
																				NewLateBinding.LateGet(this.H, null, "EmailTo", new object[0], null, null, null)
																			}, null, null);
																			NewLateBinding.LateSet(instance24, null, "Subject", new object[]
																			{
																				NewLateBinding.LateGet(this.H, null, "EmailSubject", new object[0], null, null, null)
																			}, null, null);
																			NewLateBinding.LateSet(instance24, null, "Server", new object[]
																			{
																				NewLateBinding.LateGet(this.H, null, "EmailServer", new object[0], null, null, null)
																			}, null, null);
																			NewLateBinding.LateSet(instance24, null, "Body", new object[]
																			{
																				NewLateBinding.LateGet(this.H, null, "EmailText", new object[0], null, null, null)
																			}, null, null);
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					instance = null;
					NewLateBinding.LateSet(objectValue2, null, "Data", new object[]
					{
						NewLateBinding.LateGet(obj, null, "Serialize", new object[0], null, null, null)
					}, null, null);
					object instance25 = this.r;
					Type type16 = null;
					string memberName16 = "RegisterTaskDefinition";
					object[] array18 = new object[7];
					int num16 = 0;
					obj2 = obj;
					array18[num16] = NewLateBinding.LateGet(obj2, null, "Name", new object[0], null, null, null);
					array18[1] = objectValue2;
					int num17 = 2;
					obj4 = this.G;
					array18[num17] = NewLateBinding.LateGet(obj4, null, "TASK_CREATE_OR_UPDATE", new object[0], null, null, null);
					object instance26;
					array18[3] = NewLateBinding.LateGet(instance26 = NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "TaskUserID", new object[0], null, null, null);
					int num18 = 4;
					object obj13 = objectValue;
					object instance27 = obj13;
					Type type17 = null;
					string memberName17 = "Decrypt";
					object[] array19 = new object[1];
					object instance28;
					object obj14 = array19[0] = NewLateBinding.LateGet(instance28 = NewLateBinding.LateGet(this.V, null, "Settings", new object[0], null, null, null), null, "TaskPassword", new object[0], null, null, null);
					object[] array20 = array19;
					bool[] array21;
					object obj15 = NewLateBinding.LateGet(instance27, type17, memberName17, array19, null, null, array21 = new bool[]
					{
						true
					});
					if (array21[0])
					{
						NewLateBinding.LateSetComplex(instance28, null, "TaskPassword", new object[]
						{
							array20[0]
						}, null, null, true, true);
					}
					array18[num18] = obj15;
					int num19 = 5;
					object p = this.P;
					array18[num19] = NewLateBinding.LateGet(p, null, "TASK_LOGON_PASSWORD", new object[0], null, null, null);
					array18[6] = "";
					array = array18;
					NewLateBinding.LateCall(instance25, type16, memberName16, array18, null, null, array2 = new bool[]
					{
						true,
						true,
						true,
						true,
						true,
						true,
						false
					}, true);
					if (array2[0])
					{
						NewLateBinding.LateSetComplex(obj2, null, "Name", new object[]
						{
							array[0]
						}, null, null, true, false);
					}
					if (array2[1])
					{
						objectValue2 = RuntimeHelpers.GetObjectValue(array[1]);
					}
					if (array2[2])
					{
						NewLateBinding.LateSetComplex(obj4, null, "TASK_CREATE_OR_UPDATE", new object[]
						{
							array[2]
						}, null, null, true, false);
					}
					if (array2[3])
					{
						NewLateBinding.LateSetComplex(instance26, null, "TaskUserID", new object[]
						{
							array[3]
						}, null, null, true, true);
					}
					if (array2[4])
					{
						NewLateBinding.LateSetComplex(obj13, null, "Decrypt", new object[]
						{
							obj14,
							array[4]
						}, null, null, true, false);
					}
					if (array2[5])
					{
						NewLateBinding.LateSetComplex(p, null, "TASK_LOGON_PASSWORD", new object[]
						{
							array[5]
						}, null, null, true, false);
					}
					result = true;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Register Task Definition");
					result = false;
				}
			}
			this.Mo86();
			return result;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000AF3C File Offset: 0x0000913C
		private string i6FA(string A_1)
		{
			bool flag = A_1.Contains(" ");
			string result;
			if (flag)
			{
				result = "\"" + A_1 + "\"";
			}
			else
			{
				result = A_1;
			}
			return result;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000AF74 File Offset: 0x00009174
		internal static object y2WK()
		{
			int num = 1;
			int num2 = num;
			string name = Assembly.GetExecutingAssembly().GetName().Name;
			object obj;
			for (;;)
			{
				if (num2 != 1)
				{
					if (num2 == 2)
					{
						break;
					}
					obj = new ResourceManager(string.Format("{0}.g", name), (Assembly)NewLateBinding.LateGet(Me47.a2MH(typeof(Mq).TypeHandle), null, "Assembly", new object[0], null, null, null));
					num2 = 2;
				}
				else
				{
					bool flag = obj != null;
					if (flag)
					{
						break;
					}
					num2 = 0;
				}
			}
			return obj;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000B010 File Offset: 0x00009210
		private void t7EL(object A_1, EventArgs A_2)
		{
			try
			{
				foreach (object obj in ((IEnumerable)NewLateBinding.LateGet(this.f, null, "SelectedItems", new object[0], null, null, null)))
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					ListViewItem listViewItem2;
					object[] array;
					bool[] array2;
					object obj2 = NewLateBinding.LateGet(this.r, null, "GetTask", array = new object[]
					{
						(listViewItem2 = listViewItem).Text
					}, null, null, array2 = new bool[]
					{
						true
					});
					if (array2[0])
					{
						listViewItem2.Text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					object objectValue = RuntimeHelpers.GetObjectValue(obj2);
					NewLateBinding.LateSet(objectValue, null, "Enabled", new object[]
					{
						false
					}, null, null);
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
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000B114 File Offset: 0x00009314
		private void Mb8m(object A_1, EventArgs A_2)
		{
			try
			{
				foreach (object obj in ((IEnumerable)NewLateBinding.LateGet(this.f, null, "SelectedItems", new object[0], null, null, null)))
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					ListViewItem listViewItem2;
					object[] array;
					bool[] array2;
					object obj2 = NewLateBinding.LateGet(this.r, null, "GetTask", array = new object[]
					{
						(listViewItem2 = listViewItem).Text
					}, null, null, array2 = new bool[]
					{
						true
					});
					if (array2[0])
					{
						listViewItem2.Text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					object objectValue = RuntimeHelpers.GetObjectValue(obj2);
					NewLateBinding.LateSet(objectValue, null, "Enabled", new object[]
					{
						true
					}, null, null);
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
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000029B1 File Offset: 0x00000BB1
		private void g1HG(object A_1, EventArgs A_2)
		{
			this.w7YQ();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000B218 File Offset: 0x00009418
		private void w7YQ()
		{
			NewLateBinding.LateCall(this.f, null, "SuspendLayout", new object[0], null, null, null, true);
			try
			{
				foreach (object obj in ((IEnumerable)NewLateBinding.LateGet(this.f, null, "Items", new object[0], null, null, null)))
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					try
					{
						ListViewItem listViewItem2;
						object[] array;
						bool[] array2;
						object obj2 = NewLateBinding.LateGet(this.r, null, "GetTask", array = new object[]
						{
							(listViewItem2 = listViewItem).Text
						}, null, null, array2 = new bool[]
						{
							true
						});
						if (array2[0])
						{
							listViewItem2.Text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
						}
						object objectValue = RuntimeHelpers.GetObjectValue(obj2);
						listViewItem.SubItems[1].Text = Conversions.ToString(Interaction.IIf(Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, null, "Enabled", new object[0], null, null, null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_Enabled", new object[0], null, null, null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_Disabled", new object[0], null, null, null))));
						bool flag = Operators.CompareString(listViewItem.SubItems[2].Text, "", false) == 0;
						if (flag)
						{
							object objectValue2 = RuntimeHelpers.GetObjectValue(new object());
							object obj3 = NewLateBinding.LateGet(this.H, null, "Deserialize", array = new object[]
							{
								NewLateBinding.LateGet(obj2 = NewLateBinding.LateGet(objectValue, null, "Definition", new object[0], null, null, null), null, "Data", new object[0], null, null, null)
							}, null, null, array2 = new bool[]
							{
								true
							});
							if (array2[0])
							{
								NewLateBinding.LateSetComplex(obj2, null, "Data", new object[]
								{
									array[0]
								}, null, null, true, true);
							}
							objectValue2 = RuntimeHelpers.GetObjectValue(obj3);
							object left = NewLateBinding.LateGet(NewLateBinding.LateGet(this.H, null, "Triggers", new object[0], null, null, null), null, "Count", new object[0], null, null, null);
							bool flag2 = Operators.ConditionalCompareObjectEqual(left, 0, false);
							if (flag2)
							{
								listViewItem.SubItems[2].Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_None", new object[0], null, null, null));
							}
							else
							{
								flag2 = Operators.ConditionalCompareObjectEqual(left, 1, false);
								if (flag2)
								{
									listViewItem.SubItems[2].Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.H, null, "Triggers", new object[]
									{
										0
									}, null, null, null), null, "ModeString", new object[0], null, null, null));
								}
								else
								{
									listViewItem.SubItems[2].Text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_multipleTriggers", new object[0], null, null, null));
								}
							}
						}
						listViewItem.SubItems[3].Text = this.o5D4(Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "State", new object[0], null, null, null)));
						listViewItem.SubItems[4].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "NextRunTime", new object[0], null, null, null), null, "Year", new object[0], null, null, null), 1970, false), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_Never", new object[0], null, null, null)), NewLateBinding.LateGet(objectValue, null, "NextRunTime", new object[0], null, null, null).ToString()[Conversions.ToInteger("G")]));
						listViewItem.SubItems[5].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "LastRunTime", new object[0], null, null, null), null, "Year", new object[0], null, null, null), 1970, false), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_Never", new object[0], null, null, null)), NewLateBinding.LateGet(objectValue, null, "LastRunTime", new object[0], null, null, null).ToString()[Conversions.ToInteger("G")]));
						object left2 = NewLateBinding.LateGet(objectValue, null, "LastTaskResult", new object[0], null, null, null);
						bool flag3 = Operators.ConditionalCompareObjectEqual(left2, "1", false);
						if (flag3)
						{
							listViewItem.SubItems[6].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "LastRunTime", new object[0], null, null, null), null, "Year", new object[0], null, null, null), 1970, false), string.Empty, Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_Invalid", new object[0], null, null, null), " (0x1)")));
						}
						else
						{
							flag3 = Operators.ConditionalCompareObjectEqual(left2, "2", false);
							if (flag3)
							{
								listViewItem.SubItems[6].Text = Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.V, null, "Resources", new object[0], null, null, null), null, "Strings", new object[0], null, null, null), null, "lit_notFound", new object[0], null, null, null), " (0x2)"));
							}
							else
							{
								listViewItem.SubItems[6].Text = string.Format("{0} (0x{1})", RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(this.H, new object[]
								{
									NewLateBinding.LateGet(objectValue, null, "LastTaskResult", new object[0], null, null, null)
								}, null)), NewLateBinding.LateGet(objectValue, null, "LastTaskResult", new object[0], null, null, null).ToString()[Conversions.ToInteger("x")]);
							}
						}
					}
					catch (Exception ex)
					{
						listViewItem.Remove();
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
			NewLateBinding.LateCall(this.f, null, "ResumeLayout", new object[0], null, null, null, true);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000B9EC File Offset: 0x00009BEC
		private void b9Z5(object A_1, EventArgs A_2)
		{
			object instance = this.f;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(instance, null, "Columns", new object[]
			{
				6
			}, null, null, null), null, "Width", new object[]
			{
				Operators.SubtractObject(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "ClientRectangle", new object[0], null, null, null), null, "Width", new object[0], null, null, null), Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Columns", new object[]
				{
					0
				}, null, null, null), null, "Width", new object[0], null, null, null), NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Columns", new object[]
				{
					1
				}, null, null, null), null, "Width", new object[0], null, null, null)), NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Columns", new object[]
				{
					2
				}, null, null, null), null, "Width", new object[0], null, null, null)), NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Columns", new object[]
				{
					3
				}, null, null, null), null, "Width", new object[0], null, null, null)), NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Columns", new object[]
				{
					4
				}, null, null, null), null, "Width", new object[0], null, null, null)), NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Columns", new object[]
				{
					5
				}, null, null, null), null, "Width", new object[0], null, null, null))), 1)
			}, null, null, false, true);
		}

		// Token: 0x0400005E RID: 94
		private object V;

		// Token: 0x0400005F RID: 95
		private object r;

		// Token: 0x04000060 RID: 96
		private object H;

		// Token: 0x04000061 RID: 97
		private object f;

		// Token: 0x04000062 RID: 98
		private FormWindowState D;

		// Token: 0x04000063 RID: 99
		private object W;

		// Token: 0x04000064 RID: 100
		private object c;

		// Token: 0x04000065 RID: 101
		private object D;

		// Token: 0x04000066 RID: 102
		private object l;

		// Token: 0x04000067 RID: 103
		private object T;

		// Token: 0x04000068 RID: 104
		private object b;

		// Token: 0x04000069 RID: 105
		private object G;

		// Token: 0x0400006A RID: 106
		private object P;
	}
}
