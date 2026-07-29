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
    /// Contains summary information about a data segment, including its source dataset, time
    /// series, timestamp range, and enrichment status.
    /// </summary>
    public partial class DataSegmentSummary
    {
        private string _alias;
        private PropertyDataType _dataType;
        private TimeInNanos _endTimestamp;
        private DataSegmentEnrichment _enrichment;
        private string _sourceDatasetId;
        private TimeInNanos _startTimestamp;
        private string _timeSeriesId;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias of the time series.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the time series.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PropertyDataType DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The nanosecond-precision end time of the data segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeInNanos EndTimestamp
        {
            get { return this._endTimestamp; }
            set { this._endTimestamp = value; }
        }

        // Check to see if EndTimestamp property is set
        internal bool IsSetEndTimestamp()
        {
            return this._endTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property Enrichment. 
        /// <para>
        /// The enrichment information for the data segment.
        /// </para>
        /// </summary>
        public DataSegmentEnrichment Enrichment
        {
            get { return this._enrichment; }
            set { this._enrichment = value; }
        }

        // Check to see if Enrichment property is set
        internal bool IsSetEnrichment()
        {
            return this._enrichment != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDatasetId. 
        /// <para>
        /// The ID of the source dataset that contains the data segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string SourceDatasetId
        {
            get { return this._sourceDatasetId; }
            set { this._sourceDatasetId = value; }
        }

        // Check to see if SourceDatasetId property is set
        internal bool IsSetSourceDatasetId()
        {
            return this._sourceDatasetId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The nanosecond-precision start time of the data segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeInNanos StartTimestamp
        {
            get { return this._startTimestamp; }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesId. 
        /// <para>
        /// The ID of the time series.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=73)]
        public string TimeSeriesId
        {
            get { return this._timeSeriesId; }
            set { this._timeSeriesId = value; }
        }

        // Check to see if TimeSeriesId property is set
        internal bool IsSetTimeSeriesId()
        {
            return this._timeSeriesId != null;
        }

    }
}