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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ControlTower
{

    /// <summary>
    /// Constants used for properties of type ControlOperationStatus.
    /// </summary>
    public class ControlOperationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ControlOperationStatus
        /// </summary>
        public static readonly ControlOperationStatus FAILED = new ControlOperationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ControlOperationStatus
        /// </summary>
        public static readonly ControlOperationStatus IN_PROGRESS = new ControlOperationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for ControlOperationStatus
        /// </summary>
        public static readonly ControlOperationStatus SUCCEEDED = new ControlOperationStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlOperationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlOperationStatus FindValue(string value)
        {
            return FindValue<ControlOperationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlOperationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ControlOperationType.
    /// </summary>
    public class ControlOperationType : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE_CONTROL for ControlOperationType
        /// </summary>
        public static readonly ControlOperationType DISABLE_CONTROL = new ControlOperationType("DISABLE_CONTROL");
        /// <summary>
        /// Constant ENABLE_CONTROL for ControlOperationType
        /// </summary>
        public static readonly ControlOperationType ENABLE_CONTROL = new ControlOperationType("ENABLE_CONTROL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlOperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlOperationType FindValue(string value)
        {
            return FindValue<ControlOperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlOperationType(string value)
        {
            return FindValue(value);
        }
    }

}