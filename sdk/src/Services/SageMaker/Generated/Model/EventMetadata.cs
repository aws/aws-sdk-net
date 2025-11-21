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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Metadata associated with a cluster event, which may include details about various
    /// resource types.
    /// </summary>
    public partial class EventMetadata
    {
        private ClusterMetadata _cluster;
        private InstanceMetadata _instance;
        private InstanceGroupMetadata _instanceGroup;
        private InstanceGroupScalingMetadata _instanceGroupScaling;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// Metadata specific to cluster-level events.
        /// </para>
        /// </summary>
        public ClusterMetadata Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

        /// <summary>
        /// Gets and sets the property Instance. 
        /// <para>
        /// Metadata specific to instance-level events.
        /// </para>
        /// </summary>
        public InstanceMetadata Instance
        {
            get { return this._instance; }
            set { this._instance = value; }
        }

        // Check to see if Instance property is set
        internal bool IsSetInstance()
        {
            return this._instance != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceGroup. 
        /// <para>
        /// Metadata specific to instance group-level events.
        /// </para>
        /// </summary>
        public InstanceGroupMetadata InstanceGroup
        {
            get { return this._instanceGroup; }
            set { this._instanceGroup = value; }
        }

        // Check to see if InstanceGroup property is set
        internal bool IsSetInstanceGroup()
        {
            return this._instanceGroup != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupScaling. 
        /// <para>
        /// Metadata related to instance group scaling events.
        /// </para>
        /// </summary>
        public InstanceGroupScalingMetadata InstanceGroupScaling
        {
            get { return this._instanceGroupScaling; }
            set { this._instanceGroupScaling = value; }
        }

        // Check to see if InstanceGroupScaling property is set
        internal bool IsSetInstanceGroupScaling()
        {
            return this._instanceGroupScaling != null;
        }

    }
}