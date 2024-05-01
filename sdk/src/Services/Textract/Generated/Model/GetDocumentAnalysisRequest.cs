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

#pragma warning disable CS0612,CS0618,CS1570
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
    /// returns a job identifier (<c>JobId</c>). When the text analysis operation finishes,
    /// Amazon Textract publishes a completion status to the Amazon Simple Notification Service
    /// (Amazon SNS) topic that's registered in the initial call to <c>StartDocumentAnalysis</c>.
    /// To get the results of the text-detection operation, first check that the status value
    /// published to the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <c>GetDocumentAnalysis</c>,
    /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartDocumentAnalysis</c>.
    /// </para>
    ///  
    /// <para>
    ///  <c>GetDocumentAnalysis</c> returns an array of <a>Block</a> objects. The following
    /// types of information are returned: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Form data (key-value pairs). The related information is returned in two <a>Block</a>
    /// objects, each of type <c>KEY_VALUE_SET</c>: a KEY <c>Block</c> object and a VALUE
    /// <c>Block</c> object. For example, <i>Name: Ana Silva Carolina</i> contains a key and
    /// value. <i>Name:</i> is the key. <i>Ana Silva Carolina</i> is the value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Table and table cell data. A TABLE <c>Block</c> object contains information about
    /// a detected table. A CELL <c>Block</c> object is returned for each cell in a table.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Lines and words of text. A LINE <c>Block</c> object contains one or more WORD <c>Block</c>
    /// objects. All lines and words that are detected in the document are returned (including
    /// text that doesn't have a relationship with the value of the <c>StartDocumentAnalysis</c>
    /// <c>FeatureTypes</c> input parameter). 
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
    /// While processing a document with queries, look out for <c>INVALID_REQUEST_PARAMETERS</c>
    /// output. This indicates that either the per page query limit has been exceeded or that
    /// the operation is trying to query a page in the document which doesn’t exist. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Selection elements such as check boxes and option buttons (radio buttons) can be detected
    /// in form data and in tables. A SELECTION_ELEMENT <c>Block</c> object contains information
    /// about a selection element, including the selection status.
    /// </para>
    ///  
    /// <para>
    /// Use the <c>MaxResults</c> parameter to limit the number of blocks that are returned.
    /// If there are more results than specified in <c>MaxResults</c>, the value of <c>NextToken</c>
    /// in the operation response contains a pagination token for getting the next set of
    /// results. To get the next page of results, call <c>GetDocumentAnalysis</c>, and populate
    /// the <c>NextToken</c> request parameter with the token value that's returned from the
    /// previous call to <c>GetDocumentAnalysis</c>.
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
        /// A unique identifier for the text-detection job. The <c>JobId</c> is returned from
        /// <c>StartDocumentAnalysis</c>. A <c>JobId</c> value is only valid for 7 days.
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
        /// If the previous response was incomplete (because there are more blocks to retrieve),
        /// Amazon Textract returns a pagination token in the response. You can use this pagination
        /// token to retrieve the next set of blocks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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