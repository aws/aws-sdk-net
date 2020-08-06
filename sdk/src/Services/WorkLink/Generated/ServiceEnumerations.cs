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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.WorkLink
{

    /// <summary>
    /// Constants used for properties of type AuthorizationProviderType.
    /// </summary>
    public class AuthorizationProviderType : ConstantClass
    {

        /// <summary>
        /// Constant SAML for AuthorizationProviderType
        /// </summary>
        public static readonly AuthorizationProviderType SAML = new AuthorizationProviderType("SAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthorizationProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthorizationProviderType FindValue(string value)
        {
            return FindValue<AuthorizationProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthorizationProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceStatus.
    /// </summary>
    public class DeviceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus ACTIVE = new DeviceStatus("ACTIVE");
        /// <summary>
        /// Constant SIGNED_OUT for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus SIGNED_OUT = new DeviceStatus("SIGNED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceStatus FindValue(string value)
        {
            return FindValue<DeviceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainStatus.
    /// </summary>
    public class DomainStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DomainStatus
        /// </summary>
        public static readonly DomainStatus ACTIVE = new DomainStatus("ACTIVE");
        /// <summary>
        /// Constant ASSOCIATING for DomainStatus
        /// </summary>
        public static readonly DomainStatus ASSOCIATING = new DomainStatus("ASSOCIATING");
        /// <summary>
        /// Constant DISASSOCIATED for DomainStatus
        /// </summary>
        public static readonly DomainStatus DISASSOCIATED = new DomainStatus("DISASSOCIATED");
        /// <summary>
        /// Constant DISASSOCIATING for DomainStatus
        /// </summary>
        public static readonly DomainStatus DISASSOCIATING = new DomainStatus("DISASSOCIATING");
        /// <summary>
        /// Constant FAILED_TO_ASSOCIATE for DomainStatus
        /// </summary>
        public static readonly DomainStatus FAILED_TO_ASSOCIATE = new DomainStatus("FAILED_TO_ASSOCIATE");
        /// <summary>
        /// Constant FAILED_TO_DISASSOCIATE for DomainStatus
        /// </summary>
        public static readonly DomainStatus FAILED_TO_DISASSOCIATE = new DomainStatus("FAILED_TO_DISASSOCIATE");
        /// <summary>
        /// Constant INACTIVE for DomainStatus
        /// </summary>
        public static readonly DomainStatus INACTIVE = new DomainStatus("INACTIVE");
        /// <summary>
        /// Constant PENDING_VALIDATION for DomainStatus
        /// </summary>
        public static readonly DomainStatus PENDING_VALIDATION = new DomainStatus("PENDING_VALIDATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainStatus FindValue(string value)
        {
            return FindValue<DomainStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetStatus.
    /// </summary>
    public class FleetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FleetStatus
        /// </summary>
        public static readonly FleetStatus ACTIVE = new FleetStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for FleetStatus
        /// </summary>
        public static readonly FleetStatus CREATING = new FleetStatus("CREATING");
        /// <summary>
        /// Constant DELETED for FleetStatus
        /// </summary>
        public static readonly FleetStatus DELETED = new FleetStatus("DELETED");
        /// <summary>
        /// Constant DELETING for FleetStatus
        /// </summary>
        public static readonly FleetStatus DELETING = new FleetStatus("DELETING");
        /// <summary>
        /// Constant FAILED_TO_CREATE for FleetStatus
        /// </summary>
        public static readonly FleetStatus FAILED_TO_CREATE = new FleetStatus("FAILED_TO_CREATE");
        /// <summary>
        /// Constant FAILED_TO_DELETE for FleetStatus
        /// </summary>
        public static readonly FleetStatus FAILED_TO_DELETE = new FleetStatus("FAILED_TO_DELETE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetStatus FindValue(string value)
        {
            return FindValue<FleetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityProviderType.
    /// </summary>
    public class IdentityProviderType : ConstantClass
    {

        /// <summary>
        /// Constant SAML for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType SAML = new IdentityProviderType("SAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityProviderType FindValue(string value)
        {
            return FindValue<IdentityProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityProviderType(string value)
        {
            return FindValue(value);
        }
    }

}