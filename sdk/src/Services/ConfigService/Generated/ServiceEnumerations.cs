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
    /// Constants used for properties of type AggregateConformancePackComplianceSummaryGroupKey.
    /// </summary>
    public class AggregateConformancePackComplianceSummaryGroupKey : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_ID for AggregateConformancePackComplianceSummaryGroupKey
        /// </summary>
        public static readonly AggregateConformancePackComplianceSummaryGroupKey ACCOUNT_ID = new AggregateConformancePackComplianceSummaryGroupKey("ACCOUNT_ID");
        /// <summary>
        /// Constant AWS_REGION for AggregateConformancePackComplianceSummaryGroupKey
        /// </summary>
        public static readonly AggregateConformancePackComplianceSummaryGroupKey AWS_REGION = new AggregateConformancePackComplianceSummaryGroupKey("AWS_REGION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregateConformancePackComplianceSummaryGroupKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregateConformancePackComplianceSummaryGroupKey FindValue(string value)
        {
            return FindValue<AggregateConformancePackComplianceSummaryGroupKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregateConformancePackComplianceSummaryGroupKey(string value)
        {
            return FindValue(value);
        }
    }


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
        /// Constant INSUFFICIENT_DATA for ConformancePackComplianceType
        /// </summary>
        public static readonly ConformancePackComplianceType INSUFFICIENT_DATA = new ConformancePackComplianceType("INSUFFICIENT_DATA");
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
    /// Constants used for properties of type EvaluationMode.
    /// </summary>
    public class EvaluationMode : ConstantClass
    {

        /// <summary>
        /// Constant DETECTIVE for EvaluationMode
        /// </summary>
        public static readonly EvaluationMode DETECTIVE = new EvaluationMode("DETECTIVE");
        /// <summary>
        /// Constant PROACTIVE for EvaluationMode
        /// </summary>
        public static readonly EvaluationMode PROACTIVE = new EvaluationMode("PROACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationMode FindValue(string value)
        {
            return FindValue<EvaluationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationMode(string value)
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
    /// Constants used for properties of type OrganizationConfigRuleTriggerTypeNoSN.
    /// </summary>
    public class OrganizationConfigRuleTriggerTypeNoSN : ConstantClass
    {

        /// <summary>
        /// Constant ConfigurationItemChangeNotification for OrganizationConfigRuleTriggerTypeNoSN
        /// </summary>
        public static readonly OrganizationConfigRuleTriggerTypeNoSN ConfigurationItemChangeNotification = new OrganizationConfigRuleTriggerTypeNoSN("ConfigurationItemChangeNotification");
        /// <summary>
        /// Constant OversizedConfigurationItemChangeNotification for OrganizationConfigRuleTriggerTypeNoSN
        /// </summary>
        public static readonly OrganizationConfigRuleTriggerTypeNoSN OversizedConfigurationItemChangeNotification = new OrganizationConfigRuleTriggerTypeNoSN("OversizedConfigurationItemChangeNotification");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationConfigRuleTriggerTypeNoSN(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationConfigRuleTriggerTypeNoSN FindValue(string value)
        {
            return FindValue<OrganizationConfigRuleTriggerTypeNoSN>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationConfigRuleTriggerTypeNoSN(string value)
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
        /// Constant CUSTOM_POLICY for Owner
        /// </summary>
        public static readonly Owner CUSTOM_POLICY = new Owner("CUSTOM_POLICY");

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
    /// Constants used for properties of type ResourceConfigurationSchemaType.
    /// </summary>
    public class ResourceConfigurationSchemaType : ConstantClass
    {

        /// <summary>
        /// Constant CFN_RESOURCE_SCHEMA for ResourceConfigurationSchemaType
        /// </summary>
        public static readonly ResourceConfigurationSchemaType CFN_RESOURCE_SCHEMA = new ResourceConfigurationSchemaType("CFN_RESOURCE_SCHEMA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceConfigurationSchemaType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceConfigurationSchemaType FindValue(string value)
        {
            return FindValue<ResourceConfigurationSchemaType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceConfigurationSchemaType(string value)
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
    /// Constants used for properties of type ResourceEvaluationStatus.
    /// </summary>
    public class ResourceEvaluationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ResourceEvaluationStatus
        /// </summary>
        public static readonly ResourceEvaluationStatus FAILED = new ResourceEvaluationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ResourceEvaluationStatus
        /// </summary>
        public static readonly ResourceEvaluationStatus IN_PROGRESS = new ResourceEvaluationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for ResourceEvaluationStatus
        /// </summary>
        public static readonly ResourceEvaluationStatus SUCCEEDED = new ResourceEvaluationStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceEvaluationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceEvaluationStatus FindValue(string value)
        {
            return FindValue<ResourceEvaluationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceEvaluationStatus(string value)
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
        /// Constant AWSAccessAnalyzerAnalyzer for ResourceType
        /// </summary>
        public static readonly ResourceType AWSAccessAnalyzerAnalyzer = new ResourceType("AWS::AccessAnalyzer::Analyzer");
        /// <summary>
        /// Constant AWSACMCertificate for ResourceType
        /// </summary>
        public static readonly ResourceType AWSACMCertificate = new ResourceType("AWS::ACM::Certificate");
        /// <summary>
        /// Constant AWSAmazonMQBroker for ResourceType
        /// </summary>
        public static readonly ResourceType AWSAmazonMQBroker = new ResourceType("AWS::AmazonMQ::Broker");
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
        /// Constant AWSAppConfigApplication for ResourceType
        /// </summary>
        public static readonly ResourceType AWSAppConfigApplication = new ResourceType("AWS::AppConfig::Application");
        /// <summary>
        /// Constant AWSAppConfigConfigurationProfile for ResourceType
        /// </summary>
        public static readonly ResourceType AWSAppConfigConfigurationProfile = new ResourceType("AWS::AppConfig::ConfigurationProfile");
        /// <summary>
        /// Constant AWSAppConfigEnvironment for ResourceType
        /// </summary>
        public static readonly ResourceType AWSAppConfigEnvironment = new ResourceType("AWS::AppConfig::Environment");
        /// <summary>
        /// Constant AWSAppSyncGraphQLApi for ResourceType
        /// </summary>
        public static readonly ResourceType AWSAppSyncGraphQLApi = new ResourceType("AWS::AppSync::GraphQLApi");
        /// <summary>
        /// Constant AWSAthenaDataCatalog for ResourceType
        /// </summary>
        public static readonly ResourceType AWSAthenaDataCatalog = new ResourceType("AWS::Athena::DataCatalog");
        /// <summary>
        /// Constant AWSAthenaWorkGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSAthenaWorkGroup = new ResourceType("AWS::Athena::WorkGroup");
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
        /// Constant AWSBackupBackupPlan for ResourceType
        /// </summary>
        public static readonly ResourceType AWSBackupBackupPlan = new ResourceType("AWS::Backup::BackupPlan");
        /// <summary>
        /// Constant AWSBackupBackupSelection for ResourceType
        /// </summary>
        public static readonly ResourceType AWSBackupBackupSelection = new ResourceType("AWS::Backup::BackupSelection");
        /// <summary>
        /// Constant AWSBackupBackupVault for ResourceType
        /// </summary>
        public static readonly ResourceType AWSBackupBackupVault = new ResourceType("AWS::Backup::BackupVault");
        /// <summary>
        /// Constant AWSBackupRecoveryPoint for ResourceType
        /// </summary>
        public static readonly ResourceType AWSBackupRecoveryPoint = new ResourceType("AWS::Backup::RecoveryPoint");
        /// <summary>
        /// Constant AWSBackupReportPlan for ResourceType
        /// </summary>
        public static readonly ResourceType AWSBackupReportPlan = new ResourceType("AWS::Backup::ReportPlan");
        /// <summary>
        /// Constant AWSBatchComputeEnvironment for ResourceType
        /// </summary>
        public static readonly ResourceType AWSBatchComputeEnvironment = new ResourceType("AWS::Batch::ComputeEnvironment");
        /// <summary>
        /// Constant AWSBatchJobQueue for ResourceType
        /// </summary>
        public static readonly ResourceType AWSBatchJobQueue = new ResourceType("AWS::Batch::JobQueue");
        /// <summary>
        /// Constant AWSBudgetsBudgetsAction for ResourceType
        /// </summary>
        public static readonly ResourceType AWSBudgetsBudgetsAction = new ResourceType("AWS::Budgets::BudgetsAction");
        /// <summary>
        /// Constant AWSCloud9EnvironmentEC2 for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCloud9EnvironmentEC2 = new ResourceType("AWS::Cloud9::EnvironmentEC2");
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
        /// Constant AWSCodeDeployApplication for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCodeDeployApplication = new ResourceType("AWS::CodeDeploy::Application");
        /// <summary>
        /// Constant AWSCodeDeployDeploymentConfig for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCodeDeployDeploymentConfig = new ResourceType("AWS::CodeDeploy::DeploymentConfig");
        /// <summary>
        /// Constant AWSCodeDeployDeploymentGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCodeDeployDeploymentGroup = new ResourceType("AWS::CodeDeploy::DeploymentGroup");
        /// <summary>
        /// Constant AWSCodeGuruReviewerRepositoryAssociation for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCodeGuruReviewerRepositoryAssociation = new ResourceType("AWS::CodeGuruReviewer::RepositoryAssociation");
        /// <summary>
        /// Constant AWSCodePipelinePipeline for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCodePipelinePipeline = new ResourceType("AWS::CodePipeline::Pipeline");
        /// <summary>
        /// Constant AWSConfigConformancePackCompliance for ResourceType
        /// </summary>
        public static readonly ResourceType AWSConfigConformancePackCompliance = new ResourceType("AWS::Config::ConformancePackCompliance");
        /// <summary>
        /// Constant AWSConfigResourceCompliance for ResourceType
        /// </summary>
        public static readonly ResourceType AWSConfigResourceCompliance = new ResourceType("AWS::Config::ResourceCompliance");
        /// <summary>
        /// Constant AWSDataSyncLocationEFS for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDataSyncLocationEFS = new ResourceType("AWS::DataSync::LocationEFS");
        /// <summary>
        /// Constant AWSDataSyncLocationFSxLustre for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDataSyncLocationFSxLustre = new ResourceType("AWS::DataSync::LocationFSxLustre");
        /// <summary>
        /// Constant AWSDataSyncLocationFSxWindows for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDataSyncLocationFSxWindows = new ResourceType("AWS::DataSync::LocationFSxWindows");
        /// <summary>
        /// Constant AWSDataSyncLocationHDFS for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDataSyncLocationHDFS = new ResourceType("AWS::DataSync::LocationHDFS");
        /// <summary>
        /// Constant AWSDataSyncLocationNFS for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDataSyncLocationNFS = new ResourceType("AWS::DataSync::LocationNFS");
        /// <summary>
        /// Constant AWSDataSyncLocationObjectStorage for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDataSyncLocationObjectStorage = new ResourceType("AWS::DataSync::LocationObjectStorage");
        /// <summary>
        /// Constant AWSDataSyncLocationS3 for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDataSyncLocationS3 = new ResourceType("AWS::DataSync::LocationS3");
        /// <summary>
        /// Constant AWSDataSyncLocationSMB for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDataSyncLocationSMB = new ResourceType("AWS::DataSync::LocationSMB");
        /// <summary>
        /// Constant AWSDataSyncTask for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDataSyncTask = new ResourceType("AWS::DataSync::Task");
        /// <summary>
        /// Constant AWSDetectiveGraph for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDetectiveGraph = new ResourceType("AWS::Detective::Graph");
        /// <summary>
        /// Constant AWSDeviceFarmTestGridProject for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDeviceFarmTestGridProject = new ResourceType("AWS::DeviceFarm::TestGridProject");
        /// <summary>
        /// Constant AWSDMSCertificate for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDMSCertificate = new ResourceType("AWS::DMS::Certificate");
        /// <summary>
        /// Constant AWSDMSEventSubscription for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDMSEventSubscription = new ResourceType("AWS::DMS::EventSubscription");
        /// <summary>
        /// Constant AWSDMSReplicationSubnetGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDMSReplicationSubnetGroup = new ResourceType("AWS::DMS::ReplicationSubnetGroup");
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
        /// Constant AWSEC2LaunchTemplate for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2LaunchTemplate = new ResourceType("AWS::EC2::LaunchTemplate");
        /// <summary>
        /// Constant AWSEC2NatGateway for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2NatGateway = new ResourceType("AWS::EC2::NatGateway");
        /// <summary>
        /// Constant AWSEC2NetworkAcl for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2NetworkAcl = new ResourceType("AWS::EC2::NetworkAcl");
        /// <summary>
        /// Constant AWSEC2NetworkInsightsAccessScopeAnalysis for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2NetworkInsightsAccessScopeAnalysis = new ResourceType("AWS::EC2::NetworkInsightsAccessScopeAnalysis");
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
        /// Constant AWSEC2TrafficMirrorSession for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2TrafficMirrorSession = new ResourceType("AWS::EC2::TrafficMirrorSession");
        /// <summary>
        /// Constant AWSEC2TrafficMirrorTarget for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2TrafficMirrorTarget = new ResourceType("AWS::EC2::TrafficMirrorTarget");
        /// <summary>
        /// Constant AWSEC2TransitGateway for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2TransitGateway = new ResourceType("AWS::EC2::TransitGateway");
        /// <summary>
        /// Constant AWSEC2TransitGatewayAttachment for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2TransitGatewayAttachment = new ResourceType("AWS::EC2::TransitGatewayAttachment");
        /// <summary>
        /// Constant AWSEC2TransitGatewayRouteTable for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2TransitGatewayRouteTable = new ResourceType("AWS::EC2::TransitGatewayRouteTable");
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
        /// Constant AWSECRPublicRepository for ResourceType
        /// </summary>
        public static readonly ResourceType AWSECRPublicRepository = new ResourceType("AWS::ECR::PublicRepository");
        /// <summary>
        /// Constant AWSECRRegistryPolicy for ResourceType
        /// </summary>
        public static readonly ResourceType AWSECRRegistryPolicy = new ResourceType("AWS::ECR::RegistryPolicy");
        /// <summary>
        /// Constant AWSECRRepository for ResourceType
        /// </summary>
        public static readonly ResourceType AWSECRRepository = new ResourceType("AWS::ECR::Repository");
        /// <summary>
        /// Constant AWSECSCluster for ResourceType
        /// </summary>
        public static readonly ResourceType AWSECSCluster = new ResourceType("AWS::ECS::Cluster");
        /// <summary>
        /// Constant AWSECSService for ResourceType
        /// </summary>
        public static readonly ResourceType AWSECSService = new ResourceType("AWS::ECS::Service");
        /// <summary>
        /// Constant AWSECSTaskDefinition for ResourceType
        /// </summary>
        public static readonly ResourceType AWSECSTaskDefinition = new ResourceType("AWS::ECS::TaskDefinition");
        /// <summary>
        /// Constant AWSEFSAccessPoint for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEFSAccessPoint = new ResourceType("AWS::EFS::AccessPoint");
        /// <summary>
        /// Constant AWSEFSFileSystem for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEFSFileSystem = new ResourceType("AWS::EFS::FileSystem");
        /// <summary>
        /// Constant AWSEKSAddon for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEKSAddon = new ResourceType("AWS::EKS::Addon");
        /// <summary>
        /// Constant AWSEKSCluster for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEKSCluster = new ResourceType("AWS::EKS::Cluster");
        /// <summary>
        /// Constant AWSEKSFargateProfile for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEKSFargateProfile = new ResourceType("AWS::EKS::FargateProfile");
        /// <summary>
        /// Constant AWSEKSIdentityProviderConfig for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEKSIdentityProviderConfig = new ResourceType("AWS::EKS::IdentityProviderConfig");
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
        /// Constant AWSElasticLoadBalancingV2Listener for ResourceType
        /// </summary>
        public static readonly ResourceType AWSElasticLoadBalancingV2Listener = new ResourceType("AWS::ElasticLoadBalancingV2::Listener");
        /// <summary>
        /// Constant AWSElasticLoadBalancingV2LoadBalancer for ResourceType
        /// </summary>
        public static readonly ResourceType AWSElasticLoadBalancingV2LoadBalancer = new ResourceType("AWS::ElasticLoadBalancingV2::LoadBalancer");
        /// <summary>
        /// Constant AWSElasticsearchDomain for ResourceType
        /// </summary>
        public static readonly ResourceType AWSElasticsearchDomain = new ResourceType("AWS::Elasticsearch::Domain");
        /// <summary>
        /// Constant AWSEMRSecurityConfiguration for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEMRSecurityConfiguration = new ResourceType("AWS::EMR::SecurityConfiguration");
        /// <summary>
        /// Constant AWSEventsApiDestination for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEventsApiDestination = new ResourceType("AWS::Events::ApiDestination");
        /// <summary>
        /// Constant AWSEventsArchive for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEventsArchive = new ResourceType("AWS::Events::Archive");
        /// <summary>
        /// Constant AWSEventSchemasDiscoverer for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEventSchemasDiscoverer = new ResourceType("AWS::EventSchemas::Discoverer");
        /// <summary>
        /// Constant AWSEventSchemasRegistry for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEventSchemasRegistry = new ResourceType("AWS::EventSchemas::Registry");
        /// <summary>
        /// Constant AWSEventSchemasRegistryPolicy for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEventSchemasRegistryPolicy = new ResourceType("AWS::EventSchemas::RegistryPolicy");
        /// <summary>
        /// Constant AWSEventSchemasSchema for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEventSchemasSchema = new ResourceType("AWS::EventSchemas::Schema");
        /// <summary>
        /// Constant AWSEventsConnection for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEventsConnection = new ResourceType("AWS::Events::Connection");
        /// <summary>
        /// Constant AWSEventsEndpoint for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEventsEndpoint = new ResourceType("AWS::Events::Endpoint");
        /// <summary>
        /// Constant AWSEventsEventBus for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEventsEventBus = new ResourceType("AWS::Events::EventBus");
        /// <summary>
        /// Constant AWSFISExperimentTemplate for ResourceType
        /// </summary>
        public static readonly ResourceType AWSFISExperimentTemplate = new ResourceType("AWS::FIS::ExperimentTemplate");
        /// <summary>
        /// Constant AWSFraudDetectorEntityType for ResourceType
        /// </summary>
        public static readonly ResourceType AWSFraudDetectorEntityType = new ResourceType("AWS::FraudDetector::EntityType");
        /// <summary>
        /// Constant AWSFraudDetectorLabel for ResourceType
        /// </summary>
        public static readonly ResourceType AWSFraudDetectorLabel = new ResourceType("AWS::FraudDetector::Label");
        /// <summary>
        /// Constant AWSFraudDetectorOutcome for ResourceType
        /// </summary>
        public static readonly ResourceType AWSFraudDetectorOutcome = new ResourceType("AWS::FraudDetector::Outcome");
        /// <summary>
        /// Constant AWSFraudDetectorVariable for ResourceType
        /// </summary>
        public static readonly ResourceType AWSFraudDetectorVariable = new ResourceType("AWS::FraudDetector::Variable");
        /// <summary>
        /// Constant AWSGlobalAcceleratorAccelerator for ResourceType
        /// </summary>
        public static readonly ResourceType AWSGlobalAcceleratorAccelerator = new ResourceType("AWS::GlobalAccelerator::Accelerator");
        /// <summary>
        /// Constant AWSGlobalAcceleratorEndpointGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSGlobalAcceleratorEndpointGroup = new ResourceType("AWS::GlobalAccelerator::EndpointGroup");
        /// <summary>
        /// Constant AWSGlobalAcceleratorListener for ResourceType
        /// </summary>
        public static readonly ResourceType AWSGlobalAcceleratorListener = new ResourceType("AWS::GlobalAccelerator::Listener");
        /// <summary>
        /// Constant AWSGlueClassifier for ResourceType
        /// </summary>
        public static readonly ResourceType AWSGlueClassifier = new ResourceType("AWS::Glue::Classifier");
        /// <summary>
        /// Constant AWSGlueJob for ResourceType
        /// </summary>
        public static readonly ResourceType AWSGlueJob = new ResourceType("AWS::Glue::Job");
        /// <summary>
        /// Constant AWSGlueMLTransform for ResourceType
        /// </summary>
        public static readonly ResourceType AWSGlueMLTransform = new ResourceType("AWS::Glue::MLTransform");
        /// <summary>
        /// Constant AWSGuardDutyDetector for ResourceType
        /// </summary>
        public static readonly ResourceType AWSGuardDutyDetector = new ResourceType("AWS::GuardDuty::Detector");
        /// <summary>
        /// Constant AWSGuardDutyFilter for ResourceType
        /// </summary>
        public static readonly ResourceType AWSGuardDutyFilter = new ResourceType("AWS::GuardDuty::Filter");
        /// <summary>
        /// Constant AWSGuardDutyIPSet for ResourceType
        /// </summary>
        public static readonly ResourceType AWSGuardDutyIPSet = new ResourceType("AWS::GuardDuty::IPSet");
        /// <summary>
        /// Constant AWSGuardDutyThreatIntelSet for ResourceType
        /// </summary>
        public static readonly ResourceType AWSGuardDutyThreatIntelSet = new ResourceType("AWS::GuardDuty::ThreatIntelSet");
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
        /// Constant AWSImageBuilderContainerRecipe for ResourceType
        /// </summary>
        public static readonly ResourceType AWSImageBuilderContainerRecipe = new ResourceType("AWS::ImageBuilder::ContainerRecipe");
        /// <summary>
        /// Constant AWSImageBuilderDistributionConfiguration for ResourceType
        /// </summary>
        public static readonly ResourceType AWSImageBuilderDistributionConfiguration = new ResourceType("AWS::ImageBuilder::DistributionConfiguration");
        /// <summary>
        /// Constant AWSImageBuilderInfrastructureConfiguration for ResourceType
        /// </summary>
        public static readonly ResourceType AWSImageBuilderInfrastructureConfiguration = new ResourceType("AWS::ImageBuilder::InfrastructureConfiguration");
        /// <summary>
        /// Constant AWSIoTAccountAuditConfiguration for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTAccountAuditConfiguration = new ResourceType("AWS::IoT::AccountAuditConfiguration");
        /// <summary>
        /// Constant AWSIoTAnalyticsChannel for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTAnalyticsChannel = new ResourceType("AWS::IoTAnalytics::Channel");
        /// <summary>
        /// Constant AWSIoTAnalyticsDataset for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTAnalyticsDataset = new ResourceType("AWS::IoTAnalytics::Dataset");
        /// <summary>
        /// Constant AWSIoTAnalyticsDatastore for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTAnalyticsDatastore = new ResourceType("AWS::IoTAnalytics::Datastore");
        /// <summary>
        /// Constant AWSIoTAnalyticsPipeline for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTAnalyticsPipeline = new ResourceType("AWS::IoTAnalytics::Pipeline");
        /// <summary>
        /// Constant AWSIoTAuthorizer for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTAuthorizer = new ResourceType("AWS::IoT::Authorizer");
        /// <summary>
        /// Constant AWSIoTCustomMetric for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTCustomMetric = new ResourceType("AWS::IoT::CustomMetric");
        /// <summary>
        /// Constant AWSIoTDimension for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTDimension = new ResourceType("AWS::IoT::Dimension");
        /// <summary>
        /// Constant AWSIoTEventsAlarmModel for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTEventsAlarmModel = new ResourceType("AWS::IoTEvents::AlarmModel");
        /// <summary>
        /// Constant AWSIoTEventsDetectorModel for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTEventsDetectorModel = new ResourceType("AWS::IoTEvents::DetectorModel");
        /// <summary>
        /// Constant AWSIoTEventsInput for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTEventsInput = new ResourceType("AWS::IoTEvents::Input");
        /// <summary>
        /// Constant AWSIoTMitigationAction for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTMitigationAction = new ResourceType("AWS::IoT::MitigationAction");
        /// <summary>
        /// Constant AWSIoTPolicy for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTPolicy = new ResourceType("AWS::IoT::Policy");
        /// <summary>
        /// Constant AWSIoTRoleAlias for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTRoleAlias = new ResourceType("AWS::IoT::RoleAlias");
        /// <summary>
        /// Constant AWSIoTScheduledAudit for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTScheduledAudit = new ResourceType("AWS::IoT::ScheduledAudit");
        /// <summary>
        /// Constant AWSIoTSecurityProfile for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTSecurityProfile = new ResourceType("AWS::IoT::SecurityProfile");
        /// <summary>
        /// Constant AWSIoTSiteWiseAssetModel for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTSiteWiseAssetModel = new ResourceType("AWS::IoTSiteWise::AssetModel");
        /// <summary>
        /// Constant AWSIoTSiteWiseDashboard for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTSiteWiseDashboard = new ResourceType("AWS::IoTSiteWise::Dashboard");
        /// <summary>
        /// Constant AWSIoTSiteWiseGateway for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTSiteWiseGateway = new ResourceType("AWS::IoTSiteWise::Gateway");
        /// <summary>
        /// Constant AWSIoTSiteWisePortal for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTSiteWisePortal = new ResourceType("AWS::IoTSiteWise::Portal");
        /// <summary>
        /// Constant AWSIoTSiteWiseProject for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTSiteWiseProject = new ResourceType("AWS::IoTSiteWise::Project");
        /// <summary>
        /// Constant AWSIoTTwinMakerEntity for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTTwinMakerEntity = new ResourceType("AWS::IoTTwinMaker::Entity");
        /// <summary>
        /// Constant AWSIoTTwinMakerWorkspace for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIoTTwinMakerWorkspace = new ResourceType("AWS::IoTTwinMaker::Workspace");
        /// <summary>
        /// Constant AWSIVSChannel for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIVSChannel = new ResourceType("AWS::IVS::Channel");
        /// <summary>
        /// Constant AWSIVSPlaybackKeyPair for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIVSPlaybackKeyPair = new ResourceType("AWS::IVS::PlaybackKeyPair");
        /// <summary>
        /// Constant AWSIVSRecordingConfiguration for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIVSRecordingConfiguration = new ResourceType("AWS::IVS::RecordingConfiguration");
        /// <summary>
        /// Constant AWSKinesisAnalyticsV2Application for ResourceType
        /// </summary>
        public static readonly ResourceType AWSKinesisAnalyticsV2Application = new ResourceType("AWS::KinesisAnalyticsV2::Application");
        /// <summary>
        /// Constant AWSKinesisStream for ResourceType
        /// </summary>
        public static readonly ResourceType AWSKinesisStream = new ResourceType("AWS::Kinesis::Stream");
        /// <summary>
        /// Constant AWSKinesisStreamConsumer for ResourceType
        /// </summary>
        public static readonly ResourceType AWSKinesisStreamConsumer = new ResourceType("AWS::Kinesis::StreamConsumer");
        /// <summary>
        /// Constant AWSKMSKey for ResourceType
        /// </summary>
        public static readonly ResourceType AWSKMSKey = new ResourceType("AWS::KMS::Key");
        /// <summary>
        /// Constant AWSLambdaFunction for ResourceType
        /// </summary>
        public static readonly ResourceType AWSLambdaFunction = new ResourceType("AWS::Lambda::Function");
        /// <summary>
        /// Constant AWSLexBot for ResourceType
        /// </summary>
        public static readonly ResourceType AWSLexBot = new ResourceType("AWS::Lex::Bot");
        /// <summary>
        /// Constant AWSLexBotAlias for ResourceType
        /// </summary>
        public static readonly ResourceType AWSLexBotAlias = new ResourceType("AWS::Lex::BotAlias");
        /// <summary>
        /// Constant AWSLightsailBucket for ResourceType
        /// </summary>
        public static readonly ResourceType AWSLightsailBucket = new ResourceType("AWS::Lightsail::Bucket");
        /// <summary>
        /// Constant AWSLightsailCertificate for ResourceType
        /// </summary>
        public static readonly ResourceType AWSLightsailCertificate = new ResourceType("AWS::Lightsail::Certificate");
        /// <summary>
        /// Constant AWSLightsailDisk for ResourceType
        /// </summary>
        public static readonly ResourceType AWSLightsailDisk = new ResourceType("AWS::Lightsail::Disk");
        /// <summary>
        /// Constant AWSLightsailStaticIp for ResourceType
        /// </summary>
        public static readonly ResourceType AWSLightsailStaticIp = new ResourceType("AWS::Lightsail::StaticIp");
        /// <summary>
        /// Constant AWSLookoutMetricsAlert for ResourceType
        /// </summary>
        public static readonly ResourceType AWSLookoutMetricsAlert = new ResourceType("AWS::LookoutMetrics::Alert");
        /// <summary>
        /// Constant AWSMediaPackagePackagingConfiguration for ResourceType
        /// </summary>
        public static readonly ResourceType AWSMediaPackagePackagingConfiguration = new ResourceType("AWS::MediaPackage::PackagingConfiguration");
        /// <summary>
        /// Constant AWSMediaPackagePackagingGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSMediaPackagePackagingGroup = new ResourceType("AWS::MediaPackage::PackagingGroup");
        /// <summary>
        /// Constant AWSMSKCluster for ResourceType
        /// </summary>
        public static readonly ResourceType AWSMSKCluster = new ResourceType("AWS::MSK::Cluster");
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
        /// Constant AWSOpenSearchDomain for ResourceType
        /// </summary>
        public static readonly ResourceType AWSOpenSearchDomain = new ResourceType("AWS::OpenSearch::Domain");
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
        /// Constant AWSRDSGlobalCluster for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRDSGlobalCluster = new ResourceType("AWS::RDS::GlobalCluster");
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
        /// Constant AWSResilienceHubResiliencyPolicy for ResourceType
        /// </summary>
        public static readonly ResourceType AWSResilienceHubResiliencyPolicy = new ResourceType("AWS::ResilienceHub::ResiliencyPolicy");
        /// <summary>
        /// Constant AWSRoboMakerRobotApplicationVersion for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRoboMakerRobotApplicationVersion = new ResourceType("AWS::RoboMaker::RobotApplicationVersion");
        /// <summary>
        /// Constant AWSRoute53HostedZone for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRoute53HostedZone = new ResourceType("AWS::Route53::HostedZone");
        /// <summary>
        /// Constant AWSRoute53RecoveryReadinessCell for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRoute53RecoveryReadinessCell = new ResourceType("AWS::Route53RecoveryReadiness::Cell");
        /// <summary>
        /// Constant AWSRoute53RecoveryReadinessReadinessCheck for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRoute53RecoveryReadinessReadinessCheck = new ResourceType("AWS::Route53RecoveryReadiness::ReadinessCheck");
        /// <summary>
        /// Constant AWSRoute53RecoveryReadinessRecoveryGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRoute53RecoveryReadinessRecoveryGroup = new ResourceType("AWS::Route53RecoveryReadiness::RecoveryGroup");
        /// <summary>
        /// Constant AWSRoute53ResolverFirewallDomainList for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRoute53ResolverFirewallDomainList = new ResourceType("AWS::Route53Resolver::FirewallDomainList");
        /// <summary>
        /// Constant AWSRoute53ResolverResolverEndpoint for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRoute53ResolverResolverEndpoint = new ResourceType("AWS::Route53Resolver::ResolverEndpoint");
        /// <summary>
        /// Constant AWSRoute53ResolverResolverRule for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRoute53ResolverResolverRule = new ResourceType("AWS::Route53Resolver::ResolverRule");
        /// <summary>
        /// Constant AWSRoute53ResolverResolverRuleAssociation for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRoute53ResolverResolverRuleAssociation = new ResourceType("AWS::Route53Resolver::ResolverRuleAssociation");
        /// <summary>
        /// Constant AWSRUMAppMonitor for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRUMAppMonitor = new ResourceType("AWS::RUM::AppMonitor");
        /// <summary>
        /// Constant AWSS3AccountPublicAccessBlock for ResourceType
        /// </summary>
        public static readonly ResourceType AWSS3AccountPublicAccessBlock = new ResourceType("AWS::S3::AccountPublicAccessBlock");
        /// <summary>
        /// Constant AWSS3Bucket for ResourceType
        /// </summary>
        public static readonly ResourceType AWSS3Bucket = new ResourceType("AWS::S3::Bucket");
        /// <summary>
        /// Constant AWSS3MultiRegionAccessPoint for ResourceType
        /// </summary>
        public static readonly ResourceType AWSS3MultiRegionAccessPoint = new ResourceType("AWS::S3::MultiRegionAccessPoint");
        /// <summary>
        /// Constant AWSS3StorageLens for ResourceType
        /// </summary>
        public static readonly ResourceType AWSS3StorageLens = new ResourceType("AWS::S3::StorageLens");
        /// <summary>
        /// Constant AWSSageMakerCodeRepository for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSageMakerCodeRepository = new ResourceType("AWS::SageMaker::CodeRepository");
        /// <summary>
        /// Constant AWSSageMakerModel for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSageMakerModel = new ResourceType("AWS::SageMaker::Model");
        /// <summary>
        /// Constant AWSSageMakerNotebookInstanceLifecycleConfig for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSageMakerNotebookInstanceLifecycleConfig = new ResourceType("AWS::SageMaker::NotebookInstanceLifecycleConfig");
        /// <summary>
        /// Constant AWSSageMakerWorkteam for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSageMakerWorkteam = new ResourceType("AWS::SageMaker::Workteam");
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
        /// Constant AWSServiceDiscoveryHttpNamespace for ResourceType
        /// </summary>
        public static readonly ResourceType AWSServiceDiscoveryHttpNamespace = new ResourceType("AWS::ServiceDiscovery::HttpNamespace");
        /// <summary>
        /// Constant AWSServiceDiscoveryPublicDnsNamespace for ResourceType
        /// </summary>
        public static readonly ResourceType AWSServiceDiscoveryPublicDnsNamespace = new ResourceType("AWS::ServiceDiscovery::PublicDnsNamespace");
        /// <summary>
        /// Constant AWSServiceDiscoveryService for ResourceType
        /// </summary>
        public static readonly ResourceType AWSServiceDiscoveryService = new ResourceType("AWS::ServiceDiscovery::Service");
        /// <summary>
        /// Constant AWSSESConfigurationSet for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSESConfigurationSet = new ResourceType("AWS::SES::ConfigurationSet");
        /// <summary>
        /// Constant AWSSESContactList for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSESContactList = new ResourceType("AWS::SES::ContactList");
        /// <summary>
        /// Constant AWSSESReceiptFilter for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSESReceiptFilter = new ResourceType("AWS::SES::ReceiptFilter");
        /// <summary>
        /// Constant AWSSESReceiptRuleSet for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSESReceiptRuleSet = new ResourceType("AWS::SES::ReceiptRuleSet");
        /// <summary>
        /// Constant AWSSESTemplate for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSESTemplate = new ResourceType("AWS::SES::Template");
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
        /// Constant AWSStepFunctionsActivity for ResourceType
        /// </summary>
        public static readonly ResourceType AWSStepFunctionsActivity = new ResourceType("AWS::StepFunctions::Activity");
        /// <summary>
        /// Constant AWSStepFunctionsStateMachine for ResourceType
        /// </summary>
        public static readonly ResourceType AWSStepFunctionsStateMachine = new ResourceType("AWS::StepFunctions::StateMachine");
        /// <summary>
        /// Constant AWSTransferWorkflow for ResourceType
        /// </summary>
        public static readonly ResourceType AWSTransferWorkflow = new ResourceType("AWS::Transfer::Workflow");
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
        /// Constant AWSWorkSpacesConnectionAlias for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWorkSpacesConnectionAlias = new ResourceType("AWS::WorkSpaces::ConnectionAlias");
        /// <summary>
        /// Constant AWSWorkSpacesWorkspace for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWorkSpacesWorkspace = new ResourceType("AWS::WorkSpaces::Workspace");
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


    /// <summary>
    /// Constants used for properties of type SortBy.
    /// </summary>
    public class SortBy : ConstantClass
    {

        /// <summary>
        /// Constant SCORE for SortBy
        /// </summary>
        public static readonly SortBy SCORE = new SortBy("SCORE");

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
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

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

}