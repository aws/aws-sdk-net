using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.CognitoSync")]
#if BCL35
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (3.5) - Amazon Cognito Sync. Amazon Cognito is a service that makes it easy to save user data, such as app preferences or game state, in the AWS Cloud without writing any backend code or managing any infrastructure. With Amazon Cognito, you can focus on creating great app experiences instead of having to worry about building and managing a backend solution to handle identity management, network state, storage, and sync.")]
#elif BCL45
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.5) - Amazon Cognito Sync. Amazon Cognito is a service that makes it easy to save user data, such as app preferences or game state, in the AWS Cloud without writing any backend code or managing any infrastructure. With Amazon Cognito, you can focus on creating great app experiences instead of having to worry about building and managing a backend solution to handle identity management, network state, storage, and sync.")]
#elif NETSTANDARD20
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 2.0) - Amazon Cognito Sync. Amazon Cognito is a service that makes it easy to save user data, such as app preferences or game state, in the AWS Cloud without writing any backend code or managing any infrastructure. With Amazon Cognito, you can focus on creating great app experiences instead of having to worry about building and managing a backend solution to handle identity management, network state, storage, and sync.")]
#elif NETCOREAPP3_1
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET Core 3.1) - Amazon Cognito Sync. Amazon Cognito is a service that makes it easy to save user data, such as app preferences or game state, in the AWS Cloud without writing any backend code or managing any infrastructure. With Amazon Cognito, you can focus on creating great app experiences instead of having to worry about building and managing a backend solution to handle identity management, network state, storage, and sync.")]
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
[assembly: AssemblyFileVersion("3.7.100.38")]

[assembly: System.CLSCompliant(true)]

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif