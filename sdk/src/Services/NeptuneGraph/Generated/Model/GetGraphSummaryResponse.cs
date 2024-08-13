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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
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
namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// This is the response object from the GetGraphSummary operation.
    /// </summary>
    public partial class GetGraphSummaryResponse : AmazonWebServiceResponse
    {
        private GraphDataSummary _graphSummary;
        private DateTime? _lastStatisticsComputationTime;
        private string _version;

        /// <summary>
        /// Gets and sets the property GraphSummary. 
        /// <para>
        /// The graph summary.
        /// </para>
        /// </summary>
        public GraphDataSummary GraphSummary
        {
            get { return this._graphSummary; }
            set { this._graphSummary = value; }
        }

        // Check to see if GraphSummary property is set
        internal bool IsSetGraphSummary()
        {
            return this._graphSummary != null;
        }

        /// <summary>
        /// Gets and sets the property LastStatisticsComputationTime. 
        /// <para>
        /// The timestamp, in ISO 8601 format, of the time at which Neptune Analytics last computed
        /// statistics.
        /// </para>
        /// </summary>
        public DateTime? LastStatisticsComputationTime
        {
            get { return this._lastStatisticsComputationTime; }
            set { this._lastStatisticsComputationTime = value; }
        }

        // Check to see if LastStatisticsComputationTime property is set
        internal bool IsSetLastStatisticsComputationTime()
        {
            return this._lastStatisticsComputationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Display the version of this tool.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}