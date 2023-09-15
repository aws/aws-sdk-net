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
// this is for the dev snk
[assembly: InternalsVisibleTo("AWSSDK.UnitTests.Net45, PublicKey=0024000004800000940000000602000000240000525341310004000001000100516caa6311db961cb07702d63876c5b8cbd661557cd18bde9fb966bb30a4442abb27a4a5aca5af15c97b77f3f8f683eb1ca32cd7e8d1edcbbb1a62fe215001d507c2437f052b29540b7a11edbdc7dfe12de00c37f9e70c7e85a04541858ca46bb2581099780121ee8041732b7214ec9b5c483ef13c1db6d5f86a71fcc014dcaf")]
[assembly: InternalsVisibleTo("AWSSDK.UnitTests.Net35, PublicKey=0024000004800000940000000602000000240000525341310004000001000100516caa6311db961cb07702d63876c5b8cbd661557cd18bde9fb966bb30a4442abb27a4a5aca5af15c97b77f3f8f683eb1ca32cd7e8d1edcbbb1a62fe215001d507c2437f052b29540b7a11edbdc7dfe12de00c37f9e70c7e85a04541858ca46bb2581099780121ee8041732b7214ec9b5c483ef13c1db6d5f86a71fcc014dcaf")]
//this is for the prod snk
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
[assembly: AssemblyFileVersion("3.7.201.4")]

[assembly: System.CLSCompliant(true)]

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif

#if BCL45
// Setting SecurityRules to level 1 to match .NET 2.0 rules and allow the
// Amazon.Util.Settings.UserCrypto methods to work in .NET 4.5
[assembly: System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
#endif