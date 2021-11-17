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
 * Do not modify this file. This file is generated from the appconfigdata-2021-11-11.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AppConfigData
{

    /// <summary>
    /// Constants used for properties of type BadRequestReason.
    /// </summary>
    public class BadRequestReason : ConstantClass
    {

        /// <summary>
        /// Constant InvalidParameters for BadRequestReason
        /// </summary>
        public static readonly BadRequestReason InvalidParameters = new BadRequestReason("InvalidParameters");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BadRequestReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BadRequestReason FindValue(string value)
        {
            return FindValue<BadRequestReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BadRequestReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvalidParameterProblem.
    /// </summary>
    public class InvalidParameterProblem : ConstantClass
    {

        /// <summary>
        /// Constant Corrupted for InvalidParameterProblem
        /// </summary>
        public static readonly InvalidParameterProblem Corrupted = new InvalidParameterProblem("Corrupted");
        /// <summary>
        /// Constant Expired for InvalidParameterProblem
        /// </summary>
        public static readonly InvalidParameterProblem Expired = new InvalidParameterProblem("Expired");
        /// <summary>
        /// Constant PollIntervalNotSatisfied for InvalidParameterProblem
        /// </summary>
        public static readonly InvalidParameterProblem PollIntervalNotSatisfied = new InvalidParameterProblem("PollIntervalNotSatisfied");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvalidParameterProblem(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvalidParameterProblem FindValue(string value)
        {
            return FindValue<InvalidParameterProblem>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvalidParameterProblem(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant Application for ResourceType
        /// </summary>
        public static readonly ResourceType Application = new ResourceType("Application");
        /// <summary>
        /// Constant Configuration for ResourceType
        /// </summary>
        public static readonly ResourceType Configuration = new ResourceType("Configuration");
        /// <summary>
        /// Constant ConfigurationProfile for ResourceType
        /// </summary>
        public static readonly ResourceType ConfigurationProfile = new ResourceType("ConfigurationProfile");
        /// <summary>
        /// Constant Deployment for ResourceType
        /// </summary>
        public static readonly ResourceType Deployment = new ResourceType("Deployment");
        /// <summary>
        /// Constant Environment for ResourceType
        /// </summary>
        public static readonly ResourceType Environment = new ResourceType("Environment");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }

}