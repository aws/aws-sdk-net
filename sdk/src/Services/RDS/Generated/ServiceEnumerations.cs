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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.RDS
{

    /// <summary>
    /// Constants used for properties of type ActivityStreamMode.
    /// </summary>
    public class ActivityStreamMode : ConstantClass
    {

        /// <summary>
        /// Constant Async for ActivityStreamMode
        /// </summary>
        public static readonly ActivityStreamMode Async = new ActivityStreamMode("async");
        /// <summary>
        /// Constant Sync for ActivityStreamMode
        /// </summary>
        public static readonly ActivityStreamMode Sync = new ActivityStreamMode("sync");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActivityStreamMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActivityStreamMode FindValue(string value)
        {
            return FindValue<ActivityStreamMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActivityStreamMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActivityStreamPolicyStatus.
    /// </summary>
    public class ActivityStreamPolicyStatus : ConstantClass
    {

        /// <summary>
        /// Constant Locked for ActivityStreamPolicyStatus
        /// </summary>
        public static readonly ActivityStreamPolicyStatus Locked = new ActivityStreamPolicyStatus("locked");
        /// <summary>
        /// Constant LockingPolicy for ActivityStreamPolicyStatus
        /// </summary>
        public static readonly ActivityStreamPolicyStatus LockingPolicy = new ActivityStreamPolicyStatus("locking-policy");
        /// <summary>
        /// Constant Unlocked for ActivityStreamPolicyStatus
        /// </summary>
        public static readonly ActivityStreamPolicyStatus Unlocked = new ActivityStreamPolicyStatus("unlocked");
        /// <summary>
        /// Constant UnlockingPolicy for ActivityStreamPolicyStatus
        /// </summary>
        public static readonly ActivityStreamPolicyStatus UnlockingPolicy = new ActivityStreamPolicyStatus("unlocking-policy");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActivityStreamPolicyStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActivityStreamPolicyStatus FindValue(string value)
        {
            return FindValue<ActivityStreamPolicyStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActivityStreamPolicyStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActivityStreamStatus.
    /// </summary>
    public class ActivityStreamStatus : ConstantClass
    {

        /// <summary>
        /// Constant Started for ActivityStreamStatus
        /// </summary>
        public static readonly ActivityStreamStatus Started = new ActivityStreamStatus("started");
        /// <summary>
        /// Constant Starting for ActivityStreamStatus
        /// </summary>
        public static readonly ActivityStreamStatus Starting = new ActivityStreamStatus("starting");
        /// <summary>
        /// Constant Stopped for ActivityStreamStatus
        /// </summary>
        public static readonly ActivityStreamStatus Stopped = new ActivityStreamStatus("stopped");
        /// <summary>
        /// Constant Stopping for ActivityStreamStatus
        /// </summary>
        public static readonly ActivityStreamStatus Stopping = new ActivityStreamStatus("stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActivityStreamStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActivityStreamStatus FindValue(string value)
        {
            return FindValue<ActivityStreamStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActivityStreamStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplyMethod.
    /// </summary>
    public class ApplyMethod : ConstantClass
    {

        /// <summary>
        /// Constant Immediate for ApplyMethod
        /// </summary>
        public static readonly ApplyMethod Immediate = new ApplyMethod("immediate");
        /// <summary>
        /// Constant PendingReboot for ApplyMethod
        /// </summary>
        public static readonly ApplyMethod PendingReboot = new ApplyMethod("pending-reboot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplyMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplyMethod FindValue(string value)
        {
            return FindValue<ApplyMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplyMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditPolicyState.
    /// </summary>
    public class AuditPolicyState : ConstantClass
    {

        /// <summary>
        /// Constant Locked for AuditPolicyState
        /// </summary>
        public static readonly AuditPolicyState Locked = new AuditPolicyState("locked");
        /// <summary>
        /// Constant Unlocked for AuditPolicyState
        /// </summary>
        public static readonly AuditPolicyState Unlocked = new AuditPolicyState("unlocked");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditPolicyState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditPolicyState FindValue(string value)
        {
            return FindValue<AuditPolicyState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditPolicyState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthScheme.
    /// </summary>
    public class AuthScheme : ConstantClass
    {

        /// <summary>
        /// Constant SECRETS for AuthScheme
        /// </summary>
        public static readonly AuthScheme SECRETS = new AuthScheme("SECRETS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthScheme(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthScheme FindValue(string value)
        {
            return FindValue<AuthScheme>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthScheme(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutomationMode.
    /// </summary>
    public class AutomationMode : ConstantClass
    {

        /// <summary>
        /// Constant AllPaused for AutomationMode
        /// </summary>
        public static readonly AutomationMode AllPaused = new AutomationMode("all-paused");
        /// <summary>
        /// Constant Full for AutomationMode
        /// </summary>
        public static readonly AutomationMode Full = new AutomationMode("full");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomationMode FindValue(string value)
        {
            return FindValue<AutomationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientPasswordAuthType.
    /// </summary>
    public class ClientPasswordAuthType : ConstantClass
    {

        /// <summary>
        /// Constant MYSQL_CACHING_SHA2_PASSWORD for ClientPasswordAuthType
        /// </summary>
        public static readonly ClientPasswordAuthType MYSQL_CACHING_SHA2_PASSWORD = new ClientPasswordAuthType("MYSQL_CACHING_SHA2_PASSWORD");
        /// <summary>
        /// Constant MYSQL_NATIVE_PASSWORD for ClientPasswordAuthType
        /// </summary>
        public static readonly ClientPasswordAuthType MYSQL_NATIVE_PASSWORD = new ClientPasswordAuthType("MYSQL_NATIVE_PASSWORD");
        /// <summary>
        /// Constant POSTGRES_MD5 for ClientPasswordAuthType
        /// </summary>
        public static readonly ClientPasswordAuthType POSTGRES_MD5 = new ClientPasswordAuthType("POSTGRES_MD5");
        /// <summary>
        /// Constant POSTGRES_SCRAM_SHA_256 for ClientPasswordAuthType
        /// </summary>
        public static readonly ClientPasswordAuthType POSTGRES_SCRAM_SHA_256 = new ClientPasswordAuthType("POSTGRES_SCRAM_SHA_256");
        /// <summary>
        /// Constant SQL_SERVER_AUTHENTICATION for ClientPasswordAuthType
        /// </summary>
        public static readonly ClientPasswordAuthType SQL_SERVER_AUTHENTICATION = new ClientPasswordAuthType("SQL_SERVER_AUTHENTICATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientPasswordAuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientPasswordAuthType FindValue(string value)
        {
            return FindValue<ClientPasswordAuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientPasswordAuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterScalabilityType.
    /// </summary>
    public class ClusterScalabilityType : ConstantClass
    {

        /// <summary>
        /// Constant Limitless for ClusterScalabilityType
        /// </summary>
        public static readonly ClusterScalabilityType Limitless = new ClusterScalabilityType("limitless");
        /// <summary>
        /// Constant Scaleout for ClusterScalabilityType
        /// </summary>
        public static readonly ClusterScalabilityType Scaleout = new ClusterScalabilityType("scaleout");
        /// <summary>
        /// Constant Standard for ClusterScalabilityType
        /// </summary>
        public static readonly ClusterScalabilityType Standard = new ClusterScalabilityType("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterScalabilityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterScalabilityType FindValue(string value)
        {
            return FindValue<ClusterScalabilityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterScalabilityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomEngineVersionStatus.
    /// </summary>
    public class CustomEngineVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for CustomEngineVersionStatus
        /// </summary>
        public static readonly CustomEngineVersionStatus Available = new CustomEngineVersionStatus("available");
        /// <summary>
        /// Constant Inactive for CustomEngineVersionStatus
        /// </summary>
        public static readonly CustomEngineVersionStatus Inactive = new CustomEngineVersionStatus("inactive");
        /// <summary>
        /// Constant InactiveExceptRestore for CustomEngineVersionStatus
        /// </summary>
        public static readonly CustomEngineVersionStatus InactiveExceptRestore = new CustomEngineVersionStatus("inactive-except-restore");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomEngineVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomEngineVersionStatus FindValue(string value)
        {
            return FindValue<CustomEngineVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomEngineVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatabaseInsightsMode.
    /// </summary>
    public class DatabaseInsightsMode : ConstantClass
    {

        /// <summary>
        /// Constant Advanced for DatabaseInsightsMode
        /// </summary>
        public static readonly DatabaseInsightsMode Advanced = new DatabaseInsightsMode("advanced");
        /// <summary>
        /// Constant Standard for DatabaseInsightsMode
        /// </summary>
        public static readonly DatabaseInsightsMode Standard = new DatabaseInsightsMode("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatabaseInsightsMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatabaseInsightsMode FindValue(string value)
        {
            return FindValue<DatabaseInsightsMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatabaseInsightsMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DBProxyEndpointStatus.
    /// </summary>
    public class DBProxyEndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for DBProxyEndpointStatus
        /// </summary>
        public static readonly DBProxyEndpointStatus Available = new DBProxyEndpointStatus("available");
        /// <summary>
        /// Constant Creating for DBProxyEndpointStatus
        /// </summary>
        public static readonly DBProxyEndpointStatus Creating = new DBProxyEndpointStatus("creating");
        /// <summary>
        /// Constant Deleting for DBProxyEndpointStatus
        /// </summary>
        public static readonly DBProxyEndpointStatus Deleting = new DBProxyEndpointStatus("deleting");
        /// <summary>
        /// Constant IncompatibleNetwork for DBProxyEndpointStatus
        /// </summary>
        public static readonly DBProxyEndpointStatus IncompatibleNetwork = new DBProxyEndpointStatus("incompatible-network");
        /// <summary>
        /// Constant InsufficientResourceLimits for DBProxyEndpointStatus
        /// </summary>
        public static readonly DBProxyEndpointStatus InsufficientResourceLimits = new DBProxyEndpointStatus("insufficient-resource-limits");
        /// <summary>
        /// Constant Modifying for DBProxyEndpointStatus
        /// </summary>
        public static readonly DBProxyEndpointStatus Modifying = new DBProxyEndpointStatus("modifying");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DBProxyEndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DBProxyEndpointStatus FindValue(string value)
        {
            return FindValue<DBProxyEndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DBProxyEndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DBProxyEndpointTargetRole.
    /// </summary>
    public class DBProxyEndpointTargetRole : ConstantClass
    {

        /// <summary>
        /// Constant READ_ONLY for DBProxyEndpointTargetRole
        /// </summary>
        public static readonly DBProxyEndpointTargetRole READ_ONLY = new DBProxyEndpointTargetRole("READ_ONLY");
        /// <summary>
        /// Constant READ_WRITE for DBProxyEndpointTargetRole
        /// </summary>
        public static readonly DBProxyEndpointTargetRole READ_WRITE = new DBProxyEndpointTargetRole("READ_WRITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DBProxyEndpointTargetRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DBProxyEndpointTargetRole FindValue(string value)
        {
            return FindValue<DBProxyEndpointTargetRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DBProxyEndpointTargetRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DBProxyStatus.
    /// </summary>
    public class DBProxyStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for DBProxyStatus
        /// </summary>
        public static readonly DBProxyStatus Available = new DBProxyStatus("available");
        /// <summary>
        /// Constant Creating for DBProxyStatus
        /// </summary>
        public static readonly DBProxyStatus Creating = new DBProxyStatus("creating");
        /// <summary>
        /// Constant Deleting for DBProxyStatus
        /// </summary>
        public static readonly DBProxyStatus Deleting = new DBProxyStatus("deleting");
        /// <summary>
        /// Constant IncompatibleNetwork for DBProxyStatus
        /// </summary>
        public static readonly DBProxyStatus IncompatibleNetwork = new DBProxyStatus("incompatible-network");
        /// <summary>
        /// Constant InsufficientResourceLimits for DBProxyStatus
        /// </summary>
        public static readonly DBProxyStatus InsufficientResourceLimits = new DBProxyStatus("insufficient-resource-limits");
        /// <summary>
        /// Constant Modifying for DBProxyStatus
        /// </summary>
        public static readonly DBProxyStatus Modifying = new DBProxyStatus("modifying");
        /// <summary>
        /// Constant Reactivating for DBProxyStatus
        /// </summary>
        public static readonly DBProxyStatus Reactivating = new DBProxyStatus("reactivating");
        /// <summary>
        /// Constant Suspended for DBProxyStatus
        /// </summary>
        public static readonly DBProxyStatus Suspended = new DBProxyStatus("suspended");
        /// <summary>
        /// Constant Suspending for DBProxyStatus
        /// </summary>
        public static readonly DBProxyStatus Suspending = new DBProxyStatus("suspending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DBProxyStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DBProxyStatus FindValue(string value)
        {
            return FindValue<DBProxyStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DBProxyStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DefaultAuthScheme.
    /// </summary>
    public class DefaultAuthScheme : ConstantClass
    {

        /// <summary>
        /// Constant IAM_AUTH for DefaultAuthScheme
        /// </summary>
        public static readonly DefaultAuthScheme IAM_AUTH = new DefaultAuthScheme("IAM_AUTH");
        /// <summary>
        /// Constant NONE for DefaultAuthScheme
        /// </summary>
        public static readonly DefaultAuthScheme NONE = new DefaultAuthScheme("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefaultAuthScheme(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefaultAuthScheme FindValue(string value)
        {
            return FindValue<DefaultAuthScheme>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefaultAuthScheme(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointNetworkType.
    /// </summary>
    public class EndpointNetworkType : ConstantClass
    {

        /// <summary>
        /// Constant DUAL for EndpointNetworkType
        /// </summary>
        public static readonly EndpointNetworkType DUAL = new EndpointNetworkType("DUAL");
        /// <summary>
        /// Constant IPV4 for EndpointNetworkType
        /// </summary>
        public static readonly EndpointNetworkType IPV4 = new EndpointNetworkType("IPV4");
        /// <summary>
        /// Constant IPV6 for EndpointNetworkType
        /// </summary>
        public static readonly EndpointNetworkType IPV6 = new EndpointNetworkType("IPV6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointNetworkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointNetworkType FindValue(string value)
        {
            return FindValue<EndpointNetworkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointNetworkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EngineFamily.
    /// </summary>
    public class EngineFamily : ConstantClass
    {

        /// <summary>
        /// Constant MYSQL for EngineFamily
        /// </summary>
        public static readonly EngineFamily MYSQL = new EngineFamily("MYSQL");
        /// <summary>
        /// Constant POSTGRESQL for EngineFamily
        /// </summary>
        public static readonly EngineFamily POSTGRESQL = new EngineFamily("POSTGRESQL");
        /// <summary>
        /// Constant SQLSERVER for EngineFamily
        /// </summary>
        public static readonly EngineFamily SQLSERVER = new EngineFamily("SQLSERVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EngineFamily(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EngineFamily FindValue(string value)
        {
            return FindValue<EngineFamily>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EngineFamily(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportSourceType.
    /// </summary>
    public class ExportSourceType : ConstantClass
    {

        /// <summary>
        /// Constant CLUSTER for ExportSourceType
        /// </summary>
        public static readonly ExportSourceType CLUSTER = new ExportSourceType("CLUSTER");
        /// <summary>
        /// Constant SNAPSHOT for ExportSourceType
        /// </summary>
        public static readonly ExportSourceType SNAPSHOT = new ExportSourceType("SNAPSHOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportSourceType FindValue(string value)
        {
            return FindValue<ExportSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailoverStatus.
    /// </summary>
    public class FailoverStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelling for FailoverStatus
        /// </summary>
        public static readonly FailoverStatus Cancelling = new FailoverStatus("cancelling");
        /// <summary>
        /// Constant FailingOver for FailoverStatus
        /// </summary>
        public static readonly FailoverStatus FailingOver = new FailoverStatus("failing-over");
        /// <summary>
        /// Constant Pending for FailoverStatus
        /// </summary>
        public static readonly FailoverStatus Pending = new FailoverStatus("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailoverStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailoverStatus FindValue(string value)
        {
            return FindValue<FailoverStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailoverStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GlobalClusterMemberSynchronizationStatus.
    /// </summary>
    public class GlobalClusterMemberSynchronizationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Connected for GlobalClusterMemberSynchronizationStatus
        /// </summary>
        public static readonly GlobalClusterMemberSynchronizationStatus Connected = new GlobalClusterMemberSynchronizationStatus("connected");
        /// <summary>
        /// Constant PendingResync for GlobalClusterMemberSynchronizationStatus
        /// </summary>
        public static readonly GlobalClusterMemberSynchronizationStatus PendingResync = new GlobalClusterMemberSynchronizationStatus("pending-resync");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlobalClusterMemberSynchronizationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlobalClusterMemberSynchronizationStatus FindValue(string value)
        {
            return FindValue<GlobalClusterMemberSynchronizationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlobalClusterMemberSynchronizationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IAMAuthMode.
    /// </summary>
    public class IAMAuthMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for IAMAuthMode
        /// </summary>
        public static readonly IAMAuthMode DISABLED = new IAMAuthMode("DISABLED");
        /// <summary>
        /// Constant ENABLED for IAMAuthMode
        /// </summary>
        public static readonly IAMAuthMode ENABLED = new IAMAuthMode("ENABLED");
        /// <summary>
        /// Constant REQUIRED for IAMAuthMode
        /// </summary>
        public static readonly IAMAuthMode REQUIRED = new IAMAuthMode("REQUIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IAMAuthMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IAMAuthMode FindValue(string value)
        {
            return FindValue<IAMAuthMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IAMAuthMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationStatus.
    /// </summary>
    public class IntegrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus Active = new IntegrationStatus("active");
        /// <summary>
        /// Constant Creating for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus Creating = new IntegrationStatus("creating");
        /// <summary>
        /// Constant Deleting for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus Deleting = new IntegrationStatus("deleting");
        /// <summary>
        /// Constant Failed for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus Failed = new IntegrationStatus("failed");
        /// <summary>
        /// Constant Modifying for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus Modifying = new IntegrationStatus("modifying");
        /// <summary>
        /// Constant Needs_attention for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus Needs_attention = new IntegrationStatus("needs_attention");
        /// <summary>
        /// Constant Syncing for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus Syncing = new IntegrationStatus("syncing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationStatus FindValue(string value)
        {
            return FindValue<IntegrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifecycleSupportName.
    /// </summary>
    public class LifecycleSupportName : ConstantClass
    {

        /// <summary>
        /// Constant OpenSourceRdsExtendedSupport for LifecycleSupportName
        /// </summary>
        public static readonly LifecycleSupportName OpenSourceRdsExtendedSupport = new LifecycleSupportName("open-source-rds-extended-support");
        /// <summary>
        /// Constant OpenSourceRdsStandardSupport for LifecycleSupportName
        /// </summary>
        public static readonly LifecycleSupportName OpenSourceRdsStandardSupport = new LifecycleSupportName("open-source-rds-standard-support");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecycleSupportName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecycleSupportName FindValue(string value)
        {
            return FindValue<LifecycleSupportName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecycleSupportName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LimitlessDatabaseStatus.
    /// </summary>
    public class LimitlessDatabaseStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for LimitlessDatabaseStatus
        /// </summary>
        public static readonly LimitlessDatabaseStatus Active = new LimitlessDatabaseStatus("active");
        /// <summary>
        /// Constant Disabled for LimitlessDatabaseStatus
        /// </summary>
        public static readonly LimitlessDatabaseStatus Disabled = new LimitlessDatabaseStatus("disabled");
        /// <summary>
        /// Constant Disabling for LimitlessDatabaseStatus
        /// </summary>
        public static readonly LimitlessDatabaseStatus Disabling = new LimitlessDatabaseStatus("disabling");
        /// <summary>
        /// Constant Enabled for LimitlessDatabaseStatus
        /// </summary>
        public static readonly LimitlessDatabaseStatus Enabled = new LimitlessDatabaseStatus("enabled");
        /// <summary>
        /// Constant Enabling for LimitlessDatabaseStatus
        /// </summary>
        public static readonly LimitlessDatabaseStatus Enabling = new LimitlessDatabaseStatus("enabling");
        /// <summary>
        /// Constant Error for LimitlessDatabaseStatus
        /// </summary>
        public static readonly LimitlessDatabaseStatus Error = new LimitlessDatabaseStatus("error");
        /// <summary>
        /// Constant ModifyingMaxCapacity for LimitlessDatabaseStatus
        /// </summary>
        public static readonly LimitlessDatabaseStatus ModifyingMaxCapacity = new LimitlessDatabaseStatus("modifying-max-capacity");
        /// <summary>
        /// Constant NotInUse for LimitlessDatabaseStatus
        /// </summary>
        public static readonly LimitlessDatabaseStatus NotInUse = new LimitlessDatabaseStatus("not-in-use");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LimitlessDatabaseStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LimitlessDatabaseStatus FindValue(string value)
        {
            return FindValue<LimitlessDatabaseStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LimitlessDatabaseStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocalWriteForwardingStatus.
    /// </summary>
    public class LocalWriteForwardingStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for LocalWriteForwardingStatus
        /// </summary>
        public static readonly LocalWriteForwardingStatus Disabled = new LocalWriteForwardingStatus("disabled");
        /// <summary>
        /// Constant Disabling for LocalWriteForwardingStatus
        /// </summary>
        public static readonly LocalWriteForwardingStatus Disabling = new LocalWriteForwardingStatus("disabling");
        /// <summary>
        /// Constant Enabled for LocalWriteForwardingStatus
        /// </summary>
        public static readonly LocalWriteForwardingStatus Enabled = new LocalWriteForwardingStatus("enabled");
        /// <summary>
        /// Constant Enabling for LocalWriteForwardingStatus
        /// </summary>
        public static readonly LocalWriteForwardingStatus Enabling = new LocalWriteForwardingStatus("enabling");
        /// <summary>
        /// Constant Requested for LocalWriteForwardingStatus
        /// </summary>
        public static readonly LocalWriteForwardingStatus Requested = new LocalWriteForwardingStatus("requested");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocalWriteForwardingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocalWriteForwardingStatus FindValue(string value)
        {
            return FindValue<LocalWriteForwardingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocalWriteForwardingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MasterUserAuthenticationType.
    /// </summary>
    public class MasterUserAuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant IamDbAuth for MasterUserAuthenticationType
        /// </summary>
        public static readonly MasterUserAuthenticationType IamDbAuth = new MasterUserAuthenticationType("iam-db-auth");
        /// <summary>
        /// Constant Password for MasterUserAuthenticationType
        /// </summary>
        public static readonly MasterUserAuthenticationType Password = new MasterUserAuthenticationType("password");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MasterUserAuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MasterUserAuthenticationType FindValue(string value)
        {
            return FindValue<MasterUserAuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MasterUserAuthenticationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicaMode.
    /// </summary>
    public class ReplicaMode : ConstantClass
    {

        /// <summary>
        /// Constant Mounted for ReplicaMode
        /// </summary>
        public static readonly ReplicaMode Mounted = new ReplicaMode("mounted");
        /// <summary>
        /// Constant OpenReadOnly for ReplicaMode
        /// </summary>
        public static readonly ReplicaMode OpenReadOnly = new ReplicaMode("open-read-only");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicaMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicaMode FindValue(string value)
        {
            return FindValue<ReplicaMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicaMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant BlueGreenDeployment for SourceType
        /// </summary>
        public static readonly SourceType BlueGreenDeployment = new SourceType("blue-green-deployment");
        /// <summary>
        /// Constant CustomEngineVersion for SourceType
        /// </summary>
        public static readonly SourceType CustomEngineVersion = new SourceType("custom-engine-version");
        /// <summary>
        /// Constant DbCluster for SourceType
        /// </summary>
        public static readonly SourceType DbCluster = new SourceType("db-cluster");
        /// <summary>
        /// Constant DbClusterSnapshot for SourceType
        /// </summary>
        public static readonly SourceType DbClusterSnapshot = new SourceType("db-cluster-snapshot");
        /// <summary>
        /// Constant DbInstance for SourceType
        /// </summary>
        public static readonly SourceType DbInstance = new SourceType("db-instance");
        /// <summary>
        /// Constant DbParameterGroup for SourceType
        /// </summary>
        public static readonly SourceType DbParameterGroup = new SourceType("db-parameter-group");
        /// <summary>
        /// Constant DbProxy for SourceType
        /// </summary>
        public static readonly SourceType DbProxy = new SourceType("db-proxy");
        /// <summary>
        /// Constant DbSecurityGroup for SourceType
        /// </summary>
        public static readonly SourceType DbSecurityGroup = new SourceType("db-security-group");
        /// <summary>
        /// Constant DbShardGroup for SourceType
        /// </summary>
        public static readonly SourceType DbShardGroup = new SourceType("db-shard-group");
        /// <summary>
        /// Constant DbSnapshot for SourceType
        /// </summary>
        public static readonly SourceType DbSnapshot = new SourceType("db-snapshot");
        /// <summary>
        /// Constant ZeroEtl for SourceType
        /// </summary>
        public static readonly SourceType ZeroEtl = new SourceType("zero-etl");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetConnectionNetworkType.
    /// </summary>
    public class TargetConnectionNetworkType : ConstantClass
    {

        /// <summary>
        /// Constant IPV4 for TargetConnectionNetworkType
        /// </summary>
        public static readonly TargetConnectionNetworkType IPV4 = new TargetConnectionNetworkType("IPV4");
        /// <summary>
        /// Constant IPV6 for TargetConnectionNetworkType
        /// </summary>
        public static readonly TargetConnectionNetworkType IPV6 = new TargetConnectionNetworkType("IPV6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetConnectionNetworkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetConnectionNetworkType FindValue(string value)
        {
            return FindValue<TargetConnectionNetworkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetConnectionNetworkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetHealthReason.
    /// </summary>
    public class TargetHealthReason : ConstantClass
    {

        /// <summary>
        /// Constant AUTH_FAILURE for TargetHealthReason
        /// </summary>
        public static readonly TargetHealthReason AUTH_FAILURE = new TargetHealthReason("AUTH_FAILURE");
        /// <summary>
        /// Constant CONNECTION_FAILED for TargetHealthReason
        /// </summary>
        public static readonly TargetHealthReason CONNECTION_FAILED = new TargetHealthReason("CONNECTION_FAILED");
        /// <summary>
        /// Constant INVALID_REPLICATION_STATE for TargetHealthReason
        /// </summary>
        public static readonly TargetHealthReason INVALID_REPLICATION_STATE = new TargetHealthReason("INVALID_REPLICATION_STATE");
        /// <summary>
        /// Constant PENDING_PROXY_CAPACITY for TargetHealthReason
        /// </summary>
        public static readonly TargetHealthReason PENDING_PROXY_CAPACITY = new TargetHealthReason("PENDING_PROXY_CAPACITY");
        /// <summary>
        /// Constant PROMOTED for TargetHealthReason
        /// </summary>
        public static readonly TargetHealthReason PROMOTED = new TargetHealthReason("PROMOTED");
        /// <summary>
        /// Constant UNREACHABLE for TargetHealthReason
        /// </summary>
        public static readonly TargetHealthReason UNREACHABLE = new TargetHealthReason("UNREACHABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetHealthReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetHealthReason FindValue(string value)
        {
            return FindValue<TargetHealthReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetHealthReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetRole.
    /// </summary>
    public class TargetRole : ConstantClass
    {

        /// <summary>
        /// Constant READ_ONLY for TargetRole
        /// </summary>
        public static readonly TargetRole READ_ONLY = new TargetRole("READ_ONLY");
        /// <summary>
        /// Constant READ_WRITE for TargetRole
        /// </summary>
        public static readonly TargetRole READ_WRITE = new TargetRole("READ_WRITE");
        /// <summary>
        /// Constant UNKNOWN for TargetRole
        /// </summary>
        public static readonly TargetRole UNKNOWN = new TargetRole("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetRole FindValue(string value)
        {
            return FindValue<TargetRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetState.
    /// </summary>
    public class TargetState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for TargetState
        /// </summary>
        public static readonly TargetState AVAILABLE = new TargetState("AVAILABLE");
        /// <summary>
        /// Constant REGISTERING for TargetState
        /// </summary>
        public static readonly TargetState REGISTERING = new TargetState("REGISTERING");
        /// <summary>
        /// Constant UNAVAILABLE for TargetState
        /// </summary>
        public static readonly TargetState UNAVAILABLE = new TargetState("UNAVAILABLE");
        /// <summary>
        /// Constant UNUSED for TargetState
        /// </summary>
        public static readonly TargetState UNUSED = new TargetState("UNUSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetState FindValue(string value)
        {
            return FindValue<TargetState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetType.
    /// </summary>
    public class TargetType : ConstantClass
    {

        /// <summary>
        /// Constant RDS_INSTANCE for TargetType
        /// </summary>
        public static readonly TargetType RDS_INSTANCE = new TargetType("RDS_INSTANCE");
        /// <summary>
        /// Constant RDS_SERVERLESS_ENDPOINT for TargetType
        /// </summary>
        public static readonly TargetType RDS_SERVERLESS_ENDPOINT = new TargetType("RDS_SERVERLESS_ENDPOINT");
        /// <summary>
        /// Constant TRACKED_CLUSTER for TargetType
        /// </summary>
        public static readonly TargetType TRACKED_CLUSTER = new TargetType("TRACKED_CLUSTER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetType FindValue(string value)
        {
            return FindValue<TargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WriteForwardingStatus.
    /// </summary>
    public class WriteForwardingStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for WriteForwardingStatus
        /// </summary>
        public static readonly WriteForwardingStatus Disabled = new WriteForwardingStatus("disabled");
        /// <summary>
        /// Constant Disabling for WriteForwardingStatus
        /// </summary>
        public static readonly WriteForwardingStatus Disabling = new WriteForwardingStatus("disabling");
        /// <summary>
        /// Constant Enabled for WriteForwardingStatus
        /// </summary>
        public static readonly WriteForwardingStatus Enabled = new WriteForwardingStatus("enabled");
        /// <summary>
        /// Constant Enabling for WriteForwardingStatus
        /// </summary>
        public static readonly WriteForwardingStatus Enabling = new WriteForwardingStatus("enabling");
        /// <summary>
        /// Constant Unknown for WriteForwardingStatus
        /// </summary>
        public static readonly WriteForwardingStatus Unknown = new WriteForwardingStatus("unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WriteForwardingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WriteForwardingStatus FindValue(string value)
        {
            return FindValue<WriteForwardingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WriteForwardingStatus(string value)
        {
            return FindValue(value);
        }
    }

}