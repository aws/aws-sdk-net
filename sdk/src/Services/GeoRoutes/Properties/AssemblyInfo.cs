using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.GeoRoutes")]
#if BCL
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.7.2) - Amazon Location Service Routes V2. Release of Amazon Location Routes API. Routes enables you to plan efficient routes and streamline deliveries by leveraging real-time traffic, vehicle restrictions, and turn-by-turn directions.")]
#elif NETSTANDARD20
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 2.0) - Amazon Location Service Routes V2. Release of Amazon Location Routes API. Routes enables you to plan efficient routes and streamline deliveries by leveraging real-time traffic, vehicle restrictions, and turn-by-turn directions.")]
#elif NETCOREAPP3_1
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET Core 3.1) - Amazon Location Service Routes V2. Release of Amazon Location Routes API. Routes enables you to plan efficient routes and streamline deliveries by leveraging real-time traffic, vehicle restrictions, and turn-by-turn directions.")]
#elif NET8_0
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET 8.0) - Amazon Location Service Routes V2. Release of Amazon Location Routes API. Routes enables you to plan efficient routes and streamline deliveries by leveraging real-time traffic, vehicle restrictions, and turn-by-turn directions.")]
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
[assembly: AssemblyFileVersion("4.0.0.2")]