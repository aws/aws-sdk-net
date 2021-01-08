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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Schemas
{

    /// <summary>
    /// Constants used for properties of type CodeGenerationStatus.
    /// </summary>
    public class CodeGenerationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_COMPLETE for CodeGenerationStatus
        /// </summary>
        public static readonly CodeGenerationStatus CREATE_COMPLETE = new CodeGenerationStatus("CREATE_COMPLETE");
        /// <summary>
        /// Constant CREATE_FAILED for CodeGenerationStatus
        /// </summary>
        public static readonly CodeGenerationStatus CREATE_FAILED = new CodeGenerationStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for CodeGenerationStatus
        /// </summary>
        public static readonly CodeGenerationStatus CREATE_IN_PROGRESS = new CodeGenerationStatus("CREATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeGenerationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeGenerationStatus FindValue(string value)
        {
            return FindValue<CodeGenerationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeGenerationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiscovererState.
    /// </summary>
    public class DiscovererState : ConstantClass
    {

        /// <summary>
        /// Constant STARTED for DiscovererState
        /// </summary>
        public static readonly DiscovererState STARTED = new DiscovererState("STARTED");
        /// <summary>
        /// Constant STOPPED for DiscovererState
        /// </summary>
        public static readonly DiscovererState STOPPED = new DiscovererState("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiscovererState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiscovererState FindValue(string value)
        {
            return FindValue<DiscovererState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiscovererState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Type.
    /// </summary>
    public class Type : ConstantClass
    {

        /// <summary>
        /// Constant JSONSchemaDraft4 for Type
        /// </summary>
        public static readonly Type JSONSchemaDraft4 = new Type("JSONSchemaDraft4");
        /// <summary>
        /// Constant OpenApi3 for Type
        /// </summary>
        public static readonly Type OpenApi3 = new Type("OpenApi3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Type(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Type FindValue(string value)
        {
            return FindValue<Type>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Type(string value)
        {
            return FindValue(value);
        }
    }

}