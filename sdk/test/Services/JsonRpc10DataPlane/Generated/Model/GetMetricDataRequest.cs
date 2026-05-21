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
 * Do not modify this file. This file is generated from the jsonrpc10dataplane-1999-12-31.normal.json service model.
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
namespace Amazon.JsonRpc10DataPlane.Model
{
    /// <summary>
    /// Container for the parameters to the GetMetricData operation.
    /// <pre><c>As seen in Amazon CloudWatch </c></pre>
    /// </summary>
    public partial class GetMetricDataRequest : AmazonJsonRpc10DataPlaneRequest
    {
        private DateTime? _endTime;
        private LabelOptions _labelOptions;
        private int? _maxDatapoints;
        private List<MetricDataQuery> _metricDataQueries = AWSConfigs.InitializeCollections ? new List<MetricDataQuery>() : null;
        private string _nextToken;
        private ScanBy _scanBy;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LabelOptions.
        /// </summary>
        public LabelOptions LabelOptions
        {
            get { return this._labelOptions; }
            set { this._labelOptions = value; }
        }

        // Check to see if LabelOptions property is set
        internal bool IsSetLabelOptions()
        {
            return this._labelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property MaxDatapoints.
        /// </summary>
        public int? MaxDatapoints
        {
            get { return this._maxDatapoints; }
            set { this._maxDatapoints = value; }
        }

        // Check to see if MaxDatapoints property is set
        internal bool IsSetMaxDatapoints()
        {
            return this._maxDatapoints.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricDataQueries.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MetricDataQuery> MetricDataQueries
        {
            get { return this._metricDataQueries; }
            set { this._metricDataQueries = value; }
        }

        // Check to see if MetricDataQueries property is set
        internal bool IsSetMetricDataQueries()
        {
            return this._metricDataQueries != null && (this._metricDataQueries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ScanBy.
        /// </summary>
        public ScanBy ScanBy
        {
            get { return this._scanBy; }
            set { this._scanBy = value; }
        }

        // Check to see if ScanBy property is set
        internal bool IsSetScanBy()
        {
            return this._scanBy != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}