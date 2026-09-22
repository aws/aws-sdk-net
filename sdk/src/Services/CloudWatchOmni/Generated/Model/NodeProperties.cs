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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
        private NodeCategory _category;
        private string _cloudProvider;
        private string _awsNamespace;
        private string _region;
        private string _sourceAccountId;
        private string _stage;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// What kind of thing the node is, coarser than nodeType.
        /// </para>
        /// </summary>
        public NodeCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property CloudProvider. 
        /// <para>
        /// The cloud provider hosting the node, resolved from the reported provider, platform,
        /// or vendor namespace, and defaulting to &quot;aws&quot;.
        /// </para>
        /// </summary>
        public string CloudProvider
        {
            get { return this._cloudProvider; }
            set { this._cloudProvider = value; }
        }

        // Check to see if CloudProvider property is set
        internal bool IsSetCloudProvider()
        {
            return this._cloudProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The logical service grouping the node belongs to. This is not a metric namespace.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The region the node runs in. Falls back to the region the telemetry was ingested from
        /// when the node does not report one.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAccountId. 
        /// <para>
        /// The account that produced the telemetry this node was discovered from.
        /// </para>
        /// </summary>
        public string SourceAccountId
        {
            get { return this._sourceAccountId; }
            set { this._sourceAccountId = value; }
        }

        // Check to see if SourceAccountId property is set
        internal bool IsSetSourceAccountId()
        {
            return this._sourceAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The node's deployment environment. A node may be observed in several; this is the
        /// highest-precedence one. Match any of them with NodeFilters.stage.
        /// </para>
        /// </summary>
        public string Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

    }
}