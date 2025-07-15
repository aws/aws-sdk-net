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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the ListPipelineVersions operation.
    /// </summary>
    public partial class ListPipelineVersionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PipelineVersionSummary> _pipelineVersionSummaries = AWSConfigs.InitializeCollections ? new List<PipelineVersionSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result of the previous <c>ListPipelineVersions</c> request was truncated, the
        /// response includes a <c>NextToken</c>. To retrieve the next set of pipeline versions,
        /// use this token in your next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
        /// Gets and sets the property PipelineVersionSummaries. 
        /// <para>
        /// Contains a sorted list of pipeline version summary objects matching the specified
        /// filters. Each version summary includes the pipeline version ID, the creation date,
        /// and the last pipeline execution created from that version. This list can be empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<PipelineVersionSummary> PipelineVersionSummaries
        {
            get { return this._pipelineVersionSummaries; }
            set { this._pipelineVersionSummaries = value; }
        }

        // Check to see if PipelineVersionSummaries property is set
        internal bool IsSetPipelineVersionSummaries()
        {
            return this._pipelineVersionSummaries != null && (this._pipelineVersionSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}