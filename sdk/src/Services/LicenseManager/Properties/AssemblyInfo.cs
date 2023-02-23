using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.LicenseManager")]
#if BCL35
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (3.5) - AWS License Manager. AWS License Manager makes it easier to manage licenses in AWS and on premises when customers run applications using existing licenses from a variety of software vendors including Microsoft, SAP, Oracle, and IBM. AWS License Manager automatically tracks and controls license usage once administrators have created and enforced rules that emulate the terms of their licensing agreements. The capabilities of AWS License Manager are available through SDK and Tools, besides the management console and CLI.")]
#elif BCL45
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.5) - AWS License Manager. AWS License Manager makes it easier to manage licenses in AWS and on premises when customers run applications using existing licenses from a variety of software vendors including Microsoft, SAP, Oracle, and IBM. AWS License Manager automatically tracks and controls license usage once administrators have created and enforced rules that emulate the terms of their licensing agreements. The capabilities of AWS License Manager are available through SDK and Tools, besides the management console and CLI.")]
#elif NETSTANDARD20
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 2.0) - AWS License Manager. AWS License Manager makes it easier to manage licenses in AWS and on premises when customers run applications using existing licenses from a variety of software vendors including Microsoft, SAP, Oracle, and IBM. AWS License Manager automatically tracks and controls license usage once administrators have created and enforced rules that emulate the terms of their licensing agreements. The capabilities of AWS License Manager are available through SDK and Tools, besides the management console and CLI.")]
#elif NETCOREAPP3_1
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET Core 3.1) - AWS License Manager. AWS License Manager makes it easier to manage licenses in AWS and on premises when customers run applications using existing licenses from a variety of software vendors including Microsoft, SAP, Oracle, and IBM. AWS License Manager automatically tracks and controls license usage once administrators have created and enforced rules that emulate the terms of their licensing agreements. The capabilities of AWS License Manager are available through SDK and Tools, besides the management console and CLI.")]
#else
#error Unknown platform constant - unable to set correct AssemblyDescription
#endif

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
[assembly: AssemblyFileVersion("3.7.101.63")]

[assembly: System.CLSCompliant(true)]

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif