﻿using System.Reflection;
using System.Runtime.InteropServices;

#if x86
[assembly: AssemblyTitle("Port-Able Apps Launcher")]
[assembly: AssemblyProduct("AppsLauncher")]
#else
[assembly: AssemblyTitle("Port-Able Apps Launcher (64-bit)")]
[assembly: AssemblyProduct("AppsLauncher64")]
#endif
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Si13n7 Dev. ®")]
[assembly: AssemblyCopyright("Copyright © Si13n7 Dev. ® 2018")]
[assembly: AssemblyTrademark("Si13n7 Dev. ®")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("ee806ac7-2a8b-4d79-8634-adbdbba0aebf")]

[assembly: AssemblyVersion("18.6.20.0")]