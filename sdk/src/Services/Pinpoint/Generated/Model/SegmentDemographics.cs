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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies demographic-based dimension settings for including or excluding endpoints
    /// from a segment. These settings derive from characteristics of endpoint devices, such
    /// as platform, make, and model.
    /// </summary>
    public partial class SegmentDemographics
    {
        private SetDimension _appVersion;
        private SetDimension _channel;
        private SetDimension _deviceType;
        private SetDimension _make;
        private SetDimension _model;
        private SetDimension _platform;

        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// The app version criteria for the segment.
        /// </para>
        /// </summary>
        public SetDimension AppVersion
        {
            get { return this._appVersion; }
            set { this._appVersion = value; }
        }

        // Check to see if AppVersion property is set
        internal bool IsSetAppVersion()
        {
            return this._appVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel criteria for the segment.
        /// </para>
        /// </summary>
        public SetDimension Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// The device type criteria for the segment.
        /// </para>
        /// </summary>
        public SetDimension DeviceType
        {
            get { return this._deviceType; }
            set { this._deviceType = value; }
        }

        // Check to see if DeviceType property is set
        internal bool IsSetDeviceType()
        {
            return this._deviceType != null;
        }

        /// <summary>
        /// Gets and sets the property Make. 
        /// <para>
        /// The device make criteria for the segment.
        /// </para>
        /// </summary>
        public SetDimension Make
        {
            get { return this._make; }
            set { this._make = value; }
        }

        // Check to see if Make property is set
        internal bool IsSetMake()
        {
            return this._make != null;
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The device model criteria for the segment.
        /// </para>
        /// </summary>
        public SetDimension Model
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
        /// Gets and sets the property Platform. 
        /// <para>
        /// The device platform criteria for the segment.
        /// </para>
        /// </summary>
        public SetDimension Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

    }
}