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
    /// Container for the parameters to the GetLendingAnalysisSummary operation.
    /// Gets summarized results for the <code>StartLendingAnalysis</code> operation, which
    /// analyzes text in a lending document. The returned summary consists of information
    /// about documents grouped together by a common document type. Information like detected
    /// signatures, page numbers, and split documents is returned with respect to the type
    /// of grouped document. 
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
    /// published to the Amazon SNS topic is SUCCEEDED. If so, call <code>GetLendingAnalysisSummary</code>,
    /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartLendingAnalysis</code>.
    /// </para>
    /// </summary>
    public partial class GetLendingAnalysisSummaryRequest : AmazonTextractRequest
    {
        private string _jobId;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        ///  A unique identifier for the lending or text-detection job. The <code>JobId</code>
        /// is returned from StartLendingAnalysis. A <code>JobId</code> value is only valid for
        /// 7 days.
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

    }
}