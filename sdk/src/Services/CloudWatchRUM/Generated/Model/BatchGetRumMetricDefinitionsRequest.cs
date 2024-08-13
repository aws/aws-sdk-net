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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
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
namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetRumMetricDefinitions operation.
    /// Retrieves the list of metrics and dimensions that a RUM app monitor is sending to
    /// a single destination.
    /// </summary>
    public partial class BatchGetRumMetricDefinitionsRequest : AmazonCloudWatchRUMRequest
    {
        private string _appMonitorName;
        private MetricDestination _destination;
        private string _destinationArn;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AppMonitorName. 
        /// <para>
        /// The name of the CloudWatch RUM app monitor that is sending the metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AppMonitorName
        {
            get { return this._appMonitorName; }
            set { this._appMonitorName = value; }
        }

        // Check to see if AppMonitorName property is set
        internal bool IsSetAppMonitorName()
        {
            return this._appMonitorName != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The type of destination that you want to view metrics for. Valid values are <c>CloudWatch</c>
        /// and <c>Evidently</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// This parameter is required if <c>Destination</c> is <c>Evidently</c>. If <c>Destination</c>
        /// is <c>CloudWatch</c>, do not use this parameter.
        /// </para>
        ///  
        /// <para>
        /// This parameter specifies the ARN of the Evidently experiment that corresponds to the
        /// destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in one operation. The default is 50. The maximum
        /// that you can specify is 100.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the remaining results, make another call with the returned <c>NextToken</c>
        /// value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Use the token returned by the previous operation to request the next page of results.
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