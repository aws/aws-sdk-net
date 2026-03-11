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
 * Do not modify this file. This file is generated from the workspaces-thin-client-2023-08-22.normal.json service model.
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
    public partial class Device
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _currentSoftwareSetId;
        private string _currentSoftwareSetVersion;
        private string _desiredSoftwareSetId;
        private string _environmentId;
        private string _id;
        private string _kmsKeyArn;
        private DateTime? _lastConnectedAt;
        private DateTime? _lastPostureAt;
        private string _lastUserId;
        private string _model;
        private string _name;
        private string _pendingSoftwareSetId;
        private string _pendingSoftwareSetVersion;
        private string _serialNumber;
        private DeviceSoftwareSetComplianceStatus _softwareSetComplianceStatus;
        private SoftwareSetUpdateSchedule _softwareSetUpdateSchedule;
        private SoftwareSetUpdateStatus _softwareSetUpdateStatus;
        private DeviceStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the device was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentSoftwareSetId. 
        /// <para>
        /// The ID of the software set currently installed on the device.
        /// </para>
        /// </summary>
        public string CurrentSoftwareSetId
        {
            get { return this._currentSoftwareSetId; }
            set { this._currentSoftwareSetId = value; }
        }

        // Check to see if CurrentSoftwareSetId property is set
        internal bool IsSetCurrentSoftwareSetId()
        {
            return this._currentSoftwareSetId != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentSoftwareSetVersion. 
        /// <para>
        /// The version of the software set currently installed on the device.
        /// </para>
        /// </summary>
        public string CurrentSoftwareSetVersion
        {
            get { return this._currentSoftwareSetVersion; }
            set { this._currentSoftwareSetVersion = value; }
        }

        // Check to see if CurrentSoftwareSetVersion property is set
        internal bool IsSetCurrentSoftwareSetVersion()
        {
            return this._currentSoftwareSetVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredSoftwareSetId. 
        /// <para>
        /// The ID of the software set which the device has been set to.
        /// </para>
        /// </summary>
        public string DesiredSoftwareSetId
        {
            get { return this._desiredSoftwareSetId; }
            set { this._desiredSoftwareSetId = value; }
        }

        // Check to see if DesiredSoftwareSetId property is set
        internal bool IsSetDesiredSoftwareSetId()
        {
            return this._desiredSoftwareSetId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment the device is associated with.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the device.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Key Management Service key used to encrypt the
        /// device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastConnectedAt. 
        /// <para>
        /// The timestamp of the most recent session on the device.
        /// </para>
        /// </summary>
        public DateTime? LastConnectedAt
        {
            get { return this._lastConnectedAt; }
            set { this._lastConnectedAt = value; }
        }

        // Check to see if LastConnectedAt property is set
        internal bool IsSetLastConnectedAt()
        {
            return this._lastConnectedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastPostureAt. 
        /// <para>
        /// The timestamp of the most recent check-in of the device.
        /// </para>
        /// </summary>
        public DateTime? LastPostureAt
        {
            get { return this._lastPostureAt; }
            set { this._lastPostureAt = value; }
        }

        // Check to see if LastPostureAt property is set
        internal bool IsSetLastPostureAt()
        {
            return this._lastPostureAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUserId. 
        /// <para>
        /// The user ID of the most recent session on the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string LastUserId
        {
            get { return this._lastUserId; }
            set { this._lastUserId = value; }
        }

        // Check to see if LastUserId property is set
        internal bool IsSetLastUserId()
        {
            return this._lastUserId != null;
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model number of the device.
        /// </para>
        /// </summary>
        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=64)]
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
        /// Gets and sets the property PendingSoftwareSetId. 
        /// <para>
        /// The ID of the software set that is pending to be installed on the device.
        /// </para>
        /// </summary>
        public string PendingSoftwareSetId
        {
            get { return this._pendingSoftwareSetId; }
            set { this._pendingSoftwareSetId = value; }
        }

        // Check to see if PendingSoftwareSetId property is set
        internal bool IsSetPendingSoftwareSetId()
        {
            return this._pendingSoftwareSetId != null;
        }

        /// <summary>
        /// Gets and sets the property PendingSoftwareSetVersion. 
        /// <para>
        /// The version of the software set that is pending to be installed on the device.
        /// </para>
        /// </summary>
        public string PendingSoftwareSetVersion
        {
            get { return this._pendingSoftwareSetVersion; }
            set { this._pendingSoftwareSetVersion = value; }
        }

        // Check to see if PendingSoftwareSetVersion property is set
        internal bool IsSetPendingSoftwareSetVersion()
        {
            return this._pendingSoftwareSetVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The hardware serial number of the device.
        /// </para>
        /// </summary>
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareSetComplianceStatus. 
        /// <para>
        /// Describes if the software currently installed on the device is a supported version.
        /// </para>
        /// </summary>
        public DeviceSoftwareSetComplianceStatus SoftwareSetComplianceStatus
        {
            get { return this._softwareSetComplianceStatus; }
            set { this._softwareSetComplianceStatus = value; }
        }

        // Check to see if SoftwareSetComplianceStatus property is set
        internal bool IsSetSoftwareSetComplianceStatus()
        {
            return this._softwareSetComplianceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareSetUpdateSchedule. 
        /// <para>
        /// An option to define if software updates should be applied within a maintenance window.
        /// </para>
        /// </summary>
        public SoftwareSetUpdateSchedule SoftwareSetUpdateSchedule
        {
            get { return this._softwareSetUpdateSchedule; }
            set { this._softwareSetUpdateSchedule = value; }
        }

        // Check to see if SoftwareSetUpdateSchedule property is set
        internal bool IsSetSoftwareSetUpdateSchedule()
        {
            return this._softwareSetUpdateSchedule != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareSetUpdateStatus. 
        /// <para>
        /// Describes if the device has a supported version of software installed.
        /// </para>
        /// </summary>
        public SoftwareSetUpdateStatus SoftwareSetUpdateStatus
        {
            get { return this._softwareSetUpdateStatus; }
            set { this._softwareSetUpdateStatus = value; }
        }

        // Check to see if SoftwareSetUpdateStatus property is set
        internal bool IsSetSoftwareSetUpdateStatus()
        {
            return this._softwareSetUpdateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the device.
        /// </para>
        /// </summary>
        public DeviceStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the device was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}