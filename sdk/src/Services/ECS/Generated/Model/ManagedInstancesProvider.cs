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
    /// The configuration for a Amazon ECS Managed Instances provider. Amazon ECS uses this
    /// configuration to automatically launch, manage, and terminate Amazon EC2 instances
    /// on your behalf. Managed instances provide access to the full range of Amazon EC2 instance
    /// types and features while offloading infrastructure management to Amazon Web Services.
    /// </summary>
    public partial class ManagedInstancesProvider
    {
        private string _infrastructureRoleArn;
        private InstanceLaunchTemplate _instanceLaunchTemplate;
        private PropagateMITags _propagateTags;

        /// <summary>
        /// Gets and sets the property InfrastructureRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the infrastructure role that Amazon ECS assumes
        /// to manage instances. This role must include permissions for Amazon EC2 instance lifecycle
        /// management, networking, and any additional Amazon Web Services services required for
        /// your workloads.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/infrastructure_IAM_role.html">Amazon
        /// ECS infrastructure IAM role</a> in the <i>Amazon ECS Developer Guide</i>.
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
        /// The launch template that defines how Amazon ECS launches Amazon ECS Managed Instances.
        /// This includes the instance profile for your tasks, network and storage configuration,
        /// and instance requirements that determine which Amazon EC2 instance types can be used.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">Store
        /// instance launch parameters in Amazon EC2 launch templates</a> in the <i>Amazon EC2
        /// User Guide</i>.
        /// </para>
        /// </summary>
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
        /// Determines whether tags from the capacity provider are automatically applied to Amazon
        /// ECS Managed Instances. This helps with cost allocation and resource management by
        /// ensuring consistent tagging across your infrastructure.
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