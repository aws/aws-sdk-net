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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// An application instance's state.
    /// </summary>
    public partial class ReportedRuntimeContextState
    {
        private DesiredState _desiredState;
        private DeviceReportedStatus _deviceReportedStatus;
        private DateTime? _deviceReportedTime;
        private string _runtimeContextName;

        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// The application's desired state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DesiredState DesiredState
        {
            get { return this._desiredState; }
            set { this._desiredState = value; }
        }

        // Check to see if DesiredState property is set
        internal bool IsSetDesiredState()
        {
            return this._desiredState != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceReportedStatus. 
        /// <para>
        /// The application's reported status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeviceReportedStatus DeviceReportedStatus
        {
            get { return this._deviceReportedStatus; }
            set { this._deviceReportedStatus = value; }
        }

        // Check to see if DeviceReportedStatus property is set
        internal bool IsSetDeviceReportedStatus()
        {
            return this._deviceReportedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceReportedTime. 
        /// <para>
        /// When the device reported the application's state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? DeviceReportedTime
        {
            get { return this._deviceReportedTime; }
            set { this._deviceReportedTime = value; }
        }

        // Check to see if DeviceReportedTime property is set
        internal bool IsSetDeviceReportedTime()
        {
            return this._deviceReportedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuntimeContextName. 
        /// <para>
        /// The device's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string RuntimeContextName
        {
            get { return this._runtimeContextName; }
            set { this._runtimeContextName = value; }
        }

        // Check to see if RuntimeContextName property is set
        internal bool IsSetRuntimeContextName()
        {
            return this._runtimeContextName != null;
        }

    }
}