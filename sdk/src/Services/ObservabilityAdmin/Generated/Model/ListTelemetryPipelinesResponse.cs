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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// This is the response object from the ListTelemetryPipelines operation.
    /// </summary>
    public partial class ListTelemetryPipelinesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TelemetryPipelineSummary> _pipelineSummaries = AWSConfigs.InitializeCollections ? new List<TelemetryPipelineSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to resume pagination of results.
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
        /// Gets and sets the property PipelineSummaries. 
        /// <para>
        /// A list of telemetry pipeline summaries containing key information about each pipeline.
        /// </para>
        /// </summary>
        public List<TelemetryPipelineSummary> PipelineSummaries
        {
            get { return this._pipelineSummaries; }
            set { this._pipelineSummaries = value; }
        }

        // Check to see if PipelineSummaries property is set
        internal bool IsSetPipelineSummaries()
        {
            return this._pipelineSummaries != null && (this._pipelineSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}