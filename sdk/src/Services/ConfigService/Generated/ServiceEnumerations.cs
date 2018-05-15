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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ConfigService
{

    /// <summary>
    /// Constants used for properties of type AggregatedSourceStatusType.
    /// </summary>
    public class AggregatedSourceStatusType : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for AggregatedSourceStatusType
        /// </summary>
        public static readonly AggregatedSourceStatusType FAILED = new AggregatedSourceStatusType("FAILED");
        /// <summary>
        /// Constant OUTDATED for AggregatedSourceStatusType
        /// </summary>
        public static readonly AggregatedSourceStatusType OUTDATED = new AggregatedSourceStatusType("OUTDATED");
        /// <summary>
        /// Constant SUCCEEDED for AggregatedSourceStatusType
        /// </summary>
        public static readonly AggregatedSourceStatusType SUCCEEDED = new AggregatedSourceStatusType("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregatedSourceStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregatedSourceStatusType FindValue(string value)
        {
            return FindValue<AggregatedSourceStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregatedSourceStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AggregatedSourceType.
    /// </summary>
    public class AggregatedSourceType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for AggregatedSourceType
        /// </summary>
        public static readonly AggregatedSourceType ACCOUNT = new AggregatedSourceType("ACCOUNT");
        /// <summary>
        /// Constant ORGANIZATION for AggregatedSourceType
        /// </summary>
        public static readonly AggregatedSourceType ORGANIZATION = new AggregatedSourceType("ORGANIZATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregatedSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregatedSourceType FindValue(string value)
        {
            return FindValue<AggregatedSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregatedSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChronologicalOrder.
    /// </summary>
    public class ChronologicalOrder : ConstantClass
    {

        /// <summary>
        /// Constant Forward for ChronologicalOrder
        /// </summary>
        public static readonly ChronologicalOrder Forward = new ChronologicalOrder("Forward");
        /// <summary>
        /// Constant Reverse for ChronologicalOrder
        /// </summary>
        public static readonly ChronologicalOrder Reverse = new ChronologicalOrder("Reverse");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChronologicalOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChronologicalOrder FindValue(string value)
        {
            return FindValue<ChronologicalOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChronologicalOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComplianceType.
    /// </summary>
    public class ComplianceType : ConstantClass
    {

        /// <summary>
        /// Constant COMPLIANT for ComplianceType
        /// </summary>
        public static readonly ComplianceType COMPLIANT = new ComplianceType("COMPLIANT");
        /// <summary>
        /// Constant INSUFFICIENT_DATA for ComplianceType
        /// </summary>
        public static readonly ComplianceType INSUFFICIENT_DATA = new ComplianceType("INSUFFICIENT_DATA");
        /// <summary>
        /// Constant NON_COMPLIANT for ComplianceType
        /// </summary>
        public static readonly ComplianceType NON_COMPLIANT = new ComplianceType("NON_COMPLIANT");
        /// <summary>
        /// Constant NOT_APPLICABLE for ComplianceType
        /// </summary>
        public static readonly ComplianceType NOT_APPLICABLE = new ComplianceType("NOT_APPLICABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComplianceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComplianceType FindValue(string value)
        {
            return FindValue<ComplianceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComplianceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigRuleComplianceSummaryGroupKey.
    /// </summary>
    public class ConfigRuleComplianceSummaryGroupKey : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_ID for ConfigRuleComplianceSummaryGroupKey
        /// </summary>
        public static readonly ConfigRuleComplianceSummaryGroupKey ACCOUNT_ID = new ConfigRuleComplianceSummaryGroupKey("ACCOUNT_ID");
        /// <summary>
        /// Constant AWS_REGION for ConfigRuleComplianceSummaryGroupKey
        /// </summary>
        public static readonly ConfigRuleComplianceSummaryGroupKey AWS_REGION = new ConfigRuleComplianceSummaryGroupKey("AWS_REGION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigRuleComplianceSummaryGroupKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigRuleComplianceSummaryGroupKey FindValue(string value)
        {
            return FindValue<ConfigRuleComplianceSummaryGroupKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigRuleComplianceSummaryGroupKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigRuleState.
    /// </summary>
    public class ConfigRuleState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ConfigRuleState
        /// </summary>
        public static readonly ConfigRuleState ACTIVE = new ConfigRuleState("ACTIVE");
        /// <summary>
        /// Constant DELETING for ConfigRuleState
        /// </summary>
        public static readonly ConfigRuleState DELETING = new ConfigRuleState("DELETING");
        /// <summary>
        /// Constant DELETING_RESULTS for ConfigRuleState
        /// </summary>
        public static readonly ConfigRuleState DELETING_RESULTS = new ConfigRuleState("DELETING_RESULTS");
        /// <summary>
        /// Constant EVALUATING for ConfigRuleState
        /// </summary>
        public static readonly ConfigRuleState EVALUATING = new ConfigRuleState("EVALUATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigRuleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigRuleState FindValue(string value)
        {
            return FindValue<ConfigRuleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigRuleState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationItemStatus.
    /// </summary>
    public class ConfigurationItemStatus : ConstantClass
    {

        /// <summary>
        /// Constant OK for ConfigurationItemStatus
        /// </summary>
        public static readonly ConfigurationItemStatus OK = new ConfigurationItemStatus("OK");
        /// <summary>
        /// Constant ResourceDeleted for ConfigurationItemStatus
        /// </summary>
        public static readonly ConfigurationItemStatus ResourceDeleted = new ConfigurationItemStatus("ResourceDeleted");
        /// <summary>
        /// Constant ResourceDeletedNotRecorded for ConfigurationItemStatus
        /// </summary>
        public static readonly ConfigurationItemStatus ResourceDeletedNotRecorded = new ConfigurationItemStatus("ResourceDeletedNotRecorded");
        /// <summary>
        /// Constant ResourceDiscovered for ConfigurationItemStatus
        /// </summary>
        public static readonly ConfigurationItemStatus ResourceDiscovered = new ConfigurationItemStatus("ResourceDiscovered");
        /// <summary>
        /// Constant ResourceNotRecorded for ConfigurationItemStatus
        /// </summary>
        public static readonly ConfigurationItemStatus ResourceNotRecorded = new ConfigurationItemStatus("ResourceNotRecorded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationItemStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationItemStatus FindValue(string value)
        {
            return FindValue<ConfigurationItemStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationItemStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeliveryStatus.
    /// </summary>
    public class DeliveryStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failure for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus Failure = new DeliveryStatus("Failure");
        /// <summary>
        /// Constant Not_Applicable for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus Not_Applicable = new DeliveryStatus("Not_Applicable");
        /// <summary>
        /// Constant Success for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus Success = new DeliveryStatus("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeliveryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryStatus FindValue(string value)
        {
            return FindValue<DeliveryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventSource.
    /// </summary>
    public class EventSource : ConstantClass
    {

        /// <summary>
        /// Constant AwsConfig for EventSource
        /// </summary>
        public static readonly EventSource AwsConfig = new EventSource("aws.config");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSource FindValue(string value)
        {
            return FindValue<EventSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaximumExecutionFrequency.
    /// </summary>
    public class MaximumExecutionFrequency : ConstantClass
    {

        /// <summary>
        /// Constant One_Hour for MaximumExecutionFrequency
        /// </summary>
        public static readonly MaximumExecutionFrequency One_Hour = new MaximumExecutionFrequency("One_Hour");
        /// <summary>
        /// Constant Six_Hours for MaximumExecutionFrequency
        /// </summary>
        public static readonly MaximumExecutionFrequency Six_Hours = new MaximumExecutionFrequency("Six_Hours");
        /// <summary>
        /// Constant Three_Hours for MaximumExecutionFrequency
        /// </summary>
        public static readonly MaximumExecutionFrequency Three_Hours = new MaximumExecutionFrequency("Three_Hours");
        /// <summary>
        /// Constant Twelve_Hours for MaximumExecutionFrequency
        /// </summary>
        public static readonly MaximumExecutionFrequency Twelve_Hours = new MaximumExecutionFrequency("Twelve_Hours");
        /// <summary>
        /// Constant TwentyFour_Hours for MaximumExecutionFrequency
        /// </summary>
        public static readonly MaximumExecutionFrequency TwentyFour_Hours = new MaximumExecutionFrequency("TwentyFour_Hours");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaximumExecutionFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaximumExecutionFrequency FindValue(string value)
        {
            return FindValue<MaximumExecutionFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaximumExecutionFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageType.
    /// </summary>
    public class MessageType : ConstantClass
    {

        /// <summary>
        /// Constant ConfigurationItemChangeNotification for MessageType
        /// </summary>
        public static readonly MessageType ConfigurationItemChangeNotification = new MessageType("ConfigurationItemChangeNotification");
        /// <summary>
        /// Constant ConfigurationSnapshotDeliveryCompleted for MessageType
        /// </summary>
        public static readonly MessageType ConfigurationSnapshotDeliveryCompleted = new MessageType("ConfigurationSnapshotDeliveryCompleted");
        /// <summary>
        /// Constant OversizedConfigurationItemChangeNotification for MessageType
        /// </summary>
        public static readonly MessageType OversizedConfigurationItemChangeNotification = new MessageType("OversizedConfigurationItemChangeNotification");
        /// <summary>
        /// Constant ScheduledNotification for MessageType
        /// </summary>
        public static readonly MessageType ScheduledNotification = new MessageType("ScheduledNotification");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageType FindValue(string value)
        {
            return FindValue<MessageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Owner.
    /// </summary>
    public class Owner : ConstantClass
    {

        /// <summary>
        /// Constant AWS for Owner
        /// </summary>
        public static readonly Owner AWS = new Owner("AWS");
        /// <summary>
        /// Constant CUSTOM_LAMBDA for Owner
        /// </summary>
        public static readonly Owner CUSTOM_LAMBDA = new Owner("CUSTOM_LAMBDA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Owner(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Owner FindValue(string value)
        {
            return FindValue<Owner>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Owner(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecorderStatus.
    /// </summary>
    public class RecorderStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failure for RecorderStatus
        /// </summary>
        public static readonly RecorderStatus Failure = new RecorderStatus("Failure");
        /// <summary>
        /// Constant Pending for RecorderStatus
        /// </summary>
        public static readonly RecorderStatus Pending = new RecorderStatus("Pending");
        /// <summary>
        /// Constant Success for RecorderStatus
        /// </summary>
        public static readonly RecorderStatus Success = new RecorderStatus("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecorderStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecorderStatus FindValue(string value)
        {
            return FindValue<RecorderStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecorderStatus(string value)
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
        /// Constant AWSACMCertificate for ResourceType
        /// </summary>
        public static readonly ResourceType AWSACMCertificate = new ResourceType("AWS::ACM::Certificate");
        /// <summary>
        /// Constant AWSAutoScalingAutoScalingGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSAutoScalingAutoScalingGroup = new ResourceType("AWS::AutoScaling::AutoScalingGroup");
        /// <summary>
        /// Constant AWSAutoScalingLaunchConfiguration for ResourceType
        /// </summary>
        public static readonly ResourceType AWSAutoScalingLaunchConfiguration = new ResourceType("AWS::AutoScaling::LaunchConfiguration");
        /// <summary>
        /// Constant AWSAutoScalingScalingPolicy for ResourceType
        /// </summary>
        public static readonly ResourceType AWSAutoScalingScalingPolicy = new ResourceType("AWS::AutoScaling::ScalingPolicy");
        /// <summary>
        /// Constant AWSAutoScalingScheduledAction for ResourceType
        /// </summary>
        public static readonly ResourceType AWSAutoScalingScheduledAction = new ResourceType("AWS::AutoScaling::ScheduledAction");
        /// <summary>
        /// Constant AWSCloudFormationStack for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCloudFormationStack = new ResourceType("AWS::CloudFormation::Stack");
        /// <summary>
        /// Constant AWSCloudFrontDistribution for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCloudFrontDistribution = new ResourceType("AWS::CloudFront::Distribution");
        /// <summary>
        /// Constant AWSCloudFrontStreamingDistribution for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCloudFrontStreamingDistribution = new ResourceType("AWS::CloudFront::StreamingDistribution");
        /// <summary>
        /// Constant AWSCloudTrailTrail for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCloudTrailTrail = new ResourceType("AWS::CloudTrail::Trail");
        /// <summary>
        /// Constant AWSCloudWatchAlarm for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCloudWatchAlarm = new ResourceType("AWS::CloudWatch::Alarm");
        /// <summary>
        /// Constant AWSCodeBuildProject for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCodeBuildProject = new ResourceType("AWS::CodeBuild::Project");
        /// <summary>
        /// Constant AWSDynamoDBTable for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDynamoDBTable = new ResourceType("AWS::DynamoDB::Table");
        /// <summary>
        /// Constant AWSEC2CustomerGateway for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2CustomerGateway = new ResourceType("AWS::EC2::CustomerGateway");
        /// <summary>
        /// Constant AWSEC2EIP for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2EIP = new ResourceType("AWS::EC2::EIP");
        /// <summary>
        /// Constant AWSEC2Host for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2Host = new ResourceType("AWS::EC2::Host");
        /// <summary>
        /// Constant AWSEC2Instance for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2Instance = new ResourceType("AWS::EC2::Instance");
        /// <summary>
        /// Constant AWSEC2InternetGateway for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2InternetGateway = new ResourceType("AWS::EC2::InternetGateway");
        /// <summary>
        /// Constant AWSEC2NetworkAcl for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2NetworkAcl = new ResourceType("AWS::EC2::NetworkAcl");
        /// <summary>
        /// Constant AWSEC2NetworkInterface for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2NetworkInterface = new ResourceType("AWS::EC2::NetworkInterface");
        /// <summary>
        /// Constant AWSEC2RouteTable for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2RouteTable = new ResourceType("AWS::EC2::RouteTable");
        /// <summary>
        /// Constant AWSEC2SecurityGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2SecurityGroup = new ResourceType("AWS::EC2::SecurityGroup");
        /// <summary>
        /// Constant AWSEC2Subnet for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2Subnet = new ResourceType("AWS::EC2::Subnet");
        /// <summary>
        /// Constant AWSEC2Volume for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2Volume = new ResourceType("AWS::EC2::Volume");
        /// <summary>
        /// Constant AWSEC2VPC for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2VPC = new ResourceType("AWS::EC2::VPC");
        /// <summary>
        /// Constant AWSEC2VPNConnection for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2VPNConnection = new ResourceType("AWS::EC2::VPNConnection");
        /// <summary>
        /// Constant AWSEC2VPNGateway for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2VPNGateway = new ResourceType("AWS::EC2::VPNGateway");
        /// <summary>
        /// Constant AWSElasticBeanstalkApplication for ResourceType
        /// </summary>
        public static readonly ResourceType AWSElasticBeanstalkApplication = new ResourceType("AWS::ElasticBeanstalk::Application");
        /// <summary>
        /// Constant AWSElasticBeanstalkApplicationVersion for ResourceType
        /// </summary>
        public static readonly ResourceType AWSElasticBeanstalkApplicationVersion = new ResourceType("AWS::ElasticBeanstalk::ApplicationVersion");
        /// <summary>
        /// Constant AWSElasticBeanstalkEnvironment for ResourceType
        /// </summary>
        public static readonly ResourceType AWSElasticBeanstalkEnvironment = new ResourceType("AWS::ElasticBeanstalk::Environment");
        /// <summary>
        /// Constant AWSElasticLoadBalancingLoadBalancer for ResourceType
        /// </summary>
        public static readonly ResourceType AWSElasticLoadBalancingLoadBalancer = new ResourceType("AWS::ElasticLoadBalancing::LoadBalancer");
        /// <summary>
        /// Constant AWSElasticLoadBalancingV2LoadBalancer for ResourceType
        /// </summary>
        public static readonly ResourceType AWSElasticLoadBalancingV2LoadBalancer = new ResourceType("AWS::ElasticLoadBalancingV2::LoadBalancer");
        /// <summary>
        /// Constant AWSIAMGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIAMGroup = new ResourceType("AWS::IAM::Group");
        /// <summary>
        /// Constant AWSIAMPolicy for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIAMPolicy = new ResourceType("AWS::IAM::Policy");
        /// <summary>
        /// Constant AWSIAMRole for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIAMRole = new ResourceType("AWS::IAM::Role");
        /// <summary>
        /// Constant AWSIAMUser for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIAMUser = new ResourceType("AWS::IAM::User");
        /// <summary>
        /// Constant AWSLambdaFunction for ResourceType
        /// </summary>
        public static readonly ResourceType AWSLambdaFunction = new ResourceType("AWS::Lambda::Function");
        /// <summary>
        /// Constant AWSRDSDBInstance for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRDSDBInstance = new ResourceType("AWS::RDS::DBInstance");
        /// <summary>
        /// Constant AWSRDSDBSecurityGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRDSDBSecurityGroup = new ResourceType("AWS::RDS::DBSecurityGroup");
        /// <summary>
        /// Constant AWSRDSDBSnapshot for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRDSDBSnapshot = new ResourceType("AWS::RDS::DBSnapshot");
        /// <summary>
        /// Constant AWSRDSDBSubnetGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRDSDBSubnetGroup = new ResourceType("AWS::RDS::DBSubnetGroup");
        /// <summary>
        /// Constant AWSRDSEventSubscription for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRDSEventSubscription = new ResourceType("AWS::RDS::EventSubscription");
        /// <summary>
        /// Constant AWSRedshiftCluster for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRedshiftCluster = new ResourceType("AWS::Redshift::Cluster");
        /// <summary>
        /// Constant AWSRedshiftClusterParameterGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRedshiftClusterParameterGroup = new ResourceType("AWS::Redshift::ClusterParameterGroup");
        /// <summary>
        /// Constant AWSRedshiftClusterSecurityGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRedshiftClusterSecurityGroup = new ResourceType("AWS::Redshift::ClusterSecurityGroup");
        /// <summary>
        /// Constant AWSRedshiftClusterSnapshot for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRedshiftClusterSnapshot = new ResourceType("AWS::Redshift::ClusterSnapshot");
        /// <summary>
        /// Constant AWSRedshiftClusterSubnetGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRedshiftClusterSubnetGroup = new ResourceType("AWS::Redshift::ClusterSubnetGroup");
        /// <summary>
        /// Constant AWSRedshiftEventSubscription for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRedshiftEventSubscription = new ResourceType("AWS::Redshift::EventSubscription");
        /// <summary>
        /// Constant AWSS3Bucket for ResourceType
        /// </summary>
        public static readonly ResourceType AWSS3Bucket = new ResourceType("AWS::S3::Bucket");
        /// <summary>
        /// Constant AWSSSMManagedInstanceInventory for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSSMManagedInstanceInventory = new ResourceType("AWS::SSM::ManagedInstanceInventory");
        /// <summary>
        /// Constant AWSWAFRateBasedRule for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFRateBasedRule = new ResourceType("AWS::WAF::RateBasedRule");
        /// <summary>
        /// Constant AWSWAFRegionalRateBasedRule for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFRegionalRateBasedRule = new ResourceType("AWS::WAFRegional::RateBasedRule");
        /// <summary>
        /// Constant AWSWAFRegionalRule for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFRegionalRule = new ResourceType("AWS::WAFRegional::Rule");
        /// <summary>
        /// Constant AWSWAFRegionalRuleGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFRegionalRuleGroup = new ResourceType("AWS::WAFRegional::RuleGroup");
        /// <summary>
        /// Constant AWSWAFRegionalWebACL for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFRegionalWebACL = new ResourceType("AWS::WAFRegional::WebACL");
        /// <summary>
        /// Constant AWSWAFRule for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFRule = new ResourceType("AWS::WAF::Rule");
        /// <summary>
        /// Constant AWSWAFRuleGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFRuleGroup = new ResourceType("AWS::WAF::RuleGroup");
        /// <summary>
        /// Constant AWSWAFWebACL for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFWebACL = new ResourceType("AWS::WAF::WebACL");
        /// <summary>
        /// Constant AWSXRayEncryptionConfig for ResourceType
        /// </summary>
        public static readonly ResourceType AWSXRayEncryptionConfig = new ResourceType("AWS::XRay::EncryptionConfig");

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

}