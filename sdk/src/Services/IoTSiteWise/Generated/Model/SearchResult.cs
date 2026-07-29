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
    /// A single matching segment of time-series data returned by a search.
    /// </summary>
    public partial class SearchResult
    {
        private string _datasetId;
        private TimeInNanos _endTimestamp;
        private float? _score;
        private string _searchId;
        private TimeInNanos _startTimestamp;
        private string _timeSeriesId;
        private TimeInNanos _topTimestamp;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The identifier of the dataset that contains the matching data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The end of the matching time-series segment, in nanoseconds since the Unix epoch.
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
        /// Gets and sets the property Score. 
        /// <para>
        /// The relevance score of this result. Higher scores indicate a stronger match.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public float? Score
        {
            get { return this._score; }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SearchId. 
        /// <para>
        /// The identifier of the search that produced this result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=23, Max=36)]
        public string SearchId
        {
            get { return this._searchId; }
            set { this._searchId = value; }
        }

        // Check to see if SearchId property is set
        internal bool IsSetSearchId()
        {
            return this._searchId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The start of the matching time-series segment, in nanoseconds since the Unix epoch.
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
        /// The identifier of the time series that contains the matching data.
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

        /// <summary>
        /// Gets and sets the property TopTimestamp. 
        /// <para>
        /// The timestamp of the most relevant point within the matching segment, in nanoseconds
        /// since the Unix epoch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeInNanos TopTimestamp
        {
            get { return this._topTimestamp; }
            set { this._topTimestamp = value; }
        }

        // Check to see if TopTimestamp property is set
        internal bool IsSetTopTimestamp()
        {
            return this._topTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace the search ran against.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}