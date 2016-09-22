using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.SimpleNotificationService")]
#if BCL35
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (3.5) - Amazon Simple Notification Service. Amazon Simple Notification Service (Amazon SNS) is a fast, flexible, fully managed push messaging service. Amazon SNS makes it simple and cost-effective to push notifications to Apple, Google, Fire OS, and Windows devices, as well as Android devices in China with Baidu Cloud Push.  You can also use SNS to push notifications to internet connected smart devices, as well as other distributed services.")]
#elif BCL45
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.5) - Amazon Simple Notification Service. Amazon Simple Notification Service (Amazon SNS) is a fast, flexible, fully managed push messaging service. Amazon SNS makes it simple and cost-effective to push notifications to Apple, Google, Fire OS, and Windows devices, as well as Android devices in China with Baidu Cloud Push.  You can also use SNS to push notifications to internet connected smart devices, as well as other distributed services.")]
#elif PCL
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (PCL) -  Amazon Simple Notification Service. Amazon Simple Notification Service (Amazon SNS) is a fast, flexible, fully managed push messaging service. Amazon SNS makes it simple and cost-effective to push notifications to Apple, Google, Fire OS, and Windows devices, as well as Android devices in China with Baidu Cloud Push.  You can also use SNS to push notifications to internet connected smart devices, as well as other distributed services.")]
#elif UNITY
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (Unity) - Amazon Simple Notification Service. Amazon Simple Notification Service (Amazon SNS) is a fast, flexible, fully managed push messaging service. Amazon SNS makes it simple and cost-effective to push notifications to Apple, Google, Fire OS, and Windows devices, as well as Android devices in China with Baidu Cloud Push.  You can also use SNS to push notifications to internet connected smart devices, as well as other distributed services.")]
#elif CORECLR
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (CoreCLR)- Amazon Simple Notification Service. Amazon Simple Notification Service (Amazon SNS) is a fast, flexible, fully managed push messaging service. Amazon SNS makes it simple and cost-effective to push notifications to Apple, Google, Fire OS, and Windows devices, as well as Android devices in China with Baidu Cloud Push.  You can also use SNS to push notifications to internet connected smart devices, as well as other distributed services.")]
#else
#error Unknown platform constant - unable to set correct AssemblyDescription
#endif

[assembly: AssemblyConfiguration("")]
[assembly: AssemblyProduct("Amazon Web Services SDK for .NET")]
[assembly: AssemblyCompany("Amazon.com, Inc")]
[assembly: AssemblyCopyright("Copyright 2009-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.")]
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
[assembly: AssemblyFileVersion("3.3.0.0")]

#if WINDOWS_PHONE || UNITY
[assembly: System.CLSCompliant(false)]
# else
[assembly: System.CLSCompliant(true)]
#endif

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif