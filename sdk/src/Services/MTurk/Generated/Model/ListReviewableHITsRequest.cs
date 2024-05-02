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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the ListReviewableHITs operation.
    /// The <c>ListReviewableHITs</c> operation retrieves the HITs with Status equal to Reviewable
    /// or Status equal to Reviewing that belong to the Requester calling the operation.
    /// </summary>
    public partial class ListReviewableHITsRequest : AmazonMTurkRequest
    {
        private string _hitTypeId;
        private int? _maxResults;
        private string _nextToken;
        private ReviewableHITStatus _status;

        /// <summary>
        /// Gets and sets the property HITTypeId. 
        /// <para>
        ///  The ID of the HIT type of the HITs to consider for the query. If not specified, all
        /// HITs for the Reviewer are considered 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string HITTypeId
        {
            get { return this._hitTypeId; }
            set { this._hitTypeId = value; }
        }

        // Check to see if HITTypeId property is set
        internal bool IsSetHITTypeId()
        {
            return this._hitTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  Limit the number of results returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Pagination Token
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Can be either <c>Reviewable</c> or <c>Reviewing</c>. Reviewable is the default value.
        /// 
        /// </para>
        /// </summary>
        public ReviewableHITStatus Status
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