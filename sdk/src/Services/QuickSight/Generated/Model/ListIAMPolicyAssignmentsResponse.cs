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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the ListIAMPolicyAssignments operation.
    /// </summary>
    public partial class ListIAMPolicyAssignmentsResponse : AmazonWebServiceResponse
    {
        private List<IAMPolicyAssignmentSummary> _iamPolicyAssignments = new List<IAMPolicyAssignmentSummary>();
        private string _nextToken;
        private string _requestId;
        private int? _status;

        /// <summary>
        /// Gets and sets the property IAMPolicyAssignments. 
        /// <para>
        /// Information describing the IAM policy assignments.
        /// </para>
        /// </summary>
        public List<IAMPolicyAssignmentSummary> IAMPolicyAssignments
        {
            get { return this._iamPolicyAssignments; }
            set { this._iamPolicyAssignments = value; }
        }

        // Check to see if IAMPolicyAssignments property is set
        internal bool IsSetIAMPolicyAssignments()
        {
            return this._iamPolicyAssignments != null && this._iamPolicyAssignments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or null if there are no more results.
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
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The AWS request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int Status
        {
            get { return this._status.GetValueOrDefault(); }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

    }
}