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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Route53RecoveryControlConfig
{

    /// <summary>
    /// Constants used for properties of type NetworkType.
    /// </summary>
    public class NetworkType : ConstantClass
    {

        /// <summary>
        /// Constant DUALSTACK for NetworkType
        /// </summary>
        public static readonly NetworkType DUALSTACK = new NetworkType("DUALSTACK");
        /// <summary>
        /// Constant IPV4 for NetworkType
        /// </summary>
        public static readonly NetworkType IPV4 = new NetworkType("IPV4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkType FindValue(string value)
        {
            return FindValue<NetworkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkType(string value)
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
        /// Constant AND for RuleType
        /// </summary>
        public static readonly RuleType AND = new RuleType("AND");
        /// <summary>
        /// Constant ATLEAST for RuleType
        /// </summary>
        public static readonly RuleType ATLEAST = new RuleType("ATLEAST");
        /// <summary>
        /// Constant OR for RuleType
        /// </summary>
        public static readonly RuleType OR = new RuleType("OR");

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
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOYED for Status
        /// </summary>
        public static readonly Status DEPLOYED = new Status("DEPLOYED");
        /// <summary>
        /// Constant PENDING for Status
        /// </summary>
        public static readonly Status PENDING = new Status("PENDING");
        /// <summary>
        /// Constant PENDING_DELETION for Status
        /// </summary>
        public static readonly Status PENDING_DELETION = new Status("PENDING_DELETION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }

}