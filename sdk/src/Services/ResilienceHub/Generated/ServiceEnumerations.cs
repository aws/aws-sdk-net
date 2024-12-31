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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ResilienceHub
{

    /// <summary>
    /// Constants used for properties of type AlarmType.
    /// </summary>
    public class AlarmType : ConstantClass
    {

        /// <summary>
        /// Constant Canary for AlarmType
        /// </summary>
        public static readonly AlarmType Canary = new AlarmType("Canary");
        /// <summary>
        /// Constant Composite for AlarmType
        /// </summary>
        public static readonly AlarmType Composite = new AlarmType("Composite");
        /// <summary>
        /// Constant Event for AlarmType
        /// </summary>
        public static readonly AlarmType Event = new AlarmType("Event");
        /// <summary>
        /// Constant Logs for AlarmType
        /// </summary>
        public static readonly AlarmType Logs = new AlarmType("Logs");
        /// <summary>
        /// Constant Metric for AlarmType
        /// </summary>
        public static readonly AlarmType Metric = new AlarmType("Metric");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlarmType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlarmType FindValue(string value)
        {
            return FindValue<AlarmType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlarmType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppAssessmentScheduleType.
    /// </summary>
    public class AppAssessmentScheduleType : ConstantClass
    {

        /// <summary>
        /// Constant Daily for AppAssessmentScheduleType
        /// </summary>
        public static readonly AppAssessmentScheduleType Daily = new AppAssessmentScheduleType("Daily");
        /// <summary>
        /// Constant Disabled for AppAssessmentScheduleType
        /// </summary>
        public static readonly AppAssessmentScheduleType Disabled = new AppAssessmentScheduleType("Disabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppAssessmentScheduleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppAssessmentScheduleType FindValue(string value)
        {
            return FindValue<AppAssessmentScheduleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppAssessmentScheduleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppComplianceStatusType.
    /// </summary>
    public class AppComplianceStatusType : ConstantClass
    {

        /// <summary>
        /// Constant ChangesDetected for AppComplianceStatusType
        /// </summary>
        public static readonly AppComplianceStatusType ChangesDetected = new AppComplianceStatusType("ChangesDetected");
        /// <summary>
        /// Constant MissingPolicy for AppComplianceStatusType
        /// </summary>
        public static readonly AppComplianceStatusType MissingPolicy = new AppComplianceStatusType("MissingPolicy");
        /// <summary>
        /// Constant NotApplicable for AppComplianceStatusType
        /// </summary>
        public static readonly AppComplianceStatusType NotApplicable = new AppComplianceStatusType("NotApplicable");
        /// <summary>
        /// Constant NotAssessed for AppComplianceStatusType
        /// </summary>
        public static readonly AppComplianceStatusType NotAssessed = new AppComplianceStatusType("NotAssessed");
        /// <summary>
        /// Constant PolicyBreached for AppComplianceStatusType
        /// </summary>
        public static readonly AppComplianceStatusType PolicyBreached = new AppComplianceStatusType("PolicyBreached");
        /// <summary>
        /// Constant PolicyMet for AppComplianceStatusType
        /// </summary>
        public static readonly AppComplianceStatusType PolicyMet = new AppComplianceStatusType("PolicyMet");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppComplianceStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppComplianceStatusType FindValue(string value)
        {
            return FindValue<AppComplianceStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppComplianceStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppDriftStatusType.
    /// </summary>
    public class AppDriftStatusType : ConstantClass
    {

        /// <summary>
        /// Constant Detected for AppDriftStatusType
        /// </summary>
        public static readonly AppDriftStatusType Detected = new AppDriftStatusType("Detected");
        /// <summary>
        /// Constant NotChecked for AppDriftStatusType
        /// </summary>
        public static readonly AppDriftStatusType NotChecked = new AppDriftStatusType("NotChecked");
        /// <summary>
        /// Constant NotDetected for AppDriftStatusType
        /// </summary>
        public static readonly AppDriftStatusType NotDetected = new AppDriftStatusType("NotDetected");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppDriftStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppDriftStatusType FindValue(string value)
        {
            return FindValue<AppDriftStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppDriftStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppStatusType.
    /// </summary>
    public class AppStatusType : ConstantClass
    {

        /// <summary>
        /// Constant Active for AppStatusType
        /// </summary>
        public static readonly AppStatusType Active = new AppStatusType("Active");
        /// <summary>
        /// Constant Deleting for AppStatusType
        /// </summary>
        public static readonly AppStatusType Deleting = new AppStatusType("Deleting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppStatusType FindValue(string value)
        {
            return FindValue<AppStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssessmentInvoker.
    /// </summary>
    public class AssessmentInvoker : ConstantClass
    {

        /// <summary>
        /// Constant System for AssessmentInvoker
        /// </summary>
        public static readonly AssessmentInvoker System = new AssessmentInvoker("System");
        /// <summary>
        /// Constant User for AssessmentInvoker
        /// </summary>
        public static readonly AssessmentInvoker User = new AssessmentInvoker("User");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssessmentInvoker(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssessmentInvoker FindValue(string value)
        {
            return FindValue<AssessmentInvoker>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssessmentInvoker(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssessmentStatus.
    /// </summary>
    public class AssessmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus Failed = new AssessmentStatus("Failed");
        /// <summary>
        /// Constant InProgress for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus InProgress = new AssessmentStatus("InProgress");
        /// <summary>
        /// Constant Pending for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus Pending = new AssessmentStatus("Pending");
        /// <summary>
        /// Constant Success for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus Success = new AssessmentStatus("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssessmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssessmentStatus FindValue(string value)
        {
            return FindValue<AssessmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssessmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComplianceStatus.
    /// </summary>
    public class ComplianceStatus : ConstantClass
    {

        /// <summary>
        /// Constant MissingPolicy for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus MissingPolicy = new ComplianceStatus("MissingPolicy");
        /// <summary>
        /// Constant NotApplicable for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus NotApplicable = new ComplianceStatus("NotApplicable");
        /// <summary>
        /// Constant PolicyBreached for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus PolicyBreached = new ComplianceStatus("PolicyBreached");
        /// <summary>
        /// Constant PolicyMet for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus PolicyMet = new ComplianceStatus("PolicyMet");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComplianceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComplianceStatus FindValue(string value)
        {
            return FindValue<ComplianceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComplianceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConditionOperatorType.
    /// </summary>
    public class ConditionOperatorType : ConstantClass
    {

        /// <summary>
        /// Constant Equals for ConditionOperatorType
        /// </summary>
        public new static readonly ConditionOperatorType Equals = new ConditionOperatorType("Equals");
        /// <summary>
        /// Constant GreaterOrEquals for ConditionOperatorType
        /// </summary>
        public static readonly ConditionOperatorType GreaterOrEquals = new ConditionOperatorType("GreaterOrEquals");
        /// <summary>
        /// Constant GreaterThen for ConditionOperatorType
        /// </summary>
        public static readonly ConditionOperatorType GreaterThen = new ConditionOperatorType("GreaterThen");
        /// <summary>
        /// Constant LessOrEquals for ConditionOperatorType
        /// </summary>
        public static readonly ConditionOperatorType LessOrEquals = new ConditionOperatorType("LessOrEquals");
        /// <summary>
        /// Constant LessThen for ConditionOperatorType
        /// </summary>
        public static readonly ConditionOperatorType LessThen = new ConditionOperatorType("LessThen");
        /// <summary>
        /// Constant NotEquals for ConditionOperatorType
        /// </summary>
        public static readonly ConditionOperatorType NotEquals = new ConditionOperatorType("NotEquals");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConditionOperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConditionOperatorType FindValue(string value)
        {
            return FindValue<ConditionOperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConditionOperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigRecommendationOptimizationType.
    /// </summary>
    public class ConfigRecommendationOptimizationType : ConstantClass
    {

        /// <summary>
        /// Constant BestAttainable for ConfigRecommendationOptimizationType
        /// </summary>
        public static readonly ConfigRecommendationOptimizationType BestAttainable = new ConfigRecommendationOptimizationType("BestAttainable");
        /// <summary>
        /// Constant BestAZRecovery for ConfigRecommendationOptimizationType
        /// </summary>
        public static readonly ConfigRecommendationOptimizationType BestAZRecovery = new ConfigRecommendationOptimizationType("BestAZRecovery");
        /// <summary>
        /// Constant BestRegionRecovery for ConfigRecommendationOptimizationType
        /// </summary>
        public static readonly ConfigRecommendationOptimizationType BestRegionRecovery = new ConfigRecommendationOptimizationType("BestRegionRecovery");
        /// <summary>
        /// Constant LeastChange for ConfigRecommendationOptimizationType
        /// </summary>
        public static readonly ConfigRecommendationOptimizationType LeastChange = new ConfigRecommendationOptimizationType("LeastChange");
        /// <summary>
        /// Constant LeastCost for ConfigRecommendationOptimizationType
        /// </summary>
        public static readonly ConfigRecommendationOptimizationType LeastCost = new ConfigRecommendationOptimizationType("LeastCost");
        /// <summary>
        /// Constant LeastErrors for ConfigRecommendationOptimizationType
        /// </summary>
        public static readonly ConfigRecommendationOptimizationType LeastErrors = new ConfigRecommendationOptimizationType("LeastErrors");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigRecommendationOptimizationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigRecommendationOptimizationType FindValue(string value)
        {
            return FindValue<ConfigRecommendationOptimizationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigRecommendationOptimizationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CostFrequency.
    /// </summary>
    public class CostFrequency : ConstantClass
    {

        /// <summary>
        /// Constant Daily for CostFrequency
        /// </summary>
        public static readonly CostFrequency Daily = new CostFrequency("Daily");
        /// <summary>
        /// Constant Hourly for CostFrequency
        /// </summary>
        public static readonly CostFrequency Hourly = new CostFrequency("Hourly");
        /// <summary>
        /// Constant Monthly for CostFrequency
        /// </summary>
        public static readonly CostFrequency Monthly = new CostFrequency("Monthly");
        /// <summary>
        /// Constant Yearly for CostFrequency
        /// </summary>
        public static readonly CostFrequency Yearly = new CostFrequency("Yearly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CostFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CostFrequency FindValue(string value)
        {
            return FindValue<CostFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CostFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataLocationConstraint.
    /// </summary>
    public class DataLocationConstraint : ConstantClass
    {

        /// <summary>
        /// Constant AnyLocation for DataLocationConstraint
        /// </summary>
        public static readonly DataLocationConstraint AnyLocation = new DataLocationConstraint("AnyLocation");
        /// <summary>
        /// Constant SameContinent for DataLocationConstraint
        /// </summary>
        public static readonly DataLocationConstraint SameContinent = new DataLocationConstraint("SameContinent");
        /// <summary>
        /// Constant SameCountry for DataLocationConstraint
        /// </summary>
        public static readonly DataLocationConstraint SameCountry = new DataLocationConstraint("SameCountry");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataLocationConstraint(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataLocationConstraint FindValue(string value)
        {
            return FindValue<DataLocationConstraint>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataLocationConstraint(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DifferenceType.
    /// </summary>
    public class DifferenceType : ConstantClass
    {

        /// <summary>
        /// Constant Added for DifferenceType
        /// </summary>
        public static readonly DifferenceType Added = new DifferenceType("Added");
        /// <summary>
        /// Constant NotEqual for DifferenceType
        /// </summary>
        public static readonly DifferenceType NotEqual = new DifferenceType("NotEqual");
        /// <summary>
        /// Constant Removed for DifferenceType
        /// </summary>
        public static readonly DifferenceType Removed = new DifferenceType("Removed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DifferenceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DifferenceType FindValue(string value)
        {
            return FindValue<DifferenceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DifferenceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DisruptionType.
    /// </summary>
    public class DisruptionType : ConstantClass
    {

        /// <summary>
        /// Constant AZ for DisruptionType
        /// </summary>
        public static readonly DisruptionType AZ = new DisruptionType("AZ");
        /// <summary>
        /// Constant Hardware for DisruptionType
        /// </summary>
        public static readonly DisruptionType Hardware = new DisruptionType("Hardware");
        /// <summary>
        /// Constant Region for DisruptionType
        /// </summary>
        public static readonly DisruptionType Region = new DisruptionType("Region");
        /// <summary>
        /// Constant Software for DisruptionType
        /// </summary>
        public static readonly DisruptionType Software = new DisruptionType("Software");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DisruptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DisruptionType FindValue(string value)
        {
            return FindValue<DisruptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DisruptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DriftStatus.
    /// </summary>
    public class DriftStatus : ConstantClass
    {

        /// <summary>
        /// Constant Detected for DriftStatus
        /// </summary>
        public static readonly DriftStatus Detected = new DriftStatus("Detected");
        /// <summary>
        /// Constant NotChecked for DriftStatus
        /// </summary>
        public static readonly DriftStatus NotChecked = new DriftStatus("NotChecked");
        /// <summary>
        /// Constant NotDetected for DriftStatus
        /// </summary>
        public static readonly DriftStatus NotDetected = new DriftStatus("NotDetected");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DriftStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DriftStatus FindValue(string value)
        {
            return FindValue<DriftStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DriftStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DriftType.
    /// </summary>
    public class DriftType : ConstantClass
    {

        /// <summary>
        /// Constant AppComponentResiliencyComplianceStatus for DriftType
        /// </summary>
        public static readonly DriftType AppComponentResiliencyComplianceStatus = new DriftType("AppComponentResiliencyComplianceStatus");
        /// <summary>
        /// Constant ApplicationCompliance for DriftType
        /// </summary>
        public static readonly DriftType ApplicationCompliance = new DriftType("ApplicationCompliance");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DriftType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DriftType FindValue(string value)
        {
            return FindValue<DriftType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DriftType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EstimatedCostTier.
    /// </summary>
    public class EstimatedCostTier : ConstantClass
    {

        /// <summary>
        /// Constant L1 for EstimatedCostTier
        /// </summary>
        public static readonly EstimatedCostTier L1 = new EstimatedCostTier("L1");
        /// <summary>
        /// Constant L2 for EstimatedCostTier
        /// </summary>
        public static readonly EstimatedCostTier L2 = new EstimatedCostTier("L2");
        /// <summary>
        /// Constant L3 for EstimatedCostTier
        /// </summary>
        public static readonly EstimatedCostTier L3 = new EstimatedCostTier("L3");
        /// <summary>
        /// Constant L4 for EstimatedCostTier
        /// </summary>
        public static readonly EstimatedCostTier L4 = new EstimatedCostTier("L4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EstimatedCostTier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EstimatedCostTier FindValue(string value)
        {
            return FindValue<EstimatedCostTier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EstimatedCostTier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventType.
    /// </summary>
    public class EventType : ConstantClass
    {

        /// <summary>
        /// Constant DriftDetected for EventType
        /// </summary>
        public static readonly EventType DriftDetected = new EventType("DriftDetected");
        /// <summary>
        /// Constant ScheduledAssessmentFailure for EventType
        /// </summary>
        public static readonly EventType ScheduledAssessmentFailure = new EventType("ScheduledAssessmentFailure");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventType FindValue(string value)
        {
            return FindValue<EventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExcludeRecommendationReason.
    /// </summary>
    public class ExcludeRecommendationReason : ConstantClass
    {

        /// <summary>
        /// Constant AlreadyImplemented for ExcludeRecommendationReason
        /// </summary>
        public static readonly ExcludeRecommendationReason AlreadyImplemented = new ExcludeRecommendationReason("AlreadyImplemented");
        /// <summary>
        /// Constant ComplexityOfImplementation for ExcludeRecommendationReason
        /// </summary>
        public static readonly ExcludeRecommendationReason ComplexityOfImplementation = new ExcludeRecommendationReason("ComplexityOfImplementation");
        /// <summary>
        /// Constant NotRelevant for ExcludeRecommendationReason
        /// </summary>
        public static readonly ExcludeRecommendationReason NotRelevant = new ExcludeRecommendationReason("NotRelevant");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExcludeRecommendationReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExcludeRecommendationReason FindValue(string value)
        {
            return FindValue<ExcludeRecommendationReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExcludeRecommendationReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FieldAggregationType.
    /// </summary>
    public class FieldAggregationType : ConstantClass
    {

        /// <summary>
        /// Constant Avg for FieldAggregationType
        /// </summary>
        public static readonly FieldAggregationType Avg = new FieldAggregationType("Avg");
        /// <summary>
        /// Constant Count for FieldAggregationType
        /// </summary>
        public static readonly FieldAggregationType Count = new FieldAggregationType("Count");
        /// <summary>
        /// Constant Max for FieldAggregationType
        /// </summary>
        public static readonly FieldAggregationType Max = new FieldAggregationType("Max");
        /// <summary>
        /// Constant Min for FieldAggregationType
        /// </summary>
        public static readonly FieldAggregationType Min = new FieldAggregationType("Min");
        /// <summary>
        /// Constant Sum for FieldAggregationType
        /// </summary>
        public static readonly FieldAggregationType Sum = new FieldAggregationType("Sum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FieldAggregationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FieldAggregationType FindValue(string value)
        {
            return FindValue<FieldAggregationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FieldAggregationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupingRecommendationConfidenceLevel.
    /// </summary>
    public class GroupingRecommendationConfidenceLevel : ConstantClass
    {

        /// <summary>
        /// Constant High for GroupingRecommendationConfidenceLevel
        /// </summary>
        public static readonly GroupingRecommendationConfidenceLevel High = new GroupingRecommendationConfidenceLevel("High");
        /// <summary>
        /// Constant Medium for GroupingRecommendationConfidenceLevel
        /// </summary>
        public static readonly GroupingRecommendationConfidenceLevel Medium = new GroupingRecommendationConfidenceLevel("Medium");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupingRecommendationConfidenceLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupingRecommendationConfidenceLevel FindValue(string value)
        {
            return FindValue<GroupingRecommendationConfidenceLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupingRecommendationConfidenceLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupingRecommendationRejectionReason.
    /// </summary>
    public class GroupingRecommendationRejectionReason : ConstantClass
    {

        /// <summary>
        /// Constant DistinctBusinessPurpose for GroupingRecommendationRejectionReason
        /// </summary>
        public static readonly GroupingRecommendationRejectionReason DistinctBusinessPurpose = new GroupingRecommendationRejectionReason("DistinctBusinessPurpose");
        /// <summary>
        /// Constant DistinctUserGroupHandling for GroupingRecommendationRejectionReason
        /// </summary>
        public static readonly GroupingRecommendationRejectionReason DistinctUserGroupHandling = new GroupingRecommendationRejectionReason("DistinctUserGroupHandling");
        /// <summary>
        /// Constant Other for GroupingRecommendationRejectionReason
        /// </summary>
        public static readonly GroupingRecommendationRejectionReason Other = new GroupingRecommendationRejectionReason("Other");
        /// <summary>
        /// Constant SeparateDataConcern for GroupingRecommendationRejectionReason
        /// </summary>
        public static readonly GroupingRecommendationRejectionReason SeparateDataConcern = new GroupingRecommendationRejectionReason("SeparateDataConcern");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupingRecommendationRejectionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupingRecommendationRejectionReason FindValue(string value)
        {
            return FindValue<GroupingRecommendationRejectionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupingRecommendationRejectionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupingRecommendationStatusType.
    /// </summary>
    public class GroupingRecommendationStatusType : ConstantClass
    {

        /// <summary>
        /// Constant Accepted for GroupingRecommendationStatusType
        /// </summary>
        public static readonly GroupingRecommendationStatusType Accepted = new GroupingRecommendationStatusType("Accepted");
        /// <summary>
        /// Constant PendingDecision for GroupingRecommendationStatusType
        /// </summary>
        public static readonly GroupingRecommendationStatusType PendingDecision = new GroupingRecommendationStatusType("PendingDecision");
        /// <summary>
        /// Constant Rejected for GroupingRecommendationStatusType
        /// </summary>
        public static readonly GroupingRecommendationStatusType Rejected = new GroupingRecommendationStatusType("Rejected");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupingRecommendationStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupingRecommendationStatusType FindValue(string value)
        {
            return FindValue<GroupingRecommendationStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupingRecommendationStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HaArchitecture.
    /// </summary>
    public class HaArchitecture : ConstantClass
    {

        /// <summary>
        /// Constant BackupAndRestore for HaArchitecture
        /// </summary>
        public static readonly HaArchitecture BackupAndRestore = new HaArchitecture("BackupAndRestore");
        /// <summary>
        /// Constant MultiSite for HaArchitecture
        /// </summary>
        public static readonly HaArchitecture MultiSite = new HaArchitecture("MultiSite");
        /// <summary>
        /// Constant NoRecoveryPlan for HaArchitecture
        /// </summary>
        public static readonly HaArchitecture NoRecoveryPlan = new HaArchitecture("NoRecoveryPlan");
        /// <summary>
        /// Constant PilotLight for HaArchitecture
        /// </summary>
        public static readonly HaArchitecture PilotLight = new HaArchitecture("PilotLight");
        /// <summary>
        /// Constant WarmStandby for HaArchitecture
        /// </summary>
        public static readonly HaArchitecture WarmStandby = new HaArchitecture("WarmStandby");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HaArchitecture(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HaArchitecture FindValue(string value)
        {
            return FindValue<HaArchitecture>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HaArchitecture(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricsExportStatusType.
    /// </summary>
    public class MetricsExportStatusType : ConstantClass
    {

        /// <summary>
        /// Constant Failed for MetricsExportStatusType
        /// </summary>
        public static readonly MetricsExportStatusType Failed = new MetricsExportStatusType("Failed");
        /// <summary>
        /// Constant InProgress for MetricsExportStatusType
        /// </summary>
        public static readonly MetricsExportStatusType InProgress = new MetricsExportStatusType("InProgress");
        /// <summary>
        /// Constant Pending for MetricsExportStatusType
        /// </summary>
        public static readonly MetricsExportStatusType Pending = new MetricsExportStatusType("Pending");
        /// <summary>
        /// Constant Success for MetricsExportStatusType
        /// </summary>
        public static readonly MetricsExportStatusType Success = new MetricsExportStatusType("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricsExportStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricsExportStatusType FindValue(string value)
        {
            return FindValue<MetricsExportStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricsExportStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionModelType.
    /// </summary>
    public class PermissionModelType : ConstantClass
    {

        /// <summary>
        /// Constant LegacyIAMUser for PermissionModelType
        /// </summary>
        public static readonly PermissionModelType LegacyIAMUser = new PermissionModelType("LegacyIAMUser");
        /// <summary>
        /// Constant RoleBased for PermissionModelType
        /// </summary>
        public static readonly PermissionModelType RoleBased = new PermissionModelType("RoleBased");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionModelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionModelType FindValue(string value)
        {
            return FindValue<PermissionModelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionModelType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhysicalIdentifierType.
    /// </summary>
    public class PhysicalIdentifierType : ConstantClass
    {

        /// <summary>
        /// Constant Arn for PhysicalIdentifierType
        /// </summary>
        public static readonly PhysicalIdentifierType Arn = new PhysicalIdentifierType("Arn");
        /// <summary>
        /// Constant Native for PhysicalIdentifierType
        /// </summary>
        public static readonly PhysicalIdentifierType Native = new PhysicalIdentifierType("Native");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhysicalIdentifierType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhysicalIdentifierType FindValue(string value)
        {
            return FindValue<PhysicalIdentifierType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhysicalIdentifierType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationComplianceStatus.
    /// </summary>
    public class RecommendationComplianceStatus : ConstantClass
    {

        /// <summary>
        /// Constant BreachedCanMeet for RecommendationComplianceStatus
        /// </summary>
        public static readonly RecommendationComplianceStatus BreachedCanMeet = new RecommendationComplianceStatus("BreachedCanMeet");
        /// <summary>
        /// Constant BreachedUnattainable for RecommendationComplianceStatus
        /// </summary>
        public static readonly RecommendationComplianceStatus BreachedUnattainable = new RecommendationComplianceStatus("BreachedUnattainable");
        /// <summary>
        /// Constant MetCanImprove for RecommendationComplianceStatus
        /// </summary>
        public static readonly RecommendationComplianceStatus MetCanImprove = new RecommendationComplianceStatus("MetCanImprove");
        /// <summary>
        /// Constant MissingPolicy for RecommendationComplianceStatus
        /// </summary>
        public static readonly RecommendationComplianceStatus MissingPolicy = new RecommendationComplianceStatus("MissingPolicy");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationComplianceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationComplianceStatus FindValue(string value)
        {
            return FindValue<RecommendationComplianceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationComplianceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationStatus.
    /// </summary>
    public class RecommendationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Excluded for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus Excluded = new RecommendationStatus("Excluded");
        /// <summary>
        /// Constant Implemented for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus Implemented = new RecommendationStatus("Implemented");
        /// <summary>
        /// Constant Inactive for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus Inactive = new RecommendationStatus("Inactive");
        /// <summary>
        /// Constant NotImplemented for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus NotImplemented = new RecommendationStatus("NotImplemented");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationStatus FindValue(string value)
        {
            return FindValue<RecommendationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationTemplateStatus.
    /// </summary>
    public class RecommendationTemplateStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for RecommendationTemplateStatus
        /// </summary>
        public static readonly RecommendationTemplateStatus Failed = new RecommendationTemplateStatus("Failed");
        /// <summary>
        /// Constant InProgress for RecommendationTemplateStatus
        /// </summary>
        public static readonly RecommendationTemplateStatus InProgress = new RecommendationTemplateStatus("InProgress");
        /// <summary>
        /// Constant Pending for RecommendationTemplateStatus
        /// </summary>
        public static readonly RecommendationTemplateStatus Pending = new RecommendationTemplateStatus("Pending");
        /// <summary>
        /// Constant Success for RecommendationTemplateStatus
        /// </summary>
        public static readonly RecommendationTemplateStatus Success = new RecommendationTemplateStatus("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationTemplateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationTemplateStatus FindValue(string value)
        {
            return FindValue<RecommendationTemplateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationTemplateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RenderRecommendationType.
    /// </summary>
    public class RenderRecommendationType : ConstantClass
    {

        /// <summary>
        /// Constant Alarm for RenderRecommendationType
        /// </summary>
        public static readonly RenderRecommendationType Alarm = new RenderRecommendationType("Alarm");
        /// <summary>
        /// Constant Sop for RenderRecommendationType
        /// </summary>
        public static readonly RenderRecommendationType Sop = new RenderRecommendationType("Sop");
        /// <summary>
        /// Constant Test for RenderRecommendationType
        /// </summary>
        public static readonly RenderRecommendationType Test = new RenderRecommendationType("Test");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RenderRecommendationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RenderRecommendationType FindValue(string value)
        {
            return FindValue<RenderRecommendationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RenderRecommendationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResiliencyPolicyTier.
    /// </summary>
    public class ResiliencyPolicyTier : ConstantClass
    {

        /// <summary>
        /// Constant CoreServices for ResiliencyPolicyTier
        /// </summary>
        public static readonly ResiliencyPolicyTier CoreServices = new ResiliencyPolicyTier("CoreServices");
        /// <summary>
        /// Constant Critical for ResiliencyPolicyTier
        /// </summary>
        public static readonly ResiliencyPolicyTier Critical = new ResiliencyPolicyTier("Critical");
        /// <summary>
        /// Constant Important for ResiliencyPolicyTier
        /// </summary>
        public static readonly ResiliencyPolicyTier Important = new ResiliencyPolicyTier("Important");
        /// <summary>
        /// Constant MissionCritical for ResiliencyPolicyTier
        /// </summary>
        public static readonly ResiliencyPolicyTier MissionCritical = new ResiliencyPolicyTier("MissionCritical");
        /// <summary>
        /// Constant NonCritical for ResiliencyPolicyTier
        /// </summary>
        public static readonly ResiliencyPolicyTier NonCritical = new ResiliencyPolicyTier("NonCritical");
        /// <summary>
        /// Constant NotApplicable for ResiliencyPolicyTier
        /// </summary>
        public static readonly ResiliencyPolicyTier NotApplicable = new ResiliencyPolicyTier("NotApplicable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResiliencyPolicyTier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResiliencyPolicyTier FindValue(string value)
        {
            return FindValue<ResiliencyPolicyTier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResiliencyPolicyTier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResiliencyScoreType.
    /// </summary>
    public class ResiliencyScoreType : ConstantClass
    {

        /// <summary>
        /// Constant Alarm for ResiliencyScoreType
        /// </summary>
        public static readonly ResiliencyScoreType Alarm = new ResiliencyScoreType("Alarm");
        /// <summary>
        /// Constant Compliance for ResiliencyScoreType
        /// </summary>
        public static readonly ResiliencyScoreType Compliance = new ResiliencyScoreType("Compliance");
        /// <summary>
        /// Constant Sop for ResiliencyScoreType
        /// </summary>
        public static readonly ResiliencyScoreType Sop = new ResiliencyScoreType("Sop");
        /// <summary>
        /// Constant Test for ResiliencyScoreType
        /// </summary>
        public static readonly ResiliencyScoreType Test = new ResiliencyScoreType("Test");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResiliencyScoreType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResiliencyScoreType FindValue(string value)
        {
            return FindValue<ResiliencyScoreType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResiliencyScoreType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceImportStatusType.
    /// </summary>
    public class ResourceImportStatusType : ConstantClass
    {

        /// <summary>
        /// Constant Failed for ResourceImportStatusType
        /// </summary>
        public static readonly ResourceImportStatusType Failed = new ResourceImportStatusType("Failed");
        /// <summary>
        /// Constant InProgress for ResourceImportStatusType
        /// </summary>
        public static readonly ResourceImportStatusType InProgress = new ResourceImportStatusType("InProgress");
        /// <summary>
        /// Constant Pending for ResourceImportStatusType
        /// </summary>
        public static readonly ResourceImportStatusType Pending = new ResourceImportStatusType("Pending");
        /// <summary>
        /// Constant Success for ResourceImportStatusType
        /// </summary>
        public static readonly ResourceImportStatusType Success = new ResourceImportStatusType("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceImportStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceImportStatusType FindValue(string value)
        {
            return FindValue<ResourceImportStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceImportStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceImportStrategyType.
    /// </summary>
    public class ResourceImportStrategyType : ConstantClass
    {

        /// <summary>
        /// Constant AddOnly for ResourceImportStrategyType
        /// </summary>
        public static readonly ResourceImportStrategyType AddOnly = new ResourceImportStrategyType("AddOnly");
        /// <summary>
        /// Constant ReplaceAll for ResourceImportStrategyType
        /// </summary>
        public static readonly ResourceImportStrategyType ReplaceAll = new ResourceImportStrategyType("ReplaceAll");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceImportStrategyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceImportStrategyType FindValue(string value)
        {
            return FindValue<ResourceImportStrategyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceImportStrategyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceMappingType.
    /// </summary>
    public class ResourceMappingType : ConstantClass
    {

        /// <summary>
        /// Constant AppRegistryApp for ResourceMappingType
        /// </summary>
        public static readonly ResourceMappingType AppRegistryApp = new ResourceMappingType("AppRegistryApp");
        /// <summary>
        /// Constant CfnStack for ResourceMappingType
        /// </summary>
        public static readonly ResourceMappingType CfnStack = new ResourceMappingType("CfnStack");
        /// <summary>
        /// Constant EKS for ResourceMappingType
        /// </summary>
        public static readonly ResourceMappingType EKS = new ResourceMappingType("EKS");
        /// <summary>
        /// Constant Resource for ResourceMappingType
        /// </summary>
        public static readonly ResourceMappingType Resource = new ResourceMappingType("Resource");
        /// <summary>
        /// Constant ResourceGroup for ResourceMappingType
        /// </summary>
        public static readonly ResourceMappingType ResourceGroup = new ResourceMappingType("ResourceGroup");
        /// <summary>
        /// Constant Terraform for ResourceMappingType
        /// </summary>
        public static readonly ResourceMappingType Terraform = new ResourceMappingType("Terraform");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceMappingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceMappingType FindValue(string value)
        {
            return FindValue<ResourceMappingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceMappingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceResolutionStatusType.
    /// </summary>
    public class ResourceResolutionStatusType : ConstantClass
    {

        /// <summary>
        /// Constant Failed for ResourceResolutionStatusType
        /// </summary>
        public static readonly ResourceResolutionStatusType Failed = new ResourceResolutionStatusType("Failed");
        /// <summary>
        /// Constant InProgress for ResourceResolutionStatusType
        /// </summary>
        public static readonly ResourceResolutionStatusType InProgress = new ResourceResolutionStatusType("InProgress");
        /// <summary>
        /// Constant Pending for ResourceResolutionStatusType
        /// </summary>
        public static readonly ResourceResolutionStatusType Pending = new ResourceResolutionStatusType("Pending");
        /// <summary>
        /// Constant Success for ResourceResolutionStatusType
        /// </summary>
        public static readonly ResourceResolutionStatusType Success = new ResourceResolutionStatusType("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceResolutionStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceResolutionStatusType FindValue(string value)
        {
            return FindValue<ResourceResolutionStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceResolutionStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourcesGroupingRecGenStatusType.
    /// </summary>
    public class ResourcesGroupingRecGenStatusType : ConstantClass
    {

        /// <summary>
        /// Constant Failed for ResourcesGroupingRecGenStatusType
        /// </summary>
        public static readonly ResourcesGroupingRecGenStatusType Failed = new ResourcesGroupingRecGenStatusType("Failed");
        /// <summary>
        /// Constant InProgress for ResourcesGroupingRecGenStatusType
        /// </summary>
        public static readonly ResourcesGroupingRecGenStatusType InProgress = new ResourcesGroupingRecGenStatusType("InProgress");
        /// <summary>
        /// Constant Pending for ResourcesGroupingRecGenStatusType
        /// </summary>
        public static readonly ResourcesGroupingRecGenStatusType Pending = new ResourcesGroupingRecGenStatusType("Pending");
        /// <summary>
        /// Constant Success for ResourcesGroupingRecGenStatusType
        /// </summary>
        public static readonly ResourcesGroupingRecGenStatusType Success = new ResourcesGroupingRecGenStatusType("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourcesGroupingRecGenStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourcesGroupingRecGenStatusType FindValue(string value)
        {
            return FindValue<ResourcesGroupingRecGenStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourcesGroupingRecGenStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceSourceType.
    /// </summary>
    public class ResourceSourceType : ConstantClass
    {

        /// <summary>
        /// Constant AppTemplate for ResourceSourceType
        /// </summary>
        public static readonly ResourceSourceType AppTemplate = new ResourceSourceType("AppTemplate");
        /// <summary>
        /// Constant Discovered for ResourceSourceType
        /// </summary>
        public static readonly ResourceSourceType Discovered = new ResourceSourceType("Discovered");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceSourceType FindValue(string value)
        {
            return FindValue<ResourceSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SopServiceType.
    /// </summary>
    public class SopServiceType : ConstantClass
    {

        /// <summary>
        /// Constant SSM for SopServiceType
        /// </summary>
        public static readonly SopServiceType SSM = new SopServiceType("SSM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SopServiceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SopServiceType FindValue(string value)
        {
            return FindValue<SopServiceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SopServiceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemplateFormat.
    /// </summary>
    public class TemplateFormat : ConstantClass
    {

        /// <summary>
        /// Constant CfnJson for TemplateFormat
        /// </summary>
        public static readonly TemplateFormat CfnJson = new TemplateFormat("CfnJson");
        /// <summary>
        /// Constant CfnYaml for TemplateFormat
        /// </summary>
        public static readonly TemplateFormat CfnYaml = new TemplateFormat("CfnYaml");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemplateFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemplateFormat FindValue(string value)
        {
            return FindValue<TemplateFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemplateFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestRisk.
    /// </summary>
    public class TestRisk : ConstantClass
    {

        /// <summary>
        /// Constant High for TestRisk
        /// </summary>
        public static readonly TestRisk High = new TestRisk("High");
        /// <summary>
        /// Constant Medium for TestRisk
        /// </summary>
        public static readonly TestRisk Medium = new TestRisk("Medium");
        /// <summary>
        /// Constant Small for TestRisk
        /// </summary>
        public static readonly TestRisk Small = new TestRisk("Small");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestRisk(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestRisk FindValue(string value)
        {
            return FindValue<TestRisk>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestRisk(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestType.
    /// </summary>
    public class TestType : ConstantClass
    {

        /// <summary>
        /// Constant AZ for TestType
        /// </summary>
        public static readonly TestType AZ = new TestType("AZ");
        /// <summary>
        /// Constant Hardware for TestType
        /// </summary>
        public static readonly TestType Hardware = new TestType("Hardware");
        /// <summary>
        /// Constant Region for TestType
        /// </summary>
        public static readonly TestType Region = new TestType("Region");
        /// <summary>
        /// Constant Software for TestType
        /// </summary>
        public static readonly TestType Software = new TestType("Software");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestType FindValue(string value)
        {
            return FindValue<TestType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestType(string value)
        {
            return FindValue(value);
        }
    }

}