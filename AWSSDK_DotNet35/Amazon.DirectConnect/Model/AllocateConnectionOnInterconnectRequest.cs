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
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the AllocateConnectionOnInterconnect operation.
    /// <para>Creates a hosted connection on an interconnect.</para> <para>Allocates a VLAN number and a specified amount of bandwidth for use by a
    /// hosted connection on the given interconnect.</para>
    /// </summary>
    public partial class AllocateConnectionOnInterconnectRequest : AmazonDirectConnectRequest
    {
        private string bandwidth;
        private string connectionName;
        private string ownerAccount;
        private string interconnectId;
        private int? vlan;


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
        /// Name of the provisioned connection. Example: "<i>500M Connection to AWS</i>" Default: None
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
        /// Numeric account Id of the customer for whom the connection will be provisioned. Example: 123443215678 Default: None
        ///  
        /// </summary>
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
        /// ID of the interconnect on which the connection will be provisioned. Example: dxcon-456abc78 Default: None
        ///  
        /// </summary>
        public string InterconnectId
        {
            get { return this.interconnectId; }
            set { this.interconnectId = value; }
        }

        // Check to see if InterconnectId property is set
        internal bool IsSetInterconnectId()
        {
            return this.interconnectId != null;
        }

        /// <summary>
        /// The dedicated VLAN provisioned to the connection. Example: 101 Default: None
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

    }
}
    
