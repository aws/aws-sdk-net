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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Route53RecoveryReadiness
{

    /// <summary>
    /// Constants used for properties of type Readiness.
    /// </summary>
    public class Readiness : ConstantClass
    {

        /// <summary>
        /// Constant NOT_AUTHORIZED for Readiness
        /// </summary>
        public static readonly Readiness NOT_AUTHORIZED = new Readiness("NOT_AUTHORIZED");
        /// <summary>
        /// Constant NOT_READY for Readiness
        /// </summary>
        public static readonly Readiness NOT_READY = new Readiness("NOT_READY");
        /// <summary>
        /// Constant READY for Readiness
        /// </summary>
        public static readonly Readiness READY = new Readiness("READY");
        /// <summary>
        /// Constant UNKNOWN for Readiness
        /// </summary>
        public static readonly Readiness UNKNOWN = new Readiness("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Readiness(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Readiness FindValue(string value)
        {
            return FindValue<Readiness>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Readiness(string value)
        {
            return FindValue(value);
        }
    }

}