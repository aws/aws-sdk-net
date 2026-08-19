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

namespace Amazon.SimpleDBv2
{
    /// <summary>
    /// Constants used for properties of type ExportStatus.
    /// </summary>
    public class ExportStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for ExportStatus
        /// </summary>
        public static readonly ExportStatus FAILED = new ExportStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for ExportStatus
        /// </summary>
        public static readonly ExportStatus IN_PROGRESS = new ExportStatus("IN_PROGRESS");

        /// <summary>
        /// Constant PENDING for ExportStatus
        /// </summary>
        public static readonly ExportStatus PENDING = new ExportStatus("PENDING");

        /// <summary>
        /// Constant SUCCEEDED for ExportStatus
        /// </summary>
        public static readonly ExportStatus SUCCEEDED = new ExportStatus("SUCCEEDED");

        /// <summary>
        /// Constructs a custom ExportStatus for a value not among the defined constants.
        /// </summary>
        public ExportStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportStatus FindValue(string value)
        {
            return FindValue<ExportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type S3SseAlgorithm.
    /// </summary>
    public class S3SseAlgorithm : ConstantClass
    {
        /// <summary>
        /// Constant AES256 for S3SseAlgorithm
        /// </summary>
        public static readonly S3SseAlgorithm AES256 = new S3SseAlgorithm("AES256");

        /// <summary>
        /// Constant KMS for S3SseAlgorithm
        /// </summary>
        public static readonly S3SseAlgorithm KMS = new S3SseAlgorithm("KMS");

        /// <summary>
        /// Constructs a custom S3SseAlgorithm for a value not among the defined constants.
        /// </summary>
        public S3SseAlgorithm(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3SseAlgorithm FindValue(string value)
        {
            return FindValue<S3SseAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3SseAlgorithm(string value)
        {
            return FindValue(value);
        }
    }
}
