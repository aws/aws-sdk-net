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
    /// Container for the parameters to the UpdateClusterVersion operation. Updates an Amazon
    /// EKS cluster to the specified Kubernetes version. Your cluster continues to function
    /// during the update. The response output includes an update ID that you can use to track
    /// the status of your cluster update with the <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_DescribeUpdate.html">
    /// <c>DescribeUpdate</c> </a> API operation. <para> Cluster updates are asynchronous,
    /// and they should finish within a few minutes. During an update, the cluster status
    /// moves to <c>UPDATING</c> (this status transition is eventually consistent). When the
    /// update is complete (either <c>Failed</c> or <c>Successful</c>), the cluster status
    /// moves to <c>Active</c>. </para> <para> If your cluster has managed node groups attached
    /// to it, all of your node groups' Kubernetes versions must match the cluster's Kubernetes
    /// version in order to update the cluster to a new Kubernetes version. </para>
    /// </summary>
    public partial class UpdateClusterVersionRequest : AmazonEKSRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// Set this value to <c>true</c> to override upgrade-blocking or rollback-blocking readiness
        /// checks when updating a cluster.
        /// </para>
        /// </summary>
        public bool? Force { get; set; }

        /// <summary>
        /// Checks to see if the Force property is set.
        /// </summary>
        internal bool IsSetForce() => this.Force.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon EKS cluster to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RollbackConfig. 
        /// <para>
        /// The rollback configuration for the cluster version rollback.
        /// </para>
        /// </summary>
        public RollbackConfig RollbackConfig { get; set; }

        /// <summary>
        /// Checks to see if the RollbackConfig property is set.
        /// </summary>
        internal bool IsSetRollbackConfig() => this.RollbackConfig != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The desired Kubernetes version following a successful update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
