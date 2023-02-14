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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SageMaker
{

    /// <summary>
    /// Constants used for properties of type ActionStatus.
    /// </summary>
    public class ActionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for ActionStatus
        /// </summary>
        public static readonly ActionStatus Completed = new ActionStatus("Completed");
        /// <summary>
        /// Constant Failed for ActionStatus
        /// </summary>
        public static readonly ActionStatus Failed = new ActionStatus("Failed");
        /// <summary>
        /// Constant InProgress for ActionStatus
        /// </summary>
        public static readonly ActionStatus InProgress = new ActionStatus("InProgress");
        /// <summary>
        /// Constant Stopped for ActionStatus
        /// </summary>
        public static readonly ActionStatus Stopped = new ActionStatus("Stopped");
        /// <summary>
        /// Constant Stopping for ActionStatus
        /// </summary>
        public static readonly ActionStatus Stopping = new ActionStatus("Stopping");
        /// <summary>
        /// Constant Unknown for ActionStatus
        /// </summary>
        public static readonly ActionStatus Unknown = new ActionStatus("Unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionStatus FindValue(string value)
        {
            return FindValue<ActionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlgorithmSortBy.
    /// </summary>
    public class AlgorithmSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for AlgorithmSortBy
        /// </summary>
        public static readonly AlgorithmSortBy CreationTime = new AlgorithmSortBy("CreationTime");
        /// <summary>
        /// Constant Name for AlgorithmSortBy
        /// </summary>
        public static readonly AlgorithmSortBy Name = new AlgorithmSortBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlgorithmSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlgorithmSortBy FindValue(string value)
        {
            return FindValue<AlgorithmSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlgorithmSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlgorithmStatus.
    /// </summary>
    public class AlgorithmStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for AlgorithmStatus
        /// </summary>
        public static readonly AlgorithmStatus Completed = new AlgorithmStatus("Completed");
        /// <summary>
        /// Constant Deleting for AlgorithmStatus
        /// </summary>
        public static readonly AlgorithmStatus Deleting = new AlgorithmStatus("Deleting");
        /// <summary>
        /// Constant Failed for AlgorithmStatus
        /// </summary>
        public static readonly AlgorithmStatus Failed = new AlgorithmStatus("Failed");
        /// <summary>
        /// Constant InProgress for AlgorithmStatus
        /// </summary>
        public static readonly AlgorithmStatus InProgress = new AlgorithmStatus("InProgress");
        /// <summary>
        /// Constant Pending for AlgorithmStatus
        /// </summary>
        public static readonly AlgorithmStatus Pending = new AlgorithmStatus("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlgorithmStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlgorithmStatus FindValue(string value)
        {
            return FindValue<AlgorithmStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlgorithmStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppImageConfigSortKey.
    /// </summary>
    public class AppImageConfigSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for AppImageConfigSortKey
        /// </summary>
        public static readonly AppImageConfigSortKey CreationTime = new AppImageConfigSortKey("CreationTime");
        /// <summary>
        /// Constant LastModifiedTime for AppImageConfigSortKey
        /// </summary>
        public static readonly AppImageConfigSortKey LastModifiedTime = new AppImageConfigSortKey("LastModifiedTime");
        /// <summary>
        /// Constant Name for AppImageConfigSortKey
        /// </summary>
        public static readonly AppImageConfigSortKey Name = new AppImageConfigSortKey("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppImageConfigSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppImageConfigSortKey FindValue(string value)
        {
            return FindValue<AppImageConfigSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppImageConfigSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppInstanceType.
    /// </summary>
    public class AppInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC512xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlC512xlarge = new AppInstanceType("ml.c5.12xlarge");
        /// <summary>
        /// Constant MlC518xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlC518xlarge = new AppInstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC524xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlC524xlarge = new AppInstanceType("ml.c5.24xlarge");
        /// <summary>
        /// Constant MlC52xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlC52xlarge = new AppInstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlC54xlarge = new AppInstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlC59xlarge = new AppInstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5Large for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlC5Large = new AppInstanceType("ml.c5.large");
        /// <summary>
        /// Constant MlC5Xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlC5Xlarge = new AppInstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlG4dn12xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlG4dn12xlarge = new AppInstanceType("ml.g4dn.12xlarge");
        /// <summary>
        /// Constant MlG4dn16xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlG4dn16xlarge = new AppInstanceType("ml.g4dn.16xlarge");
        /// <summary>
        /// Constant MlG4dn2xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlG4dn2xlarge = new AppInstanceType("ml.g4dn.2xlarge");
        /// <summary>
        /// Constant MlG4dn4xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlG4dn4xlarge = new AppInstanceType("ml.g4dn.4xlarge");
        /// <summary>
        /// Constant MlG4dn8xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlG4dn8xlarge = new AppInstanceType("ml.g4dn.8xlarge");
        /// <summary>
        /// Constant MlG4dnXlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlG4dnXlarge = new AppInstanceType("ml.g4dn.xlarge");
        /// <summary>
        /// Constant MlG512xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlG512xlarge = new AppInstanceType("ml.g5.12xlarge");
        /// <summary>
        /// Constant MlG516xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlG516xlarge = new AppInstanceType("ml.g5.16xlarge");
        /// <summary>
        /// Constant MlG524xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlG524xlarge = new AppInstanceType("ml.g5.24xlarge");
        /// <summary>
        /// Constant MlG52xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlG52xlarge = new AppInstanceType("ml.g5.2xlarge");
        /// <summary>
        /// Constant MlG548xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlG548xlarge = new AppInstanceType("ml.g5.48xlarge");
        /// <summary>
        /// Constant MlG54xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlG54xlarge = new AppInstanceType("ml.g5.4xlarge");
        /// <summary>
        /// Constant MlG58xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlG58xlarge = new AppInstanceType("ml.g5.8xlarge");
        /// <summary>
        /// Constant MlG5Xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlG5Xlarge = new AppInstanceType("ml.g5.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM512xlarge = new AppInstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM516xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM516xlarge = new AppInstanceType("ml.m5.16xlarge");
        /// <summary>
        /// Constant MlM524xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM524xlarge = new AppInstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM52xlarge = new AppInstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM54xlarge = new AppInstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM58xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM58xlarge = new AppInstanceType("ml.m5.8xlarge");
        /// <summary>
        /// Constant MlM5d12xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM5d12xlarge = new AppInstanceType("ml.m5d.12xlarge");
        /// <summary>
        /// Constant MlM5d16xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM5d16xlarge = new AppInstanceType("ml.m5d.16xlarge");
        /// <summary>
        /// Constant MlM5d24xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM5d24xlarge = new AppInstanceType("ml.m5d.24xlarge");
        /// <summary>
        /// Constant MlM5d2xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM5d2xlarge = new AppInstanceType("ml.m5d.2xlarge");
        /// <summary>
        /// Constant MlM5d4xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM5d4xlarge = new AppInstanceType("ml.m5d.4xlarge");
        /// <summary>
        /// Constant MlM5d8xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM5d8xlarge = new AppInstanceType("ml.m5d.8xlarge");
        /// <summary>
        /// Constant MlM5dLarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM5dLarge = new AppInstanceType("ml.m5d.large");
        /// <summary>
        /// Constant MlM5dXlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM5dXlarge = new AppInstanceType("ml.m5d.xlarge");
        /// <summary>
        /// Constant MlM5Large for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM5Large = new AppInstanceType("ml.m5.large");
        /// <summary>
        /// Constant MlM5Xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlM5Xlarge = new AppInstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlP316xlarge = new AppInstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlP32xlarge = new AppInstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlP38xlarge = new AppInstanceType("ml.p3.8xlarge");
        /// <summary>
        /// Constant MlP3dn24xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlP3dn24xlarge = new AppInstanceType("ml.p3dn.24xlarge");
        /// <summary>
        /// Constant MlR512xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlR512xlarge = new AppInstanceType("ml.r5.12xlarge");
        /// <summary>
        /// Constant MlR516xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlR516xlarge = new AppInstanceType("ml.r5.16xlarge");
        /// <summary>
        /// Constant MlR524xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlR524xlarge = new AppInstanceType("ml.r5.24xlarge");
        /// <summary>
        /// Constant MlR52xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlR52xlarge = new AppInstanceType("ml.r5.2xlarge");
        /// <summary>
        /// Constant MlR54xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlR54xlarge = new AppInstanceType("ml.r5.4xlarge");
        /// <summary>
        /// Constant MlR58xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlR58xlarge = new AppInstanceType("ml.r5.8xlarge");
        /// <summary>
        /// Constant MlR5Large for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlR5Large = new AppInstanceType("ml.r5.large");
        /// <summary>
        /// Constant MlR5Xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlR5Xlarge = new AppInstanceType("ml.r5.xlarge");
        /// <summary>
        /// Constant MlT32xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlT32xlarge = new AppInstanceType("ml.t3.2xlarge");
        /// <summary>
        /// Constant MlT3Large for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlT3Large = new AppInstanceType("ml.t3.large");
        /// <summary>
        /// Constant MlT3Medium for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlT3Medium = new AppInstanceType("ml.t3.medium");
        /// <summary>
        /// Constant MlT3Micro for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlT3Micro = new AppInstanceType("ml.t3.micro");
        /// <summary>
        /// Constant MlT3Small for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlT3Small = new AppInstanceType("ml.t3.small");
        /// <summary>
        /// Constant MlT3Xlarge for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType MlT3Xlarge = new AppInstanceType("ml.t3.xlarge");
        /// <summary>
        /// Constant System for AppInstanceType
        /// </summary>
        public static readonly AppInstanceType System = new AppInstanceType("system");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppInstanceType FindValue(string value)
        {
            return FindValue<AppInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppNetworkAccessType.
    /// </summary>
    public class AppNetworkAccessType : ConstantClass
    {

        /// <summary>
        /// Constant PublicInternetOnly for AppNetworkAccessType
        /// </summary>
        public static readonly AppNetworkAccessType PublicInternetOnly = new AppNetworkAccessType("PublicInternetOnly");
        /// <summary>
        /// Constant VpcOnly for AppNetworkAccessType
        /// </summary>
        public static readonly AppNetworkAccessType VpcOnly = new AppNetworkAccessType("VpcOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppNetworkAccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppNetworkAccessType FindValue(string value)
        {
            return FindValue<AppNetworkAccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppNetworkAccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppSecurityGroupManagement.
    /// </summary>
    public class AppSecurityGroupManagement : ConstantClass
    {

        /// <summary>
        /// Constant Customer for AppSecurityGroupManagement
        /// </summary>
        public static readonly AppSecurityGroupManagement Customer = new AppSecurityGroupManagement("Customer");
        /// <summary>
        /// Constant Service for AppSecurityGroupManagement
        /// </summary>
        public static readonly AppSecurityGroupManagement Service = new AppSecurityGroupManagement("Service");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppSecurityGroupManagement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppSecurityGroupManagement FindValue(string value)
        {
            return FindValue<AppSecurityGroupManagement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppSecurityGroupManagement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppSortKey.
    /// </summary>
    public class AppSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for AppSortKey
        /// </summary>
        public static readonly AppSortKey CreationTime = new AppSortKey("CreationTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppSortKey FindValue(string value)
        {
            return FindValue<AppSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppStatus.
    /// </summary>
    public class AppStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deleted for AppStatus
        /// </summary>
        public static readonly AppStatus Deleted = new AppStatus("Deleted");
        /// <summary>
        /// Constant Deleting for AppStatus
        /// </summary>
        public static readonly AppStatus Deleting = new AppStatus("Deleting");
        /// <summary>
        /// Constant Failed for AppStatus
        /// </summary>
        public static readonly AppStatus Failed = new AppStatus("Failed");
        /// <summary>
        /// Constant InService for AppStatus
        /// </summary>
        public static readonly AppStatus InService = new AppStatus("InService");
        /// <summary>
        /// Constant Pending for AppStatus
        /// </summary>
        public static readonly AppStatus Pending = new AppStatus("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppStatus FindValue(string value)
        {
            return FindValue<AppStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppType.
    /// </summary>
    public class AppType : ConstantClass
    {

        /// <summary>
        /// Constant JupyterServer for AppType
        /// </summary>
        public static readonly AppType JupyterServer = new AppType("JupyterServer");
        /// <summary>
        /// Constant KernelGateway for AppType
        /// </summary>
        public static readonly AppType KernelGateway = new AppType("KernelGateway");
        /// <summary>
        /// Constant RSessionGateway for AppType
        /// </summary>
        public static readonly AppType RSessionGateway = new AppType("RSessionGateway");
        /// <summary>
        /// Constant RStudioServerPro for AppType
        /// </summary>
        public static readonly AppType RStudioServerPro = new AppType("RStudioServerPro");
        /// <summary>
        /// Constant TensorBoard for AppType
        /// </summary>
        public static readonly AppType TensorBoard = new AppType("TensorBoard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppType FindValue(string value)
        {
            return FindValue<AppType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArtifactSourceIdType.
    /// </summary>
    public class ArtifactSourceIdType : ConstantClass
    {

        /// <summary>
        /// Constant Custom for ArtifactSourceIdType
        /// </summary>
        public static readonly ArtifactSourceIdType Custom = new ArtifactSourceIdType("Custom");
        /// <summary>
        /// Constant MD5Hash for ArtifactSourceIdType
        /// </summary>
        public static readonly ArtifactSourceIdType MD5Hash = new ArtifactSourceIdType("MD5Hash");
        /// <summary>
        /// Constant S3ETag for ArtifactSourceIdType
        /// </summary>
        public static readonly ArtifactSourceIdType S3ETag = new ArtifactSourceIdType("S3ETag");
        /// <summary>
        /// Constant S3Version for ArtifactSourceIdType
        /// </summary>
        public static readonly ArtifactSourceIdType S3Version = new ArtifactSourceIdType("S3Version");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactSourceIdType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactSourceIdType FindValue(string value)
        {
            return FindValue<ArtifactSourceIdType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactSourceIdType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssemblyType.
    /// </summary>
    public class AssemblyType : ConstantClass
    {

        /// <summary>
        /// Constant Line for AssemblyType
        /// </summary>
        public static readonly AssemblyType Line = new AssemblyType("Line");
        /// <summary>
        /// Constant None for AssemblyType
        /// </summary>
        public static readonly AssemblyType None = new AssemblyType("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssemblyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssemblyType FindValue(string value)
        {
            return FindValue<AssemblyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssemblyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationEdgeType.
    /// </summary>
    public class AssociationEdgeType : ConstantClass
    {

        /// <summary>
        /// Constant AssociatedWith for AssociationEdgeType
        /// </summary>
        public static readonly AssociationEdgeType AssociatedWith = new AssociationEdgeType("AssociatedWith");
        /// <summary>
        /// Constant ContributedTo for AssociationEdgeType
        /// </summary>
        public static readonly AssociationEdgeType ContributedTo = new AssociationEdgeType("ContributedTo");
        /// <summary>
        /// Constant DerivedFrom for AssociationEdgeType
        /// </summary>
        public static readonly AssociationEdgeType DerivedFrom = new AssociationEdgeType("DerivedFrom");
        /// <summary>
        /// Constant Produced for AssociationEdgeType
        /// </summary>
        public static readonly AssociationEdgeType Produced = new AssociationEdgeType("Produced");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationEdgeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationEdgeType FindValue(string value)
        {
            return FindValue<AssociationEdgeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationEdgeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AthenaResultCompressionType.
    /// </summary>
    public class AthenaResultCompressionType : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for AthenaResultCompressionType
        /// </summary>
        public static readonly AthenaResultCompressionType GZIP = new AthenaResultCompressionType("GZIP");
        /// <summary>
        /// Constant SNAPPY for AthenaResultCompressionType
        /// </summary>
        public static readonly AthenaResultCompressionType SNAPPY = new AthenaResultCompressionType("SNAPPY");
        /// <summary>
        /// Constant ZLIB for AthenaResultCompressionType
        /// </summary>
        public static readonly AthenaResultCompressionType ZLIB = new AthenaResultCompressionType("ZLIB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AthenaResultCompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AthenaResultCompressionType FindValue(string value)
        {
            return FindValue<AthenaResultCompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AthenaResultCompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AthenaResultFormat.
    /// </summary>
    public class AthenaResultFormat : ConstantClass
    {

        /// <summary>
        /// Constant AVRO for AthenaResultFormat
        /// </summary>
        public static readonly AthenaResultFormat AVRO = new AthenaResultFormat("AVRO");
        /// <summary>
        /// Constant JSON for AthenaResultFormat
        /// </summary>
        public static readonly AthenaResultFormat JSON = new AthenaResultFormat("JSON");
        /// <summary>
        /// Constant ORC for AthenaResultFormat
        /// </summary>
        public static readonly AthenaResultFormat ORC = new AthenaResultFormat("ORC");
        /// <summary>
        /// Constant PARQUET for AthenaResultFormat
        /// </summary>
        public static readonly AthenaResultFormat PARQUET = new AthenaResultFormat("PARQUET");
        /// <summary>
        /// Constant TEXTFILE for AthenaResultFormat
        /// </summary>
        public static readonly AthenaResultFormat TEXTFILE = new AthenaResultFormat("TEXTFILE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AthenaResultFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AthenaResultFormat FindValue(string value)
        {
            return FindValue<AthenaResultFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AthenaResultFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthMode.
    /// </summary>
    public class AuthMode : ConstantClass
    {

        /// <summary>
        /// Constant IAM for AuthMode
        /// </summary>
        public static readonly AuthMode IAM = new AuthMode("IAM");
        /// <summary>
        /// Constant SSO for AuthMode
        /// </summary>
        public static readonly AuthMode SSO = new AuthMode("SSO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthMode FindValue(string value)
        {
            return FindValue<AuthMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoMLAlgorithm.
    /// </summary>
    public class AutoMLAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant Catboost for AutoMLAlgorithm
        /// </summary>
        public static readonly AutoMLAlgorithm Catboost = new AutoMLAlgorithm("catboost");
        /// <summary>
        /// Constant ExtraTrees for AutoMLAlgorithm
        /// </summary>
        public static readonly AutoMLAlgorithm ExtraTrees = new AutoMLAlgorithm("extra-trees");
        /// <summary>
        /// Constant Fastai for AutoMLAlgorithm
        /// </summary>
        public static readonly AutoMLAlgorithm Fastai = new AutoMLAlgorithm("fastai");
        /// <summary>
        /// Constant Lightgbm for AutoMLAlgorithm
        /// </summary>
        public static readonly AutoMLAlgorithm Lightgbm = new AutoMLAlgorithm("lightgbm");
        /// <summary>
        /// Constant LinearLearner for AutoMLAlgorithm
        /// </summary>
        public static readonly AutoMLAlgorithm LinearLearner = new AutoMLAlgorithm("linear-learner");
        /// <summary>
        /// Constant Mlp for AutoMLAlgorithm
        /// </summary>
        public static readonly AutoMLAlgorithm Mlp = new AutoMLAlgorithm("mlp");
        /// <summary>
        /// Constant NnTorch for AutoMLAlgorithm
        /// </summary>
        public static readonly AutoMLAlgorithm NnTorch = new AutoMLAlgorithm("nn-torch");
        /// <summary>
        /// Constant Randomforest for AutoMLAlgorithm
        /// </summary>
        public static readonly AutoMLAlgorithm Randomforest = new AutoMLAlgorithm("randomforest");
        /// <summary>
        /// Constant Xgboost for AutoMLAlgorithm
        /// </summary>
        public static readonly AutoMLAlgorithm Xgboost = new AutoMLAlgorithm("xgboost");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoMLAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoMLAlgorithm FindValue(string value)
        {
            return FindValue<AutoMLAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoMLAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoMLChannelType.
    /// </summary>
    public class AutoMLChannelType : ConstantClass
    {

        /// <summary>
        /// Constant Training for AutoMLChannelType
        /// </summary>
        public static readonly AutoMLChannelType Training = new AutoMLChannelType("training");
        /// <summary>
        /// Constant Validation for AutoMLChannelType
        /// </summary>
        public static readonly AutoMLChannelType Validation = new AutoMLChannelType("validation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoMLChannelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoMLChannelType FindValue(string value)
        {
            return FindValue<AutoMLChannelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoMLChannelType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoMLJobObjectiveType.
    /// </summary>
    public class AutoMLJobObjectiveType : ConstantClass
    {

        /// <summary>
        /// Constant Maximize for AutoMLJobObjectiveType
        /// </summary>
        public static readonly AutoMLJobObjectiveType Maximize = new AutoMLJobObjectiveType("Maximize");
        /// <summary>
        /// Constant Minimize for AutoMLJobObjectiveType
        /// </summary>
        public static readonly AutoMLJobObjectiveType Minimize = new AutoMLJobObjectiveType("Minimize");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoMLJobObjectiveType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoMLJobObjectiveType FindValue(string value)
        {
            return FindValue<AutoMLJobObjectiveType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoMLJobObjectiveType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoMLJobSecondaryStatus.
    /// </summary>
    public class AutoMLJobSecondaryStatus : ConstantClass
    {

        /// <summary>
        /// Constant AnalyzingData for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus AnalyzingData = new AutoMLJobSecondaryStatus("AnalyzingData");
        /// <summary>
        /// Constant CandidateDefinitionsGenerated for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus CandidateDefinitionsGenerated = new AutoMLJobSecondaryStatus("CandidateDefinitionsGenerated");
        /// <summary>
        /// Constant Completed for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus Completed = new AutoMLJobSecondaryStatus("Completed");
        /// <summary>
        /// Constant DeployingModel for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus DeployingModel = new AutoMLJobSecondaryStatus("DeployingModel");
        /// <summary>
        /// Constant ExplainabilityError for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus ExplainabilityError = new AutoMLJobSecondaryStatus("ExplainabilityError");
        /// <summary>
        /// Constant Failed for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus Failed = new AutoMLJobSecondaryStatus("Failed");
        /// <summary>
        /// Constant FeatureEngineering for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus FeatureEngineering = new AutoMLJobSecondaryStatus("FeatureEngineering");
        /// <summary>
        /// Constant GeneratingExplainabilityReport for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus GeneratingExplainabilityReport = new AutoMLJobSecondaryStatus("GeneratingExplainabilityReport");
        /// <summary>
        /// Constant GeneratingModelInsightsReport for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus GeneratingModelInsightsReport = new AutoMLJobSecondaryStatus("GeneratingModelInsightsReport");
        /// <summary>
        /// Constant MaxAutoMLJobRuntimeReached for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus MaxAutoMLJobRuntimeReached = new AutoMLJobSecondaryStatus("MaxAutoMLJobRuntimeReached");
        /// <summary>
        /// Constant MaxCandidatesReached for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus MaxCandidatesReached = new AutoMLJobSecondaryStatus("MaxCandidatesReached");
        /// <summary>
        /// Constant ModelDeploymentError for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus ModelDeploymentError = new AutoMLJobSecondaryStatus("ModelDeploymentError");
        /// <summary>
        /// Constant ModelInsightsError for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus ModelInsightsError = new AutoMLJobSecondaryStatus("ModelInsightsError");
        /// <summary>
        /// Constant ModelTuning for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus ModelTuning = new AutoMLJobSecondaryStatus("ModelTuning");
        /// <summary>
        /// Constant Starting for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus Starting = new AutoMLJobSecondaryStatus("Starting");
        /// <summary>
        /// Constant Stopped for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus Stopped = new AutoMLJobSecondaryStatus("Stopped");
        /// <summary>
        /// Constant Stopping for AutoMLJobSecondaryStatus
        /// </summary>
        public static readonly AutoMLJobSecondaryStatus Stopping = new AutoMLJobSecondaryStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoMLJobSecondaryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoMLJobSecondaryStatus FindValue(string value)
        {
            return FindValue<AutoMLJobSecondaryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoMLJobSecondaryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoMLJobStatus.
    /// </summary>
    public class AutoMLJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for AutoMLJobStatus
        /// </summary>
        public static readonly AutoMLJobStatus Completed = new AutoMLJobStatus("Completed");
        /// <summary>
        /// Constant Failed for AutoMLJobStatus
        /// </summary>
        public static readonly AutoMLJobStatus Failed = new AutoMLJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for AutoMLJobStatus
        /// </summary>
        public static readonly AutoMLJobStatus InProgress = new AutoMLJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for AutoMLJobStatus
        /// </summary>
        public static readonly AutoMLJobStatus Stopped = new AutoMLJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for AutoMLJobStatus
        /// </summary>
        public static readonly AutoMLJobStatus Stopping = new AutoMLJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoMLJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoMLJobStatus FindValue(string value)
        {
            return FindValue<AutoMLJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoMLJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoMLMetricEnum.
    /// </summary>
    public class AutoMLMetricEnum : ConstantClass
    {

        /// <summary>
        /// Constant Accuracy for AutoMLMetricEnum
        /// </summary>
        public static readonly AutoMLMetricEnum Accuracy = new AutoMLMetricEnum("Accuracy");
        /// <summary>
        /// Constant AUC for AutoMLMetricEnum
        /// </summary>
        public static readonly AutoMLMetricEnum AUC = new AutoMLMetricEnum("AUC");
        /// <summary>
        /// Constant BalancedAccuracy for AutoMLMetricEnum
        /// </summary>
        public static readonly AutoMLMetricEnum BalancedAccuracy = new AutoMLMetricEnum("BalancedAccuracy");
        /// <summary>
        /// Constant F1 for AutoMLMetricEnum
        /// </summary>
        public static readonly AutoMLMetricEnum F1 = new AutoMLMetricEnum("F1");
        /// <summary>
        /// Constant F1macro for AutoMLMetricEnum
        /// </summary>
        public static readonly AutoMLMetricEnum F1macro = new AutoMLMetricEnum("F1macro");
        /// <summary>
        /// Constant MAE for AutoMLMetricEnum
        /// </summary>
        public static readonly AutoMLMetricEnum MAE = new AutoMLMetricEnum("MAE");
        /// <summary>
        /// Constant MSE for AutoMLMetricEnum
        /// </summary>
        public static readonly AutoMLMetricEnum MSE = new AutoMLMetricEnum("MSE");
        /// <summary>
        /// Constant Precision for AutoMLMetricEnum
        /// </summary>
        public static readonly AutoMLMetricEnum Precision = new AutoMLMetricEnum("Precision");
        /// <summary>
        /// Constant PrecisionMacro for AutoMLMetricEnum
        /// </summary>
        public static readonly AutoMLMetricEnum PrecisionMacro = new AutoMLMetricEnum("PrecisionMacro");
        /// <summary>
        /// Constant R2 for AutoMLMetricEnum
        /// </summary>
        public static readonly AutoMLMetricEnum R2 = new AutoMLMetricEnum("R2");
        /// <summary>
        /// Constant Recall for AutoMLMetricEnum
        /// </summary>
        public static readonly AutoMLMetricEnum Recall = new AutoMLMetricEnum("Recall");
        /// <summary>
        /// Constant RecallMacro for AutoMLMetricEnum
        /// </summary>
        public static readonly AutoMLMetricEnum RecallMacro = new AutoMLMetricEnum("RecallMacro");
        /// <summary>
        /// Constant RMSE for AutoMLMetricEnum
        /// </summary>
        public static readonly AutoMLMetricEnum RMSE = new AutoMLMetricEnum("RMSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoMLMetricEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoMLMetricEnum FindValue(string value)
        {
            return FindValue<AutoMLMetricEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoMLMetricEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoMLMetricExtendedEnum.
    /// </summary>
    public class AutoMLMetricExtendedEnum : ConstantClass
    {

        /// <summary>
        /// Constant Accuracy for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum Accuracy = new AutoMLMetricExtendedEnum("Accuracy");
        /// <summary>
        /// Constant AUC for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum AUC = new AutoMLMetricExtendedEnum("AUC");
        /// <summary>
        /// Constant BalancedAccuracy for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum BalancedAccuracy = new AutoMLMetricExtendedEnum("BalancedAccuracy");
        /// <summary>
        /// Constant F1 for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum F1 = new AutoMLMetricExtendedEnum("F1");
        /// <summary>
        /// Constant F1macro for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum F1macro = new AutoMLMetricExtendedEnum("F1macro");
        /// <summary>
        /// Constant InferenceLatency for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum InferenceLatency = new AutoMLMetricExtendedEnum("InferenceLatency");
        /// <summary>
        /// Constant LogLoss for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum LogLoss = new AutoMLMetricExtendedEnum("LogLoss");
        /// <summary>
        /// Constant MAE for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum MAE = new AutoMLMetricExtendedEnum("MAE");
        /// <summary>
        /// Constant MSE for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum MSE = new AutoMLMetricExtendedEnum("MSE");
        /// <summary>
        /// Constant Precision for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum Precision = new AutoMLMetricExtendedEnum("Precision");
        /// <summary>
        /// Constant PrecisionMacro for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum PrecisionMacro = new AutoMLMetricExtendedEnum("PrecisionMacro");
        /// <summary>
        /// Constant R2 for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum R2 = new AutoMLMetricExtendedEnum("R2");
        /// <summary>
        /// Constant Recall for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum Recall = new AutoMLMetricExtendedEnum("Recall");
        /// <summary>
        /// Constant RecallMacro for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum RecallMacro = new AutoMLMetricExtendedEnum("RecallMacro");
        /// <summary>
        /// Constant RMSE for AutoMLMetricExtendedEnum
        /// </summary>
        public static readonly AutoMLMetricExtendedEnum RMSE = new AutoMLMetricExtendedEnum("RMSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoMLMetricExtendedEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoMLMetricExtendedEnum FindValue(string value)
        {
            return FindValue<AutoMLMetricExtendedEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoMLMetricExtendedEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoMLMode.
    /// </summary>
    public class AutoMLMode : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for AutoMLMode
        /// </summary>
        public static readonly AutoMLMode AUTO = new AutoMLMode("AUTO");
        /// <summary>
        /// Constant ENSEMBLING for AutoMLMode
        /// </summary>
        public static readonly AutoMLMode ENSEMBLING = new AutoMLMode("ENSEMBLING");
        /// <summary>
        /// Constant HYPERPARAMETER_TUNING for AutoMLMode
        /// </summary>
        public static readonly AutoMLMode HYPERPARAMETER_TUNING = new AutoMLMode("HYPERPARAMETER_TUNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoMLMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoMLMode FindValue(string value)
        {
            return FindValue<AutoMLMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoMLMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoMLS3DataType.
    /// </summary>
    public class AutoMLS3DataType : ConstantClass
    {

        /// <summary>
        /// Constant ManifestFile for AutoMLS3DataType
        /// </summary>
        public static readonly AutoMLS3DataType ManifestFile = new AutoMLS3DataType("ManifestFile");
        /// <summary>
        /// Constant S3Prefix for AutoMLS3DataType
        /// </summary>
        public static readonly AutoMLS3DataType S3Prefix = new AutoMLS3DataType("S3Prefix");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoMLS3DataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoMLS3DataType FindValue(string value)
        {
            return FindValue<AutoMLS3DataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoMLS3DataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoMLSortBy.
    /// </summary>
    public class AutoMLSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for AutoMLSortBy
        /// </summary>
        public static readonly AutoMLSortBy CreationTime = new AutoMLSortBy("CreationTime");
        /// <summary>
        /// Constant Name for AutoMLSortBy
        /// </summary>
        public static readonly AutoMLSortBy Name = new AutoMLSortBy("Name");
        /// <summary>
        /// Constant Status for AutoMLSortBy
        /// </summary>
        public static readonly AutoMLSortBy Status = new AutoMLSortBy("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoMLSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoMLSortBy FindValue(string value)
        {
            return FindValue<AutoMLSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoMLSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoMLSortOrder.
    /// </summary>
    public class AutoMLSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for AutoMLSortOrder
        /// </summary>
        public static readonly AutoMLSortOrder Ascending = new AutoMLSortOrder("Ascending");
        /// <summary>
        /// Constant Descending for AutoMLSortOrder
        /// </summary>
        public static readonly AutoMLSortOrder Descending = new AutoMLSortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoMLSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoMLSortOrder FindValue(string value)
        {
            return FindValue<AutoMLSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoMLSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsManagedHumanLoopRequestSource.
    /// </summary>
    public class AwsManagedHumanLoopRequestSource : ConstantClass
    {

        /// <summary>
        /// Constant AWSRekognitionDetectModerationLabelsImageV3 for AwsManagedHumanLoopRequestSource
        /// </summary>
        public static readonly AwsManagedHumanLoopRequestSource AWSRekognitionDetectModerationLabelsImageV3 = new AwsManagedHumanLoopRequestSource("AWS/Rekognition/DetectModerationLabels/Image/V3");
        /// <summary>
        /// Constant AWSTextractAnalyzeDocumentFormsV1 for AwsManagedHumanLoopRequestSource
        /// </summary>
        public static readonly AwsManagedHumanLoopRequestSource AWSTextractAnalyzeDocumentFormsV1 = new AwsManagedHumanLoopRequestSource("AWS/Textract/AnalyzeDocument/Forms/V1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsManagedHumanLoopRequestSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsManagedHumanLoopRequestSource FindValue(string value)
        {
            return FindValue<AwsManagedHumanLoopRequestSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsManagedHumanLoopRequestSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchStrategy.
    /// </summary>
    public class BatchStrategy : ConstantClass
    {

        /// <summary>
        /// Constant MultiRecord for BatchStrategy
        /// </summary>
        public static readonly BatchStrategy MultiRecord = new BatchStrategy("MultiRecord");
        /// <summary>
        /// Constant SingleRecord for BatchStrategy
        /// </summary>
        public static readonly BatchStrategy SingleRecord = new BatchStrategy("SingleRecord");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchStrategy FindValue(string value)
        {
            return FindValue<BatchStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BooleanOperator.
    /// </summary>
    public class BooleanOperator : ConstantClass
    {

        /// <summary>
        /// Constant And for BooleanOperator
        /// </summary>
        public static readonly BooleanOperator And = new BooleanOperator("And");
        /// <summary>
        /// Constant Or for BooleanOperator
        /// </summary>
        public static readonly BooleanOperator Or = new BooleanOperator("Or");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BooleanOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BooleanOperator FindValue(string value)
        {
            return FindValue<BooleanOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BooleanOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CandidateSortBy.
    /// </summary>
    public class CandidateSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for CandidateSortBy
        /// </summary>
        public static readonly CandidateSortBy CreationTime = new CandidateSortBy("CreationTime");
        /// <summary>
        /// Constant FinalObjectiveMetricValue for CandidateSortBy
        /// </summary>
        public static readonly CandidateSortBy FinalObjectiveMetricValue = new CandidateSortBy("FinalObjectiveMetricValue");
        /// <summary>
        /// Constant Status for CandidateSortBy
        /// </summary>
        public static readonly CandidateSortBy Status = new CandidateSortBy("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CandidateSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CandidateSortBy FindValue(string value)
        {
            return FindValue<CandidateSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CandidateSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CandidateStatus.
    /// </summary>
    public class CandidateStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for CandidateStatus
        /// </summary>
        public static readonly CandidateStatus Completed = new CandidateStatus("Completed");
        /// <summary>
        /// Constant Failed for CandidateStatus
        /// </summary>
        public static readonly CandidateStatus Failed = new CandidateStatus("Failed");
        /// <summary>
        /// Constant InProgress for CandidateStatus
        /// </summary>
        public static readonly CandidateStatus InProgress = new CandidateStatus("InProgress");
        /// <summary>
        /// Constant Stopped for CandidateStatus
        /// </summary>
        public static readonly CandidateStatus Stopped = new CandidateStatus("Stopped");
        /// <summary>
        /// Constant Stopping for CandidateStatus
        /// </summary>
        public static readonly CandidateStatus Stopping = new CandidateStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CandidateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CandidateStatus FindValue(string value)
        {
            return FindValue<CandidateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CandidateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CandidateStepType.
    /// </summary>
    public class CandidateStepType : ConstantClass
    {

        /// <summary>
        /// Constant AWSSageMakerProcessingJob for CandidateStepType
        /// </summary>
        public static readonly CandidateStepType AWSSageMakerProcessingJob = new CandidateStepType("AWS::SageMaker::ProcessingJob");
        /// <summary>
        /// Constant AWSSageMakerTrainingJob for CandidateStepType
        /// </summary>
        public static readonly CandidateStepType AWSSageMakerTrainingJob = new CandidateStepType("AWS::SageMaker::TrainingJob");
        /// <summary>
        /// Constant AWSSageMakerTransformJob for CandidateStepType
        /// </summary>
        public static readonly CandidateStepType AWSSageMakerTransformJob = new CandidateStepType("AWS::SageMaker::TransformJob");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CandidateStepType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CandidateStepType FindValue(string value)
        {
            return FindValue<CandidateStepType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CandidateStepType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacitySizeType.
    /// </summary>
    public class CapacitySizeType : ConstantClass
    {

        /// <summary>
        /// Constant CAPACITY_PERCENT for CapacitySizeType
        /// </summary>
        public static readonly CapacitySizeType CAPACITY_PERCENT = new CapacitySizeType("CAPACITY_PERCENT");
        /// <summary>
        /// Constant INSTANCE_COUNT for CapacitySizeType
        /// </summary>
        public static readonly CapacitySizeType INSTANCE_COUNT = new CapacitySizeType("INSTANCE_COUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacitySizeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacitySizeType FindValue(string value)
        {
            return FindValue<CapacitySizeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacitySizeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CaptureMode.
    /// </summary>
    public class CaptureMode : ConstantClass
    {

        /// <summary>
        /// Constant Input for CaptureMode
        /// </summary>
        public static readonly CaptureMode Input = new CaptureMode("Input");
        /// <summary>
        /// Constant Output for CaptureMode
        /// </summary>
        public static readonly CaptureMode Output = new CaptureMode("Output");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CaptureMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CaptureMode FindValue(string value)
        {
            return FindValue<CaptureMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CaptureMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CaptureStatus.
    /// </summary>
    public class CaptureStatus : ConstantClass
    {

        /// <summary>
        /// Constant Started for CaptureStatus
        /// </summary>
        public static readonly CaptureStatus Started = new CaptureStatus("Started");
        /// <summary>
        /// Constant Stopped for CaptureStatus
        /// </summary>
        public static readonly CaptureStatus Stopped = new CaptureStatus("Stopped");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CaptureStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CaptureStatus FindValue(string value)
        {
            return FindValue<CaptureStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CaptureStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClarifyFeatureType.
    /// </summary>
    public class ClarifyFeatureType : ConstantClass
    {

        /// <summary>
        /// Constant Categorical for ClarifyFeatureType
        /// </summary>
        public static readonly ClarifyFeatureType Categorical = new ClarifyFeatureType("categorical");
        /// <summary>
        /// Constant Numerical for ClarifyFeatureType
        /// </summary>
        public static readonly ClarifyFeatureType Numerical = new ClarifyFeatureType("numerical");
        /// <summary>
        /// Constant Text for ClarifyFeatureType
        /// </summary>
        public static readonly ClarifyFeatureType Text = new ClarifyFeatureType("text");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClarifyFeatureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClarifyFeatureType FindValue(string value)
        {
            return FindValue<ClarifyFeatureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClarifyFeatureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClarifyTextGranularity.
    /// </summary>
    public class ClarifyTextGranularity : ConstantClass
    {

        /// <summary>
        /// Constant Paragraph for ClarifyTextGranularity
        /// </summary>
        public static readonly ClarifyTextGranularity Paragraph = new ClarifyTextGranularity("paragraph");
        /// <summary>
        /// Constant Sentence for ClarifyTextGranularity
        /// </summary>
        public static readonly ClarifyTextGranularity Sentence = new ClarifyTextGranularity("sentence");
        /// <summary>
        /// Constant Token for ClarifyTextGranularity
        /// </summary>
        public static readonly ClarifyTextGranularity Token = new ClarifyTextGranularity("token");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClarifyTextGranularity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClarifyTextGranularity FindValue(string value)
        {
            return FindValue<ClarifyTextGranularity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClarifyTextGranularity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClarifyTextLanguage.
    /// </summary>
    public class ClarifyTextLanguage : ConstantClass
    {

        /// <summary>
        /// Constant Af for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Af = new ClarifyTextLanguage("af");
        /// <summary>
        /// Constant Ar for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Ar = new ClarifyTextLanguage("ar");
        /// <summary>
        /// Constant Bg for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Bg = new ClarifyTextLanguage("bg");
        /// <summary>
        /// Constant Bn for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Bn = new ClarifyTextLanguage("bn");
        /// <summary>
        /// Constant Ca for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Ca = new ClarifyTextLanguage("ca");
        /// <summary>
        /// Constant Cs for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Cs = new ClarifyTextLanguage("cs");
        /// <summary>
        /// Constant Da for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Da = new ClarifyTextLanguage("da");
        /// <summary>
        /// Constant De for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage De = new ClarifyTextLanguage("de");
        /// <summary>
        /// Constant El for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage El = new ClarifyTextLanguage("el");
        /// <summary>
        /// Constant En for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage En = new ClarifyTextLanguage("en");
        /// <summary>
        /// Constant Es for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Es = new ClarifyTextLanguage("es");
        /// <summary>
        /// Constant Et for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Et = new ClarifyTextLanguage("et");
        /// <summary>
        /// Constant Eu for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Eu = new ClarifyTextLanguage("eu");
        /// <summary>
        /// Constant Fa for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Fa = new ClarifyTextLanguage("fa");
        /// <summary>
        /// Constant Fi for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Fi = new ClarifyTextLanguage("fi");
        /// <summary>
        /// Constant Fr for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Fr = new ClarifyTextLanguage("fr");
        /// <summary>
        /// Constant Ga for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Ga = new ClarifyTextLanguage("ga");
        /// <summary>
        /// Constant Gu for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Gu = new ClarifyTextLanguage("gu");
        /// <summary>
        /// Constant He for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage He = new ClarifyTextLanguage("he");
        /// <summary>
        /// Constant Hi for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Hi = new ClarifyTextLanguage("hi");
        /// <summary>
        /// Constant Hr for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Hr = new ClarifyTextLanguage("hr");
        /// <summary>
        /// Constant Hu for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Hu = new ClarifyTextLanguage("hu");
        /// <summary>
        /// Constant Hy for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Hy = new ClarifyTextLanguage("hy");
        /// <summary>
        /// Constant Id for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Id = new ClarifyTextLanguage("id");
        /// <summary>
        /// Constant Is for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Is = new ClarifyTextLanguage("is");
        /// <summary>
        /// Constant It for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage It = new ClarifyTextLanguage("it");
        /// <summary>
        /// Constant Kn for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Kn = new ClarifyTextLanguage("kn");
        /// <summary>
        /// Constant Ky for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Ky = new ClarifyTextLanguage("ky");
        /// <summary>
        /// Constant Lb for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Lb = new ClarifyTextLanguage("lb");
        /// <summary>
        /// Constant Lij for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Lij = new ClarifyTextLanguage("lij");
        /// <summary>
        /// Constant Lt for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Lt = new ClarifyTextLanguage("lt");
        /// <summary>
        /// Constant Lv for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Lv = new ClarifyTextLanguage("lv");
        /// <summary>
        /// Constant Mk for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Mk = new ClarifyTextLanguage("mk");
        /// <summary>
        /// Constant Ml for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Ml = new ClarifyTextLanguage("ml");
        /// <summary>
        /// Constant Mr for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Mr = new ClarifyTextLanguage("mr");
        /// <summary>
        /// Constant Nb for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Nb = new ClarifyTextLanguage("nb");
        /// <summary>
        /// Constant Ne for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Ne = new ClarifyTextLanguage("ne");
        /// <summary>
        /// Constant Nl for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Nl = new ClarifyTextLanguage("nl");
        /// <summary>
        /// Constant Pl for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Pl = new ClarifyTextLanguage("pl");
        /// <summary>
        /// Constant Pt for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Pt = new ClarifyTextLanguage("pt");
        /// <summary>
        /// Constant Ro for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Ro = new ClarifyTextLanguage("ro");
        /// <summary>
        /// Constant Ru for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Ru = new ClarifyTextLanguage("ru");
        /// <summary>
        /// Constant Sa for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Sa = new ClarifyTextLanguage("sa");
        /// <summary>
        /// Constant Si for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Si = new ClarifyTextLanguage("si");
        /// <summary>
        /// Constant Sk for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Sk = new ClarifyTextLanguage("sk");
        /// <summary>
        /// Constant Sl for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Sl = new ClarifyTextLanguage("sl");
        /// <summary>
        /// Constant Sq for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Sq = new ClarifyTextLanguage("sq");
        /// <summary>
        /// Constant Sr for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Sr = new ClarifyTextLanguage("sr");
        /// <summary>
        /// Constant Sv for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Sv = new ClarifyTextLanguage("sv");
        /// <summary>
        /// Constant Ta for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Ta = new ClarifyTextLanguage("ta");
        /// <summary>
        /// Constant Te for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Te = new ClarifyTextLanguage("te");
        /// <summary>
        /// Constant Tl for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Tl = new ClarifyTextLanguage("tl");
        /// <summary>
        /// Constant Tn for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Tn = new ClarifyTextLanguage("tn");
        /// <summary>
        /// Constant Tr for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Tr = new ClarifyTextLanguage("tr");
        /// <summary>
        /// Constant Tt for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Tt = new ClarifyTextLanguage("tt");
        /// <summary>
        /// Constant Uk for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Uk = new ClarifyTextLanguage("uk");
        /// <summary>
        /// Constant Ur for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Ur = new ClarifyTextLanguage("ur");
        /// <summary>
        /// Constant Xx for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Xx = new ClarifyTextLanguage("xx");
        /// <summary>
        /// Constant Yo for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Yo = new ClarifyTextLanguage("yo");
        /// <summary>
        /// Constant Zh for ClarifyTextLanguage
        /// </summary>
        public static readonly ClarifyTextLanguage Zh = new ClarifyTextLanguage("zh");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClarifyTextLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClarifyTextLanguage FindValue(string value)
        {
            return FindValue<ClarifyTextLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClarifyTextLanguage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeRepositorySortBy.
    /// </summary>
    public class CodeRepositorySortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for CodeRepositorySortBy
        /// </summary>
        public static readonly CodeRepositorySortBy CreationTime = new CodeRepositorySortBy("CreationTime");
        /// <summary>
        /// Constant LastModifiedTime for CodeRepositorySortBy
        /// </summary>
        public static readonly CodeRepositorySortBy LastModifiedTime = new CodeRepositorySortBy("LastModifiedTime");
        /// <summary>
        /// Constant Name for CodeRepositorySortBy
        /// </summary>
        public static readonly CodeRepositorySortBy Name = new CodeRepositorySortBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeRepositorySortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeRepositorySortBy FindValue(string value)
        {
            return FindValue<CodeRepositorySortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeRepositorySortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeRepositorySortOrder.
    /// </summary>
    public class CodeRepositorySortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for CodeRepositorySortOrder
        /// </summary>
        public static readonly CodeRepositorySortOrder Ascending = new CodeRepositorySortOrder("Ascending");
        /// <summary>
        /// Constant Descending for CodeRepositorySortOrder
        /// </summary>
        public static readonly CodeRepositorySortOrder Descending = new CodeRepositorySortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeRepositorySortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeRepositorySortOrder FindValue(string value)
        {
            return FindValue<CodeRepositorySortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeRepositorySortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompilationJobStatus.
    /// </summary>
    public class CompilationJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for CompilationJobStatus
        /// </summary>
        public static readonly CompilationJobStatus COMPLETED = new CompilationJobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for CompilationJobStatus
        /// </summary>
        public static readonly CompilationJobStatus FAILED = new CompilationJobStatus("FAILED");
        /// <summary>
        /// Constant INPROGRESS for CompilationJobStatus
        /// </summary>
        public static readonly CompilationJobStatus INPROGRESS = new CompilationJobStatus("INPROGRESS");
        /// <summary>
        /// Constant STARTING for CompilationJobStatus
        /// </summary>
        public static readonly CompilationJobStatus STARTING = new CompilationJobStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for CompilationJobStatus
        /// </summary>
        public static readonly CompilationJobStatus STOPPED = new CompilationJobStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for CompilationJobStatus
        /// </summary>
        public static readonly CompilationJobStatus STOPPING = new CompilationJobStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompilationJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompilationJobStatus FindValue(string value)
        {
            return FindValue<CompilationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompilationJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompleteOnConvergence.
    /// </summary>
    public class CompleteOnConvergence : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for CompleteOnConvergence
        /// </summary>
        public static readonly CompleteOnConvergence Disabled = new CompleteOnConvergence("Disabled");
        /// <summary>
        /// Constant Enabled for CompleteOnConvergence
        /// </summary>
        public static readonly CompleteOnConvergence Enabled = new CompleteOnConvergence("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompleteOnConvergence(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompleteOnConvergence FindValue(string value)
        {
            return FindValue<CompleteOnConvergence>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompleteOnConvergence(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompressionType.
    /// </summary>
    public class CompressionType : ConstantClass
    {

        /// <summary>
        /// Constant Gzip for CompressionType
        /// </summary>
        public static readonly CompressionType Gzip = new CompressionType("Gzip");
        /// <summary>
        /// Constant None for CompressionType
        /// </summary>
        public static readonly CompressionType None = new CompressionType("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompressionType FindValue(string value)
        {
            return FindValue<CompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConditionOutcome.
    /// </summary>
    public class ConditionOutcome : ConstantClass
    {

        /// <summary>
        /// Constant False for ConditionOutcome
        /// </summary>
        public static readonly ConditionOutcome False = new ConditionOutcome("False");
        /// <summary>
        /// Constant True for ConditionOutcome
        /// </summary>
        public static readonly ConditionOutcome True = new ConditionOutcome("True");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConditionOutcome(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConditionOutcome FindValue(string value)
        {
            return FindValue<ConditionOutcome>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConditionOutcome(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerMode.
    /// </summary>
    public class ContainerMode : ConstantClass
    {

        /// <summary>
        /// Constant MultiModel for ContainerMode
        /// </summary>
        public static readonly ContainerMode MultiModel = new ContainerMode("MultiModel");
        /// <summary>
        /// Constant SingleModel for ContainerMode
        /// </summary>
        public static readonly ContainerMode SingleModel = new ContainerMode("SingleModel");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerMode FindValue(string value)
        {
            return FindValue<ContainerMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentClassifier.
    /// </summary>
    public class ContentClassifier : ConstantClass
    {

        /// <summary>
        /// Constant FreeOfAdultContent for ContentClassifier
        /// </summary>
        public static readonly ContentClassifier FreeOfAdultContent = new ContentClassifier("FreeOfAdultContent");
        /// <summary>
        /// Constant FreeOfPersonallyIdentifiableInformation for ContentClassifier
        /// </summary>
        public static readonly ContentClassifier FreeOfPersonallyIdentifiableInformation = new ContentClassifier("FreeOfPersonallyIdentifiableInformation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentClassifier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentClassifier FindValue(string value)
        {
            return FindValue<ContentClassifier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentClassifier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataDistributionType.
    /// </summary>
    public class DataDistributionType : ConstantClass
    {

        /// <summary>
        /// Constant FullyReplicated for DataDistributionType
        /// </summary>
        public static readonly DataDistributionType FullyReplicated = new DataDistributionType("FullyReplicated");
        /// <summary>
        /// Constant ShardedByS3Key for DataDistributionType
        /// </summary>
        public static readonly DataDistributionType ShardedByS3Key = new DataDistributionType("ShardedByS3Key");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataDistributionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataDistributionType FindValue(string value)
        {
            return FindValue<DataDistributionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataDistributionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DetailedAlgorithmStatus.
    /// </summary>
    public class DetailedAlgorithmStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for DetailedAlgorithmStatus
        /// </summary>
        public static readonly DetailedAlgorithmStatus Completed = new DetailedAlgorithmStatus("Completed");
        /// <summary>
        /// Constant Failed for DetailedAlgorithmStatus
        /// </summary>
        public static readonly DetailedAlgorithmStatus Failed = new DetailedAlgorithmStatus("Failed");
        /// <summary>
        /// Constant InProgress for DetailedAlgorithmStatus
        /// </summary>
        public static readonly DetailedAlgorithmStatus InProgress = new DetailedAlgorithmStatus("InProgress");
        /// <summary>
        /// Constant NotStarted for DetailedAlgorithmStatus
        /// </summary>
        public static readonly DetailedAlgorithmStatus NotStarted = new DetailedAlgorithmStatus("NotStarted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetailedAlgorithmStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetailedAlgorithmStatus FindValue(string value)
        {
            return FindValue<DetailedAlgorithmStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetailedAlgorithmStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DetailedModelPackageStatus.
    /// </summary>
    public class DetailedModelPackageStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for DetailedModelPackageStatus
        /// </summary>
        public static readonly DetailedModelPackageStatus Completed = new DetailedModelPackageStatus("Completed");
        /// <summary>
        /// Constant Failed for DetailedModelPackageStatus
        /// </summary>
        public static readonly DetailedModelPackageStatus Failed = new DetailedModelPackageStatus("Failed");
        /// <summary>
        /// Constant InProgress for DetailedModelPackageStatus
        /// </summary>
        public static readonly DetailedModelPackageStatus InProgress = new DetailedModelPackageStatus("InProgress");
        /// <summary>
        /// Constant NotStarted for DetailedModelPackageStatus
        /// </summary>
        public static readonly DetailedModelPackageStatus NotStarted = new DetailedModelPackageStatus("NotStarted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetailedModelPackageStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetailedModelPackageStatus FindValue(string value)
        {
            return FindValue<DetailedModelPackageStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetailedModelPackageStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceDeploymentStatus.
    /// </summary>
    public class DeviceDeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOYED for DeviceDeploymentStatus
        /// </summary>
        public static readonly DeviceDeploymentStatus DEPLOYED = new DeviceDeploymentStatus("DEPLOYED");
        /// <summary>
        /// Constant FAILED for DeviceDeploymentStatus
        /// </summary>
        public static readonly DeviceDeploymentStatus FAILED = new DeviceDeploymentStatus("FAILED");
        /// <summary>
        /// Constant INPROGRESS for DeviceDeploymentStatus
        /// </summary>
        public static readonly DeviceDeploymentStatus INPROGRESS = new DeviceDeploymentStatus("INPROGRESS");
        /// <summary>
        /// Constant READYTODEPLOY for DeviceDeploymentStatus
        /// </summary>
        public static readonly DeviceDeploymentStatus READYTODEPLOY = new DeviceDeploymentStatus("READYTODEPLOY");
        /// <summary>
        /// Constant STOPPED for DeviceDeploymentStatus
        /// </summary>
        public static readonly DeviceDeploymentStatus STOPPED = new DeviceDeploymentStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for DeviceDeploymentStatus
        /// </summary>
        public static readonly DeviceDeploymentStatus STOPPING = new DeviceDeploymentStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceDeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceDeploymentStatus FindValue(string value)
        {
            return FindValue<DeviceDeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceDeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceSubsetType.
    /// </summary>
    public class DeviceSubsetType : ConstantClass
    {

        /// <summary>
        /// Constant NAMECONTAINS for DeviceSubsetType
        /// </summary>
        public static readonly DeviceSubsetType NAMECONTAINS = new DeviceSubsetType("NAMECONTAINS");
        /// <summary>
        /// Constant PERCENTAGE for DeviceSubsetType
        /// </summary>
        public static readonly DeviceSubsetType PERCENTAGE = new DeviceSubsetType("PERCENTAGE");
        /// <summary>
        /// Constant SELECTION for DeviceSubsetType
        /// </summary>
        public static readonly DeviceSubsetType SELECTION = new DeviceSubsetType("SELECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceSubsetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceSubsetType FindValue(string value)
        {
            return FindValue<DeviceSubsetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceSubsetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectInternetAccess.
    /// </summary>
    public class DirectInternetAccess : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for DirectInternetAccess
        /// </summary>
        public static readonly DirectInternetAccess Disabled = new DirectInternetAccess("Disabled");
        /// <summary>
        /// Constant Enabled for DirectInternetAccess
        /// </summary>
        public static readonly DirectInternetAccess Enabled = new DirectInternetAccess("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectInternetAccess(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectInternetAccess FindValue(string value)
        {
            return FindValue<DirectInternetAccess>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectInternetAccess(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Direction.
    /// </summary>
    public class Direction : ConstantClass
    {

        /// <summary>
        /// Constant Ascendants for Direction
        /// </summary>
        public static readonly Direction Ascendants = new Direction("Ascendants");
        /// <summary>
        /// Constant Both for Direction
        /// </summary>
        public static readonly Direction Both = new Direction("Both");
        /// <summary>
        /// Constant Descendants for Direction
        /// </summary>
        public static readonly Direction Descendants = new Direction("Descendants");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Direction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Direction FindValue(string value)
        {
            return FindValue<Direction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Direction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainStatus.
    /// </summary>
    public class DomainStatus : ConstantClass
    {

        /// <summary>
        /// Constant Delete_Failed for DomainStatus
        /// </summary>
        public static readonly DomainStatus Delete_Failed = new DomainStatus("Delete_Failed");
        /// <summary>
        /// Constant Deleting for DomainStatus
        /// </summary>
        public static readonly DomainStatus Deleting = new DomainStatus("Deleting");
        /// <summary>
        /// Constant Failed for DomainStatus
        /// </summary>
        public static readonly DomainStatus Failed = new DomainStatus("Failed");
        /// <summary>
        /// Constant InService for DomainStatus
        /// </summary>
        public static readonly DomainStatus InService = new DomainStatus("InService");
        /// <summary>
        /// Constant Pending for DomainStatus
        /// </summary>
        public static readonly DomainStatus Pending = new DomainStatus("Pending");
        /// <summary>
        /// Constant Update_Failed for DomainStatus
        /// </summary>
        public static readonly DomainStatus Update_Failed = new DomainStatus("Update_Failed");
        /// <summary>
        /// Constant Updating for DomainStatus
        /// </summary>
        public static readonly DomainStatus Updating = new DomainStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainStatus FindValue(string value)
        {
            return FindValue<DomainStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EdgePackagingJobStatus.
    /// </summary>
    public class EdgePackagingJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for EdgePackagingJobStatus
        /// </summary>
        public static readonly EdgePackagingJobStatus COMPLETED = new EdgePackagingJobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for EdgePackagingJobStatus
        /// </summary>
        public static readonly EdgePackagingJobStatus FAILED = new EdgePackagingJobStatus("FAILED");
        /// <summary>
        /// Constant INPROGRESS for EdgePackagingJobStatus
        /// </summary>
        public static readonly EdgePackagingJobStatus INPROGRESS = new EdgePackagingJobStatus("INPROGRESS");
        /// <summary>
        /// Constant STARTING for EdgePackagingJobStatus
        /// </summary>
        public static readonly EdgePackagingJobStatus STARTING = new EdgePackagingJobStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for EdgePackagingJobStatus
        /// </summary>
        public static readonly EdgePackagingJobStatus STOPPED = new EdgePackagingJobStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for EdgePackagingJobStatus
        /// </summary>
        public static readonly EdgePackagingJobStatus STOPPING = new EdgePackagingJobStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EdgePackagingJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EdgePackagingJobStatus FindValue(string value)
        {
            return FindValue<EdgePackagingJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EdgePackagingJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EdgePresetDeploymentStatus.
    /// </summary>
    public class EdgePresetDeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for EdgePresetDeploymentStatus
        /// </summary>
        public static readonly EdgePresetDeploymentStatus COMPLETED = new EdgePresetDeploymentStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for EdgePresetDeploymentStatus
        /// </summary>
        public static readonly EdgePresetDeploymentStatus FAILED = new EdgePresetDeploymentStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EdgePresetDeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EdgePresetDeploymentStatus FindValue(string value)
        {
            return FindValue<EdgePresetDeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EdgePresetDeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EdgePresetDeploymentType.
    /// </summary>
    public class EdgePresetDeploymentType : ConstantClass
    {

        /// <summary>
        /// Constant GreengrassV2Component for EdgePresetDeploymentType
        /// </summary>
        public static readonly EdgePresetDeploymentType GreengrassV2Component = new EdgePresetDeploymentType("GreengrassV2Component");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EdgePresetDeploymentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EdgePresetDeploymentType FindValue(string value)
        {
            return FindValue<EdgePresetDeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EdgePresetDeploymentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointConfigSortKey.
    /// </summary>
    public class EndpointConfigSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for EndpointConfigSortKey
        /// </summary>
        public static readonly EndpointConfigSortKey CreationTime = new EndpointConfigSortKey("CreationTime");
        /// <summary>
        /// Constant Name for EndpointConfigSortKey
        /// </summary>
        public static readonly EndpointConfigSortKey Name = new EndpointConfigSortKey("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointConfigSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointConfigSortKey FindValue(string value)
        {
            return FindValue<EndpointConfigSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointConfigSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointSortKey.
    /// </summary>
    public class EndpointSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for EndpointSortKey
        /// </summary>
        public static readonly EndpointSortKey CreationTime = new EndpointSortKey("CreationTime");
        /// <summary>
        /// Constant Name for EndpointSortKey
        /// </summary>
        public static readonly EndpointSortKey Name = new EndpointSortKey("Name");
        /// <summary>
        /// Constant Status for EndpointSortKey
        /// </summary>
        public static readonly EndpointSortKey Status = new EndpointSortKey("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointSortKey FindValue(string value)
        {
            return FindValue<EndpointSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointStatus.
    /// </summary>
    public class EndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant Creating for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Creating = new EndpointStatus("Creating");
        /// <summary>
        /// Constant Deleting for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Deleting = new EndpointStatus("Deleting");
        /// <summary>
        /// Constant Failed for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Failed = new EndpointStatus("Failed");
        /// <summary>
        /// Constant InService for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus InService = new EndpointStatus("InService");
        /// <summary>
        /// Constant OutOfService for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus OutOfService = new EndpointStatus("OutOfService");
        /// <summary>
        /// Constant RollingBack for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus RollingBack = new EndpointStatus("RollingBack");
        /// <summary>
        /// Constant SystemUpdating for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus SystemUpdating = new EndpointStatus("SystemUpdating");
        /// <summary>
        /// Constant Updating for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Updating = new EndpointStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointStatus FindValue(string value)
        {
            return FindValue<EndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionRoleIdentityConfig.
    /// </summary>
    public class ExecutionRoleIdentityConfig : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ExecutionRoleIdentityConfig
        /// </summary>
        public static readonly ExecutionRoleIdentityConfig DISABLED = new ExecutionRoleIdentityConfig("DISABLED");
        /// <summary>
        /// Constant USER_PROFILE_NAME for ExecutionRoleIdentityConfig
        /// </summary>
        public static readonly ExecutionRoleIdentityConfig USER_PROFILE_NAME = new ExecutionRoleIdentityConfig("USER_PROFILE_NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionRoleIdentityConfig(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionRoleIdentityConfig FindValue(string value)
        {
            return FindValue<ExecutionRoleIdentityConfig>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionRoleIdentityConfig(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionStatus.
    /// </summary>
    public class ExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus Completed = new ExecutionStatus("Completed");
        /// <summary>
        /// Constant CompletedWithViolations for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus CompletedWithViolations = new ExecutionStatus("CompletedWithViolations");
        /// <summary>
        /// Constant Failed for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus Failed = new ExecutionStatus("Failed");
        /// <summary>
        /// Constant InProgress for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus InProgress = new ExecutionStatus("InProgress");
        /// <summary>
        /// Constant Pending for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus Pending = new ExecutionStatus("Pending");
        /// <summary>
        /// Constant Stopped for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus Stopped = new ExecutionStatus("Stopped");
        /// <summary>
        /// Constant Stopping for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus Stopping = new ExecutionStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionStatus FindValue(string value)
        {
            return FindValue<ExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailureHandlingPolicy.
    /// </summary>
    public class FailureHandlingPolicy : ConstantClass
    {

        /// <summary>
        /// Constant DO_NOTHING for FailureHandlingPolicy
        /// </summary>
        public static readonly FailureHandlingPolicy DO_NOTHING = new FailureHandlingPolicy("DO_NOTHING");
        /// <summary>
        /// Constant ROLLBACK_ON_FAILURE for FailureHandlingPolicy
        /// </summary>
        public static readonly FailureHandlingPolicy ROLLBACK_ON_FAILURE = new FailureHandlingPolicy("ROLLBACK_ON_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailureHandlingPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailureHandlingPolicy FindValue(string value)
        {
            return FindValue<FailureHandlingPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailureHandlingPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeatureGroupSortBy.
    /// </summary>
    public class FeatureGroupSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for FeatureGroupSortBy
        /// </summary>
        public static readonly FeatureGroupSortBy CreationTime = new FeatureGroupSortBy("CreationTime");
        /// <summary>
        /// Constant FeatureGroupStatus for FeatureGroupSortBy
        /// </summary>
        public static readonly FeatureGroupSortBy FeatureGroupStatus = new FeatureGroupSortBy("FeatureGroupStatus");
        /// <summary>
        /// Constant Name for FeatureGroupSortBy
        /// </summary>
        public static readonly FeatureGroupSortBy Name = new FeatureGroupSortBy("Name");
        /// <summary>
        /// Constant OfflineStoreStatus for FeatureGroupSortBy
        /// </summary>
        public static readonly FeatureGroupSortBy OfflineStoreStatus = new FeatureGroupSortBy("OfflineStoreStatus");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureGroupSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureGroupSortBy FindValue(string value)
        {
            return FindValue<FeatureGroupSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureGroupSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeatureGroupSortOrder.
    /// </summary>
    public class FeatureGroupSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for FeatureGroupSortOrder
        /// </summary>
        public static readonly FeatureGroupSortOrder Ascending = new FeatureGroupSortOrder("Ascending");
        /// <summary>
        /// Constant Descending for FeatureGroupSortOrder
        /// </summary>
        public static readonly FeatureGroupSortOrder Descending = new FeatureGroupSortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureGroupSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureGroupSortOrder FindValue(string value)
        {
            return FindValue<FeatureGroupSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureGroupSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeatureGroupStatus.
    /// </summary>
    public class FeatureGroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant Created for FeatureGroupStatus
        /// </summary>
        public static readonly FeatureGroupStatus Created = new FeatureGroupStatus("Created");
        /// <summary>
        /// Constant CreateFailed for FeatureGroupStatus
        /// </summary>
        public static readonly FeatureGroupStatus CreateFailed = new FeatureGroupStatus("CreateFailed");
        /// <summary>
        /// Constant Creating for FeatureGroupStatus
        /// </summary>
        public static readonly FeatureGroupStatus Creating = new FeatureGroupStatus("Creating");
        /// <summary>
        /// Constant DeleteFailed for FeatureGroupStatus
        /// </summary>
        public static readonly FeatureGroupStatus DeleteFailed = new FeatureGroupStatus("DeleteFailed");
        /// <summary>
        /// Constant Deleting for FeatureGroupStatus
        /// </summary>
        public static readonly FeatureGroupStatus Deleting = new FeatureGroupStatus("Deleting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureGroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureGroupStatus FindValue(string value)
        {
            return FindValue<FeatureGroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureGroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeatureStatus.
    /// </summary>
    public class FeatureStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for FeatureStatus
        /// </summary>
        public static readonly FeatureStatus DISABLED = new FeatureStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for FeatureStatus
        /// </summary>
        public static readonly FeatureStatus ENABLED = new FeatureStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureStatus FindValue(string value)
        {
            return FindValue<FeatureStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeatureType.
    /// </summary>
    public class FeatureType : ConstantClass
    {

        /// <summary>
        /// Constant Fractional for FeatureType
        /// </summary>
        public static readonly FeatureType Fractional = new FeatureType("Fractional");
        /// <summary>
        /// Constant Integral for FeatureType
        /// </summary>
        public static readonly FeatureType Integral = new FeatureType("Integral");
        /// <summary>
        /// Constant String for FeatureType
        /// </summary>
        public static readonly FeatureType String = new FeatureType("String");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureType FindValue(string value)
        {
            return FindValue<FeatureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileSystemAccessMode.
    /// </summary>
    public class FileSystemAccessMode : ConstantClass
    {

        /// <summary>
        /// Constant Ro for FileSystemAccessMode
        /// </summary>
        public static readonly FileSystemAccessMode Ro = new FileSystemAccessMode("ro");
        /// <summary>
        /// Constant Rw for FileSystemAccessMode
        /// </summary>
        public static readonly FileSystemAccessMode Rw = new FileSystemAccessMode("rw");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileSystemAccessMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileSystemAccessMode FindValue(string value)
        {
            return FindValue<FileSystemAccessMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileSystemAccessMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileSystemType.
    /// </summary>
    public class FileSystemType : ConstantClass
    {

        /// <summary>
        /// Constant EFS for FileSystemType
        /// </summary>
        public static readonly FileSystemType EFS = new FileSystemType("EFS");
        /// <summary>
        /// Constant FSxLustre for FileSystemType
        /// </summary>
        public static readonly FileSystemType FSxLustre = new FileSystemType("FSxLustre");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileSystemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileSystemType FindValue(string value)
        {
            return FindValue<FileSystemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileSystemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowDefinitionStatus.
    /// </summary>
    public class FlowDefinitionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for FlowDefinitionStatus
        /// </summary>
        public static readonly FlowDefinitionStatus Active = new FlowDefinitionStatus("Active");
        /// <summary>
        /// Constant Deleting for FlowDefinitionStatus
        /// </summary>
        public static readonly FlowDefinitionStatus Deleting = new FlowDefinitionStatus("Deleting");
        /// <summary>
        /// Constant Failed for FlowDefinitionStatus
        /// </summary>
        public static readonly FlowDefinitionStatus Failed = new FlowDefinitionStatus("Failed");
        /// <summary>
        /// Constant Initializing for FlowDefinitionStatus
        /// </summary>
        public static readonly FlowDefinitionStatus Initializing = new FlowDefinitionStatus("Initializing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowDefinitionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowDefinitionStatus FindValue(string value)
        {
            return FindValue<FlowDefinitionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowDefinitionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Framework.
    /// </summary>
    public class Framework : ConstantClass
    {

        /// <summary>
        /// Constant DARKNET for Framework
        /// </summary>
        public static readonly Framework DARKNET = new Framework("DARKNET");
        /// <summary>
        /// Constant KERAS for Framework
        /// </summary>
        public static readonly Framework KERAS = new Framework("KERAS");
        /// <summary>
        /// Constant MXNET for Framework
        /// </summary>
        public static readonly Framework MXNET = new Framework("MXNET");
        /// <summary>
        /// Constant ONNX for Framework
        /// </summary>
        public static readonly Framework ONNX = new Framework("ONNX");
        /// <summary>
        /// Constant PYTORCH for Framework
        /// </summary>
        public static readonly Framework PYTORCH = new Framework("PYTORCH");
        /// <summary>
        /// Constant SKLEARN for Framework
        /// </summary>
        public static readonly Framework SKLEARN = new Framework("SKLEARN");
        /// <summary>
        /// Constant TENSORFLOW for Framework
        /// </summary>
        public static readonly Framework TENSORFLOW = new Framework("TENSORFLOW");
        /// <summary>
        /// Constant TFLITE for Framework
        /// </summary>
        public static readonly Framework TFLITE = new Framework("TFLITE");
        /// <summary>
        /// Constant XGBOOST for Framework
        /// </summary>
        public static readonly Framework XGBOOST = new Framework("XGBOOST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Framework(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Framework FindValue(string value)
        {
            return FindValue<Framework>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Framework(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HubContentSortBy.
    /// </summary>
    public class HubContentSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for HubContentSortBy
        /// </summary>
        public static readonly HubContentSortBy CreationTime = new HubContentSortBy("CreationTime");
        /// <summary>
        /// Constant HubContentName for HubContentSortBy
        /// </summary>
        public static readonly HubContentSortBy HubContentName = new HubContentSortBy("HubContentName");
        /// <summary>
        /// Constant HubContentStatus for HubContentSortBy
        /// </summary>
        public static readonly HubContentSortBy HubContentStatus = new HubContentSortBy("HubContentStatus");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HubContentSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HubContentSortBy FindValue(string value)
        {
            return FindValue<HubContentSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HubContentSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HubContentStatus.
    /// </summary>
    public class HubContentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for HubContentStatus
        /// </summary>
        public static readonly HubContentStatus Available = new HubContentStatus("Available");
        /// <summary>
        /// Constant DeleteFailed for HubContentStatus
        /// </summary>
        public static readonly HubContentStatus DeleteFailed = new HubContentStatus("DeleteFailed");
        /// <summary>
        /// Constant Deleting for HubContentStatus
        /// </summary>
        public static readonly HubContentStatus Deleting = new HubContentStatus("Deleting");
        /// <summary>
        /// Constant ImportFailed for HubContentStatus
        /// </summary>
        public static readonly HubContentStatus ImportFailed = new HubContentStatus("ImportFailed");
        /// <summary>
        /// Constant Importing for HubContentStatus
        /// </summary>
        public static readonly HubContentStatus Importing = new HubContentStatus("Importing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HubContentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HubContentStatus FindValue(string value)
        {
            return FindValue<HubContentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HubContentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HubContentType.
    /// </summary>
    public class HubContentType : ConstantClass
    {

        /// <summary>
        /// Constant Model for HubContentType
        /// </summary>
        public static readonly HubContentType Model = new HubContentType("Model");
        /// <summary>
        /// Constant Notebook for HubContentType
        /// </summary>
        public static readonly HubContentType Notebook = new HubContentType("Notebook");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HubContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HubContentType FindValue(string value)
        {
            return FindValue<HubContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HubContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HubSortBy.
    /// </summary>
    public class HubSortBy : ConstantClass
    {

        /// <summary>
        /// Constant AccountIdOwner for HubSortBy
        /// </summary>
        public static readonly HubSortBy AccountIdOwner = new HubSortBy("AccountIdOwner");
        /// <summary>
        /// Constant CreationTime for HubSortBy
        /// </summary>
        public static readonly HubSortBy CreationTime = new HubSortBy("CreationTime");
        /// <summary>
        /// Constant HubName for HubSortBy
        /// </summary>
        public static readonly HubSortBy HubName = new HubSortBy("HubName");
        /// <summary>
        /// Constant HubStatus for HubSortBy
        /// </summary>
        public static readonly HubSortBy HubStatus = new HubSortBy("HubStatus");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HubSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HubSortBy FindValue(string value)
        {
            return FindValue<HubSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HubSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HubStatus.
    /// </summary>
    public class HubStatus : ConstantClass
    {

        /// <summary>
        /// Constant CreateFailed for HubStatus
        /// </summary>
        public static readonly HubStatus CreateFailed = new HubStatus("CreateFailed");
        /// <summary>
        /// Constant Creating for HubStatus
        /// </summary>
        public static readonly HubStatus Creating = new HubStatus("Creating");
        /// <summary>
        /// Constant DeleteFailed for HubStatus
        /// </summary>
        public static readonly HubStatus DeleteFailed = new HubStatus("DeleteFailed");
        /// <summary>
        /// Constant Deleting for HubStatus
        /// </summary>
        public static readonly HubStatus Deleting = new HubStatus("Deleting");
        /// <summary>
        /// Constant InService for HubStatus
        /// </summary>
        public static readonly HubStatus InService = new HubStatus("InService");
        /// <summary>
        /// Constant UpdateFailed for HubStatus
        /// </summary>
        public static readonly HubStatus UpdateFailed = new HubStatus("UpdateFailed");
        /// <summary>
        /// Constant Updating for HubStatus
        /// </summary>
        public static readonly HubStatus Updating = new HubStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HubStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HubStatus FindValue(string value)
        {
            return FindValue<HubStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HubStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HumanTaskUiStatus.
    /// </summary>
    public class HumanTaskUiStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for HumanTaskUiStatus
        /// </summary>
        public static readonly HumanTaskUiStatus Active = new HumanTaskUiStatus("Active");
        /// <summary>
        /// Constant Deleting for HumanTaskUiStatus
        /// </summary>
        public static readonly HumanTaskUiStatus Deleting = new HumanTaskUiStatus("Deleting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HumanTaskUiStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HumanTaskUiStatus FindValue(string value)
        {
            return FindValue<HumanTaskUiStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HumanTaskUiStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterScalingType.
    /// </summary>
    public class HyperParameterScalingType : ConstantClass
    {

        /// <summary>
        /// Constant Auto for HyperParameterScalingType
        /// </summary>
        public static readonly HyperParameterScalingType Auto = new HyperParameterScalingType("Auto");
        /// <summary>
        /// Constant Linear for HyperParameterScalingType
        /// </summary>
        public static readonly HyperParameterScalingType Linear = new HyperParameterScalingType("Linear");
        /// <summary>
        /// Constant Logarithmic for HyperParameterScalingType
        /// </summary>
        public static readonly HyperParameterScalingType Logarithmic = new HyperParameterScalingType("Logarithmic");
        /// <summary>
        /// Constant ReverseLogarithmic for HyperParameterScalingType
        /// </summary>
        public static readonly HyperParameterScalingType ReverseLogarithmic = new HyperParameterScalingType("ReverseLogarithmic");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterScalingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterScalingType FindValue(string value)
        {
            return FindValue<HyperParameterScalingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterScalingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningAllocationStrategy.
    /// </summary>
    public class HyperParameterTuningAllocationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant Prioritized for HyperParameterTuningAllocationStrategy
        /// </summary>
        public static readonly HyperParameterTuningAllocationStrategy Prioritized = new HyperParameterTuningAllocationStrategy("Prioritized");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningAllocationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningAllocationStrategy FindValue(string value)
        {
            return FindValue<HyperParameterTuningAllocationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningAllocationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningJobObjectiveType.
    /// </summary>
    public class HyperParameterTuningJobObjectiveType : ConstantClass
    {

        /// <summary>
        /// Constant Maximize for HyperParameterTuningJobObjectiveType
        /// </summary>
        public static readonly HyperParameterTuningJobObjectiveType Maximize = new HyperParameterTuningJobObjectiveType("Maximize");
        /// <summary>
        /// Constant Minimize for HyperParameterTuningJobObjectiveType
        /// </summary>
        public static readonly HyperParameterTuningJobObjectiveType Minimize = new HyperParameterTuningJobObjectiveType("Minimize");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningJobObjectiveType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningJobObjectiveType FindValue(string value)
        {
            return FindValue<HyperParameterTuningJobObjectiveType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningJobObjectiveType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningJobSortByOptions.
    /// </summary>
    public class HyperParameterTuningJobSortByOptions : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for HyperParameterTuningJobSortByOptions
        /// </summary>
        public static readonly HyperParameterTuningJobSortByOptions CreationTime = new HyperParameterTuningJobSortByOptions("CreationTime");
        /// <summary>
        /// Constant Name for HyperParameterTuningJobSortByOptions
        /// </summary>
        public static readonly HyperParameterTuningJobSortByOptions Name = new HyperParameterTuningJobSortByOptions("Name");
        /// <summary>
        /// Constant Status for HyperParameterTuningJobSortByOptions
        /// </summary>
        public static readonly HyperParameterTuningJobSortByOptions Status = new HyperParameterTuningJobSortByOptions("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningJobSortByOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningJobSortByOptions FindValue(string value)
        {
            return FindValue<HyperParameterTuningJobSortByOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningJobSortByOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningJobStatus.
    /// </summary>
    public class HyperParameterTuningJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus Completed = new HyperParameterTuningJobStatus("Completed");
        /// <summary>
        /// Constant Failed for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus Failed = new HyperParameterTuningJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus InProgress = new HyperParameterTuningJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus Stopped = new HyperParameterTuningJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus Stopping = new HyperParameterTuningJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningJobStatus FindValue(string value)
        {
            return FindValue<HyperParameterTuningJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningJobStrategyType.
    /// </summary>
    public class HyperParameterTuningJobStrategyType : ConstantClass
    {

        /// <summary>
        /// Constant Bayesian for HyperParameterTuningJobStrategyType
        /// </summary>
        public static readonly HyperParameterTuningJobStrategyType Bayesian = new HyperParameterTuningJobStrategyType("Bayesian");
        /// <summary>
        /// Constant Grid for HyperParameterTuningJobStrategyType
        /// </summary>
        public static readonly HyperParameterTuningJobStrategyType Grid = new HyperParameterTuningJobStrategyType("Grid");
        /// <summary>
        /// Constant Hyperband for HyperParameterTuningJobStrategyType
        /// </summary>
        public static readonly HyperParameterTuningJobStrategyType Hyperband = new HyperParameterTuningJobStrategyType("Hyperband");
        /// <summary>
        /// Constant Random for HyperParameterTuningJobStrategyType
        /// </summary>
        public static readonly HyperParameterTuningJobStrategyType Random = new HyperParameterTuningJobStrategyType("Random");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningJobStrategyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningJobStrategyType FindValue(string value)
        {
            return FindValue<HyperParameterTuningJobStrategyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningJobStrategyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningJobWarmStartType.
    /// </summary>
    public class HyperParameterTuningJobWarmStartType : ConstantClass
    {

        /// <summary>
        /// Constant IdenticalDataAndAlgorithm for HyperParameterTuningJobWarmStartType
        /// </summary>
        public static readonly HyperParameterTuningJobWarmStartType IdenticalDataAndAlgorithm = new HyperParameterTuningJobWarmStartType("IdenticalDataAndAlgorithm");
        /// <summary>
        /// Constant TransferLearning for HyperParameterTuningJobWarmStartType
        /// </summary>
        public static readonly HyperParameterTuningJobWarmStartType TransferLearning = new HyperParameterTuningJobWarmStartType("TransferLearning");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningJobWarmStartType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningJobWarmStartType FindValue(string value)
        {
            return FindValue<HyperParameterTuningJobWarmStartType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningJobWarmStartType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageSortBy.
    /// </summary>
    public class ImageSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CREATION_TIME for ImageSortBy
        /// </summary>
        public static readonly ImageSortBy CREATION_TIME = new ImageSortBy("CREATION_TIME");
        /// <summary>
        /// Constant IMAGE_NAME for ImageSortBy
        /// </summary>
        public static readonly ImageSortBy IMAGE_NAME = new ImageSortBy("IMAGE_NAME");
        /// <summary>
        /// Constant LAST_MODIFIED_TIME for ImageSortBy
        /// </summary>
        public static readonly ImageSortBy LAST_MODIFIED_TIME = new ImageSortBy("LAST_MODIFIED_TIME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageSortBy FindValue(string value)
        {
            return FindValue<ImageSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageSortOrder.
    /// </summary>
    public class ImageSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for ImageSortOrder
        /// </summary>
        public static readonly ImageSortOrder ASCENDING = new ImageSortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for ImageSortOrder
        /// </summary>
        public static readonly ImageSortOrder DESCENDING = new ImageSortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageSortOrder FindValue(string value)
        {
            return FindValue<ImageSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageStatus.
    /// </summary>
    public class ImageStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for ImageStatus
        /// </summary>
        public static readonly ImageStatus CREATE_FAILED = new ImageStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATED for ImageStatus
        /// </summary>
        public static readonly ImageStatus CREATED = new ImageStatus("CREATED");
        /// <summary>
        /// Constant CREATING for ImageStatus
        /// </summary>
        public static readonly ImageStatus CREATING = new ImageStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for ImageStatus
        /// </summary>
        public static readonly ImageStatus DELETE_FAILED = new ImageStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for ImageStatus
        /// </summary>
        public static readonly ImageStatus DELETING = new ImageStatus("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for ImageStatus
        /// </summary>
        public static readonly ImageStatus UPDATE_FAILED = new ImageStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for ImageStatus
        /// </summary>
        public static readonly ImageStatus UPDATING = new ImageStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageStatus FindValue(string value)
        {
            return FindValue<ImageStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageVersionSortBy.
    /// </summary>
    public class ImageVersionSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CREATION_TIME for ImageVersionSortBy
        /// </summary>
        public static readonly ImageVersionSortBy CREATION_TIME = new ImageVersionSortBy("CREATION_TIME");
        /// <summary>
        /// Constant LAST_MODIFIED_TIME for ImageVersionSortBy
        /// </summary>
        public static readonly ImageVersionSortBy LAST_MODIFIED_TIME = new ImageVersionSortBy("LAST_MODIFIED_TIME");
        /// <summary>
        /// Constant VERSION for ImageVersionSortBy
        /// </summary>
        public static readonly ImageVersionSortBy VERSION = new ImageVersionSortBy("VERSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageVersionSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageVersionSortBy FindValue(string value)
        {
            return FindValue<ImageVersionSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageVersionSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageVersionSortOrder.
    /// </summary>
    public class ImageVersionSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for ImageVersionSortOrder
        /// </summary>
        public static readonly ImageVersionSortOrder ASCENDING = new ImageVersionSortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for ImageVersionSortOrder
        /// </summary>
        public static readonly ImageVersionSortOrder DESCENDING = new ImageVersionSortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageVersionSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageVersionSortOrder FindValue(string value)
        {
            return FindValue<ImageVersionSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageVersionSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageVersionStatus.
    /// </summary>
    public class ImageVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for ImageVersionStatus
        /// </summary>
        public static readonly ImageVersionStatus CREATE_FAILED = new ImageVersionStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATED for ImageVersionStatus
        /// </summary>
        public static readonly ImageVersionStatus CREATED = new ImageVersionStatus("CREATED");
        /// <summary>
        /// Constant CREATING for ImageVersionStatus
        /// </summary>
        public static readonly ImageVersionStatus CREATING = new ImageVersionStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for ImageVersionStatus
        /// </summary>
        public static readonly ImageVersionStatus DELETE_FAILED = new ImageVersionStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for ImageVersionStatus
        /// </summary>
        public static readonly ImageVersionStatus DELETING = new ImageVersionStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageVersionStatus FindValue(string value)
        {
            return FindValue<ImageVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InferenceExecutionMode.
    /// </summary>
    public class InferenceExecutionMode : ConstantClass
    {

        /// <summary>
        /// Constant Direct for InferenceExecutionMode
        /// </summary>
        public static readonly InferenceExecutionMode Direct = new InferenceExecutionMode("Direct");
        /// <summary>
        /// Constant Serial for InferenceExecutionMode
        /// </summary>
        public static readonly InferenceExecutionMode Serial = new InferenceExecutionMode("Serial");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InferenceExecutionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InferenceExecutionMode FindValue(string value)
        {
            return FindValue<InferenceExecutionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InferenceExecutionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InferenceExperimentStatus.
    /// </summary>
    public class InferenceExperimentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for InferenceExperimentStatus
        /// </summary>
        public static readonly InferenceExperimentStatus Cancelled = new InferenceExperimentStatus("Cancelled");
        /// <summary>
        /// Constant Completed for InferenceExperimentStatus
        /// </summary>
        public static readonly InferenceExperimentStatus Completed = new InferenceExperimentStatus("Completed");
        /// <summary>
        /// Constant Created for InferenceExperimentStatus
        /// </summary>
        public static readonly InferenceExperimentStatus Created = new InferenceExperimentStatus("Created");
        /// <summary>
        /// Constant Creating for InferenceExperimentStatus
        /// </summary>
        public static readonly InferenceExperimentStatus Creating = new InferenceExperimentStatus("Creating");
        /// <summary>
        /// Constant Running for InferenceExperimentStatus
        /// </summary>
        public static readonly InferenceExperimentStatus Running = new InferenceExperimentStatus("Running");
        /// <summary>
        /// Constant Starting for InferenceExperimentStatus
        /// </summary>
        public static readonly InferenceExperimentStatus Starting = new InferenceExperimentStatus("Starting");
        /// <summary>
        /// Constant Stopping for InferenceExperimentStatus
        /// </summary>
        public static readonly InferenceExperimentStatus Stopping = new InferenceExperimentStatus("Stopping");
        /// <summary>
        /// Constant Updating for InferenceExperimentStatus
        /// </summary>
        public static readonly InferenceExperimentStatus Updating = new InferenceExperimentStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InferenceExperimentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InferenceExperimentStatus FindValue(string value)
        {
            return FindValue<InferenceExperimentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InferenceExperimentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InferenceExperimentStopDesiredState.
    /// </summary>
    public class InferenceExperimentStopDesiredState : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for InferenceExperimentStopDesiredState
        /// </summary>
        public static readonly InferenceExperimentStopDesiredState Cancelled = new InferenceExperimentStopDesiredState("Cancelled");
        /// <summary>
        /// Constant Completed for InferenceExperimentStopDesiredState
        /// </summary>
        public static readonly InferenceExperimentStopDesiredState Completed = new InferenceExperimentStopDesiredState("Completed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InferenceExperimentStopDesiredState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InferenceExperimentStopDesiredState FindValue(string value)
        {
            return FindValue<InferenceExperimentStopDesiredState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InferenceExperimentStopDesiredState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InferenceExperimentType.
    /// </summary>
    public class InferenceExperimentType : ConstantClass
    {

        /// <summary>
        /// Constant ShadowMode for InferenceExperimentType
        /// </summary>
        public static readonly InferenceExperimentType ShadowMode = new InferenceExperimentType("ShadowMode");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InferenceExperimentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InferenceExperimentType FindValue(string value)
        {
            return FindValue<InferenceExperimentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InferenceExperimentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputMode.
    /// </summary>
    public class InputMode : ConstantClass
    {

        /// <summary>
        /// Constant File for InputMode
        /// </summary>
        public static readonly InputMode File = new InputMode("File");
        /// <summary>
        /// Constant Pipe for InputMode
        /// </summary>
        public static readonly InputMode Pipe = new InputMode("Pipe");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputMode FindValue(string value)
        {
            return FindValue<InputMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceType.
    /// </summary>
    public class InstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC42xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC42xlarge = new InstanceType("ml.c4.2xlarge");
        /// <summary>
        /// Constant MlC44xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC44xlarge = new InstanceType("ml.c4.4xlarge");
        /// <summary>
        /// Constant MlC48xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC48xlarge = new InstanceType("ml.c4.8xlarge");
        /// <summary>
        /// Constant MlC4Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC4Xlarge = new InstanceType("ml.c4.xlarge");
        /// <summary>
        /// Constant MlC518xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC518xlarge = new InstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC52xlarge = new InstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC54xlarge = new InstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC59xlarge = new InstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5d18xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5d18xlarge = new InstanceType("ml.c5d.18xlarge");
        /// <summary>
        /// Constant MlC5d2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5d2xlarge = new InstanceType("ml.c5d.2xlarge");
        /// <summary>
        /// Constant MlC5d4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5d4xlarge = new InstanceType("ml.c5d.4xlarge");
        /// <summary>
        /// Constant MlC5d9xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5d9xlarge = new InstanceType("ml.c5d.9xlarge");
        /// <summary>
        /// Constant MlC5dXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5dXlarge = new InstanceType("ml.c5d.xlarge");
        /// <summary>
        /// Constant MlC5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5Xlarge = new InstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlG4dn12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn12xlarge = new InstanceType("ml.g4dn.12xlarge");
        /// <summary>
        /// Constant MlG4dn16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn16xlarge = new InstanceType("ml.g4dn.16xlarge");
        /// <summary>
        /// Constant MlG4dn2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn2xlarge = new InstanceType("ml.g4dn.2xlarge");
        /// <summary>
        /// Constant MlG4dn4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn4xlarge = new InstanceType("ml.g4dn.4xlarge");
        /// <summary>
        /// Constant MlG4dn8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dn8xlarge = new InstanceType("ml.g4dn.8xlarge");
        /// <summary>
        /// Constant MlG4dnXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG4dnXlarge = new InstanceType("ml.g4dn.xlarge");
        /// <summary>
        /// Constant MlG512xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG512xlarge = new InstanceType("ml.g5.12xlarge");
        /// <summary>
        /// Constant MlG516xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG516xlarge = new InstanceType("ml.g5.16xlarge");
        /// <summary>
        /// Constant MlG524xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG524xlarge = new InstanceType("ml.g5.24xlarge");
        /// <summary>
        /// Constant MlG52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG52xlarge = new InstanceType("ml.g5.2xlarge");
        /// <summary>
        /// Constant MlG548xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG548xlarge = new InstanceType("ml.g5.48xlarge");
        /// <summary>
        /// Constant MlG54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG54xlarge = new InstanceType("ml.g5.4xlarge");
        /// <summary>
        /// Constant MlG58xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG58xlarge = new InstanceType("ml.g5.8xlarge");
        /// <summary>
        /// Constant MlG5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlG5Xlarge = new InstanceType("ml.g5.xlarge");
        /// <summary>
        /// Constant MlM410xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM410xlarge = new InstanceType("ml.m4.10xlarge");
        /// <summary>
        /// Constant MlM416xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM416xlarge = new InstanceType("ml.m4.16xlarge");
        /// <summary>
        /// Constant MlM42xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM42xlarge = new InstanceType("ml.m4.2xlarge");
        /// <summary>
        /// Constant MlM44xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM44xlarge = new InstanceType("ml.m4.4xlarge");
        /// <summary>
        /// Constant MlM4Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM4Xlarge = new InstanceType("ml.m4.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM512xlarge = new InstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM524xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM524xlarge = new InstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM52xlarge = new InstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM54xlarge = new InstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM5d12xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM5d12xlarge = new InstanceType("ml.m5d.12xlarge");
        /// <summary>
        /// Constant MlM5d16xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM5d16xlarge = new InstanceType("ml.m5d.16xlarge");
        /// <summary>
        /// Constant MlM5d24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM5d24xlarge = new InstanceType("ml.m5d.24xlarge");
        /// <summary>
        /// Constant MlM5d2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM5d2xlarge = new InstanceType("ml.m5d.2xlarge");
        /// <summary>
        /// Constant MlM5d4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM5d4xlarge = new InstanceType("ml.m5d.4xlarge");
        /// <summary>
        /// Constant MlM5d8xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM5d8xlarge = new InstanceType("ml.m5d.8xlarge");
        /// <summary>
        /// Constant MlM5dLarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM5dLarge = new InstanceType("ml.m5d.large");
        /// <summary>
        /// Constant MlM5dXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM5dXlarge = new InstanceType("ml.m5d.xlarge");
        /// <summary>
        /// Constant MlM5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM5Xlarge = new InstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlP216xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP216xlarge = new InstanceType("ml.p2.16xlarge");
        /// <summary>
        /// Constant MlP28xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP28xlarge = new InstanceType("ml.p2.8xlarge");
        /// <summary>
        /// Constant MlP2Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP2Xlarge = new InstanceType("ml.p2.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP316xlarge = new InstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP32xlarge = new InstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP38xlarge = new InstanceType("ml.p3.8xlarge");
        /// <summary>
        /// Constant MlP3dn24xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP3dn24xlarge = new InstanceType("ml.p3dn.24xlarge");
        /// <summary>
        /// Constant MlR512xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR512xlarge = new InstanceType("ml.r5.12xlarge");
        /// <summary>
        /// Constant MlR516xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR516xlarge = new InstanceType("ml.r5.16xlarge");
        /// <summary>
        /// Constant MlR524xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR524xlarge = new InstanceType("ml.r5.24xlarge");
        /// <summary>
        /// Constant MlR52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR52xlarge = new InstanceType("ml.r5.2xlarge");
        /// <summary>
        /// Constant MlR54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR54xlarge = new InstanceType("ml.r5.4xlarge");
        /// <summary>
        /// Constant MlR58xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR58xlarge = new InstanceType("ml.r5.8xlarge");
        /// <summary>
        /// Constant MlR5Large for InstanceType
        /// </summary>
        public static readonly InstanceType MlR5Large = new InstanceType("ml.r5.large");
        /// <summary>
        /// Constant MlR5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlR5Xlarge = new InstanceType("ml.r5.xlarge");
        /// <summary>
        /// Constant MlT22xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlT22xlarge = new InstanceType("ml.t2.2xlarge");
        /// <summary>
        /// Constant MlT2Large for InstanceType
        /// </summary>
        public static readonly InstanceType MlT2Large = new InstanceType("ml.t2.large");
        /// <summary>
        /// Constant MlT2Medium for InstanceType
        /// </summary>
        public static readonly InstanceType MlT2Medium = new InstanceType("ml.t2.medium");
        /// <summary>
        /// Constant MlT2Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlT2Xlarge = new InstanceType("ml.t2.xlarge");
        /// <summary>
        /// Constant MlT32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlT32xlarge = new InstanceType("ml.t3.2xlarge");
        /// <summary>
        /// Constant MlT3Large for InstanceType
        /// </summary>
        public static readonly InstanceType MlT3Large = new InstanceType("ml.t3.large");
        /// <summary>
        /// Constant MlT3Medium for InstanceType
        /// </summary>
        public static readonly InstanceType MlT3Medium = new InstanceType("ml.t3.medium");
        /// <summary>
        /// Constant MlT3Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlT3Xlarge = new InstanceType("ml.t3.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceType FindValue(string value)
        {
            return FindValue<InstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobType.
    /// </summary>
    public class JobType : ConstantClass
    {

        /// <summary>
        /// Constant INFERENCE for JobType
        /// </summary>
        public static readonly JobType INFERENCE = new JobType("INFERENCE");
        /// <summary>
        /// Constant NOTEBOOK_KERNEL for JobType
        /// </summary>
        public static readonly JobType NOTEBOOK_KERNEL = new JobType("NOTEBOOK_KERNEL");
        /// <summary>
        /// Constant TRAINING for JobType
        /// </summary>
        public static readonly JobType TRAINING = new JobType("TRAINING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobType FindValue(string value)
        {
            return FindValue<JobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JoinSource.
    /// </summary>
    public class JoinSource : ConstantClass
    {

        /// <summary>
        /// Constant Input for JoinSource
        /// </summary>
        public static readonly JoinSource Input = new JoinSource("Input");
        /// <summary>
        /// Constant None for JoinSource
        /// </summary>
        public static readonly JoinSource None = new JoinSource("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JoinSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JoinSource FindValue(string value)
        {
            return FindValue<JoinSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JoinSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LabelingJobStatus.
    /// </summary>
    public class LabelingJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for LabelingJobStatus
        /// </summary>
        public static readonly LabelingJobStatus Completed = new LabelingJobStatus("Completed");
        /// <summary>
        /// Constant Failed for LabelingJobStatus
        /// </summary>
        public static readonly LabelingJobStatus Failed = new LabelingJobStatus("Failed");
        /// <summary>
        /// Constant Initializing for LabelingJobStatus
        /// </summary>
        public static readonly LabelingJobStatus Initializing = new LabelingJobStatus("Initializing");
        /// <summary>
        /// Constant InProgress for LabelingJobStatus
        /// </summary>
        public static readonly LabelingJobStatus InProgress = new LabelingJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for LabelingJobStatus
        /// </summary>
        public static readonly LabelingJobStatus Stopped = new LabelingJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for LabelingJobStatus
        /// </summary>
        public static readonly LabelingJobStatus Stopping = new LabelingJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LabelingJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LabelingJobStatus FindValue(string value)
        {
            return FindValue<LabelingJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LabelingJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LastUpdateStatusValue.
    /// </summary>
    public class LastUpdateStatusValue : ConstantClass
    {

        /// <summary>
        /// Constant Failed for LastUpdateStatusValue
        /// </summary>
        public static readonly LastUpdateStatusValue Failed = new LastUpdateStatusValue("Failed");
        /// <summary>
        /// Constant InProgress for LastUpdateStatusValue
        /// </summary>
        public static readonly LastUpdateStatusValue InProgress = new LastUpdateStatusValue("InProgress");
        /// <summary>
        /// Constant Successful for LastUpdateStatusValue
        /// </summary>
        public static readonly LastUpdateStatusValue Successful = new LastUpdateStatusValue("Successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LastUpdateStatusValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LastUpdateStatusValue FindValue(string value)
        {
            return FindValue<LastUpdateStatusValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LastUpdateStatusValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LineageType.
    /// </summary>
    public class LineageType : ConstantClass
    {

        /// <summary>
        /// Constant Action for LineageType
        /// </summary>
        public static readonly LineageType Action = new LineageType("Action");
        /// <summary>
        /// Constant Artifact for LineageType
        /// </summary>
        public static readonly LineageType Artifact = new LineageType("Artifact");
        /// <summary>
        /// Constant Context for LineageType
        /// </summary>
        public static readonly LineageType Context = new LineageType("Context");
        /// <summary>
        /// Constant TrialComponent for LineageType
        /// </summary>
        public static readonly LineageType TrialComponent = new LineageType("TrialComponent");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LineageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LineageType FindValue(string value)
        {
            return FindValue<LineageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LineageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListCompilationJobsSortBy.
    /// </summary>
    public class ListCompilationJobsSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for ListCompilationJobsSortBy
        /// </summary>
        public static readonly ListCompilationJobsSortBy CreationTime = new ListCompilationJobsSortBy("CreationTime");
        /// <summary>
        /// Constant Name for ListCompilationJobsSortBy
        /// </summary>
        public static readonly ListCompilationJobsSortBy Name = new ListCompilationJobsSortBy("Name");
        /// <summary>
        /// Constant Status for ListCompilationJobsSortBy
        /// </summary>
        public static readonly ListCompilationJobsSortBy Status = new ListCompilationJobsSortBy("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListCompilationJobsSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListCompilationJobsSortBy FindValue(string value)
        {
            return FindValue<ListCompilationJobsSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListCompilationJobsSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListDeviceFleetsSortBy.
    /// </summary>
    public class ListDeviceFleetsSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CREATION_TIME for ListDeviceFleetsSortBy
        /// </summary>
        public static readonly ListDeviceFleetsSortBy CREATION_TIME = new ListDeviceFleetsSortBy("CREATION_TIME");
        /// <summary>
        /// Constant LAST_MODIFIED_TIME for ListDeviceFleetsSortBy
        /// </summary>
        public static readonly ListDeviceFleetsSortBy LAST_MODIFIED_TIME = new ListDeviceFleetsSortBy("LAST_MODIFIED_TIME");
        /// <summary>
        /// Constant NAME for ListDeviceFleetsSortBy
        /// </summary>
        public static readonly ListDeviceFleetsSortBy NAME = new ListDeviceFleetsSortBy("NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListDeviceFleetsSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListDeviceFleetsSortBy FindValue(string value)
        {
            return FindValue<ListDeviceFleetsSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListDeviceFleetsSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListEdgeDeploymentPlansSortBy.
    /// </summary>
    public class ListEdgeDeploymentPlansSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CREATION_TIME for ListEdgeDeploymentPlansSortBy
        /// </summary>
        public static readonly ListEdgeDeploymentPlansSortBy CREATION_TIME = new ListEdgeDeploymentPlansSortBy("CREATION_TIME");
        /// <summary>
        /// Constant DEVICE_FLEET_NAME for ListEdgeDeploymentPlansSortBy
        /// </summary>
        public static readonly ListEdgeDeploymentPlansSortBy DEVICE_FLEET_NAME = new ListEdgeDeploymentPlansSortBy("DEVICE_FLEET_NAME");
        /// <summary>
        /// Constant LAST_MODIFIED_TIME for ListEdgeDeploymentPlansSortBy
        /// </summary>
        public static readonly ListEdgeDeploymentPlansSortBy LAST_MODIFIED_TIME = new ListEdgeDeploymentPlansSortBy("LAST_MODIFIED_TIME");
        /// <summary>
        /// Constant NAME for ListEdgeDeploymentPlansSortBy
        /// </summary>
        public static readonly ListEdgeDeploymentPlansSortBy NAME = new ListEdgeDeploymentPlansSortBy("NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListEdgeDeploymentPlansSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListEdgeDeploymentPlansSortBy FindValue(string value)
        {
            return FindValue<ListEdgeDeploymentPlansSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListEdgeDeploymentPlansSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListEdgePackagingJobsSortBy.
    /// </summary>
    public class ListEdgePackagingJobsSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CREATION_TIME for ListEdgePackagingJobsSortBy
        /// </summary>
        public static readonly ListEdgePackagingJobsSortBy CREATION_TIME = new ListEdgePackagingJobsSortBy("CREATION_TIME");
        /// <summary>
        /// Constant LAST_MODIFIED_TIME for ListEdgePackagingJobsSortBy
        /// </summary>
        public static readonly ListEdgePackagingJobsSortBy LAST_MODIFIED_TIME = new ListEdgePackagingJobsSortBy("LAST_MODIFIED_TIME");
        /// <summary>
        /// Constant MODEL_NAME for ListEdgePackagingJobsSortBy
        /// </summary>
        public static readonly ListEdgePackagingJobsSortBy MODEL_NAME = new ListEdgePackagingJobsSortBy("MODEL_NAME");
        /// <summary>
        /// Constant NAME for ListEdgePackagingJobsSortBy
        /// </summary>
        public static readonly ListEdgePackagingJobsSortBy NAME = new ListEdgePackagingJobsSortBy("NAME");
        /// <summary>
        /// Constant STATUS for ListEdgePackagingJobsSortBy
        /// </summary>
        public static readonly ListEdgePackagingJobsSortBy STATUS = new ListEdgePackagingJobsSortBy("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListEdgePackagingJobsSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListEdgePackagingJobsSortBy FindValue(string value)
        {
            return FindValue<ListEdgePackagingJobsSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListEdgePackagingJobsSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListInferenceRecommendationsJobsSortBy.
    /// </summary>
    public class ListInferenceRecommendationsJobsSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for ListInferenceRecommendationsJobsSortBy
        /// </summary>
        public static readonly ListInferenceRecommendationsJobsSortBy CreationTime = new ListInferenceRecommendationsJobsSortBy("CreationTime");
        /// <summary>
        /// Constant Name for ListInferenceRecommendationsJobsSortBy
        /// </summary>
        public static readonly ListInferenceRecommendationsJobsSortBy Name = new ListInferenceRecommendationsJobsSortBy("Name");
        /// <summary>
        /// Constant Status for ListInferenceRecommendationsJobsSortBy
        /// </summary>
        public static readonly ListInferenceRecommendationsJobsSortBy Status = new ListInferenceRecommendationsJobsSortBy("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListInferenceRecommendationsJobsSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListInferenceRecommendationsJobsSortBy FindValue(string value)
        {
            return FindValue<ListInferenceRecommendationsJobsSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListInferenceRecommendationsJobsSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListLabelingJobsForWorkteamSortByOptions.
    /// </summary>
    public class ListLabelingJobsForWorkteamSortByOptions : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for ListLabelingJobsForWorkteamSortByOptions
        /// </summary>
        public static readonly ListLabelingJobsForWorkteamSortByOptions CreationTime = new ListLabelingJobsForWorkteamSortByOptions("CreationTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListLabelingJobsForWorkteamSortByOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListLabelingJobsForWorkteamSortByOptions FindValue(string value)
        {
            return FindValue<ListLabelingJobsForWorkteamSortByOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListLabelingJobsForWorkteamSortByOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListWorkforcesSortByOptions.
    /// </summary>
    public class ListWorkforcesSortByOptions : ConstantClass
    {

        /// <summary>
        /// Constant CreateDate for ListWorkforcesSortByOptions
        /// </summary>
        public static readonly ListWorkforcesSortByOptions CreateDate = new ListWorkforcesSortByOptions("CreateDate");
        /// <summary>
        /// Constant Name for ListWorkforcesSortByOptions
        /// </summary>
        public static readonly ListWorkforcesSortByOptions Name = new ListWorkforcesSortByOptions("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListWorkforcesSortByOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListWorkforcesSortByOptions FindValue(string value)
        {
            return FindValue<ListWorkforcesSortByOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListWorkforcesSortByOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListWorkteamsSortByOptions.
    /// </summary>
    public class ListWorkteamsSortByOptions : ConstantClass
    {

        /// <summary>
        /// Constant CreateDate for ListWorkteamsSortByOptions
        /// </summary>
        public static readonly ListWorkteamsSortByOptions CreateDate = new ListWorkteamsSortByOptions("CreateDate");
        /// <summary>
        /// Constant Name for ListWorkteamsSortByOptions
        /// </summary>
        public static readonly ListWorkteamsSortByOptions Name = new ListWorkteamsSortByOptions("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListWorkteamsSortByOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListWorkteamsSortByOptions FindValue(string value)
        {
            return FindValue<ListWorkteamsSortByOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListWorkteamsSortByOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricSetSource.
    /// </summary>
    public class MetricSetSource : ConstantClass
    {

        /// <summary>
        /// Constant Test for MetricSetSource
        /// </summary>
        public static readonly MetricSetSource Test = new MetricSetSource("Test");
        /// <summary>
        /// Constant Train for MetricSetSource
        /// </summary>
        public static readonly MetricSetSource Train = new MetricSetSource("Train");
        /// <summary>
        /// Constant Validation for MetricSetSource
        /// </summary>
        public static readonly MetricSetSource Validation = new MetricSetSource("Validation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricSetSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricSetSource FindValue(string value)
        {
            return FindValue<MetricSetSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricSetSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelApprovalStatus.
    /// </summary>
    public class ModelApprovalStatus : ConstantClass
    {

        /// <summary>
        /// Constant Approved for ModelApprovalStatus
        /// </summary>
        public static readonly ModelApprovalStatus Approved = new ModelApprovalStatus("Approved");
        /// <summary>
        /// Constant PendingManualApproval for ModelApprovalStatus
        /// </summary>
        public static readonly ModelApprovalStatus PendingManualApproval = new ModelApprovalStatus("PendingManualApproval");
        /// <summary>
        /// Constant Rejected for ModelApprovalStatus
        /// </summary>
        public static readonly ModelApprovalStatus Rejected = new ModelApprovalStatus("Rejected");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelApprovalStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelApprovalStatus FindValue(string value)
        {
            return FindValue<ModelApprovalStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelApprovalStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelCacheSetting.
    /// </summary>
    public class ModelCacheSetting : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ModelCacheSetting
        /// </summary>
        public static readonly ModelCacheSetting Disabled = new ModelCacheSetting("Disabled");
        /// <summary>
        /// Constant Enabled for ModelCacheSetting
        /// </summary>
        public static readonly ModelCacheSetting Enabled = new ModelCacheSetting("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelCacheSetting(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelCacheSetting FindValue(string value)
        {
            return FindValue<ModelCacheSetting>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelCacheSetting(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelCardExportJobSortBy.
    /// </summary>
    public class ModelCardExportJobSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for ModelCardExportJobSortBy
        /// </summary>
        public static readonly ModelCardExportJobSortBy CreationTime = new ModelCardExportJobSortBy("CreationTime");
        /// <summary>
        /// Constant Name for ModelCardExportJobSortBy
        /// </summary>
        public static readonly ModelCardExportJobSortBy Name = new ModelCardExportJobSortBy("Name");
        /// <summary>
        /// Constant Status for ModelCardExportJobSortBy
        /// </summary>
        public static readonly ModelCardExportJobSortBy Status = new ModelCardExportJobSortBy("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelCardExportJobSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelCardExportJobSortBy FindValue(string value)
        {
            return FindValue<ModelCardExportJobSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelCardExportJobSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelCardExportJobSortOrder.
    /// </summary>
    public class ModelCardExportJobSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for ModelCardExportJobSortOrder
        /// </summary>
        public static readonly ModelCardExportJobSortOrder Ascending = new ModelCardExportJobSortOrder("Ascending");
        /// <summary>
        /// Constant Descending for ModelCardExportJobSortOrder
        /// </summary>
        public static readonly ModelCardExportJobSortOrder Descending = new ModelCardExportJobSortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelCardExportJobSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelCardExportJobSortOrder FindValue(string value)
        {
            return FindValue<ModelCardExportJobSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelCardExportJobSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelCardExportJobStatus.
    /// </summary>
    public class ModelCardExportJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for ModelCardExportJobStatus
        /// </summary>
        public static readonly ModelCardExportJobStatus Completed = new ModelCardExportJobStatus("Completed");
        /// <summary>
        /// Constant Failed for ModelCardExportJobStatus
        /// </summary>
        public static readonly ModelCardExportJobStatus Failed = new ModelCardExportJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for ModelCardExportJobStatus
        /// </summary>
        public static readonly ModelCardExportJobStatus InProgress = new ModelCardExportJobStatus("InProgress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelCardExportJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelCardExportJobStatus FindValue(string value)
        {
            return FindValue<ModelCardExportJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelCardExportJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelCardProcessingStatus.
    /// </summary>
    public class ModelCardProcessingStatus : ConstantClass
    {

        /// <summary>
        /// Constant ContentDeleted for ModelCardProcessingStatus
        /// </summary>
        public static readonly ModelCardProcessingStatus ContentDeleted = new ModelCardProcessingStatus("ContentDeleted");
        /// <summary>
        /// Constant DeleteCompleted for ModelCardProcessingStatus
        /// </summary>
        public static readonly ModelCardProcessingStatus DeleteCompleted = new ModelCardProcessingStatus("DeleteCompleted");
        /// <summary>
        /// Constant DeleteFailed for ModelCardProcessingStatus
        /// </summary>
        public static readonly ModelCardProcessingStatus DeleteFailed = new ModelCardProcessingStatus("DeleteFailed");
        /// <summary>
        /// Constant DeleteInProgress for ModelCardProcessingStatus
        /// </summary>
        public static readonly ModelCardProcessingStatus DeleteInProgress = new ModelCardProcessingStatus("DeleteInProgress");
        /// <summary>
        /// Constant DeletePending for ModelCardProcessingStatus
        /// </summary>
        public static readonly ModelCardProcessingStatus DeletePending = new ModelCardProcessingStatus("DeletePending");
        /// <summary>
        /// Constant ExportJobsDeleted for ModelCardProcessingStatus
        /// </summary>
        public static readonly ModelCardProcessingStatus ExportJobsDeleted = new ModelCardProcessingStatus("ExportJobsDeleted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelCardProcessingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelCardProcessingStatus FindValue(string value)
        {
            return FindValue<ModelCardProcessingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelCardProcessingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelCardSortBy.
    /// </summary>
    public class ModelCardSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for ModelCardSortBy
        /// </summary>
        public static readonly ModelCardSortBy CreationTime = new ModelCardSortBy("CreationTime");
        /// <summary>
        /// Constant Name for ModelCardSortBy
        /// </summary>
        public static readonly ModelCardSortBy Name = new ModelCardSortBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelCardSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelCardSortBy FindValue(string value)
        {
            return FindValue<ModelCardSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelCardSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelCardSortOrder.
    /// </summary>
    public class ModelCardSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for ModelCardSortOrder
        /// </summary>
        public static readonly ModelCardSortOrder Ascending = new ModelCardSortOrder("Ascending");
        /// <summary>
        /// Constant Descending for ModelCardSortOrder
        /// </summary>
        public static readonly ModelCardSortOrder Descending = new ModelCardSortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelCardSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelCardSortOrder FindValue(string value)
        {
            return FindValue<ModelCardSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelCardSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelCardStatus.
    /// </summary>
    public class ModelCardStatus : ConstantClass
    {

        /// <summary>
        /// Constant Approved for ModelCardStatus
        /// </summary>
        public static readonly ModelCardStatus Approved = new ModelCardStatus("Approved");
        /// <summary>
        /// Constant Archived for ModelCardStatus
        /// </summary>
        public static readonly ModelCardStatus Archived = new ModelCardStatus("Archived");
        /// <summary>
        /// Constant Draft for ModelCardStatus
        /// </summary>
        public static readonly ModelCardStatus Draft = new ModelCardStatus("Draft");
        /// <summary>
        /// Constant PendingReview for ModelCardStatus
        /// </summary>
        public static readonly ModelCardStatus PendingReview = new ModelCardStatus("PendingReview");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelCardStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelCardStatus FindValue(string value)
        {
            return FindValue<ModelCardStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelCardStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelCardVersionSortBy.
    /// </summary>
    public class ModelCardVersionSortBy : ConstantClass
    {

        /// <summary>
        /// Constant Version for ModelCardVersionSortBy
        /// </summary>
        public static readonly ModelCardVersionSortBy Version = new ModelCardVersionSortBy("Version");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelCardVersionSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelCardVersionSortBy FindValue(string value)
        {
            return FindValue<ModelCardVersionSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelCardVersionSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelInfrastructureType.
    /// </summary>
    public class ModelInfrastructureType : ConstantClass
    {

        /// <summary>
        /// Constant RealTimeInference for ModelInfrastructureType
        /// </summary>
        public static readonly ModelInfrastructureType RealTimeInference = new ModelInfrastructureType("RealTimeInference");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelInfrastructureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelInfrastructureType FindValue(string value)
        {
            return FindValue<ModelInfrastructureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelInfrastructureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelMetadataFilterType.
    /// </summary>
    public class ModelMetadataFilterType : ConstantClass
    {

        /// <summary>
        /// Constant Domain for ModelMetadataFilterType
        /// </summary>
        public static readonly ModelMetadataFilterType Domain = new ModelMetadataFilterType("Domain");
        /// <summary>
        /// Constant Framework for ModelMetadataFilterType
        /// </summary>
        public static readonly ModelMetadataFilterType Framework = new ModelMetadataFilterType("Framework");
        /// <summary>
        /// Constant FrameworkVersion for ModelMetadataFilterType
        /// </summary>
        public static readonly ModelMetadataFilterType FrameworkVersion = new ModelMetadataFilterType("FrameworkVersion");
        /// <summary>
        /// Constant Task for ModelMetadataFilterType
        /// </summary>
        public static readonly ModelMetadataFilterType Task = new ModelMetadataFilterType("Task");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelMetadataFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelMetadataFilterType FindValue(string value)
        {
            return FindValue<ModelMetadataFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelMetadataFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelPackageGroupSortBy.
    /// </summary>
    public class ModelPackageGroupSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for ModelPackageGroupSortBy
        /// </summary>
        public static readonly ModelPackageGroupSortBy CreationTime = new ModelPackageGroupSortBy("CreationTime");
        /// <summary>
        /// Constant Name for ModelPackageGroupSortBy
        /// </summary>
        public static readonly ModelPackageGroupSortBy Name = new ModelPackageGroupSortBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelPackageGroupSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelPackageGroupSortBy FindValue(string value)
        {
            return FindValue<ModelPackageGroupSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelPackageGroupSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelPackageGroupStatus.
    /// </summary>
    public class ModelPackageGroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for ModelPackageGroupStatus
        /// </summary>
        public static readonly ModelPackageGroupStatus Completed = new ModelPackageGroupStatus("Completed");
        /// <summary>
        /// Constant DeleteFailed for ModelPackageGroupStatus
        /// </summary>
        public static readonly ModelPackageGroupStatus DeleteFailed = new ModelPackageGroupStatus("DeleteFailed");
        /// <summary>
        /// Constant Deleting for ModelPackageGroupStatus
        /// </summary>
        public static readonly ModelPackageGroupStatus Deleting = new ModelPackageGroupStatus("Deleting");
        /// <summary>
        /// Constant Failed for ModelPackageGroupStatus
        /// </summary>
        public static readonly ModelPackageGroupStatus Failed = new ModelPackageGroupStatus("Failed");
        /// <summary>
        /// Constant InProgress for ModelPackageGroupStatus
        /// </summary>
        public static readonly ModelPackageGroupStatus InProgress = new ModelPackageGroupStatus("InProgress");
        /// <summary>
        /// Constant Pending for ModelPackageGroupStatus
        /// </summary>
        public static readonly ModelPackageGroupStatus Pending = new ModelPackageGroupStatus("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelPackageGroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelPackageGroupStatus FindValue(string value)
        {
            return FindValue<ModelPackageGroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelPackageGroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelPackageSortBy.
    /// </summary>
    public class ModelPackageSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for ModelPackageSortBy
        /// </summary>
        public static readonly ModelPackageSortBy CreationTime = new ModelPackageSortBy("CreationTime");
        /// <summary>
        /// Constant Name for ModelPackageSortBy
        /// </summary>
        public static readonly ModelPackageSortBy Name = new ModelPackageSortBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelPackageSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelPackageSortBy FindValue(string value)
        {
            return FindValue<ModelPackageSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelPackageSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelPackageStatus.
    /// </summary>
    public class ModelPackageStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for ModelPackageStatus
        /// </summary>
        public static readonly ModelPackageStatus Completed = new ModelPackageStatus("Completed");
        /// <summary>
        /// Constant Deleting for ModelPackageStatus
        /// </summary>
        public static readonly ModelPackageStatus Deleting = new ModelPackageStatus("Deleting");
        /// <summary>
        /// Constant Failed for ModelPackageStatus
        /// </summary>
        public static readonly ModelPackageStatus Failed = new ModelPackageStatus("Failed");
        /// <summary>
        /// Constant InProgress for ModelPackageStatus
        /// </summary>
        public static readonly ModelPackageStatus InProgress = new ModelPackageStatus("InProgress");
        /// <summary>
        /// Constant Pending for ModelPackageStatus
        /// </summary>
        public static readonly ModelPackageStatus Pending = new ModelPackageStatus("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelPackageStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelPackageStatus FindValue(string value)
        {
            return FindValue<ModelPackageStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelPackageStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelPackageType.
    /// </summary>
    public class ModelPackageType : ConstantClass
    {

        /// <summary>
        /// Constant Both for ModelPackageType
        /// </summary>
        public static readonly ModelPackageType Both = new ModelPackageType("Both");
        /// <summary>
        /// Constant Unversioned for ModelPackageType
        /// </summary>
        public static readonly ModelPackageType Unversioned = new ModelPackageType("Unversioned");
        /// <summary>
        /// Constant Versioned for ModelPackageType
        /// </summary>
        public static readonly ModelPackageType Versioned = new ModelPackageType("Versioned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelPackageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelPackageType FindValue(string value)
        {
            return FindValue<ModelPackageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelPackageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelSortKey.
    /// </summary>
    public class ModelSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for ModelSortKey
        /// </summary>
        public static readonly ModelSortKey CreationTime = new ModelSortKey("CreationTime");
        /// <summary>
        /// Constant Name for ModelSortKey
        /// </summary>
        public static readonly ModelSortKey Name = new ModelSortKey("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelSortKey FindValue(string value)
        {
            return FindValue<ModelSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelVariantAction.
    /// </summary>
    public class ModelVariantAction : ConstantClass
    {

        /// <summary>
        /// Constant Promote for ModelVariantAction
        /// </summary>
        public static readonly ModelVariantAction Promote = new ModelVariantAction("Promote");
        /// <summary>
        /// Constant Remove for ModelVariantAction
        /// </summary>
        public static readonly ModelVariantAction Remove = new ModelVariantAction("Remove");
        /// <summary>
        /// Constant Retain for ModelVariantAction
        /// </summary>
        public static readonly ModelVariantAction Retain = new ModelVariantAction("Retain");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelVariantAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelVariantAction FindValue(string value)
        {
            return FindValue<ModelVariantAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelVariantAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelVariantStatus.
    /// </summary>
    public class ModelVariantStatus : ConstantClass
    {

        /// <summary>
        /// Constant Creating for ModelVariantStatus
        /// </summary>
        public static readonly ModelVariantStatus Creating = new ModelVariantStatus("Creating");
        /// <summary>
        /// Constant Deleted for ModelVariantStatus
        /// </summary>
        public static readonly ModelVariantStatus Deleted = new ModelVariantStatus("Deleted");
        /// <summary>
        /// Constant Deleting for ModelVariantStatus
        /// </summary>
        public static readonly ModelVariantStatus Deleting = new ModelVariantStatus("Deleting");
        /// <summary>
        /// Constant InService for ModelVariantStatus
        /// </summary>
        public static readonly ModelVariantStatus InService = new ModelVariantStatus("InService");
        /// <summary>
        /// Constant Updating for ModelVariantStatus
        /// </summary>
        public static readonly ModelVariantStatus Updating = new ModelVariantStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelVariantStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelVariantStatus FindValue(string value)
        {
            return FindValue<ModelVariantStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelVariantStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitoringAlertHistorySortKey.
    /// </summary>
    public class MonitoringAlertHistorySortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for MonitoringAlertHistorySortKey
        /// </summary>
        public static readonly MonitoringAlertHistorySortKey CreationTime = new MonitoringAlertHistorySortKey("CreationTime");
        /// <summary>
        /// Constant Status for MonitoringAlertHistorySortKey
        /// </summary>
        public static readonly MonitoringAlertHistorySortKey Status = new MonitoringAlertHistorySortKey("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitoringAlertHistorySortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitoringAlertHistorySortKey FindValue(string value)
        {
            return FindValue<MonitoringAlertHistorySortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitoringAlertHistorySortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitoringAlertStatus.
    /// </summary>
    public class MonitoringAlertStatus : ConstantClass
    {

        /// <summary>
        /// Constant InAlert for MonitoringAlertStatus
        /// </summary>
        public static readonly MonitoringAlertStatus InAlert = new MonitoringAlertStatus("InAlert");
        /// <summary>
        /// Constant OK for MonitoringAlertStatus
        /// </summary>
        public static readonly MonitoringAlertStatus OK = new MonitoringAlertStatus("OK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitoringAlertStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitoringAlertStatus FindValue(string value)
        {
            return FindValue<MonitoringAlertStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitoringAlertStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitoringExecutionSortKey.
    /// </summary>
    public class MonitoringExecutionSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for MonitoringExecutionSortKey
        /// </summary>
        public static readonly MonitoringExecutionSortKey CreationTime = new MonitoringExecutionSortKey("CreationTime");
        /// <summary>
        /// Constant ScheduledTime for MonitoringExecutionSortKey
        /// </summary>
        public static readonly MonitoringExecutionSortKey ScheduledTime = new MonitoringExecutionSortKey("ScheduledTime");
        /// <summary>
        /// Constant Status for MonitoringExecutionSortKey
        /// </summary>
        public static readonly MonitoringExecutionSortKey Status = new MonitoringExecutionSortKey("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitoringExecutionSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitoringExecutionSortKey FindValue(string value)
        {
            return FindValue<MonitoringExecutionSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitoringExecutionSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitoringJobDefinitionSortKey.
    /// </summary>
    public class MonitoringJobDefinitionSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for MonitoringJobDefinitionSortKey
        /// </summary>
        public static readonly MonitoringJobDefinitionSortKey CreationTime = new MonitoringJobDefinitionSortKey("CreationTime");
        /// <summary>
        /// Constant Name for MonitoringJobDefinitionSortKey
        /// </summary>
        public static readonly MonitoringJobDefinitionSortKey Name = new MonitoringJobDefinitionSortKey("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitoringJobDefinitionSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitoringJobDefinitionSortKey FindValue(string value)
        {
            return FindValue<MonitoringJobDefinitionSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitoringJobDefinitionSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitoringProblemType.
    /// </summary>
    public class MonitoringProblemType : ConstantClass
    {

        /// <summary>
        /// Constant BinaryClassification for MonitoringProblemType
        /// </summary>
        public static readonly MonitoringProblemType BinaryClassification = new MonitoringProblemType("BinaryClassification");
        /// <summary>
        /// Constant MulticlassClassification for MonitoringProblemType
        /// </summary>
        public static readonly MonitoringProblemType MulticlassClassification = new MonitoringProblemType("MulticlassClassification");
        /// <summary>
        /// Constant Regression for MonitoringProblemType
        /// </summary>
        public static readonly MonitoringProblemType Regression = new MonitoringProblemType("Regression");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitoringProblemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitoringProblemType FindValue(string value)
        {
            return FindValue<MonitoringProblemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitoringProblemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitoringScheduleSortKey.
    /// </summary>
    public class MonitoringScheduleSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for MonitoringScheduleSortKey
        /// </summary>
        public static readonly MonitoringScheduleSortKey CreationTime = new MonitoringScheduleSortKey("CreationTime");
        /// <summary>
        /// Constant Name for MonitoringScheduleSortKey
        /// </summary>
        public static readonly MonitoringScheduleSortKey Name = new MonitoringScheduleSortKey("Name");
        /// <summary>
        /// Constant Status for MonitoringScheduleSortKey
        /// </summary>
        public static readonly MonitoringScheduleSortKey Status = new MonitoringScheduleSortKey("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitoringScheduleSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitoringScheduleSortKey FindValue(string value)
        {
            return FindValue<MonitoringScheduleSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitoringScheduleSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitoringType.
    /// </summary>
    public class MonitoringType : ConstantClass
    {

        /// <summary>
        /// Constant DataQuality for MonitoringType
        /// </summary>
        public static readonly MonitoringType DataQuality = new MonitoringType("DataQuality");
        /// <summary>
        /// Constant ModelBias for MonitoringType
        /// </summary>
        public static readonly MonitoringType ModelBias = new MonitoringType("ModelBias");
        /// <summary>
        /// Constant ModelExplainability for MonitoringType
        /// </summary>
        public static readonly MonitoringType ModelExplainability = new MonitoringType("ModelExplainability");
        /// <summary>
        /// Constant ModelQuality for MonitoringType
        /// </summary>
        public static readonly MonitoringType ModelQuality = new MonitoringType("ModelQuality");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitoringType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitoringType FindValue(string value)
        {
            return FindValue<MonitoringType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitoringType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceAcceleratorType.
    /// </summary>
    public class NotebookInstanceAcceleratorType : ConstantClass
    {

        /// <summary>
        /// Constant MlEia1Large for NotebookInstanceAcceleratorType
        /// </summary>
        public static readonly NotebookInstanceAcceleratorType MlEia1Large = new NotebookInstanceAcceleratorType("ml.eia1.large");
        /// <summary>
        /// Constant MlEia1Medium for NotebookInstanceAcceleratorType
        /// </summary>
        public static readonly NotebookInstanceAcceleratorType MlEia1Medium = new NotebookInstanceAcceleratorType("ml.eia1.medium");
        /// <summary>
        /// Constant MlEia1Xlarge for NotebookInstanceAcceleratorType
        /// </summary>
        public static readonly NotebookInstanceAcceleratorType MlEia1Xlarge = new NotebookInstanceAcceleratorType("ml.eia1.xlarge");
        /// <summary>
        /// Constant MlEia2Large for NotebookInstanceAcceleratorType
        /// </summary>
        public static readonly NotebookInstanceAcceleratorType MlEia2Large = new NotebookInstanceAcceleratorType("ml.eia2.large");
        /// <summary>
        /// Constant MlEia2Medium for NotebookInstanceAcceleratorType
        /// </summary>
        public static readonly NotebookInstanceAcceleratorType MlEia2Medium = new NotebookInstanceAcceleratorType("ml.eia2.medium");
        /// <summary>
        /// Constant MlEia2Xlarge for NotebookInstanceAcceleratorType
        /// </summary>
        public static readonly NotebookInstanceAcceleratorType MlEia2Xlarge = new NotebookInstanceAcceleratorType("ml.eia2.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceAcceleratorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceAcceleratorType FindValue(string value)
        {
            return FindValue<NotebookInstanceAcceleratorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceAcceleratorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceLifecycleConfigSortKey.
    /// </summary>
    public class NotebookInstanceLifecycleConfigSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for NotebookInstanceLifecycleConfigSortKey
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortKey CreationTime = new NotebookInstanceLifecycleConfigSortKey("CreationTime");
        /// <summary>
        /// Constant LastModifiedTime for NotebookInstanceLifecycleConfigSortKey
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortKey LastModifiedTime = new NotebookInstanceLifecycleConfigSortKey("LastModifiedTime");
        /// <summary>
        /// Constant Name for NotebookInstanceLifecycleConfigSortKey
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortKey Name = new NotebookInstanceLifecycleConfigSortKey("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceLifecycleConfigSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceLifecycleConfigSortKey FindValue(string value)
        {
            return FindValue<NotebookInstanceLifecycleConfigSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceLifecycleConfigSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceLifecycleConfigSortOrder.
    /// </summary>
    public class NotebookInstanceLifecycleConfigSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for NotebookInstanceLifecycleConfigSortOrder
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortOrder Ascending = new NotebookInstanceLifecycleConfigSortOrder("Ascending");
        /// <summary>
        /// Constant Descending for NotebookInstanceLifecycleConfigSortOrder
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortOrder Descending = new NotebookInstanceLifecycleConfigSortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceLifecycleConfigSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceLifecycleConfigSortOrder FindValue(string value)
        {
            return FindValue<NotebookInstanceLifecycleConfigSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceLifecycleConfigSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceSortKey.
    /// </summary>
    public class NotebookInstanceSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for NotebookInstanceSortKey
        /// </summary>
        public static readonly NotebookInstanceSortKey CreationTime = new NotebookInstanceSortKey("CreationTime");
        /// <summary>
        /// Constant Name for NotebookInstanceSortKey
        /// </summary>
        public static readonly NotebookInstanceSortKey Name = new NotebookInstanceSortKey("Name");
        /// <summary>
        /// Constant Status for NotebookInstanceSortKey
        /// </summary>
        public static readonly NotebookInstanceSortKey Status = new NotebookInstanceSortKey("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceSortKey FindValue(string value)
        {
            return FindValue<NotebookInstanceSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceSortOrder.
    /// </summary>
    public class NotebookInstanceSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for NotebookInstanceSortOrder
        /// </summary>
        public static readonly NotebookInstanceSortOrder Ascending = new NotebookInstanceSortOrder("Ascending");
        /// <summary>
        /// Constant Descending for NotebookInstanceSortOrder
        /// </summary>
        public static readonly NotebookInstanceSortOrder Descending = new NotebookInstanceSortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceSortOrder FindValue(string value)
        {
            return FindValue<NotebookInstanceSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceStatus.
    /// </summary>
    public class NotebookInstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deleting for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Deleting = new NotebookInstanceStatus("Deleting");
        /// <summary>
        /// Constant Failed for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Failed = new NotebookInstanceStatus("Failed");
        /// <summary>
        /// Constant InService for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus InService = new NotebookInstanceStatus("InService");
        /// <summary>
        /// Constant Pending for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Pending = new NotebookInstanceStatus("Pending");
        /// <summary>
        /// Constant Stopped for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Stopped = new NotebookInstanceStatus("Stopped");
        /// <summary>
        /// Constant Stopping for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Stopping = new NotebookInstanceStatus("Stopping");
        /// <summary>
        /// Constant Updating for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Updating = new NotebookInstanceStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceStatus FindValue(string value)
        {
            return FindValue<NotebookInstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookOutputOption.
    /// </summary>
    public class NotebookOutputOption : ConstantClass
    {

        /// <summary>
        /// Constant Allowed for NotebookOutputOption
        /// </summary>
        public static readonly NotebookOutputOption Allowed = new NotebookOutputOption("Allowed");
        /// <summary>
        /// Constant Disabled for NotebookOutputOption
        /// </summary>
        public static readonly NotebookOutputOption Disabled = new NotebookOutputOption("Disabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookOutputOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookOutputOption FindValue(string value)
        {
            return FindValue<NotebookOutputOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookOutputOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectiveStatus.
    /// </summary>
    public class ObjectiveStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for ObjectiveStatus
        /// </summary>
        public static readonly ObjectiveStatus Failed = new ObjectiveStatus("Failed");
        /// <summary>
        /// Constant Pending for ObjectiveStatus
        /// </summary>
        public static readonly ObjectiveStatus Pending = new ObjectiveStatus("Pending");
        /// <summary>
        /// Constant Succeeded for ObjectiveStatus
        /// </summary>
        public static readonly ObjectiveStatus Succeeded = new ObjectiveStatus("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectiveStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectiveStatus FindValue(string value)
        {
            return FindValue<ObjectiveStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectiveStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OfflineStoreStatusValue.
    /// </summary>
    public class OfflineStoreStatusValue : ConstantClass
    {

        /// <summary>
        /// Constant Active for OfflineStoreStatusValue
        /// </summary>
        public static readonly OfflineStoreStatusValue Active = new OfflineStoreStatusValue("Active");
        /// <summary>
        /// Constant Blocked for OfflineStoreStatusValue
        /// </summary>
        public static readonly OfflineStoreStatusValue Blocked = new OfflineStoreStatusValue("Blocked");
        /// <summary>
        /// Constant Disabled for OfflineStoreStatusValue
        /// </summary>
        public static readonly OfflineStoreStatusValue Disabled = new OfflineStoreStatusValue("Disabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OfflineStoreStatusValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OfflineStoreStatusValue FindValue(string value)
        {
            return FindValue<OfflineStoreStatusValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OfflineStoreStatusValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operator.
    /// </summary>
    public class Operator : ConstantClass
    {

        /// <summary>
        /// Constant Contains for Operator
        /// </summary>
        public static readonly Operator Contains = new Operator("Contains");
        /// <summary>
        /// Constant Equals for Operator
        /// </summary>
        public static readonly Operator Equals = new Operator("Equals");
        /// <summary>
        /// Constant Exists for Operator
        /// </summary>
        public static readonly Operator Exists = new Operator("Exists");
        /// <summary>
        /// Constant GreaterThan for Operator
        /// </summary>
        public static readonly Operator GreaterThan = new Operator("GreaterThan");
        /// <summary>
        /// Constant GreaterThanOrEqualTo for Operator
        /// </summary>
        public static readonly Operator GreaterThanOrEqualTo = new Operator("GreaterThanOrEqualTo");
        /// <summary>
        /// Constant In for Operator
        /// </summary>
        public static readonly Operator In = new Operator("In");
        /// <summary>
        /// Constant LessThan for Operator
        /// </summary>
        public static readonly Operator LessThan = new Operator("LessThan");
        /// <summary>
        /// Constant LessThanOrEqualTo for Operator
        /// </summary>
        public static readonly Operator LessThanOrEqualTo = new Operator("LessThanOrEqualTo");
        /// <summary>
        /// Constant NotEquals for Operator
        /// </summary>
        public static readonly Operator NotEquals = new Operator("NotEquals");
        /// <summary>
        /// Constant NotExists for Operator
        /// </summary>
        public static readonly Operator NotExists = new Operator("NotExists");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operator FindValue(string value)
        {
            return FindValue<Operator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderKey.
    /// </summary>
    public class OrderKey : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for OrderKey
        /// </summary>
        public static readonly OrderKey Ascending = new OrderKey("Ascending");
        /// <summary>
        /// Constant Descending for OrderKey
        /// </summary>
        public static readonly OrderKey Descending = new OrderKey("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderKey FindValue(string value)
        {
            return FindValue<OrderKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParameterType.
    /// </summary>
    public class ParameterType : ConstantClass
    {

        /// <summary>
        /// Constant Categorical for ParameterType
        /// </summary>
        public static readonly ParameterType Categorical = new ParameterType("Categorical");
        /// <summary>
        /// Constant Continuous for ParameterType
        /// </summary>
        public static readonly ParameterType Continuous = new ParameterType("Continuous");
        /// <summary>
        /// Constant FreeText for ParameterType
        /// </summary>
        public static readonly ParameterType FreeText = new ParameterType("FreeText");
        /// <summary>
        /// Constant Integer for ParameterType
        /// </summary>
        public static readonly ParameterType Integer = new ParameterType("Integer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParameterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterType FindValue(string value)
        {
            return FindValue<ParameterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipelineExecutionStatus.
    /// </summary>
    public class PipelineExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Executing for PipelineExecutionStatus
        /// </summary>
        public static readonly PipelineExecutionStatus Executing = new PipelineExecutionStatus("Executing");
        /// <summary>
        /// Constant Failed for PipelineExecutionStatus
        /// </summary>
        public static readonly PipelineExecutionStatus Failed = new PipelineExecutionStatus("Failed");
        /// <summary>
        /// Constant Stopped for PipelineExecutionStatus
        /// </summary>
        public static readonly PipelineExecutionStatus Stopped = new PipelineExecutionStatus("Stopped");
        /// <summary>
        /// Constant Stopping for PipelineExecutionStatus
        /// </summary>
        public static readonly PipelineExecutionStatus Stopping = new PipelineExecutionStatus("Stopping");
        /// <summary>
        /// Constant Succeeded for PipelineExecutionStatus
        /// </summary>
        public static readonly PipelineExecutionStatus Succeeded = new PipelineExecutionStatus("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipelineExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipelineExecutionStatus FindValue(string value)
        {
            return FindValue<PipelineExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipelineExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipelineStatus.
    /// </summary>
    public class PipelineStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for PipelineStatus
        /// </summary>
        public static readonly PipelineStatus Active = new PipelineStatus("Active");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipelineStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipelineStatus FindValue(string value)
        {
            return FindValue<PipelineStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipelineStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProblemType.
    /// </summary>
    public class ProblemType : ConstantClass
    {

        /// <summary>
        /// Constant BinaryClassification for ProblemType
        /// </summary>
        public static readonly ProblemType BinaryClassification = new ProblemType("BinaryClassification");
        /// <summary>
        /// Constant MulticlassClassification for ProblemType
        /// </summary>
        public static readonly ProblemType MulticlassClassification = new ProblemType("MulticlassClassification");
        /// <summary>
        /// Constant Regression for ProblemType
        /// </summary>
        public static readonly ProblemType Regression = new ProblemType("Regression");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProblemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProblemType FindValue(string value)
        {
            return FindValue<ProblemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProblemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProcessingInstanceType.
    /// </summary>
    public class ProcessingInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC42xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlC42xlarge = new ProcessingInstanceType("ml.c4.2xlarge");
        /// <summary>
        /// Constant MlC44xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlC44xlarge = new ProcessingInstanceType("ml.c4.4xlarge");
        /// <summary>
        /// Constant MlC48xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlC48xlarge = new ProcessingInstanceType("ml.c4.8xlarge");
        /// <summary>
        /// Constant MlC4Xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlC4Xlarge = new ProcessingInstanceType("ml.c4.xlarge");
        /// <summary>
        /// Constant MlC518xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlC518xlarge = new ProcessingInstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC52xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlC52xlarge = new ProcessingInstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlC54xlarge = new ProcessingInstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlC59xlarge = new ProcessingInstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5Xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlC5Xlarge = new ProcessingInstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlG4dn12xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlG4dn12xlarge = new ProcessingInstanceType("ml.g4dn.12xlarge");
        /// <summary>
        /// Constant MlG4dn16xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlG4dn16xlarge = new ProcessingInstanceType("ml.g4dn.16xlarge");
        /// <summary>
        /// Constant MlG4dn2xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlG4dn2xlarge = new ProcessingInstanceType("ml.g4dn.2xlarge");
        /// <summary>
        /// Constant MlG4dn4xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlG4dn4xlarge = new ProcessingInstanceType("ml.g4dn.4xlarge");
        /// <summary>
        /// Constant MlG4dn8xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlG4dn8xlarge = new ProcessingInstanceType("ml.g4dn.8xlarge");
        /// <summary>
        /// Constant MlG4dnXlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlG4dnXlarge = new ProcessingInstanceType("ml.g4dn.xlarge");
        /// <summary>
        /// Constant MlM410xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlM410xlarge = new ProcessingInstanceType("ml.m4.10xlarge");
        /// <summary>
        /// Constant MlM416xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlM416xlarge = new ProcessingInstanceType("ml.m4.16xlarge");
        /// <summary>
        /// Constant MlM42xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlM42xlarge = new ProcessingInstanceType("ml.m4.2xlarge");
        /// <summary>
        /// Constant MlM44xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlM44xlarge = new ProcessingInstanceType("ml.m4.4xlarge");
        /// <summary>
        /// Constant MlM4Xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlM4Xlarge = new ProcessingInstanceType("ml.m4.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlM512xlarge = new ProcessingInstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM524xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlM524xlarge = new ProcessingInstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlM52xlarge = new ProcessingInstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlM54xlarge = new ProcessingInstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM5Large for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlM5Large = new ProcessingInstanceType("ml.m5.large");
        /// <summary>
        /// Constant MlM5Xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlM5Xlarge = new ProcessingInstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlP216xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlP216xlarge = new ProcessingInstanceType("ml.p2.16xlarge");
        /// <summary>
        /// Constant MlP28xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlP28xlarge = new ProcessingInstanceType("ml.p2.8xlarge");
        /// <summary>
        /// Constant MlP2Xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlP2Xlarge = new ProcessingInstanceType("ml.p2.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlP316xlarge = new ProcessingInstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlP32xlarge = new ProcessingInstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlP38xlarge = new ProcessingInstanceType("ml.p3.8xlarge");
        /// <summary>
        /// Constant MlR512xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlR512xlarge = new ProcessingInstanceType("ml.r5.12xlarge");
        /// <summary>
        /// Constant MlR516xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlR516xlarge = new ProcessingInstanceType("ml.r5.16xlarge");
        /// <summary>
        /// Constant MlR524xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlR524xlarge = new ProcessingInstanceType("ml.r5.24xlarge");
        /// <summary>
        /// Constant MlR52xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlR52xlarge = new ProcessingInstanceType("ml.r5.2xlarge");
        /// <summary>
        /// Constant MlR54xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlR54xlarge = new ProcessingInstanceType("ml.r5.4xlarge");
        /// <summary>
        /// Constant MlR58xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlR58xlarge = new ProcessingInstanceType("ml.r5.8xlarge");
        /// <summary>
        /// Constant MlR5Large for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlR5Large = new ProcessingInstanceType("ml.r5.large");
        /// <summary>
        /// Constant MlR5Xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlR5Xlarge = new ProcessingInstanceType("ml.r5.xlarge");
        /// <summary>
        /// Constant MlT32xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlT32xlarge = new ProcessingInstanceType("ml.t3.2xlarge");
        /// <summary>
        /// Constant MlT3Large for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlT3Large = new ProcessingInstanceType("ml.t3.large");
        /// <summary>
        /// Constant MlT3Medium for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlT3Medium = new ProcessingInstanceType("ml.t3.medium");
        /// <summary>
        /// Constant MlT3Xlarge for ProcessingInstanceType
        /// </summary>
        public static readonly ProcessingInstanceType MlT3Xlarge = new ProcessingInstanceType("ml.t3.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcessingInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcessingInstanceType FindValue(string value)
        {
            return FindValue<ProcessingInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcessingInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProcessingJobStatus.
    /// </summary>
    public class ProcessingJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for ProcessingJobStatus
        /// </summary>
        public static readonly ProcessingJobStatus Completed = new ProcessingJobStatus("Completed");
        /// <summary>
        /// Constant Failed for ProcessingJobStatus
        /// </summary>
        public static readonly ProcessingJobStatus Failed = new ProcessingJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for ProcessingJobStatus
        /// </summary>
        public static readonly ProcessingJobStatus InProgress = new ProcessingJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for ProcessingJobStatus
        /// </summary>
        public static readonly ProcessingJobStatus Stopped = new ProcessingJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for ProcessingJobStatus
        /// </summary>
        public static readonly ProcessingJobStatus Stopping = new ProcessingJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcessingJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcessingJobStatus FindValue(string value)
        {
            return FindValue<ProcessingJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcessingJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProcessingS3CompressionType.
    /// </summary>
    public class ProcessingS3CompressionType : ConstantClass
    {

        /// <summary>
        /// Constant Gzip for ProcessingS3CompressionType
        /// </summary>
        public static readonly ProcessingS3CompressionType Gzip = new ProcessingS3CompressionType("Gzip");
        /// <summary>
        /// Constant None for ProcessingS3CompressionType
        /// </summary>
        public static readonly ProcessingS3CompressionType None = new ProcessingS3CompressionType("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcessingS3CompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcessingS3CompressionType FindValue(string value)
        {
            return FindValue<ProcessingS3CompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcessingS3CompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProcessingS3DataDistributionType.
    /// </summary>
    public class ProcessingS3DataDistributionType : ConstantClass
    {

        /// <summary>
        /// Constant FullyReplicated for ProcessingS3DataDistributionType
        /// </summary>
        public static readonly ProcessingS3DataDistributionType FullyReplicated = new ProcessingS3DataDistributionType("FullyReplicated");
        /// <summary>
        /// Constant ShardedByS3Key for ProcessingS3DataDistributionType
        /// </summary>
        public static readonly ProcessingS3DataDistributionType ShardedByS3Key = new ProcessingS3DataDistributionType("ShardedByS3Key");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcessingS3DataDistributionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcessingS3DataDistributionType FindValue(string value)
        {
            return FindValue<ProcessingS3DataDistributionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcessingS3DataDistributionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProcessingS3DataType.
    /// </summary>
    public class ProcessingS3DataType : ConstantClass
    {

        /// <summary>
        /// Constant ManifestFile for ProcessingS3DataType
        /// </summary>
        public static readonly ProcessingS3DataType ManifestFile = new ProcessingS3DataType("ManifestFile");
        /// <summary>
        /// Constant S3Prefix for ProcessingS3DataType
        /// </summary>
        public static readonly ProcessingS3DataType S3Prefix = new ProcessingS3DataType("S3Prefix");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcessingS3DataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcessingS3DataType FindValue(string value)
        {
            return FindValue<ProcessingS3DataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcessingS3DataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProcessingS3InputMode.
    /// </summary>
    public class ProcessingS3InputMode : ConstantClass
    {

        /// <summary>
        /// Constant File for ProcessingS3InputMode
        /// </summary>
        public static readonly ProcessingS3InputMode File = new ProcessingS3InputMode("File");
        /// <summary>
        /// Constant Pipe for ProcessingS3InputMode
        /// </summary>
        public static readonly ProcessingS3InputMode Pipe = new ProcessingS3InputMode("Pipe");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcessingS3InputMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcessingS3InputMode FindValue(string value)
        {
            return FindValue<ProcessingS3InputMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcessingS3InputMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProcessingS3UploadMode.
    /// </summary>
    public class ProcessingS3UploadMode : ConstantClass
    {

        /// <summary>
        /// Constant Continuous for ProcessingS3UploadMode
        /// </summary>
        public static readonly ProcessingS3UploadMode Continuous = new ProcessingS3UploadMode("Continuous");
        /// <summary>
        /// Constant EndOfJob for ProcessingS3UploadMode
        /// </summary>
        public static readonly ProcessingS3UploadMode EndOfJob = new ProcessingS3UploadMode("EndOfJob");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcessingS3UploadMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcessingS3UploadMode FindValue(string value)
        {
            return FindValue<ProcessingS3UploadMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcessingS3UploadMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Processor.
    /// </summary>
    public class Processor : ConstantClass
    {

        /// <summary>
        /// Constant CPU for Processor
        /// </summary>
        public static readonly Processor CPU = new Processor("CPU");
        /// <summary>
        /// Constant GPU for Processor
        /// </summary>
        public static readonly Processor GPU = new Processor("GPU");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Processor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Processor FindValue(string value)
        {
            return FindValue<Processor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Processor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProductionVariantAcceleratorType.
    /// </summary>
    public class ProductionVariantAcceleratorType : ConstantClass
    {

        /// <summary>
        /// Constant MlEia1Large for ProductionVariantAcceleratorType
        /// </summary>
        public static readonly ProductionVariantAcceleratorType MlEia1Large = new ProductionVariantAcceleratorType("ml.eia1.large");
        /// <summary>
        /// Constant MlEia1Medium for ProductionVariantAcceleratorType
        /// </summary>
        public static readonly ProductionVariantAcceleratorType MlEia1Medium = new ProductionVariantAcceleratorType("ml.eia1.medium");
        /// <summary>
        /// Constant MlEia1Xlarge for ProductionVariantAcceleratorType
        /// </summary>
        public static readonly ProductionVariantAcceleratorType MlEia1Xlarge = new ProductionVariantAcceleratorType("ml.eia1.xlarge");
        /// <summary>
        /// Constant MlEia2Large for ProductionVariantAcceleratorType
        /// </summary>
        public static readonly ProductionVariantAcceleratorType MlEia2Large = new ProductionVariantAcceleratorType("ml.eia2.large");
        /// <summary>
        /// Constant MlEia2Medium for ProductionVariantAcceleratorType
        /// </summary>
        public static readonly ProductionVariantAcceleratorType MlEia2Medium = new ProductionVariantAcceleratorType("ml.eia2.medium");
        /// <summary>
        /// Constant MlEia2Xlarge for ProductionVariantAcceleratorType
        /// </summary>
        public static readonly ProductionVariantAcceleratorType MlEia2Xlarge = new ProductionVariantAcceleratorType("ml.eia2.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProductionVariantAcceleratorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductionVariantAcceleratorType FindValue(string value)
        {
            return FindValue<ProductionVariantAcceleratorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductionVariantAcceleratorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProductionVariantInstanceType.
    /// </summary>
    public class ProductionVariantInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC42xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC42xlarge = new ProductionVariantInstanceType("ml.c4.2xlarge");
        /// <summary>
        /// Constant MlC44xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC44xlarge = new ProductionVariantInstanceType("ml.c4.4xlarge");
        /// <summary>
        /// Constant MlC48xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC48xlarge = new ProductionVariantInstanceType("ml.c4.8xlarge");
        /// <summary>
        /// Constant MlC4Large for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC4Large = new ProductionVariantInstanceType("ml.c4.large");
        /// <summary>
        /// Constant MlC4Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC4Xlarge = new ProductionVariantInstanceType("ml.c4.xlarge");
        /// <summary>
        /// Constant MlC518xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC518xlarge = new ProductionVariantInstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC52xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC52xlarge = new ProductionVariantInstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC54xlarge = new ProductionVariantInstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC59xlarge = new ProductionVariantInstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5d18xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC5d18xlarge = new ProductionVariantInstanceType("ml.c5d.18xlarge");
        /// <summary>
        /// Constant MlC5d2xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC5d2xlarge = new ProductionVariantInstanceType("ml.c5d.2xlarge");
        /// <summary>
        /// Constant MlC5d4xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC5d4xlarge = new ProductionVariantInstanceType("ml.c5d.4xlarge");
        /// <summary>
        /// Constant MlC5d9xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC5d9xlarge = new ProductionVariantInstanceType("ml.c5d.9xlarge");
        /// <summary>
        /// Constant MlC5dLarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC5dLarge = new ProductionVariantInstanceType("ml.c5d.large");
        /// <summary>
        /// Constant MlC5dXlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC5dXlarge = new ProductionVariantInstanceType("ml.c5d.xlarge");
        /// <summary>
        /// Constant MlC5Large for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC5Large = new ProductionVariantInstanceType("ml.c5.large");
        /// <summary>
        /// Constant MlC5Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC5Xlarge = new ProductionVariantInstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlC6g12xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6g12xlarge = new ProductionVariantInstanceType("ml.c6g.12xlarge");
        /// <summary>
        /// Constant MlC6g16xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6g16xlarge = new ProductionVariantInstanceType("ml.c6g.16xlarge");
        /// <summary>
        /// Constant MlC6g2xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6g2xlarge = new ProductionVariantInstanceType("ml.c6g.2xlarge");
        /// <summary>
        /// Constant MlC6g4xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6g4xlarge = new ProductionVariantInstanceType("ml.c6g.4xlarge");
        /// <summary>
        /// Constant MlC6g8xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6g8xlarge = new ProductionVariantInstanceType("ml.c6g.8xlarge");
        /// <summary>
        /// Constant MlC6gd12xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gd12xlarge = new ProductionVariantInstanceType("ml.c6gd.12xlarge");
        /// <summary>
        /// Constant MlC6gd16xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gd16xlarge = new ProductionVariantInstanceType("ml.c6gd.16xlarge");
        /// <summary>
        /// Constant MlC6gd2xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gd2xlarge = new ProductionVariantInstanceType("ml.c6gd.2xlarge");
        /// <summary>
        /// Constant MlC6gd4xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gd4xlarge = new ProductionVariantInstanceType("ml.c6gd.4xlarge");
        /// <summary>
        /// Constant MlC6gd8xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gd8xlarge = new ProductionVariantInstanceType("ml.c6gd.8xlarge");
        /// <summary>
        /// Constant MlC6gdLarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gdLarge = new ProductionVariantInstanceType("ml.c6gd.large");
        /// <summary>
        /// Constant MlC6gdXlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gdXlarge = new ProductionVariantInstanceType("ml.c6gd.xlarge");
        /// <summary>
        /// Constant MlC6gLarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gLarge = new ProductionVariantInstanceType("ml.c6g.large");
        /// <summary>
        /// Constant MlC6gn12xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gn12xlarge = new ProductionVariantInstanceType("ml.c6gn.12xlarge");
        /// <summary>
        /// Constant MlC6gn16xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gn16xlarge = new ProductionVariantInstanceType("ml.c6gn.16xlarge");
        /// <summary>
        /// Constant MlC6gn2xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gn2xlarge = new ProductionVariantInstanceType("ml.c6gn.2xlarge");
        /// <summary>
        /// Constant MlC6gn4xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gn4xlarge = new ProductionVariantInstanceType("ml.c6gn.4xlarge");
        /// <summary>
        /// Constant MlC6gn8xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gn8xlarge = new ProductionVariantInstanceType("ml.c6gn.8xlarge");
        /// <summary>
        /// Constant MlC6gnLarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gnLarge = new ProductionVariantInstanceType("ml.c6gn.large");
        /// <summary>
        /// Constant MlC6gnXlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gnXlarge = new ProductionVariantInstanceType("ml.c6gn.xlarge");
        /// <summary>
        /// Constant MlC6gXlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6gXlarge = new ProductionVariantInstanceType("ml.c6g.xlarge");
        /// <summary>
        /// Constant MlC6i12xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6i12xlarge = new ProductionVariantInstanceType("ml.c6i.12xlarge");
        /// <summary>
        /// Constant MlC6i16xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6i16xlarge = new ProductionVariantInstanceType("ml.c6i.16xlarge");
        /// <summary>
        /// Constant MlC6i24xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6i24xlarge = new ProductionVariantInstanceType("ml.c6i.24xlarge");
        /// <summary>
        /// Constant MlC6i2xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6i2xlarge = new ProductionVariantInstanceType("ml.c6i.2xlarge");
        /// <summary>
        /// Constant MlC6i32xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6i32xlarge = new ProductionVariantInstanceType("ml.c6i.32xlarge");
        /// <summary>
        /// Constant MlC6i4xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6i4xlarge = new ProductionVariantInstanceType("ml.c6i.4xlarge");
        /// <summary>
        /// Constant MlC6i8xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6i8xlarge = new ProductionVariantInstanceType("ml.c6i.8xlarge");
        /// <summary>
        /// Constant MlC6iLarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6iLarge = new ProductionVariantInstanceType("ml.c6i.large");
        /// <summary>
        /// Constant MlC6iXlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC6iXlarge = new ProductionVariantInstanceType("ml.c6i.xlarge");
        /// <summary>
        /// Constant MlC7g12xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC7g12xlarge = new ProductionVariantInstanceType("ml.c7g.12xlarge");
        /// <summary>
        /// Constant MlC7g16xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC7g16xlarge = new ProductionVariantInstanceType("ml.c7g.16xlarge");
        /// <summary>
        /// Constant MlC7g2xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC7g2xlarge = new ProductionVariantInstanceType("ml.c7g.2xlarge");
        /// <summary>
        /// Constant MlC7g4xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC7g4xlarge = new ProductionVariantInstanceType("ml.c7g.4xlarge");
        /// <summary>
        /// Constant MlC7g8xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC7g8xlarge = new ProductionVariantInstanceType("ml.c7g.8xlarge");
        /// <summary>
        /// Constant MlC7gLarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC7gLarge = new ProductionVariantInstanceType("ml.c7g.large");
        /// <summary>
        /// Constant MlC7gXlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC7gXlarge = new ProductionVariantInstanceType("ml.c7g.xlarge");
        /// <summary>
        /// Constant MlG4dn12xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG4dn12xlarge = new ProductionVariantInstanceType("ml.g4dn.12xlarge");
        /// <summary>
        /// Constant MlG4dn16xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG4dn16xlarge = new ProductionVariantInstanceType("ml.g4dn.16xlarge");
        /// <summary>
        /// Constant MlG4dn2xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG4dn2xlarge = new ProductionVariantInstanceType("ml.g4dn.2xlarge");
        /// <summary>
        /// Constant MlG4dn4xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG4dn4xlarge = new ProductionVariantInstanceType("ml.g4dn.4xlarge");
        /// <summary>
        /// Constant MlG4dn8xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG4dn8xlarge = new ProductionVariantInstanceType("ml.g4dn.8xlarge");
        /// <summary>
        /// Constant MlG4dnXlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG4dnXlarge = new ProductionVariantInstanceType("ml.g4dn.xlarge");
        /// <summary>
        /// Constant MlG512xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG512xlarge = new ProductionVariantInstanceType("ml.g5.12xlarge");
        /// <summary>
        /// Constant MlG516xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG516xlarge = new ProductionVariantInstanceType("ml.g5.16xlarge");
        /// <summary>
        /// Constant MlG524xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG524xlarge = new ProductionVariantInstanceType("ml.g5.24xlarge");
        /// <summary>
        /// Constant MlG52xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG52xlarge = new ProductionVariantInstanceType("ml.g5.2xlarge");
        /// <summary>
        /// Constant MlG548xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG548xlarge = new ProductionVariantInstanceType("ml.g5.48xlarge");
        /// <summary>
        /// Constant MlG54xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG54xlarge = new ProductionVariantInstanceType("ml.g5.4xlarge");
        /// <summary>
        /// Constant MlG58xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG58xlarge = new ProductionVariantInstanceType("ml.g5.8xlarge");
        /// <summary>
        /// Constant MlG5Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG5Xlarge = new ProductionVariantInstanceType("ml.g5.xlarge");
        /// <summary>
        /// Constant MlInf124xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlInf124xlarge = new ProductionVariantInstanceType("ml.inf1.24xlarge");
        /// <summary>
        /// Constant MlInf12xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlInf12xlarge = new ProductionVariantInstanceType("ml.inf1.2xlarge");
        /// <summary>
        /// Constant MlInf16xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlInf16xlarge = new ProductionVariantInstanceType("ml.inf1.6xlarge");
        /// <summary>
        /// Constant MlInf1Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlInf1Xlarge = new ProductionVariantInstanceType("ml.inf1.xlarge");
        /// <summary>
        /// Constant MlM410xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM410xlarge = new ProductionVariantInstanceType("ml.m4.10xlarge");
        /// <summary>
        /// Constant MlM416xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM416xlarge = new ProductionVariantInstanceType("ml.m4.16xlarge");
        /// <summary>
        /// Constant MlM42xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM42xlarge = new ProductionVariantInstanceType("ml.m4.2xlarge");
        /// <summary>
        /// Constant MlM44xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM44xlarge = new ProductionVariantInstanceType("ml.m4.4xlarge");
        /// <summary>
        /// Constant MlM4Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM4Xlarge = new ProductionVariantInstanceType("ml.m4.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM512xlarge = new ProductionVariantInstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM524xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM524xlarge = new ProductionVariantInstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM52xlarge = new ProductionVariantInstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM54xlarge = new ProductionVariantInstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM5d12xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM5d12xlarge = new ProductionVariantInstanceType("ml.m5d.12xlarge");
        /// <summary>
        /// Constant MlM5d24xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM5d24xlarge = new ProductionVariantInstanceType("ml.m5d.24xlarge");
        /// <summary>
        /// Constant MlM5d2xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM5d2xlarge = new ProductionVariantInstanceType("ml.m5d.2xlarge");
        /// <summary>
        /// Constant MlM5d4xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM5d4xlarge = new ProductionVariantInstanceType("ml.m5d.4xlarge");
        /// <summary>
        /// Constant MlM5dLarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM5dLarge = new ProductionVariantInstanceType("ml.m5d.large");
        /// <summary>
        /// Constant MlM5dXlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM5dXlarge = new ProductionVariantInstanceType("ml.m5d.xlarge");
        /// <summary>
        /// Constant MlM5Large for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM5Large = new ProductionVariantInstanceType("ml.m5.large");
        /// <summary>
        /// Constant MlM5Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM5Xlarge = new ProductionVariantInstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlM6g12xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM6g12xlarge = new ProductionVariantInstanceType("ml.m6g.12xlarge");
        /// <summary>
        /// Constant MlM6g16xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM6g16xlarge = new ProductionVariantInstanceType("ml.m6g.16xlarge");
        /// <summary>
        /// Constant MlM6g2xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM6g2xlarge = new ProductionVariantInstanceType("ml.m6g.2xlarge");
        /// <summary>
        /// Constant MlM6g4xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM6g4xlarge = new ProductionVariantInstanceType("ml.m6g.4xlarge");
        /// <summary>
        /// Constant MlM6g8xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM6g8xlarge = new ProductionVariantInstanceType("ml.m6g.8xlarge");
        /// <summary>
        /// Constant MlM6gd12xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM6gd12xlarge = new ProductionVariantInstanceType("ml.m6gd.12xlarge");
        /// <summary>
        /// Constant MlM6gd16xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM6gd16xlarge = new ProductionVariantInstanceType("ml.m6gd.16xlarge");
        /// <summary>
        /// Constant MlM6gd2xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM6gd2xlarge = new ProductionVariantInstanceType("ml.m6gd.2xlarge");
        /// <summary>
        /// Constant MlM6gd4xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM6gd4xlarge = new ProductionVariantInstanceType("ml.m6gd.4xlarge");
        /// <summary>
        /// Constant MlM6gd8xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM6gd8xlarge = new ProductionVariantInstanceType("ml.m6gd.8xlarge");
        /// <summary>
        /// Constant MlM6gdLarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM6gdLarge = new ProductionVariantInstanceType("ml.m6gd.large");
        /// <summary>
        /// Constant MlM6gdXlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM6gdXlarge = new ProductionVariantInstanceType("ml.m6gd.xlarge");
        /// <summary>
        /// Constant MlM6gLarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM6gLarge = new ProductionVariantInstanceType("ml.m6g.large");
        /// <summary>
        /// Constant MlM6gXlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM6gXlarge = new ProductionVariantInstanceType("ml.m6g.xlarge");
        /// <summary>
        /// Constant MlP216xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP216xlarge = new ProductionVariantInstanceType("ml.p2.16xlarge");
        /// <summary>
        /// Constant MlP28xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP28xlarge = new ProductionVariantInstanceType("ml.p2.8xlarge");
        /// <summary>
        /// Constant MlP2Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP2Xlarge = new ProductionVariantInstanceType("ml.p2.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP316xlarge = new ProductionVariantInstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP32xlarge = new ProductionVariantInstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP38xlarge = new ProductionVariantInstanceType("ml.p3.8xlarge");
        /// <summary>
        /// Constant MlP4d24xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP4d24xlarge = new ProductionVariantInstanceType("ml.p4d.24xlarge");
        /// <summary>
        /// Constant MlP4de24xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP4de24xlarge = new ProductionVariantInstanceType("ml.p4de.24xlarge");
        /// <summary>
        /// Constant MlR512xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR512xlarge = new ProductionVariantInstanceType("ml.r5.12xlarge");
        /// <summary>
        /// Constant MlR524xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR524xlarge = new ProductionVariantInstanceType("ml.r5.24xlarge");
        /// <summary>
        /// Constant MlR52xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR52xlarge = new ProductionVariantInstanceType("ml.r5.2xlarge");
        /// <summary>
        /// Constant MlR54xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR54xlarge = new ProductionVariantInstanceType("ml.r5.4xlarge");
        /// <summary>
        /// Constant MlR5d12xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR5d12xlarge = new ProductionVariantInstanceType("ml.r5d.12xlarge");
        /// <summary>
        /// Constant MlR5d24xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR5d24xlarge = new ProductionVariantInstanceType("ml.r5d.24xlarge");
        /// <summary>
        /// Constant MlR5d2xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR5d2xlarge = new ProductionVariantInstanceType("ml.r5d.2xlarge");
        /// <summary>
        /// Constant MlR5d4xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR5d4xlarge = new ProductionVariantInstanceType("ml.r5d.4xlarge");
        /// <summary>
        /// Constant MlR5dLarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR5dLarge = new ProductionVariantInstanceType("ml.r5d.large");
        /// <summary>
        /// Constant MlR5dXlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR5dXlarge = new ProductionVariantInstanceType("ml.r5d.xlarge");
        /// <summary>
        /// Constant MlR5Large for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR5Large = new ProductionVariantInstanceType("ml.r5.large");
        /// <summary>
        /// Constant MlR5Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR5Xlarge = new ProductionVariantInstanceType("ml.r5.xlarge");
        /// <summary>
        /// Constant MlR6g12xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR6g12xlarge = new ProductionVariantInstanceType("ml.r6g.12xlarge");
        /// <summary>
        /// Constant MlR6g16xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR6g16xlarge = new ProductionVariantInstanceType("ml.r6g.16xlarge");
        /// <summary>
        /// Constant MlR6g2xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR6g2xlarge = new ProductionVariantInstanceType("ml.r6g.2xlarge");
        /// <summary>
        /// Constant MlR6g4xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR6g4xlarge = new ProductionVariantInstanceType("ml.r6g.4xlarge");
        /// <summary>
        /// Constant MlR6g8xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR6g8xlarge = new ProductionVariantInstanceType("ml.r6g.8xlarge");
        /// <summary>
        /// Constant MlR6gd12xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR6gd12xlarge = new ProductionVariantInstanceType("ml.r6gd.12xlarge");
        /// <summary>
        /// Constant MlR6gd16xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR6gd16xlarge = new ProductionVariantInstanceType("ml.r6gd.16xlarge");
        /// <summary>
        /// Constant MlR6gd2xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR6gd2xlarge = new ProductionVariantInstanceType("ml.r6gd.2xlarge");
        /// <summary>
        /// Constant MlR6gd4xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR6gd4xlarge = new ProductionVariantInstanceType("ml.r6gd.4xlarge");
        /// <summary>
        /// Constant MlR6gd8xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR6gd8xlarge = new ProductionVariantInstanceType("ml.r6gd.8xlarge");
        /// <summary>
        /// Constant MlR6gdLarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR6gdLarge = new ProductionVariantInstanceType("ml.r6gd.large");
        /// <summary>
        /// Constant MlR6gdXlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR6gdXlarge = new ProductionVariantInstanceType("ml.r6gd.xlarge");
        /// <summary>
        /// Constant MlR6gLarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR6gLarge = new ProductionVariantInstanceType("ml.r6g.large");
        /// <summary>
        /// Constant MlR6gXlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR6gXlarge = new ProductionVariantInstanceType("ml.r6g.xlarge");
        /// <summary>
        /// Constant MlT22xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlT22xlarge = new ProductionVariantInstanceType("ml.t2.2xlarge");
        /// <summary>
        /// Constant MlT2Large for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlT2Large = new ProductionVariantInstanceType("ml.t2.large");
        /// <summary>
        /// Constant MlT2Medium for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlT2Medium = new ProductionVariantInstanceType("ml.t2.medium");
        /// <summary>
        /// Constant MlT2Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlT2Xlarge = new ProductionVariantInstanceType("ml.t2.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProductionVariantInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductionVariantInstanceType FindValue(string value)
        {
            return FindValue<ProductionVariantInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductionVariantInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProfilingStatus.
    /// </summary>
    public class ProfilingStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ProfilingStatus
        /// </summary>
        public static readonly ProfilingStatus Disabled = new ProfilingStatus("Disabled");
        /// <summary>
        /// Constant Enabled for ProfilingStatus
        /// </summary>
        public static readonly ProfilingStatus Enabled = new ProfilingStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfilingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfilingStatus FindValue(string value)
        {
            return FindValue<ProfilingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfilingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProjectSortBy.
    /// </summary>
    public class ProjectSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for ProjectSortBy
        /// </summary>
        public static readonly ProjectSortBy CreationTime = new ProjectSortBy("CreationTime");
        /// <summary>
        /// Constant Name for ProjectSortBy
        /// </summary>
        public static readonly ProjectSortBy Name = new ProjectSortBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProjectSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProjectSortBy FindValue(string value)
        {
            return FindValue<ProjectSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProjectSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProjectSortOrder.
    /// </summary>
    public class ProjectSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for ProjectSortOrder
        /// </summary>
        public static readonly ProjectSortOrder Ascending = new ProjectSortOrder("Ascending");
        /// <summary>
        /// Constant Descending for ProjectSortOrder
        /// </summary>
        public static readonly ProjectSortOrder Descending = new ProjectSortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProjectSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProjectSortOrder FindValue(string value)
        {
            return FindValue<ProjectSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProjectSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProjectStatus.
    /// </summary>
    public class ProjectStatus : ConstantClass
    {

        /// <summary>
        /// Constant CreateCompleted for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus CreateCompleted = new ProjectStatus("CreateCompleted");
        /// <summary>
        /// Constant CreateFailed for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus CreateFailed = new ProjectStatus("CreateFailed");
        /// <summary>
        /// Constant CreateInProgress for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus CreateInProgress = new ProjectStatus("CreateInProgress");
        /// <summary>
        /// Constant DeleteCompleted for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus DeleteCompleted = new ProjectStatus("DeleteCompleted");
        /// <summary>
        /// Constant DeleteFailed for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus DeleteFailed = new ProjectStatus("DeleteFailed");
        /// <summary>
        /// Constant DeleteInProgress for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus DeleteInProgress = new ProjectStatus("DeleteInProgress");
        /// <summary>
        /// Constant Pending for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus Pending = new ProjectStatus("Pending");
        /// <summary>
        /// Constant UpdateCompleted for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus UpdateCompleted = new ProjectStatus("UpdateCompleted");
        /// <summary>
        /// Constant UpdateFailed for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus UpdateFailed = new ProjectStatus("UpdateFailed");
        /// <summary>
        /// Constant UpdateInProgress for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus UpdateInProgress = new ProjectStatus("UpdateInProgress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProjectStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProjectStatus FindValue(string value)
        {
            return FindValue<ProjectStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProjectStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationJobStatus.
    /// </summary>
    public class RecommendationJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for RecommendationJobStatus
        /// </summary>
        public static readonly RecommendationJobStatus COMPLETED = new RecommendationJobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for RecommendationJobStatus
        /// </summary>
        public static readonly RecommendationJobStatus FAILED = new RecommendationJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for RecommendationJobStatus
        /// </summary>
        public static readonly RecommendationJobStatus IN_PROGRESS = new RecommendationJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for RecommendationJobStatus
        /// </summary>
        public static readonly RecommendationJobStatus PENDING = new RecommendationJobStatus("PENDING");
        /// <summary>
        /// Constant STOPPED for RecommendationJobStatus
        /// </summary>
        public static readonly RecommendationJobStatus STOPPED = new RecommendationJobStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for RecommendationJobStatus
        /// </summary>
        public static readonly RecommendationJobStatus STOPPING = new RecommendationJobStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationJobStatus FindValue(string value)
        {
            return FindValue<RecommendationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationJobType.
    /// </summary>
    public class RecommendationJobType : ConstantClass
    {

        /// <summary>
        /// Constant Advanced for RecommendationJobType
        /// </summary>
        public static readonly RecommendationJobType Advanced = new RecommendationJobType("Advanced");
        /// <summary>
        /// Constant Default for RecommendationJobType
        /// </summary>
        public static readonly RecommendationJobType Default = new RecommendationJobType("Default");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationJobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationJobType FindValue(string value)
        {
            return FindValue<RecommendationJobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationJobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationStepType.
    /// </summary>
    public class RecommendationStepType : ConstantClass
    {

        /// <summary>
        /// Constant BENCHMARK for RecommendationStepType
        /// </summary>
        public static readonly RecommendationStepType BENCHMARK = new RecommendationStepType("BENCHMARK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationStepType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationStepType FindValue(string value)
        {
            return FindValue<RecommendationStepType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationStepType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordWrapper.
    /// </summary>
    public class RecordWrapper : ConstantClass
    {

        /// <summary>
        /// Constant None for RecordWrapper
        /// </summary>
        public static readonly RecordWrapper None = new RecordWrapper("None");
        /// <summary>
        /// Constant RecordIO for RecordWrapper
        /// </summary>
        public static readonly RecordWrapper RecordIO = new RecordWrapper("RecordIO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordWrapper(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordWrapper FindValue(string value)
        {
            return FindValue<RecordWrapper>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordWrapper(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RedshiftResultCompressionType.
    /// </summary>
    public class RedshiftResultCompressionType : ConstantClass
    {

        /// <summary>
        /// Constant BZIP2 for RedshiftResultCompressionType
        /// </summary>
        public static readonly RedshiftResultCompressionType BZIP2 = new RedshiftResultCompressionType("BZIP2");
        /// <summary>
        /// Constant GZIP for RedshiftResultCompressionType
        /// </summary>
        public static readonly RedshiftResultCompressionType GZIP = new RedshiftResultCompressionType("GZIP");
        /// <summary>
        /// Constant None for RedshiftResultCompressionType
        /// </summary>
        public static readonly RedshiftResultCompressionType None = new RedshiftResultCompressionType("None");
        /// <summary>
        /// Constant SNAPPY for RedshiftResultCompressionType
        /// </summary>
        public static readonly RedshiftResultCompressionType SNAPPY = new RedshiftResultCompressionType("SNAPPY");
        /// <summary>
        /// Constant ZSTD for RedshiftResultCompressionType
        /// </summary>
        public static readonly RedshiftResultCompressionType ZSTD = new RedshiftResultCompressionType("ZSTD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RedshiftResultCompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RedshiftResultCompressionType FindValue(string value)
        {
            return FindValue<RedshiftResultCompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RedshiftResultCompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RedshiftResultFormat.
    /// </summary>
    public class RedshiftResultFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for RedshiftResultFormat
        /// </summary>
        public static readonly RedshiftResultFormat CSV = new RedshiftResultFormat("CSV");
        /// <summary>
        /// Constant PARQUET for RedshiftResultFormat
        /// </summary>
        public static readonly RedshiftResultFormat PARQUET = new RedshiftResultFormat("PARQUET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RedshiftResultFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RedshiftResultFormat FindValue(string value)
        {
            return FindValue<RedshiftResultFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RedshiftResultFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RepositoryAccessMode.
    /// </summary>
    public class RepositoryAccessMode : ConstantClass
    {

        /// <summary>
        /// Constant Platform for RepositoryAccessMode
        /// </summary>
        public static readonly RepositoryAccessMode Platform = new RepositoryAccessMode("Platform");
        /// <summary>
        /// Constant Vpc for RepositoryAccessMode
        /// </summary>
        public static readonly RepositoryAccessMode Vpc = new RepositoryAccessMode("Vpc");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RepositoryAccessMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RepositoryAccessMode FindValue(string value)
        {
            return FindValue<RepositoryAccessMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RepositoryAccessMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant Endpoint for ResourceType
        /// </summary>
        public static readonly ResourceType Endpoint = new ResourceType("Endpoint");
        /// <summary>
        /// Constant Experiment for ResourceType
        /// </summary>
        public static readonly ResourceType Experiment = new ResourceType("Experiment");
        /// <summary>
        /// Constant ExperimentTrial for ResourceType
        /// </summary>
        public static readonly ResourceType ExperimentTrial = new ResourceType("ExperimentTrial");
        /// <summary>
        /// Constant ExperimentTrialComponent for ResourceType
        /// </summary>
        public static readonly ResourceType ExperimentTrialComponent = new ResourceType("ExperimentTrialComponent");
        /// <summary>
        /// Constant FeatureGroup for ResourceType
        /// </summary>
        public static readonly ResourceType FeatureGroup = new ResourceType("FeatureGroup");
        /// <summary>
        /// Constant FeatureMetadata for ResourceType
        /// </summary>
        public static readonly ResourceType FeatureMetadata = new ResourceType("FeatureMetadata");
        /// <summary>
        /// Constant HyperParameterTuningJob for ResourceType
        /// </summary>
        public static readonly ResourceType HyperParameterTuningJob = new ResourceType("HyperParameterTuningJob");
        /// <summary>
        /// Constant Model for ResourceType
        /// </summary>
        public static readonly ResourceType Model = new ResourceType("Model");
        /// <summary>
        /// Constant ModelCard for ResourceType
        /// </summary>
        public static readonly ResourceType ModelCard = new ResourceType("ModelCard");
        /// <summary>
        /// Constant ModelPackage for ResourceType
        /// </summary>
        public static readonly ResourceType ModelPackage = new ResourceType("ModelPackage");
        /// <summary>
        /// Constant ModelPackageGroup for ResourceType
        /// </summary>
        public static readonly ResourceType ModelPackageGroup = new ResourceType("ModelPackageGroup");
        /// <summary>
        /// Constant Pipeline for ResourceType
        /// </summary>
        public static readonly ResourceType Pipeline = new ResourceType("Pipeline");
        /// <summary>
        /// Constant PipelineExecution for ResourceType
        /// </summary>
        public static readonly ResourceType PipelineExecution = new ResourceType("PipelineExecution");
        /// <summary>
        /// Constant Project for ResourceType
        /// </summary>
        public static readonly ResourceType Project = new ResourceType("Project");
        /// <summary>
        /// Constant TrainingJob for ResourceType
        /// </summary>
        public static readonly ResourceType TrainingJob = new ResourceType("TrainingJob");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetentionType.
    /// </summary>
    public class RetentionType : ConstantClass
    {

        /// <summary>
        /// Constant Delete for RetentionType
        /// </summary>
        public static readonly RetentionType Delete = new RetentionType("Delete");
        /// <summary>
        /// Constant Retain for RetentionType
        /// </summary>
        public static readonly RetentionType Retain = new RetentionType("Retain");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetentionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetentionType FindValue(string value)
        {
            return FindValue<RetentionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetentionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RootAccess.
    /// </summary>
    public class RootAccess : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for RootAccess
        /// </summary>
        public static readonly RootAccess Disabled = new RootAccess("Disabled");
        /// <summary>
        /// Constant Enabled for RootAccess
        /// </summary>
        public static readonly RootAccess Enabled = new RootAccess("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RootAccess(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RootAccess FindValue(string value)
        {
            return FindValue<RootAccess>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RootAccess(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RStudioServerProAccessStatus.
    /// </summary>
    public class RStudioServerProAccessStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for RStudioServerProAccessStatus
        /// </summary>
        public static readonly RStudioServerProAccessStatus DISABLED = new RStudioServerProAccessStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for RStudioServerProAccessStatus
        /// </summary>
        public static readonly RStudioServerProAccessStatus ENABLED = new RStudioServerProAccessStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RStudioServerProAccessStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RStudioServerProAccessStatus FindValue(string value)
        {
            return FindValue<RStudioServerProAccessStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RStudioServerProAccessStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RStudioServerProUserGroup.
    /// </summary>
    public class RStudioServerProUserGroup : ConstantClass
    {

        /// <summary>
        /// Constant R_STUDIO_ADMIN for RStudioServerProUserGroup
        /// </summary>
        public static readonly RStudioServerProUserGroup R_STUDIO_ADMIN = new RStudioServerProUserGroup("R_STUDIO_ADMIN");
        /// <summary>
        /// Constant R_STUDIO_USER for RStudioServerProUserGroup
        /// </summary>
        public static readonly RStudioServerProUserGroup R_STUDIO_USER = new RStudioServerProUserGroup("R_STUDIO_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RStudioServerProUserGroup(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RStudioServerProUserGroup FindValue(string value)
        {
            return FindValue<RStudioServerProUserGroup>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RStudioServerProUserGroup(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleEvaluationStatus.
    /// </summary>
    public class RuleEvaluationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Error for RuleEvaluationStatus
        /// </summary>
        public static readonly RuleEvaluationStatus Error = new RuleEvaluationStatus("Error");
        /// <summary>
        /// Constant InProgress for RuleEvaluationStatus
        /// </summary>
        public static readonly RuleEvaluationStatus InProgress = new RuleEvaluationStatus("InProgress");
        /// <summary>
        /// Constant IssuesFound for RuleEvaluationStatus
        /// </summary>
        public static readonly RuleEvaluationStatus IssuesFound = new RuleEvaluationStatus("IssuesFound");
        /// <summary>
        /// Constant NoIssuesFound for RuleEvaluationStatus
        /// </summary>
        public static readonly RuleEvaluationStatus NoIssuesFound = new RuleEvaluationStatus("NoIssuesFound");
        /// <summary>
        /// Constant Stopped for RuleEvaluationStatus
        /// </summary>
        public static readonly RuleEvaluationStatus Stopped = new RuleEvaluationStatus("Stopped");
        /// <summary>
        /// Constant Stopping for RuleEvaluationStatus
        /// </summary>
        public static readonly RuleEvaluationStatus Stopping = new RuleEvaluationStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleEvaluationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleEvaluationStatus FindValue(string value)
        {
            return FindValue<RuleEvaluationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleEvaluationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3DataDistribution.
    /// </summary>
    public class S3DataDistribution : ConstantClass
    {

        /// <summary>
        /// Constant FullyReplicated for S3DataDistribution
        /// </summary>
        public static readonly S3DataDistribution FullyReplicated = new S3DataDistribution("FullyReplicated");
        /// <summary>
        /// Constant ShardedByS3Key for S3DataDistribution
        /// </summary>
        public static readonly S3DataDistribution ShardedByS3Key = new S3DataDistribution("ShardedByS3Key");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3DataDistribution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3DataDistribution FindValue(string value)
        {
            return FindValue<S3DataDistribution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3DataDistribution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3DataType.
    /// </summary>
    public class S3DataType : ConstantClass
    {

        /// <summary>
        /// Constant AugmentedManifestFile for S3DataType
        /// </summary>
        public static readonly S3DataType AugmentedManifestFile = new S3DataType("AugmentedManifestFile");
        /// <summary>
        /// Constant ManifestFile for S3DataType
        /// </summary>
        public static readonly S3DataType ManifestFile = new S3DataType("ManifestFile");
        /// <summary>
        /// Constant S3Prefix for S3DataType
        /// </summary>
        public static readonly S3DataType S3Prefix = new S3DataType("S3Prefix");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3DataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3DataType FindValue(string value)
        {
            return FindValue<S3DataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3DataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SagemakerServicecatalogStatus.
    /// </summary>
    public class SagemakerServicecatalogStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for SagemakerServicecatalogStatus
        /// </summary>
        public static readonly SagemakerServicecatalogStatus Disabled = new SagemakerServicecatalogStatus("Disabled");
        /// <summary>
        /// Constant Enabled for SagemakerServicecatalogStatus
        /// </summary>
        public static readonly SagemakerServicecatalogStatus Enabled = new SagemakerServicecatalogStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SagemakerServicecatalogStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SagemakerServicecatalogStatus FindValue(string value)
        {
            return FindValue<SagemakerServicecatalogStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SagemakerServicecatalogStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScheduleStatus.
    /// </summary>
    public class ScheduleStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for ScheduleStatus
        /// </summary>
        public static readonly ScheduleStatus Failed = new ScheduleStatus("Failed");
        /// <summary>
        /// Constant Pending for ScheduleStatus
        /// </summary>
        public static readonly ScheduleStatus Pending = new ScheduleStatus("Pending");
        /// <summary>
        /// Constant Scheduled for ScheduleStatus
        /// </summary>
        public static readonly ScheduleStatus Scheduled = new ScheduleStatus("Scheduled");
        /// <summary>
        /// Constant Stopped for ScheduleStatus
        /// </summary>
        public static readonly ScheduleStatus Stopped = new ScheduleStatus("Stopped");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduleStatus FindValue(string value)
        {
            return FindValue<ScheduleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchSortOrder.
    /// </summary>
    public class SearchSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for SearchSortOrder
        /// </summary>
        public static readonly SearchSortOrder Ascending = new SearchSortOrder("Ascending");
        /// <summary>
        /// Constant Descending for SearchSortOrder
        /// </summary>
        public static readonly SearchSortOrder Descending = new SearchSortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchSortOrder FindValue(string value)
        {
            return FindValue<SearchSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SecondaryStatus.
    /// </summary>
    public class SecondaryStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Completed = new SecondaryStatus("Completed");
        /// <summary>
        /// Constant Downloading for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Downloading = new SecondaryStatus("Downloading");
        /// <summary>
        /// Constant DownloadingTrainingImage for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus DownloadingTrainingImage = new SecondaryStatus("DownloadingTrainingImage");
        /// <summary>
        /// Constant Failed for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Failed = new SecondaryStatus("Failed");
        /// <summary>
        /// Constant Interrupted for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Interrupted = new SecondaryStatus("Interrupted");
        /// <summary>
        /// Constant LaunchingMLInstances for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus LaunchingMLInstances = new SecondaryStatus("LaunchingMLInstances");
        /// <summary>
        /// Constant MaxRuntimeExceeded for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus MaxRuntimeExceeded = new SecondaryStatus("MaxRuntimeExceeded");
        /// <summary>
        /// Constant MaxWaitTimeExceeded for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus MaxWaitTimeExceeded = new SecondaryStatus("MaxWaitTimeExceeded");
        /// <summary>
        /// Constant PreparingTrainingStack for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus PreparingTrainingStack = new SecondaryStatus("PreparingTrainingStack");
        /// <summary>
        /// Constant Restarting for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Restarting = new SecondaryStatus("Restarting");
        /// <summary>
        /// Constant Starting for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Starting = new SecondaryStatus("Starting");
        /// <summary>
        /// Constant Stopped for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Stopped = new SecondaryStatus("Stopped");
        /// <summary>
        /// Constant Stopping for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Stopping = new SecondaryStatus("Stopping");
        /// <summary>
        /// Constant Training for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Training = new SecondaryStatus("Training");
        /// <summary>
        /// Constant Updating for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Updating = new SecondaryStatus("Updating");
        /// <summary>
        /// Constant Uploading for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Uploading = new SecondaryStatus("Uploading");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SecondaryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecondaryStatus FindValue(string value)
        {
            return FindValue<SecondaryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecondaryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortActionsBy.
    /// </summary>
    public class SortActionsBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortActionsBy
        /// </summary>
        public static readonly SortActionsBy CreationTime = new SortActionsBy("CreationTime");
        /// <summary>
        /// Constant Name for SortActionsBy
        /// </summary>
        public static readonly SortActionsBy Name = new SortActionsBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortActionsBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortActionsBy FindValue(string value)
        {
            return FindValue<SortActionsBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortActionsBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortArtifactsBy.
    /// </summary>
    public class SortArtifactsBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortArtifactsBy
        /// </summary>
        public static readonly SortArtifactsBy CreationTime = new SortArtifactsBy("CreationTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortArtifactsBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortArtifactsBy FindValue(string value)
        {
            return FindValue<SortArtifactsBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortArtifactsBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortAssociationsBy.
    /// </summary>
    public class SortAssociationsBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortAssociationsBy
        /// </summary>
        public static readonly SortAssociationsBy CreationTime = new SortAssociationsBy("CreationTime");
        /// <summary>
        /// Constant DestinationArn for SortAssociationsBy
        /// </summary>
        public static readonly SortAssociationsBy DestinationArn = new SortAssociationsBy("DestinationArn");
        /// <summary>
        /// Constant DestinationType for SortAssociationsBy
        /// </summary>
        public static readonly SortAssociationsBy DestinationType = new SortAssociationsBy("DestinationType");
        /// <summary>
        /// Constant SourceArn for SortAssociationsBy
        /// </summary>
        public static readonly SortAssociationsBy SourceArn = new SortAssociationsBy("SourceArn");
        /// <summary>
        /// Constant SourceType for SortAssociationsBy
        /// </summary>
        public static readonly SortAssociationsBy SourceType = new SortAssociationsBy("SourceType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortAssociationsBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortAssociationsBy FindValue(string value)
        {
            return FindValue<SortAssociationsBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortAssociationsBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortBy.
    /// </summary>
    public class SortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortBy
        /// </summary>
        public static readonly SortBy CreationTime = new SortBy("CreationTime");
        /// <summary>
        /// Constant Name for SortBy
        /// </summary>
        public static readonly SortBy Name = new SortBy("Name");
        /// <summary>
        /// Constant Status for SortBy
        /// </summary>
        public static readonly SortBy Status = new SortBy("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortBy FindValue(string value)
        {
            return FindValue<SortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortContextsBy.
    /// </summary>
    public class SortContextsBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortContextsBy
        /// </summary>
        public static readonly SortContextsBy CreationTime = new SortContextsBy("CreationTime");
        /// <summary>
        /// Constant Name for SortContextsBy
        /// </summary>
        public static readonly SortContextsBy Name = new SortContextsBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortContextsBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortContextsBy FindValue(string value)
        {
            return FindValue<SortContextsBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortContextsBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortExperimentsBy.
    /// </summary>
    public class SortExperimentsBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortExperimentsBy
        /// </summary>
        public static readonly SortExperimentsBy CreationTime = new SortExperimentsBy("CreationTime");
        /// <summary>
        /// Constant Name for SortExperimentsBy
        /// </summary>
        public static readonly SortExperimentsBy Name = new SortExperimentsBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortExperimentsBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortExperimentsBy FindValue(string value)
        {
            return FindValue<SortExperimentsBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortExperimentsBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortInferenceExperimentsBy.
    /// </summary>
    public class SortInferenceExperimentsBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortInferenceExperimentsBy
        /// </summary>
        public static readonly SortInferenceExperimentsBy CreationTime = new SortInferenceExperimentsBy("CreationTime");
        /// <summary>
        /// Constant Name for SortInferenceExperimentsBy
        /// </summary>
        public static readonly SortInferenceExperimentsBy Name = new SortInferenceExperimentsBy("Name");
        /// <summary>
        /// Constant Status for SortInferenceExperimentsBy
        /// </summary>
        public static readonly SortInferenceExperimentsBy Status = new SortInferenceExperimentsBy("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortInferenceExperimentsBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortInferenceExperimentsBy FindValue(string value)
        {
            return FindValue<SortInferenceExperimentsBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortInferenceExperimentsBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortLineageGroupsBy.
    /// </summary>
    public class SortLineageGroupsBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortLineageGroupsBy
        /// </summary>
        public static readonly SortLineageGroupsBy CreationTime = new SortLineageGroupsBy("CreationTime");
        /// <summary>
        /// Constant Name for SortLineageGroupsBy
        /// </summary>
        public static readonly SortLineageGroupsBy Name = new SortLineageGroupsBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortLineageGroupsBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortLineageGroupsBy FindValue(string value)
        {
            return FindValue<SortLineageGroupsBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortLineageGroupsBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for SortOrder
        /// </summary>
        public static readonly SortOrder Ascending = new SortOrder("Ascending");
        /// <summary>
        /// Constant Descending for SortOrder
        /// </summary>
        public static readonly SortOrder Descending = new SortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortPipelineExecutionsBy.
    /// </summary>
    public class SortPipelineExecutionsBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortPipelineExecutionsBy
        /// </summary>
        public static readonly SortPipelineExecutionsBy CreationTime = new SortPipelineExecutionsBy("CreationTime");
        /// <summary>
        /// Constant PipelineExecutionArn for SortPipelineExecutionsBy
        /// </summary>
        public static readonly SortPipelineExecutionsBy PipelineExecutionArn = new SortPipelineExecutionsBy("PipelineExecutionArn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortPipelineExecutionsBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortPipelineExecutionsBy FindValue(string value)
        {
            return FindValue<SortPipelineExecutionsBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortPipelineExecutionsBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortPipelinesBy.
    /// </summary>
    public class SortPipelinesBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortPipelinesBy
        /// </summary>
        public static readonly SortPipelinesBy CreationTime = new SortPipelinesBy("CreationTime");
        /// <summary>
        /// Constant Name for SortPipelinesBy
        /// </summary>
        public static readonly SortPipelinesBy Name = new SortPipelinesBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortPipelinesBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortPipelinesBy FindValue(string value)
        {
            return FindValue<SortPipelinesBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortPipelinesBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortTrialComponentsBy.
    /// </summary>
    public class SortTrialComponentsBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortTrialComponentsBy
        /// </summary>
        public static readonly SortTrialComponentsBy CreationTime = new SortTrialComponentsBy("CreationTime");
        /// <summary>
        /// Constant Name for SortTrialComponentsBy
        /// </summary>
        public static readonly SortTrialComponentsBy Name = new SortTrialComponentsBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortTrialComponentsBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortTrialComponentsBy FindValue(string value)
        {
            return FindValue<SortTrialComponentsBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortTrialComponentsBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortTrialsBy.
    /// </summary>
    public class SortTrialsBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortTrialsBy
        /// </summary>
        public static readonly SortTrialsBy CreationTime = new SortTrialsBy("CreationTime");
        /// <summary>
        /// Constant Name for SortTrialsBy
        /// </summary>
        public static readonly SortTrialsBy Name = new SortTrialsBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortTrialsBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortTrialsBy FindValue(string value)
        {
            return FindValue<SortTrialsBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortTrialsBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpaceSortKey.
    /// </summary>
    public class SpaceSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SpaceSortKey
        /// </summary>
        public static readonly SpaceSortKey CreationTime = new SpaceSortKey("CreationTime");
        /// <summary>
        /// Constant LastModifiedTime for SpaceSortKey
        /// </summary>
        public static readonly SpaceSortKey LastModifiedTime = new SpaceSortKey("LastModifiedTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpaceSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpaceSortKey FindValue(string value)
        {
            return FindValue<SpaceSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpaceSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpaceStatus.
    /// </summary>
    public class SpaceStatus : ConstantClass
    {

        /// <summary>
        /// Constant Delete_Failed for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus Delete_Failed = new SpaceStatus("Delete_Failed");
        /// <summary>
        /// Constant Deleting for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus Deleting = new SpaceStatus("Deleting");
        /// <summary>
        /// Constant Failed for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus Failed = new SpaceStatus("Failed");
        /// <summary>
        /// Constant InService for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus InService = new SpaceStatus("InService");
        /// <summary>
        /// Constant Pending for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus Pending = new SpaceStatus("Pending");
        /// <summary>
        /// Constant Update_Failed for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus Update_Failed = new SpaceStatus("Update_Failed");
        /// <summary>
        /// Constant Updating for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus Updating = new SpaceStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpaceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpaceStatus FindValue(string value)
        {
            return FindValue<SpaceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpaceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SplitType.
    /// </summary>
    public class SplitType : ConstantClass
    {

        /// <summary>
        /// Constant Line for SplitType
        /// </summary>
        public static readonly SplitType Line = new SplitType("Line");
        /// <summary>
        /// Constant None for SplitType
        /// </summary>
        public static readonly SplitType None = new SplitType("None");
        /// <summary>
        /// Constant RecordIO for SplitType
        /// </summary>
        public static readonly SplitType RecordIO = new SplitType("RecordIO");
        /// <summary>
        /// Constant TFRecord for SplitType
        /// </summary>
        public static readonly SplitType TFRecord = new SplitType("TFRecord");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SplitType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SplitType FindValue(string value)
        {
            return FindValue<SplitType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SplitType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StageStatus.
    /// </summary>
    public class StageStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for StageStatus
        /// </summary>
        public static readonly StageStatus CREATING = new StageStatus("CREATING");
        /// <summary>
        /// Constant DEPLOYED for StageStatus
        /// </summary>
        public static readonly StageStatus DEPLOYED = new StageStatus("DEPLOYED");
        /// <summary>
        /// Constant FAILED for StageStatus
        /// </summary>
        public static readonly StageStatus FAILED = new StageStatus("FAILED");
        /// <summary>
        /// Constant INPROGRESS for StageStatus
        /// </summary>
        public static readonly StageStatus INPROGRESS = new StageStatus("INPROGRESS");
        /// <summary>
        /// Constant READYTODEPLOY for StageStatus
        /// </summary>
        public static readonly StageStatus READYTODEPLOY = new StageStatus("READYTODEPLOY");
        /// <summary>
        /// Constant STARTING for StageStatus
        /// </summary>
        public static readonly StageStatus STARTING = new StageStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for StageStatus
        /// </summary>
        public static readonly StageStatus STOPPED = new StageStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for StageStatus
        /// </summary>
        public static readonly StageStatus STOPPING = new StageStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StageStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StageStatus FindValue(string value)
        {
            return FindValue<StageStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StageStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepStatus.
    /// </summary>
    public class StepStatus : ConstantClass
    {

        /// <summary>
        /// Constant Executing for StepStatus
        /// </summary>
        public static readonly StepStatus Executing = new StepStatus("Executing");
        /// <summary>
        /// Constant Failed for StepStatus
        /// </summary>
        public static readonly StepStatus Failed = new StepStatus("Failed");
        /// <summary>
        /// Constant Starting for StepStatus
        /// </summary>
        public static readonly StepStatus Starting = new StepStatus("Starting");
        /// <summary>
        /// Constant Stopped for StepStatus
        /// </summary>
        public static readonly StepStatus Stopped = new StepStatus("Stopped");
        /// <summary>
        /// Constant Stopping for StepStatus
        /// </summary>
        public static readonly StepStatus Stopping = new StepStatus("Stopping");
        /// <summary>
        /// Constant Succeeded for StepStatus
        /// </summary>
        public static readonly StepStatus Succeeded = new StepStatus("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepStatus FindValue(string value)
        {
            return FindValue<StepStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StudioLifecycleConfigAppType.
    /// </summary>
    public class StudioLifecycleConfigAppType : ConstantClass
    {

        /// <summary>
        /// Constant JupyterServer for StudioLifecycleConfigAppType
        /// </summary>
        public static readonly StudioLifecycleConfigAppType JupyterServer = new StudioLifecycleConfigAppType("JupyterServer");
        /// <summary>
        /// Constant KernelGateway for StudioLifecycleConfigAppType
        /// </summary>
        public static readonly StudioLifecycleConfigAppType KernelGateway = new StudioLifecycleConfigAppType("KernelGateway");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StudioLifecycleConfigAppType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StudioLifecycleConfigAppType FindValue(string value)
        {
            return FindValue<StudioLifecycleConfigAppType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StudioLifecycleConfigAppType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StudioLifecycleConfigSortKey.
    /// </summary>
    public class StudioLifecycleConfigSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for StudioLifecycleConfigSortKey
        /// </summary>
        public static readonly StudioLifecycleConfigSortKey CreationTime = new StudioLifecycleConfigSortKey("CreationTime");
        /// <summary>
        /// Constant LastModifiedTime for StudioLifecycleConfigSortKey
        /// </summary>
        public static readonly StudioLifecycleConfigSortKey LastModifiedTime = new StudioLifecycleConfigSortKey("LastModifiedTime");
        /// <summary>
        /// Constant Name for StudioLifecycleConfigSortKey
        /// </summary>
        public static readonly StudioLifecycleConfigSortKey Name = new StudioLifecycleConfigSortKey("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StudioLifecycleConfigSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StudioLifecycleConfigSortKey FindValue(string value)
        {
            return FindValue<StudioLifecycleConfigSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StudioLifecycleConfigSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TableFormat.
    /// </summary>
    public class TableFormat : ConstantClass
    {

        /// <summary>
        /// Constant Glue for TableFormat
        /// </summary>
        public static readonly TableFormat Glue = new TableFormat("Glue");
        /// <summary>
        /// Constant Iceberg for TableFormat
        /// </summary>
        public static readonly TableFormat Iceberg = new TableFormat("Iceberg");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableFormat FindValue(string value)
        {
            return FindValue<TableFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetDevice.
    /// </summary>
    public class TargetDevice : ConstantClass
    {

        /// <summary>
        /// Constant Aisage for TargetDevice
        /// </summary>
        public static readonly TargetDevice Aisage = new TargetDevice("aisage");
        /// <summary>
        /// Constant Amba_cv2 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Amba_cv2 = new TargetDevice("amba_cv2");
        /// <summary>
        /// Constant Amba_cv22 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Amba_cv22 = new TargetDevice("amba_cv22");
        /// <summary>
        /// Constant Amba_cv25 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Amba_cv25 = new TargetDevice("amba_cv25");
        /// <summary>
        /// Constant Coreml for TargetDevice
        /// </summary>
        public static readonly TargetDevice Coreml = new TargetDevice("coreml");
        /// <summary>
        /// Constant Deeplens for TargetDevice
        /// </summary>
        public static readonly TargetDevice Deeplens = new TargetDevice("deeplens");
        /// <summary>
        /// Constant Imx8mplus for TargetDevice
        /// </summary>
        public static readonly TargetDevice Imx8mplus = new TargetDevice("imx8mplus");
        /// <summary>
        /// Constant Imx8qm for TargetDevice
        /// </summary>
        public static readonly TargetDevice Imx8qm = new TargetDevice("imx8qm");
        /// <summary>
        /// Constant Jacinto_tda4vm for TargetDevice
        /// </summary>
        public static readonly TargetDevice Jacinto_tda4vm = new TargetDevice("jacinto_tda4vm");
        /// <summary>
        /// Constant Jetson_nano for TargetDevice
        /// </summary>
        public static readonly TargetDevice Jetson_nano = new TargetDevice("jetson_nano");
        /// <summary>
        /// Constant Jetson_tx1 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Jetson_tx1 = new TargetDevice("jetson_tx1");
        /// <summary>
        /// Constant Jetson_tx2 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Jetson_tx2 = new TargetDevice("jetson_tx2");
        /// <summary>
        /// Constant Jetson_xavier for TargetDevice
        /// </summary>
        public static readonly TargetDevice Jetson_xavier = new TargetDevice("jetson_xavier");
        /// <summary>
        /// Constant Lambda for TargetDevice
        /// </summary>
        public static readonly TargetDevice Lambda = new TargetDevice("lambda");
        /// <summary>
        /// Constant Ml_c4 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_c4 = new TargetDevice("ml_c4");
        /// <summary>
        /// Constant Ml_c5 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_c5 = new TargetDevice("ml_c5");
        /// <summary>
        /// Constant Ml_eia2 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_eia2 = new TargetDevice("ml_eia2");
        /// <summary>
        /// Constant Ml_g4dn for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_g4dn = new TargetDevice("ml_g4dn");
        /// <summary>
        /// Constant Ml_inf1 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_inf1 = new TargetDevice("ml_inf1");
        /// <summary>
        /// Constant Ml_m4 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_m4 = new TargetDevice("ml_m4");
        /// <summary>
        /// Constant Ml_m5 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_m5 = new TargetDevice("ml_m5");
        /// <summary>
        /// Constant Ml_p2 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_p2 = new TargetDevice("ml_p2");
        /// <summary>
        /// Constant Ml_p3 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_p3 = new TargetDevice("ml_p3");
        /// <summary>
        /// Constant Qcs603 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Qcs603 = new TargetDevice("qcs603");
        /// <summary>
        /// Constant Qcs605 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Qcs605 = new TargetDevice("qcs605");
        /// <summary>
        /// Constant Rasp3b for TargetDevice
        /// </summary>
        public static readonly TargetDevice Rasp3b = new TargetDevice("rasp3b");
        /// <summary>
        /// Constant Rk3288 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Rk3288 = new TargetDevice("rk3288");
        /// <summary>
        /// Constant Rk3399 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Rk3399 = new TargetDevice("rk3399");
        /// <summary>
        /// Constant Sbe_c for TargetDevice
        /// </summary>
        public static readonly TargetDevice Sbe_c = new TargetDevice("sbe_c");
        /// <summary>
        /// Constant Sitara_am57x for TargetDevice
        /// </summary>
        public static readonly TargetDevice Sitara_am57x = new TargetDevice("sitara_am57x");
        /// <summary>
        /// Constant X86_win32 for TargetDevice
        /// </summary>
        public static readonly TargetDevice X86_win32 = new TargetDevice("x86_win32");
        /// <summary>
        /// Constant X86_win64 for TargetDevice
        /// </summary>
        public static readonly TargetDevice X86_win64 = new TargetDevice("x86_win64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetDevice(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetDevice FindValue(string value)
        {
            return FindValue<TargetDevice>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetDevice(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetPlatformAccelerator.
    /// </summary>
    public class TargetPlatformAccelerator : ConstantClass
    {

        /// <summary>
        /// Constant INTEL_GRAPHICS for TargetPlatformAccelerator
        /// </summary>
        public static readonly TargetPlatformAccelerator INTEL_GRAPHICS = new TargetPlatformAccelerator("INTEL_GRAPHICS");
        /// <summary>
        /// Constant MALI for TargetPlatformAccelerator
        /// </summary>
        public static readonly TargetPlatformAccelerator MALI = new TargetPlatformAccelerator("MALI");
        /// <summary>
        /// Constant NNA for TargetPlatformAccelerator
        /// </summary>
        public static readonly TargetPlatformAccelerator NNA = new TargetPlatformAccelerator("NNA");
        /// <summary>
        /// Constant NVIDIA for TargetPlatformAccelerator
        /// </summary>
        public static readonly TargetPlatformAccelerator NVIDIA = new TargetPlatformAccelerator("NVIDIA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetPlatformAccelerator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetPlatformAccelerator FindValue(string value)
        {
            return FindValue<TargetPlatformAccelerator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetPlatformAccelerator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetPlatformArch.
    /// </summary>
    public class TargetPlatformArch : ConstantClass
    {

        /// <summary>
        /// Constant ARM_EABI for TargetPlatformArch
        /// </summary>
        public static readonly TargetPlatformArch ARM_EABI = new TargetPlatformArch("ARM_EABI");
        /// <summary>
        /// Constant ARM_EABIHF for TargetPlatformArch
        /// </summary>
        public static readonly TargetPlatformArch ARM_EABIHF = new TargetPlatformArch("ARM_EABIHF");
        /// <summary>
        /// Constant ARM64 for TargetPlatformArch
        /// </summary>
        public static readonly TargetPlatformArch ARM64 = new TargetPlatformArch("ARM64");
        /// <summary>
        /// Constant X86 for TargetPlatformArch
        /// </summary>
        public static readonly TargetPlatformArch X86 = new TargetPlatformArch("X86");
        /// <summary>
        /// Constant X86_64 for TargetPlatformArch
        /// </summary>
        public static readonly TargetPlatformArch X86_64 = new TargetPlatformArch("X86_64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetPlatformArch(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetPlatformArch FindValue(string value)
        {
            return FindValue<TargetPlatformArch>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetPlatformArch(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetPlatformOs.
    /// </summary>
    public class TargetPlatformOs : ConstantClass
    {

        /// <summary>
        /// Constant ANDROID for TargetPlatformOs
        /// </summary>
        public static readonly TargetPlatformOs ANDROID = new TargetPlatformOs("ANDROID");
        /// <summary>
        /// Constant LINUX for TargetPlatformOs
        /// </summary>
        public static readonly TargetPlatformOs LINUX = new TargetPlatformOs("LINUX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetPlatformOs(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetPlatformOs FindValue(string value)
        {
            return FindValue<TargetPlatformOs>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetPlatformOs(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrafficRoutingConfigType.
    /// </summary>
    public class TrafficRoutingConfigType : ConstantClass
    {

        /// <summary>
        /// Constant ALL_AT_ONCE for TrafficRoutingConfigType
        /// </summary>
        public static readonly TrafficRoutingConfigType ALL_AT_ONCE = new TrafficRoutingConfigType("ALL_AT_ONCE");
        /// <summary>
        /// Constant CANARY for TrafficRoutingConfigType
        /// </summary>
        public static readonly TrafficRoutingConfigType CANARY = new TrafficRoutingConfigType("CANARY");
        /// <summary>
        /// Constant LINEAR for TrafficRoutingConfigType
        /// </summary>
        public static readonly TrafficRoutingConfigType LINEAR = new TrafficRoutingConfigType("LINEAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrafficRoutingConfigType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrafficRoutingConfigType FindValue(string value)
        {
            return FindValue<TrafficRoutingConfigType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrafficRoutingConfigType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrafficType.
    /// </summary>
    public class TrafficType : ConstantClass
    {

        /// <summary>
        /// Constant PHASES for TrafficType
        /// </summary>
        public static readonly TrafficType PHASES = new TrafficType("PHASES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrafficType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrafficType FindValue(string value)
        {
            return FindValue<TrafficType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrafficType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingInputMode.
    /// </summary>
    public class TrainingInputMode : ConstantClass
    {

        /// <summary>
        /// Constant FastFile for TrainingInputMode
        /// </summary>
        public static readonly TrainingInputMode FastFile = new TrainingInputMode("FastFile");
        /// <summary>
        /// Constant File for TrainingInputMode
        /// </summary>
        public static readonly TrainingInputMode File = new TrainingInputMode("File");
        /// <summary>
        /// Constant Pipe for TrainingInputMode
        /// </summary>
        public static readonly TrainingInputMode Pipe = new TrainingInputMode("Pipe");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingInputMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingInputMode FindValue(string value)
        {
            return FindValue<TrainingInputMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingInputMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingInstanceType.
    /// </summary>
    public class TrainingInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC42xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC42xlarge = new TrainingInstanceType("ml.c4.2xlarge");
        /// <summary>
        /// Constant MlC44xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC44xlarge = new TrainingInstanceType("ml.c4.4xlarge");
        /// <summary>
        /// Constant MlC48xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC48xlarge = new TrainingInstanceType("ml.c4.8xlarge");
        /// <summary>
        /// Constant MlC4Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC4Xlarge = new TrainingInstanceType("ml.c4.xlarge");
        /// <summary>
        /// Constant MlC518xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC518xlarge = new TrainingInstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC52xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC52xlarge = new TrainingInstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC54xlarge = new TrainingInstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC59xlarge = new TrainingInstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5n18xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC5n18xlarge = new TrainingInstanceType("ml.c5n.18xlarge");
        /// <summary>
        /// Constant MlC5n2xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC5n2xlarge = new TrainingInstanceType("ml.c5n.2xlarge");
        /// <summary>
        /// Constant MlC5n4xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC5n4xlarge = new TrainingInstanceType("ml.c5n.4xlarge");
        /// <summary>
        /// Constant MlC5n9xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC5n9xlarge = new TrainingInstanceType("ml.c5n.9xlarge");
        /// <summary>
        /// Constant MlC5nXlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC5nXlarge = new TrainingInstanceType("ml.c5n.xlarge");
        /// <summary>
        /// Constant MlC5Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC5Xlarge = new TrainingInstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlG4dn12xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlG4dn12xlarge = new TrainingInstanceType("ml.g4dn.12xlarge");
        /// <summary>
        /// Constant MlG4dn16xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlG4dn16xlarge = new TrainingInstanceType("ml.g4dn.16xlarge");
        /// <summary>
        /// Constant MlG4dn2xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlG4dn2xlarge = new TrainingInstanceType("ml.g4dn.2xlarge");
        /// <summary>
        /// Constant MlG4dn4xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlG4dn4xlarge = new TrainingInstanceType("ml.g4dn.4xlarge");
        /// <summary>
        /// Constant MlG4dn8xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlG4dn8xlarge = new TrainingInstanceType("ml.g4dn.8xlarge");
        /// <summary>
        /// Constant MlG4dnXlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlG4dnXlarge = new TrainingInstanceType("ml.g4dn.xlarge");
        /// <summary>
        /// Constant MlG512xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlG512xlarge = new TrainingInstanceType("ml.g5.12xlarge");
        /// <summary>
        /// Constant MlG516xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlG516xlarge = new TrainingInstanceType("ml.g5.16xlarge");
        /// <summary>
        /// Constant MlG524xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlG524xlarge = new TrainingInstanceType("ml.g5.24xlarge");
        /// <summary>
        /// Constant MlG52xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlG52xlarge = new TrainingInstanceType("ml.g5.2xlarge");
        /// <summary>
        /// Constant MlG548xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlG548xlarge = new TrainingInstanceType("ml.g5.48xlarge");
        /// <summary>
        /// Constant MlG54xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlG54xlarge = new TrainingInstanceType("ml.g5.4xlarge");
        /// <summary>
        /// Constant MlG58xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlG58xlarge = new TrainingInstanceType("ml.g5.8xlarge");
        /// <summary>
        /// Constant MlG5Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlG5Xlarge = new TrainingInstanceType("ml.g5.xlarge");
        /// <summary>
        /// Constant MlM410xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM410xlarge = new TrainingInstanceType("ml.m4.10xlarge");
        /// <summary>
        /// Constant MlM416xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM416xlarge = new TrainingInstanceType("ml.m4.16xlarge");
        /// <summary>
        /// Constant MlM42xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM42xlarge = new TrainingInstanceType("ml.m4.2xlarge");
        /// <summary>
        /// Constant MlM44xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM44xlarge = new TrainingInstanceType("ml.m4.4xlarge");
        /// <summary>
        /// Constant MlM4Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM4Xlarge = new TrainingInstanceType("ml.m4.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM512xlarge = new TrainingInstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM524xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM524xlarge = new TrainingInstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM52xlarge = new TrainingInstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM54xlarge = new TrainingInstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM5Large for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM5Large = new TrainingInstanceType("ml.m5.large");
        /// <summary>
        /// Constant MlM5Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM5Xlarge = new TrainingInstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlP216xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP216xlarge = new TrainingInstanceType("ml.p2.16xlarge");
        /// <summary>
        /// Constant MlP28xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP28xlarge = new TrainingInstanceType("ml.p2.8xlarge");
        /// <summary>
        /// Constant MlP2Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP2Xlarge = new TrainingInstanceType("ml.p2.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP316xlarge = new TrainingInstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP32xlarge = new TrainingInstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP38xlarge = new TrainingInstanceType("ml.p3.8xlarge");
        /// <summary>
        /// Constant MlP3dn24xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP3dn24xlarge = new TrainingInstanceType("ml.p3dn.24xlarge");
        /// <summary>
        /// Constant MlP4d24xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP4d24xlarge = new TrainingInstanceType("ml.p4d.24xlarge");
        /// <summary>
        /// Constant MlTrn12xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlTrn12xlarge = new TrainingInstanceType("ml.trn1.2xlarge");
        /// <summary>
        /// Constant MlTrn132xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlTrn132xlarge = new TrainingInstanceType("ml.trn1.32xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingInstanceType FindValue(string value)
        {
            return FindValue<TrainingInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingJobEarlyStoppingType.
    /// </summary>
    public class TrainingJobEarlyStoppingType : ConstantClass
    {

        /// <summary>
        /// Constant Auto for TrainingJobEarlyStoppingType
        /// </summary>
        public static readonly TrainingJobEarlyStoppingType Auto = new TrainingJobEarlyStoppingType("Auto");
        /// <summary>
        /// Constant Off for TrainingJobEarlyStoppingType
        /// </summary>
        public static readonly TrainingJobEarlyStoppingType Off = new TrainingJobEarlyStoppingType("Off");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingJobEarlyStoppingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingJobEarlyStoppingType FindValue(string value)
        {
            return FindValue<TrainingJobEarlyStoppingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingJobEarlyStoppingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingJobSortByOptions.
    /// </summary>
    public class TrainingJobSortByOptions : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for TrainingJobSortByOptions
        /// </summary>
        public static readonly TrainingJobSortByOptions CreationTime = new TrainingJobSortByOptions("CreationTime");
        /// <summary>
        /// Constant FinalObjectiveMetricValue for TrainingJobSortByOptions
        /// </summary>
        public static readonly TrainingJobSortByOptions FinalObjectiveMetricValue = new TrainingJobSortByOptions("FinalObjectiveMetricValue");
        /// <summary>
        /// Constant Name for TrainingJobSortByOptions
        /// </summary>
        public static readonly TrainingJobSortByOptions Name = new TrainingJobSortByOptions("Name");
        /// <summary>
        /// Constant Status for TrainingJobSortByOptions
        /// </summary>
        public static readonly TrainingJobSortByOptions Status = new TrainingJobSortByOptions("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingJobSortByOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingJobSortByOptions FindValue(string value)
        {
            return FindValue<TrainingJobSortByOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingJobSortByOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingJobStatus.
    /// </summary>
    public class TrainingJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus Completed = new TrainingJobStatus("Completed");
        /// <summary>
        /// Constant Failed for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus Failed = new TrainingJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus InProgress = new TrainingJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus Stopped = new TrainingJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus Stopping = new TrainingJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingJobStatus FindValue(string value)
        {
            return FindValue<TrainingJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingRepositoryAccessMode.
    /// </summary>
    public class TrainingRepositoryAccessMode : ConstantClass
    {

        /// <summary>
        /// Constant Platform for TrainingRepositoryAccessMode
        /// </summary>
        public static readonly TrainingRepositoryAccessMode Platform = new TrainingRepositoryAccessMode("Platform");
        /// <summary>
        /// Constant Vpc for TrainingRepositoryAccessMode
        /// </summary>
        public static readonly TrainingRepositoryAccessMode Vpc = new TrainingRepositoryAccessMode("Vpc");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingRepositoryAccessMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingRepositoryAccessMode FindValue(string value)
        {
            return FindValue<TrainingRepositoryAccessMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingRepositoryAccessMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransformInstanceType.
    /// </summary>
    public class TransformInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC42xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC42xlarge = new TransformInstanceType("ml.c4.2xlarge");
        /// <summary>
        /// Constant MlC44xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC44xlarge = new TransformInstanceType("ml.c4.4xlarge");
        /// <summary>
        /// Constant MlC48xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC48xlarge = new TransformInstanceType("ml.c4.8xlarge");
        /// <summary>
        /// Constant MlC4Xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC4Xlarge = new TransformInstanceType("ml.c4.xlarge");
        /// <summary>
        /// Constant MlC518xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC518xlarge = new TransformInstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC52xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC52xlarge = new TransformInstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC54xlarge = new TransformInstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC59xlarge = new TransformInstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5Xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC5Xlarge = new TransformInstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlG4dn12xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlG4dn12xlarge = new TransformInstanceType("ml.g4dn.12xlarge");
        /// <summary>
        /// Constant MlG4dn16xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlG4dn16xlarge = new TransformInstanceType("ml.g4dn.16xlarge");
        /// <summary>
        /// Constant MlG4dn2xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlG4dn2xlarge = new TransformInstanceType("ml.g4dn.2xlarge");
        /// <summary>
        /// Constant MlG4dn4xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlG4dn4xlarge = new TransformInstanceType("ml.g4dn.4xlarge");
        /// <summary>
        /// Constant MlG4dn8xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlG4dn8xlarge = new TransformInstanceType("ml.g4dn.8xlarge");
        /// <summary>
        /// Constant MlG4dnXlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlG4dnXlarge = new TransformInstanceType("ml.g4dn.xlarge");
        /// <summary>
        /// Constant MlM410xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM410xlarge = new TransformInstanceType("ml.m4.10xlarge");
        /// <summary>
        /// Constant MlM416xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM416xlarge = new TransformInstanceType("ml.m4.16xlarge");
        /// <summary>
        /// Constant MlM42xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM42xlarge = new TransformInstanceType("ml.m4.2xlarge");
        /// <summary>
        /// Constant MlM44xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM44xlarge = new TransformInstanceType("ml.m4.4xlarge");
        /// <summary>
        /// Constant MlM4Xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM4Xlarge = new TransformInstanceType("ml.m4.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM512xlarge = new TransformInstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM524xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM524xlarge = new TransformInstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM52xlarge = new TransformInstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM54xlarge = new TransformInstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM5Large for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM5Large = new TransformInstanceType("ml.m5.large");
        /// <summary>
        /// Constant MlM5Xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM5Xlarge = new TransformInstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlP216xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlP216xlarge = new TransformInstanceType("ml.p2.16xlarge");
        /// <summary>
        /// Constant MlP28xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlP28xlarge = new TransformInstanceType("ml.p2.8xlarge");
        /// <summary>
        /// Constant MlP2Xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlP2Xlarge = new TransformInstanceType("ml.p2.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlP316xlarge = new TransformInstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlP32xlarge = new TransformInstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlP38xlarge = new TransformInstanceType("ml.p3.8xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransformInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransformInstanceType FindValue(string value)
        {
            return FindValue<TransformInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransformInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransformJobStatus.
    /// </summary>
    public class TransformJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for TransformJobStatus
        /// </summary>
        public static readonly TransformJobStatus Completed = new TransformJobStatus("Completed");
        /// <summary>
        /// Constant Failed for TransformJobStatus
        /// </summary>
        public static readonly TransformJobStatus Failed = new TransformJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for TransformJobStatus
        /// </summary>
        public static readonly TransformJobStatus InProgress = new TransformJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for TransformJobStatus
        /// </summary>
        public static readonly TransformJobStatus Stopped = new TransformJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for TransformJobStatus
        /// </summary>
        public static readonly TransformJobStatus Stopping = new TransformJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransformJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransformJobStatus FindValue(string value)
        {
            return FindValue<TransformJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransformJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrialComponentPrimaryStatus.
    /// </summary>
    public class TrialComponentPrimaryStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for TrialComponentPrimaryStatus
        /// </summary>
        public static readonly TrialComponentPrimaryStatus Completed = new TrialComponentPrimaryStatus("Completed");
        /// <summary>
        /// Constant Failed for TrialComponentPrimaryStatus
        /// </summary>
        public static readonly TrialComponentPrimaryStatus Failed = new TrialComponentPrimaryStatus("Failed");
        /// <summary>
        /// Constant InProgress for TrialComponentPrimaryStatus
        /// </summary>
        public static readonly TrialComponentPrimaryStatus InProgress = new TrialComponentPrimaryStatus("InProgress");
        /// <summary>
        /// Constant Stopped for TrialComponentPrimaryStatus
        /// </summary>
        public static readonly TrialComponentPrimaryStatus Stopped = new TrialComponentPrimaryStatus("Stopped");
        /// <summary>
        /// Constant Stopping for TrialComponentPrimaryStatus
        /// </summary>
        public static readonly TrialComponentPrimaryStatus Stopping = new TrialComponentPrimaryStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrialComponentPrimaryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrialComponentPrimaryStatus FindValue(string value)
        {
            return FindValue<TrialComponentPrimaryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrialComponentPrimaryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserProfileSortKey.
    /// </summary>
    public class UserProfileSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for UserProfileSortKey
        /// </summary>
        public static readonly UserProfileSortKey CreationTime = new UserProfileSortKey("CreationTime");
        /// <summary>
        /// Constant LastModifiedTime for UserProfileSortKey
        /// </summary>
        public static readonly UserProfileSortKey LastModifiedTime = new UserProfileSortKey("LastModifiedTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserProfileSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserProfileSortKey FindValue(string value)
        {
            return FindValue<UserProfileSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserProfileSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserProfileStatus.
    /// </summary>
    public class UserProfileStatus : ConstantClass
    {

        /// <summary>
        /// Constant Delete_Failed for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus Delete_Failed = new UserProfileStatus("Delete_Failed");
        /// <summary>
        /// Constant Deleting for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus Deleting = new UserProfileStatus("Deleting");
        /// <summary>
        /// Constant Failed for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus Failed = new UserProfileStatus("Failed");
        /// <summary>
        /// Constant InService for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus InService = new UserProfileStatus("InService");
        /// <summary>
        /// Constant Pending for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus Pending = new UserProfileStatus("Pending");
        /// <summary>
        /// Constant Update_Failed for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus Update_Failed = new UserProfileStatus("Update_Failed");
        /// <summary>
        /// Constant Updating for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus Updating = new UserProfileStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserProfileStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserProfileStatus FindValue(string value)
        {
            return FindValue<UserProfileStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserProfileStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VariantPropertyType.
    /// </summary>
    public class VariantPropertyType : ConstantClass
    {

        /// <summary>
        /// Constant DataCaptureConfig for VariantPropertyType
        /// </summary>
        public static readonly VariantPropertyType DataCaptureConfig = new VariantPropertyType("DataCaptureConfig");
        /// <summary>
        /// Constant DesiredInstanceCount for VariantPropertyType
        /// </summary>
        public static readonly VariantPropertyType DesiredInstanceCount = new VariantPropertyType("DesiredInstanceCount");
        /// <summary>
        /// Constant DesiredWeight for VariantPropertyType
        /// </summary>
        public static readonly VariantPropertyType DesiredWeight = new VariantPropertyType("DesiredWeight");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VariantPropertyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VariantPropertyType FindValue(string value)
        {
            return FindValue<VariantPropertyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VariantPropertyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VariantStatus.
    /// </summary>
    public class VariantStatus : ConstantClass
    {

        /// <summary>
        /// Constant ActivatingTraffic for VariantStatus
        /// </summary>
        public static readonly VariantStatus ActivatingTraffic = new VariantStatus("ActivatingTraffic");
        /// <summary>
        /// Constant Baking for VariantStatus
        /// </summary>
        public static readonly VariantStatus Baking = new VariantStatus("Baking");
        /// <summary>
        /// Constant Creating for VariantStatus
        /// </summary>
        public static readonly VariantStatus Creating = new VariantStatus("Creating");
        /// <summary>
        /// Constant Deleting for VariantStatus
        /// </summary>
        public static readonly VariantStatus Deleting = new VariantStatus("Deleting");
        /// <summary>
        /// Constant Updating for VariantStatus
        /// </summary>
        public static readonly VariantStatus Updating = new VariantStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VariantStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VariantStatus FindValue(string value)
        {
            return FindValue<VariantStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VariantStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VendorGuidance.
    /// </summary>
    public class VendorGuidance : ConstantClass
    {

        /// <summary>
        /// Constant ARCHIVED for VendorGuidance
        /// </summary>
        public static readonly VendorGuidance ARCHIVED = new VendorGuidance("ARCHIVED");
        /// <summary>
        /// Constant NOT_PROVIDED for VendorGuidance
        /// </summary>
        public static readonly VendorGuidance NOT_PROVIDED = new VendorGuidance("NOT_PROVIDED");
        /// <summary>
        /// Constant STABLE for VendorGuidance
        /// </summary>
        public static readonly VendorGuidance STABLE = new VendorGuidance("STABLE");
        /// <summary>
        /// Constant TO_BE_ARCHIVED for VendorGuidance
        /// </summary>
        public static readonly VendorGuidance TO_BE_ARCHIVED = new VendorGuidance("TO_BE_ARCHIVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VendorGuidance(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VendorGuidance FindValue(string value)
        {
            return FindValue<VendorGuidance>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VendorGuidance(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WarmPoolResourceStatus.
    /// </summary>
    public class WarmPoolResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for WarmPoolResourceStatus
        /// </summary>
        public static readonly WarmPoolResourceStatus Available = new WarmPoolResourceStatus("Available");
        /// <summary>
        /// Constant InUse for WarmPoolResourceStatus
        /// </summary>
        public static readonly WarmPoolResourceStatus InUse = new WarmPoolResourceStatus("InUse");
        /// <summary>
        /// Constant Reused for WarmPoolResourceStatus
        /// </summary>
        public static readonly WarmPoolResourceStatus Reused = new WarmPoolResourceStatus("Reused");
        /// <summary>
        /// Constant Terminated for WarmPoolResourceStatus
        /// </summary>
        public static readonly WarmPoolResourceStatus Terminated = new WarmPoolResourceStatus("Terminated");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WarmPoolResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WarmPoolResourceStatus FindValue(string value)
        {
            return FindValue<WarmPoolResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WarmPoolResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkforceStatus.
    /// </summary>
    public class WorkforceStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for WorkforceStatus
        /// </summary>
        public static readonly WorkforceStatus Active = new WorkforceStatus("Active");
        /// <summary>
        /// Constant Deleting for WorkforceStatus
        /// </summary>
        public static readonly WorkforceStatus Deleting = new WorkforceStatus("Deleting");
        /// <summary>
        /// Constant Failed for WorkforceStatus
        /// </summary>
        public static readonly WorkforceStatus Failed = new WorkforceStatus("Failed");
        /// <summary>
        /// Constant Initializing for WorkforceStatus
        /// </summary>
        public static readonly WorkforceStatus Initializing = new WorkforceStatus("Initializing");
        /// <summary>
        /// Constant Updating for WorkforceStatus
        /// </summary>
        public static readonly WorkforceStatus Updating = new WorkforceStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkforceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkforceStatus FindValue(string value)
        {
            return FindValue<WorkforceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkforceStatus(string value)
        {
            return FindValue(value);
        }
    }

}