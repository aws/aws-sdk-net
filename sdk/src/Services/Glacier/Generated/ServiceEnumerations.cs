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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Glacier
{

    /// <summary>
    /// Constants used for properties of type ActionCode.
    /// </summary>
    public class ActionCode : ConstantClass
    {

        /// <summary>
        /// Constant ArchiveRetrieval for ActionCode
        /// </summary>
        public static readonly ActionCode ArchiveRetrieval = new ActionCode("ArchiveRetrieval");
        /// <summary>
        /// Constant InventoryRetrieval for ActionCode
        /// </summary>
        public static readonly ActionCode InventoryRetrieval = new ActionCode("InventoryRetrieval");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ActionCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionCode FindValue(string value)
        {
            return FindValue<ActionCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusCode.
    /// </summary>
    public class StatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Failed for StatusCode
        /// </summary>
        public static readonly StatusCode Failed = new StatusCode("Failed");
        /// <summary>
        /// Constant InProgress for StatusCode
        /// </summary>
        public static readonly StatusCode InProgress = new StatusCode("InProgress");
        /// <summary>
        /// Constant Succeeded for StatusCode
        /// </summary>
        public static readonly StatusCode Succeeded = new StatusCode("Succeeded");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public StatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusCode FindValue(string value)
        {
            return FindValue<StatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusCode(string value)
        {
            return FindValue(value);
        }
    }

}