using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.SimpleEmail")]
#if BCL35
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (3.5) - Amazon Simple Email Service. Amazon SES is an outbound-only email-sending service that provides an easy, cost-effective way for you to send email.")]
#elif BCL45
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.5) - Amazon Simple Email Service. Amazon SES is an outbound-only email-sending service that provides an easy, cost-effective way for you to send email.")]
#elif (WIN_RT && WINDOWS_PHONE)
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (Portable)- Amazon Simple Email Service. Amazon SES is an outbound-only email-sending service that provides an easy, cost-effective way for you to send email.")]
#elif WIN_RT
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (Windows RT) - Amazon Simple Email Service. Amazon SES is an outbound-only email-sending service that provides an easy, cost-effective way for you to send email.")]
#elif WINDOWS_PHONE
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (Windows Phone 8)- Amazon Simple Email Service. Amazon SES is an outbound-only email-sending service that provides an easy, cost-effective way for you to send email.")]
#else
#error Unknown platform constant - unable to set correct AssemblyDescription
#endif

[assembly: AssemblyConfiguration("")]
[assembly: AssemblyProduct("Amazon Web Services SDK for .NET")]
[assembly: AssemblyCompany("Amazon.com, Inc")]
[assembly: AssemblyCopyright("Copyright 2009-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.")]
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
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: System.CLSCompliant(true)]
[assembly: System.Security.AllowPartiallyTrustedCallers]
[assembly: InternalsVisibleTo("AWS.TraceListener,PublicKey=00240000048000009400000006020000002400005253413100040000010001006fe30670d8799591454f4143052b981d91d512647d0bff5a85c74bd9ce24413d9d91073cac76063f129c23c155e46433945d01a9d11d6d5207415b8a2a9cf2796507b677cceeca801c4824c3b27b2cfe9a6eaae4ea961013eb9a193159b9867fc9ecc03d650c07fd773e25c204b6c5aa546f736ccf391761c2a815ef175c3dc6")]
[assembly: InternalsVisibleTo("AWS.SessionProvider,PublicKey=00240000048000009400000006020000002400005253413100040000010001006fe30670d8799591454f4143052b981d91d512647d0bff5a85c74bd9ce24413d9d91073cac76063f129c23c155e46433945d01a9d11d6d5207415b8a2a9cf2796507b677cceeca801c4824c3b27b2cfe9a6eaae4ea961013eb9a193159b9867fc9ecc03d650c07fd773e25c204b6c5aa546f736ccf391761c2a815ef175c3dc6")]