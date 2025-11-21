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
    /// The updated launch template configuration for Amazon ECS Managed Instances. You can
    /// modify the instance profile, network configuration, storage settings, and instance
    /// requirements. Changes apply to new instances launched after the update.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">Store
    /// instance launch parameters in Amazon EC2 launch templates</a> in the <i>Amazon EC2
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class InstanceLaunchTemplateUpdate
    {
        private string _ec2InstanceProfileArn;
        private InstanceRequirementsRequest _instanceRequirements;
        private ManagedInstancesMonitoringOptions _monitoring;
        private ManagedInstancesNetworkConfiguration _networkConfiguration;
        private ManagedInstancesStorageConfiguration _storageConfiguration;

        /// <summary>
        /// Gets and sets the property Ec2InstanceProfileArn. 
        /// <para>
        /// The updated Amazon Resource Name (ARN) of the instance profile. The new instance profile
        /// must have the necessary permissions for your tasks.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/managed-instances-instance-profile.html">Amazon
        /// ECS instance profile for Managed Instances</a> in the <i>Amazon ECS Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        public string Ec2InstanceProfileArn
        {
            get { return this._ec2InstanceProfileArn; }
            set { this._ec2InstanceProfileArn = value; }
        }

        // Check to see if Ec2InstanceProfileArn property is set
        internal bool IsSetEc2InstanceProfileArn()
        {
            return this._ec2InstanceProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The updated instance requirements for attribute-based instance type selection. Changes
        /// to instance requirements affect which instance types Amazon ECS selects for new instances.
        /// </para>
        /// </summary>
        public InstanceRequirementsRequest InstanceRequirements
        {
            get { return this._instanceRequirements; }
            set { this._instanceRequirements = value; }
        }

        // Check to see if InstanceRequirements property is set
        internal bool IsSetInstanceRequirements()
        {
            return this._instanceRequirements != null;
        }

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// CloudWatch provides two categories of monitoring: basic monitoring and detailed monitoring.
        /// By default, your managed instance is configured for basic monitoring. You can optionally
        /// enable detailed monitoring to help you more quickly identify and act on operational
        /// issues. You can enable or turn off detailed monitoring at launch or when the managed
        /// instance is running or stopped. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/detailed-monitoring-managed-instances.html">Detailed
        /// monitoring for Amazon ECS Managed Instances</a> in the Amazon ECS Developer Guide.
        /// </para>
        /// </summary>
        public ManagedInstancesMonitoringOptions Monitoring
        {
            get { return this._monitoring; }
            set { this._monitoring = value; }
        }

        // Check to see if Monitoring property is set
        internal bool IsSetMonitoring()
        {
            return this._monitoring != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The updated network configuration for Amazon ECS Managed Instances. Changes to subnets
        /// and security groups affect new instances launched after the update.
        /// </para>
        /// </summary>
        public ManagedInstancesNetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// The updated storage configuration for Amazon ECS Managed Instances. Changes to storage
        /// settings apply to new instances launched after the update.
        /// </para>
        /// </summary>
        public ManagedInstancesStorageConfiguration StorageConfiguration
        {
            get { return this._storageConfiguration; }
            set { this._storageConfiguration = value; }
        }

        // Check to see if StorageConfiguration property is set
        internal bool IsSetStorageConfiguration()
        {
            return this._storageConfiguration != null;
        }

    }
}