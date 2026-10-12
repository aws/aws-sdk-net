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

namespace Amazon.SageMakerTrainingSessionRuntime
{
    /// <summary>
    /// Constants used for properties of type EncodedTextChunkType.
    /// </summary>
    public class EncodedTextChunkType : ConstantClass
    {
        /// <summary>
        /// Constant Encoded_text for EncodedTextChunkType
        /// </summary>
        public static readonly EncodedTextChunkType Encoded_text = new EncodedTextChunkType("encoded_text");

        /// <summary>
        /// Constructs a custom EncodedTextChunkType for a value not among the defined constants.
        /// </summary>
        public EncodedTextChunkType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncodedTextChunkType FindValue(string value)
        {
            return FindValue<EncodedTextChunkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncodedTextChunkType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LossFnName.
    /// </summary>
    public class LossFnName : ConstantClass
    {
        /// <summary>
        /// Constant Cispo for LossFnName
        /// </summary>
        public static readonly LossFnName Cispo = new LossFnName("cispo");

        /// <summary>
        /// Constant Cross_entropy for LossFnName
        /// </summary>
        public static readonly LossFnName Cross_entropy = new LossFnName("cross_entropy");

        /// <summary>
        /// Constant Importance_sampling for LossFnName
        /// </summary>
        public static readonly LossFnName Importance_sampling = new LossFnName("importance_sampling");

        /// <summary>
        /// Constant Ppo for LossFnName
        /// </summary>
        public static readonly LossFnName Ppo = new LossFnName("ppo");

        /// <summary>
        /// Constructs a custom LossFnName for a value not among the defined constants.
        /// </summary>
        public LossFnName(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LossFnName FindValue(string value)
        {
            return FindValue<LossFnName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LossFnName(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RequestStatus.
    /// </summary>
    public class RequestStatus : ConstantClass
    {
        /// <summary>
        /// Constant Completed for RequestStatus
        /// </summary>
        public static readonly RequestStatus Completed = new RequestStatus("Completed");

        /// <summary>
        /// Constant Failed for RequestStatus
        /// </summary>
        public static readonly RequestStatus Failed = new RequestStatus("Failed");

        /// <summary>
        /// Constant InProgress for RequestStatus
        /// </summary>
        public static readonly RequestStatus InProgress = new RequestStatus("InProgress");

        /// <summary>
        /// Constant Pending for RequestStatus
        /// </summary>
        public static readonly RequestStatus Pending = new RequestStatus("Pending");

        /// <summary>
        /// Constant Skipped for RequestStatus
        /// </summary>
        public static readonly RequestStatus Skipped = new RequestStatus("Skipped");

        /// <summary>
        /// Constructs a custom RequestStatus for a value not among the defined constants.
        /// </summary>
        public RequestStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequestStatus FindValue(string value)
        {
            return FindValue<RequestStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequestStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type StopReason.
    /// </summary>
    public class StopReason : ConstantClass
    {
        /// <summary>
        /// Constant Length for StopReason
        /// </summary>
        public static readonly StopReason Length = new StopReason("length");

        /// <summary>
        /// Constant Stop for StopReason
        /// </summary>
        public static readonly StopReason Stop = new StopReason("stop");

        /// <summary>
        /// Constructs a custom StopReason for a value not among the defined constants.
        /// </summary>
        public StopReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StopReason FindValue(string value)
        {
            return FindValue<StopReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StopReason(string value)
        {
            return FindValue(value);
        }
    }
}
