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
    /// Container for the parameters to the TestMigration operation. Async API to test connection
    /// between source and target replication group.
    /// </summary>
    public partial class TestMigrationRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property CustomerNodeEndpointList. 
        /// <para>
        ///  List of endpoints from which data should be migrated. List should have only one element.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<CustomerNodeEndpoint> CustomerNodeEndpointList { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomerNodeEndpoint>() : null;

        /// <summary>
        /// Checks to see if the CustomerNodeEndpointList property is set.
        /// </summary>
        internal bool IsSetCustomerNodeEndpointList() => this.CustomerNodeEndpointList != null && (this.CustomerNodeEndpointList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        ///  The ID of the replication group to which data is to be migrated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetReplicationGroupId() => this.ReplicationGroupId != null;
    }
}
