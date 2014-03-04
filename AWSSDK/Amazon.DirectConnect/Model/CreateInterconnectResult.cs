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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// <para>An interconnect is a connection that can host other connections.</para> <para>Like a standard Direct Connect connection, an
    /// interconnect represents the physical connection between a Direct Connect partner's network and a specific Direct Connect location. A Direct
    /// Connect partner who owns an interconnect can provision hosted connections on the interconnect for their end customers, thereby providing the
    /// end customers with connectivity to AWS services.</para> <para>The resources of the interconnect, including bandwidth and VLAN numbers, are
    /// shared by all of the hosted connections on the interconnect, and the owner of the interconnect determines how these resources are
    /// assigned.</para>
    /// </summary>
    public class CreateInterconnectResult
    {
        
        private string interconnectId;
        private string interconnectName;
        private string interconnectState;
        private string region;
        private string location;
        private string bandwidth;

        /// <summary>
        /// The ID of the interconnect. Example: dxcon-abc123
        ///  
        /// </summary>
        public string InterconnectId
        {
            get { return this.interconnectId; }
            set { this.interconnectId = value; }
        }

        /// <summary>
        /// Sets the InterconnectId property
        /// </summary>
        /// <param name="interconnectId">The value to set for the InterconnectId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInterconnectResult WithInterconnectId(string interconnectId)
        {
            this.interconnectId = interconnectId;
            return this;
        }
            

        // Check to see if InterconnectId property is set
        internal bool IsSetInterconnectId()
        {
            return this.interconnectId != null;
        }

        /// <summary>
        /// The name of the interconnect. Example: "<i>1G Interconnect to AWS</i>"
        ///  
        /// </summary>
        public string InterconnectName
        {
            get { return this.interconnectName; }
            set { this.interconnectName = value; }
        }

        /// <summary>
        /// Sets the InterconnectName property
        /// </summary>
        /// <param name="interconnectName">The value to set for the InterconnectName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInterconnectResult WithInterconnectName(string interconnectName)
        {
            this.interconnectName = interconnectName;
            return this;
        }
            

        // Check to see if InterconnectName property is set
        internal bool IsSetInterconnectName()
        {
            return this.interconnectName != null;
        }

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
        public string InterconnectState
        {
            get { return this.interconnectState; }
            set { this.interconnectState = value; }
        }

        /// <summary>
        /// Sets the InterconnectState property
        /// </summary>
        /// <param name="interconnectState">The value to set for the InterconnectState property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInterconnectResult WithInterconnectState(string interconnectState)
        {
            this.interconnectState = interconnectState;
            return this;
        }
            

        // Check to see if InterconnectState property is set
        internal bool IsSetInterconnectState()
        {
            return this.interconnectState != null;
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

        /// <summary>
        /// Sets the Region property
        /// </summary>
        /// <param name="region">The value to set for the Region property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInterconnectResult WithRegion(string region)
        {
            this.region = region;
            return this;
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

        /// <summary>
        /// Sets the Location property
        /// </summary>
        /// <param name="location">The value to set for the Location property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInterconnectResult WithLocation(string location)
        {
            this.location = location;
            return this;
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

        /// <summary>
        /// Sets the Bandwidth property
        /// </summary>
        /// <param name="bandwidth">The value to set for the Bandwidth property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInterconnectResult WithBandwidth(string bandwidth)
        {
            this.bandwidth = bandwidth;
            return this;
        }
            

        // Check to see if Bandwidth property is set
        internal bool IsSetBandwidth()
        {
            return this.bandwidth != null;
        }
    }
}
