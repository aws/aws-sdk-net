/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.Runtime;


namespace Amazon.DirectConnect
{


    /// <summary>Connection State
    /// </summary>
    public class ConnectionState : ConstantClass
    {


       /// <summary>Constant Available for ConnectionState
       /// </summary>
        public static readonly ConnectionState Available = new ConnectionState("available");
    

       /// <summary>Constant Deleted for ConnectionState
       /// </summary>
        public static readonly ConnectionState Deleted = new ConnectionState("deleted");
    

       /// <summary>Constant Pending for ConnectionState
       /// </summary>
        public static readonly ConnectionState Pending = new ConnectionState("pending");
    

       /// <summary>Constant Requested for ConnectionState
       /// </summary>
        public static readonly ConnectionState Requested = new ConnectionState("requested");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator ConnectionState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Step State
    /// </summary>
    public class StepState : ConstantClass
    {


       /// <summary>Constant Completed for StepState
       /// </summary>
        public static readonly StepState Completed = new StepState("completed");
    

       /// <summary>Constant Pending for StepState
       /// </summary>
        public static readonly StepState Pending = new StepState("pending");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public StepState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepState FindValue(string value)
        {
            return FindValue<StepState>(value);
        }

        public static implicit operator StepState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Virtual Interface State
    /// </summary>
    public class VirtualInterfaceState : ConstantClass
    {


       /// <summary>Constant Available for VirtualInterfaceState
       /// </summary>
        public static readonly VirtualInterfaceState Available = new VirtualInterfaceState("available");
    

       /// <summary>Constant Deleted for VirtualInterfaceState
       /// </summary>
        public static readonly VirtualInterfaceState Deleted = new VirtualInterfaceState("deleted");
    

       /// <summary>Constant Deleting for VirtualInterfaceState
       /// </summary>
        public static readonly VirtualInterfaceState Deleting = new VirtualInterfaceState("deleting");
    

       /// <summary>Constant Pending for VirtualInterfaceState
       /// </summary>
        public static readonly VirtualInterfaceState Pending = new VirtualInterfaceState("pending");
    

       /// <summary>Constant Verifying for VirtualInterfaceState
       /// </summary>
        public static readonly VirtualInterfaceState Verifying = new VirtualInterfaceState("verifying");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator VirtualInterfaceState(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
