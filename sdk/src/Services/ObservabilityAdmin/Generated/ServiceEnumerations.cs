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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ObservabilityAdmin
{

    /// <summary>
    /// Constants used for properties of type CentralizationFailureReason.
    /// </summary>
    public class CentralizationFailureReason : ConstantClass
    {

        /// <summary>
        /// Constant DESTINATION_ACCOUNT_NOT_IN_ORGANIZATION for CentralizationFailureReason
        /// </summary>
        public static readonly CentralizationFailureReason DESTINATION_ACCOUNT_NOT_IN_ORGANIZATION = new CentralizationFailureReason("DESTINATION_ACCOUNT_NOT_IN_ORGANIZATION");
        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for CentralizationFailureReason
        /// </summary>
        public static readonly CentralizationFailureReason INTERNAL_SERVER_ERROR = new CentralizationFailureReason("INTERNAL_SERVER_ERROR");
        /// <summary>
        /// Constant TRUSTED_ACCESS_NOT_ENABLED for CentralizationFailureReason
        /// </summary>
        public static readonly CentralizationFailureReason TRUSTED_ACCESS_NOT_ENABLED = new CentralizationFailureReason("TRUSTED_ACCESS_NOT_ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CentralizationFailureReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CentralizationFailureReason FindValue(string value)
        {
            return FindValue<CentralizationFailureReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CentralizationFailureReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DestinationType.
    /// </summary>
    public class DestinationType : ConstantClass
    {

        /// <summary>
        /// Constant CloudWatchLogs for DestinationType
        /// </summary>
        public static readonly DestinationType CloudWatchLogs = new DestinationType("cloud-watch-logs");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DestinationType FindValue(string value)
        {
            return FindValue<DestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DestinationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptedLogGroupStrategy.
    /// </summary>
    public class EncryptedLogGroupStrategy : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for EncryptedLogGroupStrategy
        /// </summary>
        public static readonly EncryptedLogGroupStrategy ALLOW = new EncryptedLogGroupStrategy("ALLOW");
        /// <summary>
        /// Constant SKIP for EncryptedLogGroupStrategy
        /// </summary>
        public static readonly EncryptedLogGroupStrategy SKIP = new EncryptedLogGroupStrategy("SKIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptedLogGroupStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptedLogGroupStrategy FindValue(string value)
        {
            return FindValue<EncryptedLogGroupStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptedLogGroupStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionConflictResolutionStrategy.
    /// </summary>
    public class EncryptionConflictResolutionStrategy : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for EncryptionConflictResolutionStrategy
        /// </summary>
        public static readonly EncryptionConflictResolutionStrategy ALLOW = new EncryptionConflictResolutionStrategy("ALLOW");
        /// <summary>
        /// Constant SKIP for EncryptionConflictResolutionStrategy
        /// </summary>
        public static readonly EncryptionConflictResolutionStrategy SKIP = new EncryptionConflictResolutionStrategy("SKIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionConflictResolutionStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionConflictResolutionStrategy FindValue(string value)
        {
            return FindValue<EncryptionConflictResolutionStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionConflictResolutionStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionStrategy.
    /// </summary>
    public class EncryptionStrategy : ConstantClass
    {

        /// <summary>
        /// Constant AWS_OWNED for EncryptionStrategy
        /// </summary>
        public static readonly EncryptionStrategy AWS_OWNED = new EncryptionStrategy("AWS_OWNED");
        /// <summary>
        /// Constant CUSTOMER_MANAGED for EncryptionStrategy
        /// </summary>
        public static readonly EncryptionStrategy CUSTOMER_MANAGED = new EncryptionStrategy("CUSTOMER_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionStrategy FindValue(string value)
        {
            return FindValue<EncryptionStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionStrategy(string value)
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
        /// Constant AWSEC2Instance for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2Instance = new ResourceType("AWS::EC2::Instance");
        /// <summary>
        /// Constant AWSEC2VPC for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2VPC = new ResourceType("AWS::EC2::VPC");
        /// <summary>
        /// Constant AWSLambdaFunction for ResourceType
        /// </summary>
        public static readonly ResourceType AWSLambdaFunction = new ResourceType("AWS::Lambda::Function");

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
    /// Constants used for properties of type RuleHealth.
    /// </summary>
    public class RuleHealth : ConstantClass
    {

        /// <summary>
        /// Constant Healthy for RuleHealth
        /// </summary>
        public static readonly RuleHealth Healthy = new RuleHealth("Healthy");
        /// <summary>
        /// Constant Provisioning for RuleHealth
        /// </summary>
        public static readonly RuleHealth Provisioning = new RuleHealth("Provisioning");
        /// <summary>
        /// Constant Unhealthy for RuleHealth
        /// </summary>
        public static readonly RuleHealth Unhealthy = new RuleHealth("Unhealthy");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleHealth(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleHealth FindValue(string value)
        {
            return FindValue<RuleHealth>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleHealth(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant FAILED_START for Status
        /// </summary>
        public static readonly Status FAILED_START = new Status("FAILED_START");
        /// <summary>
        /// Constant FAILED_STOP for Status
        /// </summary>
        public static readonly Status FAILED_STOP = new Status("FAILED_STOP");
        /// <summary>
        /// Constant NOT_STARTED for Status
        /// </summary>
        public static readonly Status NOT_STARTED = new Status("NOT_STARTED");
        /// <summary>
        /// Constant RUNNING for Status
        /// </summary>
        public static readonly Status RUNNING = new Status("RUNNING");
        /// <summary>
        /// Constant STARTING for Status
        /// </summary>
        public static readonly Status STARTING = new Status("STARTING");
        /// <summary>
        /// Constant STOPPED for Status
        /// </summary>
        public static readonly Status STOPPED = new Status("STOPPED");
        /// <summary>
        /// Constant STOPPING for Status
        /// </summary>
        public static readonly Status STOPPING = new Status("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TelemetryState.
    /// </summary>
    public class TelemetryState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for TelemetryState
        /// </summary>
        public static readonly TelemetryState Disabled = new TelemetryState("Disabled");
        /// <summary>
        /// Constant Enabled for TelemetryState
        /// </summary>
        public static readonly TelemetryState Enabled = new TelemetryState("Enabled");
        /// <summary>
        /// Constant NotApplicable for TelemetryState
        /// </summary>
        public static readonly TelemetryState NotApplicable = new TelemetryState("NotApplicable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TelemetryState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TelemetryState FindValue(string value)
        {
            return FindValue<TelemetryState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TelemetryState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TelemetryType.
    /// </summary>
    public class TelemetryType : ConstantClass
    {

        /// <summary>
        /// Constant Logs for TelemetryType
        /// </summary>
        public static readonly TelemetryType Logs = new TelemetryType("Logs");
        /// <summary>
        /// Constant Metrics for TelemetryType
        /// </summary>
        public static readonly TelemetryType Metrics = new TelemetryType("Metrics");
        /// <summary>
        /// Constant Traces for TelemetryType
        /// </summary>
        public static readonly TelemetryType Traces = new TelemetryType("Traces");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TelemetryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TelemetryType FindValue(string value)
        {
            return FindValue<TelemetryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TelemetryType(string value)
        {
            return FindValue(value);
        }
    }

}