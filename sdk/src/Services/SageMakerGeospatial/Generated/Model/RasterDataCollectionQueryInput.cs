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
    public partial class RasterDataCollectionQueryInput
    {
        private AreaOfInterest _areaOfInterest;
        private PropertyFilters _propertyFilters;
        private string _rasterDataCollectionArn;
        private TimeRangeFilterInput _timeRangeFilter;

        /// <summary>
        /// Gets and sets the property AreaOfInterest. 
        /// <para>
        /// The area of interest being queried for the raster data collection.
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
        /// Gets and sets the property PropertyFilters.
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
        /// Gets and sets the property RasterDataCollectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the raster data collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RasterDataCollectionArn
        {
            get { return this._rasterDataCollectionArn; }
            set { this._rasterDataCollectionArn = value; }
        }

        // Check to see if RasterDataCollectionArn property is set
        internal bool IsSetRasterDataCollectionArn()
        {
            return this._rasterDataCollectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property TimeRangeFilter.
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