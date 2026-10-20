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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCapacityProvider operation. Modifies the
    /// parameters for a capacity provider. <para> These changes only apply to new Amazon
    /// ECS Managed Instances, or EC2 instances, not existing ones. </para>
    /// </summary>
    public partial class UpdateCapacityProviderRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property AutoScalingGroupProvider. 
        /// <para>
        /// An object that represent the parameters to update for the Auto Scaling group capacity
        /// provider.
        /// </para>
        /// </summary>
        public AutoScalingGroupProviderUpdate AutoScalingGroupProvider { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingGroupProvider property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroupProvider() => this.AutoScalingGroupProvider != null;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The name of the cluster that contains the capacity provider to update. Managed instances
        /// capacity providers are cluster-scoped and can only be updated within their associated
        /// cluster.
        /// </para>
        /// </summary>
        public string Cluster { get; set; }

        /// <summary>
        /// Checks to see if the Cluster property is set.
        /// </summary>
        internal bool IsSetCluster() => this.Cluster != null;

        /// <summary>
        /// Gets and sets the property ManagedInstancesProvider. 
        /// <para>
        /// The updated configuration for the Amazon ECS Managed Instances provider. You can modify
        /// the infrastructure role, instance launch template, and tag propagation settings. Changes
        /// take effect for new instances launched after the update.
        /// </para>
        /// </summary>
        public UpdateManagedInstancesProviderConfiguration ManagedInstancesProvider { get; set; }

        /// <summary>
        /// Checks to see if the ManagedInstancesProvider property is set.
        /// </summary>
        internal bool IsSetManagedInstancesProvider() => this.ManagedInstancesProvider != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the capacity provider to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
