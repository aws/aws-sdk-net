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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Contains information about the analyzed metrics that displayed anomalous behavior.
    /// </summary>
    public partial class CloudWatchMetricsDataSummary
    {
        private CloudWatchMetricDataStatusCode _statusCode;
        private List<TimestampMetricValuePair> _timestampMetricValuePairList = AWSConfigs.InitializeCollections ? new List<TimestampMetricValuePair>() : null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// This is an enum of the status showing whether the metric value pair list has partial
        /// or complete data, or if there was an error.
        /// </para>
        /// </summary>
        public CloudWatchMetricDataStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampMetricValuePairList. 
        /// <para>
        /// This is a list of Amazon CloudWatch metric values at given timestamp.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TimestampMetricValuePair> TimestampMetricValuePairList
        {
            get { return this._timestampMetricValuePairList; }
            set { this._timestampMetricValuePairList = value; }
        }

        // Check to see if TimestampMetricValuePairList property is set
        internal bool IsSetTimestampMetricValuePairList()
        {
            return this._timestampMetricValuePairList != null && (this._timestampMetricValuePairList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}