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
    /// The updated configuration for a Amazon ECS Managed Instances provider. You can modify
    /// the infrastructure role, instance launch template, and tag propagation settings. Changes
    /// apply to new instances launched after the update.
    /// </summary>
    public partial class UpdateManagedInstancesProviderConfiguration
    {
        /// <summary>
        /// Gets and sets the property AutoRepairConfiguration. 
        /// <para>
        /// The updated auto repair configuration for the Amazon ECS Managed Instances capacity
        /// provider.
        /// </para>
        /// </summary>
        public AutoRepairConfiguration AutoRepairConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutoRepairConfiguration property is set.
        /// </summary>
        internal bool IsSetAutoRepairConfiguration() => this.AutoRepairConfiguration != null;

        /// <summary>
        /// Gets and sets the property InfrastructureOptimization. 
        /// <para>
        /// The updated infrastructure optimization configuration. Changes to this setting affect
        /// how Amazon ECS optimizes instances going forward.
        /// </para>
        /// </summary>
        public InfrastructureOptimization InfrastructureOptimization { get; set; }

        /// <summary>
        /// Checks to see if the InfrastructureOptimization property is set.
        /// </summary>
        internal bool IsSetInfrastructureOptimization() => this.InfrastructureOptimization != null;

        /// <summary>
        /// Gets and sets the property InfrastructureRoleArn. 
        /// <para>
        /// The updated Amazon Resource Name (ARN) of the infrastructure role. The new role must
        /// have the necessary permissions to manage instances and access required Amazon Web
        /// Services services.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/infrastructure_IAM_role.html">Amazon
        /// ECS infrastructure IAM role</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InfrastructureRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the InfrastructureRoleArn property is set.
        /// </summary>
        internal bool IsSetInfrastructureRoleArn() => this.InfrastructureRoleArn != null;

        /// <summary>
        /// Gets and sets the property InstanceLaunchTemplate. 
        /// <para>
        /// The updated launch template configuration. Changes to the launch template affect new
        /// instances launched after the update, while existing instances continue to use their
        /// original configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceLaunchTemplateUpdate InstanceLaunchTemplate { get; set; }

        /// <summary>
        /// Checks to see if the InstanceLaunchTemplate property is set.
        /// </summary>
        internal bool IsSetInstanceLaunchTemplate() => this.InstanceLaunchTemplate != null;

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// The updated tag propagation setting. When changed, this affects only new instances
        /// launched after the update.
        /// </para>
        /// </summary>
        public PropagateMITags PropagateTags { get; set; }

        /// <summary>
        /// Checks to see if the PropagateTags property is set.
        /// </summary>
        internal bool IsSetPropagateTags() => this.PropagateTags != null;
    }
}
