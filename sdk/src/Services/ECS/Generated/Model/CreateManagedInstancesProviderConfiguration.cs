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
    /// The configuration for creating a Amazon ECS Managed Instances provider. This specifies
    /// how Amazon ECS should manage Amazon EC2 instances, including the infrastructure role,
    /// instance launch template, and whether to propagate tags from the capacity provider
    /// to the instances.
    /// </summary>
    public partial class CreateManagedInstancesProviderConfiguration
    {
        private string _infrastructureRoleArn;
        private InstanceLaunchTemplate _instanceLaunchTemplate;
        private PropagateMITags _propagateTags;

        /// <summary>
        /// Gets and sets the property InfrastructureRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the infrastructure role that Amazon ECS uses to
        /// manage instances on your behalf. This role must have permissions to launch, terminate,
        /// and manage Amazon EC2 instances, as well as access to other Amazon Web Services services
        /// required for Amazon ECS Managed Instances functionality.
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
        /// The launch template configuration that specifies how Amazon ECS should launch Amazon
        /// EC2 instances. This includes the instance profile, network configuration, storage
        /// settings, and instance requirements for attribute-based instance type selection.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">Store
        /// instance launch parameters in Amazon EC2 launch templates</a> in the <i>Amazon EC2
        /// User Guide</i>.
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
        /// Specifies whether to propagate tags from the capacity provider to the Amazon ECS Managed
        /// Instances. When enabled, tags applied to the capacity provider are automatically applied
        /// to all instances launched by this provider.
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