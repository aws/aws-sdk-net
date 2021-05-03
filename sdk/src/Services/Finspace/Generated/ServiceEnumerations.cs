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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Finspace
{

    /// <summary>
    /// Constants used for properties of type EnvironmentStatus.
    /// </summary>
    public class EnvironmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_REQUESTED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus CREATE_REQUESTED = new EnvironmentStatus("CREATE_REQUESTED");
        /// <summary>
        /// Constant CREATED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus CREATED = new EnvironmentStatus("CREATED");
        /// <summary>
        /// Constant CREATING for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus CREATING = new EnvironmentStatus("CREATING");
        /// <summary>
        /// Constant DELETE_REQUESTED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DELETE_REQUESTED = new EnvironmentStatus("DELETE_REQUESTED");
        /// <summary>
        /// Constant DELETED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DELETED = new EnvironmentStatus("DELETED");
        /// <summary>
        /// Constant DELETING for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DELETING = new EnvironmentStatus("DELETING");
        /// <summary>
        /// Constant FAILED_CREATION for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus FAILED_CREATION = new EnvironmentStatus("FAILED_CREATION");
        /// <summary>
        /// Constant FAILED_DELETION for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus FAILED_DELETION = new EnvironmentStatus("FAILED_DELETION");
        /// <summary>
        /// Constant RETRY_DELETION for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus RETRY_DELETION = new EnvironmentStatus("RETRY_DELETION");
        /// <summary>
        /// Constant SUSPENDED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus SUSPENDED = new EnvironmentStatus("SUSPENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentStatus FindValue(string value)
        {
            return FindValue<EnvironmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FederationMode.
    /// </summary>
    public class FederationMode : ConstantClass
    {

        /// <summary>
        /// Constant FEDERATED for FederationMode
        /// </summary>
        public static readonly FederationMode FEDERATED = new FederationMode("FEDERATED");
        /// <summary>
        /// Constant LOCAL for FederationMode
        /// </summary>
        public static readonly FederationMode LOCAL = new FederationMode("LOCAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FederationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FederationMode FindValue(string value)
        {
            return FindValue<FederationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FederationMode(string value)
        {
            return FindValue(value);
        }
    }

}