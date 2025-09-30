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
    /// Container for the parameters to the CreateCapacityProvider operation.
    /// Creates a capacity provider. Capacity providers are associated with a cluster and
    /// are used in capacity provider strategies to facilitate cluster auto scaling. You can
    /// create capacity providers for Amazon ECS Managed Instances and EC2 instances. Fargate
    /// has the predefined <c>FARGATE</c> and <c>FARGATE_SPOT</c> capacity providers.
    /// </summary>
    public partial class CreateCapacityProviderRequest : AmazonECSRequest
    {
        private AutoScalingGroupProvider _autoScalingGroupProvider;
        private string _cluster;
        private CreateManagedInstancesProviderConfiguration _managedInstancesProvider;
        private string _name;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupProvider. 
        /// <para>
        /// The details of the Auto Scaling group for the capacity provider.
        /// </para>
        /// </summary>
        public AutoScalingGroupProvider AutoScalingGroupProvider
        {
            get { return this._autoScalingGroupProvider; }
            set { this._autoScalingGroupProvider = value; }
        }

        // Check to see if AutoScalingGroupProvider property is set
        internal bool IsSetAutoScalingGroupProvider()
        {
            return this._autoScalingGroupProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The name of the cluster to associate with the capacity provider. When you create a
        /// capacity provider with Amazon ECS Managed Instances, it becomes available only within
        /// the specified cluster.
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

        /// <summary>
        /// Gets and sets the property ManagedInstancesProvider. 
        /// <para>
        /// The configuration for the Amazon ECS Managed Instances provider. This configuration
        /// specifies how Amazon ECS manages Amazon EC2 instances on your behalf, including the
        /// infrastructure role, instance launch template, and tag propagation settings.
        /// </para>
        /// </summary>
        public CreateManagedInstancesProviderConfiguration ManagedInstancesProvider
        {
            get { return this._managedInstancesProvider; }
            set { this._managedInstancesProvider = value; }
        }

        // Check to see if ManagedInstancesProvider property is set
        internal bool IsSetManagedInstancesProvider()
        {
            return this._managedInstancesProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the capacity provider. Up to 255 characters are allowed. They include
        /// letters (both upper and lowercase letters), numbers, underscores (_), and hyphens
        /// (-). The name can't be prefixed with "<c>aws</c>", "<c>ecs</c>", or "<c>fargate</c>".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the capacity provider to categorize and organize them
        /// more conveniently. Each tag consists of a key and an optional value. You define both
        /// of them.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use <c>aws:</c>, <c>AWS:</c>, or any upper or lowercase combination of such
        /// as a prefix for either keys or values as it is reserved for Amazon Web Services use.
        /// You cannot edit or delete tag keys or values with this prefix. Tags with this prefix
        /// do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}