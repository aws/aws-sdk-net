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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CostOptimizationHub
{

    /// <summary>
    /// Constants used for properties of type ActionType.
    /// </summary>
    public class ActionType : ConstantClass
    {

        /// <summary>
        /// Constant Delete for ActionType
        /// </summary>
        public static readonly ActionType Delete = new ActionType("Delete");
        /// <summary>
        /// Constant MigrateToGraviton for ActionType
        /// </summary>
        public static readonly ActionType MigrateToGraviton = new ActionType("MigrateToGraviton");
        /// <summary>
        /// Constant PurchaseReservedInstances for ActionType
        /// </summary>
        public static readonly ActionType PurchaseReservedInstances = new ActionType("PurchaseReservedInstances");
        /// <summary>
        /// Constant PurchaseSavingsPlans for ActionType
        /// </summary>
        public static readonly ActionType PurchaseSavingsPlans = new ActionType("PurchaseSavingsPlans");
        /// <summary>
        /// Constant Rightsize for ActionType
        /// </summary>
        public static readonly ActionType Rightsize = new ActionType("Rightsize");
        /// <summary>
        /// Constant ScaleIn for ActionType
        /// </summary>
        public static readonly ActionType ScaleIn = new ActionType("ScaleIn");
        /// <summary>
        /// Constant Stop for ActionType
        /// </summary>
        public static readonly ActionType Stop = new ActionType("Stop");
        /// <summary>
        /// Constant Upgrade for ActionType
        /// </summary>
        public static readonly ActionType Upgrade = new ActionType("Upgrade");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionType FindValue(string value)
        {
            return FindValue<ActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AllocationStrategy.
    /// </summary>
    public class AllocationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant LowestPrice for AllocationStrategy
        /// </summary>
        public static readonly AllocationStrategy LowestPrice = new AllocationStrategy("LowestPrice");
        /// <summary>
        /// Constant Prioritized for AllocationStrategy
        /// </summary>
        public static readonly AllocationStrategy Prioritized = new AllocationStrategy("Prioritized");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AllocationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllocationStrategy FindValue(string value)
        {
            return FindValue<AllocationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllocationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ec2AutoScalingGroupType.
    /// </summary>
    public class Ec2AutoScalingGroupType : ConstantClass
    {

        /// <summary>
        /// Constant MixedInstanceTypes for Ec2AutoScalingGroupType
        /// </summary>
        public static readonly Ec2AutoScalingGroupType MixedInstanceTypes = new Ec2AutoScalingGroupType("MixedInstanceTypes");
        /// <summary>
        /// Constant SingleInstanceType for Ec2AutoScalingGroupType
        /// </summary>
        public static readonly Ec2AutoScalingGroupType SingleInstanceType = new Ec2AutoScalingGroupType("SingleInstanceType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ec2AutoScalingGroupType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ec2AutoScalingGroupType FindValue(string value)
        {
            return FindValue<Ec2AutoScalingGroupType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ec2AutoScalingGroupType(string value)
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
        /// Constant Inactive for EnrollmentStatus
        /// </summary>
        public static readonly EnrollmentStatus Inactive = new EnrollmentStatus("Inactive");

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
    /// Constants used for properties of type ImplementationEffort.
    /// </summary>
    public class ImplementationEffort : ConstantClass
    {

        /// <summary>
        /// Constant High for ImplementationEffort
        /// </summary>
        public static readonly ImplementationEffort High = new ImplementationEffort("High");
        /// <summary>
        /// Constant Low for ImplementationEffort
        /// </summary>
        public static readonly ImplementationEffort Low = new ImplementationEffort("Low");
        /// <summary>
        /// Constant Medium for ImplementationEffort
        /// </summary>
        public static readonly ImplementationEffort Medium = new ImplementationEffort("Medium");
        /// <summary>
        /// Constant VeryHigh for ImplementationEffort
        /// </summary>
        public static readonly ImplementationEffort VeryHigh = new ImplementationEffort("VeryHigh");
        /// <summary>
        /// Constant VeryLow for ImplementationEffort
        /// </summary>
        public static readonly ImplementationEffort VeryLow = new ImplementationEffort("VeryLow");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImplementationEffort(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImplementationEffort FindValue(string value)
        {
            return FindValue<ImplementationEffort>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImplementationEffort(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemberAccountDiscountVisibility.
    /// </summary>
    public class MemberAccountDiscountVisibility : ConstantClass
    {

        /// <summary>
        /// Constant All for MemberAccountDiscountVisibility
        /// </summary>
        public static readonly MemberAccountDiscountVisibility All = new MemberAccountDiscountVisibility("All");
        /// <summary>
        /// Constant None for MemberAccountDiscountVisibility
        /// </summary>
        public static readonly MemberAccountDiscountVisibility None = new MemberAccountDiscountVisibility("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberAccountDiscountVisibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberAccountDiscountVisibility FindValue(string value)
        {
            return FindValue<MemberAccountDiscountVisibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberAccountDiscountVisibility(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Order.
    /// </summary>
    public class Order : ConstantClass
    {

        /// <summary>
        /// Constant Asc for Order
        /// </summary>
        public static readonly Order Asc = new Order("Asc");
        /// <summary>
        /// Constant Desc for Order
        /// </summary>
        public static readonly Order Desc = new Order("Desc");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Order(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Order FindValue(string value)
        {
            return FindValue<Order>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Order(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PaymentOption.
    /// </summary>
    public class PaymentOption : ConstantClass
    {

        /// <summary>
        /// Constant AllUpfront for PaymentOption
        /// </summary>
        public static readonly PaymentOption AllUpfront = new PaymentOption("AllUpfront");
        /// <summary>
        /// Constant NoUpfront for PaymentOption
        /// </summary>
        public static readonly PaymentOption NoUpfront = new PaymentOption("NoUpfront");
        /// <summary>
        /// Constant PartialUpfront for PaymentOption
        /// </summary>
        public static readonly PaymentOption PartialUpfront = new PaymentOption("PartialUpfront");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PaymentOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentOption FindValue(string value)
        {
            return FindValue<PaymentOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentOption(string value)
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
        /// Constant AuroraDbClusterStorage for ResourceType
        /// </summary>
        public static readonly ResourceType AuroraDbClusterStorage = new ResourceType("AuroraDbClusterStorage");
        /// <summary>
        /// Constant ComputeSavingsPlans for ResourceType
        /// </summary>
        public static readonly ResourceType ComputeSavingsPlans = new ResourceType("ComputeSavingsPlans");
        /// <summary>
        /// Constant DynamoDbReservedCapacity for ResourceType
        /// </summary>
        public static readonly ResourceType DynamoDbReservedCapacity = new ResourceType("DynamoDbReservedCapacity");
        /// <summary>
        /// Constant EbsVolume for ResourceType
        /// </summary>
        public static readonly ResourceType EbsVolume = new ResourceType("EbsVolume");
        /// <summary>
        /// Constant Ec2AutoScalingGroup for ResourceType
        /// </summary>
        public static readonly ResourceType Ec2AutoScalingGroup = new ResourceType("Ec2AutoScalingGroup");
        /// <summary>
        /// Constant Ec2Instance for ResourceType
        /// </summary>
        public static readonly ResourceType Ec2Instance = new ResourceType("Ec2Instance");
        /// <summary>
        /// Constant Ec2InstanceSavingsPlans for ResourceType
        /// </summary>
        public static readonly ResourceType Ec2InstanceSavingsPlans = new ResourceType("Ec2InstanceSavingsPlans");
        /// <summary>
        /// Constant Ec2ReservedInstances for ResourceType
        /// </summary>
        public static readonly ResourceType Ec2ReservedInstances = new ResourceType("Ec2ReservedInstances");
        /// <summary>
        /// Constant EcsService for ResourceType
        /// </summary>
        public static readonly ResourceType EcsService = new ResourceType("EcsService");
        /// <summary>
        /// Constant ElastiCacheReservedInstances for ResourceType
        /// </summary>
        public static readonly ResourceType ElastiCacheReservedInstances = new ResourceType("ElastiCacheReservedInstances");
        /// <summary>
        /// Constant LambdaFunction for ResourceType
        /// </summary>
        public static readonly ResourceType LambdaFunction = new ResourceType("LambdaFunction");
        /// <summary>
        /// Constant MemoryDbReservedInstances for ResourceType
        /// </summary>
        public static readonly ResourceType MemoryDbReservedInstances = new ResourceType("MemoryDbReservedInstances");
        /// <summary>
        /// Constant OpenSearchReservedInstances for ResourceType
        /// </summary>
        public static readonly ResourceType OpenSearchReservedInstances = new ResourceType("OpenSearchReservedInstances");
        /// <summary>
        /// Constant RdsDbInstance for ResourceType
        /// </summary>
        public static readonly ResourceType RdsDbInstance = new ResourceType("RdsDbInstance");
        /// <summary>
        /// Constant RdsDbInstanceStorage for ResourceType
        /// </summary>
        public static readonly ResourceType RdsDbInstanceStorage = new ResourceType("RdsDbInstanceStorage");
        /// <summary>
        /// Constant RdsReservedInstances for ResourceType
        /// </summary>
        public static readonly ResourceType RdsReservedInstances = new ResourceType("RdsReservedInstances");
        /// <summary>
        /// Constant RedshiftReservedInstances for ResourceType
        /// </summary>
        public static readonly ResourceType RedshiftReservedInstances = new ResourceType("RedshiftReservedInstances");
        /// <summary>
        /// Constant SageMakerSavingsPlans for ResourceType
        /// </summary>
        public static readonly ResourceType SageMakerSavingsPlans = new ResourceType("SageMakerSavingsPlans");

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
    /// Constants used for properties of type SavingsEstimationMode.
    /// </summary>
    public class SavingsEstimationMode : ConstantClass
    {

        /// <summary>
        /// Constant AfterDiscounts for SavingsEstimationMode
        /// </summary>
        public static readonly SavingsEstimationMode AfterDiscounts = new SavingsEstimationMode("AfterDiscounts");
        /// <summary>
        /// Constant BeforeDiscounts for SavingsEstimationMode
        /// </summary>
        public static readonly SavingsEstimationMode BeforeDiscounts = new SavingsEstimationMode("BeforeDiscounts");

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
    /// Constants used for properties of type Source.
    /// </summary>
    public class Source : ConstantClass
    {

        /// <summary>
        /// Constant ComputeOptimizer for Source
        /// </summary>
        public static readonly Source ComputeOptimizer = new Source("ComputeOptimizer");
        /// <summary>
        /// Constant CostExplorer for Source
        /// </summary>
        public static readonly Source CostExplorer = new Source("CostExplorer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Source(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Source FindValue(string value)
        {
            return FindValue<Source>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Source(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SummaryMetrics.
    /// </summary>
    public class SummaryMetrics : ConstantClass
    {

        /// <summary>
        /// Constant SavingsPercentage for SummaryMetrics
        /// </summary>
        public static readonly SummaryMetrics SavingsPercentage = new SummaryMetrics("SavingsPercentage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SummaryMetrics(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SummaryMetrics FindValue(string value)
        {
            return FindValue<SummaryMetrics>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SummaryMetrics(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Term.
    /// </summary>
    public class Term : ConstantClass
    {

        /// <summary>
        /// Constant OneYear for Term
        /// </summary>
        public static readonly Term OneYear = new Term("OneYear");
        /// <summary>
        /// Constant ThreeYears for Term
        /// </summary>
        public static readonly Term ThreeYears = new Term("ThreeYears");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Term(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Term FindValue(string value)
        {
            return FindValue<Term>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Term(string value)
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
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("FieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("Other");

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