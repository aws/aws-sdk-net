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

namespace Amazon.Route53RecoveryCluster
{
    /// <summary>
    /// Constants used for properties of type RoutingControlState.
    /// </summary>
    public class RoutingControlState : ConstantClass
    {
        /// <summary>
        /// Constant Off for RoutingControlState
        /// </summary>
        public static readonly RoutingControlState Off = new RoutingControlState("Off");

        /// <summary>
        /// Constant On for RoutingControlState
        /// </summary>
        public static readonly RoutingControlState On = new RoutingControlState("On");

        /// <summary>
        /// Constructs a custom RoutingControlState for a value not among the defined constants.
        /// </summary>
        public RoutingControlState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoutingControlState FindValue(string value)
        {
            return FindValue<RoutingControlState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoutingControlState(string value)
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
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");

        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");

        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");

        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

        /// <summary>
        /// Constructs a custom ValidationExceptionReason for a value not among the defined constants.
        /// </summary>
        public ValidationExceptionReason(string value) : base(value) { }

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
