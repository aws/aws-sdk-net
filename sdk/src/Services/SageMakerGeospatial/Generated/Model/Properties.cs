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
    /// 
    /// </summary>
    public partial class Properties
    {
        private float? _eoCloudCover;
        private float? _landsatCloudCoverLand;
        private string _platform;
        private float? _viewOffNadir;
        private float? _viewSunAzimuth;
        private float? _viewSunElevation;

        /// <summary>
        /// Gets and sets the property EoCloudCover.
        /// </summary>
        public float EoCloudCover
        {
            get { return this._eoCloudCover.GetValueOrDefault(); }
            set { this._eoCloudCover = value; }
        }

        // Check to see if EoCloudCover property is set
        internal bool IsSetEoCloudCover()
        {
            return this._eoCloudCover.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LandsatCloudCoverLand.
        /// </summary>
        public float LandsatCloudCoverLand
        {
            get { return this._landsatCloudCoverLand.GetValueOrDefault(); }
            set { this._landsatCloudCoverLand = value; }
        }

        // Check to see if LandsatCloudCoverLand property is set
        internal bool IsSetLandsatCloudCoverLand()
        {
            return this._landsatCloudCoverLand.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Platform.
        /// </summary>
        public string Platform
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
        /// </summary>
        public float ViewOffNadir
        {
            get { return this._viewOffNadir.GetValueOrDefault(); }
            set { this._viewOffNadir = value; }
        }

        // Check to see if ViewOffNadir property is set
        internal bool IsSetViewOffNadir()
        {
            return this._viewOffNadir.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ViewSunAzimuth.
        /// </summary>
        public float ViewSunAzimuth
        {
            get { return this._viewSunAzimuth.GetValueOrDefault(); }
            set { this._viewSunAzimuth = value; }
        }

        // Check to see if ViewSunAzimuth property is set
        internal bool IsSetViewSunAzimuth()
        {
            return this._viewSunAzimuth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ViewSunElevation.
        /// </summary>
        public float ViewSunElevation
        {
            get { return this._viewSunElevation.GetValueOrDefault(); }
            set { this._viewSunElevation = value; }
        }

        // Check to see if ViewSunElevation property is set
        internal bool IsSetViewSunElevation()
        {
            return this._viewSunElevation.HasValue; 
        }

    }
}