/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.Runtime;


namespace Amazon.DataPipeline
{


    /// <summary>Operator Type
    /// </summary>
    public class OperatorType : ConstantClass
    {


       /// <summary>Constant BETWEEN for OperatorType
       /// </summary>
        public static readonly OperatorType BETWEEN = new OperatorType("BETWEEN");
    

       /// <summary>Constant EQ for OperatorType
       /// </summary>
        public static readonly OperatorType EQ = new OperatorType("EQ");
    

       /// <summary>Constant GE for OperatorType
       /// </summary>
        public static readonly OperatorType GE = new OperatorType("GE");
    

       /// <summary>Constant LE for OperatorType
       /// </summary>
        public static readonly OperatorType LE = new OperatorType("LE");
    

       /// <summary>Constant REF_EQ for OperatorType
       /// </summary>
        public static readonly OperatorType REF_EQ = new OperatorType("REF_EQ");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator OperatorType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Task Status
    /// </summary>
    public class TaskStatus : ConstantClass
    {


       /// <summary>Constant FAILED for TaskStatus
       /// </summary>
        public static readonly TaskStatus FAILED = new TaskStatus("FAILED");
    

       /// <summary>Constant FALSE for TaskStatus
       /// </summary>
        public static readonly TaskStatus FALSE = new TaskStatus("FALSE");
    

       /// <summary>Constant FINISHED for TaskStatus
       /// </summary>
        public static readonly TaskStatus FINISHED = new TaskStatus("FINISHED");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator TaskStatus(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
