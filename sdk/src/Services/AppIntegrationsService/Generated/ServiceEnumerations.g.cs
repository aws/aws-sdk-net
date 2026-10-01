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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.AppIntegrationsService
{
    /// <summary>
    /// Constants used for properties of type ApplicationType.
    /// </summary>
    public class ApplicationType : ConstantClass
    {
        /// <summary>
        /// Constant A2A_SERVER for ApplicationType
        /// </summary>
        public static readonly ApplicationType A2A_SERVER = new ApplicationType("A2A_SERVER");

        /// <summary>
        /// Constant MCP_SERVER for ApplicationType
        /// </summary>
        public static readonly ApplicationType MCP_SERVER = new ApplicationType("MCP_SERVER");

        /// <summary>
        /// Constant SERVICE for ApplicationType
        /// </summary>
        public static readonly ApplicationType SERVICE = new ApplicationType("SERVICE");

        /// <summary>
        /// Constant STANDARD for ApplicationType
        /// </summary>
        public static readonly ApplicationType STANDARD = new ApplicationType("STANDARD");

        /// <summary>
        /// Constructs a custom ApplicationType for a value not among the defined constants.
        /// </summary>
        public ApplicationType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationType FindValue(string value)
        {
            return FindValue<ApplicationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type AuthType.
    /// </summary>
    public class AuthType : ConstantClass
    {
        /// <summary>
        /// Constant API_KEY for AuthType
        /// </summary>
        public static readonly AuthType API_KEY = new AuthType("API_KEY");

        /// <summary>
        /// Constructs a custom AuthType for a value not among the defined constants.
        /// </summary>
        public AuthType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthType FindValue(string value)
        {
            return FindValue<AuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthType(string value)
        {
            return FindValue(value);
        }
    }

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
        /// Constructs a custom ContactHandlingScope for a value not among the defined constants.
        /// </summary>
        public ContactHandlingScope(string value) : base(value) { }

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
        /// Constructs a custom ExecutionMode for a value not among the defined constants.
        /// </summary>
        public ExecutionMode(string value) : base(value) { }

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
        /// Constructs a custom ExecutionStatus for a value not among the defined constants.
        /// </summary>
        public ExecutionStatus(string value) : base(value) { }

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
