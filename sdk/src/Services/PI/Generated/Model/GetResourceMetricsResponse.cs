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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
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
namespace Amazon.PI.Model
{
    /// <summary>
    /// This is the response object from the GetResourceMetrics operation.
    /// </summary>
    public partial class GetResourceMetricsResponse : AmazonWebServiceResponse
    {
        private DateTime? _alignedEndTime;
        private DateTime? _alignedStartTime;
        private string _identifier;
        private List<MetricKeyDataPoints> _metricList = AWSConfigs.InitializeCollections ? new List<MetricKeyDataPoints>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AlignedEndTime. 
        /// <para>
        /// The end time for the returned metrics, after alignment to a granular boundary (as
        /// specified by <c>PeriodInSeconds</c>). <c>AlignedEndTime</c> will be greater than or
        /// equal to the value of the user-specified <c>Endtime</c>.
        /// </para>
        /// </summary>
        public DateTime? AlignedEndTime
        {
            get { return this._alignedEndTime; }
            set { this._alignedEndTime = value; }
        }

        // Check to see if AlignedEndTime property is set
        internal bool IsSetAlignedEndTime()
        {
            return this._alignedEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AlignedStartTime. 
        /// <para>
        /// The start time for the returned metrics, after alignment to a granular boundary (as
        /// specified by <c>PeriodInSeconds</c>). <c>AlignedStartTime</c> will be less than or
        /// equal to the value of the user-specified <c>StartTime</c>.
        /// </para>
        /// </summary>
        public DateTime? AlignedStartTime
        {
            get { return this._alignedStartTime; }
            set { this._alignedStartTime = value; }
        }

        // Check to see if AlignedStartTime property is set
        internal bool IsSetAlignedStartTime()
        {
            return this._alignedStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// An immutable identifier for a data source that is unique for an Amazon Web Services
        /// Region. Performance Insights gathers metrics from this data source. In the console,
        /// the identifier is shown as <i>ResourceID</i>. When you call <c>DescribeDBInstances</c>,
        /// the identifier is returned as <c>DbiResourceId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property MetricList. 
        /// <para>
        /// An array of metric results, where each array element contains all of the data points
        /// for a particular dimension.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricKeyDataPoints> MetricList
        {
            get { return this._metricList; }
            set { this._metricList = value; }
        }

        // Check to see if MetricList property is set
        internal bool IsSetMetricList()
        {
            return this._metricList != null && (this._metricList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the token, up to the value specified
        /// by <c>MaxRecords</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}