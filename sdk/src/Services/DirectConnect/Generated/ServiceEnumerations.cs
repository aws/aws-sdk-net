/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DirectConnect
{

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
        /// Constant Ordering for ConnectionState
        /// </summary>
        public static readonly ConnectionState Ordering = new ConnectionState("ordering");
        /// <summary>
        /// Constant Pending for ConnectionState
        /// </summary>
        public static readonly ConnectionState Pending = new ConnectionState("pending");
        /// <summary>
        /// Constant Rejected for ConnectionState
        /// </summary>
        public static readonly ConnectionState Rejected = new ConnectionState("rejected");
        /// <summary>
        /// Constant Requested for ConnectionState
        /// </summary>
        public static readonly ConnectionState Requested = new ConnectionState("requested");

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
    /// Constants used for properties of type InterconnectState.
    /// </summary>
    public class InterconnectState : ConstantClass
    {

        /// <summary>
        /// Constant Available for InterconnectState
        /// </summary>
        public static readonly InterconnectState Available = new InterconnectState("available");
        /// <summary>
        /// Constant Deleted for InterconnectState
        /// </summary>
        public static readonly InterconnectState Deleted = new InterconnectState("deleted");
        /// <summary>
        /// Constant Deleting for InterconnectState
        /// </summary>
        public static readonly InterconnectState Deleting = new InterconnectState("deleting");
        /// <summary>
        /// Constant Down for InterconnectState
        /// </summary>
        public static readonly InterconnectState Down = new InterconnectState("down");
        /// <summary>
        /// Constant Pending for InterconnectState
        /// </summary>
        public static readonly InterconnectState Pending = new InterconnectState("pending");
        /// <summary>
        /// Constant Requested for InterconnectState
        /// </summary>
        public static readonly InterconnectState Requested = new InterconnectState("requested");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InterconnectState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InterconnectState FindValue(string value)
        {
            return FindValue<InterconnectState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InterconnectState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoaContentType.
    /// </summary>
    public class LoaContentType : ConstantClass
    {

        /// <summary>
        /// Constant ApplicationPdf for LoaContentType
        /// </summary>
        public static readonly LoaContentType ApplicationPdf = new LoaContentType("application/pdf");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoaContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoaContentType FindValue(string value)
        {
            return FindValue<LoaContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoaContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VirtualInterfaceState.
    /// </summary>
    public class VirtualInterfaceState : ConstantClass
    {

        /// <summary>
        /// Constant Available for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Available = new VirtualInterfaceState("available");
        /// <summary>
        /// Constant Confirming for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Confirming = new VirtualInterfaceState("confirming");
        /// <summary>
        /// Constant Deleted for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Deleted = new VirtualInterfaceState("deleted");
        /// <summary>
        /// Constant Deleting for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Deleting = new VirtualInterfaceState("deleting");
        /// <summary>
        /// Constant Down for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Down = new VirtualInterfaceState("down");
        /// <summary>
        /// Constant Pending for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Pending = new VirtualInterfaceState("pending");
        /// <summary>
        /// Constant Rejected for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Rejected = new VirtualInterfaceState("rejected");
        /// <summary>
        /// Constant Verifying for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Verifying = new VirtualInterfaceState("verifying");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VirtualInterfaceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VirtualInterfaceState FindValue(string value)
        {
            return FindValue<VirtualInterfaceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VirtualInterfaceState(string value)
        {
            return FindValue(value);
        }
    }

}