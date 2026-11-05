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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// A domain that another domain replicates with, and the state of that relationship.
    /// </summary>
    public partial class ReplicationPeer
    {
        /// <summary>
        /// Gets and sets the property PeerDomainArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the peer domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string PeerDomainArn { get; set; }

        /// <summary>
        /// Checks to see if the PeerDomainArn property is set.
        /// </summary>
        internal bool IsSetPeerDomainArn() => this.PeerDomainArn != null;

        /// <summary>
        /// Gets and sets the property PeerRole. 
        /// <para>
        /// The peer's role in the relationship, either <c>PRIMARY</c> or <c>SECONDARY</c>.
        /// </para>
        /// </summary>
        public ReplicationRole PeerRole { get; set; }

        /// <summary>
        /// Checks to see if the PeerRole property is set.
        /// </summary>
        internal bool IsSetPeerRole() => this.PeerRole != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the relationship:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING_SETUP</c> - replication is being established.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - replication is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SWITCHING_OVER</c> - a planned promotion is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILING_OVER</c> - an unplanned promotion is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_REMOVAL</c> - replication is being stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DETACHED</c> - the relationship has ended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EJECTED</c> - a failover promoted the other domain. The former primary keeps the
        /// data it had when it was ejected and stays read-only until you remove the peer, or
        /// discard that data and pair again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - setup or teardown could not complete. You can still remove the relationship.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A relationship that is removed successfully no longer appears in <c>Peers</c>.
        /// </para>
        /// </summary>
        public ReplicationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// An explanation of why the relationship is in its current state, when more detail is
        /// available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
