using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.Core")]
#if BCL35
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (3.5) - Core Runtime")]
#elif BCL45
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.5) - Core Runtime")]
#elif NETSTANDARD20
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 2.0) - Core Runtime")]
#elif NETCOREAPP3_1
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET Core 3.1) - Core Runtime")]
#elif NET8_0
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET 8.0) - Core Runtime")]
#else
#error Unknown platform constant - unable to set correct AssemblyDescription
#endif
[assembly: InternalsVisibleTo("AWSSDK.UnitTests.Net45, PublicKey=0024000004800000940000000602000000240000525341310004000001000100db5f59f098d27276c7833875a6263a3cc74ab17ba9a9df0b52aedbe7252745db7274d5271fd79c1f08f668ecfa8eaab5626fa76adc811d3c8fc55859b0d09d3bc0a84eecd0ba891f2b8a2fc55141cdcc37c2053d53491e650a479967c3622762977900eddbf1252ed08a2413f00a28f3a0752a81203f03ccb7f684db373518b4")]
[assembly: InternalsVisibleTo("AWSSDK.UnitTests.Net35, PublicKey=0024000004800000940000000602000000240000525341310004000001000100db5f59f098d27276c7833875a6263a3cc74ab17ba9a9df0b52aedbe7252745db7274d5271fd79c1f08f668ecfa8eaab5626fa76adc811d3c8fc55859b0d09d3bc0a84eecd0ba891f2b8a2fc55141cdcc37c2053d53491e650a479967c3622762977900eddbf1252ed08a2413f00a28f3a0752a81203f03ccb7f684db373518b4")]

[assembly: AssemblyConfiguration("")]
[assembly: AssemblyProduct("Amazon Web Services SDK for .NET")]
[assembly: AssemblyCompany("Amazon.com, Inc")]
[assembly: AssemblyCopyright("Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("3.3")]
[assembly: AssemblyFileVersion("3.7.303.16")]

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif

#if BCL45
// Setting SecurityRules to level 1 to match .NET 2.0 rules and allow the
// Amazon.Util.Settings.UserCrypto methods to work in .NET 4.5
[assembly: System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
#endif