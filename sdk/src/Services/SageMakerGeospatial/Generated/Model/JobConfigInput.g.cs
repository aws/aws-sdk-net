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
    /// The input structure for the JobConfig in an EarthObservationJob.
    /// </summary>
    public partial class JobConfigInput
    {
        /// <summary>
        /// Gets and sets the property BandMathConfig. 
        /// <para>
        /// An object containing information about the job configuration for BandMath.
        /// </para>
        /// </summary>
        public BandMathConfigInput BandMathConfig { get; set; }

        /// <summary>
        /// Checks to see if the BandMathConfig property is set.
        /// </summary>
        internal bool IsSetBandMathConfig() => this.BandMathConfig != null;

        /// <summary>
        /// Gets and sets the property CloudMaskingConfig. 
        /// <para>
        /// An object containing information about the job configuration for cloud masking.
        /// </para>
        /// </summary>
        public CloudMaskingConfigInput CloudMaskingConfig { get; set; }

        /// <summary>
        /// Checks to see if the CloudMaskingConfig property is set.
        /// </summary>
        internal bool IsSetCloudMaskingConfig() => this.CloudMaskingConfig != null;

        /// <summary>
        /// Gets and sets the property CloudRemovalConfig. 
        /// <para>
        /// An object containing information about the job configuration for cloud removal.
        /// </para>
        /// </summary>
        public CloudRemovalConfigInput CloudRemovalConfig { get; set; }

        /// <summary>
        /// Checks to see if the CloudRemovalConfig property is set.
        /// </summary>
        internal bool IsSetCloudRemovalConfig() => this.CloudRemovalConfig != null;

        /// <summary>
        /// Gets and sets the property GeoMosaicConfig. 
        /// <para>
        /// An object containing information about the job configuration for geomosaic.
        /// </para>
        /// </summary>
        public GeoMosaicConfigInput GeoMosaicConfig { get; set; }

        /// <summary>
        /// Checks to see if the GeoMosaicConfig property is set.
        /// </summary>
        internal bool IsSetGeoMosaicConfig() => this.GeoMosaicConfig != null;

        /// <summary>
        /// Gets and sets the property LandCoverSegmentationConfig. 
        /// <para>
        /// An object containing information about the job configuration for land cover segmentation.
        /// </para>
        /// </summary>
        public LandCoverSegmentationConfigInput LandCoverSegmentationConfig { get; set; }

        /// <summary>
        /// Checks to see if the LandCoverSegmentationConfig property is set.
        /// </summary>
        internal bool IsSetLandCoverSegmentationConfig() => this.LandCoverSegmentationConfig != null;

        /// <summary>
        /// Gets and sets the property ResamplingConfig. 
        /// <para>
        /// An object containing information about the job configuration for resampling.
        /// </para>
        /// </summary>
        public ResamplingConfigInput ResamplingConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResamplingConfig property is set.
        /// </summary>
        internal bool IsSetResamplingConfig() => this.ResamplingConfig != null;

        /// <summary>
        /// Gets and sets the property StackConfig. 
        /// <para>
        /// An object containing information about the job configuration for a Stacking Earth
        /// Observation job.
        /// </para>
        /// </summary>
        public StackConfigInput StackConfig { get; set; }

        /// <summary>
        /// Checks to see if the StackConfig property is set.
        /// </summary>
        internal bool IsSetStackConfig() => this.StackConfig != null;

        /// <summary>
        /// Gets and sets the property TemporalStatisticsConfig. 
        /// <para>
        /// An object containing information about the job configuration for temporal statistics.
        /// </para>
        /// </summary>
        public TemporalStatisticsConfigInput TemporalStatisticsConfig { get; set; }

        /// <summary>
        /// Checks to see if the TemporalStatisticsConfig property is set.
        /// </summary>
        internal bool IsSetTemporalStatisticsConfig() => this.TemporalStatisticsConfig != null;

        /// <summary>
        /// Gets and sets the property ZonalStatisticsConfig. 
        /// <para>
        /// An object containing information about the job configuration for zonal statistics.
        /// </para>
        /// </summary>
        public ZonalStatisticsConfigInput ZonalStatisticsConfig { get; set; }

        /// <summary>
        /// Checks to see if the ZonalStatisticsConfig property is set.
        /// </summary>
        internal bool IsSetZonalStatisticsConfig() => this.ZonalStatisticsConfig != null;
    }
}
