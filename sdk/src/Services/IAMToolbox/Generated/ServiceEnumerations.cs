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
 * Do not modify this file. This file is generated from the iam-toolbox-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IAMToolbox
{

    /// <summary>
    /// Constants used for properties of type EvaluatedEffect.
    /// </summary>
    public class EvaluatedEffect : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for EvaluatedEffect
        /// </summary>
        public static readonly EvaluatedEffect ALLOW = new EvaluatedEffect("ALLOW");
        /// <summary>
        /// Constant EXPLICIT_DENY for EvaluatedEffect
        /// </summary>
        public static readonly EvaluatedEffect EXPLICIT_DENY = new EvaluatedEffect("EXPLICIT_DENY");
        /// <summary>
        /// Constant IMPLICIT_DENY for EvaluatedEffect
        /// </summary>
        public static readonly EvaluatedEffect IMPLICIT_DENY = new EvaluatedEffect("IMPLICIT_DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluatedEffect(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluatedEffect FindValue(string value)
        {
            return FindValue<EvaluatedEffect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluatedEffect(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyType.
    /// </summary>
    public class PolicyType : ConstantClass
    {

        /// <summary>
        /// Constant IDENTITY_BASED_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType IDENTITY_BASED_POLICY = new PolicyType("IDENTITY_BASED_POLICY");
        /// <summary>
        /// Constant PERMISSIONS_BOUNDARY for PolicyType
        /// </summary>
        public static readonly PolicyType PERMISSIONS_BOUNDARY = new PolicyType("PERMISSIONS_BOUNDARY");
        /// <summary>
        /// Constant RESOURCE_BASED_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType RESOURCE_BASED_POLICY = new PolicyType("RESOURCE_BASED_POLICY");
        /// <summary>
        /// Constant RESOURCE_CONTROL_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType RESOURCE_CONTROL_POLICY = new PolicyType("RESOURCE_CONTROL_POLICY");
        /// <summary>
        /// Constant SERVICE_CONTROL_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType SERVICE_CONTROL_POLICY = new PolicyType("SERVICE_CONTROL_POLICY");
        /// <summary>
        /// Constant SESSION_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType SESSION_POLICY = new PolicyType("SESSION_POLICY");
        /// <summary>
        /// Constant VPC_ENDPOINT_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType VPC_ENDPOINT_POLICY = new PolicyType("VPC_ENDPOINT_POLICY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyType FindValue(string value)
        {
            return FindValue<PolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatementEffect.
    /// </summary>
    public class StatementEffect : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for StatementEffect
        /// </summary>
        public static readonly StatementEffect ALLOW = new StatementEffect("ALLOW");
        /// <summary>
        /// Constant DENY for StatementEffect
        /// </summary>
        public static readonly StatementEffect DENY = new StatementEffect("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatementEffect(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatementEffect FindValue(string value)
        {
            return FindValue<StatementEffect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatementEffect(string value)
        {
            return FindValue(value);
        }
    }

}