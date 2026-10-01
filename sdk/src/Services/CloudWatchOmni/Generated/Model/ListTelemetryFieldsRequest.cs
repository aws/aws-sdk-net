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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Container for the parameters to the ListTelemetryFields operation.
    /// Lists fields available for telemetry queries.
    /// 
    ///  
    /// <para>
    /// Returns a list of fields included in the specified dataset, granular to telemetry
    /// type. Returned field names reflect the exact stored casing and are case-sensitive
    /// when referenced in query expressions; the query engine does not normalize identifier
    /// case.
    /// </para>
    /// </summary>
    public partial class ListTelemetryFieldsRequest : AmazonCloudWatchOmniRequest
    {
        private string _dataSetName;
        private DateTime? _endTime;
        private string _nextToken;
        private DateTime? _startTime;
        private TelemetryType _telemetryType;

        /// <summary>
        /// Gets and sets the property DataSetName. 
        /// <para>
        /// The name of the dataset to list fields for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DataSetName
        {
            get { return this._dataSetName; }
            set { this._dataSetName = value; }
        }

        // Check to see if DataSetName property is set
        internal bool IsSetDataSetName()
        {
            return this._dataSetName != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Inclusive end of the lookback window. When omitted, the service defaults to the current
        /// time.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to retrieve the next page of results. Reserved for future pagination; the
        /// service does not paginate at this time and returns null.
        /// </para>
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Inclusive start of the lookback window. When omitted, the service defaults to the
        /// configured lookback before endTime.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TelemetryType. 
        /// <para>
        /// The type of telemetry to filter fields by.
        /// </para>
        /// </summary>
        public TelemetryType TelemetryType
        {
            get { return this._telemetryType; }
            set { this._telemetryType = value; }
        }

        // Check to see if TelemetryType property is set
        internal bool IsSetTelemetryType()
        {
            return this._telemetryType != null;
        }

    }
}