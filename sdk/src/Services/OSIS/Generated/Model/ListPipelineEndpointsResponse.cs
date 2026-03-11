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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
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
namespace Amazon.OSIS.Model
{
    /// <summary>
    /// This is the response object from the ListPipelineEndpoints operation.
    /// </summary>
    public partial class ListPipelineEndpointsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PipelineEndpoint> _pipelineEndpoints = AWSConfigs.InitializeCollections ? new List<PipelineEndpoint>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When <c>NextToken</c> is returned, there are more results available. The value of
        /// <c>NextToken</c> is a unique pagination token for each page. Make the call again using
        /// the returned token to retrieve the next page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3000)]
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
        /// Gets and sets the property PipelineEndpoints. 
        /// <para>
        /// A list of pipeline endpoints.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PipelineEndpoint> PipelineEndpoints
        {
            get { return this._pipelineEndpoints; }
            set { this._pipelineEndpoints = value; }
        }

        // Check to see if PipelineEndpoints property is set
        internal bool IsSetPipelineEndpoints()
        {
            return this._pipelineEndpoints != null && (this._pipelineEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}