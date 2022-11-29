/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Lambda
{

    /// <summary>
    /// Constants used for properties of type Architecture.
    /// </summary>
    public class Architecture : ConstantClass
    {

        /// <summary>
        /// Constant Arm64 for Architecture
        /// </summary>
        public static readonly Architecture Arm64 = new Architecture("arm64");
        /// <summary>
        /// Constant X86_64 for Architecture
        /// </summary>
        public static readonly Architecture X86_64 = new Architecture("x86_64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Architecture(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Architecture FindValue(string value)
        {
            return FindValue<Architecture>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Architecture(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeSigningPolicy.
    /// </summary>
    public class CodeSigningPolicy : ConstantClass
    {

        /// <summary>
        /// Constant Enforce for CodeSigningPolicy
        /// </summary>
        public static readonly CodeSigningPolicy Enforce = new CodeSigningPolicy("Enforce");
        /// <summary>
        /// Constant Warn for CodeSigningPolicy
        /// </summary>
        public static readonly CodeSigningPolicy Warn = new CodeSigningPolicy("Warn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeSigningPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeSigningPolicy FindValue(string value)
        {
            return FindValue<CodeSigningPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeSigningPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndPointType.
    /// </summary>
    public class EndPointType : ConstantClass
    {

        /// <summary>
        /// Constant KAFKA_BOOTSTRAP_SERVERS for EndPointType
        /// </summary>
        public static readonly EndPointType KAFKA_BOOTSTRAP_SERVERS = new EndPointType("KAFKA_BOOTSTRAP_SERVERS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndPointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndPointType FindValue(string value)
        {
            return FindValue<EndPointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndPointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventSourcePosition.
    /// </summary>
    public class EventSourcePosition : ConstantClass
    {

        /// <summary>
        /// Constant AT_TIMESTAMP for EventSourcePosition
        /// </summary>
        public static readonly EventSourcePosition AT_TIMESTAMP = new EventSourcePosition("AT_TIMESTAMP");
        /// <summary>
        /// Constant LATEST for EventSourcePosition
        /// </summary>
        public static readonly EventSourcePosition LATEST = new EventSourcePosition("LATEST");
        /// <summary>
        /// Constant TRIM_HORIZON for EventSourcePosition
        /// </summary>
        public static readonly EventSourcePosition TRIM_HORIZON = new EventSourcePosition("TRIM_HORIZON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventSourcePosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSourcePosition FindValue(string value)
        {
            return FindValue<EventSourcePosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventSourcePosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FunctionResponseType.
    /// </summary>
    public class FunctionResponseType : ConstantClass
    {

        /// <summary>
        /// Constant ReportBatchItemFailures for FunctionResponseType
        /// </summary>
        public static readonly FunctionResponseType ReportBatchItemFailures = new FunctionResponseType("ReportBatchItemFailures");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FunctionResponseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FunctionResponseType FindValue(string value)
        {
            return FindValue<FunctionResponseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FunctionResponseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FunctionUrlAuthType.
    /// </summary>
    public class FunctionUrlAuthType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_IAM for FunctionUrlAuthType
        /// </summary>
        public static readonly FunctionUrlAuthType AWS_IAM = new FunctionUrlAuthType("AWS_IAM");
        /// <summary>
        /// Constant NONE for FunctionUrlAuthType
        /// </summary>
        public static readonly FunctionUrlAuthType NONE = new FunctionUrlAuthType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FunctionUrlAuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FunctionUrlAuthType FindValue(string value)
        {
            return FindValue<FunctionUrlAuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FunctionUrlAuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FunctionVersion.
    /// </summary>
    public class FunctionVersion : ConstantClass
    {

        /// <summary>
        /// Constant ALL for FunctionVersion
        /// </summary>
        public static readonly FunctionVersion ALL = new FunctionVersion("ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FunctionVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FunctionVersion FindValue(string value)
        {
            return FindValue<FunctionVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FunctionVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvocationType.
    /// </summary>
    public class InvocationType : ConstantClass
    {

        /// <summary>
        /// Constant DryRun for InvocationType
        /// </summary>
        public static readonly InvocationType DryRun = new InvocationType("DryRun");
        /// <summary>
        /// Constant Event for InvocationType
        /// </summary>
        public static readonly InvocationType Event = new InvocationType("Event");
        /// <summary>
        /// Constant RequestResponse for InvocationType
        /// </summary>
        public static readonly InvocationType RequestResponse = new InvocationType("RequestResponse");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvocationType FindValue(string value)
        {
            return FindValue<InvocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LastUpdateStatus.
    /// </summary>
    public class LastUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for LastUpdateStatus
        /// </summary>
        public static readonly LastUpdateStatus Failed = new LastUpdateStatus("Failed");
        /// <summary>
        /// Constant InProgress for LastUpdateStatus
        /// </summary>
        public static readonly LastUpdateStatus InProgress = new LastUpdateStatus("InProgress");
        /// <summary>
        /// Constant Successful for LastUpdateStatus
        /// </summary>
        public static readonly LastUpdateStatus Successful = new LastUpdateStatus("Successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LastUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LastUpdateStatus FindValue(string value)
        {
            return FindValue<LastUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LastUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LastUpdateStatusReasonCode.
    /// </summary>
    public class LastUpdateStatusReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant DisabledKMSKey for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode DisabledKMSKey = new LastUpdateStatusReasonCode("DisabledKMSKey");
        /// <summary>
        /// Constant EFSIOError for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode EFSIOError = new LastUpdateStatusReasonCode("EFSIOError");
        /// <summary>
        /// Constant EFSMountConnectivityError for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode EFSMountConnectivityError = new LastUpdateStatusReasonCode("EFSMountConnectivityError");
        /// <summary>
        /// Constant EFSMountFailure for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode EFSMountFailure = new LastUpdateStatusReasonCode("EFSMountFailure");
        /// <summary>
        /// Constant EFSMountTimeout for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode EFSMountTimeout = new LastUpdateStatusReasonCode("EFSMountTimeout");
        /// <summary>
        /// Constant EniLimitExceeded for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode EniLimitExceeded = new LastUpdateStatusReasonCode("EniLimitExceeded");
        /// <summary>
        /// Constant FunctionError for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode FunctionError = new LastUpdateStatusReasonCode("FunctionError");
        /// <summary>
        /// Constant ImageAccessDenied for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode ImageAccessDenied = new LastUpdateStatusReasonCode("ImageAccessDenied");
        /// <summary>
        /// Constant ImageDeleted for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode ImageDeleted = new LastUpdateStatusReasonCode("ImageDeleted");
        /// <summary>
        /// Constant InsufficientRolePermissions for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InsufficientRolePermissions = new LastUpdateStatusReasonCode("InsufficientRolePermissions");
        /// <summary>
        /// Constant InternalError for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InternalError = new LastUpdateStatusReasonCode("InternalError");
        /// <summary>
        /// Constant InvalidConfiguration for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InvalidConfiguration = new LastUpdateStatusReasonCode("InvalidConfiguration");
        /// <summary>
        /// Constant InvalidImage for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InvalidImage = new LastUpdateStatusReasonCode("InvalidImage");
        /// <summary>
        /// Constant InvalidRuntime for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InvalidRuntime = new LastUpdateStatusReasonCode("InvalidRuntime");
        /// <summary>
        /// Constant InvalidSecurityGroup for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InvalidSecurityGroup = new LastUpdateStatusReasonCode("InvalidSecurityGroup");
        /// <summary>
        /// Constant InvalidStateKMSKey for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InvalidStateKMSKey = new LastUpdateStatusReasonCode("InvalidStateKMSKey");
        /// <summary>
        /// Constant InvalidSubnet for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InvalidSubnet = new LastUpdateStatusReasonCode("InvalidSubnet");
        /// <summary>
        /// Constant InvalidZipFileException for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InvalidZipFileException = new LastUpdateStatusReasonCode("InvalidZipFileException");
        /// <summary>
        /// Constant KMSKeyAccessDenied for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode KMSKeyAccessDenied = new LastUpdateStatusReasonCode("KMSKeyAccessDenied");
        /// <summary>
        /// Constant KMSKeyNotFound for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode KMSKeyNotFound = new LastUpdateStatusReasonCode("KMSKeyNotFound");
        /// <summary>
        /// Constant SubnetOutOfIPAddresses for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode SubnetOutOfIPAddresses = new LastUpdateStatusReasonCode("SubnetOutOfIPAddresses");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LastUpdateStatusReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LastUpdateStatusReasonCode FindValue(string value)
        {
            return FindValue<LastUpdateStatusReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LastUpdateStatusReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogType.
    /// </summary>
    public class LogType : ConstantClass
    {

        /// <summary>
        /// Constant None for LogType
        /// </summary>
        public static readonly LogType None = new LogType("None");
        /// <summary>
        /// Constant Tail for LogType
        /// </summary>
        public static readonly LogType Tail = new LogType("Tail");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogType FindValue(string value)
        {
            return FindValue<LogType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageType.
    /// </summary>
    public class PackageType : ConstantClass
    {

        /// <summary>
        /// Constant Image for PackageType
        /// </summary>
        public static readonly PackageType Image = new PackageType("Image");
        /// <summary>
        /// Constant Zip for PackageType
        /// </summary>
        public static readonly PackageType Zip = new PackageType("Zip");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageType FindValue(string value)
        {
            return FindValue<PackageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisionedConcurrencyStatusEnum.
    /// </summary>
    public class ProvisionedConcurrencyStatusEnum : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ProvisionedConcurrencyStatusEnum
        /// </summary>
        public static readonly ProvisionedConcurrencyStatusEnum FAILED = new ProvisionedConcurrencyStatusEnum("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ProvisionedConcurrencyStatusEnum
        /// </summary>
        public static readonly ProvisionedConcurrencyStatusEnum IN_PROGRESS = new ProvisionedConcurrencyStatusEnum("IN_PROGRESS");
        /// <summary>
        /// Constant READY for ProvisionedConcurrencyStatusEnum
        /// </summary>
        public static readonly ProvisionedConcurrencyStatusEnum READY = new ProvisionedConcurrencyStatusEnum("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisionedConcurrencyStatusEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisionedConcurrencyStatusEnum FindValue(string value)
        {
            return FindValue<ProvisionedConcurrencyStatusEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisionedConcurrencyStatusEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Runtime.
    /// </summary>
    public class Runtime : ConstantClass
    {

        /// <summary>
        /// Constant Dotnet6 for Runtime
        /// </summary>
        public static readonly Runtime Dotnet6 = new Runtime("dotnet6");
        /// <summary>
        /// Constant Dotnetcore10 for Runtime
        /// </summary>
        public static readonly Runtime Dotnetcore10 = new Runtime("dotnetcore1.0");
        /// <summary>
        /// Constant Dotnetcore20 for Runtime
        /// </summary>
        public static readonly Runtime Dotnetcore20 = new Runtime("dotnetcore2.0");
        /// <summary>
        /// Constant Dotnetcore21 for Runtime
        /// </summary>
        public static readonly Runtime Dotnetcore21 = new Runtime("dotnetcore2.1");
        /// <summary>
        /// Constant Dotnetcore31 for Runtime
        /// </summary>
        public static readonly Runtime Dotnetcore31 = new Runtime("dotnetcore3.1");
        /// <summary>
        /// Constant Go1X for Runtime
        /// </summary>
        public static readonly Runtime Go1X = new Runtime("go1.x");
        /// <summary>
        /// Constant Java11 for Runtime
        /// </summary>
        public static readonly Runtime Java11 = new Runtime("java11");
        /// <summary>
        /// Constant Java8 for Runtime
        /// </summary>
        public static readonly Runtime Java8 = new Runtime("java8");
        /// <summary>
        /// Constant Java8Al2 for Runtime
        /// </summary>
        public static readonly Runtime Java8Al2 = new Runtime("java8.al2");
        /// <summary>
        /// Constant Nodejs for Runtime
        /// </summary>
        public static readonly Runtime Nodejs = new Runtime("nodejs");
        /// <summary>
        /// Constant Nodejs10X for Runtime
        /// </summary>
        public static readonly Runtime Nodejs10X = new Runtime("nodejs10.x");
        /// <summary>
        /// Constant Nodejs12X for Runtime
        /// </summary>
        public static readonly Runtime Nodejs12X = new Runtime("nodejs12.x");
        /// <summary>
        /// Constant Nodejs14X for Runtime
        /// </summary>
        public static readonly Runtime Nodejs14X = new Runtime("nodejs14.x");
        /// <summary>
        /// Constant Nodejs16X for Runtime
        /// </summary>
        public static readonly Runtime Nodejs16X = new Runtime("nodejs16.x");
        /// <summary>
        /// Constant Nodejs18X for Runtime
        /// </summary>
        public static readonly Runtime Nodejs18X = new Runtime("nodejs18.x");
        /// <summary>
        /// Constant Nodejs43 for Runtime
        /// </summary>
        public static readonly Runtime Nodejs43 = new Runtime("nodejs4.3");
        /// <summary>
        /// Constant Nodejs43Edge for Runtime
        /// </summary>
        public static readonly Runtime Nodejs43Edge = new Runtime("nodejs4.3-edge");
        /// <summary>
        /// Constant Nodejs610 for Runtime
        /// </summary>
        public static readonly Runtime Nodejs610 = new Runtime("nodejs6.10");
        /// <summary>
        /// Constant Nodejs810 for Runtime
        /// </summary>
        public static readonly Runtime Nodejs810 = new Runtime("nodejs8.10");
        /// <summary>
        /// Constant Provided for Runtime
        /// </summary>
        public static readonly Runtime Provided = new Runtime("provided");
        /// <summary>
        /// Constant ProvidedAl2 for Runtime
        /// </summary>
        public static readonly Runtime ProvidedAl2 = new Runtime("provided.al2");
        /// <summary>
        /// Constant Python27 for Runtime
        /// </summary>
        public static readonly Runtime Python27 = new Runtime("python2.7");
        /// <summary>
        /// Constant Python36 for Runtime
        /// </summary>
        public static readonly Runtime Python36 = new Runtime("python3.6");
        /// <summary>
        /// Constant Python37 for Runtime
        /// </summary>
        public static readonly Runtime Python37 = new Runtime("python3.7");
        /// <summary>
        /// Constant Python38 for Runtime
        /// </summary>
        public static readonly Runtime Python38 = new Runtime("python3.8");
        /// <summary>
        /// Constant Python39 for Runtime
        /// </summary>
        public static readonly Runtime Python39 = new Runtime("python3.9");
        /// <summary>
        /// Constant Ruby25 for Runtime
        /// </summary>
        public static readonly Runtime Ruby25 = new Runtime("ruby2.5");
        /// <summary>
        /// Constant Ruby27 for Runtime
        /// </summary>
        public static readonly Runtime Ruby27 = new Runtime("ruby2.7");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Runtime(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Runtime FindValue(string value)
        {
            return FindValue<Runtime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Runtime(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapStartApplyOn.
    /// </summary>
    public class SnapStartApplyOn : ConstantClass
    {

        /// <summary>
        /// Constant None for SnapStartApplyOn
        /// </summary>
        public static readonly SnapStartApplyOn None = new SnapStartApplyOn("None");
        /// <summary>
        /// Constant PublishedVersions for SnapStartApplyOn
        /// </summary>
        public static readonly SnapStartApplyOn PublishedVersions = new SnapStartApplyOn("PublishedVersions");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapStartApplyOn(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapStartApplyOn FindValue(string value)
        {
            return FindValue<SnapStartApplyOn>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapStartApplyOn(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapStartOptimizationStatus.
    /// </summary>
    public class SnapStartOptimizationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Off for SnapStartOptimizationStatus
        /// </summary>
        public static readonly SnapStartOptimizationStatus Off = new SnapStartOptimizationStatus("Off");
        /// <summary>
        /// Constant On for SnapStartOptimizationStatus
        /// </summary>
        public static readonly SnapStartOptimizationStatus On = new SnapStartOptimizationStatus("On");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapStartOptimizationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapStartOptimizationStatus FindValue(string value)
        {
            return FindValue<SnapStartOptimizationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapStartOptimizationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceAccessType.
    /// </summary>
    public class SourceAccessType : ConstantClass
    {

        /// <summary>
        /// Constant BASIC_AUTH for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType BASIC_AUTH = new SourceAccessType("BASIC_AUTH");
        /// <summary>
        /// Constant CLIENT_CERTIFICATE_TLS_AUTH for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType CLIENT_CERTIFICATE_TLS_AUTH = new SourceAccessType("CLIENT_CERTIFICATE_TLS_AUTH");
        /// <summary>
        /// Constant SASL_SCRAM_256_AUTH for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType SASL_SCRAM_256_AUTH = new SourceAccessType("SASL_SCRAM_256_AUTH");
        /// <summary>
        /// Constant SASL_SCRAM_512_AUTH for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType SASL_SCRAM_512_AUTH = new SourceAccessType("SASL_SCRAM_512_AUTH");
        /// <summary>
        /// Constant SERVER_ROOT_CA_CERTIFICATE for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType SERVER_ROOT_CA_CERTIFICATE = new SourceAccessType("SERVER_ROOT_CA_CERTIFICATE");
        /// <summary>
        /// Constant VIRTUAL_HOST for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType VIRTUAL_HOST = new SourceAccessType("VIRTUAL_HOST");
        /// <summary>
        /// Constant VPC_SECURITY_GROUP for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType VPC_SECURITY_GROUP = new SourceAccessType("VPC_SECURITY_GROUP");
        /// <summary>
        /// Constant VPC_SUBNET for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType VPC_SUBNET = new SourceAccessType("VPC_SUBNET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceAccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceAccessType FindValue(string value)
        {
            return FindValue<SourceAccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceAccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type State.
    /// </summary>
    public class State : ConstantClass
    {

        /// <summary>
        /// Constant Active for State
        /// </summary>
        public static readonly State Active = new State("Active");
        /// <summary>
        /// Constant Failed for State
        /// </summary>
        public static readonly State Failed = new State("Failed");
        /// <summary>
        /// Constant Inactive for State
        /// </summary>
        public static readonly State Inactive = new State("Inactive");
        /// <summary>
        /// Constant Pending for State
        /// </summary>
        public static readonly State Pending = new State("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public State(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static State FindValue(string value)
        {
            return FindValue<State>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator State(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StateReasonCode.
    /// </summary>
    public class StateReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant Creating for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode Creating = new StateReasonCode("Creating");
        /// <summary>
        /// Constant DisabledKMSKey for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode DisabledKMSKey = new StateReasonCode("DisabledKMSKey");
        /// <summary>
        /// Constant EFSIOError for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode EFSIOError = new StateReasonCode("EFSIOError");
        /// <summary>
        /// Constant EFSMountConnectivityError for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode EFSMountConnectivityError = new StateReasonCode("EFSMountConnectivityError");
        /// <summary>
        /// Constant EFSMountFailure for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode EFSMountFailure = new StateReasonCode("EFSMountFailure");
        /// <summary>
        /// Constant EFSMountTimeout for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode EFSMountTimeout = new StateReasonCode("EFSMountTimeout");
        /// <summary>
        /// Constant EniLimitExceeded for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode EniLimitExceeded = new StateReasonCode("EniLimitExceeded");
        /// <summary>
        /// Constant FunctionError for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode FunctionError = new StateReasonCode("FunctionError");
        /// <summary>
        /// Constant Idle for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode Idle = new StateReasonCode("Idle");
        /// <summary>
        /// Constant ImageAccessDenied for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode ImageAccessDenied = new StateReasonCode("ImageAccessDenied");
        /// <summary>
        /// Constant ImageDeleted for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode ImageDeleted = new StateReasonCode("ImageDeleted");
        /// <summary>
        /// Constant InsufficientRolePermissions for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InsufficientRolePermissions = new StateReasonCode("InsufficientRolePermissions");
        /// <summary>
        /// Constant InternalError for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InternalError = new StateReasonCode("InternalError");
        /// <summary>
        /// Constant InvalidConfiguration for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InvalidConfiguration = new StateReasonCode("InvalidConfiguration");
        /// <summary>
        /// Constant InvalidImage for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InvalidImage = new StateReasonCode("InvalidImage");
        /// <summary>
        /// Constant InvalidRuntime for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InvalidRuntime = new StateReasonCode("InvalidRuntime");
        /// <summary>
        /// Constant InvalidSecurityGroup for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InvalidSecurityGroup = new StateReasonCode("InvalidSecurityGroup");
        /// <summary>
        /// Constant InvalidStateKMSKey for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InvalidStateKMSKey = new StateReasonCode("InvalidStateKMSKey");
        /// <summary>
        /// Constant InvalidSubnet for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InvalidSubnet = new StateReasonCode("InvalidSubnet");
        /// <summary>
        /// Constant InvalidZipFileException for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InvalidZipFileException = new StateReasonCode("InvalidZipFileException");
        /// <summary>
        /// Constant KMSKeyAccessDenied for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode KMSKeyAccessDenied = new StateReasonCode("KMSKeyAccessDenied");
        /// <summary>
        /// Constant KMSKeyNotFound for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode KMSKeyNotFound = new StateReasonCode("KMSKeyNotFound");
        /// <summary>
        /// Constant Restoring for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode Restoring = new StateReasonCode("Restoring");
        /// <summary>
        /// Constant SubnetOutOfIPAddresses for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode SubnetOutOfIPAddresses = new StateReasonCode("SubnetOutOfIPAddresses");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StateReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StateReasonCode FindValue(string value)
        {
            return FindValue<StateReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StateReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThrottleReason.
    /// </summary>
    public class ThrottleReason : ConstantClass
    {

        /// <summary>
        /// Constant CallerRateLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason CallerRateLimitExceeded = new ThrottleReason("CallerRateLimitExceeded");
        /// <summary>
        /// Constant ConcurrentInvocationLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason ConcurrentInvocationLimitExceeded = new ThrottleReason("ConcurrentInvocationLimitExceeded");
        /// <summary>
        /// Constant ConcurrentSnapshotCreateLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason ConcurrentSnapshotCreateLimitExceeded = new ThrottleReason("ConcurrentSnapshotCreateLimitExceeded");
        /// <summary>
        /// Constant FunctionInvocationRateLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason FunctionInvocationRateLimitExceeded = new ThrottleReason("FunctionInvocationRateLimitExceeded");
        /// <summary>
        /// Constant ReservedFunctionConcurrentInvocationLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason ReservedFunctionConcurrentInvocationLimitExceeded = new ThrottleReason("ReservedFunctionConcurrentInvocationLimitExceeded");
        /// <summary>
        /// Constant ReservedFunctionInvocationRateLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason ReservedFunctionInvocationRateLimitExceeded = new ThrottleReason("ReservedFunctionInvocationRateLimitExceeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThrottleReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThrottleReason FindValue(string value)
        {
            return FindValue<ThrottleReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThrottleReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TracingMode.
    /// </summary>
    public class TracingMode : ConstantClass
    {

        /// <summary>
        /// Constant Active for TracingMode
        /// </summary>
        public static readonly TracingMode Active = new TracingMode("Active");
        /// <summary>
        /// Constant PassThrough for TracingMode
        /// </summary>
        public static readonly TracingMode PassThrough = new TracingMode("PassThrough");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TracingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TracingMode FindValue(string value)
        {
            return FindValue<TracingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TracingMode(string value)
        {
            return FindValue(value);
        }
    }

}