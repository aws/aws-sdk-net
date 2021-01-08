using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.HealthLake")]
#if BCL35
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (3.5) - Amazon HealthLake. This release introduces Amazon HealthLake (preview), a HIPAA-eligible service that enables healthcare and life sciences customers to store, transform, query, and analyze health data in the AWS Cloud.")]
#elif BCL45
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.5) - Amazon HealthLake. This release introduces Amazon HealthLake (preview), a HIPAA-eligible service that enables healthcare and life sciences customers to store, transform, query, and analyze health data in the AWS Cloud.")]
#elif NETSTANDARD13
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 1.3) - Amazon HealthLake. This release introduces Amazon HealthLake (preview), a HIPAA-eligible service that enables healthcare and life sciences customers to store, transform, query, and analyze health data in the AWS Cloud.")]
#elif NETSTANDARD20
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 2.0) - Amazon HealthLake. This release introduces Amazon HealthLake (preview), a HIPAA-eligible service that enables healthcare and life sciences customers to store, transform, query, and analyze health data in the AWS Cloud.")]
#elif NETCOREAPP3_1
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET Core 3.1) - Amazon HealthLake. This release introduces Amazon HealthLake (preview), a HIPAA-eligible service that enables healthcare and life sciences customers to store, transform, query, and analyze health data in the AWS Cloud.")]
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
[assembly: AssemblyFileVersion("3.5.1.1")]

[assembly: System.CLSCompliant(true)]

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif