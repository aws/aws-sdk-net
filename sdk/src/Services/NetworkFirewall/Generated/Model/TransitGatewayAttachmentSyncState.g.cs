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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Contains information about the synchronization state of a transit gateway attachment,
    /// including its current status and any error messages. Network Firewall uses this to
    /// track the state of your transit gateway configuration changes.
    /// </summary>
    public partial class TransitGatewayAttachmentSyncState
    {
        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The unique identifier of the transit gateway attachment.
        /// </para>
        /// </summary>
        public string AttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentId property is set.
        /// </summary>
        internal bool IsSetAttachmentId() => this.AttachmentId != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message providing additional information about the current status, particularly
        /// useful when the transit gateway attachment is in a non-<c>READY</c> state.
        /// </para>
        ///  
        /// <para>
        /// Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The attachment is being created
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The attachment is being deleted
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> - The attachment has been deleted
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The attachment creation has failed and cannot be recovered
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c> - The attachment is in an error state that might be recoverable
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c> - The attachment is active and processing traffic
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_ACCEPTANCE</c> - The attachment is waiting to be accepted
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECTING</c> - The attachment is in the process of being rejected
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECTED</c> - The attachment has been rejected
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about troubleshooting endpoint failures, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/firewall-troubleshooting-endpoint-failures.html">Troubleshooting
        /// firewall endpoint failures</a> in the <i>Network Firewall Developer Guide</i>.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentStatus. 
        /// <para>
        /// The current status of the transit gateway attachment.
        /// </para>
        ///  
        /// <para>
        /// Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The attachment is being created
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The attachment is being deleted
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> - The attachment has been deleted
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The attachment creation has failed and cannot be recovered
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c> - The attachment is in an error state that might be recoverable
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c> - The attachment is active and processing traffic
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_ACCEPTANCE</c> - The attachment is waiting to be accepted
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECTING</c> - The attachment is in the process of being rejected
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECTED</c> - The attachment has been rejected
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TransitGatewayAttachmentStatus TransitGatewayAttachmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayAttachmentStatus property is set.
        /// </summary>
        internal bool IsSetTransitGatewayAttachmentStatus() => this.TransitGatewayAttachmentStatus != null;
    }
}
