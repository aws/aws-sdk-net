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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Synthetics
{

    /// <summary>
    /// Constants used for properties of type CanaryRunState.
    /// </summary>
    public class CanaryRunState : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for CanaryRunState
        /// </summary>
        public static readonly CanaryRunState FAILED = new CanaryRunState("FAILED");
        /// <summary>
        /// Constant PASSED for CanaryRunState
        /// </summary>
        public static readonly CanaryRunState PASSED = new CanaryRunState("PASSED");
        /// <summary>
        /// Constant RUNNING for CanaryRunState
        /// </summary>
        public static readonly CanaryRunState RUNNING = new CanaryRunState("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CanaryRunState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CanaryRunState FindValue(string value)
        {
            return FindValue<CanaryRunState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CanaryRunState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CanaryRunStateReasonCode.
    /// </summary>
    public class CanaryRunStateReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant CANARY_FAILURE for CanaryRunStateReasonCode
        /// </summary>
        public static readonly CanaryRunStateReasonCode CANARY_FAILURE = new CanaryRunStateReasonCode("CANARY_FAILURE");
        /// <summary>
        /// Constant EXECUTION_FAILURE for CanaryRunStateReasonCode
        /// </summary>
        public static readonly CanaryRunStateReasonCode EXECUTION_FAILURE = new CanaryRunStateReasonCode("EXECUTION_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CanaryRunStateReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CanaryRunStateReasonCode FindValue(string value)
        {
            return FindValue<CanaryRunStateReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CanaryRunStateReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CanaryState.
    /// </summary>
    public class CanaryState : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for CanaryState
        /// </summary>
        public static readonly CanaryState CREATING = new CanaryState("CREATING");
        /// <summary>
        /// Constant DELETING for CanaryState
        /// </summary>
        public static readonly CanaryState DELETING = new CanaryState("DELETING");
        /// <summary>
        /// Constant ERROR for CanaryState
        /// </summary>
        public static readonly CanaryState ERROR = new CanaryState("ERROR");
        /// <summary>
        /// Constant READY for CanaryState
        /// </summary>
        public static readonly CanaryState READY = new CanaryState("READY");
        /// <summary>
        /// Constant RUNNING for CanaryState
        /// </summary>
        public static readonly CanaryState RUNNING = new CanaryState("RUNNING");
        /// <summary>
        /// Constant STARTING for CanaryState
        /// </summary>
        public static readonly CanaryState STARTING = new CanaryState("STARTING");
        /// <summary>
        /// Constant STOPPED for CanaryState
        /// </summary>
        public static readonly CanaryState STOPPED = new CanaryState("STOPPED");
        /// <summary>
        /// Constant STOPPING for CanaryState
        /// </summary>
        public static readonly CanaryState STOPPING = new CanaryState("STOPPING");
        /// <summary>
        /// Constant UPDATING for CanaryState
        /// </summary>
        public static readonly CanaryState UPDATING = new CanaryState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CanaryState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CanaryState FindValue(string value)
        {
            return FindValue<CanaryState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CanaryState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CanaryStateReasonCode.
    /// </summary>
    public class CanaryStateReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant INVALID_PERMISSIONS for CanaryStateReasonCode
        /// </summary>
        public static readonly CanaryStateReasonCode INVALID_PERMISSIONS = new CanaryStateReasonCode("INVALID_PERMISSIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CanaryStateReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CanaryStateReasonCode FindValue(string value)
        {
            return FindValue<CanaryStateReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CanaryStateReasonCode(string value)
        {
            return FindValue(value);
        }
    }

}