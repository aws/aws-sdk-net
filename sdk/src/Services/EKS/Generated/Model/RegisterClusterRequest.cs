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
    /// Container for the parameters to the RegisterCluster operation.
    /// Connects a Kubernetes cluster to the Amazon EKS control plane. 
    /// 
    ///  
    /// <para>
    /// Any Kubernetes cluster can be connected to the Amazon EKS control plane to view current
    /// information about the cluster and its nodes. 
    /// </para>
    ///  
    /// <para>
    /// Cluster connection requires two steps. First, send a <code> <a>RegisterClusterRequest</a>
    /// </code> to add it to the Amazon EKS control plane.
    /// </para>
    ///  
    /// <para>
    /// Second, a <a href="https://amazon-eks.s3.us-west-2.amazonaws.com/eks-connector/manifests/eks-connector/latest/eks-connector.yaml">Manifest</a>
    /// containing the <code>activationID</code> and <code>activationCode</code> must be applied
    /// to the Kubernetes cluster through it's native provider to provide visibility.
    /// </para>
    ///  
    /// <para>
    /// After the Manifest is updated and applied, then the connected cluster is visible to
    /// the Amazon EKS control plane. If the Manifest is not applied within three days, then
    /// the connected cluster will no longer be visible and must be deregistered. See <a>DeregisterCluster</a>.
    /// </para>
    /// </summary>
    public partial class RegisterClusterRequest : AmazonEKSRequest
    {
        private string _clientRequestToken;
        private ConnectorConfigRequest _connectorConfig;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

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
        /// Gets and sets the property ConnectorConfig. 
        /// <para>
        /// The configuration settings required to connect the Kubernetes cluster to the Amazon
        /// EKS control plane.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorConfigRequest ConnectorConfig
        {
            get { return this._connectorConfig; }
            set { this._connectorConfig = value; }
        }

        // Check to see if ConnectorConfig property is set
        internal bool IsSetConnectorConfig()
        {
            return this._connectorConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Define a unique name for this cluster for your Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the cluster to assist with categorization and organization.
        /// Each tag consists of a key and an optional value, both of which you define. Cluster
        /// tags do not propagate to any other resources associated with the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}