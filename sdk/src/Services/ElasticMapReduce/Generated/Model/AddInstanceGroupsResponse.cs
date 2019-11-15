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
    /// Output from an AddInstanceGroups call.
    /// </summary>
    public partial class AddInstanceGroupsResponse : AmazonWebServiceResponse
    {
        private string _clusterArn;
        private List<string> _instanceGroupIds = new List<string>();
        private string _jobFlowId;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupIds. 
        /// <para>
        /// Instance group IDs of the newly created instance groups.
        /// </para>
        /// </summary>
        public List<string> InstanceGroupIds
        {
            get { return this._instanceGroupIds; }
            set { this._instanceGroupIds = value; }
        }

        // Check to see if InstanceGroupIds property is set
        internal bool IsSetInstanceGroupIds()
        {
            return this._instanceGroupIds != null && this._instanceGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JobFlowId. 
        /// <para>
        /// The job flow ID in which the instance groups are added.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string JobFlowId
        {
            get { return this._jobFlowId; }
            set { this._jobFlowId = value; }
        }

        // Check to see if JobFlowId property is set
        internal bool IsSetJobFlowId()
        {
            return this._jobFlowId != null;
        }

    }
}