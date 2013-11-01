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
    /// <para>The response received when DeleteInterconnect is called.</para>
    /// </summary>
    public partial class DeleteInterconnectResult : AmazonWebServiceResponse
    {
        
        private InterconnectState interconnectState;


        /// <summary>
        /// State of the interconnect. <ul> <li><b>Requested</b>: The initial state of an interconnect. The interconnect stays in the requested state
        /// until the Letter of Authorization (LOA) is sent to the customer.</li> <li><b>Pending</b>: The interconnect has been approved, and is being
        /// initialized.</li> <li><b>Available</b>: The network link is up, and the interconnect is ready for use.</li> <li><b>Down</b>: The network
        /// link is down.</li> <li><b>Deleted</b>: The interconnect has been deleted.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>requested, pending, available, down, deleting, deleted</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public InterconnectState InterconnectState
        {
            get { return this.interconnectState; }
            set { this.interconnectState = value; }
        }

        // Check to see if InterconnectState property is set
        internal bool IsSetInterconnectState()
        {
            return this.interconnectState != null;
        }
    }
}
