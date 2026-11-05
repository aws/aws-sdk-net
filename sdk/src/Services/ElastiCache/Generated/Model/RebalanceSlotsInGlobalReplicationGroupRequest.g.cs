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
    /// Container for the parameters to the RebalanceSlotsInGlobalReplicationGroup operation.
    /// Redistribute slots to ensure uniform distribution across existing shards in the cluster.
    /// </summary>
    public partial class RebalanceSlotsInGlobalReplicationGroupRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// If <c>True</c>, redistribution is applied immediately.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? ApplyImmediately { get; set; }

        /// <summary>
        /// Checks to see if the ApplyImmediately property is set.
        /// </summary>
        internal bool IsSetApplyImmediately() => this.ApplyImmediately.HasValue;

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupId. 
        /// <para>
        /// The name of the Global datastore
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GlobalReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the GlobalReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetGlobalReplicationGroupId() => this.GlobalReplicationGroupId != null;
    }
}
