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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCluster operation.
    /// Returns descriptive information about an Amazon EKS cluster.
    /// 
    ///  
    /// <para>
    /// The API server endpoint and certificate authority data returned by this operation
    /// are required for <code>kubelet</code> and <code>kubectl</code> to communicate with
    /// your Kubernetes API server. For more information, see <a href="http://docs.aws.amazon.com/eks/latest/userguide/create-kubeconfig.html">Create
    /// a kubeconfig for Amazon EKS</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The API server endpoint and certificate authority data are not available until the
    /// cluster reaches the <code>ACTIVE</code> state.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeClusterRequest : AmazonEKSRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster to describe.
        /// </para>
        /// </summary>
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