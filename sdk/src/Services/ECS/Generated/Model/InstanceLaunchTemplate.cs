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
    /// The launch template configuration for Amazon ECS Managed Instances. This defines how
    /// Amazon ECS launches Amazon EC2 instances, including the instance profile for your
    /// tasks, network and storage configuration, capacity options, and instance requirements
    /// for flexible instance type selection.
    /// </summary>
    public partial class InstanceLaunchTemplate
    {
        private CapacityOptionType _capacityOptionType;
        private string _ec2InstanceProfileArn;
        private bool? _fipsEnabled;
        private InstanceRequirementsRequest _instanceRequirements;
        private ManagedInstancesMonitoringOptions _monitoring;
        private ManagedInstancesNetworkConfiguration _networkConfiguration;
        private ManagedInstancesStorageConfiguration _storageConfiguration;

        /// <summary>
        /// Gets and sets the property CapacityOptionType. 
        /// <para>
        /// The capacity option type. This determines whether Amazon ECS launches On-Demand or
        /// Spot Instances for your managed instance capacity provider.
        /// </para>
        ///  
        /// <para>
        /// Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ON_DEMAND</c> - Launches standard On-Demand Instances. On-Demand Instances provide
        /// predictable pricing and availability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SPOT</c> - Launches Spot Instances that use spare Amazon EC2 capacity at reduced
        /// cost. Spot Instances can be interrupted by Amazon EC2 with a two-minute notification
        /// when the capacity is needed back.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is On-Demand
        /// </para>
        ///  
        /// <para>
        /// For more information about Amazon EC2 capacity options, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-purchasing-options.html">Instance
        /// purchasing options</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public CapacityOptionType CapacityOptionType
        {
            get { return this._capacityOptionType; }
            set { this._capacityOptionType = value; }
        }

        // Check to see if CapacityOptionType property is set
        internal bool IsSetCapacityOptionType()
        {
            return this._capacityOptionType != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the instance profile that Amazon ECS applies to
        /// Amazon ECS Managed Instances. This instance profile must include the necessary permissions
        /// for your tasks to access Amazon Web Services services and resources.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/managed-instances-instance-profile.html">Amazon
        /// ECS instance profile for Managed Instances</a> in the <i>Amazon ECS Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FipsEnabled. 
        /// <para>
        /// Determines whether to enable FIPS 140-2 validated cryptographic modules on EC2 instances
        /// launched by the capacity provider. If <c>true</c>, instances use FIPS-compliant cryptographic
        /// algorithms and modules for enhanced security compliance. If <c>false</c>, instances
        /// use standard cryptographic implementations.
        /// </para>
        ///  
        /// <para>
        /// If not specified, instances are launched with FIPS enabled in AWS GovCloud (US) regions
        /// and FIPS disabled in other regions.
        /// </para>
        /// </summary>
        public bool? FipsEnabled
        {
            get { return this._fipsEnabled; }
            set { this._fipsEnabled = value; }
        }

        // Check to see if FipsEnabled property is set
        internal bool IsSetFipsEnabled()
        {
            return this._fipsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The instance requirements. You can specify:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The instance types
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instance requirements such as vCPU count, memory, network performance, and accelerator
        /// specifications
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon ECS automatically selects the instances that match the specified criteria.
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
        /// The network configuration for Amazon ECS Managed Instances. This specifies the subnets
        /// and security groups that instances use for network connectivity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The storage configuration for Amazon ECS Managed Instances. This defines the root
        /// volume size and type for the instances.
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