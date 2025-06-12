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
    /// Container for the parameters to the UpdateEnvironment operation.
    /// Updates an environment.
    /// </summary>
    public partial class UpdateEnvironmentRequest : AmazonWorkSpacesThinClientRequest
    {
        private string _desiredSoftwareSetId;
        private string _desktopArn;
        private string _desktopEndpoint;
        private Dictionary<string, string> _deviceCreationTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _id;
        private MaintenanceWindow _maintenanceWindow;
        private string _name;
        private SoftwareSetUpdateMode _softwareSetUpdateMode;
        private SoftwareSetUpdateSchedule _softwareSetUpdateSchedule;

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
        /// Secure Browser, or AppStream 2.0.
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
        /// Gets and sets the property DeviceCreationTags. 
        /// <para>
        /// A map of the key-value pairs of the tag or tags to assign to the newly created devices
        /// for this environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> DeviceCreationTags
        {
            get { return this._deviceCreationTags; }
            set { this._deviceCreationTags = value; }
        }

        // Check to see if DeviceCreationTags property is set
        internal bool IsSetDeviceCreationTags()
        {
            return this._deviceCreationTags != null && (this._deviceCreationTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the environment to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The name of the environment to update.
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

    }
}