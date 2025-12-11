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
    /// Constants used for properties of type Action.
    /// </summary>
    public class Action : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for Action
        /// </summary>
        public static readonly Action ALLOW = new Action("ALLOW");
        /// <summary>
        /// Constant BLOCK for Action
        /// </summary>
        public static readonly Action BLOCK = new Action("BLOCK");
        /// <summary>
        /// Constant CAPTCHA for Action
        /// </summary>
        public static readonly Action CAPTCHA = new Action("CAPTCHA");
        /// <summary>
        /// Constant CHALLENGE for Action
        /// </summary>
        public static readonly Action CHALLENGE = new Action("CHALLENGE");
        /// <summary>
        /// Constant COUNT for Action
        /// </summary>
        public static readonly Action COUNT = new Action("COUNT");
        /// <summary>
        /// Constant EXCLUDED_AS_COUNT for Action
        /// </summary>
        public static readonly Action EXCLUDED_AS_COUNT = new Action("EXCLUDED_AS_COUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Action(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Action FindValue(string value)
        {
            return FindValue<Action>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Action(string value)
        {
            return FindValue(value);
        }
    }


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
    /// Constants used for properties of type FilterBehavior.
    /// </summary>
    public class FilterBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DROP for FilterBehavior
        /// </summary>
        public static readonly FilterBehavior DROP = new FilterBehavior("DROP");
        /// <summary>
        /// Constant KEEP for FilterBehavior
        /// </summary>
        public static readonly FilterBehavior KEEP = new FilterBehavior("KEEP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterBehavior FindValue(string value)
        {
            return FindValue<FilterBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterRequirement.
    /// </summary>
    public class FilterRequirement : ConstantClass
    {

        /// <summary>
        /// Constant MEETS_ALL for FilterRequirement
        /// </summary>
        public static readonly FilterRequirement MEETS_ALL = new FilterRequirement("MEETS_ALL");
        /// <summary>
        /// Constant MEETS_ANY for FilterRequirement
        /// </summary>
        public static readonly FilterRequirement MEETS_ANY = new FilterRequirement("MEETS_ANY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterRequirement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterRequirement FindValue(string value)
        {
            return FindValue<FilterRequirement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterRequirement(string value)
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
        /// Constant ACTIVE for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus ACTIVE = new IntegrationStatus("ACTIVE");
        /// <summary>
        /// Constant DELETING for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus DELETING = new IntegrationStatus("DELETING");

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
    /// Constants used for properties of type LogType.
    /// </summary>
    public class LogType : ConstantClass
    {

        /// <summary>
        /// Constant APPLICATION_LOGS for LogType
        /// </summary>
        public static readonly LogType APPLICATION_LOGS = new LogType("APPLICATION_LOGS");
        /// <summary>
        /// Constant USAGE_LOGS for LogType
        /// </summary>
        public static readonly LogType USAGE_LOGS = new LogType("USAGE_LOGS");

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
    /// Constants used for properties of type OutputFormat.
    /// </summary>
    public class OutputFormat : ConstantClass
    {

        /// <summary>
        /// Constant Json for OutputFormat
        /// </summary>
        public static readonly OutputFormat Json = new OutputFormat("json");
        /// <summary>
        /// Constant Plain for OutputFormat
        /// </summary>
        public static readonly OutputFormat Plain = new OutputFormat("plain");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputFormat FindValue(string value)
        {
            return FindValue<OutputFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordFormat.
    /// </summary>
    public class RecordFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for RecordFormat
        /// </summary>
        public static readonly RecordFormat JSON = new RecordFormat("JSON");
        /// <summary>
        /// Constant STRING for RecordFormat
        /// </summary>
        public static readonly RecordFormat STRING = new RecordFormat("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordFormat FindValue(string value)
        {
            return FindValue<RecordFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordFormat(string value)
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
        /// Constant AWSBedrockAgentCoreBrowser for ResourceType
        /// </summary>
        public static readonly ResourceType AWSBedrockAgentCoreBrowser = new ResourceType("AWS::BedrockAgentCore::Browser");
        /// <summary>
        /// Constant AWSBedrockAgentCoreCodeInterpreter for ResourceType
        /// </summary>
        public static readonly ResourceType AWSBedrockAgentCoreCodeInterpreter = new ResourceType("AWS::BedrockAgentCore::CodeInterpreter");
        /// <summary>
        /// Constant AWSBedrockAgentCoreRuntime for ResourceType
        /// </summary>
        public static readonly ResourceType AWSBedrockAgentCoreRuntime = new ResourceType("AWS::BedrockAgentCore::Runtime");
        /// <summary>
        /// Constant AWSCloudTrail for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCloudTrail = new ResourceType("AWS::CloudTrail");
        /// <summary>
        /// Constant AWSEC2Instance for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2Instance = new ResourceType("AWS::EC2::Instance");
        /// <summary>
        /// Constant AWSEC2VPC for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2VPC = new ResourceType("AWS::EC2::VPC");
        /// <summary>
        /// Constant AWSEKSCluster for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEKSCluster = new ResourceType("AWS::EKS::Cluster");
        /// <summary>
        /// Constant AWSElasticLoadBalancingV2LoadBalancer for ResourceType
        /// </summary>
        public static readonly ResourceType AWSElasticLoadBalancingV2LoadBalancer = new ResourceType("AWS::ElasticLoadBalancingV2::LoadBalancer");
        /// <summary>
        /// Constant AWSLambdaFunction for ResourceType
        /// </summary>
        public static readonly ResourceType AWSLambdaFunction = new ResourceType("AWS::Lambda::Function");
        /// <summary>
        /// Constant AWSRoute53ResolverResolverEndpoint for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRoute53ResolverResolverEndpoint = new ResourceType("AWS::Route53Resolver::ResolverEndpoint");
        /// <summary>
        /// Constant AWSWAFv2WebACL for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFv2WebACL = new ResourceType("AWS::WAFv2::WebACL");

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
    /// Constants used for properties of type SSEAlgorithm.
    /// </summary>
    public class SSEAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant AES256 for SSEAlgorithm
        /// </summary>
        public static readonly SSEAlgorithm AES256 = new SSEAlgorithm("AES256");
        /// <summary>
        /// Constant AwsKms for SSEAlgorithm
        /// </summary>
        public static readonly SSEAlgorithm AwsKms = new SSEAlgorithm("aws:kms");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SSEAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SSEAlgorithm FindValue(string value)
        {
            return FindValue<SSEAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SSEAlgorithm(string value)
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
    /// Constants used for properties of type TelemetryEnrichmentStatus.
    /// </summary>
    public class TelemetryEnrichmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Impaired for TelemetryEnrichmentStatus
        /// </summary>
        public static readonly TelemetryEnrichmentStatus Impaired = new TelemetryEnrichmentStatus("Impaired");
        /// <summary>
        /// Constant Running for TelemetryEnrichmentStatus
        /// </summary>
        public static readonly TelemetryEnrichmentStatus Running = new TelemetryEnrichmentStatus("Running");
        /// <summary>
        /// Constant Stopped for TelemetryEnrichmentStatus
        /// </summary>
        public static readonly TelemetryEnrichmentStatus Stopped = new TelemetryEnrichmentStatus("Stopped");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TelemetryEnrichmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TelemetryEnrichmentStatus FindValue(string value)
        {
            return FindValue<TelemetryEnrichmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TelemetryEnrichmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TelemetryPipelineStatus.
    /// </summary>
    public class TelemetryPipelineStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TelemetryPipelineStatus
        /// </summary>
        public static readonly TelemetryPipelineStatus ACTIVE = new TelemetryPipelineStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for TelemetryPipelineStatus
        /// </summary>
        public static readonly TelemetryPipelineStatus CREATE_FAILED = new TelemetryPipelineStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for TelemetryPipelineStatus
        /// </summary>
        public static readonly TelemetryPipelineStatus CREATING = new TelemetryPipelineStatus("CREATING");
        /// <summary>
        /// Constant DELETING for TelemetryPipelineStatus
        /// </summary>
        public static readonly TelemetryPipelineStatus DELETING = new TelemetryPipelineStatus("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for TelemetryPipelineStatus
        /// </summary>
        public static readonly TelemetryPipelineStatus UPDATE_FAILED = new TelemetryPipelineStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for TelemetryPipelineStatus
        /// </summary>
        public static readonly TelemetryPipelineStatus UPDATING = new TelemetryPipelineStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TelemetryPipelineStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TelemetryPipelineStatus FindValue(string value)
        {
            return FindValue<TelemetryPipelineStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TelemetryPipelineStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TelemetrySourceType.
    /// </summary>
    public class TelemetrySourceType : ConstantClass
    {

        /// <summary>
        /// Constant EKS_API_LOGS for TelemetrySourceType
        /// </summary>
        public static readonly TelemetrySourceType EKS_API_LOGS = new TelemetrySourceType("EKS_API_LOGS");
        /// <summary>
        /// Constant EKS_AUDIT_LOGS for TelemetrySourceType
        /// </summary>
        public static readonly TelemetrySourceType EKS_AUDIT_LOGS = new TelemetrySourceType("EKS_AUDIT_LOGS");
        /// <summary>
        /// Constant EKS_AUTHENTICATOR_LOGS for TelemetrySourceType
        /// </summary>
        public static readonly TelemetrySourceType EKS_AUTHENTICATOR_LOGS = new TelemetrySourceType("EKS_AUTHENTICATOR_LOGS");
        /// <summary>
        /// Constant EKS_CONTROLLER_MANAGER_LOGS for TelemetrySourceType
        /// </summary>
        public static readonly TelemetrySourceType EKS_CONTROLLER_MANAGER_LOGS = new TelemetrySourceType("EKS_CONTROLLER_MANAGER_LOGS");
        /// <summary>
        /// Constant EKS_SCHEDULER_LOGS for TelemetrySourceType
        /// </summary>
        public static readonly TelemetrySourceType EKS_SCHEDULER_LOGS = new TelemetrySourceType("EKS_SCHEDULER_LOGS");
        /// <summary>
        /// Constant ROUTE53_RESOLVER_QUERY_LOGS for TelemetrySourceType
        /// </summary>
        public static readonly TelemetrySourceType ROUTE53_RESOLVER_QUERY_LOGS = new TelemetrySourceType("ROUTE53_RESOLVER_QUERY_LOGS");
        /// <summary>
        /// Constant VPC_FLOW_LOGS for TelemetrySourceType
        /// </summary>
        public static readonly TelemetrySourceType VPC_FLOW_LOGS = new TelemetrySourceType("VPC_FLOW_LOGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TelemetrySourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TelemetrySourceType FindValue(string value)
        {
            return FindValue<TelemetrySourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TelemetrySourceType(string value)
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


    /// <summary>
    /// Constants used for properties of type WAFLogType.
    /// </summary>
    public class WAFLogType : ConstantClass
    {

        /// <summary>
        /// Constant WAF_LOGS for WAFLogType
        /// </summary>
        public static readonly WAFLogType WAF_LOGS = new WAFLogType("WAF_LOGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WAFLogType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WAFLogType FindValue(string value)
        {
            return FindValue<WAFLogType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WAFLogType(string value)
        {
            return FindValue(value);
        }
    }

}