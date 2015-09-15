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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ElasticFileSystem
{

    /// <summary>
    /// Constants used for properties of type LifeCycleState.
    /// </summary>
    public class LifeCycleState : ConstantClass
    {

        /// <summary>
        /// Constant Available for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Available = new LifeCycleState("available");
        /// <summary>
        /// Constant Creating for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Creating = new LifeCycleState("creating");
        /// <summary>
        /// Constant Deleted for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Deleted = new LifeCycleState("deleted");
        /// <summary>
        /// Constant Deleting for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Deleting = new LifeCycleState("deleting");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public LifeCycleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifeCycleState FindValue(string value)
        {
            return FindValue<LifeCycleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifeCycleState(string value)
        {
            return FindValue(value);
        }
    }

}