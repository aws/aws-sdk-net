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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the ListJobs operation.
    /// Lists current jobs and jobs that have ended within the last 30 days for the AWS account
    /// making the request.
    /// </summary>
    public partial class ListJobsRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private List<string> _jobStatuses = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountId.
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatuses. 
        /// <para>
        /// The <code>List Jobs</code> request returns jobs that match the statuses listed in
        /// this element.
        /// </para>
        /// </summary>
        public List<string> JobStatuses
        {
            get { return this._jobStatuses; }
            set { this._jobStatuses = value; }
        }

        // Check to see if JobStatuses property is set
        internal bool IsSetJobStatuses()
        {
            return this._jobStatuses != null && this._jobStatuses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of jobs that Amazon S3 will include in the <code>List Jobs</code>
        /// response. If there are more jobs than this number, the response will include a pagination
        /// token in the <code>NextToken</code> field to enable you to retrieve the next page
        /// of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// A pagination token to request the next page of results. Use the token that Amazon
        /// S3 returned in the <code>NextToken</code> element of the <code>ListJobsResult</code>
        /// from the previous <code>List Jobs</code> request.
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