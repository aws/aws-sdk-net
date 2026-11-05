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
    /// The input structure for Raster Data Collection Query containing the Area of Interest,
    /// TimeRange Filters, and Property Filters.
    /// </summary>
    public partial class RasterDataCollectionQueryInput
    {
        /// <summary>
        /// Gets and sets the property AreaOfInterest. 
        /// <para>
        /// The area of interest being queried for the raster data collection.
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
        /// The list of Property filters used in the Raster Data Collection Query.
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
        /// The Amazon Resource Name (ARN) of the raster data collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RasterDataCollectionArn { get; set; }

        /// <summary>
        /// Checks to see if the RasterDataCollectionArn property is set.
        /// </summary>
        internal bool IsSetRasterDataCollectionArn() => this.RasterDataCollectionArn != null;

        /// <summary>
        /// Gets and sets the property TimeRangeFilter. 
        /// <para>
        /// The TimeRange Filter used in the RasterDataCollection Query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public TimeRangeFilterInput TimeRangeFilter { get; set; }

        /// <summary>
        /// Checks to see if the TimeRangeFilter property is set.
        /// </summary>
        internal bool IsSetTimeRangeFilter() => this.TimeRangeFilter != null;
    }
}
