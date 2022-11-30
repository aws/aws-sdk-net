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
    /// This is a RasterDataCollectionQueryInput containing AreaOfInterest, Time Range filter
    /// and Property filters.
    /// </summary>
    public partial class RasterDataCollectionQueryWithBandFilterInput
    {
        private AreaOfInterest _areaOfInterest;
        private List<string> _bandFilter = new List<string>();
        private PropertyFilters _propertyFilters;
        private TimeRangeFilterInput _timeRangeFilter;

        /// <summary>
        /// Gets and sets the property AreaOfInterest.
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
            return this._bandFilter != null && this._bandFilter.Count > 0; 
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
        /// Gets and sets the property TimeRangeFilter.
        /// </summary>
        [AWSProperty(Required=true)]
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