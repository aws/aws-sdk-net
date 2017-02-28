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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssignmentsForHIT operation.
    /// The <code>ListAssignmentsForHIT</code> operation retrieves completed assignments
    /// for a HIT. You can use this operation to retrieve the results for a HIT. 
    /// 
    ///  
    /// <para>
    ///  You can get assignments for a HIT at any time, even if the HIT is not yet Reviewable.
    /// If a HIT requested multiple assignments, and has received some results but has not
    /// yet become Reviewable, you can still retrieve the partial results with this operation.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  Use the AssignmentStatus parameter to control which set of assignments for a HIT
    /// are returned. The ListAssignmentsForHIT operation can return submitted assignments
    /// awaiting approval, or it can return assignments that have already been approved or
    /// rejected. You can set AssignmentStatus=Approved,Rejected to get assignments that have
    /// already been approved and rejected together in one result set. 
    /// </para>
    ///  
    /// <para>
    ///  Only the Requester who created the HIT can retrieve the assignments for that HIT.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  Results are sorted and divided into numbered pages and the operation returns a single
    /// page of results. You can use the parameters of the operation to control sorting and
    /// pagination. 
    /// </para>
    /// </summary>
    public partial class ListAssignmentsForHITRequest : AmazonMTurkRequest
    {
        private List<string> _assignmentStatuses = new List<string>();
        private string _hitId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AssignmentStatuses. 
        /// <para>
        /// The status of the assignments to return: Submitted | Approved | Rejected
        /// </para>
        /// </summary>
        public List<string> AssignmentStatuses
        {
            get { return this._assignmentStatuses; }
            set { this._assignmentStatuses = value; }
        }

        // Check to see if AssignmentStatuses property is set
        internal bool IsSetAssignmentStatuses()
        {
            return this._assignmentStatuses != null && this._assignmentStatuses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        /// The ID of the HIT.
        /// </para>
        /// </summary>
        public string HITId
        {
            get { return this._hitId; }
            set { this._hitId = value; }
        }

        // Check to see if HITId property is set
        internal bool IsSetHITId()
        {
            return this._hitId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
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
        /// Pagination token
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