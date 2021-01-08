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
    /// Constants used for properties of type ConformancePackComplianceType.
    /// </summary>
    public class ConformancePackComplianceType : ConstantClass
    {

        /// <summary>
        /// Constant COMPLIANT for ConformancePackComplianceType
        /// </summary>
        public static readonly ConformancePackComplianceType COMPLIANT = new ConformancePackComplianceType("COMPLIANT");
        /// <summary>
        /// Constant NON_COMPLIANT for ConformancePackComplianceType
        /// </summary>
        public static readonly ConformancePackComplianceType NON_COMPLIANT = new ConformancePackComplianceType("NON_COMPLIANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConformancePackComplianceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConformancePackComplianceType FindValue(string value)
        {
            return FindValue<ConformancePackComplianceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConformancePackComplianceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConformancePackState.
    /// </summary>
    public class ConformancePackState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_COMPLETE for ConformancePackState
        /// </summary>
        public static readonly ConformancePackState CREATE_COMPLETE = new ConformancePackState("CREATE_COMPLETE");
        /// <summary>
        /// Constant CREATE_FAILED for ConformancePackState
        /// </summary>
        public static readonly ConformancePackState CREATE_FAILED = new ConformancePackState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for ConformancePackState
        /// </summary>
        public static readonly ConformancePackState CREATE_IN_PROGRESS = new ConformancePackState("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for ConformancePackState
        /// </summary>
        public static readonly ConformancePackState DELETE_FAILED = new ConformancePackState("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ConformancePackState
        /// </summary>
        public static readonly ConformancePackState DELETE_IN_PROGRESS = new ConformancePackState("DELETE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConformancePackState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConformancePackState FindValue(string value)
        {
            return FindValue<ConformancePackState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConformancePackState(string value)
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
    /// Constants used for properties of type MemberAccountRuleStatus.
    /// </summary>
    public class MemberAccountRuleStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for MemberAccountRuleStatus
        /// </summary>
        public static readonly MemberAccountRuleStatus CREATE_FAILED = new MemberAccountRuleStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for MemberAccountRuleStatus
        /// </summary>
        public static readonly MemberAccountRuleStatus CREATE_IN_PROGRESS = new MemberAccountRuleStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_SUCCESSFUL for MemberAccountRuleStatus
        /// </summary>
        public static readonly MemberAccountRuleStatus CREATE_SUCCESSFUL = new MemberAccountRuleStatus("CREATE_SUCCESSFUL");
        /// <summary>
        /// Constant DELETE_FAILED for MemberAccountRuleStatus
        /// </summary>
        public static readonly MemberAccountRuleStatus DELETE_FAILED = new MemberAccountRuleStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for MemberAccountRuleStatus
        /// </summary>
        public static readonly MemberAccountRuleStatus DELETE_IN_PROGRESS = new MemberAccountRuleStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_SUCCESSFUL for MemberAccountRuleStatus
        /// </summary>
        public static readonly MemberAccountRuleStatus DELETE_SUCCESSFUL = new MemberAccountRuleStatus("DELETE_SUCCESSFUL");
        /// <summary>
        /// Constant UPDATE_FAILED for MemberAccountRuleStatus
        /// </summary>
        public static readonly MemberAccountRuleStatus UPDATE_FAILED = new MemberAccountRuleStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for MemberAccountRuleStatus
        /// </summary>
        public static readonly MemberAccountRuleStatus UPDATE_IN_PROGRESS = new MemberAccountRuleStatus("UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_SUCCESSFUL for MemberAccountRuleStatus
        /// </summary>
        public static readonly MemberAccountRuleStatus UPDATE_SUCCESSFUL = new MemberAccountRuleStatus("UPDATE_SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberAccountRuleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberAccountRuleStatus FindValue(string value)
        {
            return FindValue<MemberAccountRuleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberAccountRuleStatus(string value)
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
    /// Constants used for properties of type OrganizationConfigRuleTriggerType.
    /// </summary>
    public class OrganizationConfigRuleTriggerType : ConstantClass
    {

        /// <summary>
        /// Constant ConfigurationItemChangeNotification for OrganizationConfigRuleTriggerType
        /// </summary>
        public static readonly OrganizationConfigRuleTriggerType ConfigurationItemChangeNotification = new OrganizationConfigRuleTriggerType("ConfigurationItemChangeNotification");
        /// <summary>
        /// Constant OversizedConfigurationItemChangeNotification for OrganizationConfigRuleTriggerType
        /// </summary>
        public static readonly OrganizationConfigRuleTriggerType OversizedConfigurationItemChangeNotification = new OrganizationConfigRuleTriggerType("OversizedConfigurationItemChangeNotification");
        /// <summary>
        /// Constant ScheduledNotification for OrganizationConfigRuleTriggerType
        /// </summary>
        public static readonly OrganizationConfigRuleTriggerType ScheduledNotification = new OrganizationConfigRuleTriggerType("ScheduledNotification");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationConfigRuleTriggerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationConfigRuleTriggerType FindValue(string value)
        {
            return FindValue<OrganizationConfigRuleTriggerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationConfigRuleTriggerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrganizationResourceDetailedStatus.
    /// </summary>
    public class OrganizationResourceDetailedStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for OrganizationResourceDetailedStatus
        /// </summary>
        public static readonly OrganizationResourceDetailedStatus CREATE_FAILED = new OrganizationResourceDetailedStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for OrganizationResourceDetailedStatus
        /// </summary>
        public static readonly OrganizationResourceDetailedStatus CREATE_IN_PROGRESS = new OrganizationResourceDetailedStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_SUCCESSFUL for OrganizationResourceDetailedStatus
        /// </summary>
        public static readonly OrganizationResourceDetailedStatus CREATE_SUCCESSFUL = new OrganizationResourceDetailedStatus("CREATE_SUCCESSFUL");
        /// <summary>
        /// Constant DELETE_FAILED for OrganizationResourceDetailedStatus
        /// </summary>
        public static readonly OrganizationResourceDetailedStatus DELETE_FAILED = new OrganizationResourceDetailedStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for OrganizationResourceDetailedStatus
        /// </summary>
        public static readonly OrganizationResourceDetailedStatus DELETE_IN_PROGRESS = new OrganizationResourceDetailedStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_SUCCESSFUL for OrganizationResourceDetailedStatus
        /// </summary>
        public static readonly OrganizationResourceDetailedStatus DELETE_SUCCESSFUL = new OrganizationResourceDetailedStatus("DELETE_SUCCESSFUL");
        /// <summary>
        /// Constant UPDATE_FAILED for OrganizationResourceDetailedStatus
        /// </summary>
        public static readonly OrganizationResourceDetailedStatus UPDATE_FAILED = new OrganizationResourceDetailedStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for OrganizationResourceDetailedStatus
        /// </summary>
        public static readonly OrganizationResourceDetailedStatus UPDATE_IN_PROGRESS = new OrganizationResourceDetailedStatus("UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_SUCCESSFUL for OrganizationResourceDetailedStatus
        /// </summary>
        public static readonly OrganizationResourceDetailedStatus UPDATE_SUCCESSFUL = new OrganizationResourceDetailedStatus("UPDATE_SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationResourceDetailedStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationResourceDetailedStatus FindValue(string value)
        {
            return FindValue<OrganizationResourceDetailedStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationResourceDetailedStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrganizationResourceStatus.
    /// </summary>
    public class OrganizationResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for OrganizationResourceStatus
        /// </summary>
        public static readonly OrganizationResourceStatus CREATE_FAILED = new OrganizationResourceStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for OrganizationResourceStatus
        /// </summary>
        public static readonly OrganizationResourceStatus CREATE_IN_PROGRESS = new OrganizationResourceStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_SUCCESSFUL for OrganizationResourceStatus
        /// </summary>
        public static readonly OrganizationResourceStatus CREATE_SUCCESSFUL = new OrganizationResourceStatus("CREATE_SUCCESSFUL");
        /// <summary>
        /// Constant DELETE_FAILED for OrganizationResourceStatus
        /// </summary>
        public static readonly OrganizationResourceStatus DELETE_FAILED = new OrganizationResourceStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for OrganizationResourceStatus
        /// </summary>
        public static readonly OrganizationResourceStatus DELETE_IN_PROGRESS = new OrganizationResourceStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_SUCCESSFUL for OrganizationResourceStatus
        /// </summary>
        public static readonly OrganizationResourceStatus DELETE_SUCCESSFUL = new OrganizationResourceStatus("DELETE_SUCCESSFUL");
        /// <summary>
        /// Constant UPDATE_FAILED for OrganizationResourceStatus
        /// </summary>
        public static readonly OrganizationResourceStatus UPDATE_FAILED = new OrganizationResourceStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for OrganizationResourceStatus
        /// </summary>
        public static readonly OrganizationResourceStatus UPDATE_IN_PROGRESS = new OrganizationResourceStatus("UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_SUCCESSFUL for OrganizationResourceStatus
        /// </summary>
        public static readonly OrganizationResourceStatus UPDATE_SUCCESSFUL = new OrganizationResourceStatus("UPDATE_SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationResourceStatus FindValue(string value)
        {
            return FindValue<OrganizationResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrganizationRuleStatus.
    /// </summary>
    public class OrganizationRuleStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for OrganizationRuleStatus
        /// </summary>
        public static readonly OrganizationRuleStatus CREATE_FAILED = new OrganizationRuleStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for OrganizationRuleStatus
        /// </summary>
        public static readonly OrganizationRuleStatus CREATE_IN_PROGRESS = new OrganizationRuleStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_SUCCESSFUL for OrganizationRuleStatus
        /// </summary>
        public static readonly OrganizationRuleStatus CREATE_SUCCESSFUL = new OrganizationRuleStatus("CREATE_SUCCESSFUL");
        /// <summary>
        /// Constant DELETE_FAILED for OrganizationRuleStatus
        /// </summary>
        public static readonly OrganizationRuleStatus DELETE_FAILED = new OrganizationRuleStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for OrganizationRuleStatus
        /// </summary>
        public static readonly OrganizationRuleStatus DELETE_IN_PROGRESS = new OrganizationRuleStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_SUCCESSFUL for OrganizationRuleStatus
        /// </summary>
        public static readonly OrganizationRuleStatus DELETE_SUCCESSFUL = new OrganizationRuleStatus("DELETE_SUCCESSFUL");
        /// <summary>
        /// Constant UPDATE_FAILED for OrganizationRuleStatus
        /// </summary>
        public static readonly OrganizationRuleStatus UPDATE_FAILED = new OrganizationRuleStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for OrganizationRuleStatus
        /// </summary>
        public static readonly OrganizationRuleStatus UPDATE_IN_PROGRESS = new OrganizationRuleStatus("UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_SUCCESSFUL for OrganizationRuleStatus
        /// </summary>
        public static readonly OrganizationRuleStatus UPDATE_SUCCESSFUL = new OrganizationRuleStatus("UPDATE_SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationRuleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationRuleStatus FindValue(string value)
        {
            return FindValue<OrganizationRuleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationRuleStatus(string value)
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
    /// Constants used for properties of type RemediationExecutionState.
    /// </summary>
    public class RemediationExecutionState : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for RemediationExecutionState
        /// </summary>
        public static readonly RemediationExecutionState FAILED = new RemediationExecutionState("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for RemediationExecutionState
        /// </summary>
        public static readonly RemediationExecutionState IN_PROGRESS = new RemediationExecutionState("IN_PROGRESS");
        /// <summary>
        /// Constant QUEUED for RemediationExecutionState
        /// </summary>
        public static readonly RemediationExecutionState QUEUED = new RemediationExecutionState("QUEUED");
        /// <summary>
        /// Constant SUCCEEDED for RemediationExecutionState
        /// </summary>
        public static readonly RemediationExecutionState SUCCEEDED = new RemediationExecutionState("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RemediationExecutionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RemediationExecutionState FindValue(string value)
        {
            return FindValue<RemediationExecutionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RemediationExecutionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RemediationExecutionStepState.
    /// </summary>
    public class RemediationExecutionStepState : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for RemediationExecutionStepState
        /// </summary>
        public static readonly RemediationExecutionStepState FAILED = new RemediationExecutionStepState("FAILED");
        /// <summary>
        /// Constant PENDING for RemediationExecutionStepState
        /// </summary>
        public static readonly RemediationExecutionStepState PENDING = new RemediationExecutionStepState("PENDING");
        /// <summary>
        /// Constant SUCCEEDED for RemediationExecutionStepState
        /// </summary>
        public static readonly RemediationExecutionStepState SUCCEEDED = new RemediationExecutionStepState("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RemediationExecutionStepState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RemediationExecutionStepState FindValue(string value)
        {
            return FindValue<RemediationExecutionStepState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RemediationExecutionStepState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RemediationTargetType.
    /// </summary>
    public class RemediationTargetType : ConstantClass
    {

        /// <summary>
        /// Constant SSM_DOCUMENT for RemediationTargetType
        /// </summary>
        public static readonly RemediationTargetType SSM_DOCUMENT = new RemediationTargetType("SSM_DOCUMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RemediationTargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RemediationTargetType FindValue(string value)
        {
            return FindValue<RemediationTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RemediationTargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceCountGroupKey.
    /// </summary>
    public class ResourceCountGroupKey : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_ID for ResourceCountGroupKey
        /// </summary>
        public static readonly ResourceCountGroupKey ACCOUNT_ID = new ResourceCountGroupKey("ACCOUNT_ID");
        /// <summary>
        /// Constant AWS_REGION for ResourceCountGroupKey
        /// </summary>
        public static readonly ResourceCountGroupKey AWS_REGION = new ResourceCountGroupKey("AWS_REGION");
        /// <summary>
        /// Constant RESOURCE_TYPE for ResourceCountGroupKey
        /// </summary>
        public static readonly ResourceCountGroupKey RESOURCE_TYPE = new ResourceCountGroupKey("RESOURCE_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceCountGroupKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceCountGroupKey FindValue(string value)
        {
            return FindValue<ResourceCountGroupKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceCountGroupKey(string value)
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
        /// Constant AWSApiGatewayRestApi for ResourceType
        /// </summary>
        public static readonly ResourceType AWSApiGatewayRestApi = new ResourceType("AWS::ApiGateway::RestApi");
        /// <summary>
        /// Constant AWSApiGatewayStage for ResourceType
        /// </summary>
        public static readonly ResourceType AWSApiGatewayStage = new ResourceType("AWS::ApiGateway::Stage");
        /// <summary>
        /// Constant AWSApiGatewayV2Api for ResourceType
        /// </summary>
        public static readonly ResourceType AWSApiGatewayV2Api = new ResourceType("AWS::ApiGatewayV2::Api");
        /// <summary>
        /// Constant AWSApiGatewayV2Stage for ResourceType
        /// </summary>
        public static readonly ResourceType AWSApiGatewayV2Stage = new ResourceType("AWS::ApiGatewayV2::Stage");
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
        /// Constant AWSCodePipelinePipeline for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCodePipelinePipeline = new ResourceType("AWS::CodePipeline::Pipeline");
        /// <summary>
        /// Constant AWSConfigResourceCompliance for ResourceType
        /// </summary>
        public static readonly ResourceType AWSConfigResourceCompliance = new ResourceType("AWS::Config::ResourceCompliance");
        /// <summary>
        /// Constant AWSDynamoDBTable for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDynamoDBTable = new ResourceType("AWS::DynamoDB::Table");
        /// <summary>
        /// Constant AWSEC2CustomerGateway for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2CustomerGateway = new ResourceType("AWS::EC2::CustomerGateway");
        /// <summary>
        /// Constant AWSEC2EgressOnlyInternetGateway for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2EgressOnlyInternetGateway = new ResourceType("AWS::EC2::EgressOnlyInternetGateway");
        /// <summary>
        /// Constant AWSEC2EIP for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2EIP = new ResourceType("AWS::EC2::EIP");
        /// <summary>
        /// Constant AWSEC2FlowLog for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2FlowLog = new ResourceType("AWS::EC2::FlowLog");
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
        /// Constant AWSEC2NatGateway for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2NatGateway = new ResourceType("AWS::EC2::NatGateway");
        /// <summary>
        /// Constant AWSEC2NetworkAcl for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2NetworkAcl = new ResourceType("AWS::EC2::NetworkAcl");
        /// <summary>
        /// Constant AWSEC2NetworkInterface for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2NetworkInterface = new ResourceType("AWS::EC2::NetworkInterface");
        /// <summary>
        /// Constant AWSEC2RegisteredHAInstance for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2RegisteredHAInstance = new ResourceType("AWS::EC2::RegisteredHAInstance");
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
        /// Constant AWSEC2VPCEndpoint for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2VPCEndpoint = new ResourceType("AWS::EC2::VPCEndpoint");
        /// <summary>
        /// Constant AWSEC2VPCEndpointService for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2VPCEndpointService = new ResourceType("AWS::EC2::VPCEndpointService");
        /// <summary>
        /// Constant AWSEC2VPCPeeringConnection for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2VPCPeeringConnection = new ResourceType("AWS::EC2::VPCPeeringConnection");
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
        /// Constant AWSElasticsearchDomain for ResourceType
        /// </summary>
        public static readonly ResourceType AWSElasticsearchDomain = new ResourceType("AWS::Elasticsearch::Domain");
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
        /// Constant AWSKMSKey for ResourceType
        /// </summary>
        public static readonly ResourceType AWSKMSKey = new ResourceType("AWS::KMS::Key");
        /// <summary>
        /// Constant AWSLambdaFunction for ResourceType
        /// </summary>
        public static readonly ResourceType AWSLambdaFunction = new ResourceType("AWS::Lambda::Function");
        /// <summary>
        /// Constant AWSNetworkFirewallFirewall for ResourceType
        /// </summary>
        public static readonly ResourceType AWSNetworkFirewallFirewall = new ResourceType("AWS::NetworkFirewall::Firewall");
        /// <summary>
        /// Constant AWSNetworkFirewallFirewallPolicy for ResourceType
        /// </summary>
        public static readonly ResourceType AWSNetworkFirewallFirewallPolicy = new ResourceType("AWS::NetworkFirewall::FirewallPolicy");
        /// <summary>
        /// Constant AWSNetworkFirewallRuleGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSNetworkFirewallRuleGroup = new ResourceType("AWS::NetworkFirewall::RuleGroup");
        /// <summary>
        /// Constant AWSQLDBLedger for ResourceType
        /// </summary>
        public static readonly ResourceType AWSQLDBLedger = new ResourceType("AWS::QLDB::Ledger");
        /// <summary>
        /// Constant AWSRDSDBCluster for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRDSDBCluster = new ResourceType("AWS::RDS::DBCluster");
        /// <summary>
        /// Constant AWSRDSDBClusterSnapshot for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRDSDBClusterSnapshot = new ResourceType("AWS::RDS::DBClusterSnapshot");
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
        /// Constant AWSS3AccountPublicAccessBlock for ResourceType
        /// </summary>
        public static readonly ResourceType AWSS3AccountPublicAccessBlock = new ResourceType("AWS::S3::AccountPublicAccessBlock");
        /// <summary>
        /// Constant AWSS3Bucket for ResourceType
        /// </summary>
        public static readonly ResourceType AWSS3Bucket = new ResourceType("AWS::S3::Bucket");
        /// <summary>
        /// Constant AWSSecretsManagerSecret for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSecretsManagerSecret = new ResourceType("AWS::SecretsManager::Secret");
        /// <summary>
        /// Constant AWSServiceCatalogCloudFormationProduct for ResourceType
        /// </summary>
        public static readonly ResourceType AWSServiceCatalogCloudFormationProduct = new ResourceType("AWS::ServiceCatalog::CloudFormationProduct");
        /// <summary>
        /// Constant AWSServiceCatalogCloudFormationProvisionedProduct for ResourceType
        /// </summary>
        public static readonly ResourceType AWSServiceCatalogCloudFormationProvisionedProduct = new ResourceType("AWS::ServiceCatalog::CloudFormationProvisionedProduct");
        /// <summary>
        /// Constant AWSServiceCatalogPortfolio for ResourceType
        /// </summary>
        public static readonly ResourceType AWSServiceCatalogPortfolio = new ResourceType("AWS::ServiceCatalog::Portfolio");
        /// <summary>
        /// Constant AWSShieldProtection for ResourceType
        /// </summary>
        public static readonly ResourceType AWSShieldProtection = new ResourceType("AWS::Shield::Protection");
        /// <summary>
        /// Constant AWSShieldRegionalProtection for ResourceType
        /// </summary>
        public static readonly ResourceType AWSShieldRegionalProtection = new ResourceType("AWS::ShieldRegional::Protection");
        /// <summary>
        /// Constant AWSSNSTopic for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSNSTopic = new ResourceType("AWS::SNS::Topic");
        /// <summary>
        /// Constant AWSSQSQueue for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSQSQueue = new ResourceType("AWS::SQS::Queue");
        /// <summary>
        /// Constant AWSSSMAssociationCompliance for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSSMAssociationCompliance = new ResourceType("AWS::SSM::AssociationCompliance");
        /// <summary>
        /// Constant AWSSSMFileData for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSSMFileData = new ResourceType("AWS::SSM::FileData");
        /// <summary>
        /// Constant AWSSSMManagedInstanceInventory for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSSMManagedInstanceInventory = new ResourceType("AWS::SSM::ManagedInstanceInventory");
        /// <summary>
        /// Constant AWSSSMPatchCompliance for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSSMPatchCompliance = new ResourceType("AWS::SSM::PatchCompliance");
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
        /// Constant AWSWAFv2IPSet for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFv2IPSet = new ResourceType("AWS::WAFv2::IPSet");
        /// <summary>
        /// Constant AWSWAFv2ManagedRuleSet for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFv2ManagedRuleSet = new ResourceType("AWS::WAFv2::ManagedRuleSet");
        /// <summary>
        /// Constant AWSWAFv2RegexPatternSet for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFv2RegexPatternSet = new ResourceType("AWS::WAFv2::RegexPatternSet");
        /// <summary>
        /// Constant AWSWAFv2RuleGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFv2RuleGroup = new ResourceType("AWS::WAFv2::RuleGroup");
        /// <summary>
        /// Constant AWSWAFv2WebACL for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFv2WebACL = new ResourceType("AWS::WAFv2::WebACL");
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


    /// <summary>
    /// Constants used for properties of type ResourceValueType.
    /// </summary>
    public class ResourceValueType : ConstantClass
    {

        /// <summary>
        /// Constant RESOURCE_ID for ResourceValueType
        /// </summary>
        public static readonly ResourceValueType RESOURCE_ID = new ResourceValueType("RESOURCE_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceValueType FindValue(string value)
        {
            return FindValue<ResourceValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceValueType(string value)
        {
            return FindValue(value);
        }
    }

}