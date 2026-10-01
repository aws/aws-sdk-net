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

namespace Amazon.WorkSpacesThinClient.Model
{
    /// <summary>
    /// Describes a thin client device.
    /// </summary>
    public partial class DeviceSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the device was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentSoftwareSetId. 
        /// <para>
        /// The ID of the software set currently installed on the device.
        /// </para>
        /// </summary>
        public string CurrentSoftwareSetId { get; set; }

        /// <summary>
        /// Checks to see if the CurrentSoftwareSetId property is set.
        /// </summary>
        internal bool IsSetCurrentSoftwareSetId() => this.CurrentSoftwareSetId != null;

        /// <summary>
        /// Gets and sets the property DesiredSoftwareSetId. 
        /// <para>
        /// The ID of the software set which the device has been set to.
        /// </para>
        /// </summary>
        public string DesiredSoftwareSetId { get; set; }

        /// <summary>
        /// Checks to see if the DesiredSoftwareSetId property is set.
        /// </summary>
        internal bool IsSetDesiredSoftwareSetId() => this.DesiredSoftwareSetId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment the device is associated with.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the device.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastConnectedAt. 
        /// <para>
        /// The timestamp of the most recent session on the device.
        /// </para>
        /// </summary>
        public DateTime? LastConnectedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastConnectedAt property is set.
        /// </summary>
        internal bool IsSetLastConnectedAt() => this.LastConnectedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastPostureAt. 
        /// <para>
        /// The timestamp of the most recent check-in of the device.
        /// </para>
        /// </summary>
        public DateTime? LastPostureAt { get; set; }

        /// <summary>
        /// Checks to see if the LastPostureAt property is set.
        /// </summary>
        internal bool IsSetLastPostureAt() => this.LastPostureAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastUserId. 
        /// <para>
        /// The user ID of the most recent session on the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string LastUserId { get; set; }

        /// <summary>
        /// Checks to see if the LastUserId property is set.
        /// </summary>
        internal bool IsSetLastUserId() => this.LastUserId != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model number of the device.
        /// </para>
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PendingSoftwareSetId. 
        /// <para>
        /// The ID of the software set that is pending to be installed on the device.
        /// </para>
        /// </summary>
        public string PendingSoftwareSetId { get; set; }

        /// <summary>
        /// Checks to see if the PendingSoftwareSetId property is set.
        /// </summary>
        internal bool IsSetPendingSoftwareSetId() => this.PendingSoftwareSetId != null;

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The hardware serial number of the device.
        /// </para>
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumber property is set.
        /// </summary>
        internal bool IsSetSerialNumber() => this.SerialNumber != null;

        /// <summary>
        /// Gets and sets the property SoftwareSetUpdateSchedule. 
        /// <para>
        /// An option to define if software updates should be applied within a maintenance window.
        /// </para>
        /// </summary>
        public SoftwareSetUpdateSchedule SoftwareSetUpdateSchedule { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareSetUpdateSchedule property is set.
        /// </summary>
        internal bool IsSetSoftwareSetUpdateSchedule() => this.SoftwareSetUpdateSchedule != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the device.
        /// </para>
        /// </summary>
        public DeviceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the device was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
