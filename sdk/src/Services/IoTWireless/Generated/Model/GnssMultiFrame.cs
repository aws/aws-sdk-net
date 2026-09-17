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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Global navigation satellite system (GNSS) multi-frame object used for positioning.
    /// Contains multiple GNSS scan captures that are combined by the solver.
    /// </summary>
    public partial class GnssMultiFrame
    {
        private float? _assistAltitude;
        private List<float> _assistPosition = AWSConfigs.InitializeCollections ? new List<float>() : null;
        private List<GnssCapture> _captures = AWSConfigs.InitializeCollections ? new List<GnssCapture>() : null;
        private float? _captureTimeAccuracy;
        private bool? _use2DSolver;

        /// <summary>
        /// Gets and sets the property AssistAltitude. 
        /// <para>
        /// Optional assistance altitude, which is the altitude of the device at capture time,
        /// specified in meters above the WGS84 reference ellipsoid. This parameter is required
        /// when Use2DSolver is enabled.
        /// </para>
        /// </summary>
        public float? AssistAltitude
        {
            get { return this._assistAltitude; }
            set { this._assistAltitude = value; }
        }

        // Check to see if AssistAltitude property is set
        internal bool IsSetAssistAltitude()
        {
            return this._assistAltitude.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssistPosition. 
        /// <para>
        /// Optional assistance position information, specified using latitude and longitude values
        /// in degrees. The coordinates are inside the WGS84 reference frame.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public List<float> AssistPosition
        {
            get { return this._assistPosition; }
            set { this._assistPosition = value; }
        }

        // Check to see if AssistPosition property is set
        internal bool IsSetAssistPosition()
        {
            return this._assistPosition != null && (this._assistPosition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Captures. 
        /// <para>
        /// List of GNSS scan captures. Each capture contains a payload from a single GNSS scan.
        /// The number of captures must be 2, 4, 8, 16, or 32.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=32)]
        public List<GnssCapture> Captures
        {
            get { return this._captures; }
            set { this._captures = value; }
        }

        // Check to see if Captures property is set
        internal bool IsSetCaptures()
        {
            return this._captures != null && (this._captures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CaptureTimeAccuracy. 
        /// <para>
        /// Optional value that gives the capture time estimate accuracy, in seconds. If capture
        /// time accuracy is not specified, default value of 300 is used.
        /// </para>
        /// </summary>
        public float? CaptureTimeAccuracy
        {
            get { return this._captureTimeAccuracy; }
            set { this._captureTimeAccuracy = value; }
        }

        // Check to see if CaptureTimeAccuracy property is set
        internal bool IsSetCaptureTimeAccuracy()
        {
            return this._captureTimeAccuracy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Use2DSolver. 
        /// <para>
        /// Optional parameter that forces 2D solve, which modifies the positioning algorithm
        /// to a 2D solution problem. When this parameter is specified, the assistance altitude
        /// should have an accuracy of at least 10 meters.
        /// </para>
        /// </summary>
        public bool? Use2DSolver
        {
            get { return this._use2DSolver; }
            set { this._use2DSolver = value; }
        }

        // Check to see if Use2DSolver property is set
        internal bool IsSetUse2DSolver()
        {
            return this._use2DSolver.HasValue; 
        }

    }
}