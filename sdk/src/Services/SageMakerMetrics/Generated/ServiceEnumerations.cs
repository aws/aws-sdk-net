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
 * Do not modify this file. This file is generated from the sagemaker-metrics-2022-09-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SageMakerMetrics
{

    /// <summary>
    /// Constants used for properties of type PutMetricsErrorCode.
    /// </summary>
    public class PutMetricsErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant CONFLICT_ERROR for PutMetricsErrorCode
        /// </summary>
        public static readonly PutMetricsErrorCode CONFLICT_ERROR = new PutMetricsErrorCode("CONFLICT_ERROR");
        /// <summary>
        /// Constant INTERNAL_ERROR for PutMetricsErrorCode
        /// </summary>
        public static readonly PutMetricsErrorCode INTERNAL_ERROR = new PutMetricsErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant METRIC_LIMIT_EXCEEDED for PutMetricsErrorCode
        /// </summary>
        public static readonly PutMetricsErrorCode METRIC_LIMIT_EXCEEDED = new PutMetricsErrorCode("METRIC_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant VALIDATION_ERROR for PutMetricsErrorCode
        /// </summary>
        public static readonly PutMetricsErrorCode VALIDATION_ERROR = new PutMetricsErrorCode("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PutMetricsErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PutMetricsErrorCode FindValue(string value)
        {
            return FindValue<PutMetricsErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PutMetricsErrorCode(string value)
        {
            return FindValue(value);
        }
    }

}