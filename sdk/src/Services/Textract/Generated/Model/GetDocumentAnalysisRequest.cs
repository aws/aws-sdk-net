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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the GetDocumentAnalysis operation.
    /// Gets the results for an Amazon Textract asynchronous operation that analyzes text
    /// in a document.
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
    ///  <code>GetDocumentAnalysis</code> returns an array of <a>Block</a> objects. The following
    /// types of information are returned: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Form data (key-value pairs). The related information is returned in two <a>Block</a>
    /// objects, each of type <code>KEY_VALUE_SET</code>: a KEY <code>Block</code> object
    /// and a VALUE <code>Block</code> object. For example, <i>Name: Ana Silva Carolina</i>
    /// contains a key and value. <i>Name:</i> is the key. <i>Ana Silva Carolina</i> is the
    /// value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Table and table cell data. A TABLE <code>Block</code> object contains information
    /// about a detected table. A CELL <code>Block</code> object is returned for each cell
    /// in a table.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Lines and words of text. A LINE <code>Block</code> object contains one or more WORD
    /// <code>Block</code> objects. All lines and words that are detected in the document
    /// are returned (including text that doesn't have a relationship with the value of the
    /// <code>StartDocumentAnalysis</code> <code>FeatureTypes</code> input parameter). 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Query. A QUERY Block object contains the query text, alias and link to the associated
    /// Query results block object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Query Results. A QUERY_RESULT Block object contains the answer to the query and an
    /// ID that connects it to the query asked. This Block also contains a confidence score.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// While processing a document with queries, look out for <code>INVALID_REQUEST_PARAMETERS</code>
    /// output. This indicates that either the per page query limit has been exceeded or that
    /// the operation is trying to query a page in the document which doesn’t exist. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Selection elements such as check boxes and option buttons (radio buttons) can be detected
    /// in form data and in tables. A SELECTION_ELEMENT <code>Block</code> object contains
    /// information about a selection element, including the selection status.
    /// </para>
    ///  
    /// <para>
    /// Use the <code>MaxResults</code> parameter to limit the number of blocks that are returned.
    /// If there are more results than specified in <code>MaxResults</code>, the value of
    /// <code>NextToken</code> in the operation response contains a pagination token for getting
    /// the next set of results. To get the next page of results, call <code>GetDocumentAnalysis</code>,
    /// and populate the <code>NextToken</code> request parameter with the token value that's
    /// returned from the previous call to <code>GetDocumentAnalysis</code>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/how-it-works-analyzing.html">Document
    /// Text Analysis</a>.
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
        /// from <code>StartDocumentAnalysis</code>. A <code>JobId</code> value is only valid
        /// for 7 days.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        [AWSProperty(Min=1)]
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
        [AWSProperty(Min=1, Max=255)]
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