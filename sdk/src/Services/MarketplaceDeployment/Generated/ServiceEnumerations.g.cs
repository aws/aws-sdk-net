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

namespace Amazon.MarketplaceDeployment
{
    /// <summary>
    /// Constants used for properties of type DeliveryOptionType.
    /// </summary>
    public class DeliveryOptionType : ConstantClass
    {
        /// <summary>
        /// Constant DataAsAService for DeliveryOptionType
        /// </summary>
        public static readonly DeliveryOptionType DataAsAService = new DeliveryOptionType("data-as-a-service");

        /// <summary>
        /// Constructs a custom DeliveryOptionType for a value not among the defined constants.
        /// </summary>
        public DeliveryOptionType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryOptionType FindValue(string value)
        {
            return FindValue<DeliveryOptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryOptionType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DeploymentConfigurationJobErrorCode.
    /// </summary>
    public class DeploymentConfigurationJobErrorCode : ConstantClass
    {
        /// <summary>
        /// Constant ENDPOINT_INVALID for DeploymentConfigurationJobErrorCode
        /// </summary>
        public static readonly DeploymentConfigurationJobErrorCode ENDPOINT_INVALID = new DeploymentConfigurationJobErrorCode("ENDPOINT_INVALID");

        /// <summary>
        /// Constant FULFILLMENT_URL_UNREACHABLE for DeploymentConfigurationJobErrorCode
        /// </summary>
        public static readonly DeploymentConfigurationJobErrorCode FULFILLMENT_URL_UNREACHABLE = new DeploymentConfigurationJobErrorCode("FULFILLMENT_URL_UNREACHABLE");

        /// <summary>
        /// Constant INTERNAL_ERROR for DeploymentConfigurationJobErrorCode
        /// </summary>
        public static readonly DeploymentConfigurationJobErrorCode INTERNAL_ERROR = new DeploymentConfigurationJobErrorCode("INTERNAL_ERROR");

        /// <summary>
        /// Constructs a custom DeploymentConfigurationJobErrorCode for a value not among the defined constants.
        /// </summary>
        public DeploymentConfigurationJobErrorCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentConfigurationJobErrorCode FindValue(string value)
        {
            return FindValue<DeploymentConfigurationJobErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentConfigurationJobErrorCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DeploymentConfigurationJobStatus.
    /// </summary>
    public class DeploymentConfigurationJobStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for DeploymentConfigurationJobStatus
        /// </summary>
        public static readonly DeploymentConfigurationJobStatus FAILED = new DeploymentConfigurationJobStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for DeploymentConfigurationJobStatus
        /// </summary>
        public static readonly DeploymentConfigurationJobStatus IN_PROGRESS = new DeploymentConfigurationJobStatus("IN_PROGRESS");

        /// <summary>
        /// Constant SUCCEEDED for DeploymentConfigurationJobStatus
        /// </summary>
        public static readonly DeploymentConfigurationJobStatus SUCCEEDED = new DeploymentConfigurationJobStatus("SUCCEEDED");

        /// <summary>
        /// Constructs a custom DeploymentConfigurationJobStatus for a value not among the defined constants.
        /// </summary>
        public DeploymentConfigurationJobStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentConfigurationJobStatus FindValue(string value)
        {
            return FindValue<DeploymentConfigurationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentConfigurationJobStatus(string value)
        {
            return FindValue(value);
        }
    }
}
