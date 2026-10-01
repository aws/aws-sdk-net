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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Configuration for the Amazon EKS cluster that supports the Batch compute environment.
    /// The cluster must exist before the compute environment can be created.
    /// </summary>
    public partial class EksConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccessEntry. 
        /// <para>
        /// The Batch-managed Amazon EKS access entry for the compute environment. Set <c>desiredState</c>
        /// to declare whether Batch manages an access entry on the cluster. In a <c>DescribeComputeEnvironments</c>
        /// response, <c>desiredState</c> is the value that Batch recorded for the compute environment
        /// and <c>status</c> is the observed state of the access entry on the cluster. To change
        /// the access entry on an existing compute environment, use <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_EksConfigurationUpdate.html#Batch-Type-EksConfigurationUpdate-accessEntry">
        /// <c>EksConfigurationUpdate.accessEntry</c> </a>.
        /// </para>
        ///  
        /// <para>
        /// Whether the entry is provisioned on the cluster depends on the cluster's <c>authenticationMode</c>
        /// and the <c>desiredState</c> recorded for each Batch compute environment targeting
        /// the cluster. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/eks-access-entries.html">Amazon
        /// EKS access entry authentication</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this field, Batch doesn't record a <c>desiredState</c> for the
        /// compute environment and <c>DescribeComputeEnvironments</c> doesn't return one. For
        /// the purpose of provisioning the access entry, Batch behaves as it does for <c>INHERIT_FROM_CLUSTER</c>.
        /// </para>
        /// </summary>
        public EksAccessEntry AccessEntry { get; set; }

        /// <summary>
        /// Checks to see if the AccessEntry property is set.
        /// </summary>
        internal bool IsSetAccessEntry() => this.AccessEntry != null;

        /// <summary>
        /// Gets and sets the property EksClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon EKS cluster. An example is <c>arn:<i>aws</i>:eks:<i>us-east-1</i>:<i>123456789012</i>:cluster/<i>ClusterForBatch</i>
        /// </c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EksClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the EksClusterArn property is set.
        /// </summary>
        internal bool IsSetEksClusterArn() => this.EksClusterArn != null;

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
        [AWSProperty(Required = true)]
        public string KubernetesNamespace { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesNamespace property is set.
        /// </summary>
        internal bool IsSetKubernetesNamespace() => this.KubernetesNamespace != null;
    }
}
