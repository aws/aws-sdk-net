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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SocialMessaging
{

    /// <summary>
    /// Constants used for properties of type MetaFlowCategory.
    /// </summary>
    public class MetaFlowCategory : ConstantClass
    {

        /// <summary>
        /// Constant APPOINTMENT_BOOKING for MetaFlowCategory
        /// </summary>
        public static readonly MetaFlowCategory APPOINTMENT_BOOKING = new MetaFlowCategory("APPOINTMENT_BOOKING");
        /// <summary>
        /// Constant CONTACT_US for MetaFlowCategory
        /// </summary>
        public static readonly MetaFlowCategory CONTACT_US = new MetaFlowCategory("CONTACT_US");
        /// <summary>
        /// Constant CUSTOMER_SUPPORT for MetaFlowCategory
        /// </summary>
        public static readonly MetaFlowCategory CUSTOMER_SUPPORT = new MetaFlowCategory("CUSTOMER_SUPPORT");
        /// <summary>
        /// Constant LEAD_GENERATION for MetaFlowCategory
        /// </summary>
        public static readonly MetaFlowCategory LEAD_GENERATION = new MetaFlowCategory("LEAD_GENERATION");
        /// <summary>
        /// Constant OTHER for MetaFlowCategory
        /// </summary>
        public static readonly MetaFlowCategory OTHER = new MetaFlowCategory("OTHER");
        /// <summary>
        /// Constant SHOPPING for MetaFlowCategory
        /// </summary>
        public static readonly MetaFlowCategory SHOPPING = new MetaFlowCategory("SHOPPING");
        /// <summary>
        /// Constant SIGN_IN for MetaFlowCategory
        /// </summary>
        public static readonly MetaFlowCategory SIGN_IN = new MetaFlowCategory("SIGN_IN");
        /// <summary>
        /// Constant SIGN_UP for MetaFlowCategory
        /// </summary>
        public static readonly MetaFlowCategory SIGN_UP = new MetaFlowCategory("SIGN_UP");
        /// <summary>
        /// Constant SURVEY for MetaFlowCategory
        /// </summary>
        public static readonly MetaFlowCategory SURVEY = new MetaFlowCategory("SURVEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetaFlowCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetaFlowCategory FindValue(string value)
        {
            return FindValue<MetaFlowCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetaFlowCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationStatus.
    /// </summary>
    public class RegistrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus COMPLETE = new RegistrationStatus("COMPLETE");
        /// <summary>
        /// Constant INCOMPLETE for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus INCOMPLETE = new RegistrationStatus("INCOMPLETE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationStatus FindValue(string value)
        {
            return FindValue<RegistrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationStatus(string value)
        {
            return FindValue(value);
        }
    }

}