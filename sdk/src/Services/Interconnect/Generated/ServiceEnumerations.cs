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
 * Do not modify this file. This file is generated from the interconnect-2022-07-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Interconnect
{

    /// <summary>
    /// Constants used for properties of type AttachPointType.
    /// </summary>
    public class AttachPointType : ConstantClass
    {

        /// <summary>
        /// Constant DirectConnectGateway for AttachPointType
        /// </summary>
        public static readonly AttachPointType DirectConnectGateway = new AttachPointType("DirectConnectGateway");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachPointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachPointType FindValue(string value)
        {
            return FindValue<AttachPointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachPointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionState.
    /// </summary>
    public class ConnectionState : ConstantClass
    {

        /// <summary>
        /// Constant Available for ConnectionState
        /// </summary>
        public static readonly ConnectionState Available = new ConnectionState("available");
        /// <summary>
        /// Constant Deleted for ConnectionState
        /// </summary>
        public static readonly ConnectionState Deleted = new ConnectionState("deleted");
        /// <summary>
        /// Constant Deleting for ConnectionState
        /// </summary>
        public static readonly ConnectionState Deleting = new ConnectionState("deleting");
        /// <summary>
        /// Constant Down for ConnectionState
        /// </summary>
        public static readonly ConnectionState Down = new ConnectionState("down");
        /// <summary>
        /// Constant Failed for ConnectionState
        /// </summary>
        public static readonly ConnectionState Failed = new ConnectionState("failed");
        /// <summary>
        /// Constant Pending for ConnectionState
        /// </summary>
        public static readonly ConnectionState Pending = new ConnectionState("pending");
        /// <summary>
        /// Constant Requested for ConnectionState
        /// </summary>
        public static readonly ConnectionState Requested = new ConnectionState("requested");
        /// <summary>
        /// Constant Updating for ConnectionState
        /// </summary>
        public static readonly ConnectionState Updating = new ConnectionState("updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionState FindValue(string value)
        {
            return FindValue<ConnectionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentState.
    /// </summary>
    public class EnvironmentState : ConstantClass
    {

        /// <summary>
        /// Constant Available for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState Available = new EnvironmentState("available");
        /// <summary>
        /// Constant Limited for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState Limited = new EnvironmentState("limited");
        /// <summary>
        /// Constant Unavailable for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState Unavailable = new EnvironmentState("unavailable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentState FindValue(string value)
        {
            return FindValue<EnvironmentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RemoteAccountIdentifierType.
    /// </summary>
    public class RemoteAccountIdentifierType : ConstantClass
    {

        /// <summary>
        /// Constant Account for RemoteAccountIdentifierType
        /// </summary>
        public static readonly RemoteAccountIdentifierType Account = new RemoteAccountIdentifierType("account");
        /// <summary>
        /// Constant Email for RemoteAccountIdentifierType
        /// </summary>
        public static readonly RemoteAccountIdentifierType Email = new RemoteAccountIdentifierType("email");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RemoteAccountIdentifierType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RemoteAccountIdentifierType FindValue(string value)
        {
            return FindValue<RemoteAccountIdentifierType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RemoteAccountIdentifierType(string value)
        {
            return FindValue(value);
        }
    }

}