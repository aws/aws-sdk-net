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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Outposts
{

    /// <summary>
    /// Constants used for properties of type OrderStatus.
    /// </summary>
    public class OrderStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for OrderStatus
        /// </summary>
        public static readonly OrderStatus CANCELLED = new OrderStatus("CANCELLED");
        /// <summary>
        /// Constant FULFILLED for OrderStatus
        /// </summary>
        public static readonly OrderStatus FULFILLED = new OrderStatus("FULFILLED");
        /// <summary>
        /// Constant INSTALLING for OrderStatus
        /// </summary>
        public static readonly OrderStatus INSTALLING = new OrderStatus("INSTALLING");
        /// <summary>
        /// Constant PENDING for OrderStatus
        /// </summary>
        public static readonly OrderStatus PENDING = new OrderStatus("PENDING");
        /// <summary>
        /// Constant PROCESSING for OrderStatus
        /// </summary>
        public static readonly OrderStatus PROCESSING = new OrderStatus("PROCESSING");
        /// <summary>
        /// Constant RECEIVED for OrderStatus
        /// </summary>
        public static readonly OrderStatus RECEIVED = new OrderStatus("RECEIVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderStatus FindValue(string value)
        {
            return FindValue<OrderStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderStatus(string value)
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
        /// Constant ALL_UPFRONT for PaymentOption
        /// </summary>
        public static readonly PaymentOption ALL_UPFRONT = new PaymentOption("ALL_UPFRONT");
        /// <summary>
        /// Constant NO_UPFRONT for PaymentOption
        /// </summary>
        public static readonly PaymentOption NO_UPFRONT = new PaymentOption("NO_UPFRONT");
        /// <summary>
        /// Constant PARTIAL_UPFRONT for PaymentOption
        /// </summary>
        public static readonly PaymentOption PARTIAL_UPFRONT = new PaymentOption("PARTIAL_UPFRONT");

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
    /// Constants used for properties of type PaymentTerm.
    /// </summary>
    public class PaymentTerm : ConstantClass
    {

        /// <summary>
        /// Constant THREE_YEARS for PaymentTerm
        /// </summary>
        public static readonly PaymentTerm THREE_YEARS = new PaymentTerm("THREE_YEARS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PaymentTerm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentTerm FindValue(string value)
        {
            return FindValue<PaymentTerm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentTerm(string value)
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
        /// Constant OUTPOST for ResourceType
        /// </summary>
        public static readonly ResourceType OUTPOST = new ResourceType("OUTPOST");

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