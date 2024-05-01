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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
    ///  </li> </ul> <note> 
    /// <para>
    /// When you manually remove a table or global table replica, you do not automatically
    /// remove any associated scalable targets, scaling policies, or CloudWatch alarms.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ReplicationGroupUpdate
    {
        private CreateReplicationGroupMemberAction _create;
        private DeleteReplicationGroupMemberAction _delete;
        private UpdateReplicationGroupMemberAction _update;

        /// <summary>
        /// Gets and sets the property Create. 
        /// <para>
        /// The parameters required for creating a replica for the table.
        /// </para>
        /// </summary>
        public CreateReplicationGroupMemberAction Create
        {
            get { return this._create; }
            set { this._create = value; }
        }

        // Check to see if Create property is set
        internal bool IsSetCreate()
        {
            return this._create != null;
        }

        /// <summary>
        /// Gets and sets the property Delete. 
        /// <para>
        /// The parameters required for deleting a replica for the table.
        /// </para>
        /// </summary>
        public DeleteReplicationGroupMemberAction Delete
        {
            get { return this._delete; }
            set { this._delete = value; }
        }

        // Check to see if Delete property is set
        internal bool IsSetDelete()
        {
            return this._delete != null;
        }

        /// <summary>
        /// Gets and sets the property Update. 
        /// <para>
        /// The parameters required for updating a replica for the table.
        /// </para>
        /// </summary>
        public UpdateReplicationGroupMemberAction Update
        {
            get { return this._update; }
            set { this._update = value; }
        }

        // Check to see if Update property is set
        internal bool IsSetUpdate()
        {
            return this._update != null;
        }

    }
}