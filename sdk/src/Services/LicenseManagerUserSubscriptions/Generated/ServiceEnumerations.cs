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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.LicenseManagerUserSubscriptions
{

    /// <summary>
    /// Constants used for properties of type ActiveDirectoryType.
    /// </summary>
    public class ActiveDirectoryType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_MANAGED for ActiveDirectoryType
        /// </summary>
        public static readonly ActiveDirectoryType AWS_MANAGED = new ActiveDirectoryType("AWS_MANAGED");
        /// <summary>
        /// Constant SELF_MANAGED for ActiveDirectoryType
        /// </summary>
        public static readonly ActiveDirectoryType SELF_MANAGED = new ActiveDirectoryType("SELF_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActiveDirectoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActiveDirectoryType FindValue(string value)
        {
            return FindValue<ActiveDirectoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActiveDirectoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseServerEndpointProvisioningStatus.
    /// </summary>
    public class LicenseServerEndpointProvisioningStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for LicenseServerEndpointProvisioningStatus
        /// </summary>
        public static readonly LicenseServerEndpointProvisioningStatus DELETED = new LicenseServerEndpointProvisioningStatus("DELETED");
        /// <summary>
        /// Constant DELETING for LicenseServerEndpointProvisioningStatus
        /// </summary>
        public static readonly LicenseServerEndpointProvisioningStatus DELETING = new LicenseServerEndpointProvisioningStatus("DELETING");
        /// <summary>
        /// Constant DELETION_FAILED for LicenseServerEndpointProvisioningStatus
        /// </summary>
        public static readonly LicenseServerEndpointProvisioningStatus DELETION_FAILED = new LicenseServerEndpointProvisioningStatus("DELETION_FAILED");
        /// <summary>
        /// Constant PROVISIONED for LicenseServerEndpointProvisioningStatus
        /// </summary>
        public static readonly LicenseServerEndpointProvisioningStatus PROVISIONED = new LicenseServerEndpointProvisioningStatus("PROVISIONED");
        /// <summary>
        /// Constant PROVISIONING for LicenseServerEndpointProvisioningStatus
        /// </summary>
        public static readonly LicenseServerEndpointProvisioningStatus PROVISIONING = new LicenseServerEndpointProvisioningStatus("PROVISIONING");
        /// <summary>
        /// Constant PROVISIONING_FAILED for LicenseServerEndpointProvisioningStatus
        /// </summary>
        public static readonly LicenseServerEndpointProvisioningStatus PROVISIONING_FAILED = new LicenseServerEndpointProvisioningStatus("PROVISIONING_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseServerEndpointProvisioningStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseServerEndpointProvisioningStatus FindValue(string value)
        {
            return FindValue<LicenseServerEndpointProvisioningStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseServerEndpointProvisioningStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseServerHealthStatus.
    /// </summary>
    public class LicenseServerHealthStatus : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for LicenseServerHealthStatus
        /// </summary>
        public static readonly LicenseServerHealthStatus HEALTHY = new LicenseServerHealthStatus("HEALTHY");
        /// <summary>
        /// Constant NOT_APPLICABLE for LicenseServerHealthStatus
        /// </summary>
        public static readonly LicenseServerHealthStatus NOT_APPLICABLE = new LicenseServerHealthStatus("NOT_APPLICABLE");
        /// <summary>
        /// Constant UNHEALTHY for LicenseServerHealthStatus
        /// </summary>
        public static readonly LicenseServerHealthStatus UNHEALTHY = new LicenseServerHealthStatus("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseServerHealthStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseServerHealthStatus FindValue(string value)
        {
            return FindValue<LicenseServerHealthStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseServerHealthStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerType.
    /// </summary>
    public class ServerType : ConstantClass
    {

        /// <summary>
        /// Constant RDS_SAL for ServerType
        /// </summary>
        public static readonly ServerType RDS_SAL = new ServerType("RDS_SAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerType FindValue(string value)
        {
            return FindValue<ServerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerType(string value)
        {
            return FindValue(value);
        }
    }

}