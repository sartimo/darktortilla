using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Resources;
using System.Runtime.CompilerServices;
using Ex;
using Hz;
using Jc97;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using So;

namespace My
{
	// Token: 0x0200000F RID: 15
	[StandardModule]
	public sealed class Yq
	{
		// Token: 0x0600003C RID: 60 RVA: 0x000050B4 File Offset: 0x000032B4
		public static int Ps()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(Hz.Qt.C.Info.Title + " " + Hz.Qt.C.Info.Version.ToString());
			Console.ResetColor();
			bool flag = Hz.Qt.C.CommandLineArgs.Count == 0;
			checked
			{
				int result;
				if (flag)
				{
					Yq.Cg();
					result = 0;
				}
				else
				{
					int num = Hz.Qt.C.CommandLineArgs.Count - 1;
					int i = 0;
					while (i <= num)
					{
						string text = Hz.Qt.C.CommandLineArgs[i];
						uint num2 = Xf0i.Da7j(text);
						if (num2 <= 1607303228U)
						{
							if (num2 <= 1439527038U)
							{
								if (num2 <= 459464957U)
								{
									if (num2 != 443712427U)
									{
										if (num2 != 459464957U)
										{
											goto IL_6FC;
										}
										if (Operators.CompareString(text, "-pw", false) != 0)
										{
											goto IL_6FC;
										}
										bool flag2 = i == Hz.Qt.C.CommandLineArgs.Count - 1;
										if (flag2)
										{
											Yq.k7();
											return 1;
										}
										Yq.o = Yq.f1.N;
										Yq.O = Hz.Qt.C.CommandLineArgs[i + 1];
										i++;
									}
									else
									{
										if (Operators.CompareString(text, "-mac", false) != 0)
										{
											goto IL_6FC;
										}
										bool flag3 = i == Hz.Qt.C.CommandLineArgs.Count - 1;
										if (flag3)
										{
											Yq.k7();
											return 1;
										}
										i++;
										Yq.n = Hz.Qt.C.CommandLineArgs[i];
									}
								}
								else if (num2 != 781530473U)
								{
									if (num2 != 1405971800U)
									{
										if (num2 != 1439527038U)
										{
											goto IL_6FC;
										}
										if (Operators.CompareString(text, "-r", false) != 0)
										{
											goto IL_6FC;
										}
										Yq.o = Yq.f1.Y;
										Yq.S = 1L;
									}
									else
									{
										if (Operators.CompareString(text, "-p", false) != 0)
										{
											goto IL_6FC;
										}
										bool flag4 = i == Hz.Qt.C.CommandLineArgs.Count - 1;
										if (flag4)
										{
											Yq.k7();
											return 1;
										}
										i++;
										Yq.v = Hz.Qt.C.CommandLineArgs[i];
									}
								}
								else
								{
									if (Operators.CompareString(text, "-msg", false) != 0)
									{
										goto IL_6FC;
									}
									Yq.o = Yq.f1.G;
								}
							}
							else if (num2 <= 1473082276U)
							{
								if (num2 != 1456304657U)
								{
									if (num2 != 1473082276U)
									{
										goto IL_6FC;
									}
									if (Operators.CompareString(text, "-t", false) != 0)
									{
										goto IL_6FC;
									}
									bool flag5 = i == Hz.Qt.C.CommandLineArgs.Count - 1;
									if (flag5)
									{
										Yq.k7();
										return 1;
									}
									Yq.u = (long)Math.Round(Conversion.Val(Hz.Qt.C.CommandLineArgs[i + 1]));
									i++;
								}
								else
								{
									if (Operators.CompareString(text, "-s", false) != 0)
									{
										goto IL_6FC;
									}
									Yq.o = Yq.f1.Y;
									Yq.S = 0L;
								}
							}
							else if (num2 != 1523415133U)
							{
								if (num2 != 1540192752U)
								{
									if (num2 != 1607303228U)
									{
										goto IL_6FC;
									}
									if (Operators.CompareString(text, "-l", false) != 0)
									{
										goto IL_6FC;
									}
									Yq.k6();
									return 0;
								}
								else
								{
									if (Operators.CompareString(text, "-h", false) != 0)
									{
										goto IL_6FC;
									}
									Yq.Cg();
									return 0;
								}
							}
							else
							{
								if (Operators.CompareString(text, "-w", false) != 0)
								{
									goto IL_6FC;
								}
								Yq.o = Yq.f1.L;
							}
						}
						else if (num2 <= 1758301799U)
						{
							if (num2 <= 1691191323U)
							{
								if (num2 != 1624080847U)
								{
									if (num2 != 1691191323U)
									{
										goto IL_6FC;
									}
									if (Operators.CompareString(text, "-a", false) != 0)
									{
										goto IL_6FC;
									}
									Yq.o = Yq.f1.x;
								}
								else
								{
									if (Operators.CompareString(text, "-m", false) != 0)
									{
										goto IL_6FC;
									}
									bool flag6 = i == Hz.Qt.C.CommandLineArgs.Count - 1;
									if (flag6)
									{
										Yq.k7();
										return 1;
									}
									i++;
									Yq.w = Hz.Qt.C.CommandLineArgs[i];
								}
							}
							else if (num2 != 1724746561U)
							{
								if (num2 != 1741524180U)
								{
									if (num2 != 1758301799U)
									{
										goto IL_6FC;
									}
									if (Operators.CompareString(text, "-e", false) != 0)
									{
										goto IL_6FC;
									}
									Yq.o = Yq.f1.D;
								}
								else
								{
									if (Operators.CompareString(text, "-d", false) != 0)
									{
										goto IL_6FC;
									}
									Yq.o = Yq.f1.I;
								}
							}
							else
							{
								if (Operators.CompareString(text, "-c", false) != 0)
								{
									goto IL_6FC;
								}
								bool flag7 = i == Hz.Qt.C.CommandLineArgs.Count - 1;
								if (flag7)
								{
									Yq.k7();
									return 1;
								}
								Yq.b = Hz.Qt.C.CommandLineArgs[i + 1];
								i++;
							}
						}
						else if (num2 <= 2763393753U)
						{
							if (num2 != 1775079418U)
							{
								if (num2 != 1791857037U)
								{
									if (num2 != 2763393753U)
									{
										goto IL_6FC;
									}
									if (Operators.CompareString(text, "-agent", false) != 0)
									{
										goto IL_6FC;
									}
									bool flag8 = i == Hz.Qt.C.CommandLineArgs.Count - 1;
									if (flag8)
									{
										Yq.k7();
										return 1;
									}
									i++;
									Yq.L = Hz.Qt.C.CommandLineArgs[i];
								}
								else
								{
									if (Operators.CompareString(text, "-g", false) != 0)
									{
										goto IL_6FC;
									}
									bool flag9 = i == Hz.Qt.C.CommandLineArgs.Count - 1;
									if (flag9)
									{
										Yq.k7();
										return 1;
									}
									i++;
									Yq.y = Hz.Qt.C.CommandLineArgs[i];
								}
							}
							else
							{
								if (Operators.CompareString(text, "-f", false) != 0)
								{
									goto IL_6FC;
								}
								Yq.Q = 1L;
							}
						}
						else if (num2 != 3312101472U)
						{
							if (num2 != 3395989567U)
							{
								if (num2 != 3930292923U)
								{
									goto IL_6FC;
								}
								if (Operators.CompareString(text, "-all", false) != 0)
								{
									goto IL_6FC;
								}
								Yq.e = true;
							}
							else
							{
								if (Operators.CompareString(text, "-s4", false) != 0)
								{
									goto IL_6FC;
								}
								Yq.o = Yq.f1.T;
								Yq.S = 0L;
							}
						}
						else
						{
							if (Operators.CompareString(text, "-s1", false) != 0)
							{
								goto IL_6FC;
							}
							Yq.o = Yq.f1.E;
							Yq.S = 0L;
						}
						i++;
						continue;
						IL_6FC:
						Yq.Cg();
						return 1;
					}
					switch (Yq.o)
					{
					case Yq.f1.Y:
					case Yq.f1.E:
					case Yq.f1.T:
						result = Yq.x0();
						break;
					case Yq.f1.L:
						result = Yq.Jr();
						break;
					case Yq.f1.x:
						result = Yq.m2();
						break;
					case Yq.f1.I:
						result = Yq.n8();
						break;
					case Yq.f1.D:
						Yq.Qa();
						break;
					case Yq.f1.G:
						Yq.Ce();
						break;
					case Yq.f1.N:
						Yq.o2();
						break;
					default:
						Yq.k7();
						result = 1;
						break;
					}
				}
				return result;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000585C File Offset: 0x00003A5C
		private static void Cg()
		{
			Console.WriteLine();
			Console.WriteLine("Commands are:");
			Console.WriteLine("-s   (shutdown) requires -m, -g or -all");
			Console.WriteLine("-s1  (sleep) requires -m or -all");
			Console.WriteLine("-s4  (hibernate) requires -m or -all");
			Console.WriteLine("-a   (abort a shutdown) requires -m (depreciated)");
			Console.WriteLine("-r   (reboot)");
			Console.WriteLine("-w   (wakeup) requires -m, -g, -mac parameter, or -all");
			Console.WriteLine("     Use -m with -w to send to a specific subnet");
			Console.WriteLine("     Use -mac and -agent to explicitly send WOL packet to a specific IP");
			Console.WriteLine("-l   (listen for WOL packets)");
			Console.WriteLine("-e   (enumerate machine list)");
			Console.WriteLine("-p   (path to machines.xml (optional))");
			Console.WriteLine("-msg (immediate message (example -msg -c \"Shutting down in 10 minutes\")");
			Console.WriteLine("     Optional: Use -m to send message to a remote machine.");
			Console.WriteLine("-d   (debug) requires -m");
			Console.WriteLine("-pw  (password) change shutdown password for a machine, requires -m, -g or -all");
			Console.WriteLine("-h   (display this help message)");
			Console.WriteLine();
			Console.WriteLine("options:");
			Console.WriteLine("-t xx      delay (xx = seconds).  For Shutdown and Reboot commands.");
			Console.WriteLine("-f         force files closed.  For Shutdown and Reboot commands.");
			Console.WriteLine("-m xx      xx = machine name.");
			Console.WriteLine("-mac xx    xx = mac address.");
			Console.WriteLine("-g xx      xx = group name.  To wakeup or shutdown a group of machines.");
			Console.WriteLine("-all       all machines.");
			Console.WriteLine("-agent xx  xx = address of WOL agent if on remote subnet, use with -mac.");
			Console.WriteLine("-c \"xx\"    xx = popup message.  Optional popup message on shutdown.");
			Console.WriteLine();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002935 File Offset: 0x00000B35
		private static void k7()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Invalid command line.");
			Console.ResetColor();
			Yq.Cg();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000599C File Offset: 0x00003B9C
		private static int Jr()
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Aquila Technology\\WakeOnLAN", false);
			bool flag = Information.IsNothing(registryKey);
			if (flag)
			{
				Yq.M = 750;
			}
			else
			{
				Yq.M = Conversions.ToInteger(registryKey.GetValue("RepeatInterval", 750, RegistryValueOptions.None));
				registryKey.Close();
			}
			bool flag2 = Yq.e;
			int result;
			if (flag2)
			{
				try
				{
					object[] array;
					bool[] array2;
					NewLateBinding.LateCall(Yq.N, null, "Load", array = new object[]
					{
						Yq.v
					}, null, null, array2 = new bool[]
					{
						true
					}, true);
					if (array2[0])
					{
						Yq.v = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
				}
				catch (Exception ex)
				{
					Yq.d = 5;
					return Yq.d;
				}
				try
				{
					foreach (object obj in ((IEnumerable)Yq.N))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						Console.Write(Operators.ConcatenateObject(Operators.ConcatenateObject("Wakeup ", NewLateBinding.LateGet(objectValue, null, "Name", new object[0], null, null, null)), "... "));
						bool flag3 = Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, null, "MAC", new object[0], null, null, null), "", false);
						if (flag3)
						{
							Yq.d = 2;
							Console.WriteLine(Operators.ConcatenateObject("Cannot find MAC address for ", NewLateBinding.LateGet(objectValue, null, "Name", new object[0], null, null, null)));
						}
						else
						{
							Console.WriteLine(Operators.ConcatenateObject("waking up mac: ", NewLateBinding.LateGet(objectValue, null, "MAC", new object[0], null, null, null)));
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
				result = Yq.d;
			}
			else
			{
				bool flag4 = Yq.w.Length != 0;
				if (flag4)
				{
					try
					{
						object[] array;
						bool[] array2;
						NewLateBinding.LateCall(Yq.N, null, "Load", array = new object[]
						{
							Yq.v
						}, null, null, array2 = new bool[]
						{
							true
						}, true);
						if (array2[0])
						{
							Yq.v = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
						}
					}
					catch (Exception ex2)
					{
						Yq.d = 5;
						return Yq.d;
					}
					object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(Yq.N, new object[]
					{
						Yq.w
					}, null));
					bool flag5 = objectValue == null;
					if (flag5)
					{
						Console.WriteLine("Cannot find machine " + Yq.w);
						result = 2;
					}
					else
					{
						Console.Write("wakeup sent to ");
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine(Yq.w);
						Console.ResetColor();
						Console.Write(Operators.ConcatenateObject(Operators.ConcatenateObject("waking up mac: ", NewLateBinding.LateGet(objectValue, null, "MAC", new object[0], null, null, null)), " broadcast: "));
						bool flag6 = Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, null, "Method", new object[0], null, null, null), 0, false);
						if (flag6)
						{
							Console.WriteLine(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Broadcast", new object[0], null, null, null)));
						}
						else
						{
							Console.WriteLine(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Netbios", new object[0], null, null, null)));
						}
						Yq.Be(RuntimeHelpers.GetObjectValue(objectValue), Yq.M);
						result = 0;
					}
				}
				else
				{
					bool flag7 = Yq.n.Length != 0;
					if (flag7)
					{
						Console.WriteLine("waking up mac: " + Yq.n);
						Yq.Be(Yq.n, Conversions.ToInteger(Yq.L));
						result = 0;
					}
					else
					{
						bool flag8 = Yq.y.Length != 0;
						if (flag8)
						{
							try
							{
								object[] array;
								bool[] array2;
								NewLateBinding.LateCall(Yq.N, null, "Load", array = new object[]
								{
									Yq.v
								}, null, null, array2 = new bool[]
								{
									true
								}, true);
								if (array2[0])
								{
									Yq.v = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
								}
							}
							catch (Exception ex3)
							{
								Yq.d = 5;
								return Yq.d;
							}
							Console.WriteLine("waking up group: " + Yq.y);
							Console.WriteLine("Done.");
							result = 0;
						}
						else
						{
							Console.WriteLine("Error.  No machine or MAC specified.");
							Yq.Cg();
							result = 1;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002957 File Offset: 0x00000B57
		private static void Be(object A_0, int A_1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005E84 File Offset: 0x00004084
		internal static byte[] Ez(string A_0)
		{
			ResourceSet resourceSet = ((ResourceManager)Tf.q3()).GetResourceSet(CultureInfo.CurrentCulture, true, true);
			object objectValue;
			foreach (object obj in resourceSet)
			{
				DictionaryEntry dictionaryEntry = (obj != null) ? ((DictionaryEntry)obj) : default(DictionaryEntry);
				bool flag = dictionaryEntry.Key.ToString().Contains(A_0);
				if (flag)
				{
					objectValue = RuntimeHelpers.GetObjectValue(dictionaryEntry.Value);
					break;
				}
			}
			objectValue = RuntimeHelpers.GetObjectValue(y7.Da9i(RuntimeHelpers.GetObjectValue(objectValue)));
			bool flag2 = objectValue == null;
			byte[] result;
			if (flag2)
			{
				result = null;
			}
			else
			{
				List<byte> list = new List<byte>();
				object counter;
				object loopObj;
				bool flag3 = ObjectFlowControl.ForLoopControl.ForLoopInitObj(counter, 0, Operators.SubtractObject(NewLateBinding.LateGet(objectValue, null, "Length", new object[0], null, null, null), 1), 1, ref loopObj, ref counter);
				if (flag3)
				{
					do
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "ReadByte", new object[0], null, null, null));
						list.Add(Conversions.ToByte(objectValue2));
					}
					while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(counter, loopObj, ref counter));
				}
				result = list.ToArray().Reverse<byte>().ToArray<byte>();
			}
			return result;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005FC0 File Offset: 0x000041C0
		private static int m2()
		{
			Console.WriteLine("Error.  Abort command is depreciated.");
			return 1;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005FE0 File Offset: 0x000041E0
		private static int x0()
		{
			object[] array;
			bool[] array2;
			NewLateBinding.LateCall(Yq.N, null, "Load", array = new object[]
			{
				Yq.v
			}, null, null, array2 = new bool[]
			{
				true
			}, true);
			if (array2[0])
			{
				Yq.v = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			bool flag = string.IsNullOrEmpty(Yq.w) & string.IsNullOrEmpty(Yq.y) & !Yq.e;
			int result;
			if (flag)
			{
				Console.WriteLine("Error.  No machine specified.");
				Yq.Cg();
				Yq.d = 1;
				result = Yq.d;
			}
			else
			{
				bool flag2 = Yq.o == Yq.f1.Y;
				object objectValue;
				if (flag2)
				{
					bool flag3 = Yq.Q != 0L;
					if (flag3)
					{
						bool flag4 = Yq.S != 0L;
						if (flag4)
						{
							objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Yq.B, null, "ForcedReboot", new object[0], null, null, null));
						}
						else
						{
							objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Yq.B, null, "ForcedShutdown", new object[0], null, null, null));
						}
					}
					else
					{
						bool flag5 = Yq.S != 0L;
						if (flag5)
						{
							objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Yq.B, null, "Reboot", new object[0], null, null, null));
						}
						else
						{
							objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Yq.B, null, "Shutdown", new object[0], null, null, null));
						}
					}
				}
				else
				{
					bool flag6 = Yq.o == Yq.f1.T;
					if (flag6)
					{
						objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Yq.B, null, "Hibernate", new object[0], null, null, null));
					}
					else
					{
						bool flag7 = Yq.o == Yq.f1.E;
						if (flag7)
						{
							objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Yq.B, null, "Sleep", new object[0], null, null, null));
						}
					}
				}
				bool flag8 = Yq.e;
				if (flag8)
				{
					try
					{
						foreach (object obj in ((IEnumerable)Yq.N))
						{
							object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
							Console.WriteLine(string.Format("Command {0} to {1}", objectValue.ToString(), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "Name", new object[0], null, null, null))));
							Yq.To(RuntimeHelpers.GetObjectValue(objectValue2), RuntimeHelpers.GetObjectValue(objectValue));
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
				else
				{
					bool flag9 = Yq.y.Length != 0;
					if (flag9)
					{
						Console.WriteLine(string.Format("Command {0} to group: {1}", objectValue.ToString(), Yq.y));
						Console.WriteLine("Done.");
					}
					else
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(Yq.N, new object[]
						{
							Yq.w
						}, null));
						Console.Write(Operators.ConcatenateObject(objectValue.ToString() + " sent to ", NewLateBinding.LateGet(objectValue2, null, "Name", new object[0], null, null, null)));
						Yq.To(RuntimeHelpers.GetObjectValue(objectValue2), RuntimeHelpers.GetObjectValue(objectValue));
					}
				}
				result = Yq.d;
			}
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006310 File Offset: 0x00004510
		private static void To(object A_0, object A_1)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(new object());
			try
			{
				object left = NewLateBinding.LateGet(A_0, null, "ShutdownMethod", new object[0], null, null, null);
				bool flag = Operators.ConditionalCompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(A_0, null, "ShutdownMethods", new object[0], null, null, null), null, "WMI", new object[0], null, null, null), false);
				if (flag)
				{
					object q = Yq.Q;
					Type type = null;
					string memberName = "Shutdown";
					object[] array = new object[5];
					array[0] = NewLateBinding.LateGet(A_0, null, "Netbios", new object[0], null, null, null);
					array[1] = A_1;
					array[2] = NewLateBinding.LateGet(A_0, null, "UserID", new object[0], null, null, null);
					int num = 3;
					object obj = objectValue;
					object instance = obj;
					Type type2 = null;
					string memberName2 = "Decrypt";
					object[] array2 = new object[1];
					object obj2 = array2[0] = NewLateBinding.LateGet(A_0, null, "Password", new object[0], null, null, null);
					object[] array3 = array2;
					bool[] array4;
					object obj3 = NewLateBinding.LateGet(instance, type2, memberName2, array2, null, null, array4 = new bool[]
					{
						true
					});
					if (array4[0])
					{
						NewLateBinding.LateSetComplex(A_0, null, "Password", new object[]
						{
							array3[0]
						}, null, null, true, false);
					}
					array[num] = obj3;
					array[4] = NewLateBinding.LateGet(A_0, null, "Domain", new object[0], null, null, null);
					object[] array5 = array;
					bool[] array6;
					NewLateBinding.LateCall(q, type, memberName, array, null, null, array6 = new bool[]
					{
						true,
						true,
						true,
						true,
						true
					}, true);
					if (array6[0])
					{
						NewLateBinding.LateSetComplex(A_0, null, "Netbios", new object[]
						{
							array5[0]
						}, null, null, true, false);
					}
					if (array6[1])
					{
						A_1 = RuntimeHelpers.GetObjectValue(array5[1]);
					}
					if (array6[2])
					{
						NewLateBinding.LateSetComplex(A_0, null, "UserID", new object[]
						{
							array5[2]
						}, null, null, true, false);
					}
					if (array6[3])
					{
						NewLateBinding.LateSetComplex(obj, null, "Decrypt", new object[]
						{
							obj2,
							array5[3]
						}, null, null, true, false);
					}
					if (array6[4])
					{
						NewLateBinding.LateSetComplex(A_0, null, "Domain", new object[]
						{
							array5[4]
						}, null, null, true, false);
					}
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(A_0, null, "ShutdownMethods", new object[0], null, null, null), null, "Custom", new object[0], null, null, null), false);
					if (flag)
					{
						string text = Conversions.ToString(NewLateBinding.LateGet(A_0, null, "ShutdownCommand", new object[0], null, null, null));
						text = text.Replace("$PF", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
						text = text.Replace("$PFX86", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
						text = text.Replace("$USER", Conversions.ToString(NewLateBinding.LateGet(A_0, null, "UserID", new object[0], null, null, null)));
						string text2 = text;
						string oldValue = "$PASS";
						object[] array5;
						bool[] array6;
						object obj2 = NewLateBinding.LateGet(objectValue, null, "Decrypt", array5 = new object[]
						{
							NewLateBinding.LateGet(A_0, null, "Password", new object[0], null, null, null)
						}, null, null, array6 = new bool[]
						{
							true
						});
						if (array6[0])
						{
							NewLateBinding.LateSetComplex(A_0, null, "Password", new object[]
							{
								array5[0]
							}, null, null, true, false);
						}
						text = text2.Replace(oldValue, Conversions.ToString(obj2));
						text = text.Replace("$HOST", Conversions.ToString(NewLateBinding.LateGet(A_0, null, "Netbios", new object[0], null, null, null)));
						Debug.WriteLine("Custom command: " + text);
						Interaction.Shell(text, AppWinStyle.Hide, false, -1);
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(left, NewLateBinding.LateGet(NewLateBinding.LateGet(A_0, null, "ShutdownMethods", new object[0], null, null, null), null, "Legacy", new object[0], null, null, null), false);
						if (flag)
						{
							object left2 = A_1;
							bool flag2 = Operators.ConditionalCompareObjectEqual(left2, NewLateBinding.LateGet(Yq.B, null, "Shutdown", new object[0], null, null, null), false);
							if (flag2)
							{
								A_1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Yq.B, null, "LegacyShutdown", new object[0], null, null, null));
							}
							else
							{
								flag2 = Operators.ConditionalCompareObjectEqual(left2, NewLateBinding.LateGet(Yq.B, null, "ForcedShutdown", new object[0], null, null, null), false);
								if (flag2)
								{
									A_1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Yq.B, null, "LegacyForcedShutdown", new object[0], null, null, null));
								}
								else
								{
									flag2 = Operators.ConditionalCompareObjectEqual(left2, NewLateBinding.LateGet(Yq.B, null, "Reboot", new object[0], null, null, null), false);
									if (flag2)
									{
										A_1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Yq.B, null, "LegacyReboot", new object[0], null, null, null));
									}
									else
									{
										flag2 = Operators.ConditionalCompareObjectEqual(left2, NewLateBinding.LateGet(Yq.B, null, "ForcedReboot", new object[0], null, null, null), false);
										if (!flag2)
										{
											throw new Exception(string.Format("{0} not supported with Legacy shutdown method.", A_1.ToString()));
										}
										A_1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Yq.B, null, "LegacyForcedReboot", new object[0], null, null, null));
									}
								}
							}
							object q2 = Yq.Q;
							Type type3 = null;
							string memberName3 = "Shutdown";
							object[] array7 = new object[6];
							array7[0] = NewLateBinding.LateGet(A_0, null, "Netbios", new object[0], null, null, null);
							array7[1] = A_1;
							array7[2] = NewLateBinding.LateGet(A_0, null, "UserID", new object[0], null, null, null);
							int num2 = 3;
							object obj = objectValue;
							object instance2 = obj;
							Type type4 = null;
							string memberName4 = "Decrypt";
							object[] array8 = new object[1];
							object obj4 = array8[0] = NewLateBinding.LateGet(A_0, null, "Password", new object[0], null, null, null);
							object[] array3 = array8;
							bool[] array4;
							object obj3 = NewLateBinding.LateGet(instance2, type4, memberName4, array8, null, null, array4 = new bool[]
							{
								true
							});
							if (array4[0])
							{
								NewLateBinding.LateSetComplex(A_0, null, "Password", new object[]
								{
									array3[0]
								}, null, null, true, false);
							}
							array7[num2] = obj3;
							array7[4] = NewLateBinding.LateGet(A_0, null, "Domain", new object[0], null, null, null);
							array7[5] = Yq.b;
							object[] array5 = array7;
							bool[] array6;
							NewLateBinding.LateCall(q2, type3, memberName3, array7, null, null, array6 = new bool[]
							{
								true,
								true,
								true,
								true,
								true,
								true
							}, true);
							if (array6[0])
							{
								NewLateBinding.LateSetComplex(A_0, null, "Netbios", new object[]
								{
									array5[0]
								}, null, null, true, false);
							}
							if (array6[1])
							{
								A_1 = RuntimeHelpers.GetObjectValue(array5[1]);
							}
							if (array6[2])
							{
								NewLateBinding.LateSetComplex(A_0, null, "UserID", new object[]
								{
									array5[2]
								}, null, null, true, false);
							}
							if (array6[3])
							{
								NewLateBinding.LateSetComplex(obj, null, "Decrypt", new object[]
								{
									obj4,
									array5[3]
								}, null, null, true, false);
							}
							if (array6[4])
							{
								NewLateBinding.LateSetComplex(A_0, null, "Domain", new object[]
								{
									array5[4]
								}, null, null, true, false);
							}
							if (array6[5])
							{
								Yq.b = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[5]), typeof(string));
							}
						}
					}
				}
				Console.WriteLine("...Successful");
				Yq.a4(string.Format("Sending {0} to \"{1}\"", A_1.ToString(), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(A_0, null, "Name", new object[0], null, null, null))), EventLogEntryType.Information, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Yq.i, null, "Shutdown", new object[0], null, null, null)));
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("...Error: ");
				Console.WriteLine(ex.Message);
				Console.ResetColor();
				Yq.a4(string.Format("Shutdown error on host {0}{1}: {2}", RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(A_0, null, "Name", new object[0], null, null, null)), "\r\n", ex.Message), EventLogEntryType.Error, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Yq.i, null, "Error", new object[0], null, null, null)));
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002957 File Offset: 0x00000B57
		private static void a4(string A_0, EventLogEntryType A_1, object A_2)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006B0C File Offset: 0x00004D0C
		internal static bool Qt()
		{
			bool result;
			try
			{
				NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
				foreach (NetworkInterface networkInterface in allNetworkInterfaces)
				{
					bool flag = networkInterface.OperationalStatus == OperationalStatus.Up;
					if (flag)
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00006B7C File Offset: 0x00004D7C
		private static void Ce()
		{
			string arg = string.Empty;
			try
			{
				bool flag = !string.IsNullOrEmpty(Yq.w);
				if (flag)
				{
					bool flag2 = Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Yq.N, null, "Count", new object[0], null, null, null), 0, false);
					if (flag2)
					{
						object[] array;
						bool[] array2;
						NewLateBinding.LateCall(Yq.N, null, "Load", array = new object[]
						{
							Yq.v
						}, null, null, array2 = new bool[]
						{
							true
						}, true);
						if (array2[0])
						{
							Yq.v = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
						}
					}
					object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(Yq.N, new object[]
					{
						Yq.w
					}, null));
					arg = Conversions.ToString(NewLateBinding.LateGet(objectValue, null, "Netbios", new object[0], null, null, null));
				}
				Interaction.Shell(string.Format("msg * /server:{0} \"{1}\"", arg, Yq.b), AppWinStyle.MinimizedFocus, false, -1);
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("...Error: ");
				Console.WriteLine(ex.Message);
				Console.ResetColor();
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006CC8 File Offset: 0x00004EC8
		private static void k6()
		{
			object objectValue = RuntimeHelpers.GetObjectValue(new object());
			Console.WriteLine("Listening for WakeUp packets.  CTRL-C to abort...");
			for (;;)
			{
				NewLateBinding.LateCall(objectValue, null, "BeginReceive", new object[0], null, null, null, true);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006D08 File Offset: 0x00004F08
		private static void Qa()
		{
			Console.WriteLine("Enumerate machines...");
			object[] array;
			bool[] array2;
			NewLateBinding.LateCall(Yq.N, null, "Load", array = new object[]
			{
				Yq.v
			}, null, null, array2 = new bool[]
			{
				true
			}, true);
			if (array2[0])
			{
				Yq.v = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			try
			{
				foreach (object obj in ((IEnumerable)Yq.N))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("{0,-16}", RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Name", new object[0], null, null, null)));
					Console.ResetColor();
					Console.WriteLine(" IP: {0,-16} MAC: {1}", RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "IP", new object[0], null, null, null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "MAC", new object[0], null, null, null)));
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

		// Token: 0x0600004A RID: 74 RVA: 0x00006E44 File Offset: 0x00005044
		private static int o2()
		{
			object objectValue = RuntimeHelpers.GetObjectValue(new object());
			object[] array;
			bool[] array2;
			object value = NewLateBinding.LateGet(objectValue, null, "Encrypt", array = new object[]
			{
				Yq.O
			}, null, null, array2 = new bool[]
			{
				true
			});
			if (array2[0])
			{
				Yq.O = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			string text = Conversions.ToString(value);
			NewLateBinding.LateCall(Yq.N, null, "Load", array = new object[]
			{
				Yq.v
			}, null, null, array2 = new bool[]
			{
				true
			}, true);
			if (array2[0])
			{
				Yq.v = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			bool flag = string.IsNullOrEmpty(Yq.w) & string.IsNullOrEmpty(Yq.y) & !Yq.e;
			int result;
			if (flag)
			{
				Console.WriteLine("Error.  No machine specified.");
				Yq.Cg();
				Yq.d = 1;
				result = Yq.d;
			}
			else
			{
				bool flag2 = Yq.e;
				if (flag2)
				{
					Console.WriteLine(string.Format("Changing password all machines", new object[0]));
					try
					{
						foreach (object obj in ((IEnumerable)Yq.N))
						{
							object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
							Console.WriteLine(Operators.ConcatenateObject("  > ", NewLateBinding.LateGet(objectValue2, null, "Name", new object[0], null, null, null)));
							NewLateBinding.LateSet(objectValue2, null, "Password", new object[]
							{
								text
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
				else
				{
					bool flag3 = Yq.y.Length != 0;
					if (flag3)
					{
						Console.WriteLine(string.Format("Changing password for group: {0}", Yq.y));
					}
					else
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(Yq.N, new object[]
						{
							Yq.w
						}, null));
						Console.WriteLine("Changing password: {0}", RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "Name", new object[0], null, null, null)));
						NewLateBinding.LateSet(objectValue2, null, "Password", new object[]
						{
							text
						}, null, null);
					}
				}
				NewLateBinding.LateCall(Yq.N, null, "Save", array = new object[]
				{
					Yq.v
				}, null, null, array2 = new bool[]
				{
					true
				}, true);
				if (array2[0])
				{
					Yq.v = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				Console.WriteLine("Done.");
				result = Yq.d;
			}
			return result;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000711C File Offset: 0x0000531C
		private static int n8()
		{
			Ping ping = new Ping();
			bool flag = Operators.CompareString(Yq.w, "", false) == 0;
			int result;
			if (flag)
			{
				Console.WriteLine("You must specify machine name with -m");
				result = 1;
			}
			else
			{
				Console.WriteLine("Show IP configuration for " + Yq.w);
				try
				{
					foreach (IPAddress ipaddress in Dns.GetHostAddresses(Yq.w))
					{
						Console.WriteLine("  Address: {0} Family: {1}", ipaddress.ToString(), ipaddress.AddressFamily.ToString());
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					return 2;
				}
				PingReply pingReply = ping.Send(Yq.w, 1500);
				Console.WriteLine("Ping: " + pingReply.Status.ToString());
				result = 0;
			}
			return result;
		}

		// Token: 0x04000026 RID: 38
		private static string w = string.Empty;

		// Token: 0x04000027 RID: 39
		private static string n = string.Empty;

		// Token: 0x04000028 RID: 40
		private static bool e = false;

		// Token: 0x04000029 RID: 41
		private static string L = "255.255.255.255";

		// Token: 0x0400002A RID: 42
		private static string b = "System is shutting down";

		// Token: 0x0400002B RID: 43
		private static long u = 30L;

		// Token: 0x0400002C RID: 44
		private static long Q = 0L;

		// Token: 0x0400002D RID: 45
		private static long S = 0L;

		// Token: 0x0400002E RID: 46
		private static string y = string.Empty;

		// Token: 0x0400002F RID: 47
		private static Yq.f1 o = Yq.f1.B;

		// Token: 0x04000030 RID: 48
		private static int d = 0;

		// Token: 0x04000031 RID: 49
		private static string v = string.Empty;

		// Token: 0x04000032 RID: 50
		private static int M = 750;

		// Token: 0x04000033 RID: 51
		private static string O = string.Empty;

		// Token: 0x04000034 RID: 52
		private static object Q;

		// Token: 0x04000035 RID: 53
		private static object B;

		// Token: 0x04000036 RID: 54
		private static object N;

		// Token: 0x04000037 RID: 55
		private static object i;

		// Token: 0x02000010 RID: 16
		public enum f1
		{
			// Token: 0x04000039 RID: 57
			B,
			// Token: 0x0400003A RID: 58
			Y,
			// Token: 0x0400003B RID: 59
			L,
			// Token: 0x0400003C RID: 60
			x,
			// Token: 0x0400003D RID: 61
			I,
			// Token: 0x0400003E RID: 62
			E,
			// Token: 0x0400003F RID: 63
			T,
			// Token: 0x04000040 RID: 64
			D,
			// Token: 0x04000041 RID: 65
			G,
			// Token: 0x04000042 RID: 66
			N
		}

		// Token: 0x02000011 RID: 17
		public enum z3
		{
			// Token: 0x04000044 RID: 68
			m,
			// Token: 0x04000045 RID: 69
			X,
			// Token: 0x04000046 RID: 70
			d,
			// Token: 0x04000047 RID: 71
			g = 5
		}
	}
}
