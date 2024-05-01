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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The name of the Global datastore and role of this replication group in the Global
    /// datastore.
    /// </summary>
    public partial class GlobalReplicationGroupInfo
    {
        private string _globalReplicationGroupId;
        private string _globalReplicationGroupMemberRole;

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupId. 
        /// <para>
        /// The name of the Global datastore
        /// </para>
        /// </summary>
        public string GlobalReplicationGroupId
        {
            get { return this._globalReplicationGroupId; }
            set { this._globalReplicationGroupId = value; }
        }

        // Check to see if GlobalReplicationGroupId property is set
        internal bool IsSetGlobalReplicationGroupId()
        {
            return this._globalReplicationGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupMemberRole. 
        /// <para>
        /// The role of the replication group in a Global datastore. Can be primary or secondary.
        /// </para>
        /// </summary>
        public string GlobalReplicationGroupMemberRole
        {
            get { return this._globalReplicationGroupMemberRole; }
            set { this._globalReplicationGroupMemberRole = value; }
        }

        // Check to see if GlobalReplicationGroupMemberRole property is set
        internal bool IsSetGlobalReplicationGroupMemberRole()
        {
            return this._globalReplicationGroupMemberRole != null;
        }

    }
}