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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.IAMToolbox
{
    /// <summary>
    /// Constants used for properties of type CheckEffect.
    /// </summary>
    public class CheckEffect : ConstantClass
    {
        /// <summary>
        /// Constant ALLOW for CheckEffect
        /// </summary>
        public static readonly CheckEffect ALLOW = new CheckEffect("ALLOW");

        /// <summary>
        /// Constant EXPLICIT_DENY for CheckEffect
        /// </summary>
        public static readonly CheckEffect EXPLICIT_DENY = new CheckEffect("EXPLICIT_DENY");

        /// <summary>
        /// Constant IMPLICIT_DENY for CheckEffect
        /// </summary>
        public static readonly CheckEffect IMPLICIT_DENY = new CheckEffect("IMPLICIT_DENY");

        /// <summary>
        /// Constant NO_IMPACT for CheckEffect
        /// </summary>
        public static readonly CheckEffect NO_IMPACT = new CheckEffect("NO_IMPACT");

        /// <summary>
        /// Constructs a custom CheckEffect for a value not among the defined constants.
        /// </summary>
        public CheckEffect(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CheckEffect FindValue(string value)
        {
            return FindValue<CheckEffect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CheckEffect(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CheckType.
    /// </summary>
    public class CheckType : ConstantClass
    {
        /// <summary>
        /// Constant PERMISSIONS_BOUNDARY for CheckType
        /// </summary>
        public static readonly CheckType PERMISSIONS_BOUNDARY = new CheckType("PERMISSIONS_BOUNDARY");

        /// <summary>
        /// Constant PRINCIPAL for CheckType
        /// </summary>
        public static readonly CheckType PRINCIPAL = new CheckType("PRINCIPAL");

        /// <summary>
        /// Constant RESOURCE for CheckType
        /// </summary>
        public static readonly CheckType RESOURCE = new CheckType("RESOURCE");

        /// <summary>
        /// Constant RESOURCE_CONTROL_POLICY for CheckType
        /// </summary>
        public static readonly CheckType RESOURCE_CONTROL_POLICY = new CheckType("RESOURCE_CONTROL_POLICY");

        /// <summary>
        /// Constant SERVICE_CONTROL_POLICY for CheckType
        /// </summary>
        public static readonly CheckType SERVICE_CONTROL_POLICY = new CheckType("SERVICE_CONTROL_POLICY");

        /// <summary>
        /// Constant SESSION for CheckType
        /// </summary>
        public static readonly CheckType SESSION = new CheckType("SESSION");

        /// <summary>
        /// Constant VPC_ENDPOINT for CheckType
        /// </summary>
        public static readonly CheckType VPC_ENDPOINT = new CheckType("VPC_ENDPOINT");

        /// <summary>
        /// Constructs a custom CheckType for a value not among the defined constants.
        /// </summary>
        public CheckType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CheckType FindValue(string value)
        {
            return FindValue<CheckType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CheckType(string value)
        {
            return FindValue(value);
        }
    }

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
        /// Constructs a custom EvaluatedEffect for a value not among the defined constants.
        /// </summary>
        public EvaluatedEffect(string value) : base(value) { }

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
        /// Constructs a custom PolicyType for a value not among the defined constants.
        /// </summary>
        public PolicyType(string value) : base(value) { }

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
        /// Constructs a custom StatementEffect for a value not among the defined constants.
        /// </summary>
        public StatementEffect(string value) : base(value) { }

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
