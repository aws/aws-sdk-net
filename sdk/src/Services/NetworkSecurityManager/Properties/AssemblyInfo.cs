using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.NetworkSecurityManager")]

#if NET472
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET Framework 4.7.2) - AWS Network Security Manager Customer API. AWS Network Security Manager is a new service that helps you centrally configure, deploy, and continuously enforce security policies on network security services across the accounts and resources in your AWS Organization.")]

#elif NETSTANDARD2_0
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 2.0) - AWS Network Security Manager Customer API. AWS Network Security Manager is a new service that helps you centrally configure, deploy, and continuously enforce security policies on network security services across the accounts and resources in your AWS Organization.")]

#elif NETCOREAPP3_1
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET Core 3.1) - AWS Network Security Manager Customer API. AWS Network Security Manager is a new service that helps you centrally configure, deploy, and continuously enforce security policies on network security services across the accounts and resources in your AWS Organization.")]

#elif NET8_0
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET 8.0) - AWS Network Security Manager Customer API. AWS Network Security Manager is a new service that helps you centrally configure, deploy, and continuously enforce security policies on network security services across the accounts and resources in your AWS Organization.")]

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
[assembly: AssemblyVersion("4.0")]
[assembly: AssemblyFileVersion("4.0")]