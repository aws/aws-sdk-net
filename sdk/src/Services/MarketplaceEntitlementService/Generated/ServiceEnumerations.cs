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
 * Do not modify this file. This file is generated from the entitlement.marketplace-2017-01-11.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MarketplaceEntitlementService
{

    /// <summary>
    /// Constants used for properties of type GetEntitlementFilterName.
    /// </summary>
    public class GetEntitlementFilterName : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOMER_AWS_ACCOUNT_ID for GetEntitlementFilterName
        /// </summary>
        public static readonly GetEntitlementFilterName CUSTOMER_AWS_ACCOUNT_ID = new GetEntitlementFilterName("CUSTOMER_AWS_ACCOUNT_ID");
        /// <summary>
        /// Constant CUSTOMER_IDENTIFIER for GetEntitlementFilterName
        /// </summary>
        public static readonly GetEntitlementFilterName CUSTOMER_IDENTIFIER = new GetEntitlementFilterName("CUSTOMER_IDENTIFIER");
        /// <summary>
        /// Constant DIMENSION for GetEntitlementFilterName
        /// </summary>
        public static readonly GetEntitlementFilterName DIMENSION = new GetEntitlementFilterName("DIMENSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GetEntitlementFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GetEntitlementFilterName FindValue(string value)
        {
            return FindValue<GetEntitlementFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GetEntitlementFilterName(string value)
        {
            return FindValue(value);
        }
    }

}