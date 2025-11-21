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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCapacityProvider operation.
    /// Deletes the specified capacity provider.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>FARGATE</c> and <c>FARGATE_SPOT</c> capacity providers are reserved and can't
    /// be deleted. You can disassociate them from a cluster using either <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutClusterCapacityProviders.html">PutClusterCapacityProviders</a>
    /// or by deleting the cluster.
    /// </para>
    ///  </note> 
    /// <para>
    /// Prior to a capacity provider being deleted, the capacity provider must be removed
    /// from the capacity provider strategy from all services. The <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_UpdateService.html">UpdateService</a>
    /// API can be used to remove a capacity provider from a service's capacity provider strategy.
    /// When updating a service, the <c>forceNewDeployment</c> option can be used to ensure
    /// that any tasks using the Amazon EC2 instance capacity provided by the capacity provider
    /// are transitioned to use the capacity from the remaining capacity providers. Only capacity
    /// providers that aren't associated with a cluster can be deleted. To remove a capacity
    /// provider from a cluster, you can either use <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutClusterCapacityProviders.html">PutClusterCapacityProviders</a>
    /// or delete the cluster.
    /// </para>
    /// </summary>
    public partial class DeleteCapacityProviderRequest : AmazonECSRequest
    {
        private string _capacityProvider;
        private string _cluster;

        /// <summary>
        /// Gets and sets the property CapacityProvider. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the capacity provider to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CapacityProvider
        {
            get { return this._capacityProvider; }
            set { this._capacityProvider = value; }
        }

        // Check to see if CapacityProvider property is set
        internal bool IsSetCapacityProvider()
        {
            return this._capacityProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The name of the cluster that contains the capacity provider to delete. Managed instances
        /// capacity providers are cluster-scoped and can only be deleted from their associated
        /// cluster.
        /// </para>
        /// </summary>
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

    }
}