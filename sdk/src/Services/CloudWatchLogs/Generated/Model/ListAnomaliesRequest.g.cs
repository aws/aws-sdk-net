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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the ListAnomalies operation. Returns a list of anomalies
    /// that log anomaly detectors have found. For details about the structure format of each
    /// anomaly object that is returned, see the example in this section.
    /// </summary>
    public partial class ListAnomaliesRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// Use this to optionally limit the results to only the anomalies found by a certain
        /// anomaly detector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string AnomalyDetectorArn { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyDetectorArn property is set.
        /// </summary>
        internal bool IsSetAnomalyDetectorArn() => this.AnomalyDetectorArn != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items to return. If you don't specify a value, the default maximum
        /// value of 50 items is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SuppressionState. 
        /// <para>
        /// You can specify this parameter if you want to the operation to return only anomalies
        /// that are currently either suppressed or unsuppressed.
        /// </para>
        /// </summary>
        public SuppressionState SuppressionState { get; set; }

        /// <summary>
        /// Checks to see if the SuppressionState property is set.
        /// </summary>
        internal bool IsSetSuppressionState() => this.SuppressionState != null;
    }
}
