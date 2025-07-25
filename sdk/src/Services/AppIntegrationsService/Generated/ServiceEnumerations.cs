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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AppIntegrationsService
{

    /// <summary>
    /// Constants used for properties of type ContactHandlingScope.
    /// </summary>
    public class ContactHandlingScope : ConstantClass
    {

        /// <summary>
        /// Constant CROSS_CONTACTS for ContactHandlingScope
        /// </summary>
        public static readonly ContactHandlingScope CROSS_CONTACTS = new ContactHandlingScope("CROSS_CONTACTS");
        /// <summary>
        /// Constant PER_CONTACT for ContactHandlingScope
        /// </summary>
        public static readonly ContactHandlingScope PER_CONTACT = new ContactHandlingScope("PER_CONTACT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactHandlingScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactHandlingScope FindValue(string value)
        {
            return FindValue<ContactHandlingScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactHandlingScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionMode.
    /// </summary>
    public class ExecutionMode : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND for ExecutionMode
        /// </summary>
        public static readonly ExecutionMode ON_DEMAND = new ExecutionMode("ON_DEMAND");
        /// <summary>
        /// Constant SCHEDULED for ExecutionMode
        /// </summary>
        public static readonly ExecutionMode SCHEDULED = new ExecutionMode("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionMode FindValue(string value)
        {
            return FindValue<ExecutionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionStatus.
    /// </summary>
    public class ExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus COMPLETED = new ExecutionStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus FAILED = new ExecutionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus IN_PROGRESS = new ExecutionStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionStatus FindValue(string value)
        {
            return FindValue<ExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }

}