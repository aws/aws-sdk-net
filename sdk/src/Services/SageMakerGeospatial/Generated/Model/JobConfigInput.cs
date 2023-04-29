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
    /// The input structure for the JobConfig in an EarthObservationJob.
    /// </summary>
    public partial class JobConfigInput
    {
        private BandMathConfigInput _bandMathConfig;
        private CloudMaskingConfigInput _cloudMaskingConfig;
        private CloudRemovalConfigInput _cloudRemovalConfig;
        private GeoMosaicConfigInput _geoMosaicConfig;
        private LandCoverSegmentationConfigInput _landCoverSegmentationConfig;
        private ResamplingConfigInput _resamplingConfig;
        private StackConfigInput _stackConfig;
        private TemporalStatisticsConfigInput _temporalStatisticsConfig;
        private ZonalStatisticsConfigInput _zonalStatisticsConfig;

        /// <summary>
        /// Gets and sets the property BandMathConfig. 
        /// <para>
        /// An object containing information about the job configuration for BandMath.
        /// </para>
        /// </summary>
        public BandMathConfigInput BandMathConfig
        {
            get { return this._bandMathConfig; }
            set { this._bandMathConfig = value; }
        }

        // Check to see if BandMathConfig property is set
        internal bool IsSetBandMathConfig()
        {
            return this._bandMathConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CloudMaskingConfig. 
        /// <para>
        /// An object containing information about the job configuration for cloud masking.
        /// </para>
        /// </summary>
        public CloudMaskingConfigInput CloudMaskingConfig
        {
            get { return this._cloudMaskingConfig; }
            set { this._cloudMaskingConfig = value; }
        }

        // Check to see if CloudMaskingConfig property is set
        internal bool IsSetCloudMaskingConfig()
        {
            return this._cloudMaskingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CloudRemovalConfig. 
        /// <para>
        /// An object containing information about the job configuration for cloud removal.
        /// </para>
        /// </summary>
        public CloudRemovalConfigInput CloudRemovalConfig
        {
            get { return this._cloudRemovalConfig; }
            set { this._cloudRemovalConfig = value; }
        }

        // Check to see if CloudRemovalConfig property is set
        internal bool IsSetCloudRemovalConfig()
        {
            return this._cloudRemovalConfig != null;
        }

        /// <summary>
        /// Gets and sets the property GeoMosaicConfig. 
        /// <para>
        /// An object containing information about the job configuration for geomosaic.
        /// </para>
        /// </summary>
        public GeoMosaicConfigInput GeoMosaicConfig
        {
            get { return this._geoMosaicConfig; }
            set { this._geoMosaicConfig = value; }
        }

        // Check to see if GeoMosaicConfig property is set
        internal bool IsSetGeoMosaicConfig()
        {
            return this._geoMosaicConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LandCoverSegmentationConfig. 
        /// <para>
        /// An object containing information about the job configuration for land cover segmentation.
        /// </para>
        /// </summary>
        public LandCoverSegmentationConfigInput LandCoverSegmentationConfig
        {
            get { return this._landCoverSegmentationConfig; }
            set { this._landCoverSegmentationConfig = value; }
        }

        // Check to see if LandCoverSegmentationConfig property is set
        internal bool IsSetLandCoverSegmentationConfig()
        {
            return this._landCoverSegmentationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ResamplingConfig. 
        /// <para>
        /// An object containing information about the job configuration for resampling.
        /// </para>
        /// </summary>
        public ResamplingConfigInput ResamplingConfig
        {
            get { return this._resamplingConfig; }
            set { this._resamplingConfig = value; }
        }

        // Check to see if ResamplingConfig property is set
        internal bool IsSetResamplingConfig()
        {
            return this._resamplingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property StackConfig. 
        /// <para>
        /// An object containing information about the job configuration for a Stacking Earth
        /// Observation job.
        /// </para>
        /// </summary>
        public StackConfigInput StackConfig
        {
            get { return this._stackConfig; }
            set { this._stackConfig = value; }
        }

        // Check to see if StackConfig property is set
        internal bool IsSetStackConfig()
        {
            return this._stackConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TemporalStatisticsConfig. 
        /// <para>
        /// An object containing information about the job configuration for temporal statistics.
        /// </para>
        /// </summary>
        public TemporalStatisticsConfigInput TemporalStatisticsConfig
        {
            get { return this._temporalStatisticsConfig; }
            set { this._temporalStatisticsConfig = value; }
        }

        // Check to see if TemporalStatisticsConfig property is set
        internal bool IsSetTemporalStatisticsConfig()
        {
            return this._temporalStatisticsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ZonalStatisticsConfig. 
        /// <para>
        /// An object containing information about the job configuration for zonal statistics.
        /// </para>
        /// </summary>
        public ZonalStatisticsConfigInput ZonalStatisticsConfig
        {
            get { return this._zonalStatisticsConfig; }
            set { this._zonalStatisticsConfig = value; }
        }

        // Check to see if ZonalStatisticsConfig property is set
        internal bool IsSetZonalStatisticsConfig()
        {
            return this._zonalStatisticsConfig != null;
        }

    }
}