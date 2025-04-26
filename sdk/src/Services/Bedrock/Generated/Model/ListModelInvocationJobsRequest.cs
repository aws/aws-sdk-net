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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the ListModelInvocationJobs operation.
    /// Lists all batch inference jobs in the account. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-view.html">View
    /// details about a batch inference job</a>.
    /// </summary>
    public partial class ListModelInvocationJobsRequest : AmazonBedrockRequest
    {
        private int? _maxResults;
        private string _nameContains;
        private string _nextToken;
        private SortJobsBy _sortBy;
        private SortOrder _sortOrder;
        private ModelInvocationJobStatus _statusEquals;
        private DateTime? _submitTimeAfter;
        private DateTime? _submitTimeBefore;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return. If there are more results than the number
        /// that you specify, a <c>nextToken</c> value is returned. Use the <c>nextToken</c> in
        /// a request to return the next batch of results.
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
        /// Gets and sets the property NameContains. 
        /// <para>
        /// Specify a string to filter for batch inference jobs whose names contain the string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string NameContains
        {
            get { return this._nameContains; }
            set { this._nameContains = value; }
        }

        // Check to see if NameContains property is set
        internal bool IsSetNameContains()
        {
            return this._nameContains != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there were more results than the value you specified in the <c>maxResults</c> field
        /// in a previous <c>ListModelInvocationJobs</c> request, the response would have returned
        /// a <c>nextToken</c> value. To see the next batch of results, send the <c>nextToken</c>
        /// value in another request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property SortBy. 
        /// <para>
        /// An attribute by which to sort the results.
        /// </para>
        /// </summary>
        public SortJobsBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specifies whether to sort the results by ascending or descending order.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// Specify a status to filter for batch inference jobs whose statuses match the string
        /// you specify.
        /// </para>
        ///  
        /// <para>
        /// The following statuses are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Submitted – This job has been submitted to a queue for validation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Validating – This job is being validated for the requirements described in <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-data.html">Format
        /// and upload your batch inference data</a>. The criteria include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your IAM service role has access to the Amazon S3 buckets containing your files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your files are .jsonl files and each individual record is a JSON object in the correct
        /// format. Note that validation doesn't check if the <c>modelInput</c> value matches
        /// the request body for the model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your files fulfill the requirements for file size and number of records. For more
        /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/quotas.html">Quotas
        /// for Amazon Bedrock</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Scheduled – This job has been validated and is now in a queue. The job will automatically
        /// start when it reaches its turn.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Expired – This job timed out because it was scheduled but didn't begin before the
        /// set timeout duration. Submit a new job request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InProgress – This job has begun. You can start viewing the results in the output S3
        /// location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Completed – This job has successfully completed. View the output files in the output
        /// S3 location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PartiallyCompleted – This job has partially completed. Not all of your records could
        /// be processed in time. View the output files in the output S3 location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed – This job has failed. Check the failure message for any further details. For
        /// further assistance, reach out to the <a href="https://console.aws.amazon.com/support/home/">Amazon
        /// Web ServicesSupport Center</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stopped – This job was stopped by a user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stopping – This job is being stopped by a user.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ModelInvocationJobStatus StatusEquals
        {
            get { return this._statusEquals; }
            set { this._statusEquals = value; }
        }

        // Check to see if StatusEquals property is set
        internal bool IsSetStatusEquals()
        {
            return this._statusEquals != null;
        }

        /// <summary>
        /// Gets and sets the property SubmitTimeAfter. 
        /// <para>
        /// Specify a time to filter for batch inference jobs that were submitted after the time
        /// you specify.
        /// </para>
        /// </summary>
        public DateTime? SubmitTimeAfter
        {
            get { return this._submitTimeAfter; }
            set { this._submitTimeAfter = value; }
        }

        // Check to see if SubmitTimeAfter property is set
        internal bool IsSetSubmitTimeAfter()
        {
            return this._submitTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubmitTimeBefore. 
        /// <para>
        /// Specify a time to filter for batch inference jobs that were submitted before the time
        /// you specify.
        /// </para>
        /// </summary>
        public DateTime? SubmitTimeBefore
        {
            get { return this._submitTimeBefore; }
            set { this._submitTimeBefore = value; }
        }

        // Check to see if SubmitTimeBefore property is set
        internal bool IsSetSubmitTimeBefore()
        {
            return this._submitTimeBefore.HasValue; 
        }

    }
}