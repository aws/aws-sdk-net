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
    /// The summary of a persistent volume.
    /// </summary>
    public partial class VolumeSummary
    {
        /// <summary>
        /// Gets and sets the property AttachedWorkerId. 
        /// <para>
        /// The worker ID of the worker the volume is attached to.
        /// </para>
        /// </summary>
        public string AttachedWorkerId { get; set; }

        /// <summary>
        /// Checks to see if the AttachedWorkerId property is set.
        /// </summary>
        internal bool IsSetAttachedWorkerId() => this.AttachedWorkerId != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID of the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID of the farm that contains the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// The fleet ID of the fleet that contains the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property SizeGiB. 
        /// <para>
        /// The volume size in GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65536)]
        public int? SizeGiB { get; set; }

        /// <summary>
        /// Checks to see if the SizeGiB property is set.
        /// </summary>
        internal bool IsSetSizeGiB() => this.SizeGiB.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VolumeState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The volume ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;
    }
}
