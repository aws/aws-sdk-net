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
    /// Constants used for properties of type AnalysisMethod.
    /// </summary>
    public class AnalysisMethod : ConstantClass
    {

        /// <summary>
        /// Constant DIRECT_QUERY for AnalysisMethod
        /// </summary>
        public static readonly AnalysisMethod DIRECT_QUERY = new AnalysisMethod("DIRECT_QUERY");

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
        /// Constant FLOOR for ScalarFunctions
        /// </summary>
        public static readonly ScalarFunctions FLOOR = new ScalarFunctions("FLOOR");
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
    /// Constants used for properties of type SchemaType.
    /// </summary>
    public class SchemaType : ConstantClass
    {

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

}