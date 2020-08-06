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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DataPipeline
{

    /// <summary>
    /// Constants used for properties of type OperatorType.
    /// </summary>
    public class OperatorType : ConstantClass
    {

        /// <summary>
        /// Constant BETWEEN for OperatorType
        /// </summary>
        public static readonly OperatorType BETWEEN = new OperatorType("BETWEEN");
        /// <summary>
        /// Constant EQ for OperatorType
        /// </summary>
        public static readonly OperatorType EQ = new OperatorType("EQ");
        /// <summary>
        /// Constant GE for OperatorType
        /// </summary>
        public static readonly OperatorType GE = new OperatorType("GE");
        /// <summary>
        /// Constant LE for OperatorType
        /// </summary>
        public static readonly OperatorType LE = new OperatorType("LE");
        /// <summary>
        /// Constant REF_EQ for OperatorType
        /// </summary>
        public static readonly OperatorType REF_EQ = new OperatorType("REF_EQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperatorType FindValue(string value)
        {
            return FindValue<OperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskStatus.
    /// </summary>
    public class TaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for TaskStatus
        /// </summary>
        public static readonly TaskStatus FAILED = new TaskStatus("FAILED");
        /// <summary>
        /// Constant FALSE for TaskStatus
        /// </summary>
        public static readonly TaskStatus FALSE = new TaskStatus("FALSE");
        /// <summary>
        /// Constant FINISHED for TaskStatus
        /// </summary>
        public static readonly TaskStatus FINISHED = new TaskStatus("FINISHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskStatus FindValue(string value)
        {
            return FindValue<TaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskStatus(string value)
        {
            return FindValue(value);
        }
    }

}