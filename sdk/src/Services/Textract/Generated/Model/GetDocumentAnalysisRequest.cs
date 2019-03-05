/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the GetDocumentAnalysis operation.
    /// Gets the results for an Amazon Textract asynchronous operation that analyzes text
    /// in a document image.
    /// 
    ///  
    /// <para>
    /// You start asynchronous text analysis by calling <a>StartDocumentAnalysis</a>, which
    /// returns a job identifier (<code>JobId</code>). When the text analysis operation finishes,
    /// Amazon Textract publishes a completion status to the Amazon Simple Notification Service
    /// (Amazon SNS) topic that's registered in the initial call to <code>StartDocumentAnalysis</code>.
    /// To get the results of the text-detection operation, first check that the status value
    /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <code>GetDocumentAnalysis</code>,
    /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartDocumentAnalysis</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>GetDocumentAnalysis</code> returns an array of <a>Block</a> objects. For more
    /// information, see <a>how-it-works-analyzing</a>.
    /// </para>
    ///  
    /// <para>
    /// Use the <code>MaxResults</code> parameter to limit the number of blocks returned.
    /// If there are more results than specified in <code>MaxResults</code>, the value of
    /// <code>NextToken</code> in the operation response contains a pagination token for getting
    /// the next set of results. To get the next page of results, call <code>GetDocumentAnalysis</code>,
    /// and populate the <code>NextToken</code> request parameter with the token value that's
    /// returned from the previous call to <code>GetDocumentAnalysis</code>.
    /// </para>
    /// </summary>
    public partial class GetDocumentAnalysisRequest : AmazonTextractRequest
    {
        private string _jobId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// A unique identifier for the text-detection job. The <code>JobId</code> is returned
        /// from <code>StartDocumentAnalysis</code>.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per paginated call. The largest value that
        /// you can specify is 1,000. If you specify a value greater than 1,000, a maximum of
        /// 1,000 results is returned. The default value is 1,000.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// If the previous response was incomplete (because there are more blocks to retrieve),
        /// Amazon Textract returns a pagination token in the response. You can use this pagination
        /// token to retrieve the next set of blocks.
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