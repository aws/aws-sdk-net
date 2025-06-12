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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This is the response object from the GetMetricData operation.
    /// </summary>
    public partial class GetMetricDataResponse : AmazonWebServiceResponse
    {
        private List<MessageData> _messages = AWSConfigs.InitializeCollections ? new List<MessageData>() : null;
        private List<MetricDataResult> _metricDataResults = AWSConfigs.InitializeCollections ? new List<MetricDataResult>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// Contains a message about this <c>GetMetricData</c> operation, if the operation results
        /// in such a message. An example of a message that might be returned is <c>Maximum number
        /// of allowed metrics exceeded</c>. If there is a message, as much of the operation as
        /// possible is still executed.
        /// </para>
        ///  
        /// <para>
        /// A message appears here only if it is related to the global <c>GetMetricData</c> operation.
        /// Any message about a specific metric returned by the operation appears in the <c>MetricDataResult</c>
        /// object returned for that metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MessageData> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && (this._messages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricDataResults. 
        /// <para>
        /// The metrics that are returned, including the metric name, namespace, and dimensions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricDataResult> MetricDataResults
        {
            get { return this._metricDataResults; }
            set { this._metricDataResults = value; }
        }

        // Check to see if MetricDataResults property is set
        internal bool IsSetMetricDataResults()
        {
            return this._metricDataResults != null && (this._metricDataResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that marks the next batch of returned results.
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

    }
}