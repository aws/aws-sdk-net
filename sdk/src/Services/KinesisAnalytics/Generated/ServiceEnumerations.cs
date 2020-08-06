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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.KinesisAnalytics
{

    /// <summary>
    /// Constants used for properties of type ApplicationStatus.
    /// </summary>
    public class ApplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus DELETING = new ApplicationStatus("DELETING");
        /// <summary>
        /// Constant READY for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus READY = new ApplicationStatus("READY");
        /// <summary>
        /// Constant RUNNING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus RUNNING = new ApplicationStatus("RUNNING");
        /// <summary>
        /// Constant STARTING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus STARTING = new ApplicationStatus("STARTING");
        /// <summary>
        /// Constant STOPPING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus STOPPING = new ApplicationStatus("STOPPING");
        /// <summary>
        /// Constant UPDATING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus UPDATING = new ApplicationStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationStatus FindValue(string value)
        {
            return FindValue<ApplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputStartingPosition.
    /// </summary>
    public class InputStartingPosition : ConstantClass
    {

        /// <summary>
        /// Constant LAST_STOPPED_POINT for InputStartingPosition
        /// </summary>
        public static readonly InputStartingPosition LAST_STOPPED_POINT = new InputStartingPosition("LAST_STOPPED_POINT");
        /// <summary>
        /// Constant NOW for InputStartingPosition
        /// </summary>
        public static readonly InputStartingPosition NOW = new InputStartingPosition("NOW");
        /// <summary>
        /// Constant TRIM_HORIZON for InputStartingPosition
        /// </summary>
        public static readonly InputStartingPosition TRIM_HORIZON = new InputStartingPosition("TRIM_HORIZON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputStartingPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputStartingPosition FindValue(string value)
        {
            return FindValue<InputStartingPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputStartingPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordFormatType.
    /// </summary>
    public class RecordFormatType : ConstantClass
    {

        /// <summary>
        /// Constant CSV for RecordFormatType
        /// </summary>
        public static readonly RecordFormatType CSV = new RecordFormatType("CSV");
        /// <summary>
        /// Constant JSON for RecordFormatType
        /// </summary>
        public static readonly RecordFormatType JSON = new RecordFormatType("JSON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordFormatType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordFormatType FindValue(string value)
        {
            return FindValue<RecordFormatType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordFormatType(string value)
        {
            return FindValue(value);
        }
    }

}