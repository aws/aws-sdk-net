/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot1click-projects-2018-05-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT1ClickProjects.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateDeviceWithPlacement operation.
    /// Associates a physical device with a placement.
    /// </summary>
    public partial class AssociateDeviceWithPlacementRequest : AmazonIoT1ClickProjectsRequest
    {
        private string _deviceId;
        private string _deviceTemplateName;
        private string _placementName;
        private string _projectName;

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The ID of the physical device to be associated with the given placement in the project.
        /// Note that a mandatory 4 character prefix is required for all <code>deviceId</code>
        /// values.
        /// </para>
        /// </summary>
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceTemplateName. 
        /// <para>
        /// The device template name to associate with the device ID.
        /// </para>
        /// </summary>
        public string DeviceTemplateName
        {
            get { return this._deviceTemplateName; }
            set { this._deviceTemplateName = value; }
        }

        // Check to see if DeviceTemplateName property is set
        internal bool IsSetDeviceTemplateName()
        {
            return this._deviceTemplateName != null;
        }

        /// <summary>
        /// Gets and sets the property PlacementName. 
        /// <para>
        /// The name of the placement in which to associate the device.
        /// </para>
        /// </summary>
        public string PlacementName
        {
            get { return this._placementName; }
            set { this._placementName = value; }
        }

        // Check to see if PlacementName property is set
        internal bool IsSetPlacementName()
        {
            return this._placementName != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project containing the placement in which to associate the device.
        /// </para>
        /// </summary>
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

    }
}