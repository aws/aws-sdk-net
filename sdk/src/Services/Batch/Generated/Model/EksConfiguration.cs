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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Configuration for the Amazon EKS cluster that supports the Batch compute environment.
    /// The cluster must exist before the compute environment can be created.
    /// </summary>
    public partial class EksConfiguration
    {
        private string _eksClusterArn;
        private string _kubernetesNamespace;

        /// <summary>
        /// Gets and sets the property EksClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon EKS cluster. An example is <c>arn:<i>aws</i>:eks:<i>us-east-1</i>:<i>123456789012</i>:cluster/<i>ClusterForBatch</i>
        /// </c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EksClusterArn
        {
            get { return this._eksClusterArn; }
            set { this._eksClusterArn = value; }
        }

        // Check to see if EksClusterArn property is set
        internal bool IsSetEksClusterArn()
        {
            return this._eksClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property KubernetesNamespace. 
        /// <para>
        /// The namespace of the Amazon EKS cluster. Batch manages pods in this namespace. The
        /// value can't left empty or null. It must be fewer than 64 characters long, can't be
        /// set to <c>default</c>, can't start with "<c>kube-</c>," and must match this regular
        /// expression: <c>^[a-z0-9]([-a-z0-9]*[a-z0-9])?$</c>. For more information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/">Namespaces</a>
        /// in the Kubernetes documentation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KubernetesNamespace
        {
            get { return this._kubernetesNamespace; }
            set { this._kubernetesNamespace = value; }
        }

        // Check to see if KubernetesNamespace property is set
        internal bool IsSetKubernetesNamespace()
        {
            return this._kubernetesNamespace != null;
        }

    }
}