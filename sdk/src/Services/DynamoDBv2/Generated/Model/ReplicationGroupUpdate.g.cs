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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents one of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// A new replica to be added to an existing regional table or global table. This request
    /// invokes the <c>CreateTableReplica</c> action in the destination Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// New parameters for an existing replica. This request invokes the <c>UpdateTable</c>
    /// action in the destination Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An existing replica to be deleted. The request invokes the <c>DeleteTableReplica</c>
    /// action in the destination Region, deleting the replica and all if its items in the
    /// destination Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The local replica to be disassociated from a global table and retained as a standalone
    /// regional table.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Each <c>ReplicationGroupUpdate</c> contains exactly one action. A <c>Disassociate</c>
    /// action must be the only replica update in the request; including other updates causes
    /// the request to fail.
    /// </para>
    ///  <note> 
    /// <para>
    /// When you manually remove a table or global table replica, you do not automatically
    /// remove any associated scalable targets, scaling policies, or CloudWatch alarms.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ReplicationGroupUpdate
    {
        /// <summary>
        /// Gets and sets the property Create. 
        /// <para>
        /// The parameters required for creating a replica for the table.
        /// </para>
        /// </summary>
        public CreateReplicationGroupMemberAction Create { get; set; }

        /// <summary>
        /// Checks to see if the Create property is set.
        /// </summary>
        internal bool IsSetCreate() => this.Create != null;

        /// <summary>
        /// Gets and sets the property Delete. 
        /// <para>
        /// The parameters required for deleting a replica for the table.
        /// </para>
        /// </summary>
        public DeleteReplicationGroupMemberAction Delete { get; set; }

        /// <summary>
        /// Checks to see if the Delete property is set.
        /// </summary>
        internal bool IsSetDelete() => this.Delete != null;

        /// <summary>
        /// Gets and sets the property Disassociate. 
        /// <para>
        /// The parameters for disassociating the local replica from the global table and retaining
        /// it as a standalone regional table.
        /// </para>
        /// </summary>
        public DisassociateReplicationGroupMemberAction Disassociate { get; set; }

        /// <summary>
        /// Checks to see if the Disassociate property is set.
        /// </summary>
        internal bool IsSetDisassociate() => this.Disassociate != null;

        /// <summary>
        /// Gets and sets the property Update. 
        /// <para>
        /// The parameters required for updating a replica for the table.
        /// </para>
        /// </summary>
        public UpdateReplicationGroupMemberAction Update { get; set; }

        /// <summary>
        /// Checks to see if the Update property is set.
        /// </summary>
        internal bool IsSetUpdate() => this.Update != null;
    }
}
