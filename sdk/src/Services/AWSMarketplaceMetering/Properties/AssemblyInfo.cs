using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.AWSMarketplaceMetering")]
#if BCL35
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (3.5) - AWSMarketplace Metering. The AWS Marketplace Metering Service enables sellers to price their products along new pricing dimensions. After a integrating their product with the AWS Marketplace Metering Service, that product will emit an hourly record capturing the usage of any single pricing dimension. Buyers can easily subscribe to software priced by this new dimension on the AWS Marketplace website and only pay for what they use.")]
#elif BCL45
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.5) - AWSMarketplace Metering. The AWS Marketplace Metering Service enables sellers to price their products along new pricing dimensions. After a integrating their product with the AWS Marketplace Metering Service, that product will emit an hourly record capturing the usage of any single pricing dimension. Buyers can easily subscribe to software priced by this new dimension on the AWS Marketplace website and only pay for what they use.")]
#elif NETSTANDARD13
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 1.3) - AWSMarketplace Metering. The AWS Marketplace Metering Service enables sellers to price their products along new pricing dimensions. After a integrating their product with the AWS Marketplace Metering Service, that product will emit an hourly record capturing the usage of any single pricing dimension. Buyers can easily subscribe to software priced by this new dimension on the AWS Marketplace website and only pay for what they use.")]
#elif NETSTANDARD20
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 2.0) - AWSMarketplace Metering. The AWS Marketplace Metering Service enables sellers to price their products along new pricing dimensions. After a integrating their product with the AWS Marketplace Metering Service, that product will emit an hourly record capturing the usage of any single pricing dimension. Buyers can easily subscribe to software priced by this new dimension on the AWS Marketplace website and only pay for what they use.")]
#elif NETCOREAPP3_1
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET Core 3.1) - AWSMarketplace Metering. The AWS Marketplace Metering Service enables sellers to price their products along new pricing dimensions. After a integrating their product with the AWS Marketplace Metering Service, that product will emit an hourly record capturing the usage of any single pricing dimension. Buyers can easily subscribe to software priced by this new dimension on the AWS Marketplace website and only pay for what they use.")]
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
[assembly: AssemblyFileVersion("3.5.1.23")]

[assembly: System.CLSCompliant(true)]

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif