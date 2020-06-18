/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Constants used for properties of type IAMAuthMode.
    /// </summary>
    public class IAMAuthMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for IAMAuthMode
        /// </summary>
        public static readonly IAMAuthMode DISABLED = new IAMAuthMode("DISABLED");
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
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

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
        /// Constant DbSecurityGroup for SourceType
        /// </summary>
        public static readonly SourceType DbSecurityGroup = new SourceType("db-security-group");
        /// <summary>
        /// Constant DbSnapshot for SourceType
        /// </summary>
        public static readonly SourceType DbSnapshot = new SourceType("db-snapshot");

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
        /// Constant PENDING_PROXY_CAPACITY for TargetHealthReason
        /// </summary>
        public static readonly TargetHealthReason PENDING_PROXY_CAPACITY = new TargetHealthReason("PENDING_PROXY_CAPACITY");
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