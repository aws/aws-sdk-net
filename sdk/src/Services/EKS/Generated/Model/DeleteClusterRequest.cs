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
    /// Container for the parameters to the DeleteCluster operation.
    /// Deletes an Amazon EKS cluster control plane.
    /// 
    ///  
    /// <para>
    /// If you have active services in your cluster that are associated with a load balancer,
    /// you must delete those services before deleting the cluster so that the load balancers
    /// are deleted properly. Otherwise, you can have orphaned resources in your VPC that
    /// prevent you from being able to delete the VPC. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/delete-cluster.html">Deleting
    /// a cluster</a> in the <i>Amazon EKS User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you have managed node groups or Fargate profiles attached to the cluster, you must
    /// delete them first. For more information, see <c>DeleteNodgroup</c> and <c>DeleteFargateProfile</c>.
    /// </para>
    /// </summary>
    public partial class DeleteClusterRequest : AmazonEKSRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster to delete.
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