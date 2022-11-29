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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SecurityLake
{

    /// <summary>
    /// Constants used for properties of type AccessType.
    /// </summary>
    public class AccessType : ConstantClass
    {

        /// <summary>
        /// Constant LAKEFORMATION for AccessType
        /// </summary>
        public static readonly AccessType LAKEFORMATION = new AccessType("LAKEFORMATION");
        /// <summary>
        /// Constant S3 for AccessType
        /// </summary>
        public static readonly AccessType S3 = new AccessType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessType FindValue(string value)
        {
            return FindValue<AccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsLogSourceType.
    /// </summary>
    public class AwsLogSourceType : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD_TRAIL for AwsLogSourceType
        /// </summary>
        public static readonly AwsLogSourceType CLOUD_TRAIL = new AwsLogSourceType("CLOUD_TRAIL");
        /// <summary>
        /// Constant ROUTE53 for AwsLogSourceType
        /// </summary>
        public static readonly AwsLogSourceType ROUTE53 = new AwsLogSourceType("ROUTE53");
        /// <summary>
        /// Constant SH_FINDINGS for AwsLogSourceType
        /// </summary>
        public static readonly AwsLogSourceType SH_FINDINGS = new AwsLogSourceType("SH_FINDINGS");
        /// <summary>
        /// Constant VPC_FLOW for AwsLogSourceType
        /// </summary>
        public static readonly AwsLogSourceType VPC_FLOW = new AwsLogSourceType("VPC_FLOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsLogSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsLogSourceType FindValue(string value)
        {
            return FindValue<AwsLogSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsLogSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Dimension.
    /// </summary>
    public class Dimension : ConstantClass
    {

        /// <summary>
        /// Constant MEMBER for Dimension
        /// </summary>
        public static readonly Dimension MEMBER = new Dimension("MEMBER");
        /// <summary>
        /// Constant REGION for Dimension
        /// </summary>
        public static readonly Dimension REGION = new Dimension("REGION");
        /// <summary>
        /// Constant SOURCE_TYPE for Dimension
        /// </summary>
        public static readonly Dimension SOURCE_TYPE = new Dimension("SOURCE_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Dimension(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Dimension FindValue(string value)
        {
            return FindValue<Dimension>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Dimension(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointProtocol.
    /// </summary>
    public class EndpointProtocol : ConstantClass
    {

        /// <summary>
        /// Constant HTTPS for EndpointProtocol
        /// </summary>
        public static readonly EndpointProtocol HTTPS = new EndpointProtocol("HTTPS");
        /// <summary>
        /// Constant SQS for EndpointProtocol
        /// </summary>
        public static readonly EndpointProtocol SQS = new EndpointProtocol("SQS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointProtocol FindValue(string value)
        {
            return FindValue<EndpointProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HttpsMethod.
    /// </summary>
    public class HttpsMethod : ConstantClass
    {

        /// <summary>
        /// Constant POST for HttpsMethod
        /// </summary>
        public static readonly HttpsMethod POST = new HttpsMethod("POST");
        /// <summary>
        /// Constant PUT for HttpsMethod
        /// </summary>
        public static readonly HttpsMethod PUT = new HttpsMethod("PUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HttpsMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HttpsMethod FindValue(string value)
        {
            return FindValue<HttpsMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HttpsMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OcsfEventClass.
    /// </summary>
    public class OcsfEventClass : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass ACCESS_ACTIVITY = new OcsfEventClass("ACCESS_ACTIVITY");
        /// <summary>
        /// Constant ACCOUNT_CHANGE for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass ACCOUNT_CHANGE = new OcsfEventClass("ACCOUNT_CHANGE");
        /// <summary>
        /// Constant AUTHENTICATION for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass AUTHENTICATION = new OcsfEventClass("AUTHENTICATION");
        /// <summary>
        /// Constant AUTHORIZATION for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass AUTHORIZATION = new OcsfEventClass("AUTHORIZATION");
        /// <summary>
        /// Constant CLOUD_API for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass CLOUD_API = new OcsfEventClass("CLOUD_API");
        /// <summary>
        /// Constant CLOUD_STORAGE for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass CLOUD_STORAGE = new OcsfEventClass("CLOUD_STORAGE");
        /// <summary>
        /// Constant CONFIG_STATE for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass CONFIG_STATE = new OcsfEventClass("CONFIG_STATE");
        /// <summary>
        /// Constant CONTAINER_LIFECYCLE for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass CONTAINER_LIFECYCLE = new OcsfEventClass("CONTAINER_LIFECYCLE");
        /// <summary>
        /// Constant DATABASE_LIFECYCLE for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass DATABASE_LIFECYCLE = new OcsfEventClass("DATABASE_LIFECYCLE");
        /// <summary>
        /// Constant DHCP_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass DHCP_ACTIVITY = new OcsfEventClass("DHCP_ACTIVITY");
        /// <summary>
        /// Constant DNS_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass DNS_ACTIVITY = new OcsfEventClass("DNS_ACTIVITY");
        /// <summary>
        /// Constant ENTITY_MANAGEMENT_AUDIT for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass ENTITY_MANAGEMENT_AUDIT = new OcsfEventClass("ENTITY_MANAGEMENT_AUDIT");
        /// <summary>
        /// Constant FILE_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass FILE_ACTIVITY = new OcsfEventClass("FILE_ACTIVITY");
        /// <summary>
        /// Constant FTP_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass FTP_ACTIVITY = new OcsfEventClass("FTP_ACTIVITY");
        /// <summary>
        /// Constant HTTP_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass HTTP_ACTIVITY = new OcsfEventClass("HTTP_ACTIVITY");
        /// <summary>
        /// Constant INVENTORY_INFO for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass INVENTORY_INFO = new OcsfEventClass("INVENTORY_INFO");
        /// <summary>
        /// Constant KERNEL_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass KERNEL_ACTIVITY = new OcsfEventClass("KERNEL_ACTIVITY");
        /// <summary>
        /// Constant KERNEL_EXTENSION for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass KERNEL_EXTENSION = new OcsfEventClass("KERNEL_EXTENSION");
        /// <summary>
        /// Constant MEMORY_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass MEMORY_ACTIVITY = new OcsfEventClass("MEMORY_ACTIVITY");
        /// <summary>
        /// Constant MODULE_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass MODULE_ACTIVITY = new OcsfEventClass("MODULE_ACTIVITY");
        /// <summary>
        /// Constant NETWORK_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass NETWORK_ACTIVITY = new OcsfEventClass("NETWORK_ACTIVITY");
        /// <summary>
        /// Constant PROCESS_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass PROCESS_ACTIVITY = new OcsfEventClass("PROCESS_ACTIVITY");
        /// <summary>
        /// Constant RDP_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass RDP_ACTIVITY = new OcsfEventClass("RDP_ACTIVITY");
        /// <summary>
        /// Constant REGISTRY_KEY_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass REGISTRY_KEY_ACTIVITY = new OcsfEventClass("REGISTRY_KEY_ACTIVITY");
        /// <summary>
        /// Constant REGISTRY_VALUE_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass REGISTRY_VALUE_ACTIVITY = new OcsfEventClass("REGISTRY_VALUE_ACTIVITY");
        /// <summary>
        /// Constant RESOURCE_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass RESOURCE_ACTIVITY = new OcsfEventClass("RESOURCE_ACTIVITY");
        /// <summary>
        /// Constant RFB_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass RFB_ACTIVITY = new OcsfEventClass("RFB_ACTIVITY");
        /// <summary>
        /// Constant SCHEDULED_JOB_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass SCHEDULED_JOB_ACTIVITY = new OcsfEventClass("SCHEDULED_JOB_ACTIVITY");
        /// <summary>
        /// Constant SECURITY_FINDING for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass SECURITY_FINDING = new OcsfEventClass("SECURITY_FINDING");
        /// <summary>
        /// Constant SMB_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass SMB_ACTIVITY = new OcsfEventClass("SMB_ACTIVITY");
        /// <summary>
        /// Constant SMTP_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass SMTP_ACTIVITY = new OcsfEventClass("SMTP_ACTIVITY");
        /// <summary>
        /// Constant SSH_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass SSH_ACTIVITY = new OcsfEventClass("SSH_ACTIVITY");
        /// <summary>
        /// Constant VIRTUAL_MACHINE_ACTIVITY for OcsfEventClass
        /// </summary>
        public static readonly OcsfEventClass VIRTUAL_MACHINE_ACTIVITY = new OcsfEventClass("VIRTUAL_MACHINE_ACTIVITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OcsfEventClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OcsfEventClass FindValue(string value)
        {
            return FindValue<OcsfEventClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OcsfEventClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Region.
    /// </summary>
    public class Region : ConstantClass
    {

        /// <summary>
        /// Constant ApNortheast1 for Region
        /// </summary>
        public static readonly Region ApNortheast1 = new Region("ap-northeast-1");
        /// <summary>
        /// Constant ApSoutheast2 for Region
        /// </summary>
        public static readonly Region ApSoutheast2 = new Region("ap-southeast-2");
        /// <summary>
        /// Constant EuCentral1 for Region
        /// </summary>
        public static readonly Region EuCentral1 = new Region("eu-central-1");
        /// <summary>
        /// Constant EuWest1 for Region
        /// </summary>
        public static readonly Region EuWest1 = new Region("eu-west-1");
        /// <summary>
        /// Constant UsEast1 for Region
        /// </summary>
        public static readonly Region UsEast1 = new Region("us-east-1");
        /// <summary>
        /// Constant UsEast2 for Region
        /// </summary>
        public static readonly Region UsEast2 = new Region("us-east-2");
        /// <summary>
        /// Constant UsWest2 for Region
        /// </summary>
        public static readonly Region UsWest2 = new Region("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Region(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Region FindValue(string value)
        {
            return FindValue<Region>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Region(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SettingsStatus.
    /// </summary>
    public class SettingsStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for SettingsStatus
        /// </summary>
        public static readonly SettingsStatus COMPLETED = new SettingsStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for SettingsStatus
        /// </summary>
        public static readonly SettingsStatus FAILED = new SettingsStatus("FAILED");
        /// <summary>
        /// Constant INITIALIZED for SettingsStatus
        /// </summary>
        public static readonly SettingsStatus INITIALIZED = new SettingsStatus("INITIALIZED");
        /// <summary>
        /// Constant PENDING for SettingsStatus
        /// </summary>
        public static readonly SettingsStatus PENDING = new SettingsStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SettingsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SettingsStatus FindValue(string value)
        {
            return FindValue<SettingsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SettingsStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceStatus.
    /// </summary>
    public class SourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for SourceStatus
        /// </summary>
        public static readonly SourceStatus ACTIVE = new SourceStatus("ACTIVE");
        /// <summary>
        /// Constant DEACTIVATED for SourceStatus
        /// </summary>
        public static readonly SourceStatus DEACTIVATED = new SourceStatus("DEACTIVATED");
        /// <summary>
        /// Constant PENDING for SourceStatus
        /// </summary>
        public static readonly SourceStatus PENDING = new SourceStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceStatus FindValue(string value)
        {
            return FindValue<SourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageClass.
    /// </summary>
    public class StorageClass : ConstantClass
    {

        /// <summary>
        /// Constant DEEP_ARCHIVE for StorageClass
        /// </summary>
        public static readonly StorageClass DEEP_ARCHIVE = new StorageClass("DEEP_ARCHIVE");
        /// <summary>
        /// Constant EXPIRE for StorageClass
        /// </summary>
        public static readonly StorageClass EXPIRE = new StorageClass("EXPIRE");
        /// <summary>
        /// Constant GLACIER for StorageClass
        /// </summary>
        public static readonly StorageClass GLACIER = new StorageClass("GLACIER");
        /// <summary>
        /// Constant GLACIER_IR for StorageClass
        /// </summary>
        public static readonly StorageClass GLACIER_IR = new StorageClass("GLACIER_IR");
        /// <summary>
        /// Constant INTELLIGENT_TIERING for StorageClass
        /// </summary>
        public static readonly StorageClass INTELLIGENT_TIERING = new StorageClass("INTELLIGENT_TIERING");
        /// <summary>
        /// Constant ONEZONE_IA for StorageClass
        /// </summary>
        public static readonly StorageClass ONEZONE_IA = new StorageClass("ONEZONE_IA");
        /// <summary>
        /// Constant STANDARD_IA for StorageClass
        /// </summary>
        public static readonly StorageClass STANDARD_IA = new StorageClass("STANDARD_IA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageClass FindValue(string value)
        {
            return FindValue<StorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionProtocolType.
    /// </summary>
    public class SubscriptionProtocolType : ConstantClass
    {

        /// <summary>
        /// Constant APP for SubscriptionProtocolType
        /// </summary>
        public static readonly SubscriptionProtocolType APP = new SubscriptionProtocolType("APP");
        /// <summary>
        /// Constant EMAIL for SubscriptionProtocolType
        /// </summary>
        public static readonly SubscriptionProtocolType EMAIL = new SubscriptionProtocolType("EMAIL");
        /// <summary>
        /// Constant EMAIL_JSON for SubscriptionProtocolType
        /// </summary>
        public static readonly SubscriptionProtocolType EMAIL_JSON = new SubscriptionProtocolType("EMAIL_JSON");
        /// <summary>
        /// Constant FIREHOSE for SubscriptionProtocolType
        /// </summary>
        public static readonly SubscriptionProtocolType FIREHOSE = new SubscriptionProtocolType("FIREHOSE");
        /// <summary>
        /// Constant HTTP for SubscriptionProtocolType
        /// </summary>
        public static readonly SubscriptionProtocolType HTTP = new SubscriptionProtocolType("HTTP");
        /// <summary>
        /// Constant HTTPS for SubscriptionProtocolType
        /// </summary>
        public static readonly SubscriptionProtocolType HTTPS = new SubscriptionProtocolType("HTTPS");
        /// <summary>
        /// Constant LAMBDA for SubscriptionProtocolType
        /// </summary>
        public static readonly SubscriptionProtocolType LAMBDA = new SubscriptionProtocolType("LAMBDA");
        /// <summary>
        /// Constant SMS for SubscriptionProtocolType
        /// </summary>
        public static readonly SubscriptionProtocolType SMS = new SubscriptionProtocolType("SMS");
        /// <summary>
        /// Constant SQS for SubscriptionProtocolType
        /// </summary>
        public static readonly SubscriptionProtocolType SQS = new SubscriptionProtocolType("SQS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionProtocolType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionProtocolType FindValue(string value)
        {
            return FindValue<SubscriptionProtocolType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionProtocolType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionStatus.
    /// </summary>
    public class SubscriptionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus ACTIVE = new SubscriptionStatus("ACTIVE");
        /// <summary>
        /// Constant DEACTIVATED for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus DEACTIVATED = new SubscriptionStatus("DEACTIVATED");
        /// <summary>
        /// Constant PENDING for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus PENDING = new SubscriptionStatus("PENDING");
        /// <summary>
        /// Constant READY for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus READY = new SubscriptionStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionStatus FindValue(string value)
        {
            return FindValue<SubscriptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}