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
    /// The details for a capacity provider.
    /// </summary>
    public partial class CapacityProvider
    {
        private AutoScalingGroupProvider _autoScalingGroupProvider;
        private string _capacityProviderArn;
        private string _cluster;
        private ManagedInstancesProvider _managedInstancesProvider;
        private string _name;
        private CapacityProviderStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private CapacityProviderType _type;
        private CapacityProviderUpdateStatus _updateStatus;
        private string _updateStatusReason;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupProvider. 
        /// <para>
        /// The Auto Scaling group settings for the capacity provider.
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
        /// Gets and sets the property CapacityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the capacity provider.
        /// </para>
        /// </summary>
        public string CapacityProviderArn
        {
            get { return this._capacityProviderArn; }
            set { this._capacityProviderArn = value; }
        }

        // Check to see if CapacityProviderArn property is set
        internal bool IsSetCapacityProviderArn()
        {
            return this._capacityProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The cluster that this capacity provider is associated with. Managed instances capacity
        /// providers are cluster-scoped, meaning they can only be used within their associated
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

        /// <summary>
        /// Gets and sets the property ManagedInstancesProvider. 
        /// <para>
        /// The configuration for the Amazon ECS Managed Instances provider. This includes the
        /// infrastructure role, the launch template configuration, and tag propagation settings.
        /// </para>
        /// </summary>
        public ManagedInstancesProvider ManagedInstancesProvider
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
        /// The name of the capacity provider.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the capacity provider. Only capacity providers in an <c>ACTIVE</c>
        /// state can be used in a cluster. When a capacity provider is successfully deleted,
        /// it has an <c>INACTIVE</c> status.
        /// </para>
        /// </summary>
        public CapacityProviderStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the capacity provider to help you categorize and organize
        /// it. Each tag consists of a key and an optional value. You define both.
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of capacity provider. For Amazon ECS Managed Instances, this value is <c>MANAGED_INSTANCES</c>,
        /// indicating that Amazon ECS manages the underlying Amazon EC2 instances on your behalf.
        /// </para>
        /// </summary>
        public CapacityProviderType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// The update status of the capacity provider. The following are the possible states
        /// that is returned.
        /// </para>
        ///  <dl> <dt>DELETE_IN_PROGRESS</dt> <dd> 
        /// <para>
        /// The capacity provider is in the process of being deleted.
        /// </para>
        ///  </dd> <dt>DELETE_COMPLETE</dt> <dd> 
        /// <para>
        /// The capacity provider was successfully deleted and has an <c>INACTIVE</c> status.
        /// </para>
        ///  </dd> <dt>DELETE_FAILED</dt> <dd> 
        /// <para>
        /// The capacity provider can't be deleted. The update status reason provides further
        /// details about why the delete failed.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public CapacityProviderUpdateStatus UpdateStatus
        {
            get { return this._updateStatus; }
            set { this._updateStatus = value; }
        }

        // Check to see if UpdateStatus property is set
        internal bool IsSetUpdateStatus()
        {
            return this._updateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateStatusReason. 
        /// <para>
        /// The update status reason. This provides further details about the update status for
        /// the capacity provider.
        /// </para>
        /// </summary>
        public string UpdateStatusReason
        {
            get { return this._updateStatusReason; }
            set { this._updateStatusReason = value; }
        }

        // Check to see if UpdateStatusReason property is set
        internal bool IsSetUpdateStatusReason()
        {
            return this._updateStatusReason != null;
        }

    }
}