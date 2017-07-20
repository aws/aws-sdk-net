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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ListInstances operation.
    /// Provides information for all active EC2 instances and EC2 instances terminated in
    /// the last 30 days, up to a maximum of 2,000. EC2 instances in any of the following
    /// states are considered active: AWAITING_FULFILLMENT, PROVISIONING, BOOTSTRAPPING, RUNNING.
    /// </summary>
    public partial class ListInstancesRequest : AmazonElasticMapReduceRequest
    {
        private string _clusterId;
        private string _instanceFleetId;
        private InstanceFleetType _instanceFleetType;
        private string _instanceGroupId;
        private List<string> _instanceGroupTypes = new List<string>();
        private List<string> _instanceStates = new List<string>();
        private string _marker;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier of the cluster for which to list the instances.
        /// </para>
        /// </summary>
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceFleetId. 
        /// <para>
        /// The unique identifier of the instance fleet.
        /// </para>
        /// </summary>
        public string InstanceFleetId
        {
            get { return this._instanceFleetId; }
            set { this._instanceFleetId = value; }
        }

        // Check to see if InstanceFleetId property is set
        internal bool IsSetInstanceFleetId()
        {
            return this._instanceFleetId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceFleetType. 
        /// <para>
        /// The node type of the instance fleet. For example MASTER, CORE, or TASK.
        /// </para>
        /// </summary>
        public InstanceFleetType InstanceFleetType
        {
            get { return this._instanceFleetType; }
            set { this._instanceFleetType = value; }
        }

        // Check to see if InstanceFleetType property is set
        internal bool IsSetInstanceFleetType()
        {
            return this._instanceFleetType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupId. 
        /// <para>
        /// The identifier of the instance group for which to list the instances.
        /// </para>
        /// </summary>
        public string InstanceGroupId
        {
            get { return this._instanceGroupId; }
            set { this._instanceGroupId = value; }
        }

        // Check to see if InstanceGroupId property is set
        internal bool IsSetInstanceGroupId()
        {
            return this._instanceGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupTypes. 
        /// <para>
        /// The type of instance group for which to list the instances.
        /// </para>
        /// </summary>
        public List<string> InstanceGroupTypes
        {
            get { return this._instanceGroupTypes; }
            set { this._instanceGroupTypes = value; }
        }

        // Check to see if InstanceGroupTypes property is set
        internal bool IsSetInstanceGroupTypes()
        {
            return this._instanceGroupTypes != null && this._instanceGroupTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceStates. 
        /// <para>
        /// A list of instance states that will filter the instances returned with this request.
        /// </para>
        /// </summary>
        public List<string> InstanceStates
        {
            get { return this._instanceStates; }
            set { this._instanceStates = value; }
        }

        // Check to see if InstanceStates property is set
        internal bool IsSetInstanceStates()
        {
            return this._instanceStates != null && this._instanceStates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token that indicates the next set of results to retrieve.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}