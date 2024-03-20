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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SavingsPlans
{

    /// <summary>
    /// Constants used for properties of type CurrencyCode.
    /// </summary>
    public class CurrencyCode : ConstantClass
    {

        /// <summary>
        /// Constant CNY for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CNY = new CurrencyCode("CNY");
        /// <summary>
        /// Constant USD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode USD = new CurrencyCode("USD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CurrencyCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CurrencyCode FindValue(string value)
        {
            return FindValue<CurrencyCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CurrencyCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SavingsPlanOfferingFilterAttribute.
    /// </summary>
    public class SavingsPlanOfferingFilterAttribute : ConstantClass
    {

        /// <summary>
        /// Constant InstanceFamily for SavingsPlanOfferingFilterAttribute
        /// </summary>
        public static readonly SavingsPlanOfferingFilterAttribute InstanceFamily = new SavingsPlanOfferingFilterAttribute("instanceFamily");
        /// <summary>
        /// Constant Region for SavingsPlanOfferingFilterAttribute
        /// </summary>
        public static readonly SavingsPlanOfferingFilterAttribute Region = new SavingsPlanOfferingFilterAttribute("region");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsPlanOfferingFilterAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsPlanOfferingFilterAttribute FindValue(string value)
        {
            return FindValue<SavingsPlanOfferingFilterAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsPlanOfferingFilterAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SavingsPlanOfferingPropertyKey.
    /// </summary>
    public class SavingsPlanOfferingPropertyKey : ConstantClass
    {

        /// <summary>
        /// Constant InstanceFamily for SavingsPlanOfferingPropertyKey
        /// </summary>
        public static readonly SavingsPlanOfferingPropertyKey InstanceFamily = new SavingsPlanOfferingPropertyKey("instanceFamily");
        /// <summary>
        /// Constant Region for SavingsPlanOfferingPropertyKey
        /// </summary>
        public static readonly SavingsPlanOfferingPropertyKey Region = new SavingsPlanOfferingPropertyKey("region");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsPlanOfferingPropertyKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsPlanOfferingPropertyKey FindValue(string value)
        {
            return FindValue<SavingsPlanOfferingPropertyKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsPlanOfferingPropertyKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SavingsPlanPaymentOption.
    /// </summary>
    public class SavingsPlanPaymentOption : ConstantClass
    {

        /// <summary>
        /// Constant AllUpfront for SavingsPlanPaymentOption
        /// </summary>
        public static readonly SavingsPlanPaymentOption AllUpfront = new SavingsPlanPaymentOption("All Upfront");
        /// <summary>
        /// Constant NoUpfront for SavingsPlanPaymentOption
        /// </summary>
        public static readonly SavingsPlanPaymentOption NoUpfront = new SavingsPlanPaymentOption("No Upfront");
        /// <summary>
        /// Constant PartialUpfront for SavingsPlanPaymentOption
        /// </summary>
        public static readonly SavingsPlanPaymentOption PartialUpfront = new SavingsPlanPaymentOption("Partial Upfront");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsPlanPaymentOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsPlanPaymentOption FindValue(string value)
        {
            return FindValue<SavingsPlanPaymentOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsPlanPaymentOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SavingsPlanProductType.
    /// </summary>
    public class SavingsPlanProductType : ConstantClass
    {

        /// <summary>
        /// Constant EC2 for SavingsPlanProductType
        /// </summary>
        public static readonly SavingsPlanProductType EC2 = new SavingsPlanProductType("EC2");
        /// <summary>
        /// Constant Fargate for SavingsPlanProductType
        /// </summary>
        public static readonly SavingsPlanProductType Fargate = new SavingsPlanProductType("Fargate");
        /// <summary>
        /// Constant Lambda for SavingsPlanProductType
        /// </summary>
        public static readonly SavingsPlanProductType Lambda = new SavingsPlanProductType("Lambda");
        /// <summary>
        /// Constant SageMaker for SavingsPlanProductType
        /// </summary>
        public static readonly SavingsPlanProductType SageMaker = new SavingsPlanProductType("SageMaker");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsPlanProductType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsPlanProductType FindValue(string value)
        {
            return FindValue<SavingsPlanProductType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsPlanProductType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SavingsPlanRateFilterAttribute.
    /// </summary>
    public class SavingsPlanRateFilterAttribute : ConstantClass
    {

        /// <summary>
        /// Constant InstanceFamily for SavingsPlanRateFilterAttribute
        /// </summary>
        public static readonly SavingsPlanRateFilterAttribute InstanceFamily = new SavingsPlanRateFilterAttribute("instanceFamily");
        /// <summary>
        /// Constant InstanceType for SavingsPlanRateFilterAttribute
        /// </summary>
        public static readonly SavingsPlanRateFilterAttribute InstanceType = new SavingsPlanRateFilterAttribute("instanceType");
        /// <summary>
        /// Constant ProductDescription for SavingsPlanRateFilterAttribute
        /// </summary>
        public static readonly SavingsPlanRateFilterAttribute ProductDescription = new SavingsPlanRateFilterAttribute("productDescription");
        /// <summary>
        /// Constant ProductId for SavingsPlanRateFilterAttribute
        /// </summary>
        public static readonly SavingsPlanRateFilterAttribute ProductId = new SavingsPlanRateFilterAttribute("productId");
        /// <summary>
        /// Constant Region for SavingsPlanRateFilterAttribute
        /// </summary>
        public static readonly SavingsPlanRateFilterAttribute Region = new SavingsPlanRateFilterAttribute("region");
        /// <summary>
        /// Constant Tenancy for SavingsPlanRateFilterAttribute
        /// </summary>
        public static readonly SavingsPlanRateFilterAttribute Tenancy = new SavingsPlanRateFilterAttribute("tenancy");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsPlanRateFilterAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsPlanRateFilterAttribute FindValue(string value)
        {
            return FindValue<SavingsPlanRateFilterAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsPlanRateFilterAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SavingsPlanRateFilterName.
    /// </summary>
    public class SavingsPlanRateFilterName : ConstantClass
    {

        /// <summary>
        /// Constant InstanceType for SavingsPlanRateFilterName
        /// </summary>
        public static readonly SavingsPlanRateFilterName InstanceType = new SavingsPlanRateFilterName("instanceType");
        /// <summary>
        /// Constant Operation for SavingsPlanRateFilterName
        /// </summary>
        public static readonly SavingsPlanRateFilterName Operation = new SavingsPlanRateFilterName("operation");
        /// <summary>
        /// Constant ProductDescription for SavingsPlanRateFilterName
        /// </summary>
        public static readonly SavingsPlanRateFilterName ProductDescription = new SavingsPlanRateFilterName("productDescription");
        /// <summary>
        /// Constant ProductType for SavingsPlanRateFilterName
        /// </summary>
        public static readonly SavingsPlanRateFilterName ProductType = new SavingsPlanRateFilterName("productType");
        /// <summary>
        /// Constant Region for SavingsPlanRateFilterName
        /// </summary>
        public static readonly SavingsPlanRateFilterName Region = new SavingsPlanRateFilterName("region");
        /// <summary>
        /// Constant ServiceCode for SavingsPlanRateFilterName
        /// </summary>
        public static readonly SavingsPlanRateFilterName ServiceCode = new SavingsPlanRateFilterName("serviceCode");
        /// <summary>
        /// Constant Tenancy for SavingsPlanRateFilterName
        /// </summary>
        public static readonly SavingsPlanRateFilterName Tenancy = new SavingsPlanRateFilterName("tenancy");
        /// <summary>
        /// Constant UsageType for SavingsPlanRateFilterName
        /// </summary>
        public static readonly SavingsPlanRateFilterName UsageType = new SavingsPlanRateFilterName("usageType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsPlanRateFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsPlanRateFilterName FindValue(string value)
        {
            return FindValue<SavingsPlanRateFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsPlanRateFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SavingsPlanRatePropertyKey.
    /// </summary>
    public class SavingsPlanRatePropertyKey : ConstantClass
    {

        /// <summary>
        /// Constant InstanceFamily for SavingsPlanRatePropertyKey
        /// </summary>
        public static readonly SavingsPlanRatePropertyKey InstanceFamily = new SavingsPlanRatePropertyKey("instanceFamily");
        /// <summary>
        /// Constant InstanceType for SavingsPlanRatePropertyKey
        /// </summary>
        public static readonly SavingsPlanRatePropertyKey InstanceType = new SavingsPlanRatePropertyKey("instanceType");
        /// <summary>
        /// Constant ProductDescription for SavingsPlanRatePropertyKey
        /// </summary>
        public static readonly SavingsPlanRatePropertyKey ProductDescription = new SavingsPlanRatePropertyKey("productDescription");
        /// <summary>
        /// Constant Region for SavingsPlanRatePropertyKey
        /// </summary>
        public static readonly SavingsPlanRatePropertyKey Region = new SavingsPlanRatePropertyKey("region");
        /// <summary>
        /// Constant Tenancy for SavingsPlanRatePropertyKey
        /// </summary>
        public static readonly SavingsPlanRatePropertyKey Tenancy = new SavingsPlanRatePropertyKey("tenancy");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsPlanRatePropertyKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsPlanRatePropertyKey FindValue(string value)
        {
            return FindValue<SavingsPlanRatePropertyKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsPlanRatePropertyKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SavingsPlanRateServiceCode.
    /// </summary>
    public class SavingsPlanRateServiceCode : ConstantClass
    {

        /// <summary>
        /// Constant AmazonEC2 for SavingsPlanRateServiceCode
        /// </summary>
        public static readonly SavingsPlanRateServiceCode AmazonEC2 = new SavingsPlanRateServiceCode("AmazonEC2");
        /// <summary>
        /// Constant AmazonECS for SavingsPlanRateServiceCode
        /// </summary>
        public static readonly SavingsPlanRateServiceCode AmazonECS = new SavingsPlanRateServiceCode("AmazonECS");
        /// <summary>
        /// Constant AmazonEKS for SavingsPlanRateServiceCode
        /// </summary>
        public static readonly SavingsPlanRateServiceCode AmazonEKS = new SavingsPlanRateServiceCode("AmazonEKS");
        /// <summary>
        /// Constant AmazonSageMaker for SavingsPlanRateServiceCode
        /// </summary>
        public static readonly SavingsPlanRateServiceCode AmazonSageMaker = new SavingsPlanRateServiceCode("AmazonSageMaker");
        /// <summary>
        /// Constant AWSLambda for SavingsPlanRateServiceCode
        /// </summary>
        public static readonly SavingsPlanRateServiceCode AWSLambda = new SavingsPlanRateServiceCode("AWSLambda");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsPlanRateServiceCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsPlanRateServiceCode FindValue(string value)
        {
            return FindValue<SavingsPlanRateServiceCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsPlanRateServiceCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SavingsPlanRateUnit.
    /// </summary>
    public class SavingsPlanRateUnit : ConstantClass
    {

        /// <summary>
        /// Constant Hrs for SavingsPlanRateUnit
        /// </summary>
        public static readonly SavingsPlanRateUnit Hrs = new SavingsPlanRateUnit("Hrs");
        /// <summary>
        /// Constant LambdaGBSecond for SavingsPlanRateUnit
        /// </summary>
        public static readonly SavingsPlanRateUnit LambdaGBSecond = new SavingsPlanRateUnit("Lambda-GB-Second");
        /// <summary>
        /// Constant Request for SavingsPlanRateUnit
        /// </summary>
        public static readonly SavingsPlanRateUnit Request = new SavingsPlanRateUnit("Request");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsPlanRateUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsPlanRateUnit FindValue(string value)
        {
            return FindValue<SavingsPlanRateUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsPlanRateUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SavingsPlansFilterName.
    /// </summary>
    public class SavingsPlansFilterName : ConstantClass
    {

        /// <summary>
        /// Constant Commitment for SavingsPlansFilterName
        /// </summary>
        public static readonly SavingsPlansFilterName Commitment = new SavingsPlansFilterName("commitment");
        /// <summary>
        /// Constant Ec2InstanceFamily for SavingsPlansFilterName
        /// </summary>
        public static readonly SavingsPlansFilterName Ec2InstanceFamily = new SavingsPlansFilterName("ec2-instance-family");
        /// <summary>
        /// Constant End for SavingsPlansFilterName
        /// </summary>
        public static readonly SavingsPlansFilterName End = new SavingsPlansFilterName("end");
        /// <summary>
        /// Constant PaymentOption for SavingsPlansFilterName
        /// </summary>
        public static readonly SavingsPlansFilterName PaymentOption = new SavingsPlansFilterName("payment-option");
        /// <summary>
        /// Constant Region for SavingsPlansFilterName
        /// </summary>
        public static readonly SavingsPlansFilterName Region = new SavingsPlansFilterName("region");
        /// <summary>
        /// Constant SavingsPlanType for SavingsPlansFilterName
        /// </summary>
        public static readonly SavingsPlansFilterName SavingsPlanType = new SavingsPlansFilterName("savings-plan-type");
        /// <summary>
        /// Constant Start for SavingsPlansFilterName
        /// </summary>
        public static readonly SavingsPlansFilterName Start = new SavingsPlansFilterName("start");
        /// <summary>
        /// Constant Term for SavingsPlansFilterName
        /// </summary>
        public static readonly SavingsPlansFilterName Term = new SavingsPlansFilterName("term");
        /// <summary>
        /// Constant Upfront for SavingsPlansFilterName
        /// </summary>
        public static readonly SavingsPlansFilterName Upfront = new SavingsPlansFilterName("upfront");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsPlansFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsPlansFilterName FindValue(string value)
        {
            return FindValue<SavingsPlansFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsPlansFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SavingsPlanState.
    /// </summary>
    public class SavingsPlanState : ConstantClass
    {

        /// <summary>
        /// Constant Active for SavingsPlanState
        /// </summary>
        public static readonly SavingsPlanState Active = new SavingsPlanState("active");
        /// <summary>
        /// Constant PaymentFailed for SavingsPlanState
        /// </summary>
        public static readonly SavingsPlanState PaymentFailed = new SavingsPlanState("payment-failed");
        /// <summary>
        /// Constant PaymentPending for SavingsPlanState
        /// </summary>
        public static readonly SavingsPlanState PaymentPending = new SavingsPlanState("payment-pending");
        /// <summary>
        /// Constant PendingReturn for SavingsPlanState
        /// </summary>
        public static readonly SavingsPlanState PendingReturn = new SavingsPlanState("pending-return");
        /// <summary>
        /// Constant Queued for SavingsPlanState
        /// </summary>
        public static readonly SavingsPlanState Queued = new SavingsPlanState("queued");
        /// <summary>
        /// Constant QueuedDeleted for SavingsPlanState
        /// </summary>
        public static readonly SavingsPlanState QueuedDeleted = new SavingsPlanState("queued-deleted");
        /// <summary>
        /// Constant Retired for SavingsPlanState
        /// </summary>
        public static readonly SavingsPlanState Retired = new SavingsPlanState("retired");
        /// <summary>
        /// Constant Returned for SavingsPlanState
        /// </summary>
        public static readonly SavingsPlanState Returned = new SavingsPlanState("returned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsPlanState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsPlanState FindValue(string value)
        {
            return FindValue<SavingsPlanState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsPlanState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SavingsPlanType.
    /// </summary>
    public class SavingsPlanType : ConstantClass
    {

        /// <summary>
        /// Constant Compute for SavingsPlanType
        /// </summary>
        public static readonly SavingsPlanType Compute = new SavingsPlanType("Compute");
        /// <summary>
        /// Constant EC2Instance for SavingsPlanType
        /// </summary>
        public static readonly SavingsPlanType EC2Instance = new SavingsPlanType("EC2Instance");
        /// <summary>
        /// Constant SageMaker for SavingsPlanType
        /// </summary>
        public static readonly SavingsPlanType SageMaker = new SavingsPlanType("SageMaker");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SavingsPlanType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SavingsPlanType FindValue(string value)
        {
            return FindValue<SavingsPlanType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SavingsPlanType(string value)
        {
            return FindValue(value);
        }
    }

}