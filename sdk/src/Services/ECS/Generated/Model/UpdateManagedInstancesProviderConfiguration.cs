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
    /// The updated configuration for a Amazon ECS Managed Instances provider. You can modify
    /// the infrastructure role, instance launch template, and tag propagation settings. Changes
    /// apply to new instances launched after the update.
    /// </summary>
    public partial class UpdateManagedInstancesProviderConfiguration
    {
        private string _infrastructureRoleArn;
        private InstanceLaunchTemplateUpdate _instanceLaunchTemplate;
        private PropagateMITags _propagateTags;

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
        /// The updated launch template configuration. Changes to the launch template affect new
        /// instances launched after the update, while existing instances continue to use their
        /// original configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The updated tag propagation setting. When changed, this affects only new instances
        /// launched after the update.
        /// </para>
        /// </summary>
        public PropagateMITags PropagateTags
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