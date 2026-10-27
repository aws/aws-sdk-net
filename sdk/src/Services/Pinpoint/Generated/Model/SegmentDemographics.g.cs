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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies demographic-based dimension settings for including or excluding endpoints
    /// from a segment. These settings derive from characteristics of endpoint devices, such
    /// as platform, make, and model.
    /// </summary>
    public partial class SegmentDemographics
    {
        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// The app version criteria for the segment.
        /// </para>
        /// </summary>
        public SetDimension AppVersion { get; set; }

        /// <summary>
        /// Checks to see if the AppVersion property is set.
        /// </summary>
        internal bool IsSetAppVersion() => this.AppVersion != null;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel criteria for the segment.
        /// </para>
        /// </summary>
        public SetDimension Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// The device type criteria for the segment.
        /// </para>
        /// </summary>
        public SetDimension DeviceType { get; set; }

        /// <summary>
        /// Checks to see if the DeviceType property is set.
        /// </summary>
        internal bool IsSetDeviceType() => this.DeviceType != null;

        /// <summary>
        /// Gets and sets the property Make. 
        /// <para>
        /// The device make criteria for the segment.
        /// </para>
        /// </summary>
        public SetDimension Make { get; set; }

        /// <summary>
        /// Checks to see if the Make property is set.
        /// </summary>
        internal bool IsSetMake() => this.Make != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The device model criteria for the segment.
        /// </para>
        /// </summary>
        public SetDimension Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The device platform criteria for the segment.
        /// </para>
        /// </summary>
        public SetDimension Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;
    }
}
