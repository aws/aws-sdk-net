/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Specifies the configuration for the domain cluster, such as the type and number of
    /// instances.
    /// </summary>
    public partial class ElasticsearchClusterConfig
    {
        private int? _dedicatedMasterCount;
        private bool? _dedicatedMasterEnabled;
        private ESPartitionInstanceType _dedicatedMasterType;
        private int? _instanceCount;
        private ESPartitionInstanceType _instanceType;
        private bool? _zoneAwarenessEnabled;

        /// <summary>
        /// Gets and sets the property DedicatedMasterCount. 
        /// <para>
        /// Total number of dedicated master nodes, active and on standby, for the cluster.
        /// </para>
        /// </summary>
        public int DedicatedMasterCount
        {
            get { return this._dedicatedMasterCount.GetValueOrDefault(); }
            set { this._dedicatedMasterCount = value; }
        }

        // Check to see if DedicatedMasterCount property is set
        internal bool IsSetDedicatedMasterCount()
        {
            return this._dedicatedMasterCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DedicatedMasterEnabled. 
        /// <para>
        /// A boolean value to indicate whether a dedicated master node is enabled. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-managedomains.html#es-managedomains-dedicatedmasternodes"
        /// target="_blank">About Dedicated Master Nodes</a> for more information.
        /// </para>
        /// </summary>
        public bool DedicatedMasterEnabled
        {
            get { return this._dedicatedMasterEnabled.GetValueOrDefault(); }
            set { this._dedicatedMasterEnabled = value; }
        }

        // Check to see if DedicatedMasterEnabled property is set
        internal bool IsSetDedicatedMasterEnabled()
        {
            return this._dedicatedMasterEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DedicatedMasterType. 
        /// <para>
        /// The instance type for a dedicated master node.
        /// </para>
        /// </summary>
        public ESPartitionInstanceType DedicatedMasterType
        {
            get { return this._dedicatedMasterType; }
            set { this._dedicatedMasterType = value; }
        }

        // Check to see if DedicatedMasterType property is set
        internal bool IsSetDedicatedMasterType()
        {
            return this._dedicatedMasterType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances in the specified domain cluster.
        /// </para>
        /// </summary>
        public int InstanceCount
        {
            get { return this._instanceCount.GetValueOrDefault(); }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type for an Elasticsearch cluster.
        /// </para>
        /// </summary>
        public ESPartitionInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property ZoneAwarenessEnabled. 
        /// <para>
        /// A boolean value to indicate whether zone awareness is enabled. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-managedomains.html#es-managedomains-zoneawareness"
        /// target="_blank">About Zone Awareness</a> for more information.
        /// </para>
        /// </summary>
        public bool ZoneAwarenessEnabled
        {
            get { return this._zoneAwarenessEnabled.GetValueOrDefault(); }
            set { this._zoneAwarenessEnabled = value; }
        }

        // Check to see if ZoneAwarenessEnabled property is set
        internal bool IsSetZoneAwarenessEnabled()
        {
            return this._zoneAwarenessEnabled.HasValue; 
        }

    }
}