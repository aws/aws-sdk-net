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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the ListRunsInBatch operation.
    /// </summary>
    public partial class ListRunsInBatchResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RunBatchListItem> _runs = AWSConfigs.InitializeCollections ? new List<RunBatchListItem>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token to retrieve the next page of results. Absent when the last run
        /// has been returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property Runs. 
        /// <para>
        /// A list of run entries in the batch. See <c>RunBatchListItem</c>.
        /// </para>
        /// </summary>
        public List<RunBatchListItem> Runs
        {
            get { return this._runs; }
            set { this._runs = value; }
        }

        // Check to see if Runs property is set
        internal bool IsSetRuns()
        {
            return this._runs != null && (this._runs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}