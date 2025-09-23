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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CleanRooms
{

    /// <summary>
    /// Constants used for properties of type AccessDeniedExceptionReason.
    /// </summary>
    public class AccessDeniedExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant INSUFFICIENT_PERMISSIONS for AccessDeniedExceptionReason
        /// </summary>
        public static readonly AccessDeniedExceptionReason INSUFFICIENT_PERMISSIONS = new AccessDeniedExceptionReason("INSUFFICIENT_PERMISSIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessDeniedExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessDeniedExceptionReason FindValue(string value)
        {
            return FindValue<AccessDeniedExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessDeniedExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AdditionalAnalyses.
    /// </summary>
    public class AdditionalAnalyses : ConstantClass
    {

        /// <summary>
        /// Constant ALLOWED for AdditionalAnalyses
        /// </summary>
        public static readonly AdditionalAnalyses ALLOWED = new AdditionalAnalyses("ALLOWED");
        /// <summary>
        /// Constant NOT_ALLOWED for AdditionalAnalyses
        /// </summary>
        public static readonly AdditionalAnalyses NOT_ALLOWED = new AdditionalAnalyses("NOT_ALLOWED");
        /// <summary>
        /// Constant REQUIRED for AdditionalAnalyses
        /// </summary>
        public static readonly AdditionalAnalyses REQUIRED = new AdditionalAnalyses("REQUIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdditionalAnalyses(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdditionalAnalyses FindValue(string value)
        {
            return FindValue<AdditionalAnalyses>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdditionalAnalyses(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AggregateFunctionName.
    /// </summary>
    public class AggregateFunctionName : ConstantClass
    {

        /// <summary>
        /// Constant AVG for AggregateFunctionName
        /// </summary>
        public static readonly AggregateFunctionName AVG = new AggregateFunctionName("AVG");
        /// <summary>
        /// Constant COUNT for AggregateFunctionName
        /// </summary>
        public static readonly AggregateFunctionName COUNT = new AggregateFunctionName("COUNT");
        /// <summary>
        /// Constant COUNT_DISTINCT for AggregateFunctionName
        /// </summary>
        public static readonly AggregateFunctionName COUNT_DISTINCT = new AggregateFunctionName("COUNT_DISTINCT");
        /// <summary>
        /// Constant SUM for AggregateFunctionName
        /// </summary>
        public static readonly AggregateFunctionName SUM = new AggregateFunctionName("SUM");
        /// <summary>
        /// Constant SUM_DISTINCT for AggregateFunctionName
        /// </summary>
        public static readonly AggregateFunctionName SUM_DISTINCT = new AggregateFunctionName("SUM_DISTINCT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregateFunctionName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregateFunctionName FindValue(string value)
        {
            return FindValue<AggregateFunctionName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregateFunctionName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AggregationType.
    /// </summary>
    public class AggregationType : ConstantClass
    {

        /// <summary>
        /// Constant COUNT_DISTINCT for AggregationType
        /// </summary>
        public static readonly AggregationType COUNT_DISTINCT = new AggregationType("COUNT_DISTINCT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregationType FindValue(string value)
        {
            return FindValue<AggregationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalysisFormat.
    /// </summary>
    public class AnalysisFormat : ConstantClass
    {

        /// <summary>
        /// Constant PYSPARK_1_0 for AnalysisFormat
        /// </summary>
        public static readonly AnalysisFormat PYSPARK_1_0 = new AnalysisFormat("PYSPARK_1_0");
        /// <summary>
        /// Constant SQL for AnalysisFormat
        /// </summary>
        public static readonly AnalysisFormat SQL = new AnalysisFormat("SQL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisFormat FindValue(string value)
        {
            return FindValue<AnalysisFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalysisMethod.
    /// </summary>
    public class AnalysisMethod : ConstantClass
    {

        /// <summary>
        /// Constant DIRECT_JOB for AnalysisMethod
        /// </summary>
        public static readonly AnalysisMethod DIRECT_JOB = new AnalysisMethod("DIRECT_JOB");
        /// <summary>
        /// Constant DIRECT_QUERY for AnalysisMethod
        /// </summary>
        public static readonly AnalysisMethod DIRECT_QUERY = new AnalysisMethod("DIRECT_QUERY");
        /// <summary>
        /// Constant MULTIPLE for AnalysisMethod
        /// </summary>
        public static readonly AnalysisMethod MULTIPLE = new AnalysisMethod("MULTIPLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisMethod FindValue(string value)
        {
            return FindValue<AnalysisMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalysisRuleType.
    /// </summary>
    public class AnalysisRuleType : ConstantClass
    {

        /// <summary>
        /// Constant AGGREGATION for AnalysisRuleType
        /// </summary>
        public static readonly AnalysisRuleType AGGREGATION = new AnalysisRuleType("AGGREGATION");
        /// <summary>
        /// Constant CUSTOM for AnalysisRuleType
        /// </summary>
        public static readonly AnalysisRuleType CUSTOM = new AnalysisRuleType("CUSTOM");
        /// <summary>
        /// Constant ID_MAPPING_TABLE for AnalysisRuleType
        /// </summary>
        public static readonly AnalysisRuleType ID_MAPPING_TABLE = new AnalysisRuleType("ID_MAPPING_TABLE");
        /// <summary>
        /// Constant LIST for AnalysisRuleType
        /// </summary>
        public static readonly AnalysisRuleType LIST = new AnalysisRuleType("LIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisRuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisRuleType FindValue(string value)
        {
            return FindValue<AnalysisRuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisRuleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalysisTemplateValidationStatus.
    /// </summary>
    public class AnalysisTemplateValidationStatus : ConstantClass
    {

        /// <summary>
        /// Constant INVALID for AnalysisTemplateValidationStatus
        /// </summary>
        public static readonly AnalysisTemplateValidationStatus INVALID = new AnalysisTemplateValidationStatus("INVALID");
        /// <summary>
        /// Constant UNABLE_TO_VALIDATE for AnalysisTemplateValidationStatus
        /// </summary>
        public static readonly AnalysisTemplateValidationStatus UNABLE_TO_VALIDATE = new AnalysisTemplateValidationStatus("UNABLE_TO_VALIDATE");
        /// <summary>
        /// Constant VALID for AnalysisTemplateValidationStatus
        /// </summary>
        public static readonly AnalysisTemplateValidationStatus VALID = new AnalysisTemplateValidationStatus("VALID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisTemplateValidationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisTemplateValidationStatus FindValue(string value)
        {
            return FindValue<AnalysisTemplateValidationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisTemplateValidationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalysisTemplateValidationType.
    /// </summary>
    public class AnalysisTemplateValidationType : ConstantClass
    {

        /// <summary>
        /// Constant DIFFERENTIAL_PRIVACY for AnalysisTemplateValidationType
        /// </summary>
        public static readonly AnalysisTemplateValidationType DIFFERENTIAL_PRIVACY = new AnalysisTemplateValidationType("DIFFERENTIAL_PRIVACY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisTemplateValidationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisTemplateValidationType FindValue(string value)
        {
            return FindValue<AnalysisTemplateValidationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisTemplateValidationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalysisType.
    /// </summary>
    public class AnalysisType : ConstantClass
    {

        /// <summary>
        /// Constant ADDITIONAL_ANALYSIS for AnalysisType
        /// </summary>
        public static readonly AnalysisType ADDITIONAL_ANALYSIS = new AnalysisType("ADDITIONAL_ANALYSIS");
        /// <summary>
        /// Constant DIRECT_ANALYSIS for AnalysisType
        /// </summary>
        public static readonly AnalysisType DIRECT_ANALYSIS = new AnalysisType("DIRECT_ANALYSIS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisType FindValue(string value)
        {
            return FindValue<AnalysisType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsEngine.
    /// </summary>
    public class AnalyticsEngine : ConstantClass
    {

        /// <summary>
        /// Constant CLEAN_ROOMS_SQL for AnalyticsEngine
        /// </summary>
        public static readonly AnalyticsEngine CLEAN_ROOMS_SQL = new AnalyticsEngine("CLEAN_ROOMS_SQL");
        /// <summary>
        /// Constant SPARK for AnalyticsEngine
        /// </summary>
        public static readonly AnalyticsEngine SPARK = new AnalyticsEngine("SPARK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsEngine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsEngine FindValue(string value)
        {
            return FindValue<AnalyticsEngine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsEngine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoApprovedChangeType.
    /// </summary>
    public class AutoApprovedChangeType : ConstantClass
    {

        /// <summary>
        /// Constant ADD_MEMBER for AutoApprovedChangeType
        /// </summary>
        public static readonly AutoApprovedChangeType ADD_MEMBER = new AutoApprovedChangeType("ADD_MEMBER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoApprovedChangeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoApprovedChangeType FindValue(string value)
        {
            return FindValue<AutoApprovedChangeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoApprovedChangeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeRequestStatus.
    /// </summary>
    public class ChangeRequestStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for ChangeRequestStatus
        /// </summary>
        public static readonly ChangeRequestStatus APPROVED = new ChangeRequestStatus("APPROVED");
        /// <summary>
        /// Constant CANCELLED for ChangeRequestStatus
        /// </summary>
        public static readonly ChangeRequestStatus CANCELLED = new ChangeRequestStatus("CANCELLED");
        /// <summary>
        /// Constant COMMITTED for ChangeRequestStatus
        /// </summary>
        public static readonly ChangeRequestStatus COMMITTED = new ChangeRequestStatus("COMMITTED");
        /// <summary>
        /// Constant DENIED for ChangeRequestStatus
        /// </summary>
        public static readonly ChangeRequestStatus DENIED = new ChangeRequestStatus("DENIED");
        /// <summary>
        /// Constant PENDING for ChangeRequestStatus
        /// </summary>
        public static readonly ChangeRequestStatus PENDING = new ChangeRequestStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeRequestStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeRequestStatus FindValue(string value)
        {
            return FindValue<ChangeRequestStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeRequestStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeSpecificationType.
    /// </summary>
    public class ChangeSpecificationType : ConstantClass
    {

        /// <summary>
        /// Constant MEMBER for ChangeSpecificationType
        /// </summary>
        public static readonly ChangeSpecificationType MEMBER = new ChangeSpecificationType("MEMBER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeSpecificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeSpecificationType FindValue(string value)
        {
            return FindValue<ChangeSpecificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeSpecificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeType.
    /// </summary>
    public class ChangeType : ConstantClass
    {

        /// <summary>
        /// Constant ADD_MEMBER for ChangeType
        /// </summary>
        public static readonly ChangeType ADD_MEMBER = new ChangeType("ADD_MEMBER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeType FindValue(string value)
        {
            return FindValue<ChangeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CollaborationJobLogStatus.
    /// </summary>
    public class CollaborationJobLogStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CollaborationJobLogStatus
        /// </summary>
        public static readonly CollaborationJobLogStatus DISABLED = new CollaborationJobLogStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for CollaborationJobLogStatus
        /// </summary>
        public static readonly CollaborationJobLogStatus ENABLED = new CollaborationJobLogStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CollaborationJobLogStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CollaborationJobLogStatus FindValue(string value)
        {
            return FindValue<CollaborationJobLogStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CollaborationJobLogStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CollaborationQueryLogStatus.
    /// </summary>
    public class CollaborationQueryLogStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CollaborationQueryLogStatus
        /// </summary>
        public static readonly CollaborationQueryLogStatus DISABLED = new CollaborationQueryLogStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for CollaborationQueryLogStatus
        /// </summary>
        public static readonly CollaborationQueryLogStatus ENABLED = new CollaborationQueryLogStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CollaborationQueryLogStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CollaborationQueryLogStatus FindValue(string value)
        {
            return FindValue<CollaborationQueryLogStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CollaborationQueryLogStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfiguredTableAnalysisRuleType.
    /// </summary>
    public class ConfiguredTableAnalysisRuleType : ConstantClass
    {

        /// <summary>
        /// Constant AGGREGATION for ConfiguredTableAnalysisRuleType
        /// </summary>
        public static readonly ConfiguredTableAnalysisRuleType AGGREGATION = new ConfiguredTableAnalysisRuleType("AGGREGATION");
        /// <summary>
        /// Constant CUSTOM for ConfiguredTableAnalysisRuleType
        /// </summary>
        public static readonly ConfiguredTableAnalysisRuleType CUSTOM = new ConfiguredTableAnalysisRuleType("CUSTOM");
        /// <summary>
        /// Constant LIST for ConfiguredTableAnalysisRuleType
        /// </summary>
        public static readonly ConfiguredTableAnalysisRuleType LIST = new ConfiguredTableAnalysisRuleType("LIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfiguredTableAnalysisRuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfiguredTableAnalysisRuleType FindValue(string value)
        {
            return FindValue<ConfiguredTableAnalysisRuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfiguredTableAnalysisRuleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfiguredTableAssociationAnalysisRuleType.
    /// </summary>
    public class ConfiguredTableAssociationAnalysisRuleType : ConstantClass
    {

        /// <summary>
        /// Constant AGGREGATION for ConfiguredTableAssociationAnalysisRuleType
        /// </summary>
        public static readonly ConfiguredTableAssociationAnalysisRuleType AGGREGATION = new ConfiguredTableAssociationAnalysisRuleType("AGGREGATION");
        /// <summary>
        /// Constant CUSTOM for ConfiguredTableAssociationAnalysisRuleType
        /// </summary>
        public static readonly ConfiguredTableAssociationAnalysisRuleType CUSTOM = new ConfiguredTableAssociationAnalysisRuleType("CUSTOM");
        /// <summary>
        /// Constant LIST for ConfiguredTableAssociationAnalysisRuleType
        /// </summary>
        public static readonly ConfiguredTableAssociationAnalysisRuleType LIST = new ConfiguredTableAssociationAnalysisRuleType("LIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfiguredTableAssociationAnalysisRuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfiguredTableAssociationAnalysisRuleType FindValue(string value)
        {
            return FindValue<ConfiguredTableAssociationAnalysisRuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfiguredTableAssociationAnalysisRuleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConflictExceptionReason.
    /// </summary>
    public class ConflictExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant ALREADY_EXISTS for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason ALREADY_EXISTS = new ConflictExceptionReason("ALREADY_EXISTS");
        /// <summary>
        /// Constant INVALID_STATE for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason INVALID_STATE = new ConflictExceptionReason("INVALID_STATE");
        /// <summary>
        /// Constant SUBRESOURCES_EXIST for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason SUBRESOURCES_EXIST = new ConflictExceptionReason("SUBRESOURCES_EXIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictExceptionReason FindValue(string value)
        {
            return FindValue<ConflictExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomMLMemberAbility.
    /// </summary>
    public class CustomMLMemberAbility : ConstantClass
    {

        /// <summary>
        /// Constant CAN_RECEIVE_INFERENCE_OUTPUT for CustomMLMemberAbility
        /// </summary>
        public static readonly CustomMLMemberAbility CAN_RECEIVE_INFERENCE_OUTPUT = new CustomMLMemberAbility("CAN_RECEIVE_INFERENCE_OUTPUT");
        /// <summary>
        /// Constant CAN_RECEIVE_MODEL_OUTPUT for CustomMLMemberAbility
        /// </summary>
        public static readonly CustomMLMemberAbility CAN_RECEIVE_MODEL_OUTPUT = new CustomMLMemberAbility("CAN_RECEIVE_MODEL_OUTPUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomMLMemberAbility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomMLMemberAbility FindValue(string value)
        {
            return FindValue<CustomMLMemberAbility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomMLMemberAbility(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DifferentialPrivacyAggregationType.
    /// </summary>
    public class DifferentialPrivacyAggregationType : ConstantClass
    {

        /// <summary>
        /// Constant AVG for DifferentialPrivacyAggregationType
        /// </summary>
        public static readonly DifferentialPrivacyAggregationType AVG = new DifferentialPrivacyAggregationType("AVG");
        /// <summary>
        /// Constant COUNT for DifferentialPrivacyAggregationType
        /// </summary>
        public static readonly DifferentialPrivacyAggregationType COUNT = new DifferentialPrivacyAggregationType("COUNT");
        /// <summary>
        /// Constant COUNT_DISTINCT for DifferentialPrivacyAggregationType
        /// </summary>
        public static readonly DifferentialPrivacyAggregationType COUNT_DISTINCT = new DifferentialPrivacyAggregationType("COUNT_DISTINCT");
        /// <summary>
        /// Constant STDDEV for DifferentialPrivacyAggregationType
        /// </summary>
        public static readonly DifferentialPrivacyAggregationType STDDEV = new DifferentialPrivacyAggregationType("STDDEV");
        /// <summary>
        /// Constant SUM for DifferentialPrivacyAggregationType
        /// </summary>
        public static readonly DifferentialPrivacyAggregationType SUM = new DifferentialPrivacyAggregationType("SUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DifferentialPrivacyAggregationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DifferentialPrivacyAggregationType FindValue(string value)
        {
            return FindValue<DifferentialPrivacyAggregationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DifferentialPrivacyAggregationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorMessageType.
    /// </summary>
    public class ErrorMessageType : ConstantClass
    {

        /// <summary>
        /// Constant DETAILED for ErrorMessageType
        /// </summary>
        public static readonly ErrorMessageType DETAILED = new ErrorMessageType("DETAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorMessageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorMessageType FindValue(string value)
        {
            return FindValue<ErrorMessageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorMessageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterableMemberStatus.
    /// </summary>
    public class FilterableMemberStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FilterableMemberStatus
        /// </summary>
        public static readonly FilterableMemberStatus ACTIVE = new FilterableMemberStatus("ACTIVE");
        /// <summary>
        /// Constant INVITED for FilterableMemberStatus
        /// </summary>
        public static readonly FilterableMemberStatus INVITED = new FilterableMemberStatus("INVITED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterableMemberStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterableMemberStatus FindValue(string value)
        {
            return FindValue<FilterableMemberStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterableMemberStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdNamespaceType.
    /// </summary>
    public class IdNamespaceType : ConstantClass
    {

        /// <summary>
        /// Constant SOURCE for IdNamespaceType
        /// </summary>
        public static readonly IdNamespaceType SOURCE = new IdNamespaceType("SOURCE");
        /// <summary>
        /// Constant TARGET for IdNamespaceType
        /// </summary>
        public static readonly IdNamespaceType TARGET = new IdNamespaceType("TARGET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdNamespaceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdNamespaceType FindValue(string value)
        {
            return FindValue<IdNamespaceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdNamespaceType(string value)
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
        /// Constant BATCH for JobType
        /// </summary>
        public static readonly JobType BATCH = new JobType("BATCH");
        /// <summary>
        /// Constant DELETE_ONLY for JobType
        /// </summary>
        public static readonly JobType DELETE_ONLY = new JobType("DELETE_ONLY");
        /// <summary>
        /// Constant INCREMENTAL for JobType
        /// </summary>
        public static readonly JobType INCREMENTAL = new JobType("INCREMENTAL");

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
    /// Constants used for properties of type JoinOperator.
    /// </summary>
    public class JoinOperator : ConstantClass
    {

        /// <summary>
        /// Constant AND for JoinOperator
        /// </summary>
        public static readonly JoinOperator AND = new JoinOperator("AND");
        /// <summary>
        /// Constant OR for JoinOperator
        /// </summary>
        public static readonly JoinOperator OR = new JoinOperator("OR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JoinOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JoinOperator FindValue(string value)
        {
            return FindValue<JoinOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JoinOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JoinRequiredOption.
    /// </summary>
    public class JoinRequiredOption : ConstantClass
    {

        /// <summary>
        /// Constant QUERY_RUNNER for JoinRequiredOption
        /// </summary>
        public static readonly JoinRequiredOption QUERY_RUNNER = new JoinRequiredOption("QUERY_RUNNER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JoinRequiredOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JoinRequiredOption FindValue(string value)
        {
            return FindValue<JoinRequiredOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JoinRequiredOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemberAbility.
    /// </summary>
    public class MemberAbility : ConstantClass
    {

        /// <summary>
        /// Constant CAN_QUERY for MemberAbility
        /// </summary>
        public static readonly MemberAbility CAN_QUERY = new MemberAbility("CAN_QUERY");
        /// <summary>
        /// Constant CAN_RECEIVE_RESULTS for MemberAbility
        /// </summary>
        public static readonly MemberAbility CAN_RECEIVE_RESULTS = new MemberAbility("CAN_RECEIVE_RESULTS");
        /// <summary>
        /// Constant CAN_RUN_JOB for MemberAbility
        /// </summary>
        public static readonly MemberAbility CAN_RUN_JOB = new MemberAbility("CAN_RUN_JOB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberAbility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberAbility FindValue(string value)
        {
            return FindValue<MemberAbility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberAbility(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MembershipJobLogStatus.
    /// </summary>
    public class MembershipJobLogStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for MembershipJobLogStatus
        /// </summary>
        public static readonly MembershipJobLogStatus DISABLED = new MembershipJobLogStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for MembershipJobLogStatus
        /// </summary>
        public static readonly MembershipJobLogStatus ENABLED = new MembershipJobLogStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MembershipJobLogStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MembershipJobLogStatus FindValue(string value)
        {
            return FindValue<MembershipJobLogStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MembershipJobLogStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MembershipQueryLogStatus.
    /// </summary>
    public class MembershipQueryLogStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for MembershipQueryLogStatus
        /// </summary>
        public static readonly MembershipQueryLogStatus DISABLED = new MembershipQueryLogStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for MembershipQueryLogStatus
        /// </summary>
        public static readonly MembershipQueryLogStatus ENABLED = new MembershipQueryLogStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MembershipQueryLogStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MembershipQueryLogStatus FindValue(string value)
        {
            return FindValue<MembershipQueryLogStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MembershipQueryLogStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MembershipStatus.
    /// </summary>
    public class MembershipStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for MembershipStatus
        /// </summary>
        public static readonly MembershipStatus ACTIVE = new MembershipStatus("ACTIVE");
        /// <summary>
        /// Constant COLLABORATION_DELETED for MembershipStatus
        /// </summary>
        public static readonly MembershipStatus COLLABORATION_DELETED = new MembershipStatus("COLLABORATION_DELETED");
        /// <summary>
        /// Constant REMOVED for MembershipStatus
        /// </summary>
        public static readonly MembershipStatus REMOVED = new MembershipStatus("REMOVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MembershipStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MembershipStatus FindValue(string value)
        {
            return FindValue<MembershipStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MembershipStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemberStatus.
    /// </summary>
    public class MemberStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for MemberStatus
        /// </summary>
        public static readonly MemberStatus ACTIVE = new MemberStatus("ACTIVE");
        /// <summary>
        /// Constant INVITED for MemberStatus
        /// </summary>
        public static readonly MemberStatus INVITED = new MemberStatus("INVITED");
        /// <summary>
        /// Constant LEFT for MemberStatus
        /// </summary>
        public static readonly MemberStatus LEFT = new MemberStatus("LEFT");
        /// <summary>
        /// Constant REMOVED for MemberStatus
        /// </summary>
        public static readonly MemberStatus REMOVED = new MemberStatus("REMOVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberStatus FindValue(string value)
        {
            return FindValue<MemberStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberStatus(string value)
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
        /// Constant BIGINT for ParameterType
        /// </summary>
        public static readonly ParameterType BIGINT = new ParameterType("BIGINT");
        /// <summary>
        /// Constant BINARY for ParameterType
        /// </summary>
        public static readonly ParameterType BINARY = new ParameterType("BINARY");
        /// <summary>
        /// Constant BOOLEAN for ParameterType
        /// </summary>
        public static readonly ParameterType BOOLEAN = new ParameterType("BOOLEAN");
        /// <summary>
        /// Constant BYTE for ParameterType
        /// </summary>
        public static readonly ParameterType BYTE = new ParameterType("BYTE");
        /// <summary>
        /// Constant CHAR for ParameterType
        /// </summary>
        public static readonly ParameterType CHAR = new ParameterType("CHAR");
        /// <summary>
        /// Constant CHARACTER for ParameterType
        /// </summary>
        public static readonly ParameterType CHARACTER = new ParameterType("CHARACTER");
        /// <summary>
        /// Constant DATE for ParameterType
        /// </summary>
        public static readonly ParameterType DATE = new ParameterType("DATE");
        /// <summary>
        /// Constant DECIMAL for ParameterType
        /// </summary>
        public static readonly ParameterType DECIMAL = new ParameterType("DECIMAL");
        /// <summary>
        /// Constant DOUBLE for ParameterType
        /// </summary>
        public static readonly ParameterType DOUBLE = new ParameterType("DOUBLE");
        /// <summary>
        /// Constant DOUBLE_PRECISION for ParameterType
        /// </summary>
        public static readonly ParameterType DOUBLE_PRECISION = new ParameterType("DOUBLE_PRECISION");
        /// <summary>
        /// Constant FLOAT for ParameterType
        /// </summary>
        public static readonly ParameterType FLOAT = new ParameterType("FLOAT");
        /// <summary>
        /// Constant INT for ParameterType
        /// </summary>
        public static readonly ParameterType INT = new ParameterType("INT");
        /// <summary>
        /// Constant INTEGER for ParameterType
        /// </summary>
        public static readonly ParameterType INTEGER = new ParameterType("INTEGER");
        /// <summary>
        /// Constant LONG for ParameterType
        /// </summary>
        public static readonly ParameterType LONG = new ParameterType("LONG");
        /// <summary>
        /// Constant NUMERIC for ParameterType
        /// </summary>
        public static readonly ParameterType NUMERIC = new ParameterType("NUMERIC");
        /// <summary>
        /// Constant REAL for ParameterType
        /// </summary>
        public static readonly ParameterType REAL = new ParameterType("REAL");
        /// <summary>
        /// Constant SHORT for ParameterType
        /// </summary>
        public static readonly ParameterType SHORT = new ParameterType("SHORT");
        /// <summary>
        /// Constant SMALLINT for ParameterType
        /// </summary>
        public static readonly ParameterType SMALLINT = new ParameterType("SMALLINT");
        /// <summary>
        /// Constant STRING for ParameterType
        /// </summary>
        public static readonly ParameterType STRING = new ParameterType("STRING");
        /// <summary>
        /// Constant TIME for ParameterType
        /// </summary>
        public static readonly ParameterType TIME = new ParameterType("TIME");
        /// <summary>
        /// Constant TIMESTAMP for ParameterType
        /// </summary>
        public static readonly ParameterType TIMESTAMP = new ParameterType("TIMESTAMP");
        /// <summary>
        /// Constant TIMESTAMP_LTZ for ParameterType
        /// </summary>
        public static readonly ParameterType TIMESTAMP_LTZ = new ParameterType("TIMESTAMP_LTZ");
        /// <summary>
        /// Constant TIMESTAMP_NTZ for ParameterType
        /// </summary>
        public static readonly ParameterType TIMESTAMP_NTZ = new ParameterType("TIMESTAMP_NTZ");
        /// <summary>
        /// Constant TIMESTAMPTZ for ParameterType
        /// </summary>
        public static readonly ParameterType TIMESTAMPTZ = new ParameterType("TIMESTAMPTZ");
        /// <summary>
        /// Constant TIMETZ for ParameterType
        /// </summary>
        public static readonly ParameterType TIMETZ = new ParameterType("TIMETZ");
        /// <summary>
        /// Constant TINYINT for ParameterType
        /// </summary>
        public static readonly ParameterType TINYINT = new ParameterType("TINYINT");
        /// <summary>
        /// Constant VARBYTE for ParameterType
        /// </summary>
        public static readonly ParameterType VARBYTE = new ParameterType("VARBYTE");
        /// <summary>
        /// Constant VARCHAR for ParameterType
        /// </summary>
        public static readonly ParameterType VARCHAR = new ParameterType("VARCHAR");

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
    /// Constants used for properties of type PrivacyBudgetTemplateAutoRefresh.
    /// </summary>
    public class PrivacyBudgetTemplateAutoRefresh : ConstantClass
    {

        /// <summary>
        /// Constant CALENDAR_MONTH for PrivacyBudgetTemplateAutoRefresh
        /// </summary>
        public static readonly PrivacyBudgetTemplateAutoRefresh CALENDAR_MONTH = new PrivacyBudgetTemplateAutoRefresh("CALENDAR_MONTH");
        /// <summary>
        /// Constant NONE for PrivacyBudgetTemplateAutoRefresh
        /// </summary>
        public static readonly PrivacyBudgetTemplateAutoRefresh NONE = new PrivacyBudgetTemplateAutoRefresh("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrivacyBudgetTemplateAutoRefresh(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrivacyBudgetTemplateAutoRefresh FindValue(string value)
        {
            return FindValue<PrivacyBudgetTemplateAutoRefresh>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrivacyBudgetTemplateAutoRefresh(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrivacyBudgetType.
    /// </summary>
    public class PrivacyBudgetType : ConstantClass
    {

        /// <summary>
        /// Constant DIFFERENTIAL_PRIVACY for PrivacyBudgetType
        /// </summary>
        public static readonly PrivacyBudgetType DIFFERENTIAL_PRIVACY = new PrivacyBudgetType("DIFFERENTIAL_PRIVACY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrivacyBudgetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrivacyBudgetType FindValue(string value)
        {
            return FindValue<PrivacyBudgetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrivacyBudgetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectedJobAnalysisType.
    /// </summary>
    public class ProtectedJobAnalysisType : ConstantClass
    {

        /// <summary>
        /// Constant DIRECT_ANALYSIS for ProtectedJobAnalysisType
        /// </summary>
        public static readonly ProtectedJobAnalysisType DIRECT_ANALYSIS = new ProtectedJobAnalysisType("DIRECT_ANALYSIS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectedJobAnalysisType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectedJobAnalysisType FindValue(string value)
        {
            return FindValue<ProtectedJobAnalysisType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectedJobAnalysisType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectedJobStatus.
    /// </summary>
    public class ProtectedJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ProtectedJobStatus
        /// </summary>
        public static readonly ProtectedJobStatus CANCELLED = new ProtectedJobStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for ProtectedJobStatus
        /// </summary>
        public static readonly ProtectedJobStatus CANCELLING = new ProtectedJobStatus("CANCELLING");
        /// <summary>
        /// Constant FAILED for ProtectedJobStatus
        /// </summary>
        public static readonly ProtectedJobStatus FAILED = new ProtectedJobStatus("FAILED");
        /// <summary>
        /// Constant STARTED for ProtectedJobStatus
        /// </summary>
        public static readonly ProtectedJobStatus STARTED = new ProtectedJobStatus("STARTED");
        /// <summary>
        /// Constant SUBMITTED for ProtectedJobStatus
        /// </summary>
        public static readonly ProtectedJobStatus SUBMITTED = new ProtectedJobStatus("SUBMITTED");
        /// <summary>
        /// Constant SUCCESS for ProtectedJobStatus
        /// </summary>
        public static readonly ProtectedJobStatus SUCCESS = new ProtectedJobStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectedJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectedJobStatus FindValue(string value)
        {
            return FindValue<ProtectedJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectedJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectedJobType.
    /// </summary>
    public class ProtectedJobType : ConstantClass
    {

        /// <summary>
        /// Constant PYSPARK for ProtectedJobType
        /// </summary>
        public static readonly ProtectedJobType PYSPARK = new ProtectedJobType("PYSPARK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectedJobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectedJobType FindValue(string value)
        {
            return FindValue<ProtectedJobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectedJobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectedJobWorkerComputeType.
    /// </summary>
    public class ProtectedJobWorkerComputeType : ConstantClass
    {

        /// <summary>
        /// Constant CR1X for ProtectedJobWorkerComputeType
        /// </summary>
        public static readonly ProtectedJobWorkerComputeType CR1X = new ProtectedJobWorkerComputeType("CR.1X");
        /// <summary>
        /// Constant CR4X for ProtectedJobWorkerComputeType
        /// </summary>
        public static readonly ProtectedJobWorkerComputeType CR4X = new ProtectedJobWorkerComputeType("CR.4X");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectedJobWorkerComputeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectedJobWorkerComputeType FindValue(string value)
        {
            return FindValue<ProtectedJobWorkerComputeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectedJobWorkerComputeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectedQueryStatus.
    /// </summary>
    public class ProtectedQueryStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ProtectedQueryStatus
        /// </summary>
        public static readonly ProtectedQueryStatus CANCELLED = new ProtectedQueryStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for ProtectedQueryStatus
        /// </summary>
        public static readonly ProtectedQueryStatus CANCELLING = new ProtectedQueryStatus("CANCELLING");
        /// <summary>
        /// Constant FAILED for ProtectedQueryStatus
        /// </summary>
        public static readonly ProtectedQueryStatus FAILED = new ProtectedQueryStatus("FAILED");
        /// <summary>
        /// Constant STARTED for ProtectedQueryStatus
        /// </summary>
        public static readonly ProtectedQueryStatus STARTED = new ProtectedQueryStatus("STARTED");
        /// <summary>
        /// Constant SUBMITTED for ProtectedQueryStatus
        /// </summary>
        public static readonly ProtectedQueryStatus SUBMITTED = new ProtectedQueryStatus("SUBMITTED");
        /// <summary>
        /// Constant SUCCESS for ProtectedQueryStatus
        /// </summary>
        public static readonly ProtectedQueryStatus SUCCESS = new ProtectedQueryStatus("SUCCESS");
        /// <summary>
        /// Constant TIMED_OUT for ProtectedQueryStatus
        /// </summary>
        public static readonly ProtectedQueryStatus TIMED_OUT = new ProtectedQueryStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectedQueryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectedQueryStatus FindValue(string value)
        {
            return FindValue<ProtectedQueryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectedQueryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectedQueryType.
    /// </summary>
    public class ProtectedQueryType : ConstantClass
    {

        /// <summary>
        /// Constant SQL for ProtectedQueryType
        /// </summary>
        public static readonly ProtectedQueryType SQL = new ProtectedQueryType("SQL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectedQueryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectedQueryType FindValue(string value)
        {
            return FindValue<ProtectedQueryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectedQueryType(string value)
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
        /// Constant COLLABORATION for ResourceType
        /// </summary>
        public static readonly ResourceType COLLABORATION = new ResourceType("COLLABORATION");
        /// <summary>
        /// Constant CONFIGURED_TABLE for ResourceType
        /// </summary>
        public static readonly ResourceType CONFIGURED_TABLE = new ResourceType("CONFIGURED_TABLE");
        /// <summary>
        /// Constant CONFIGURED_TABLE_ASSOCIATION for ResourceType
        /// </summary>
        public static readonly ResourceType CONFIGURED_TABLE_ASSOCIATION = new ResourceType("CONFIGURED_TABLE_ASSOCIATION");
        /// <summary>
        /// Constant MEMBERSHIP for ResourceType
        /// </summary>
        public static readonly ResourceType MEMBERSHIP = new ResourceType("MEMBERSHIP");

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
    /// Constants used for properties of type ResultFormat.
    /// </summary>
    public class ResultFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for ResultFormat
        /// </summary>
        public static readonly ResultFormat CSV = new ResultFormat("CSV");
        /// <summary>
        /// Constant PARQUET for ResultFormat
        /// </summary>
        public static readonly ResultFormat PARQUET = new ResultFormat("PARQUET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResultFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResultFormat FindValue(string value)
        {
            return FindValue<ResultFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResultFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalarFunctions.
    /// </summary>
    public class ScalarFunctions : ConstantClass
    {

        /// <summary>
        /// Constant ABS for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions ABS = new ScalarFunctions("ABS");
        /// <summary>
        /// Constant CAST for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions CAST = new ScalarFunctions("CAST");
        /// <summary>
        /// Constant CEILING for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions CEILING = new ScalarFunctions("CEILING");
        /// <summary>
        /// Constant COALESCE for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions COALESCE = new ScalarFunctions("COALESCE");
        /// <summary>
        /// Constant CONVERT for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions CONVERT = new ScalarFunctions("CONVERT");
        /// <summary>
        /// Constant CURRENT_DATE for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions CURRENT_DATE = new ScalarFunctions("CURRENT_DATE");
        /// <summary>
        /// Constant DATEADD for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions DATEADD = new ScalarFunctions("DATEADD");
        /// <summary>
        /// Constant EXTRACT for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions EXTRACT = new ScalarFunctions("EXTRACT");
        /// <summary>
        /// Constant FLOOR for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions FLOOR = new ScalarFunctions("FLOOR");
        /// <summary>
        /// Constant GETDATE for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions GETDATE = new ScalarFunctions("GETDATE");
        /// <summary>
        /// Constant LN for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions LN = new ScalarFunctions("LN");
        /// <summary>
        /// Constant LOG for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions LOG = new ScalarFunctions("LOG");
        /// <summary>
        /// Constant LOWER for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions LOWER = new ScalarFunctions("LOWER");
        /// <summary>
        /// Constant ROUND for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions ROUND = new ScalarFunctions("ROUND");
        /// <summary>
        /// Constant RTRIM for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions RTRIM = new ScalarFunctions("RTRIM");
        /// <summary>
        /// Constant SQRT for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions SQRT = new ScalarFunctions("SQRT");
        /// <summary>
        /// Constant SUBSTRING for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions SUBSTRING = new ScalarFunctions("SUBSTRING");
        /// <summary>
        /// Constant TO_CHAR for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions TO_CHAR = new ScalarFunctions("TO_CHAR");
        /// <summary>
        /// Constant TO_DATE for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions TO_DATE = new ScalarFunctions("TO_DATE");
        /// <summary>
        /// Constant TO_NUMBER for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions TO_NUMBER = new ScalarFunctions("TO_NUMBER");
        /// <summary>
        /// Constant TO_TIMESTAMP for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions TO_TIMESTAMP = new ScalarFunctions("TO_TIMESTAMP");
        /// <summary>
        /// Constant TRIM for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions TRIM = new ScalarFunctions("TRIM");
        /// <summary>
        /// Constant TRUNC for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions TRUNC = new ScalarFunctions("TRUNC");
        /// <summary>
        /// Constant UPPER for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions UPPER = new ScalarFunctions("UPPER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalarFunctions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalarFunctions FindValue(string value)
        {
            return FindValue<ScalarFunctions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalarFunctions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaConfiguration.
    /// </summary>
    public class SchemaConfiguration : ConstantClass
    {

        /// <summary>
        /// Constant DIFFERENTIAL_PRIVACY for SchemaConfiguration
        /// </summary>
        public static readonly SchemaConfiguration DIFFERENTIAL_PRIVACY = new SchemaConfiguration("DIFFERENTIAL_PRIVACY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaConfiguration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaConfiguration FindValue(string value)
        {
            return FindValue<SchemaConfiguration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaConfiguration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaStatus.
    /// </summary>
    public class SchemaStatus : ConstantClass
    {

        /// <summary>
        /// Constant NOT_READY for SchemaStatus
        /// </summary>
        public static readonly SchemaStatus NOT_READY = new SchemaStatus("NOT_READY");
        /// <summary>
        /// Constant READY for SchemaStatus
        /// </summary>
        public static readonly SchemaStatus READY = new SchemaStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaStatus FindValue(string value)
        {
            return FindValue<SchemaStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaStatusReasonCode.
    /// </summary>
    public class SchemaStatusReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant ADDITIONAL_ANALYSES_NOT_ALLOWED for SchemaStatusReasonCode
        /// </summary>
        public static readonly SchemaStatusReasonCode ADDITIONAL_ANALYSES_NOT_ALLOWED = new SchemaStatusReasonCode("ADDITIONAL_ANALYSES_NOT_ALLOWED");
        /// <summary>
        /// Constant ADDITIONAL_ANALYSES_NOT_CONFIGURED for SchemaStatusReasonCode
        /// </summary>
        public static readonly SchemaStatusReasonCode ADDITIONAL_ANALYSES_NOT_CONFIGURED = new SchemaStatusReasonCode("ADDITIONAL_ANALYSES_NOT_CONFIGURED");
        /// <summary>
        /// Constant ANALYSIS_PROVIDERS_NOT_CONFIGURED for SchemaStatusReasonCode
        /// </summary>
        public static readonly SchemaStatusReasonCode ANALYSIS_PROVIDERS_NOT_CONFIGURED = new SchemaStatusReasonCode("ANALYSIS_PROVIDERS_NOT_CONFIGURED");
        /// <summary>
        /// Constant ANALYSIS_RULE_MISSING for SchemaStatusReasonCode
        /// </summary>
        public static readonly SchemaStatusReasonCode ANALYSIS_RULE_MISSING = new SchemaStatusReasonCode("ANALYSIS_RULE_MISSING");
        /// <summary>
        /// Constant ANALYSIS_RULE_TYPES_NOT_COMPATIBLE for SchemaStatusReasonCode
        /// </summary>
        public static readonly SchemaStatusReasonCode ANALYSIS_RULE_TYPES_NOT_COMPATIBLE = new SchemaStatusReasonCode("ANALYSIS_RULE_TYPES_NOT_COMPATIBLE");
        /// <summary>
        /// Constant ANALYSIS_TEMPLATES_NOT_CONFIGURED for SchemaStatusReasonCode
        /// </summary>
        public static readonly SchemaStatusReasonCode ANALYSIS_TEMPLATES_NOT_CONFIGURED = new SchemaStatusReasonCode("ANALYSIS_TEMPLATES_NOT_CONFIGURED");
        /// <summary>
        /// Constant COLLABORATION_ANALYSIS_RULE_NOT_CONFIGURED for SchemaStatusReasonCode
        /// </summary>
        public static readonly SchemaStatusReasonCode COLLABORATION_ANALYSIS_RULE_NOT_CONFIGURED = new SchemaStatusReasonCode("COLLABORATION_ANALYSIS_RULE_NOT_CONFIGURED");
        /// <summary>
        /// Constant DIFFERENTIAL_PRIVACY_POLICY_NOT_CONFIGURED for SchemaStatusReasonCode
        /// </summary>
        public static readonly SchemaStatusReasonCode DIFFERENTIAL_PRIVACY_POLICY_NOT_CONFIGURED = new SchemaStatusReasonCode("DIFFERENTIAL_PRIVACY_POLICY_NOT_CONFIGURED");
        /// <summary>
        /// Constant ID_MAPPING_TABLE_NOT_POPULATED for SchemaStatusReasonCode
        /// </summary>
        public static readonly SchemaStatusReasonCode ID_MAPPING_TABLE_NOT_POPULATED = new SchemaStatusReasonCode("ID_MAPPING_TABLE_NOT_POPULATED");
        /// <summary>
        /// Constant RESULT_RECEIVERS_NOT_ALLOWED for SchemaStatusReasonCode
        /// </summary>
        public static readonly SchemaStatusReasonCode RESULT_RECEIVERS_NOT_ALLOWED = new SchemaStatusReasonCode("RESULT_RECEIVERS_NOT_ALLOWED");
        /// <summary>
        /// Constant RESULT_RECEIVERS_NOT_CONFIGURED for SchemaStatusReasonCode
        /// </summary>
        public static readonly SchemaStatusReasonCode RESULT_RECEIVERS_NOT_CONFIGURED = new SchemaStatusReasonCode("RESULT_RECEIVERS_NOT_CONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaStatusReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaStatusReasonCode FindValue(string value)
        {
            return FindValue<SchemaStatusReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaStatusReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaType.
    /// </summary>
    public class SchemaType : ConstantClass
    {

        /// <summary>
        /// Constant ID_MAPPING_TABLE for SchemaType
        /// </summary>
        public static readonly SchemaType ID_MAPPING_TABLE = new SchemaType("ID_MAPPING_TABLE");
        /// <summary>
        /// Constant TABLE for SchemaType
        /// </summary>
        public static readonly SchemaType TABLE = new SchemaType("TABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaType FindValue(string value)
        {
            return FindValue<SchemaType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SelectedAnalysisMethod.
    /// </summary>
    public class SelectedAnalysisMethod : ConstantClass
    {

        /// <summary>
        /// Constant DIRECT_JOB for SelectedAnalysisMethod
        /// </summary>
        public static readonly SelectedAnalysisMethod DIRECT_JOB = new SelectedAnalysisMethod("DIRECT_JOB");
        /// <summary>
        /// Constant DIRECT_QUERY for SelectedAnalysisMethod
        /// </summary>
        public static readonly SelectedAnalysisMethod DIRECT_QUERY = new SelectedAnalysisMethod("DIRECT_QUERY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SelectedAnalysisMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SelectedAnalysisMethod FindValue(string value)
        {
            return FindValue<SelectedAnalysisMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SelectedAnalysisMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetProtectedJobStatus.
    /// </summary>
    public class TargetProtectedJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for TargetProtectedJobStatus
        /// </summary>
        public static readonly TargetProtectedJobStatus CANCELLED = new TargetProtectedJobStatus("CANCELLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetProtectedJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetProtectedJobStatus FindValue(string value)
        {
            return FindValue<TargetProtectedJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetProtectedJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetProtectedQueryStatus.
    /// </summary>
    public class TargetProtectedQueryStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for TargetProtectedQueryStatus
        /// </summary>
        public static readonly TargetProtectedQueryStatus CANCELLED = new TargetProtectedQueryStatus("CANCELLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetProtectedQueryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetProtectedQueryStatus FindValue(string value)
        {
            return FindValue<TargetProtectedQueryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetProtectedQueryStatus(string value)
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
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant IAM_SYNCHRONIZATION_DELAY for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason IAM_SYNCHRONIZATION_DELAY = new ValidationExceptionReason("IAM_SYNCHRONIZATION_DELAY");
        /// <summary>
        /// Constant INVALID_CONFIGURATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_CONFIGURATION = new ValidationExceptionReason("INVALID_CONFIGURATION");
        /// <summary>
        /// Constant INVALID_QUERY for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_QUERY = new ValidationExceptionReason("INVALID_QUERY");

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


    /// <summary>
    /// Constants used for properties of type WorkerComputeType.
    /// </summary>
    public class WorkerComputeType : ConstantClass
    {

        /// <summary>
        /// Constant CR1X for WorkerComputeType
        /// </summary>
        public static readonly WorkerComputeType CR1X = new WorkerComputeType("CR.1X");
        /// <summary>
        /// Constant CR4X for WorkerComputeType
        /// </summary>
        public static readonly WorkerComputeType CR4X = new WorkerComputeType("CR.4X");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkerComputeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkerComputeType FindValue(string value)
        {
            return FindValue<WorkerComputeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkerComputeType(string value)
        {
            return FindValue(value);
        }
    }

}