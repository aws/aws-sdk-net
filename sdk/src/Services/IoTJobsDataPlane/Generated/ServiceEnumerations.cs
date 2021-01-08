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
 * Do not modify this file. This file is generated from the iot-jobs-data-2017-09-29.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IoTJobsDataPlane
{

    /// <summary>
    /// Constants used for properties of type JobExecutionStatus.
    /// </summary>
    public class JobExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus CANCELED = new JobExecutionStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus FAILED = new JobExecutionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus IN_PROGRESS = new JobExecutionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant QUEUED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus QUEUED = new JobExecutionStatus("QUEUED");
        /// <summary>
        /// Constant REJECTED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus REJECTED = new JobExecutionStatus("REJECTED");
        /// <summary>
        /// Constant REMOVED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus REMOVED = new JobExecutionStatus("REMOVED");
        /// <summary>
        /// Constant SUCCEEDED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus SUCCEEDED = new JobExecutionStatus("SUCCEEDED");
        /// <summary>
        /// Constant TIMED_OUT for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus TIMED_OUT = new JobExecutionStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobExecutionStatus FindValue(string value)
        {
            return FindValue<JobExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }

}