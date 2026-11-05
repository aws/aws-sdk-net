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

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// Properties associated with the Item.
    /// </summary>
    public partial class Properties
    {
        /// <summary>
        /// Gets and sets the property EoCloudCover. 
        /// <para>
        /// Estimate of cloud cover.
        /// </para>
        /// </summary>
        public float? EoCloudCover { get; set; }

        /// <summary>
        /// Checks to see if the EoCloudCover property is set.
        /// </summary>
        internal bool IsSetEoCloudCover() => this.EoCloudCover.HasValue;

        /// <summary>
        /// Gets and sets the property LandsatCloudCoverLand. 
        /// <para>
        /// Land cloud cover for Landsat Data Collection.
        /// </para>
        /// </summary>
        public float? LandsatCloudCoverLand { get; set; }

        /// <summary>
        /// Checks to see if the LandsatCloudCoverLand property is set.
        /// </summary>
        internal bool IsSetLandsatCloudCoverLand() => this.LandsatCloudCoverLand.HasValue;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// Platform property. Platform refers to the unique name of the specific platform the
        /// instrument is attached to. For satellites it is the name of the satellite, eg. landsat-8
        /// (Landsat-8), sentinel-2a.
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property ViewOffNadir. 
        /// <para>
        /// The angle from the sensor between nadir (straight down) and the scene center. Measured
        /// in degrees (0-90).
        /// </para>
        /// </summary>
        public float? ViewOffNadir { get; set; }

        /// <summary>
        /// Checks to see if the ViewOffNadir property is set.
        /// </summary>
        internal bool IsSetViewOffNadir() => this.ViewOffNadir.HasValue;

        /// <summary>
        /// Gets and sets the property ViewSunAzimuth. 
        /// <para>
        /// The sun azimuth angle. From the scene center point on the ground, this is the angle
        /// between truth north and the sun. Measured clockwise in degrees (0-360).
        /// </para>
        /// </summary>
        public float? ViewSunAzimuth { get; set; }

        /// <summary>
        /// Checks to see if the ViewSunAzimuth property is set.
        /// </summary>
        internal bool IsSetViewSunAzimuth() => this.ViewSunAzimuth.HasValue;

        /// <summary>
        /// Gets and sets the property ViewSunElevation. 
        /// <para>
        /// The sun elevation angle. The angle from the tangent of the scene center point to the
        /// sun. Measured from the horizon in degrees (-90-90). Negative values indicate the sun
        /// is below the horizon, e.g. sun elevation of -10° means the data was captured during
        /// <a href="https://www.timeanddate.com/astronomy/different-types-twilight.html">nautical
        /// twilight</a>.
        /// </para>
        /// </summary>
        public float? ViewSunElevation { get; set; }

        /// <summary>
        /// Checks to see if the ViewSunElevation property is set.
        /// </summary>
        internal bool IsSetViewSunElevation() => this.ViewSunElevation.HasValue;
    }
}
