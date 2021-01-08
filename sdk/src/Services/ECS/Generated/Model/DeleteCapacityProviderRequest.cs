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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCapacityProvider operation.
    /// Deletes the specified capacity provider.
    /// 
    ///  <note> 
    /// <para>
    /// The <code>FARGATE</code> and <code>FARGATE_SPOT</code> capacity providers are reserved
    /// and cannot be deleted. You can disassociate them from a cluster using either the <a>PutClusterCapacityProviders</a>
    /// API or by deleting the cluster.
    /// </para>
    ///  </note> 
    /// <para>
    /// Prior to a capacity provider being deleted, the capacity provider must be removed
    /// from the capacity provider strategy from all services. The <a>UpdateService</a> API
    /// can be used to remove a capacity provider from a service's capacity provider strategy.
    /// When updating a service, the <code>forceNewDeployment</code> option can be used to
    /// ensure that any tasks using the Amazon EC2 instance capacity provided by the capacity
    /// provider are transitioned to use the capacity from the remaining capacity providers.
    /// Only capacity providers that are not associated with a cluster can be deleted. To
    /// remove a capacity provider from a cluster, you can either use <a>PutClusterCapacityProviders</a>
    /// or delete the cluster.
    /// </para>
    /// </summary>
    public partial class DeleteCapacityProviderRequest : AmazonECSRequest
    {
        private string _capacityProvider;

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

    }
}