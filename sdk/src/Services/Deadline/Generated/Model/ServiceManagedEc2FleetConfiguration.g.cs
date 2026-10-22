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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The configuration details for a service managed EC2 fleet.
    /// </summary>
    public partial class ServiceManagedEc2FleetConfiguration
    {
        /// <summary>
        /// Gets and sets the property AutoScalingConfiguration. 
        /// <para>
        /// The auto scaling configuration settings for the service managed EC2 fleet.
        /// </para>
        /// </summary>
        public ServiceManagedEc2AutoScalingConfiguration AutoScalingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingConfiguration property is set.
        /// </summary>
        internal bool IsSetAutoScalingConfiguration() => this.AutoScalingConfiguration != null;

        /// <summary>
        /// Gets and sets the property InstanceCapabilities. 
        /// <para>
        /// The instance capabilities for the service managed EC2 fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceManagedEc2InstanceCapabilities InstanceCapabilities { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCapabilities property is set.
        /// </summary>
        internal bool IsSetInstanceCapabilities() => this.InstanceCapabilities != null;

        /// <summary>
        /// Gets and sets the property InstanceMarketOptions. 
        /// <para>
        /// The instance market options for the service managed EC2 fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceManagedEc2InstanceMarketOptions InstanceMarketOptions { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMarketOptions property is set.
        /// </summary>
        internal bool IsSetInstanceMarketOptions() => this.InstanceMarketOptions != null;

        /// <summary>
        /// Gets and sets the property PersistentVolumeConfiguration. 
        /// <para>
        /// The persistent volume configuration for the service managed EC2 fleet.
        /// </para>
        /// </summary>
        public PersistentVolumeConfiguration PersistentVolumeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PersistentVolumeConfiguration property is set.
        /// </summary>
        internal bool IsSetPersistentVolumeConfiguration() => this.PersistentVolumeConfiguration != null;

        /// <summary>
        /// Gets and sets the property StorageProfileId. 
        /// <para>
        /// The storage profile ID for the service managed EC2 fleet.
        /// </para>
        /// </summary>
        public string StorageProfileId { get; set; }

        /// <summary>
        /// Checks to see if the StorageProfileId property is set.
        /// </summary>
        internal bool IsSetStorageProfileId() => this.StorageProfileId != null;

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// The VPC configuration for the service managed EC2 fleet.
        /// </para>
        /// </summary>
        public VpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}
