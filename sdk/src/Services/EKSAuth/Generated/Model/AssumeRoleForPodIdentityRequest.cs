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
 * Do not modify this file. This file is generated from the eks-auth-2023-11-26.normal.json service model.
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
    /// Container for the parameters to the AssumeRoleForPodIdentity operation.
    /// The Amazon EKS Auth API and the <c>AssumeRoleForPodIdentity</c> action are only used
    /// by the EKS Pod Identity Agent.
    /// 
    ///  
    /// <para>
    /// We recommend that applications use the Amazon Web Services SDKs to connect to Amazon
    /// Web Services services; if credentials from an EKS Pod Identity association are available
    /// in the pod, the latest versions of the SDKs use them automatically.
    /// </para>
    /// </summary>
    public partial class AssumeRoleForPodIdentityRequest : AmazonEKSAuthRequest
    {
        private string _clusterName;
        private string _token;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property Token. 
        /// <para>
        /// The token of the Kubernetes service account for the pod.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

    }
}