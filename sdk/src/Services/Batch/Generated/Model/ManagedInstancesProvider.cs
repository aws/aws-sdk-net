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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
    /// The configuration for an Amazon ECS Managed Instances capacity provider. This object
    /// is required when creating a compute environment with <c>computeResources.type</c>
    /// set to <c>ECS_MANAGED_INSTANCES</c>.
    /// </summary>
    public partial class ManagedInstancesProvider
    {
        private InfrastructureOptimization _infrastructureOptimization;
        private string _infrastructureRoleArn;
        private InstanceLaunchTemplate _instanceLaunchTemplate;
        private string _propagateTags;

        /// <summary>
        /// Gets and sets the property InfrastructureOptimization. 
        /// <para>
        /// The infrastructure optimization configuration for the capacity provider. Specifies
        /// the idle-instance scale-in behavior.
        /// </para>
        /// </summary>
        public InfrastructureOptimization InfrastructureOptimization
        {
            get { return this._infrastructureOptimization; }
            set { this._infrastructureOptimization = value; }
        }

        // Check to see if InfrastructureOptimization property is set
        internal bool IsSetInfrastructureOptimization()
        {
            return this._infrastructureOptimization != null;
        }

        /// <summary>
        /// Gets and sets the property InfrastructureRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon ECS assumes to manage Amazon
        /// EC2 instances on your behalf. This role must have a trust policy for <c>ecs.amazonaws.com</c>.
        /// You must have the <c>iam:PassRole</c> permission for this role with the condition
        /// <c>iam:PassedToService: ecs.amazonaws.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InfrastructureRoleArn
        {
            get { return this._infrastructureRoleArn; }
            set { this._infrastructureRoleArn = value; }
        }

        // Check to see if InfrastructureRoleArn property is set
        internal bool IsSetInfrastructureRoleArn()
        {
            return this._infrastructureRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceLaunchTemplate. 
        /// <para>
        /// The instance launch configuration for the Amazon ECS Managed Instances capacity provider.
        /// Contains networking, instance profile, instance requirements, capacity type, storage,
        /// and monitoring configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceLaunchTemplate InstanceLaunchTemplate
        {
            get { return this._instanceLaunchTemplate; }
            set { this._instanceLaunchTemplate = value; }
        }

        // Check to see if InstanceLaunchTemplate property is set
        internal bool IsSetInstanceLaunchTemplate()
        {
            return this._instanceLaunchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether tags on the capacity provider are propagated to the Amazon EC2 instances
        /// it launches. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CAPACITY_PROVIDER</c> — Propagates tags to instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> (default) — Does not propagate tags to instances.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string PropagateTags
        {
            get { return this._propagateTags; }
            set { this._propagateTags = value; }
        }

        // Check to see if PropagateTags property is set
        internal bool IsSetPropagateTags()
        {
            return this._propagateTags != null;
        }

    }
}