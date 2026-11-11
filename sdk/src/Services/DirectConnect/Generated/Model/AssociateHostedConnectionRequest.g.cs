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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateHostedConnection operation. Associates
    /// a hosted connection and its virtual interfaces with a link aggregation group (LAG)
    /// or interconnect. If the target interconnect or LAG has an existing hosted connection
    /// with a conflicting VLAN number or IP address, the operation fails. This action temporarily
    /// interrupts the hosted connection's connectivity to Amazon Web Services as it is being
    /// migrated. <note> <para> Intended for use by Direct Connect Partners only. </para>
    /// </note>
    /// </summary>
    public partial class AssociateHostedConnectionRequest : AmazonDirectConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the hosted connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionId property is set.
        /// </summary>
        internal bool IsSetConnectionId() => this.ConnectionId != null;

        /// <summary>
        /// Gets and sets the property ParentConnectionId. 
        /// <para>
        /// The ID of the interconnect or the LAG.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ParentConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ParentConnectionId property is set.
        /// </summary>
        internal bool IsSetParentConnectionId() => this.ParentConnectionId != null;
    }
}
