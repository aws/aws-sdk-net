/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IoTEvents
{

    /// <summary>
    /// Constants used for properties of type DetectorModelVersionStatus.
    /// </summary>
    public class DetectorModelVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for DetectorModelVersionStatus
        /// </summary>
        public static readonly DetectorModelVersionStatus ACTIVATING = new DetectorModelVersionStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for DetectorModelVersionStatus
        /// </summary>
        public static readonly DetectorModelVersionStatus ACTIVE = new DetectorModelVersionStatus("ACTIVE");
        /// <summary>
        /// Constant DEPRECATED for DetectorModelVersionStatus
        /// </summary>
        public static readonly DetectorModelVersionStatus DEPRECATED = new DetectorModelVersionStatus("DEPRECATED");
        /// <summary>
        /// Constant DRAFT for DetectorModelVersionStatus
        /// </summary>
        public static readonly DetectorModelVersionStatus DRAFT = new DetectorModelVersionStatus("DRAFT");
        /// <summary>
        /// Constant FAILED for DetectorModelVersionStatus
        /// </summary>
        public static readonly DetectorModelVersionStatus FAILED = new DetectorModelVersionStatus("FAILED");
        /// <summary>
        /// Constant INACTIVE for DetectorModelVersionStatus
        /// </summary>
        public static readonly DetectorModelVersionStatus INACTIVE = new DetectorModelVersionStatus("INACTIVE");
        /// <summary>
        /// Constant PAUSED for DetectorModelVersionStatus
        /// </summary>
        public static readonly DetectorModelVersionStatus PAUSED = new DetectorModelVersionStatus("PAUSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetectorModelVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetectorModelVersionStatus FindValue(string value)
        {
            return FindValue<DetectorModelVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetectorModelVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputStatus.
    /// </summary>
    public class InputStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for InputStatus
        /// </summary>
        public static readonly InputStatus ACTIVE = new InputStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for InputStatus
        /// </summary>
        public static readonly InputStatus CREATING = new InputStatus("CREATING");
        /// <summary>
        /// Constant DELETING for InputStatus
        /// </summary>
        public static readonly InputStatus DELETING = new InputStatus("DELETING");
        /// <summary>
        /// Constant UPDATING for InputStatus
        /// </summary>
        public static readonly InputStatus UPDATING = new InputStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputStatus FindValue(string value)
        {
            return FindValue<InputStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoggingLevel.
    /// </summary>
    public class LoggingLevel : ConstantClass
    {

        /// <summary>
        /// Constant DEBUG for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel DEBUG = new LoggingLevel("DEBUG");
        /// <summary>
        /// Constant ERROR for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel ERROR = new LoggingLevel("ERROR");
        /// <summary>
        /// Constant INFO for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel INFO = new LoggingLevel("INFO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoggingLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggingLevel FindValue(string value)
        {
            return FindValue<LoggingLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggingLevel(string value)
        {
            return FindValue(value);
        }
    }

}