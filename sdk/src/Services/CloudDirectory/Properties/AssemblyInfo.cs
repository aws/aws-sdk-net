using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.CloudDirectory")]
#if BCL
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.7.2) - Amazon CloudDirectory. Cloud Directory (CD) is a multi-tenant, hierarchical data store for use by other AWS services to store directory data for AWS resources, including both metadata about resources and policy data governing resources.")]
#elif NETSTANDARD20
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 2.0) - Amazon CloudDirectory. Cloud Directory (CD) is a multi-tenant, hierarchical data store for use by other AWS services to store directory data for AWS resources, including both metadata about resources and policy data governing resources.")]
#elif NETCOREAPP3_1
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET Core 3.1) - Amazon CloudDirectory. Cloud Directory (CD) is a multi-tenant, hierarchical data store for use by other AWS services to store directory data for AWS resources, including both metadata about resources and policy data governing resources.")]
#elif NET8_0
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET 8.0) - Amazon CloudDirectory. Cloud Directory (CD) is a multi-tenant, hierarchical data store for use by other AWS services to store directory data for AWS resources, including both metadata about resources and policy data governing resources.")]
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
[assembly: AssemblyFileVersion("4.0.0.15")]