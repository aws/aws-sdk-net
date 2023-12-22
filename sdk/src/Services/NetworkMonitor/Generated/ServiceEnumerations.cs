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
 * Do not modify this file. This file is generated from the networkmonitor-2023-08-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.NetworkMonitor
{

    /// <summary>
    /// Constants used for properties of type AddressFamily.
    /// </summary>
    public class AddressFamily : ConstantClass
    {

        /// <summary>
        /// Constant IPV4 for AddressFamily
        /// </summary>
        public static readonly AddressFamily IPV4 = new AddressFamily("IPV4");
        /// <summary>
        /// Constant IPV6 for AddressFamily
        /// </summary>
        public static readonly AddressFamily IPV6 = new AddressFamily("IPV6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AddressFamily(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AddressFamily FindValue(string value)
        {
            return FindValue<AddressFamily>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AddressFamily(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitorState.
    /// </summary>
    public class MonitorState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for MonitorState
        /// </summary>
        public static readonly MonitorState ACTIVE = new MonitorState("ACTIVE");
        /// <summary>
        /// Constant DELETING for MonitorState
        /// </summary>
        public static readonly MonitorState DELETING = new MonitorState("DELETING");
        /// <summary>
        /// Constant ERROR for MonitorState
        /// </summary>
        public static readonly MonitorState ERROR = new MonitorState("ERROR");
        /// <summary>
        /// Constant INACTIVE for MonitorState
        /// </summary>
        public static readonly MonitorState INACTIVE = new MonitorState("INACTIVE");
        /// <summary>
        /// Constant PENDING for MonitorState
        /// </summary>
        public static readonly MonitorState PENDING = new MonitorState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitorState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitorState FindValue(string value)
        {
            return FindValue<MonitorState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitorState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProbeState.
    /// </summary>
    public class ProbeState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ProbeState
        /// </summary>
        public static readonly ProbeState ACTIVE = new ProbeState("ACTIVE");
        /// <summary>
        /// Constant DELETED for ProbeState
        /// </summary>
        public static readonly ProbeState DELETED = new ProbeState("DELETED");
        /// <summary>
        /// Constant DELETING for ProbeState
        /// </summary>
        public static readonly ProbeState DELETING = new ProbeState("DELETING");
        /// <summary>
        /// Constant ERROR for ProbeState
        /// </summary>
        public static readonly ProbeState ERROR = new ProbeState("ERROR");
        /// <summary>
        /// Constant INACTIVE for ProbeState
        /// </summary>
        public static readonly ProbeState INACTIVE = new ProbeState("INACTIVE");
        /// <summary>
        /// Constant PENDING for ProbeState
        /// </summary>
        public static readonly ProbeState PENDING = new ProbeState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProbeState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProbeState FindValue(string value)
        {
            return FindValue<ProbeState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProbeState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Protocol.
    /// </summary>
    public class Protocol : ConstantClass
    {

        /// <summary>
        /// Constant ICMP for Protocol
        /// </summary>
        public static readonly Protocol ICMP = new Protocol("ICMP");
        /// <summary>
        /// Constant TCP for Protocol
        /// </summary>
        public static readonly Protocol TCP = new Protocol("TCP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Protocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Protocol FindValue(string value)
        {
            return FindValue<Protocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Protocol(string value)
        {
            return FindValue(value);
        }
    }

}