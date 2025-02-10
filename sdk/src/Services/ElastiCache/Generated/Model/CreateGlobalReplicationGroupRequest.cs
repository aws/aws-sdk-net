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
    /// Container for the parameters to the CreateGlobalReplicationGroup operation.
    /// Global Datastore offers fully managed, fast, reliable and secure cross-region replication.
    /// Using Global Datastore with Valkey or Redis OSS, you can create cross-region read
    /// replica clusters for ElastiCache to enable low-latency reads and disaster recovery
    /// across regions. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Redis-Global-Datastore.html">Replication
    /// Across Regions Using Global Datastore</a>. 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The <b>GlobalReplicationGroupIdSuffix</b> is the name of the Global datastore.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <b>PrimaryReplicationGroupId</b> represents the name of the primary cluster that
    /// accepts writes and will replicate updates to the secondary cluster.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateGlobalReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private string _globalReplicationGroupDescription;
        private string _globalReplicationGroupIdSuffix;
        private string _primaryReplicationGroupId;

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupDescription. 
        /// <para>
        /// Provides details of the Global datastore
        /// </para>
        /// </summary>
        public string GlobalReplicationGroupDescription
        {
            get { return this._globalReplicationGroupDescription; }
            set { this._globalReplicationGroupDescription = value; }
        }

        // Check to see if GlobalReplicationGroupDescription property is set
        internal bool IsSetGlobalReplicationGroupDescription()
        {
            return this._globalReplicationGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupIdSuffix. 
        /// <para>
        /// The suffix name of a Global datastore. Amazon ElastiCache automatically applies a
        /// prefix to the Global datastore ID when it is created. Each Amazon Region has its own
        /// prefix. For instance, a Global datastore ID created in the US-West-1 region will begin
        /// with "dsdfu" along with the suffix name you provide. The suffix, combined with the
        /// auto-generated prefix, guarantees uniqueness of the Global datastore name across multiple
        /// regions. 
        /// </para>
        ///  
        /// <para>
        /// For a full list of Amazon Regions and their respective Global datastore iD prefixes,
        /// see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Redis-Global-Datastores-CLI.html">Using
        /// the Amazon CLI with Global datastores </a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GlobalReplicationGroupIdSuffix
        {
            get { return this._globalReplicationGroupIdSuffix; }
            set { this._globalReplicationGroupIdSuffix = value; }
        }

        // Check to see if GlobalReplicationGroupIdSuffix property is set
        internal bool IsSetGlobalReplicationGroupIdSuffix()
        {
            return this._globalReplicationGroupIdSuffix != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryReplicationGroupId. 
        /// <para>
        /// The name of the primary cluster that accepts writes and will replicate updates to
        /// the secondary cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrimaryReplicationGroupId
        {
            get { return this._primaryReplicationGroupId; }
            set { this._primaryReplicationGroupId = value; }
        }

        // Check to see if PrimaryReplicationGroupId property is set
        internal bool IsSetPrimaryReplicationGroupId()
        {
            return this._primaryReplicationGroupId != null;
        }

    }
}