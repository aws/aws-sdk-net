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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the CompleteMigration operation. Completes the migration
    /// of data.
    /// </summary>
    public partial class CompleteMigrationRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// Forces the migration to stop without ensuring that data is in sync. It is recommended
        /// to use this option only to abort the migration and not recommended when application
        /// wants to continue migration to ElastiCache.
        /// </para>
        /// </summary>
        public bool? Force { get; set; }

        /// <summary>
        /// Checks to see if the Force property is set.
        /// </summary>
        internal bool IsSetForce() => this.Force.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The ID of the replication group to which data is being migrated.
        /// </para>
        /// </summary>
        public string ReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetReplicationGroupId() => this.ReplicationGroupId != null;

        /// <summary>
        /// Gets and sets the property ServerlessCacheName. 
        /// <para>
        /// The name of the serverless cache to which data is being migrated.
        /// </para>
        /// </summary>
        public string ServerlessCacheName { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessCacheName property is set.
        /// </summary>
        internal bool IsSetServerlessCacheName() => this.ServerlessCacheName != null;
    }
}
