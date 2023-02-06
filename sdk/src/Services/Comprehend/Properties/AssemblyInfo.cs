using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.Comprehend")]
#if BCL35
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (3.5) - Amazon Comprehend. Amazon Comprehend is an AWS service for gaining insight into the content of text and documents. It can be used to determine the topics contained in your documents, the topics they discuss, the  predominant sentiment expressed in them, the predominant language used, and more. For more information, go to the Amazon Comprehend product page. To get started, see the Amazon Comprehend Developer Guide.")]
#elif BCL45
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.5) - Amazon Comprehend. Amazon Comprehend is an AWS service for gaining insight into the content of text and documents. It can be used to determine the topics contained in your documents, the topics they discuss, the  predominant sentiment expressed in them, the predominant language used, and more. For more information, go to the Amazon Comprehend product page. To get started, see the Amazon Comprehend Developer Guide.")]
#elif NETSTANDARD20
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 2.0) - Amazon Comprehend. Amazon Comprehend is an AWS service for gaining insight into the content of text and documents. It can be used to determine the topics contained in your documents, the topics they discuss, the  predominant sentiment expressed in them, the predominant language used, and more. For more information, go to the Amazon Comprehend product page. To get started, see the Amazon Comprehend Developer Guide.")]
#elif NETCOREAPP3_1
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (.NET Core 3.1) - Amazon Comprehend. Amazon Comprehend is an AWS service for gaining insight into the content of text and documents. It can be used to determine the topics contained in your documents, the topics they discuss, the  predominant sentiment expressed in them, the predominant language used, and more. For more information, go to the Amazon Comprehend product page. To get started, see the Amazon Comprehend Developer Guide.")]
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
[assembly: AssemblyFileVersion("3.7.101.41")]

[assembly: System.CLSCompliant(true)]

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif