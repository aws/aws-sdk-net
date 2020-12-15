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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IoTDeviceAdvisor
{

    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for Status
        /// </summary>
        public static readonly Status CANCELED = new Status("CANCELED");
        /// <summary>
        /// Constant ERROR for Status
        /// </summary>
        public static readonly Status ERROR = new Status("ERROR");
        /// <summary>
        /// Constant FAIL for Status
        /// </summary>
        public static readonly Status FAIL = new Status("FAIL");
        /// <summary>
        /// Constant PASS for Status
        /// </summary>
        public static readonly Status PASS = new Status("PASS");
        /// <summary>
        /// Constant PASS_WITH_WARNINGS for Status
        /// </summary>
        public static readonly Status PASS_WITH_WARNINGS = new Status("PASS_WITH_WARNINGS");
        /// <summary>
        /// Constant PENDING for Status
        /// </summary>
        public static readonly Status PENDING = new Status("PENDING");
        /// <summary>
        /// Constant RUNNING for Status
        /// </summary>
        public static readonly Status RUNNING = new Status("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SuiteRunStatus.
    /// </summary>
    public class SuiteRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for SuiteRunStatus
        /// </summary>
        public static readonly SuiteRunStatus CANCELED = new SuiteRunStatus("CANCELED");
        /// <summary>
        /// Constant ERROR for SuiteRunStatus
        /// </summary>
        public static readonly SuiteRunStatus ERROR = new SuiteRunStatus("ERROR");
        /// <summary>
        /// Constant FAIL for SuiteRunStatus
        /// </summary>
        public static readonly SuiteRunStatus FAIL = new SuiteRunStatus("FAIL");
        /// <summary>
        /// Constant PASS for SuiteRunStatus
        /// </summary>
        public static readonly SuiteRunStatus PASS = new SuiteRunStatus("PASS");
        /// <summary>
        /// Constant PASS_WITH_WARNINGS for SuiteRunStatus
        /// </summary>
        public static readonly SuiteRunStatus PASS_WITH_WARNINGS = new SuiteRunStatus("PASS_WITH_WARNINGS");
        /// <summary>
        /// Constant PENDING for SuiteRunStatus
        /// </summary>
        public static readonly SuiteRunStatus PENDING = new SuiteRunStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for SuiteRunStatus
        /// </summary>
        public static readonly SuiteRunStatus RUNNING = new SuiteRunStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SuiteRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SuiteRunStatus FindValue(string value)
        {
            return FindValue<SuiteRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SuiteRunStatus(string value)
        {
            return FindValue(value);
        }
    }

}