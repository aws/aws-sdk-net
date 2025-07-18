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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// This is a RasterDataCollectionQueryInput containing AreaOfInterest, Time Range filter
    /// and Property filters.
    /// </summary>
    public partial class RasterDataCollectionQueryWithBandFilterInput
    {
        private AreaOfInterest _areaOfInterest;
        private List<string> _bandFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PropertyFilters _propertyFilters;
        private TimeRangeFilterInput _timeRangeFilter;

        /// <summary>
        /// Gets and sets the property AreaOfInterest. 
        /// <para>
        /// The Area of interest to be used in the search query.
        /// </para>
        /// </summary>
        public AreaOfInterest AreaOfInterest
        {
            get { return this._areaOfInterest; }
            set { this._areaOfInterest = value; }
        }

        // Check to see if AreaOfInterest property is set
        internal bool IsSetAreaOfInterest()
        {
            return this._areaOfInterest != null;
        }

        /// <summary>
        /// Gets and sets the property BandFilter. 
        /// <para>
        /// The list of Bands to be displayed in the result for each item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> BandFilter
        {
            get { return this._bandFilter; }
            set { this._bandFilter = value; }
        }

        // Check to see if BandFilter property is set
        internal bool IsSetBandFilter()
        {
            return this._bandFilter != null && (this._bandFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PropertyFilters. 
        /// <para>
        /// The Property Filters used in the search query.
        /// </para>
        /// </summary>
        public PropertyFilters PropertyFilters
        {
            get { return this._propertyFilters; }
            set { this._propertyFilters = value; }
        }

        // Check to see if PropertyFilters property is set
        internal bool IsSetPropertyFilters()
        {
            return this._propertyFilters != null;
        }

        /// <summary>
        /// Gets and sets the property TimeRangeFilter. 
        /// <para>
        /// The TimeRange Filter used in the search query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public TimeRangeFilterInput TimeRangeFilter
        {
            get { return this._timeRangeFilter; }
            set { this._timeRangeFilter = value; }
        }

        // Check to see if TimeRangeFilter property is set
        internal bool IsSetTimeRangeFilter()
        {
            return this._timeRangeFilter != null;
        }

    }
}