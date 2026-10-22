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
    /// This is a RasterDataCollectionQueryInput containing AreaOfInterest, Time Range filter
    /// and Property filters.
    /// </summary>
    public partial class RasterDataCollectionQueryWithBandFilterInput
    {
        /// <summary>
        /// Gets and sets the property AreaOfInterest. 
        /// <para>
        /// The Area of interest to be used in the search query.
        /// </para>
        /// </summary>
        public AreaOfInterest AreaOfInterest { get; set; }

        /// <summary>
        /// Checks to see if the AreaOfInterest property is set.
        /// </summary>
        internal bool IsSetAreaOfInterest() => this.AreaOfInterest != null;

        /// <summary>
        /// Gets and sets the property BandFilter. 
        /// <para>
        /// The list of Bands to be displayed in the result for each item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> BandFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BandFilter property is set.
        /// </summary>
        internal bool IsSetBandFilter() => this.BandFilter != null && (this.BandFilter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PropertyFilters. 
        /// <para>
        /// The Property Filters used in the search query.
        /// </para>
        /// </summary>
        public PropertyFilters PropertyFilters { get; set; }

        /// <summary>
        /// Checks to see if the PropertyFilters property is set.
        /// </summary>
        internal bool IsSetPropertyFilters() => this.PropertyFilters != null;

        /// <summary>
        /// Gets and sets the property TimeRangeFilter. 
        /// <para>
        /// The TimeRange Filter used in the search query.
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
