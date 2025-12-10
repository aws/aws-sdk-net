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
    /// Container for the parameters to the DeleteCapability operation.
    /// Deletes a managed capability from your Amazon EKS cluster. When you delete a capability,
    /// Amazon EKS removes the capability infrastructure but retains all resources that were
    /// managed by the capability.
    /// 
    ///  
    /// <para>
    /// Before deleting a capability, you should delete all Kubernetes resources that were
    /// created by the capability. After the capability is deleted, these resources become
    /// difficult to manage because the controller that managed them is no longer available.
    /// To delete resources before removing the capability, use <c>kubectl delete</c> or remove
    /// them through your GitOps workflow.
    /// </para>
    /// </summary>
    public partial class DeleteCapabilityRequest : AmazonEKSRequest
    {
        private string _capabilityName;
        private string _clusterName;

        /// <summary>
        /// Gets and sets the property CapabilityName. 
        /// <para>
        /// The name of the capability to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CapabilityName
        {
            get { return this._capabilityName; }
            set { this._capabilityName = value; }
        }

        // Check to see if CapabilityName property is set
        internal bool IsSetCapabilityName()
        {
            return this._capabilityName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the Amazon EKS cluster that contains the capability you want to delete.
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

    }
}