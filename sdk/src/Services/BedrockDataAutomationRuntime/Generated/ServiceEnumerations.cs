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
 * Do not modify this file. This file is generated from the bedrock-data-automation-runtime-2024-06-13.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BedrockDataAutomationRuntime
{

    /// <summary>
    /// Constants used for properties of type AutomationJobStatus.
    /// </summary>
    public class AutomationJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant ClientError for AutomationJobStatus
        /// </summary>
        public static readonly AutomationJobStatus ClientError = new AutomationJobStatus("ClientError");
        /// <summary>
        /// Constant Created for AutomationJobStatus
        /// </summary>
        public static readonly AutomationJobStatus Created = new AutomationJobStatus("Created");
        /// <summary>
        /// Constant InProgress for AutomationJobStatus
        /// </summary>
        public static readonly AutomationJobStatus InProgress = new AutomationJobStatus("InProgress");
        /// <summary>
        /// Constant ServiceError for AutomationJobStatus
        /// </summary>
        public static readonly AutomationJobStatus ServiceError = new AutomationJobStatus("ServiceError");
        /// <summary>
        /// Constant Success for AutomationJobStatus
        /// </summary>
        public static readonly AutomationJobStatus Success = new AutomationJobStatus("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomationJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomationJobStatus FindValue(string value)
        {
            return FindValue<AutomationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomationJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BlueprintStage.
    /// </summary>
    public class BlueprintStage : ConstantClass
    {

        /// <summary>
        /// Constant DEVELOPMENT for BlueprintStage
        /// </summary>
        public static readonly BlueprintStage DEVELOPMENT = new BlueprintStage("DEVELOPMENT");
        /// <summary>
        /// Constant LIVE for BlueprintStage
        /// </summary>
        public static readonly BlueprintStage LIVE = new BlueprintStage("LIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlueprintStage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlueprintStage FindValue(string value)
        {
            return FindValue<BlueprintStage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlueprintStage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataAutomationStage.
    /// </summary>
    public class DataAutomationStage : ConstantClass
    {

        /// <summary>
        /// Constant DEVELOPMENT for DataAutomationStage
        /// </summary>
        public static readonly DataAutomationStage DEVELOPMENT = new DataAutomationStage("DEVELOPMENT");
        /// <summary>
        /// Constant LIVE for DataAutomationStage
        /// </summary>
        public static readonly DataAutomationStage LIVE = new DataAutomationStage("LIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataAutomationStage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataAutomationStage FindValue(string value)
        {
            return FindValue<DataAutomationStage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataAutomationStage(string value)
        {
            return FindValue(value);
        }
    }

}