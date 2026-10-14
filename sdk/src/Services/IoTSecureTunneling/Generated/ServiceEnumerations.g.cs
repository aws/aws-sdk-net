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

namespace Amazon.IoTSecureTunneling
{
    /// <summary>
    /// Constants used for properties of type ClientMode.
    /// </summary>
    public class ClientMode : ConstantClass
    {
        /// <summary>
        /// Constant ALL for ClientMode
        /// </summary>
        public static readonly ClientMode ALL = new ClientMode("ALL");

        /// <summary>
        /// Constant DESTINATION for ClientMode
        /// </summary>
        public static readonly ClientMode DESTINATION = new ClientMode("DESTINATION");

        /// <summary>
        /// Constant SOURCE for ClientMode
        /// </summary>
        public static readonly ClientMode SOURCE = new ClientMode("SOURCE");

        /// <summary>
        /// Constructs a custom ClientMode for a value not among the defined constants.
        /// </summary>
        public ClientMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientMode FindValue(string value)
        {
            return FindValue<ClientMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ConnectionStatus.
    /// </summary>
    public class ConnectionStatus : ConstantClass
    {
        /// <summary>
        /// Constant CONNECTED for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus CONNECTED = new ConnectionStatus("CONNECTED");

        /// <summary>
        /// Constant DISCONNECTED for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus DISCONNECTED = new ConnectionStatus("DISCONNECTED");

        /// <summary>
        /// Constructs a custom ConnectionStatus for a value not among the defined constants.
        /// </summary>
        public ConnectionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionStatus FindValue(string value)
        {
            return FindValue<ConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TunnelStatus.
    /// </summary>
    public class TunnelStatus : ConstantClass
    {
        /// <summary>
        /// Constant CLOSED for TunnelStatus
        /// </summary>
        public static readonly TunnelStatus CLOSED = new TunnelStatus("CLOSED");

        /// <summary>
        /// Constant OPEN for TunnelStatus
        /// </summary>
        public static readonly TunnelStatus OPEN = new TunnelStatus("OPEN");

        /// <summary>
        /// Constructs a custom TunnelStatus for a value not among the defined constants.
        /// </summary>
        public TunnelStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TunnelStatus FindValue(string value)
        {
            return FindValue<TunnelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TunnelStatus(string value)
        {
            return FindValue(value);
        }
    }
}
