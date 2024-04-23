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

namespace Amazon.WorkSpacesThinClient.Model
{
    /// <summary>
    /// Describes an environment.
    /// </summary>
    public partial class Environment
    {
        private string _activationCode;
        private string _arn;
        private DateTime? _createdAt;
        private string _desiredSoftwareSetId;
        private string _desktopArn;
        private string _desktopEndpoint;
        private DesktopType _desktopType;
        private string _id;
        private string _kmsKeyArn;
        private MaintenanceWindow _maintenanceWindow;
        private string _name;
        private string _pendingSoftwareSetId;
        private string _pendingSoftwareSetVersion;
        private int? _registeredDevicesCount;
        private EnvironmentSoftwareSetComplianceStatus _softwareSetComplianceStatus;
        private SoftwareSetUpdateMode _softwareSetUpdateMode;
        private SoftwareSetUpdateSchedule _softwareSetUpdateSchedule;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ActivationCode. 
        /// <para>
        /// The activation code to register a device to the environment.
        /// </para>
        /// </summary>
        public string ActivationCode
        {
            get { return this._activationCode; }
            set { this._activationCode = value; }
        }

        // Check to see if ActivationCode property is set
        internal bool IsSetActivationCode()
        {
            return this._activationCode != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the environment.
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
        /// The timestamp of when the environment was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredSoftwareSetId. 
        /// <para>
        /// The ID of the software set to apply.
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
        /// Gets and sets the property DesktopArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the desktop to stream from Amazon WorkSpaces, WorkSpaces
        /// Web, or AppStream 2.0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DesktopArn
        {
            get { return this._desktopArn; }
            set { this._desktopArn = value; }
        }

        // Check to see if DesktopArn property is set
        internal bool IsSetDesktopArn()
        {
            return this._desktopArn != null;
        }

        /// <summary>
        /// Gets and sets the property DesktopEndpoint. 
        /// <para>
        /// The URL for the identity provider login (only for environments that use AppStream
        /// 2.0).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string DesktopEndpoint
        {
            get { return this._desktopEndpoint; }
            set { this._desktopEndpoint = value; }
        }

        // Check to see if DesktopEndpoint property is set
        internal bool IsSetDesktopEndpoint()
        {
            return this._desktopEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property DesktopType. 
        /// <para>
        /// The type of streaming desktop for the environment.
        /// </para>
        /// </summary>
        public DesktopType DesktopType
        {
            get { return this._desktopType; }
            set { this._desktopType = value; }
        }

        // Check to see if DesktopType property is set
        internal bool IsSetDesktopType()
        {
            return this._desktopType != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the environment.
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
        /// environment.
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
        /// Gets and sets the property MaintenanceWindow. 
        /// <para>
        /// A specification for a time window to apply software updates.
        /// </para>
        /// </summary>
        public MaintenanceWindow MaintenanceWindow
        {
            get { return this._maintenanceWindow; }
            set { this._maintenanceWindow = value; }
        }

        // Check to see if MaintenanceWindow property is set
        internal bool IsSetMaintenanceWindow()
        {
            return this._maintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// The ID of the software set that is pending to be installed.
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
        /// The version of the software set that is pending to be installed.
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
        /// Gets and sets the property RegisteredDevicesCount. 
        /// <para>
        /// The number of devices registered to the environment.
        /// </para>
        /// </summary>
        public int RegisteredDevicesCount
        {
            get { return this._registeredDevicesCount.GetValueOrDefault(); }
            set { this._registeredDevicesCount = value; }
        }

        // Check to see if RegisteredDevicesCount property is set
        internal bool IsSetRegisteredDevicesCount()
        {
            return this._registeredDevicesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SoftwareSetComplianceStatus. 
        /// <para>
        /// Describes if the software currently installed on all devices in the environment is
        /// a supported version.
        /// </para>
        /// </summary>
        public EnvironmentSoftwareSetComplianceStatus SoftwareSetComplianceStatus
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
        /// Gets and sets the property SoftwareSetUpdateMode. 
        /// <para>
        /// An option to define which software updates to apply.
        /// </para>
        /// </summary>
        public SoftwareSetUpdateMode SoftwareSetUpdateMode
        {
            get { return this._softwareSetUpdateMode; }
            set { this._softwareSetUpdateMode = value; }
        }

        // Check to see if SoftwareSetUpdateMode property is set
        internal bool IsSetSoftwareSetUpdateMode()
        {
            return this._softwareSetUpdateMode != null;
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the device was updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}