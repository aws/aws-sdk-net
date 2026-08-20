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
    /// The instance launch configuration for updating an Amazon ECS Managed Instances capacity
    /// provider. You cannot change <c>capacityOptionType</c> or <c>fipsEnabled</c> after
    /// the compute environment is created.
    /// </summary>
    public partial class InstanceLaunchTemplateUpdate
    {
        private CapacityReservationRequest _capacityReservations;
        private string _ec2InstanceProfileArn;
        private bool? _instanceMetadataTagsPropagation;
        private InstanceRequirementsRequest _instanceRequirements;
        private ManagedInstancesLocalStorageConfiguration _localStorageConfiguration;
        private string _monitoring;
        private ManagedInstancesNetworkConfiguration _networkConfiguration;
        private ManagedInstancesStorageConfiguration _storageConfiguration;

        /// <summary>
        /// Gets and sets the property CapacityReservations. 
        /// <para>
        /// The updated capacity reservation configuration.
        /// </para>
        /// </summary>
        public CapacityReservationRequest CapacityReservations
        {
            get { return this._capacityReservations; }
            set { this._capacityReservations = value; }
        }

        // Check to see if CapacityReservations property is set
        internal bool IsSetCapacityReservations()
        {
            return this._capacityReservations != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceProfileArn. 
        /// <para>
        /// The updated Amazon Resource Name (ARN) of the Amazon EC2 instance profile for the
        /// managed instances.
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
        /// Gets and sets the property InstanceMetadataTagsPropagation. 
        /// <para>
        /// Specifies whether instance tags are accessible from the instance metadata service
        /// (IMDS).
        /// </para>
        /// </summary>
        public bool? InstanceMetadataTagsPropagation
        {
            get { return this._instanceMetadataTagsPropagation; }
            set { this._instanceMetadataTagsPropagation = value; }
        }

        // Check to see if InstanceMetadataTagsPropagation property is set
        internal bool IsSetInstanceMetadataTagsPropagation()
        {
            return this._instanceMetadataTagsPropagation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The updated instance type requirements for the capacity provider.
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
        /// Gets and sets the property LocalStorageConfiguration. 
        /// <para>
        /// The updated local storage configuration.
        /// </para>
        /// </summary>
        public ManagedInstancesLocalStorageConfiguration LocalStorageConfiguration
        {
            get { return this._localStorageConfiguration; }
            set { this._localStorageConfiguration = value; }
        }

        // Check to see if LocalStorageConfiguration property is set
        internal bool IsSetLocalStorageConfiguration()
        {
            return this._localStorageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// The updated monitoring level. Valid values are <c>BASIC</c> and <c>DETAILED</c>.
        /// </para>
        /// </summary>
        public string Monitoring
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
        /// The updated network configuration for the managed instances.
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
        /// The updated storage configuration for the managed instances.
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