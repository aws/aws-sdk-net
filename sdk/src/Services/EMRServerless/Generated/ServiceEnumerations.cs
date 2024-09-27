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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.EMRServerless
{

    /// <summary>
    /// Constants used for properties of type ApplicationState.
    /// </summary>
    public class ApplicationState : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for ApplicationState
        /// </summary>
        public static readonly ApplicationState CREATED = new ApplicationState("CREATED");
        /// <summary>
        /// Constant CREATING for ApplicationState
        /// </summary>
        public static readonly ApplicationState CREATING = new ApplicationState("CREATING");
        /// <summary>
        /// Constant STARTED for ApplicationState
        /// </summary>
        public static readonly ApplicationState STARTED = new ApplicationState("STARTED");
        /// <summary>
        /// Constant STARTING for ApplicationState
        /// </summary>
        public static readonly ApplicationState STARTING = new ApplicationState("STARTING");
        /// <summary>
        /// Constant STOPPED for ApplicationState
        /// </summary>
        public static readonly ApplicationState STOPPED = new ApplicationState("STOPPED");
        /// <summary>
        /// Constant STOPPING for ApplicationState
        /// </summary>
        public static readonly ApplicationState STOPPING = new ApplicationState("STOPPING");
        /// <summary>
        /// Constant TERMINATED for ApplicationState
        /// </summary>
        public static readonly ApplicationState TERMINATED = new ApplicationState("TERMINATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationState FindValue(string value)
        {
            return FindValue<ApplicationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Architecture.
    /// </summary>
    public class Architecture : ConstantClass
    {

        /// <summary>
        /// Constant ARM64 for Architecture
        /// </summary>
        public static readonly Architecture ARM64 = new Architecture("ARM64");
        /// <summary>
        /// Constant X86_64 for Architecture
        /// </summary>
        public static readonly Architecture X86_64 = new Architecture("X86_64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Architecture(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Architecture FindValue(string value)
        {
            return FindValue<Architecture>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Architecture(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobRunMode.
    /// </summary>
    public class JobRunMode : ConstantClass
    {

        /// <summary>
        /// Constant BATCH for JobRunMode
        /// </summary>
        public static readonly JobRunMode BATCH = new JobRunMode("BATCH");
        /// <summary>
        /// Constant STREAMING for JobRunMode
        /// </summary>
        public static readonly JobRunMode STREAMING = new JobRunMode("STREAMING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobRunMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobRunMode FindValue(string value)
        {
            return FindValue<JobRunMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobRunMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobRunState.
    /// </summary>
    public class JobRunState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for JobRunState
        /// </summary>
        public static readonly JobRunState CANCELLED = new JobRunState("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for JobRunState
        /// </summary>
        public static readonly JobRunState CANCELLING = new JobRunState("CANCELLING");
        /// <summary>
        /// Constant FAILED for JobRunState
        /// </summary>
        public static readonly JobRunState FAILED = new JobRunState("FAILED");
        /// <summary>
        /// Constant PENDING for JobRunState
        /// </summary>
        public static readonly JobRunState PENDING = new JobRunState("PENDING");
        /// <summary>
        /// Constant QUEUED for JobRunState
        /// </summary>
        public static readonly JobRunState QUEUED = new JobRunState("QUEUED");
        /// <summary>
        /// Constant RUNNING for JobRunState
        /// </summary>
        public static readonly JobRunState RUNNING = new JobRunState("RUNNING");
        /// <summary>
        /// Constant SCHEDULED for JobRunState
        /// </summary>
        public static readonly JobRunState SCHEDULED = new JobRunState("SCHEDULED");
        /// <summary>
        /// Constant SUBMITTED for JobRunState
        /// </summary>
        public static readonly JobRunState SUBMITTED = new JobRunState("SUBMITTED");
        /// <summary>
        /// Constant SUCCESS for JobRunState
        /// </summary>
        public static readonly JobRunState SUCCESS = new JobRunState("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobRunState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobRunState FindValue(string value)
        {
            return FindValue<JobRunState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobRunState(string value)
        {
            return FindValue(value);
        }
    }

}