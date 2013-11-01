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
    /// <para>A connection represents the physical network connection between the Direct Connect location and the customer.</para>
    /// </summary>
    public partial class DeleteConnectionResult : AmazonWebServiceResponse
    {
        
        private string ownerAccount;
        private string connectionId;
        private string connectionName;
        private ConnectionState connectionState;
        private string region;
        private string location;
        private string bandwidth;
        private int? vlan;
        private string partnerName;

        public string OwnerAccount
        {
            get { return this.ownerAccount; }
            set { this.ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this.ownerAccount != null;
        }

        /// <summary>
        /// ID of the connection. Example: dxcon-fg5678gh Default: None
        ///  
        /// </summary>
        public string ConnectionId
        {
            get { return this.connectionId; }
            set { this.connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this.connectionId != null;
        }

        /// <summary>
        /// The name of the connection. Example: "<i>1G Connection to AWS</i>" Default: None
        ///  
        /// </summary>
        public string ConnectionName
        {
            get { return this.connectionName; }
            set { this.connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this.connectionName != null;
        }

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

        /// <summary>
        /// The AWS region where the connection is located. Example: us-east-1 Default: None
        ///  
        /// </summary>
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this.region != null;
        }

        /// <summary>
        /// Where the connection is located. Example: EqSV5 Default: None
        ///  
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this.location != null;
        }

        /// <summary>
        /// Bandwidth of the connection. Example: 1Gbps Default: None
        ///  
        /// </summary>
        public string Bandwidth
        {
            get { return this.bandwidth; }
            set { this.bandwidth = value; }
        }

        // Check to see if Bandwidth property is set
        internal bool IsSetBandwidth()
        {
            return this.bandwidth != null;
        }

        /// <summary>
        /// VLAN ID Example: 101
        ///  
        /// </summary>
        public int Vlan
        {
            get { return this.vlan ?? default(int); }
            set { this.vlan = value; }
        }

        // Check to see if Vlan property is set
        internal bool IsSetVlan()
        {
            return this.vlan.HasValue;
        }
        public string PartnerName
        {
            get { return this.partnerName; }
            set { this.partnerName = value; }
        }

        // Check to see if PartnerName property is set
        internal bool IsSetPartnerName()
        {
            return this.partnerName != null;
        }
    }
}
