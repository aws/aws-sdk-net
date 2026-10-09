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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Container for the parameters to the ListTelemetryFields operation. Lists fields available
    /// for telemetry queries. Returns a list of fields included in the specified dataset,
    /// granular to telemetry type. Returned field names reflect the exact stored casing and
    /// are case-sensitive when referenced in query expressions; the query engine does not
    /// normalize identifier case.
    /// </summary>
    public partial class ListTelemetryFieldsRequest : AmazonCloudWatchOmniRequest
    {
        /// <summary>
        /// Gets and sets the property DataSetName. The name of the dataset to list fields for.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string DataSetName { get; set; }

        /// <summary>
        /// Checks to see if the DataSetName property is set.
        /// </summary>
        internal bool IsSetDataSetName() => this.DataSetName != null;

        /// <summary>
        /// Gets and sets the property EndTime. Inclusive end of the lookback window. When omitted,
        /// the service defaults to the current time.
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. A token to retrieve the next page of results.
        /// Reserved for future pagination; the service does not paginate at this time and returns
        /// null.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartTime. Inclusive start of the lookback window. When
        /// omitted, the service defaults to the configured lookback before endTime.
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TelemetryType. The type of telemetry to filter fields by.
        /// </summary>
        public TelemetryType TelemetryType { get; set; }

        /// <summary>
        /// Checks to see if the TelemetryType property is set.
        /// </summary>
        internal bool IsSetTelemetryType() => this.TelemetryType != null;
    }
}
