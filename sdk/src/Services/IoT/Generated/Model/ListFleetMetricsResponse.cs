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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the ListFleetMetrics operation.
    /// </summary>
    public partial class ListFleetMetricsResponse : AmazonWebServiceResponse
    {
        private List<FleetMetricNameAndArn> _fleetMetrics = AWSConfigs.InitializeCollections ? new List<FleetMetricNameAndArn>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FleetMetrics. 
        /// <para>
        /// The list of fleet metrics objects.
        /// </para>
        /// </summary>
        public List<FleetMetricNameAndArn> FleetMetrics
        {
            get { return this._fleetMetrics; }
            set { this._fleetMetrics = value; }
        }

        // Check to see if FleetMetrics property is set
        internal bool IsSetFleetMetrics()
        {
            return this._fleetMetrics != null && (this._fleetMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Will not be returned if the operation has returned
        /// all results.
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