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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// This is the response object from the GetExperimentResults operation.
    /// </summary>
    public partial class GetExperimentResultsResponse : AmazonWebServiceResponse
    {
        private string _details;
        private List<ExperimentReport> _reports = AWSConfigs.InitializeCollections ? new List<ExperimentReport>() : null;
        private List<ExperimentResultsData> _resultsData = AWSConfigs.InitializeCollections ? new List<ExperimentResultsData>() : null;
        private List<DateTime> _timestamps = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// If the experiment doesn't yet have enough events to provide valid results, this field
        /// is returned with the message <c>Not enough events to generate results</c>. If there
        /// are enough events to provide valid results, this field is not returned.
        /// </para>
        /// </summary>
        public string Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property Reports. 
        /// <para>
        /// An array of structures that include the reports that you requested.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<ExperimentReport> Reports
        {
            get { return this._reports; }
            set { this._reports = value; }
        }

        // Check to see if Reports property is set
        internal bool IsSetReports()
        {
            return this._reports != null && (this._reports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResultsData. 
        /// <para>
        /// An array of structures that include experiment results including metric names and
        /// values. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<ExperimentResultsData> ResultsData
        {
            get { return this._resultsData; }
            set { this._resultsData = value; }
        }

        // Check to see if ResultsData property is set
        internal bool IsSetResultsData()
        {
            return this._resultsData != null && (this._resultsData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timestamps. 
        /// <para>
        /// The timestamps of each result returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100800)]
        public List<DateTime> Timestamps
        {
            get { return this._timestamps; }
            set { this._timestamps = value; }
        }

        // Check to see if Timestamps property is set
        internal bool IsSetTimestamps()
        {
            return this._timestamps != null && (this._timestamps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}