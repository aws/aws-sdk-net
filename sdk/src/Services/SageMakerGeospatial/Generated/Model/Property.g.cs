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
    /// Represents a single searchable property to search on.
    /// </summary>
    public partial class Property
    {
        /// <summary>
        /// Gets and sets the property EoCloudCover. 
        /// <para>
        /// The structure representing EoCloudCover property filter containing a lower bound and
        /// upper bound.
        /// </para>
        /// </summary>
        public EoCloudCoverInput EoCloudCover { get; set; }

        /// <summary>
        /// Checks to see if the EoCloudCover property is set.
        /// </summary>
        internal bool IsSetEoCloudCover() => this.EoCloudCover != null;

        /// <summary>
        /// Gets and sets the property LandsatCloudCoverLand. 
        /// <para>
        /// The structure representing Land Cloud Cover property filter for Landsat collection
        /// containing a lower bound and upper bound.
        /// </para>
        /// </summary>
        public LandsatCloudCoverLandInput LandsatCloudCoverLand { get; set; }

        /// <summary>
        /// Checks to see if the LandsatCloudCoverLand property is set.
        /// </summary>
        internal bool IsSetLandsatCloudCoverLand() => this.LandsatCloudCoverLand != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The structure representing Platform property filter consisting of value and comparison
        /// operator.
        /// </para>
        /// </summary>
        public PlatformInput Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property ViewOffNadir. 
        /// <para>
        /// The structure representing ViewOffNadir property filter containing a lower bound and
        /// upper bound.
        /// </para>
        /// </summary>
        public ViewOffNadirInput ViewOffNadir { get; set; }

        /// <summary>
        /// Checks to see if the ViewOffNadir property is set.
        /// </summary>
        internal bool IsSetViewOffNadir() => this.ViewOffNadir != null;

        /// <summary>
        /// Gets and sets the property ViewSunAzimuth. 
        /// <para>
        /// The structure representing ViewSunAzimuth property filter containing a lower bound
        /// and upper bound.
        /// </para>
        /// </summary>
        public ViewSunAzimuthInput ViewSunAzimuth { get; set; }

        /// <summary>
        /// Checks to see if the ViewSunAzimuth property is set.
        /// </summary>
        internal bool IsSetViewSunAzimuth() => this.ViewSunAzimuth != null;

        /// <summary>
        /// Gets and sets the property ViewSunElevation. 
        /// <para>
        /// The structure representing ViewSunElevation property filter containing a lower bound
        /// and upper bound.
        /// </para>
        /// </summary>
        public ViewSunElevationInput ViewSunElevation { get; set; }

        /// <summary>
        /// Checks to see if the ViewSunElevation property is set.
        /// </summary>
        internal bool IsSetViewSunElevation() => this.ViewSunElevation != null;
    }
}
