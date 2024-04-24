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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCluster operation.
    /// Describes an Amazon EKS cluster.
    /// 
    ///  
    /// <para>
    /// The API server endpoint and certificate authority data returned by this operation
    /// are required for <c>kubelet</c> and <c>kubectl</c> to communicate with your Kubernetes
    /// API server. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/create-kubeconfig.html">Creating
    /// or updating a <c>kubeconfig</c> file for an Amazon EKS cluster</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The API server endpoint and certificate authority data aren't available until the
    /// cluster reaches the <c>ACTIVE</c> state.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeClusterRequest : AmazonEKSRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}