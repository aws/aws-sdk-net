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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// <para>The response received when ConfirmConnection is called.</para>
    /// </summary>
    public partial class ConfirmConnectionResult : AmazonWebServiceResponse
    {
        
        private ConnectionState connectionState;


        /// <summary>
        /// State of the connection. <ul> <li><b>Ordering</b>: The initial state of a hosted connection provisioned on an interconnect. The connection
        /// stays in the ordering state until the owner of the hosted connection confirms or declines the connection order.</li> <li><b>Requested</b>:
        /// The initial state of a standard connection. The connection stays in the requested state until the Letter of Authorization (LOA) is sent to
        /// the customer.</li> <li><b>Pending</b>: The connection has been approved, and is being initialized.</li> <li><b>Available</b>: The network
        /// link is up, and the connection is ready for use.</li> <li><b>Down</b>: The network link is down.</li> <li><b>Deleted</b>: The connection has
        /// been deleted.</li> <li><b>Rejected</b>: A hosted connection in the 'Ordering' state will enter the 'Rejected' state if it is deleted by the
        /// end customer.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ordering, requested, pending, available, down, deleting, deleted, rejected</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ConnectionState ConnectionState
        {
            get { return this.connectionState; }
            set { this.connectionState = value; }
        }

        // Check to see if ConnectionState property is set
        internal bool IsSetConnectionState()
        {
            return this.connectionState != null;
        }
    }
}
