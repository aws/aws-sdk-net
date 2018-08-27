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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Signer.Model
{
    /// <summary>
    /// Container for the parameters to the ListSigningJobs operation.
    /// Lists all your signing jobs. You can use the <code>maxResults</code> parameter to
    /// limit the number of signing jobs that are returned in the response. If additional
    /// jobs remain to be listed, AWS Signer returns a <code>nextToken</code> value. Use this
    /// value in subsequent calls to <code>ListSigningJobs</code> to fetch the remaining values.
    /// You can continue calling <code>ListSigningJobs</code> with your <code>maxResults</code>
    /// parameter and with new values that AWS Signer returns in the <code>nextToken</code>
    /// parameter until all of your signing jobs have been returned.
    /// </summary>
    public partial class ListSigningJobsRequest : AmazonSignerRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _platformId;
        private string _requestedBy;
        private SigningStatus _status;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of items to return in the response. Use this parameter
        /// when paginating results. If additional items exist beyond the number you specify,
        /// the <code>nextToken</code> element is set in the response. Use the <code>nextToken</code>
        /// value in a subsequent request to retrieve additional items. 
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
        /// String for specifying the next set of paginated results to return. After you receive
        /// a response with truncated results, use this parameter in a subsequent request. Set
        /// it to the value of <code>nextToken</code> from the response that you just received.
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

        /// <summary>
        /// Gets and sets the property PlatformId. 
        /// <para>
        /// The ID of microcontroller platform that you specified for the distribution of your
        /// code image.
        /// </para>
        /// </summary>
        public string PlatformId
        {
            get { return this._platformId; }
            set { this._platformId = value; }
        }

        // Check to see if PlatformId property is set
        internal bool IsSetPlatformId()
        {
            return this._platformId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedBy. 
        /// <para>
        /// The IAM principal that requested the signing job.
        /// </para>
        /// </summary>
        public string RequestedBy
        {
            get { return this._requestedBy; }
            set { this._requestedBy = value; }
        }

        // Check to see if RequestedBy property is set
        internal bool IsSetRequestedBy()
        {
            return this._requestedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status value with which to filter your results.
        /// </para>
        /// </summary>
        public SigningStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}