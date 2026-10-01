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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Describes the configuration of an Amazon Elastic Kubernetes Service endpoint.
    /// </summary>
    public partial class EksEndpointsConfiguration
    {
        /// <summary>
        /// Gets and sets the property ClusterApiServerCaCertificateChain. 
        /// <para>
        /// The CA certificate chain of the cluster API server.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 2097152)]
        public string ClusterApiServerCaCertificateChain { get; set; }

        /// <summary>
        /// Checks to see if the ClusterApiServerCaCertificateChain property is set.
        /// </summary>
        internal bool IsSetClusterApiServerCaCertificateChain() => this.ClusterApiServerCaCertificateChain != null;

        /// <summary>
        /// Gets and sets the property ClusterApiServerEndpointUri. 
        /// <para>
        /// The URI of the cluster API server endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string ClusterApiServerEndpointUri { get; set; }

        /// <summary>
        /// Checks to see if the ClusterApiServerEndpointUri property is set.
        /// </summary>
        internal bool IsSetClusterApiServerEndpointUri() => this.ClusterApiServerEndpointUri != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 63)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property EndpointsResourceName. 
        /// <para>
        /// The name of the endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 63)]
        public string EndpointsResourceName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointsResourceName property is set.
        /// </summary>
        internal bool IsSetEndpointsResourceName() => this.EndpointsResourceName != null;

        /// <summary>
        /// Gets and sets the property EndpointsResourceNamespace. 
        /// <para>
        /// The namespace of the endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 63)]
        public string EndpointsResourceNamespace { get; set; }

        /// <summary>
        /// Checks to see if the EndpointsResourceNamespace property is set.
        /// </summary>
        internal bool IsSetEndpointsResourceNamespace() => this.EndpointsResourceNamespace != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The role ARN for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
