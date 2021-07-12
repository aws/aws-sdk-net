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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNodegroupConfig operation.
    /// Updates an Amazon EKS managed node group configuration. Your node group continues
    /// to function during the update. The response output includes an update ID that you
    /// can use to track the status of your node group update with the <a>DescribeUpdate</a>
    /// API operation. Currently you can update the Kubernetes labels for a node group or
    /// the scaling configuration.
    /// </summary>
    public partial class UpdateNodegroupConfigRequest : AmazonEKSRequest
    {
        private string _clientRequestToken;
        private string _clusterName;
        private UpdateLabelsPayload _labels;
        private string _nodegroupName;
        private NodegroupScalingConfig _scalingConfig;
        private UpdateTaintsPayload _taints;
        private NodegroupUpdateConfig _updateConfig;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the Amazon EKS cluster that the managed node group resides in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// The Kubernetes labels to be applied to the nodes in the node group after the update.
        /// </para>
        /// </summary>
        public UpdateLabelsPayload Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null;
        }

        /// <summary>
        /// Gets and sets the property NodegroupName. 
        /// <para>
        /// The name of the managed node group to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NodegroupName
        {
            get { return this._nodegroupName; }
            set { this._nodegroupName = value; }
        }

        // Check to see if NodegroupName property is set
        internal bool IsSetNodegroupName()
        {
            return this._nodegroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingConfig. 
        /// <para>
        /// The scaling configuration details for the Auto Scaling group after the update.
        /// </para>
        /// </summary>
        public NodegroupScalingConfig ScalingConfig
        {
            get { return this._scalingConfig; }
            set { this._scalingConfig = value; }
        }

        // Check to see if ScalingConfig property is set
        internal bool IsSetScalingConfig()
        {
            return this._scalingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Taints. 
        /// <para>
        /// The Kubernetes taints to be applied to the nodes in the node group after the update.
        /// </para>
        /// </summary>
        public UpdateTaintsPayload Taints
        {
            get { return this._taints; }
            set { this._taints = value; }
        }

        // Check to see if Taints property is set
        internal bool IsSetTaints()
        {
            return this._taints != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateConfig. 
        /// <para>
        /// The node group update configuration.
        /// </para>
        /// </summary>
        public NodegroupUpdateConfig UpdateConfig
        {
            get { return this._updateConfig; }
            set { this._updateConfig = value; }
        }

        // Check to see if UpdateConfig property is set
        internal bool IsSetUpdateConfig()
        {
            return this._updateConfig != null;
        }

    }
}