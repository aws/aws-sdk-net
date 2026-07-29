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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Optional filters that restrict a search to a subset of the workspace's data.
    /// </summary>
    public partial class SearchFilters
    {
        private List<string> _datasetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<TimeInterval> _timeIntervals = AWSConfigs.InitializeCollections ? new List<TimeInterval>() : null;
        private List<string> _timeSeriesIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DatasetIds. 
        /// <para>
        /// Restricts the search to these datasets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> DatasetIds
        {
            get { return this._datasetIds; }
            set { this._datasetIds = value; }
        }

        // Check to see if DatasetIds property is set
        internal bool IsSetDatasetIds()
        {
            return this._datasetIds != null && (this._datasetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeIntervals. 
        /// <para>
        /// Restricts the search to these time intervals.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<TimeInterval> TimeIntervals
        {
            get { return this._timeIntervals; }
            set { this._timeIntervals = value; }
        }

        // Check to see if TimeIntervals property is set
        internal bool IsSetTimeIntervals()
        {
            return this._timeIntervals != null && (this._timeIntervals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesIds. 
        /// <para>
        /// Restricts the search to these time series.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> TimeSeriesIds
        {
            get { return this._timeSeriesIds; }
            set { this._timeSeriesIds = value; }
        }

        // Check to see if TimeSeriesIds property is set
        internal bool IsSetTimeSeriesIds()
        {
            return this._timeSeriesIds != null && (this._timeSeriesIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}