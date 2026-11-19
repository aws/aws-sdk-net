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

namespace Amazon.AbuseSignal
{
    /// <summary>
    /// Constants used for properties of type ReasonCode.
    /// </summary>
    public class ReasonCode : ConstantClass
    {
        /// <summary>
        /// Constant ACTIONED for ReasonCode
        /// </summary>
        public static readonly ReasonCode ACTIONED = new ReasonCode("ACTIONED");

        /// <summary>
        /// Constant CONTENT_DOWN_OR_INACCESSIBLE for ReasonCode
        /// </summary>
        public static readonly ReasonCode CONTENT_DOWN_OR_INACCESSIBLE = new ReasonCode("CONTENT_DOWN_OR_INACCESSIBLE");

        /// <summary>
        /// Constant NEED_MORE_INFORMATION for ReasonCode
        /// </summary>
        public static readonly ReasonCode NEED_MORE_INFORMATION = new ReasonCode("NEED_MORE_INFORMATION");

        /// <summary>
        /// Constant NOT_RESOLVABLE_TO_AWS for ReasonCode
        /// </summary>
        public static readonly ReasonCode NOT_RESOLVABLE_TO_AWS = new ReasonCode("NOT_RESOLVABLE_TO_AWS");

        /// <summary>
        /// Constant REVIEWED_NO_AWS_ACTION for ReasonCode
        /// </summary>
        public static readonly ReasonCode REVIEWED_NO_AWS_ACTION = new ReasonCode("REVIEWED_NO_AWS_ACTION");

        /// <summary>
        /// Constructs a custom ReasonCode for a value not among the defined constants.
        /// </summary>
        public ReasonCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReasonCode FindValue(string value)
        {
            return FindValue<ReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReasonCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ReportSubmissionStatus.
    /// </summary>
    public class ReportSubmissionStatus : ConstantClass
    {
        /// <summary>
        /// Constant COMPLETED for ReportSubmissionStatus
        /// </summary>
        public static readonly ReportSubmissionStatus COMPLETED = new ReportSubmissionStatus("COMPLETED");

        /// <summary>
        /// Constant PROCESSING for ReportSubmissionStatus
        /// </summary>
        public static readonly ReportSubmissionStatus PROCESSING = new ReportSubmissionStatus("PROCESSING");

        /// <summary>
        /// Constant QUEUED for ReportSubmissionStatus
        /// </summary>
        public static readonly ReportSubmissionStatus QUEUED = new ReportSubmissionStatus("QUEUED");

        /// <summary>
        /// Constructs a custom ReportSubmissionStatus for a value not among the defined constants.
        /// </summary>
        public ReportSubmissionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportSubmissionStatus FindValue(string value)
        {
            return FindValue<ReportSubmissionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportSubmissionStatus(string value)
        {
            return FindValue(value);
        }
    }
}
