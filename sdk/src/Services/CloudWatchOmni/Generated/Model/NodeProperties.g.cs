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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Node identity attributes promoted out of the flat attribute map onto typed members.
    /// The first four are part of the node's merge key, so a node that merged across sources
    /// reports one resolved value for each.
    /// </summary>
    public partial class NodeProperties
    {
        /// <summary>
        /// Gets and sets the property Category. What kind of thing the node is, coarser than
        /// nodeType.
        /// </summary>
        public NodeCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property CloudProvider. The cloud provider hosting the node, resolved
        /// from the reported provider, platform, or vendor namespace, and defaulting to "aws".
        /// </summary>
        public string CloudProvider { get; set; }

        /// <summary>
        /// Checks to see if the CloudProvider property is set.
        /// </summary>
        internal bool IsSetCloudProvider() => this.CloudProvider != null;

        /// <summary>
        /// Gets and sets the property Namespace. The logical service grouping the node belongs
        /// to. This is not a metric namespace.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property Region. The region the node runs in. Falls back to the
        /// region the telemetry was ingested from when the node does not report one.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property SourceAccountId. The account that produced the telemetry
        /// this node was discovered from.
        /// </summary>
        public string SourceAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SourceAccountId property is set.
        /// </summary>
        internal bool IsSetSourceAccountId() => this.SourceAccountId != null;

        /// <summary>
        /// Gets and sets the property Stage. The node's deployment environment. A node may be
        /// observed in several; this is the highest-precedence one. Match any of them with NodeFilters.stage.
        /// </summary>
        public string Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;
    }
}
