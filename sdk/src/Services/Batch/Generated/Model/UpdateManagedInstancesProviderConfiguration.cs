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
    /// The configuration for updating an Amazon ECS Managed Instances capacity provider.
    /// Used in <c>UpdateComputeEnvironment</c> requests. The <c>capacityOptionType</c> and
    /// <c>fipsEnabled</c> fields cannot be changed on update.
    /// </summary>
    public partial class UpdateManagedInstancesProviderConfiguration
    {
        private InfrastructureOptimization _infrastructureOptimization;
        private string _infrastructureRoleArn;
        private InstanceLaunchTemplateUpdate _instanceLaunchTemplate;
        private string _propagateTags;

        /// <summary>
        /// Gets and sets the property InfrastructureOptimization. 
        /// <para>
        /// The updated infrastructure optimization configuration.
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
        /// The updated Amazon Resource Name (ARN) of the IAM role that Amazon ECS assumes to
        /// manage Amazon EC2 instances on your behalf.
        /// </para>
        /// </summary>
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
        /// The updated instance launch configuration for the Amazon ECS Managed Instances capacity
        /// provider.
        /// </para>
        /// </summary>
        public InstanceLaunchTemplateUpdate InstanceLaunchTemplate
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
        ///  <c>NONE</c> — Does not propagate tags to instances.
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