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

namespace Amazon.EKSAuth.Model
{
    /// <summary>
    /// Container for the parameters to the AssumeRoleForPodIdentity operation. The Amazon
    /// EKS Auth API and the <c>AssumeRoleForPodIdentity</c> action are only used by the EKS
    /// Pod Identity Agent. <para> We recommend that applications use the Amazon Web Services
    /// SDKs to connect to Amazon Web Services services; if credentials from an EKS Pod Identity
    /// association are available in the pod, the latest versions of the SDKs use them automatically.
    /// </para>
    /// </summary>
    public partial class AssumeRoleForPodIdentityRequest : AmazonEKSAuthRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property EksNodeName. 
        /// <para>
        /// The Kubernetes node name of the worker node where the pod is running.
        /// </para>
        /// </summary>
        public string EksNodeName { get; set; }

        /// <summary>
        /// Checks to see if the EksNodeName property is set.
        /// </summary>
        internal bool IsSetEksNodeName() => this.EksNodeName != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The Amazon EC2 instance ID of the worker node where the pod is running.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The token of the Kubernetes service account for the pod.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1)]
        public string Token { get; set; }

        /// <summary>
        /// Checks to see if the Token property is set.
        /// </summary>
        internal bool IsSetToken() => this.Token != null;

        /// <summary>
        /// Gets and sets the property Zone. 
        /// <para>
        /// The Availability Zone ID of the worker node where the pod is running.
        /// </para>
        /// </summary>
        public string Zone { get; set; }

        /// <summary>
        /// Checks to see if the Zone property is set.
        /// </summary>
        internal bool IsSetZone() => this.Zone != null;
    }
}
