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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Greengrass
{

    /// <summary>
    /// Constants used for properties of type DeploymentType.
    /// </summary>
    public class DeploymentType : ConstantClass
    {

        /// <summary>
        /// Constant NewDeployment for DeploymentType
        /// </summary>
        public static readonly DeploymentType NewDeployment = new DeploymentType("NewDeployment");
        /// <summary>
        /// Constant Redeployment for DeploymentType
        /// </summary>
        public static readonly DeploymentType Redeployment = new DeploymentType("Redeployment");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentType FindValue(string value)
        {
            return FindValue<DeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoggerComponent.
    /// </summary>
    public class LoggerComponent : ConstantClass
    {

        /// <summary>
        /// Constant GreengrassSystem for LoggerComponent
        /// </summary>
        public static readonly LoggerComponent GreengrassSystem = new LoggerComponent("GreengrassSystem");
        /// <summary>
        /// Constant Lambda for LoggerComponent
        /// </summary>
        public static readonly LoggerComponent Lambda = new LoggerComponent("Lambda");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoggerComponent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggerComponent FindValue(string value)
        {
            return FindValue<LoggerComponent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggerComponent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoggerLevel.
    /// </summary>
    public class LoggerLevel : ConstantClass
    {

        /// <summary>
        /// Constant DEBUG for LoggerLevel
        /// </summary>
        public static readonly LoggerLevel DEBUG = new LoggerLevel("DEBUG");
        /// <summary>
        /// Constant ERROR for LoggerLevel
        /// </summary>
        public static readonly LoggerLevel ERROR = new LoggerLevel("ERROR");
        /// <summary>
        /// Constant FATAL for LoggerLevel
        /// </summary>
        public static readonly LoggerLevel FATAL = new LoggerLevel("FATAL");
        /// <summary>
        /// Constant INFO for LoggerLevel
        /// </summary>
        public static readonly LoggerLevel INFO = new LoggerLevel("INFO");
        /// <summary>
        /// Constant WARN for LoggerLevel
        /// </summary>
        public static readonly LoggerLevel WARN = new LoggerLevel("WARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoggerLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggerLevel FindValue(string value)
        {
            return FindValue<LoggerLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggerLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoggerType.
    /// </summary>
    public class LoggerType : ConstantClass
    {

        /// <summary>
        /// Constant AWSCloudWatch for LoggerType
        /// </summary>
        public static readonly LoggerType AWSCloudWatch = new LoggerType("AWSCloudWatch");
        /// <summary>
        /// Constant FileSystem for LoggerType
        /// </summary>
        public static readonly LoggerType FileSystem = new LoggerType("FileSystem");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoggerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggerType FindValue(string value)
        {
            return FindValue<LoggerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggerType(string value)
        {
            return FindValue(value);
        }
    }

}