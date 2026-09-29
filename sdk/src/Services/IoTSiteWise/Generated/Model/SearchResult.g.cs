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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// A single matching segment of time-series data returned by a search.
    /// </summary>
    public partial class SearchResult
    {
        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The identifier of the dataset that contains the matching data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Checks to see if the DatasetId property is set.
        /// </summary>
        internal bool IsSetDatasetId() => this.DatasetId != null;

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The end of the matching time-series segment, in nanoseconds since the Unix epoch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeInNanos EndTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EndTimestamp property is set.
        /// </summary>
        internal bool IsSetEndTimestamp() => this.EndTimestamp != null;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The relevance score of this result. Higher scores indicate a stronger match.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public float? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;

        /// <summary>
        /// Gets and sets the property SearchId. 
        /// <para>
        /// The identifier of the search that produced this result.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 23, Max = 36)]
        public string SearchId { get; set; }

        /// <summary>
        /// Checks to see if the SearchId property is set.
        /// </summary>
        internal bool IsSetSearchId() => this.SearchId != null;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The start of the matching time-series segment, in nanoseconds since the Unix epoch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeInNanos StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp != null;

        /// <summary>
        /// Gets and sets the property TimeSeriesId. 
        /// <para>
        /// The identifier of the time series that contains the matching data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 73)]
        public string TimeSeriesId { get; set; }

        /// <summary>
        /// Checks to see if the TimeSeriesId property is set.
        /// </summary>
        internal bool IsSetTimeSeriesId() => this.TimeSeriesId != null;

        /// <summary>
        /// Gets and sets the property TopTimestamp. 
        /// <para>
        /// The timestamp of the most relevant point within the matching segment, in nanoseconds
        /// since the Unix epoch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeInNanos TopTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the TopTimestamp property is set.
        /// </summary>
        internal bool IsSetTopTimestamp() => this.TopTimestamp != null;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace the search ran against.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;
    }
}
