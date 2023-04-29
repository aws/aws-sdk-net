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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// Represents a single searchable property to search on.
    /// </summary>
    public partial class Property
    {
        private EoCloudCoverInput _eoCloudCover;
        private LandsatCloudCoverLandInput _landsatCloudCoverLand;
        private PlatformInput _platform;
        private ViewOffNadirInput _viewOffNadir;
        private ViewSunAzimuthInput _viewSunAzimuth;
        private ViewSunElevationInput _viewSunElevation;

        /// <summary>
        /// Gets and sets the property EoCloudCover. 
        /// <para>
        /// The structure representing EoCloudCover property filter containing a lower bound and
        /// upper bound.
        /// </para>
        /// </summary>
        public EoCloudCoverInput EoCloudCover
        {
            get { return this._eoCloudCover; }
            set { this._eoCloudCover = value; }
        }

        // Check to see if EoCloudCover property is set
        internal bool IsSetEoCloudCover()
        {
            return this._eoCloudCover != null;
        }

        /// <summary>
        /// Gets and sets the property LandsatCloudCoverLand. 
        /// <para>
        /// The structure representing Land Cloud Cover property filter for Landsat collection
        /// containing a lower bound and upper bound.
        /// </para>
        /// </summary>
        public LandsatCloudCoverLandInput LandsatCloudCoverLand
        {
            get { return this._landsatCloudCoverLand; }
            set { this._landsatCloudCoverLand = value; }
        }

        // Check to see if LandsatCloudCoverLand property is set
        internal bool IsSetLandsatCloudCoverLand()
        {
            return this._landsatCloudCoverLand != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The structure representing Platform property filter consisting of value and comparison
        /// operator.
        /// </para>
        /// </summary>
        public PlatformInput Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property ViewOffNadir. 
        /// <para>
        /// The structure representing ViewOffNadir property filter containing a lower bound and
        /// upper bound.
        /// </para>
        /// </summary>
        public ViewOffNadirInput ViewOffNadir
        {
            get { return this._viewOffNadir; }
            set { this._viewOffNadir = value; }
        }

        // Check to see if ViewOffNadir property is set
        internal bool IsSetViewOffNadir()
        {
            return this._viewOffNadir != null;
        }

        /// <summary>
        /// Gets and sets the property ViewSunAzimuth. 
        /// <para>
        /// The structure representing ViewSunAzimuth property filter containing a lower bound
        /// and upper bound.
        /// </para>
        /// </summary>
        public ViewSunAzimuthInput ViewSunAzimuth
        {
            get { return this._viewSunAzimuth; }
            set { this._viewSunAzimuth = value; }
        }

        // Check to see if ViewSunAzimuth property is set
        internal bool IsSetViewSunAzimuth()
        {
            return this._viewSunAzimuth != null;
        }

        /// <summary>
        /// Gets and sets the property ViewSunElevation. 
        /// <para>
        /// The structure representing ViewSunElevation property filter containing a lower bound
        /// and upper bound.
        /// </para>
        /// </summary>
        public ViewSunElevationInput ViewSunElevation
        {
            get { return this._viewSunElevation; }
            set { this._viewSunElevation = value; }
        }

        // Check to see if ViewSunElevation property is set
        internal bool IsSetViewSunElevation()
        {
            return this._viewSunElevation != null;
        }

    }
}