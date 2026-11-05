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
    /// The output structure contains the Raster Data Collection Query input along with some
    /// additional metadata.
    /// </summary>
    public partial class RasterDataCollectionQueryOutput
    {
        /// <summary>
        /// Gets and sets the property AreaOfInterest. 
        /// <para>
        /// The Area of Interest used in the search.
        /// </para>
        /// </summary>
        public AreaOfInterest AreaOfInterest { get; set; }

        /// <summary>
        /// Checks to see if the AreaOfInterest property is set.
        /// </summary>
        internal bool IsSetAreaOfInterest() => this.AreaOfInterest != null;

        /// <summary>
        /// Gets and sets the property PropertyFilters. 
        /// <para>
        /// Property filters used in the search.
        /// </para>
        /// </summary>
        public PropertyFilters PropertyFilters { get; set; }

        /// <summary>
        /// Checks to see if the PropertyFilters property is set.
        /// </summary>
        internal bool IsSetPropertyFilters() => this.PropertyFilters != null;

        /// <summary>
        /// Gets and sets the property RasterDataCollectionArn. 
        /// <para>
        /// The ARN of the Raster Data Collection against which the search is done.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RasterDataCollectionArn { get; set; }

        /// <summary>
        /// Checks to see if the RasterDataCollectionArn property is set.
        /// </summary>
        internal bool IsSetRasterDataCollectionArn() => this.RasterDataCollectionArn != null;

        /// <summary>
        /// Gets and sets the property RasterDataCollectionName. 
        /// <para>
        /// The name of the raster data collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RasterDataCollectionName { get; set; }

        /// <summary>
        /// Checks to see if the RasterDataCollectionName property is set.
        /// </summary>
        internal bool IsSetRasterDataCollectionName() => this.RasterDataCollectionName != null;

        /// <summary>
        /// Gets and sets the property TimeRangeFilter. 
        /// <para>
        /// The TimeRange filter used in the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public TimeRangeFilterOutput TimeRangeFilter { get; set; }

        /// <summary>
        /// Checks to see if the TimeRangeFilter property is set.
        /// </summary>
        internal bool IsSetTimeRangeFilter() => this.TimeRangeFilter != null;
    }
}
