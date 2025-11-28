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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ComputeOptimizerAutomation
{

    /// <summary>
    /// Constants used for properties of type AutomationEventFilterName.
    /// </summary>
    public class AutomationEventFilterName : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for AutomationEventFilterName
        /// </summary>
        public static readonly AutomationEventFilterName AccountId = new AutomationEventFilterName("AccountId");
        /// <summary>
        /// Constant EventStatus for AutomationEventFilterName
        /// </summary>
        public static readonly AutomationEventFilterName EventStatus = new AutomationEventFilterName("EventStatus");
        /// <summary>
        /// Constant EventType for AutomationEventFilterName
        /// </summary>
        public static readonly AutomationEventFilterName EventType = new AutomationEventFilterName("EventType");
        /// <summary>
        /// Constant ResourceType for AutomationEventFilterName
        /// </summary>
        public static readonly AutomationEventFilterName ResourceType = new AutomationEventFilterName("ResourceType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomationEventFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomationEventFilterName FindValue(string value)
        {
            return FindValue<AutomationEventFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomationEventFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutomationRuleFilterName.
    /// </summary>
    public class AutomationRuleFilterName : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for AutomationRuleFilterName
        /// </summary>
        public static readonly AutomationRuleFilterName AccountId = new AutomationRuleFilterName("AccountId");
        /// <summary>
        /// Constant Name for AutomationRuleFilterName
        /// </summary>
        public static readonly AutomationRuleFilterName Name = new AutomationRuleFilterName("Name");
        /// <summary>
        /// Constant OrganizationConfigurationRuleApplyOrder for AutomationRuleFilterName
        /// </summary>
        public static readonly AutomationRuleFilterName OrganizationConfigurationRuleApplyOrder = new AutomationRuleFilterName("OrganizationConfigurationRuleApplyOrder");
        /// <summary>
        /// Constant RecommendedActionType for AutomationRuleFilterName
        /// </summary>
        public static readonly AutomationRuleFilterName RecommendedActionType = new AutomationRuleFilterName("RecommendedActionType");
        /// <summary>
        /// Constant RuleType for AutomationRuleFilterName
        /// </summary>
        public static readonly AutomationRuleFilterName RuleType = new AutomationRuleFilterName("RuleType");
        /// <summary>
        /// Constant Status for AutomationRuleFilterName
        /// </summary>
        public static readonly AutomationRuleFilterName Status = new AutomationRuleFilterName("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomationRuleFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomationRuleFilterName FindValue(string value)
        {
            return FindValue<AutomationRuleFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomationRuleFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant NumericEquals for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NumericEquals = new ComparisonOperator("NumericEquals");
        /// <summary>
        /// Constant NumericGreaterThan for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NumericGreaterThan = new ComparisonOperator("NumericGreaterThan");
        /// <summary>
        /// Constant NumericGreaterThanEquals for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NumericGreaterThanEquals = new ComparisonOperator("NumericGreaterThanEquals");
        /// <summary>
        /// Constant NumericLessThan for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NumericLessThan = new ComparisonOperator("NumericLessThan");
        /// <summary>
        /// Constant NumericLessThanEquals for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NumericLessThanEquals = new ComparisonOperator("NumericLessThanEquals");
        /// <summary>
        /// Constant NumericNotEquals for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NumericNotEquals = new ComparisonOperator("NumericNotEquals");
        /// <summary>
        /// Constant StringEquals for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator StringEquals = new ComparisonOperator("StringEquals");
        /// <summary>
        /// Constant StringEqualsIgnoreCase for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator StringEqualsIgnoreCase = new ComparisonOperator("StringEqualsIgnoreCase");
        /// <summary>
        /// Constant StringLike for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator StringLike = new ComparisonOperator("StringLike");
        /// <summary>
        /// Constant StringNotEquals for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator StringNotEquals = new ComparisonOperator("StringNotEquals");
        /// <summary>
        /// Constant StringNotEqualsIgnoreCase for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator StringNotEqualsIgnoreCase = new ComparisonOperator("StringNotEqualsIgnoreCase");
        /// <summary>
        /// Constant StringNotLike for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator StringNotLike = new ComparisonOperator("StringNotLike");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonOperator FindValue(string value)
        {
            return FindValue<ComparisonOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnrollmentStatus.
    /// </summary>
    public class EnrollmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for EnrollmentStatus
        /// </summary>
        public static readonly EnrollmentStatus Active = new EnrollmentStatus("Active");
        /// <summary>
        /// Constant Failed for EnrollmentStatus
        /// </summary>
        public static readonly EnrollmentStatus Failed = new EnrollmentStatus("Failed");
        /// <summary>
        /// Constant Inactive for EnrollmentStatus
        /// </summary>
        public static readonly EnrollmentStatus Inactive = new EnrollmentStatus("Inactive");
        /// <summary>
        /// Constant Pending for EnrollmentStatus
        /// </summary>
        public static readonly EnrollmentStatus Pending = new EnrollmentStatus("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnrollmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnrollmentStatus FindValue(string value)
        {
            return FindValue<EnrollmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnrollmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventStatus.
    /// </summary>
    public class EventStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for EventStatus
        /// </summary>
        public static readonly EventStatus Cancelled = new EventStatus("Cancelled");
        /// <summary>
        /// Constant Complete for EventStatus
        /// </summary>
        public static readonly EventStatus Complete = new EventStatus("Complete");
        /// <summary>
        /// Constant Failed for EventStatus
        /// </summary>
        public static readonly EventStatus Failed = new EventStatus("Failed");
        /// <summary>
        /// Constant InProgress for EventStatus
        /// </summary>
        public static readonly EventStatus InProgress = new EventStatus("InProgress");
        /// <summary>
        /// Constant Ready for EventStatus
        /// </summary>
        public static readonly EventStatus Ready = new EventStatus("Ready");
        /// <summary>
        /// Constant RollbackComplete for EventStatus
        /// </summary>
        public static readonly EventStatus RollbackComplete = new EventStatus("RollbackComplete");
        /// <summary>
        /// Constant RollbackFailed for EventStatus
        /// </summary>
        public static readonly EventStatus RollbackFailed = new EventStatus("RollbackFailed");
        /// <summary>
        /// Constant RollbackInProgress for EventStatus
        /// </summary>
        public static readonly EventStatus RollbackInProgress = new EventStatus("RollbackInProgress");
        /// <summary>
        /// Constant RollbackReady for EventStatus
        /// </summary>
        public static readonly EventStatus RollbackReady = new EventStatus("RollbackReady");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventStatus FindValue(string value)
        {
            return FindValue<EventStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventStatus(string value)
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
        /// Constant SnapshotAndDeleteUnattachedEbsVolume for EventType
        /// </summary>
        public static readonly EventType SnapshotAndDeleteUnattachedEbsVolume = new EventType("SnapshotAndDeleteUnattachedEbsVolume");
        /// <summary>
        /// Constant UpgradeEbsVolumeType for EventType
        /// </summary>
        public static readonly EventType UpgradeEbsVolumeType = new EventType("UpgradeEbsVolumeType");

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
    /// Constants used for properties of type OrganizationRuleMode.
    /// </summary>
    public class OrganizationRuleMode : ConstantClass
    {

        /// <summary>
        /// Constant AnyAllowed for OrganizationRuleMode
        /// </summary>
        public static readonly OrganizationRuleMode AnyAllowed = new OrganizationRuleMode("AnyAllowed");
        /// <summary>
        /// Constant NoneAllowed for OrganizationRuleMode
        /// </summary>
        public static readonly OrganizationRuleMode NoneAllowed = new OrganizationRuleMode("NoneAllowed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationRuleMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationRuleMode FindValue(string value)
        {
            return FindValue<OrganizationRuleMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationRuleMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendedActionFilterName.
    /// </summary>
    public class RecommendedActionFilterName : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for RecommendedActionFilterName
        /// </summary>
        public static readonly RecommendedActionFilterName AccountId = new RecommendedActionFilterName("AccountId");
        /// <summary>
        /// Constant CurrentResourceDetailsEbsVolumeType for RecommendedActionFilterName
        /// </summary>
        public static readonly RecommendedActionFilterName CurrentResourceDetailsEbsVolumeType = new RecommendedActionFilterName("CurrentResourceDetailsEbsVolumeType");
        /// <summary>
        /// Constant LookBackPeriodInDays for RecommendedActionFilterName
        /// </summary>
        public static readonly RecommendedActionFilterName LookBackPeriodInDays = new RecommendedActionFilterName("LookBackPeriodInDays");
        /// <summary>
        /// Constant RecommendedActionType for RecommendedActionFilterName
        /// </summary>
        public static readonly RecommendedActionFilterName RecommendedActionType = new RecommendedActionFilterName("RecommendedActionType");
        /// <summary>
        /// Constant ResourceId for RecommendedActionFilterName
        /// </summary>
        public static readonly RecommendedActionFilterName ResourceId = new RecommendedActionFilterName("ResourceId");
        /// <summary>
        /// Constant ResourceTagsKey for RecommendedActionFilterName
        /// </summary>
        public static readonly RecommendedActionFilterName ResourceTagsKey = new RecommendedActionFilterName("ResourceTagsKey");
        /// <summary>
        /// Constant ResourceTagsValue for RecommendedActionFilterName
        /// </summary>
        public static readonly RecommendedActionFilterName ResourceTagsValue = new RecommendedActionFilterName("ResourceTagsValue");
        /// <summary>
        /// Constant ResourceType for RecommendedActionFilterName
        /// </summary>
        public static readonly RecommendedActionFilterName ResourceType = new RecommendedActionFilterName("ResourceType");
        /// <summary>
        /// Constant RestartNeeded for RecommendedActionFilterName
        /// </summary>
        public static readonly RecommendedActionFilterName RestartNeeded = new RecommendedActionFilterName("RestartNeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendedActionFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendedActionFilterName FindValue(string value)
        {
            return FindValue<RecommendedActionFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendedActionFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendedActionType.
    /// </summary>
    public class RecommendedActionType : ConstantClass
    {

        /// <summary>
        /// Constant SnapshotAndDeleteUnattachedEbsVolume for RecommendedActionType
        /// </summary>
        public static readonly RecommendedActionType SnapshotAndDeleteUnattachedEbsVolume = new RecommendedActionType("SnapshotAndDeleteUnattachedEbsVolume");
        /// <summary>
        /// Constant UpgradeEbsVolumeType for RecommendedActionType
        /// </summary>
        public static readonly RecommendedActionType UpgradeEbsVolumeType = new RecommendedActionType("UpgradeEbsVolumeType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendedActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendedActionType FindValue(string value)
        {
            return FindValue<RecommendedActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendedActionType(string value)
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
        /// Constant EbsVolume for ResourceType
        /// </summary>
        public static readonly ResourceType EbsVolume = new ResourceType("EbsVolume");

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
    /// Constants used for properties of type RuleApplyOrder.
    /// </summary>
    public class RuleApplyOrder : ConstantClass
    {

        /// <summary>
        /// Constant AfterAccountRules for RuleApplyOrder
        /// </summary>
        public static readonly RuleApplyOrder AfterAccountRules = new RuleApplyOrder("AfterAccountRules");
        /// <summary>
        /// Constant BeforeAccountRules for RuleApplyOrder
        /// </summary>
        public static readonly RuleApplyOrder BeforeAccountRules = new RuleApplyOrder("BeforeAccountRules");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleApplyOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleApplyOrder FindValue(string value)
        {
            return FindValue<RuleApplyOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleApplyOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleStatus.
    /// </summary>
    public class RuleStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for RuleStatus
        /// </summary>
        public static readonly RuleStatus Active = new RuleStatus("Active");
        /// <summary>
        /// Constant Inactive for RuleStatus
        /// </summary>
        public static readonly RuleStatus Inactive = new RuleStatus("Inactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleStatus FindValue(string value)
        {
            return FindValue<RuleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleType.
    /// </summary>
    public class RuleType : ConstantClass
    {

        /// <summary>
        /// Constant AccountRule for RuleType
        /// </summary>
        public static readonly RuleType AccountRule = new RuleType("AccountRule");
        /// <summary>
        /// Constant OrganizationRule for RuleType
        /// </summary>
        public static readonly RuleType OrganizationRule = new RuleType("OrganizationRule");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleType FindValue(string value)
        {
            return FindValue<RuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SavingsEstimationMode.
    /// </summary>
    public class SavingsEstimationMode : ConstantClass
    {

        /// <summary>
        /// Constant AfterDiscount for SavingsEstimationMode
        /// </summary>
        public static readonly SavingsEstimationMode AfterDiscount = new SavingsEstimationMode("AfterDiscount");
        /// <summary>
        /// Constant BeforeDiscount for SavingsEstimationMode
        /// </summary>
        public static readonly SavingsEstimationMode BeforeDiscount = new SavingsEstimationMode("BeforeDiscount");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsEstimationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsEstimationMode FindValue(string value)
        {
            return FindValue<SavingsEstimationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsEstimationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepStatus.
    /// </summary>
    public class StepStatus : ConstantClass
    {

        /// <summary>
        /// Constant Complete for StepStatus
        /// </summary>
        public static readonly StepStatus Complete = new StepStatus("Complete");
        /// <summary>
        /// Constant Failed for StepStatus
        /// </summary>
        public static readonly StepStatus Failed = new StepStatus("Failed");
        /// <summary>
        /// Constant InProgress for StepStatus
        /// </summary>
        public static readonly StepStatus InProgress = new StepStatus("InProgress");
        /// <summary>
        /// Constant Ready for StepStatus
        /// </summary>
        public static readonly StepStatus Ready = new StepStatus("Ready");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepStatus FindValue(string value)
        {
            return FindValue<StepStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepType.
    /// </summary>
    public class StepType : ConstantClass
    {

        /// <summary>
        /// Constant CreateEbsSnapshot for StepType
        /// </summary>
        public static readonly StepType CreateEbsSnapshot = new StepType("CreateEbsSnapshot");
        /// <summary>
        /// Constant CreateEbsVolume for StepType
        /// </summary>
        public static readonly StepType CreateEbsVolume = new StepType("CreateEbsVolume");
        /// <summary>
        /// Constant DeleteEbsVolume for StepType
        /// </summary>
        public static readonly StepType DeleteEbsVolume = new StepType("DeleteEbsVolume");
        /// <summary>
        /// Constant ModifyEbsVolume for StepType
        /// </summary>
        public static readonly StepType ModifyEbsVolume = new StepType("ModifyEbsVolume");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepType FindValue(string value)
        {
            return FindValue<StepType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SummaryDimensionKey.
    /// </summary>
    public class SummaryDimensionKey : ConstantClass
    {

        /// <summary>
        /// Constant EventStatus for SummaryDimensionKey
        /// </summary>
        public static readonly SummaryDimensionKey EventStatus = new SummaryDimensionKey("EventStatus");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SummaryDimensionKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SummaryDimensionKey FindValue(string value)
        {
            return FindValue<SummaryDimensionKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SummaryDimensionKey(string value)
        {
            return FindValue(value);
        }
    }

}