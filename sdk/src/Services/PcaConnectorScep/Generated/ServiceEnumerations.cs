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
 * Do not modify this file. This file is generated from the pca-connector-scep-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PcaConnectorScep
{

    /// <summary>
    /// Constants used for properties of type ConnectorStatus.
    /// </summary>
    public class ConnectorStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus ACTIVE = new ConnectorStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus CREATING = new ConnectorStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus DELETING = new ConnectorStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus FAILED = new ConnectorStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorStatus FindValue(string value)
        {
            return FindValue<ConnectorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorStatusReason.
    /// </summary>
    public class ConnectorStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_FAILURE for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason INTERNAL_FAILURE = new ConnectorStatusReason("INTERNAL_FAILURE");
        /// <summary>
        /// Constant PRIVATECA_ACCESS_DENIED for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason PRIVATECA_ACCESS_DENIED = new ConnectorStatusReason("PRIVATECA_ACCESS_DENIED");
        /// <summary>
        /// Constant PRIVATECA_INVALID_STATE for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason PRIVATECA_INVALID_STATE = new ConnectorStatusReason("PRIVATECA_INVALID_STATE");
        /// <summary>
        /// Constant PRIVATECA_RESOURCE_NOT_FOUND for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason PRIVATECA_RESOURCE_NOT_FOUND = new ConnectorStatusReason("PRIVATECA_RESOURCE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorStatusReason FindValue(string value)
        {
            return FindValue<ConnectorStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorStatusReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorType.
    /// </summary>
    public class ConnectorType : ConstantClass
    {

        /// <summary>
        /// Constant GENERAL_PURPOSE for ConnectorType
        /// </summary>
        public static readonly ConnectorType GENERAL_PURPOSE = new ConnectorType("GENERAL_PURPOSE");
        /// <summary>
        /// Constant INTUNE for ConnectorType
        /// </summary>
        public static readonly ConnectorType INTUNE = new ConnectorType("INTUNE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorType FindValue(string value)
        {
            return FindValue<ConnectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CA_CERT_VALIDITY_TOO_SHORT for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CA_CERT_VALIDITY_TOO_SHORT = new ValidationExceptionReason("CA_CERT_VALIDITY_TOO_SHORT");
        /// <summary>
        /// Constant INVALID_CA_USAGE_MODE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_CA_USAGE_MODE = new ValidationExceptionReason("INVALID_CA_USAGE_MODE");
        /// <summary>
        /// Constant INVALID_CONNECTOR_TYPE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_CONNECTOR_TYPE = new ValidationExceptionReason("INVALID_CONNECTOR_TYPE");
        /// <summary>
        /// Constant INVALID_STATE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_STATE = new ValidationExceptionReason("INVALID_STATE");
        /// <summary>
        /// Constant NO_CLIENT_TOKEN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason NO_CLIENT_TOKEN = new ValidationExceptionReason("NO_CLIENT_TOKEN");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}