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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// The configuration of your local Amazon EKS cluster on an Amazon Web Services Outpost.
    /// Before creating a cluster on an Outpost, review <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-outposts-local-cluster-create.html">Creating
    /// a local cluster on an Outpost</a> in the <i>Amazon EKS User Guide</i>. This API isn't
    /// available for Amazon EKS clusters on the Amazon Web Services cloud.
    /// </summary>
    public partial class OutpostConfigRequest
    {
        /// <summary>
        /// Gets and sets the property ControlPlaneInstanceType. 
        /// <para>
        /// The Amazon EC2 instance type for the Kubernetes control plane instances of your local
        /// Amazon EKS cluster on Amazon Web Services Outposts. This instance type applies to
        /// all control plane instances and cannot be changed after cluster creation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-outposts-capacity-considerations.html">Capacity
        /// considerations</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ControlPlaneInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the ControlPlaneInstanceType property is set.
        /// </summary>
        internal bool IsSetControlPlaneInstanceType() => this.ControlPlaneInstanceType != null;

        /// <summary>
        /// Gets and sets the property ControlPlanePlacement. 
        /// <para>
        /// An object representing the placement configuration for all the control plane instances
        /// of your local Amazon EKS cluster on an Amazon Web Services Outpost. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-outposts-capacity-considerations.html">Capacity
        /// considerations</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public ControlPlanePlacementRequest ControlPlanePlacement { get; set; }

        /// <summary>
        /// Checks to see if the ControlPlanePlacement property is set.
        /// </summary>
        internal bool IsSetControlPlanePlacement() => this.ControlPlanePlacement != null;

        /// <summary>
        /// Gets and sets the property EtcdInstanceType. 
        /// <para>
        /// The Amazon EC2 instance type for etcd instances of your local Amazon EKS cluster on
        /// Amazon Web Services Outposts. This instance type applies to all etcd instances and
        /// cannot be changed after cluster creation.
        /// </para>
        /// </summary>
        public string EtcdInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the EtcdInstanceType property is set.
        /// </summary>
        internal bool IsSetEtcdInstanceType() => this.EtcdInstanceType != null;

        /// <summary>
        /// Gets and sets the property EtcdPlacement. 
        /// <para>
        /// An object representing the placement configuration for the etcd instances of your
        /// local Amazon EKS cluster on an Amazon Web Services Outpost. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-outposts-capacity-considerations.html">Capacity
        /// considerations</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public EtcdPlacementRequest EtcdPlacement { get; set; }

        /// <summary>
        /// Checks to see if the EtcdPlacement property is set.
        /// </summary>
        internal bool IsSetEtcdPlacement() => this.EtcdPlacement != null;

        /// <summary>
        /// Gets and sets the property OutpostArns. 
        /// <para>
        /// The ARN of the Outpost that you want to use for your local Amazon EKS cluster on Outposts.
        /// Only a single Outpost ARN is supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> OutpostArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OutpostArns property is set.
        /// </summary>
        internal bool IsSetOutpostArns() => this.OutpostArns != null && (this.OutpostArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
