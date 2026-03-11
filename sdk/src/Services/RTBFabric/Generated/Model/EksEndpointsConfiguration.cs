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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Describes the configuration of an Amazon Elastic Kubernetes Service endpoint.
    /// </summary>
    public partial class EksEndpointsConfiguration
    {
        private string _clusterApiServerCaCertificateChain;
        private string _clusterApiServerEndpointUri;
        private string _clusterName;
        private string _endpointsResourceName;
        private string _endpointsResourceNamespace;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ClusterApiServerCaCertificateChain. 
        /// <para>
        /// The CA certificate chain of the cluster API server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2097152)]
        public string ClusterApiServerCaCertificateChain
        {
            get { return this._clusterApiServerCaCertificateChain; }
            set { this._clusterApiServerCaCertificateChain = value; }
        }

        // Check to see if ClusterApiServerCaCertificateChain property is set
        internal bool IsSetClusterApiServerCaCertificateChain()
        {
            return this._clusterApiServerCaCertificateChain != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterApiServerEndpointUri. 
        /// <para>
        /// The URI of the cluster API server endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string ClusterApiServerEndpointUri
        {
            get { return this._clusterApiServerEndpointUri; }
            set { this._clusterApiServerEndpointUri = value; }
        }

        // Check to see if ClusterApiServerEndpointUri property is set
        internal bool IsSetClusterApiServerEndpointUri()
        {
            return this._clusterApiServerEndpointUri != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster.
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
        /// Gets and sets the property EndpointsResourceName. 
        /// <para>
        /// The name of the endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EndpointsResourceName
        {
            get { return this._endpointsResourceName; }
            set { this._endpointsResourceName = value; }
        }

        // Check to see if EndpointsResourceName property is set
        internal bool IsSetEndpointsResourceName()
        {
            return this._endpointsResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointsResourceNamespace. 
        /// <para>
        /// The namespace of the endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EndpointsResourceNamespace
        {
            get { return this._endpointsResourceNamespace; }
            set { this._endpointsResourceNamespace = value; }
        }

        // Check to see if EndpointsResourceNamespace property is set
        internal bool IsSetEndpointsResourceNamespace()
        {
            return this._endpointsResourceNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The role ARN for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}