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
    /// Container for the parameters to the GetLendingAnalysis operation.
    /// Gets the results for an Amazon Textract asynchronous operation that analyzes text
    /// in a lending document. 
    /// 
    ///  
    /// <para>
    /// You start asynchronous text analysis by calling <code>StartLendingAnalysis</code>,
    /// which returns a job identifier (<code>JobId</code>). When the text analysis operation
    /// finishes, Amazon Textract publishes a completion status to the Amazon Simple Notification
    /// Service (Amazon SNS) topic that's registered in the initial call to <code>StartLendingAnalysis</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// To get the results of the text analysis operation, first check that the status value
    /// published to the Amazon SNS topic is SUCCEEDED. If so, call GetLendingAnalysis, and
    /// pass the job identifier (<code>JobId</code>) from the initial call to <code>StartLendingAnalysis</code>.
    /// </para>
    /// </summary>
    public partial class GetLendingAnalysisRequest : AmazonTextractRequest
    {
        private string _jobId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// A unique identifier for the lending or text-detection job. The <code>JobId</code>
        /// is returned from <code>StartLendingAnalysis</code>. A <code>JobId</code> value is
        /// only valid for 7 days.
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
        /// you can specify is 30. If you specify a value greater than 30, a maximum of 30 results
        /// is returned. The default value is 30.
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
        /// If the previous response was incomplete, Amazon Textract returns a pagination token
        /// in the response. You can use this pagination token to retrieve the next set of lending
        /// results.
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