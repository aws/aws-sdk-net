using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.SecretsManager")]
#if BCL35
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (3.5) - AWS Secrets Manager. AWS Secrets Manager enables you to easily create and manage the secrets that you use in your customer-facing apps. Instead of embedding credentials into your source code, you can dynamically query Secrets Manager from your app whenever you need credentials. You can automatically and frequently rotate your secrets without having to deploy updates to your apps. All secret values are encrypted when they're at rest with AWS KMS, and while they're in transit with HTTPS and TLS.")]
#elif BCL45
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.5) - AWS Secrets Manager. AWS Secrets Manager enables you to easily create and manage the secrets that you use in your customer-facing apps. Instead of embedding credentials into your source code, you can dynamically query Secrets Manager from your app whenever you need credentials. You can automatically and frequently rotate your secrets without having to deploy updates to your apps. All secret values are encrypted when they're at rest with AWS KMS, and while they're in transit with HTTPS and TLS.")]
#elif NETSTANDARD20
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 2.0) - AWS Secrets Manager. AWS Secrets Manager enables you to easily create and manage the secrets that you use in your customer-facing apps. Instead of embedding credentials into your source code, you can dynamically query Secrets Manager from your app whenever you need credentials. You can automatically and frequently rotate your secrets without having to deploy updates to your apps. All secret values are encrypted when they're at rest with AWS KMS, and while they're in transit with HTTPS and TLS.")]
#elif NETCOREAPP3_1
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET Core 3.1) - AWS Secrets Manager. AWS Secrets Manager enables you to easily create and manage the secrets that you use in your customer-facing apps. Instead of embedding credentials into your source code, you can dynamically query Secrets Manager from your app whenever you need credentials. You can automatically and frequently rotate your secrets without having to deploy updates to your apps. All secret values are encrypted when they're at rest with AWS KMS, and while they're in transit with HTTPS and TLS.")]
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
[assembly: AssemblyFileVersion("3.7.101.0")]

[assembly: System.CLSCompliant(true)]

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif