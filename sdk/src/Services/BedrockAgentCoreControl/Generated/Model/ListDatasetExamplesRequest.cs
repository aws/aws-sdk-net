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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the ListDatasetExamples operation.
    /// Returns paginated examples from the dataset.
    /// 
    ///  
    /// <para>
    /// <strong>Version-pinned pagination:</strong> The server embeds the resolved version
    /// in the <c>nextToken</c>. Once pagination begins, all subsequent pages are pinned to
    /// that version regardless of concurrent mutations or whether <c>datasetVersion</c> is
    /// passed on subsequent requests. The <c>datasetVersion</c> query parameter is only used
    /// for the first request (when <c>nextToken</c> is absent); if omitted, defaults to DRAFT.
    /// </para>
    ///  
    /// <para>
    /// <strong>State guard:</strong> Allowed for all statuses including DELETING.
    /// </para>
    /// </summary>
    public partial class ListDatasetExamplesRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _datasetId;
        private string _datasetVersion;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        ///  The unique identifier of the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetVersion. 
        /// <para>
        /// Version to paginate: &quot;DRAFT&quot; or a version number. Defaults to DRAFT if absent.
        /// Only used on the first request (when nextToken is absent). For subsequent pages, the
        /// version is extracted from the nextToken and this parameter is ignored.
        /// </para>
        /// </summary>
        public string DatasetVersion
        {
            get { return this._datasetVersion; }
            set { this._datasetVersion = value; }
        }

        // Check to see if DatasetVersion property is set
        internal bool IsSetDatasetVersion()
        {
            return this._datasetVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of examples to return per page. Default: 1000. Min: 1, max: 1000. Response
        /// size is validated against 5 MB limit after reading. For bulk access to all examples,
        /// use the <c>downloadUrl</c> field from GetDataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        ///  The token for the next page of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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